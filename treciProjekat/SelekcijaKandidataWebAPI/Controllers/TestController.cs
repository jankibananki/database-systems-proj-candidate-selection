using Microsoft.AspNetCore.Mvc;
using NHibernate;
using SelekcijaKandidata.Entiteti;
using SelekcijaKandidataWebAPI.DTOs;

namespace SelekcijaKandidataWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                using (NHibernate.ISession session = DataLayer.GetSession())
                {
                    var testovi = session.Query<Test>()
                    .ToList()
                    .Select(t => new TestView
                    {
                        Id = t.Id,
                        Datum = t.Datum,
                        Vrsta = t.Vrsta,
                        Rezultat = t.Rezultat,
                        Komentar = t.Komentar,
                        CVId = t.CV.Id
                    })
                    .OrderBy(t => t.Id)
                    .ToList();

                    return Ok(testovi);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Greška pri pribavljanju testova.", error = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                using (NHibernate.ISession session = DataLayer.GetSession())
                {
                    var test = session.Get<Test>(id);
                    if (test == null)
                    {
                        return NotFound(new { message = $"Greška pri pribavljanju testa sa id: {id}." });
                    }

                    var dto = new TestView
                    {
                        Id = test.Id,
                        Datum = test.Datum,
                        Vrsta = test.Vrsta,
                        Rezultat = test.Rezultat,
                        Komentar = test.Komentar,
                        CVId = test.CV.Id
                    };
                    return Ok(dto);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Greška pri pribavljanju testa", error = ex.Message });
            }

        }

        [HttpPost]
        public IActionResult Create([FromBody] TestView dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.Vrsta) || string.IsNullOrWhiteSpace(dto.Komentar))
            {
                return BadRequest(new { message = "Vrsta testa i komentar su obavezni." });
            }
            if (dto.CVId <= 0)
            {
                return BadRequest(new { message = "CVId mora biti validan." });
            }

            try
            {
                using (NHibernate.ISession session = DataLayer.GetSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        var cv = session.Get<CV>(dto.CVId);

                        if (cv == null)
                        {
                            return BadRequest(new { message = $"CV sa ID-om {dto.CVId} ne postoji." });
                        }

                        var test = new Test
                        {
                            Datum = dto.Datum,
                            Vrsta = dto.Vrsta,
                            Rezultat = dto.Rezultat,
                            Komentar = dto.Komentar,
                            CV = cv
                        };

                        session.Save(test);
                        transaction.Commit();

                        dto.Id = test.Id;
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
                return StatusCode(500, new { message = "Greška pri dodavanju testa.", error = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] TestView dto)
        {
            if (dto == null || string.IsNullOrWhiteSpace(dto.Vrsta) || string.IsNullOrWhiteSpace(dto.Komentar))
            {
                return BadRequest(new { message = "Vrsta testa i komentar su obavezni." });
            }

            if (dto.CVId <= 0)
            {
                return BadRequest(new { message = "CVId mora biti validan." });
            }

            try
            {
                using (NHibernate.ISession session = DataLayer.GetSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        var test = session.Get<Test>(id);

                        if (test == null)
                        {
                            return NotFound(new { message = $"Test sa ID-om {id} nije pronađen." });
                        }

                        var cv = session.Get<CV>(dto.CVId);
                        if (cv == null)
                        {
                            return BadRequest(new { message = $"CV sa ID-om {dto.CVId} ne postoji." });
                        }

                        test.Datum = dto.Datum;
                        test.Vrsta = dto.Vrsta;
                        test.Rezultat = dto.Rezultat;
                        test.Komentar = dto.Komentar;
                        test.CV = cv;


                        session.Update(test);
                        transaction.Commit();

                        return Ok(new { message = "Test je uspešno ažuriran." });
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
                return StatusCode(500, new { message = "Greška pri ažuriranju testa.", error = ex.Message });
            }
        }

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
                        var test = session.Get<Test>(id);

                        if (test == null)
                            return NotFound(new { message = $"Test sa ID-om {id} nije pronađen." });

                        session.Delete(test);
                        transaction.Commit();

                        return Ok(new { message = "Test je uspešno obrisan." });
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
                return StatusCode(500, new { message = "Greška pri brisanju Testa.", error = ex.Message });
            }
        }

    }

}