CREATE DATABASE SegPFS12;

USE SegPFS12;

CREATE TABLE users (
Id INT PRIMARY KEY IDENTITY,
Email VARCHAR (100) UNIQUE NOT NULL,
[Password] VARCHAR (50) NOT NULL,
);

INSERT INTO users VALUES ('email@.gmail.com','senha1234');

SELECT * FROM users;

SELECT Email, HASHBYTES ('MD5',[Password]) AS 'Senha com Hash' FROM users;

INSERT INTO users VALUES ('email2@.gmail.com','senha1234');

SELECT Email, HASHBYTES ('MD5',[Password]) AS 'Senha com Hash' FROM users WHERE Id=1;

SELECT Email, HASHBYTES ('MD2',[Password]) AS 'Senha com Hash' FROM users WHERE Id=1;
SELECT Email, HASHBYTES ('MD4',[Password]) AS 'Senha com Hash' FROM users WHERE Id=1;
SELECT Email, HASHBYTES ('SHA1',[Password]) AS 'Senha com Hash' FROM users WHERE Id=1;
SELECT Email, HASHBYTES ('SHA2_256',[Password]) AS 'Senha com Hash' FROM users WHERE Id=1;
SELECT Email, HASHBYTES ('SHA2_512',[Password]) AS 'Senha com Hash' FROM users WHERE Id=1;

UPDATE users SET [Password] = 'senha12345' WHERE Id =2

SELECT Email, HASHBYTES ('MD5',[Password]) AS 'Senha com Hash' FROM users WHERE Id=1;
SELECT Email, PWDENCRYPT ([Password]) AS 'Senha com Hash' FROM users WHERE Id=1;