using Microsoft.AspNetCore.Mvc;
using NHibernate;
using SelekcijaKandidata.Entiteti;
using SelekcijaKandidataWebAPI.DTOs;

namespace SelekcijaKandidataWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZaposleniController : ControllerBase
    {
        /// <summary>
        /// Pribavlja sve zaposlene.
        /// GET: api/zaposleni
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<ZaposleniView>> GetAll()
        {
            try
            {
                using (NHibernate.ISession session = DataLayer.GetSession())
                {
                    var zaposleni = session.Query<Zaposleni>()
                        .ToList()
                        .Select(z => new ZaposleniView
                        {
                            Id = z.Id,
                            Ime = z.Ime,
                            Prezime = z.Prezime
                        })
                        .OrderBy(z => z.Id)
                        .ToList();

                    return Ok(zaposleni);
                }
            }
            catch (Exception ex)
            {
                var errorDetails = GetDetailedErrorMessage(ex);
                return StatusCode(500, new { message = "Greška pri pribavljanju zaposlenih.", error = errorDetails });
            }
        }

        /// <summary>
        /// Pribavlja jednog zaposlenog po ID-u.
        /// GET: api/zaposleni/{id}
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<ZaposleniView> GetById(int id)
        {
            try
            {
                using (NHibernate.ISession session = DataLayer.GetSession())
                {
                    var zaposleni = session.Get<Zaposleni>(id);

                    if (zaposleni == null)
                        return NotFound(new { message = $"Zaposleni sa ID-om {id} nije pronađen." });

                    var dto = new ZaposleniView
                    {
                        Id = zaposleni.Id,
                        Ime = zaposleni.Ime,
                        Prezime = zaposleni.Prezime
                    };

                    return Ok(dto);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Greška pri pribavljanju zaposlenog.", error = ex.Message });
            }
        }

        /// <summary>
        /// Dodaje novog zaposlenog.
        /// POST: api/zaposleni
        /// </summary>
        [HttpPost]
        public ActionResult<ZaposleniView> Create([FromBody] ZaposleniView dto)
        {
            try
            {
                if (dto == null || string.IsNullOrWhiteSpace(dto.Ime) || string.IsNullOrWhiteSpace(dto.Prezime))
                    return BadRequest(new { message = "Ime i prezime su obavezni." });

                using (NHibernate.ISession session = DataLayer.GetSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        var zaposleni = new Zaposleni
                        {
                            Ime = dto.Ime,
                            Prezime = dto.Prezime
                        };

                        session.Save(zaposleni);
                        transaction.Commit();

                        dto.Id = zaposleni.Id;
                        return CreatedAtAction(nameof(GetById), new { id = dto.Id }, dto);
                    }
                    catch
                    {
                        if (transaction.IsActive)
                            transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Greška pri dodavanju zaposlenog.", error = ex.Message });
            }
        }

        /// <summary>
        /// Ažurira postojećeg zaposlenog.
        /// PUT: api/zaposleni/{id}
        /// </summary>
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ZaposleniView dto)
        {
            try
            {
                if (dto == null || string.IsNullOrWhiteSpace(dto.Ime) || string.IsNullOrWhiteSpace(dto.Prezime))
                    return BadRequest(new { message = "Ime i prezime su obavezni." });

                using (NHibernate.ISession session = DataLayer.GetSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        var zaposleni = session.Get<Zaposleni>(id);

                        if (zaposleni == null)
                            return NotFound(new { message = $"Zaposleni sa ID-om {id} nije pronađen." });

                        zaposleni.Ime = dto.Ime;
                        zaposleni.Prezime = dto.Prezime;

                        session.Update(zaposleni);
                        transaction.Commit();

                        return Ok(new { message = "Zaposleni je uspešno ažuriran." });
                    }
                    catch
                    {
                        if (transaction.IsActive)
                            transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Greška pri ažuriranju zaposlenog.", error = ex.Message });
            }
        }

        /// <summary>
        /// Briše zaposlenog.
        /// DELETE: api/zaposleni/{id}
        /// </summary>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                using (NHibernate.ISession session = DataLayer.GetSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        var zaposleni = session.Get<Zaposleni>(id);

                        if (zaposleni == null)
                            return NotFound(new { message = $"Zaposleni sa ID-om {id} nije pronađen." });

                        // Proveravamo da li zaposleni ima povezane intervjue ili prakse gde je mentor
                        bool imaIntervjue = session.Query<Intervju>().Any(i => i.Zaposleni.Id == id);
                        bool jeMentor = session.Query<Praksa>().Any(p => p.Mentor.Id == id);

                        if (imaIntervjue || jeMentor)
                        {
                            return BadRequest(new 
                            { 
                                message = "Ne mozete obrisati zaposlenog dok postoje povezani intervjui ili prakse gde je mentor." 
                            });
                        }

                        session.Delete(zaposleni);
                        transaction.Commit();

                        return Ok(new { message = "Zaposleni je uspešno obrisan." });
                    }
                    catch
                    {
                        if (transaction.IsActive)
                            transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Greška pri brisanju zaposlenog.", error = ex.Message });
            }
        }

        private string GetDetailedErrorMessage(Exception ex)
        {
            var messages = new List<string>();
            var current = ex;

            while (current != null)
            {
                messages.Add($"{current.GetType().Name}: {current.Message}");
                current = current.InnerException;
            }

            return string.Join(" -> ", messages);
        }
    }
}

