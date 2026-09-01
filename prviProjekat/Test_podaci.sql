INSERT INTO ZAPOSLENI VALUES (1, 'Marko', 'Petrovic');
INSERT INTO ZAPOSLENI VALUES (2, 'Jelena', 'Jovanovic');
INSERT INTO ZAPOSLENI VALUES (3, 'Nikola', 'Nikolic');
INSERT INTO ZAPOSLENI VALUES (4, 'Ana', 'Stojanovic');
INSERT INTO ZAPOSLENI VALUES (5, 'Milan', 'Ilic');
INSERT INTO ZAPOSLENI VALUES (6, 'Sara', 'Djordjevic');

INSERT INTO OGLAS VALUES (
    1, 'Java Developer', 'stalni rad',
    'Razvoj backend aplikacija',
    90000, 160000,
    TO_DATE('2026-08-01', 'YYYY-MM-DD'),
    TO_DATE('2026-09-15', 'YYYY-MM-DD'),
    'aktivan'
);

INSERT INTO OGLAS VALUES (
    2, 'Frontend Developer', 'stalni rad',
    'React frontend developer',
    85000, 150000,
    TO_DATE('2026-08-03', 'YYYY-MM-DD'),
    TO_DATE('2026-09-20', 'YYYY-MM-DD'),
    'aktivan'
);

INSERT INTO OGLAS VALUES (
    3, 'QA Tester', 'privremeni rad',
    'Testiranje web aplikacija',
    70000, 110000,
    TO_DATE('2026-07-15', 'YYYY-MM-DD'),
    TO_DATE('2026-09-01', 'YYYY-MM-DD'),
    'u toku selekcije'
);

INSERT INTO OGLAS VALUES (
    4, 'Data Analyst', 'privremeni rad',
    'Analiza poslovnih podataka',
    80000, 130000,
    TO_DATE('2026-07-20', 'YYYY-MM-DD'),
    TO_DATE('2026-09-10', 'YYYY-MM-DD'),
    'u toku selekcije'
);

INSERT INTO OGLAS VALUES (
    5, 'Letnji IT Asistent', 'sezonski rad',
    'IT podrska tokom letnje sezone',
    65000, 90000,
    TO_DATE('2026-06-01', 'YYYY-MM-DD'),
    TO_DATE('2026-07-01', 'YYYY-MM-DD'),
    'zatvoren'
);

INSERT INTO OGLAS VALUES (
    6, 'Zimski IT Asistent', 'sezonski rad',
    'IT podrska tokom zimske sezone',
    65000, 95000,
    TO_DATE('2026-08-10', 'YYYY-MM-DD'),
    TO_DATE('2026-10-15', 'YYYY-MM-DD'),
    'aktivan'
);

INSERT INTO OGLAS VALUES (
    7, 'Backend praksa', 'praksa',
    'Praksa za backend development',
    NULL, NULL,
    TO_DATE('2026-08-05', 'YYYY-MM-DD'),
    TO_DATE('2026-09-30', 'YYYY-MM-DD'),
    'aktivan'
);

INSERT INTO OGLAS VALUES (
    8, 'Frontend praksa', 'praksa',
    'Praksa za frontend development',
    NULL, NULL,
    TO_DATE('2026-08-05', 'YYYY-MM-DD'),
    TO_DATE('2026-09-30', 'YYYY-MM-DD'),
    'aktivan'
);

INSERT INTO STALNI_OGLAS VALUES (1);
INSERT INTO STALNI_OGLAS VALUES (2);

INSERT INTO PRIVREMENI_OGLAS VALUES (3, 'Web Shop projekat', '6 meseci');
INSERT INTO PRIVREMENI_OGLAS VALUES (4, 'Analitika prodaje', '4 meseca');

INSERT INTO SEZONSKI_OGLAS VALUES (5, 'leto', 'Nis');
INSERT INTO SEZONSKI_OGLAS VALUES (6, 'zima', 'Kopaonik');

INSERT INTO PRAKSA VALUES (7, 3, 1);
INSERT INTO PRAKSA VALUES (8, 6, 2);

INSERT INTO ZAHTEVI_OGLAS VALUES (1, 'Java');
INSERT INTO ZAHTEVI_OGLAS VALUES (1, 'SQL');
INSERT INTO ZAHTEVI_OGLAS VALUES (1, 'Spring');
INSERT INTO ZAHTEVI_OGLAS VALUES (2, 'React');
INSERT INTO ZAHTEVI_OGLAS VALUES (2, 'JavaScript');
INSERT INTO ZAHTEVI_OGLAS VALUES (2, 'CSS');
INSERT INTO ZAHTEVI_OGLAS VALUES (3, 'Testiranje');
INSERT INTO ZAHTEVI_OGLAS VALUES (3, 'Selenium');
INSERT INTO ZAHTEVI_OGLAS VALUES (4, 'SQL');
INSERT INTO ZAHTEVI_OGLAS VALUES (4, 'Excel');
INSERT INTO ZAHTEVI_OGLAS VALUES (5, 'Osnove racunara');
INSERT INTO ZAHTEVI_OGLAS VALUES (6, 'Mreze');
INSERT INTO ZAHTEVI_OGLAS VALUES (7, 'CSharp');
INSERT INTO ZAHTEVI_OGLAS VALUES (7, 'Baze');
INSERT INTO ZAHTEVI_OGLAS VALUES (8, 'HTML');

INSERT INTO CV VALUES (
    1, 'Luka', 'Markovic',
    'luka.markovic@gmail.com',
    TO_DATE('2026-08-10', 'YYYY-MM-DD'),
    'pozvan na intervju',
    '0611111111',
    1
);

INSERT INTO CV VALUES (
    2, 'Milica', 'Jovanovic',
    'milica.jovanovic@gmail.com',
    TO_DATE('2026-08-11', 'YYYY-MM-DD'),
    'u procesu',
    '0622222222',
    1
);

INSERT INTO CV VALUES (
    3, 'Stefan', 'Nikolic',
    'stefan.nikolic@gmail.com',
    TO_DATE('2026-08-12', 'YYYY-MM-DD'),
    'primljen',
    '0633333333',
    2
);

INSERT INTO CV VALUES (
    4, 'Marija', 'Ilic',
    'marija.ilic@gmail.com',
    TO_DATE('2026-08-13', 'YYYY-MM-DD'),
    'pozvan na intervju',
    '0644444444',
    2
);

INSERT INTO CV VALUES (
    5, 'Aleksa', 'Stojanovic',
    'aleksa.stojanovic@gmail.com',
    TO_DATE('2026-08-14', 'YYYY-MM-DD'),
    'odbijen',
    '0655555555',
    3
);

INSERT INTO CV VALUES (
    6, 'Tamara', 'Petrovic',
    'tamara.petrovic@gmail.com',
    TO_DATE('2026-08-15', 'YYYY-MM-DD'),
    'pozvan na intervju',
    '0666666666',
    3
);

INSERT INTO CV VALUES (
    7, 'Nemanja', 'Pavlovic',
    'nemanja.pavlovic@gmail.com',
    TO_DATE('2026-08-16', 'YYYY-MM-DD'),
    'u procesu',
    '0677777777',
    4
);

INSERT INTO CV VALUES (
    8, 'Teodora', 'Savic',
    'teodora.savic@gmail.com',
    TO_DATE('2026-08-17', 'YYYY-MM-DD'),
    'pozvan na intervju',
    '0688888888',
    4
);

INSERT INTO CV VALUES (
    9, 'Filip', 'Mitic',
    'filip.mitic@gmail.com',
    TO_DATE('2026-06-10', 'YYYY-MM-DD'),
    'odbijen',
    '0612345678',
    5
);

INSERT INTO CV VALUES (
    10, 'Andjela', 'Mladenovic',
    'andjela.mladenovic@gmail.com',
    TO_DATE('2026-08-18', 'YYYY-MM-DD'),
    'u procesu',
    '0623456789',
    6
);

INSERT INTO CV VALUES (
    11, 'Milos', 'Kostic',
    'milos.kostic@gmail.com',
    TO_DATE('2026-08-19', 'YYYY-MM-DD'),
    'pozvan na intervju',
    '0634567890',
    7
);

INSERT INTO CV VALUES (
    12, 'Ivana', 'Ristic',
    'ivana.ristic@gmail.com',
    TO_DATE('2026-08-20', 'YYYY-MM-DD'),
    'primljen',
    '0645678901',
    7
);

INSERT INTO CV VALUES (
    13, 'Vuk', 'Simic',
    'vuk.simic@gmail.com',
    TO_DATE('2026-08-21', 'YYYY-MM-DD'),
    'u procesu',
    '0656789012',
    8
);

INSERT INTO CV VALUES (
    14, 'Katarina', 'Tomic',
    'katarina.tomic@gmail.com',
    TO_DATE('2026-08-22', 'YYYY-MM-DD'),
    'pozvan na intervju',
    '0667890123',
    8
);

INSERT INTO CV VALUES (
    15, 'Uros', 'Milosevic',
    'uros.milosevic@gmail.com',
    TO_DATE('2026-08-23', 'YYYY-MM-DD'),
    'primljen',
    '0678901234',
    1
);

INSERT INTO CV VALUES (
    16, 'Jana', 'Markovic',
    'jana.markovic@gmail.com',
    TO_DATE('2026-08-24', 'YYYY-MM-DD'),
    'pozvan na intervju',
    '0619876543',
    7
);

INSERT INTO CV VALUES (
    17, 'Aleksandar', 'Dakic',
    'aleksandar.dakic@gmail.com',
    TO_DATE('2026-08-25', 'YYYY-MM-DD'),
    'pozvan na intervju',
    '0628765432',
    1
);

INSERT INTO CV VALUES (
    18, 'Mihajlo', 'Zivkovic',
    'mihajlo.zivkovic@gmail.com',
    TO_DATE('2026-08-26', 'YYYY-MM-DD'),
    'u procesu',
    '0637654321',
    2
);

INSERT INTO TEST VALUES (
    1,
    TO_DATE('2026-08-20', 'YYYY-MM-DD'),
    'Java test',
    88,
    'Odlican rezultat',
    1
);

INSERT INTO TEST VALUES (
    2,
    TO_DATE('2026-08-21', 'YYYY-MM-DD'),
    'SQL test',
    75,
    'Dobar rezultat',
    2
);

INSERT INTO TEST VALUES (
    3,
    TO_DATE('2026-08-22', 'YYYY-MM-DD'),
    'Frontend test',
    82,
    'Dobro znanje',
    3
);

INSERT INTO TEST VALUES (
    4,
    TO_DATE('2026-08-23', 'YYYY-MM-DD'),
    'React test',
    91,
    'Odlican kandidat',
    4
);

INSERT INTO TEST VALUES (
    5,
    TO_DATE('2026-08-24', 'YYYY-MM-DD'),
    'QA test',
    55,
    'Potrebno vise znanja',
    5
);

INSERT INTO TEST VALUES (
    6,
    TO_DATE('2026-08-24', 'YYYY-MM-DD'),
    'QA test',
    86,
    'Vrlo dobar rezultat',
    6
);

INSERT INTO TEST VALUES (
    7,
    TO_DATE('2026-08-25', 'YYYY-MM-DD'),
    'SQL test',
    72,
    'Solidan rezultat',
    7
);

INSERT INTO TEST VALUES (
    8,
    TO_DATE('2026-08-25', 'YYYY-MM-DD'),
    'Analitika',
    93,
    'Odlican rezultat',
    8
);

INSERT INTO TEST VALUES (
    9,
    TO_DATE('2026-08-26', 'YYYY-MM-DD'),
    'CSharp test',
    89,
    'Vrlo dobro',
    11
);

INSERT INTO TEST VALUES (
    10,
    TO_DATE('2026-08-27', 'YYYY-MM-DD'),
    'HTML CSS test',
    95,
    'Odlican rezultat',
    14
);

INSERT INTO TEST VALUES (
    11,
    TO_DATE('2026-08-28', 'YYYY-MM-DD'),
    'CSharp test',
    96,
    'Odlicno znanje',
    16
);

INSERT INTO TEST VALUES (
    12,
    TO_DATE('2026-08-28', 'YYYY-MM-DD'),
    'Java test',
    90,
    'Vrlo dobro znanje',
    17
);

INSERT INTO TEST VALUES (
    13,
    TO_DATE('2026-08-29', 'YYYY-MM-DD'),
    'Frontend test',
    84,
    'Dobar rezultat',
    18
);

INSERT INTO INTERVJU VALUES (
    1,
    'licni',
    TO_DATE('2026-08-25 10:00', 'YYYY-MM-DD HH24:MI'),
    'Nis',
    9,
    1,
    1
);

INSERT INTO INTERVJU VALUES (
    2,
    'video',
    TO_DATE('2026-08-25 12:00', 'YYYY-MM-DD HH24:MI'),
    'Online',
    8,
    4,
    2
);

INSERT INTO INTERVJU VALUES (
    3,
    'telefonski',
    TO_DATE('2026-08-26 09:30', 'YYYY-MM-DD HH24:MI'),
    'Telefon',
    7,
    6,
    3
);

INSERT INTO INTERVJU VALUES (
    4,
    'licni',
    TO_DATE('2026-08-26 11:00', 'YYYY-MM-DD HH24:MI'),
    'Beograd',
    10,
    8,
    4
);

INSERT INTO INTERVJU VALUES (
    5,
    'video',
    TO_DATE('2026-08-27 13:00', 'YYYY-MM-DD HH24:MI'),
    'Online',
    9,
    11,
    5
);

INSERT INTO INTERVJU VALUES (
    6,
    'licni',
    TO_DATE('2026-08-27 15:00', 'YYYY-MM-DD HH24:MI'),
    'Nis',
    8,
    14,
    6
);

INSERT INTO INTERVJU VALUES (
    7,
    'video',
    TO_DATE('2026-08-28 10:00', 'YYYY-MM-DD HH24:MI'),
    'Online',
    9,
    15,
    1
);

INSERT INTO INTERVJU VALUES (
    8,
    'telefonski',
    TO_DATE('2026-08-28 11:00', 'YYYY-MM-DD HH24:MI'),
    'Telefon',
    6,
    2,
    2
);

INSERT INTO INTERVJU VALUES (
    9,
    'licni',
    TO_DATE('2026-08-29 10:30', 'YYYY-MM-DD HH24:MI'),
    'Nis',
    10,
    16,
    3
);

INSERT INTO INTERVJU VALUES (
    10,
    'video',
    TO_DATE('2026-08-29 13:00', 'YYYY-MM-DD HH24:MI'),
    'Online',
    9,
    17,
    4
);

INSERT INTO INTERVJU VALUES (
    11,
    'telefonski',
    TO_DATE('2026-08-30 12:00', 'YYYY-MM-DD HH24:MI'),
    'Telefon',
    8,
    18,
    5
);

INSERT INTO NAPOMENA_INTERVJU VALUES (1, 'Odlicno tehnicko znanje');
INSERT INTO NAPOMENA_INTERVJU VALUES (1, 'Dobra komunikacija');
INSERT INTO NAPOMENA_INTERVJU VALUES (2, 'Poznavanje React tehnologije');
INSERT INTO NAPOMENA_INTERVJU VALUES (3, 'Potrebno vise iskustva');
INSERT INTO NAPOMENA_INTERVJU VALUES (4, 'Odlican kandidat');
INSERT INTO NAPOMENA_INTERVJU VALUES (4, 'Preporuka za sledeci krug');
INSERT INTO NAPOMENA_INTERVJU VALUES (5, 'Vrlo dobro znanje baza');
INSERT INTO NAPOMENA_INTERVJU VALUES (6, 'Dobra motivacija');
INSERT INTO NAPOMENA_INTERVJU VALUES (7, 'Odlicno backend znanje');
INSERT INTO NAPOMENA_INTERVJU VALUES (8, 'Solidan razgovor');
INSERT INTO NAPOMENA_INTERVJU VALUES (9, 'Odlicno poznavanje CSharp');
INSERT INTO NAPOMENA_INTERVJU VALUES (9, 'Veoma dobra komunikacija');
INSERT INTO NAPOMENA_INTERVJU VALUES (10, 'Odlicno poznavanje Jave');
INSERT INTO NAPOMENA_INTERVJU VALUES (10, 'Preporuka za zaposlenje');
INSERT INTO NAPOMENA_INTERVJU VALUES (11, 'Dobro frontend znanje');

INSERT INTO ODLUKA VALUES (
    1,
    TO_DATE('2026-08-29', 'YYYY-MM-DD'),
    TO_DATE('2026-09-15', 'YYYY-MM-DD'),
    1,
    'izabran',
    140000,
    NULL,
    1
);

INSERT INTO ODLUKA VALUES (
    2,
    TO_DATE('2026-08-29', 'YYYY-MM-DD'),
    NULL,
    0,
    'odbijen',
    NULL,
    'Nedovoljno iskustva',
    5
);

INSERT INTO ODLUKA VALUES (
    3,
    TO_DATE('2026-08-30', 'YYYY-MM-DD'),
    NULL,
    NULL,
    'rezerva',
    NULL,
    NULL,
    6
);

INSERT INTO ODLUKA VALUES (
    4,
    TO_DATE('2026-08-30', 'YYYY-MM-DD'),
    TO_DATE('2026-09-20', 'YYYY-MM-DD'),
    1,
    'izabran',
    125000,
    NULL,
    8
);

INSERT INTO ODLUKA VALUES (
    5,
    TO_DATE('2026-08-30', 'YYYY-MM-DD'),
    NULL,
    NULL,
    'na cekanju',
    NULL,
    NULL,
    11
);

INSERT INTO ODLUKA VALUES (
    6,
    TO_DATE('2026-08-31', 'YYYY-MM-DD'),
    TO_DATE('2026-09-10', 'YYYY-MM-DD'),
    1,
    'izabran',
    60000,
    NULL,
    12
);

INSERT INTO ODLUKA VALUES (
    7,
    TO_DATE('2026-08-31', 'YYYY-MM-DD'),
    NULL,
    NULL,
    'na cekanju',
    NULL,
    NULL,
    14
);

INSERT INTO ODLUKA VALUES (
    8,
    TO_DATE('2026-08-31', 'YYYY-MM-DD'),
    TO_DATE('2026-09-12', 'YYYY-MM-DD'),
    1,
    'izabran',
    150000,
    NULL,
    15
);

INSERT INTO ODLUKA VALUES (
    9,
    TO_DATE('2026-08-30', 'YYYY-MM-DD'),
    TO_DATE('2026-09-15', 'YYYY-MM-DD'),
    1,
    'izabran',
    70000,
    NULL,
    16
);

INSERT INTO ODLUKA VALUES (
    10,
    TO_DATE('2026-08-30', 'YYYY-MM-DD'),
    TO_DATE('2026-09-20', 'YYYY-MM-DD'),
    1,
    'izabran',
    145000,
    NULL,
    17
);

INSERT INTO ODLUKA VALUES (
    11,
    TO_DATE('2026-08-31', 'YYYY-MM-DD'),
    NULL,
    NULL,
    'rezerva',
    NULL,
    NULL,
    18
);

COMMIT;