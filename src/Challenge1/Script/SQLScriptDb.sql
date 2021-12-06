create database NubimetricUserDb;
GO
use NubimetricUserDb;
GO
create table "User"
(
Id int identity primary key,
Nombre nvarchar(50),
Apellido nvarchar(50),
Email nvarchar(100),
Password nvarchar(50)
)
GO
insert into "User" values('User1', 'Apellido1','user1@correo.com','user1');
insert into "User" values('User2', 'Apellido2','user2@correo.com','user2');
insert into "User" values('User3', 'Apellido3','user3@correo.com','user3');
insert into "User" values('User4', 'Apellido4','user4@correo.com','user4');
insert into "User" values('User5', 'Apellido5','user5@correo.com','user5');
insert into "User" values('User6', 'Apellido6','user6@correo.com','user6');
insert into "User" values('User7', 'Apellido7','user7@correo.com','user7');
insert into "User" values('User8', 'Apellido8','user8@correo.com','user8');
insert into "User" values('User9', 'Apellido9','user9@correo.com','user9');
insert into "User" values('User10', 'Apellido10','user10@correo.com','user10');
insert into "User" values('User11', 'Apellido11','user11@correo.com','user11');
insert into "User" values('User12', 'Apellido12','user12@correo.com','user12');
insert into "User" values('User13', 'Apellido13','user13@correo.com','user13');
insert into "User" values('User14', 'Apellido14','user14@correo.com','user14');
insert into "User" values('User15', 'Apellido15','user15@correo.com','user15');
insert into "User" values('User16', 'Apellido16','user16@correo.com','user16');
insert into "User" values('User17', 'Apellido17','user17@correo.com','user17');
insert into "User" values('User18', 'Apellido18','user18@correo.com','user18');
insert into "User" values('User19', 'Apellido19','user19@correo.com','user19');
insert into "User" values('User20', 'Apellido20','user20@correo.com','user20');
GO
SELECT * FROM "User"