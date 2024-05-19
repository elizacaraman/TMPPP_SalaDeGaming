-- Crearea bazei de date SalaDeGaming
CREATE DATABASE SalaDeGaming;
USE SalaDeGaming;

-- Tabelul Utilizatori
CREATE TABLE Utilizatori (
    ID_Utilizator INT PRIMARY KEY IDENTITY,
    Nume_Utilizator VARCHAR(50) NOT NULL,
    Parola VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Data_Inregistrare DATETIME DEFAULT GETDATE()
);

-- Tabelul Echipamente
CREATE TABLE Echipamente (
    ID_Echipament INT PRIMARY KEY IDENTITY,
    Nume_Echipament VARCHAR(100) NOT NULL,
    Stare VARCHAR(20) CHECK (Stare IN ('disponibil', 'ocupat', 'intretinere')) NOT NULL DEFAULT 'disponibil',
    Specificatii TEXT
);


-- Tabelul Rezervari
CREATE TABLE Rezervari (
    Id_Rezervare INT PRIMARY KEY IDENTITY,
    Nume_Utilizator NVARCHAR(50),
    Nume_Echipament NVARCHAR(100),
    Nume_Zona NVARCHAR(50),
    Data_Rezervare DATE,
    Ora_Inceput TIME,
    Ora_Sfarsit TIME
);

DROP TABLE Promotii;

-- Tabelul Notificari
CREATE TABLE Notificari (
    ID_Notificare INT PRIMARY KEY IDENTITY,
    ID_Utilizator INT,
    Titlu VARCHAR(100) NOT NULL,
    Mesaj TEXT NOT NULL,
    Data_Trimiterii DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ID_Utilizator) REFERENCES Utilizatori(ID_Utilizator)
);

Create Table Username(
Username nchar(50) not null,
Password nchar(50) not null,
)

CREATE TABLE Promotii (
    ID_Promotie INT PRIMARY KEY IDENTITY,
    Nume_Promotie NVARCHAR(100) NOT NULL,
    Descriere NVARCHAR(255) NOT NULL,
    Data_Inceput DATE NOT NULL,
    Data_Sfarsit DATE NOT NULL,
    Durata INT NOT NULL, -- Durata în ore a promoției
    Ore_Bonus INT NOT NULL -- Numărul de ore bonus oferite
);

CREATE TABLE Jocuri (
    ID_Joc INT PRIMARY KEY IDENTITY,
    Nume_Joc NVARCHAR(100) NOT NULL,
    Dezvoltator NVARCHAR(100) NOT NULL,
    Gen NVARCHAR(50),
    An_Lansare INT,
    Rating DECIMAL(3, 1) -- Poate fi o valoare între 0 și 10
);

CREATE TABLE Zone (
    ID_Zona INT PRIMARY KEY IDENTITY,
    Nume_Zona NVARCHAR(100) NOT NULL,
    Capacitate INT NOT NULL, -- Numărul de locuri disponibile în zona respectivă
    Descriere NVARCHAR(255) -- Descrierea sau detalii suplimentare despre zona
);


select * from Username
select * from Utilizatori



-- Inserare utilizator 1
INSERT INTO Utilizatori (Nume_Utilizator, Parola, Email, Data_Inregistrare)
VALUES ('john_doe', 'parola123', 'john.doe@example.com', GETDATE());

-- Inserare utilizator 2
INSERT INTO Utilizatori (Nume_Utilizator, Parola, Email, Data_Inregistrare)
VALUES ('alice_smith', 'parola456', 'alice.smith@example.com', GETDATE());

-- Inserare utilizator 3
INSERT INTO Utilizatori (Nume_Utilizator, Parola, Email, Data_Inregistrare)
VALUES ('alex_88', 'parola789', 'alex.88@example.com', GETDATE());

-- Inserare utilizator 4
INSERT INTO Utilizatori (Nume_Utilizator, Parola, Email, Data_Inregistrare)
VALUES ('laura_g', 'parola321', 'laura.g@example.com', GETDATE());

-- Inserare utilizator 5
INSERT INTO Utilizatori (Nume_Utilizator, Parola, Email, Data_Inregistrare)
VALUES ('michael_smith', 'parola987', 'michael.smith@example.com', GETDATE());

-- Inserare utilizator 6
INSERT INTO Utilizatori (Nume_Utilizator, Parola, Email, Data_Inregistrare)
VALUES ('emma_jones', 'parola654', 'emma.jones@example.com', GETDATE());



-- Inserare în tabelul Echipamente
INSERT INTO Echipamente (Nume_Echipament, Stare, Specificatii)
VALUES 
    ('Consola Xbox Series X', 'disponibil', '1TB SSD, Controller wireless'),
    ('Consola PlayStation 5', 'disponibil', 'SSD 825GB, DualSense controller'),
    ('PC Gaming High-End', 'intretinere', 'Procesor AMD Ryzen 9 5950X, 32GB RAM, NVIDIA GeForce RTX 3090'),
    ('Nintendo Switch', 'disponibil', 'Consola hibridă, Joy-Con controller'),
    ('Oculus Quest 2', 'disponibil', 'Casti VR standalone, 256GB'),
    ('PC Gaming Standard', 'disponibil', 'Procesor Intel Core i7, 16GB RAM, NVIDIA GeForce GTX 1660 Super'),
    ('PlayStation 4 Pro', 'disponibil', 'HDD 1TB, DualShock 4 controller'),
    ('Nintendo Switch Lite', 'disponibil', 'Consola portabilă, ecran tactil'),
    ('Xbox One X', 'ocupat', 'HDD 1TB, Wireless controller'),
    ('Gaming Laptop ASUS ROG', 'disponibil', 'Procesor AMD Ryzen 7, 16GB RAM, NVIDIA GeForce RTX 2060'),
    ('HTC Vive Pro', 'disponibil', 'Headset VR, senzori de mișcare, set complet pentru experiențe VR'),
    ('Sony PlayStation VR', 'disponibil', 'Headset VR, PlayStation Camera, set complet pentru experiențe VR'),
    ('Nintendo 3DS XL', 'disponibil', 'Consola portabilă, 3D display, Nintendo DS games compatibility'),
    ('Arcade Machine', 'disponibil', 'Mașină arcade clasică, joystick și butoane arcade'),
    ('Razer Gaming Chair', 'disponibil', 'Scaun ergonomic pentru gaming, suport lombar și pentru gât, ajustabil');

-- Inserare în tabelul Rezervari
INSERT INTO Rezervari (Id_Rezervare, Nume_Utilizator, Nume_Echipament, Nume_Zona, Data_Rezervare, Ora_Inceput, Ora_Sfarsit)
VALUES 
    (1, 'John Doe', 'Consola Xbox Series X', 'Zona Console', '2024-05-20', '10:00:00', '12:00:00'),
    (2, 'Alice Smith', 'Consola PlayStation 5', 'Zona Console', '2024-05-21', '14:00:00', '16:00:00');


-- Inserare în tabelul Notificari
INSERT INTO Notificari (ID_Utilizator, Titlu, Mesaj, Data_Trimiterii)
VALUES 
    (3, 'Bun venit!', 'Bine ai venit, user1!', GETDATE()),
    (4, 'Rezervare confirmată', 'Rezervarea pentru PlayStation 5 a fost confirmată.', GETDATE()),
    (5, 'Echipament indisponibil', 'PC Gaming High-End este în întreținere și nu poate fi rezervat momentan.', GETDATE()),
    (6, 'Actualizare platformă', 'În curând vom introduce noi jocuri pentru Nintendo Switch.', GETDATE()),
    (7, 'Promoție specială', 'Oculus Quest 2 este disponibil acum la un preț special.', GETDATE());


INSERT INTO Promotii (Nume_Promotie, Descriere, Data_Inceput, Data_Sfarsit, Durata, Ore_Bonus)
VALUES
('Promotia Monday Madness', 'Rezerva in fiecare luni si primesti 2 ore bonus', '2024-05-20', '2024-05-20', 2, 2),
('Promotia Student Discount', 'Prezinta un act de identitate de student si primesti 20% reducere la rezervare', '2024-05-21', '2024-05-21', 1, 0),
('Promotia VIP Membership', 'Fii membru VIP si primesti 30% reducere la fiecare rezervare', '2024-05-22', '2024-05-22', 1, 0),
('Promotia Happy Gaming Hour', 'Rezerva intre orele 10:00 si 14:00 si primesti 50% reducere la fiecare ora', '2024-05-23', '2024-05-23', 4, 0),
('Promotia Family Fun Day', 'Rezerva in weekend si primesti 3 ore bonus pentru fiecare membru al familiei', '2024-05-24', '2024-05-25', 1, 3);

	INSERT INTO Jocuri (Nume_Joc, Dezvoltator, Gen, An_Lansare, Rating)
VALUES 
    ('Cyberpunk 2077', 'CD Projekt Red', 'RPG', 2020, 8.2),
    ('The Last of Us Part II', 'Naughty Dog', 'Action-Adventure', 2020, 9.0),
    ('Valorant', 'Riot Games', 'FPS', 2020, 8.6),
    ('Animal Crossing: New Horizons', 'Nintendo', 'Simulation', 2020, 9.3),
    ('Assassin''s Creed Valhalla', 'Ubisoft', 'Action-Adventure', 2020, 8.1),
	('League of Legends', 'Riot Games', 'MOBA', 2009, 8.7),
    ('Counter-Strike: Global Offensive', 'Valve Corporation', 'FPS', 2012, 9.2),
    ('Fortnite', 'Epic Games', 'Battle Royale', 2017, 8.9),
    ('Dota 2', 'Valve Corporation', 'MOBA', 2013, 8.8),
    ('The Last of Us Part II', 'Naughty Dog', 'Action-Adventure', 2020, 9.0),
    ('God of War', 'Santa Monica Studio', 'Action-Adventure', 2018, 9.3),
    ('Marvel''s Spider-Man', 'Insomniac Games', 'Action-Adventure', 2018, 8.7),
    ('Red Dead Redemption 2', 'Rockstar Games', 'Action-Adventure', 2018, 9.8),
    ('Uncharted 4: A Thief''s End', 'Naughty Dog', 'Action-Adventure', 2016, 9.5),
    ('Beat Saber', 'Beat Games', 'Rhythm', 2018, 9.1),
    ('Half-Life: Alyx', 'Valve Corporation', 'Action', 2020, 9.5),
    ('Superhot VR', 'SUPERHOT Team', 'Action', 2017, 8.9),
    ('Moss', 'Polyarc', 'Adventure', 2018, 8.8),
    ('Job Simulator', 'Owlchemy Labs', 'Simulation', 2016, 8.6);

INSERT INTO Zone (Nume_Zona, Capacitate, Descriere)
VALUES 
    ('Zona PC-uri', 20, 'Zona dedicată PC-urilor de gaming.'),
    ('Zona Console', 15, 'Zona cu console PlayStation, Xbox și Nintendo.'),
    ('Zona VR', 10, 'Zona specială pentru experiențe de realitate virtuală.'),
    ('Zona Relaxare', 5, 'Zona cu scaune confortabile pentru relaxare și socializare.');





--Lista echipamentelor disponibile
SELECT Nume_Echipament, Stare, Specificatii
FROM Echipamente
WHERE Stare = 'disponibil';


-- Afisarea jocurilor pe coloane separate
SELECT Nume_Joc FROM Jocuri;
SELECT Dezvoltator FROM Jocuri;
SELECT Gen FROM Jocuri;
SELECT An_Lansare FROM Jocuri;
SELECT Rating FROM Jocuri;


-- Afisarea jocurilor dupa rating crescator
SELECT Nume_Joc,Dezvoltator,Gen,An_Lansare, Rating
FROM Jocuri
ORDER BY Rating ASC;

-- Afisarea jocurilor dupa rating descrescator
SELECT Nume_Joc,Dezvoltator,Gen,An_Lansare, Rating
FROM Jocuri
ORDER BY Rating DESC;


DECLARE @sortare VARCHAR(20); -- Presupunem că alegerea este stocată în variabila @sortare

-- Setarea valorii pentru sortare in functie de valoarea din combobox
SET @sortare = 'asc'; -- Sau 'desc' în funcție de alegere

-- Interogarea pentru afișarea jocurilor în funcție de opțiunea selectată
IF @sortare = 'asc'
BEGIN
    SELECT Nume_Joc, Dezvoltator, Gen, An_Lansare, Rating
    FROM Jocuri
    ORDER BY Rating ASC;
END
ELSE IF @sortare = 'desc'
BEGIN
    SELECT Nume_Joc, Dezvoltator, Gen, An_Lansare, Rating
    FROM Jocuri
    ORDER BY Rating DESC;
END


SELECT Nume_Echipament, Stare, Specificatii
FROM Echipamente;

DECLARE @Id_Rezervare INT = 1;
DECLARE @Nume_Utilizator NVARCHAR(50) = 'John Doe';
DECLARE @Nume_Echipament NVARCHAR(100) = 'Consola Xbox Series X';
DECLARE @Nume_Zona NVARCHAR(100) = 'Zona Console';
DECLARE @Data_Rezervare DATE = '2024-05-20';
DECLARE @Ora_Inceput TIME = '10:00:00';
DECLARE @Ora_Sfarsit TIME = '12:00:00';

-- Verificare disponibilitate echipament
IF EXISTS (SELECT 1 FROM Echipamente WHERE Nume_Echipament = @Nume_Echipament AND Stare = 'disponibil')
BEGIN
    -- Înregistrare utilizator dacă nu există deja
    IF NOT EXISTS (SELECT 1 FROM Utilizatori WHERE Nume_Utilizator = @Nume_Utilizator)
    BEGIN
        INSERT INTO Utilizatori (Nume_Utilizator)
        VALUES (@Nume_Utilizator);
    END

    
-- Înregistrare rezervare
INSERT INTO Rezervari (Nume_Utilizator, Nume_Echipament, Nume_Zona, Data_Rezervare, Ora_Inceput, Ora_Sfarsit)
VALUES (
    @Nume_Utilizator,
    @Nume_Echipament,
    @Nume_Zona,
    @Data_Rezervare,
    @Ora_Inceput,
    @Ora_Sfarsit
);

    PRINT 'Rezervarea a fost înregistrată cu succes!';
END
ELSE
BEGIN
    PRINT 'Echipamentul este rezervat sau în întreținere, vă rugăm să selectați altul în schimbul celui ales.';
END

-- Afișare rezervări
SELECT * FROM Rezervari;


SELECT  Nume_Echipament FROM Echipamente

SELECT  Nume_Zona FROM Zone


SELECT * FROM Zone;

SELECT ID_Zona, Nume_Zona, Capacitate, Descriere
FROM Zone;