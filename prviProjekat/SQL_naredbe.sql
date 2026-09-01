DROP TABLE NAPOMENA_INTERVJU;
DROP TABLE ZAHTEVI_OGLAS;
DROP TABLE ODLUKA;
DROP TABLE TEST;
DROP TABLE INTERVJU;
DROP TABLE CV;
DROP TABLE PRAKSA;
DROP TABLE SEZONSKI_OGLAS;
DROP TABLE PRIVREMENI_OGLAS;
DROP TABLE STALNI_OGLAS;
DROP TABLE OGLAS;
DROP TABLE ZAPOSLENI;

CREATE TABLE ZAPOSLENI (
    id INT PRIMARY KEY,
    ime VARCHAR2(50) NOT NULL,
    prezime VARCHAR2(50) NOT NULL
);

CREATE TABLE OGLAS (
    id INT PRIMARY KEY,
    naziv_pozicije VARCHAR2(100) NOT NULL,
    vrsta_oglasa VARCHAR2(30) NOT NULL CHECK (
        vrsta_oglasa IN ('stalni rad', 'privremeni rad', 'sezonski rad', 'praksa')
    ),
    opis VARCHAR2(100),
    min_plata NUMERIC,
    max_plata NUMERIC,
    datum_objave DATE NOT NULL,
    datum_zatvaranja DATE,
    status VARCHAR2(20) NOT NULL CHECK (
        status IN ('aktivan', 'zatvoren', 'u toku selekcije')
    ),
    CHECK (datum_zatvaranja IS NULL OR datum_zatvaranja >= datum_objave),
    CHECK (max_plata IS NULL OR min_plata IS NULL OR max_plata >= min_plata)
);

CREATE TABLE CV (
    id INT PRIMARY KEY,
    ime VARCHAR2(30) NOT NULL,
    prezime VARCHAR2(30) NOT NULL,
    email VARCHAR2(50) NOT NULL,
    datum_podnosenja DATE NOT NULL,
    status VARCHAR2(20) NOT NULL CHECK (
        status IN ('primljen', 'u procesu', 'odbijen', 'pozvan na intervju')
    ),
    broj_telefona VARCHAR2(20) NOT NULL,
    id_oglasa INT NOT NULL REFERENCES OGLAS(id)
);

CREATE TABLE STALNI_OGLAS (
    id INT PRIMARY KEY REFERENCES OGLAS(id) ON DELETE CASCADE
);

CREATE TABLE PRIVREMENI_OGLAS (
    id INT PRIMARY KEY REFERENCES OGLAS(id) ON DELETE CASCADE,
    projekat VARCHAR2(100) NOT NULL,
    period_angazovanja VARCHAR2(100) NOT NULL
);

CREATE TABLE SEZONSKI_OGLAS (
    id INT PRIMARY KEY REFERENCES OGLAS(id) ON DELETE CASCADE,
    sezona VARCHAR2(30) NOT NULL,
    lokacija VARCHAR2(50) NOT NULL
);

CREATE TABLE PRAKSA (
    id INT PRIMARY KEY REFERENCES OGLAS(id) ON DELETE CASCADE,
    trajanje_meseci INT NOT NULL CHECK (Trajanje_meseci > 0),
    id_zaposlenog INT NOT NULL REFERENCES ZAPOSLENI(id)
);

CREATE TABLE INTERVJU (
    id INT PRIMARY KEY,
    tip VARCHAR2(20) NOT NULL CHECK(
        tip IN ('licni', 'video', 'telefonski')
    ),
    datum_i_vreme DATE NOT NULL,
    lokacija VARCHAR2(100) NOT NULL,
    ocena INT,
    id_CV INT NOT NULL REFERENCES CV(id),
    id_zaposlenog INT NOT NULL REFERENCES ZAPOSLENI(id)
);

CREATE TABLE ODLUKA (
    id INT PRIMARY KEY,
    datum DATE NOT NULL,
    pocetak_rada DATE,
    prihvaceno NUMBER(1,0),
    status VARCHAR2(20) NOT NULL CHECK (
        status IN ('izabran', 'odbijen', 'rezerva', 'na cekanju')
    ),
    plata NUMERIC,
    razlog_odbijanja VARCHAR2(50),
    id_CV INT NOT NULL UNIQUE REFERENCES CV(id),
    CHECK(
        (prihvaceno = 1 AND pocetak_rada IS NOT NULL AND razlog_odbijanja IS NULL) OR
        (prihvaceno = 0 AND pocetak_rada IS NULL AND razlog_odbijanja IS NOT NULL) OR
        (prihvaceno IS NULL AND pocetak_rada IS NULL AND razlog_odbijanja IS NULL)
    )
);

CREATE TABLE TEST (
    id INT PRIMARY KEY,
    datum DATE NOT NULL,
    vrsta VARCHAR2(100) NOT NULL,
    rezultat INT,
    komentar VARCHAR2(50),
    id_CV INT NOT NULL REFERENCES CV(id)
);

CREATE TABLE ZAHTEVI_OGLAS (
    id INT NOT NULL REFERENCES OGLAS(id),
    zahtev VARCHAR2(30) NOT NULL,
    PRIMARY KEY (id, zahtev)
);

CREATE TABLE NAPOMENA_INTERVJU (
    id INT NOT NULL REFERENCES INTERVJU(id),
    napomena VARCHAR2(100) NOT NULL,
    PRIMARY KEY (id, napomena)
);