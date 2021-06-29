CREATE DATABASE ProyectoFinal;

USE ProyectoFinal;
SET LANGUAGE us_english;

--Creando las tablas
CREATE TABLE PERSONAL(
    identificador INT PRIMARY KEY IDENTITY,
    nombre VARCHAR (50),
    direccion VARCHAR (50),
    correo_electronico VARCHAR (50),
    usuario VARCHAR (50),
    contrasena VARCHAR (50),
    id_tipo INT
);

CREATE TABLE CABINA(
    id_cabina INT PRIMARY KEY IDENTITY,
    direccion VARCHAR (50),
    telefono VARCHAR (50),
    identificador INT
);


CREATE TABLE REGISTRO(
    id INT PRIMARY KEY IDENTITY,
    log_in DATETIME,
    log_out DATETIME,
    id_cabina INT,
    identificador INT
);

CREATE TABLE CIUDADANO(
    id INT PRIMARY KEY IDENTITY,
    dui VARCHAR(10),
    nombre VARCHAR(50),
    telefono VARCHAR(9),
    edad INT,
    direccion VARCHAR(50),
    correo_electronico VARCHAR(50),
    enfermedad_cronica VARCHAR(50),
    id_institucion INT
);

CREATE TABLE PROCESO_VACUNA(
    id_proceso INT PRIMARY KEY IDENTITY,
    hora_inicio DATETIME,
    hora_vacunacion DATETIME,
    identificador INT,
);

CREATE TABLE PROCESO_CITA(
    id_cita INT PRIMARY KEY IDENTITY,
    fecha DATETIME,
    id INT,
    identificador INT
);

CREATE TABLE EFECTOS_SECUNDARIOS(
    id_efecto INT PRIMARY KEY IDENTITY,
    descripcion VARCHAR (30)
);

CREATE TABLE INSTITUCION(
    id_institucion INT PRIMARY KEY IDENTITY,
    institucion VARCHAR (50)
);

CREATE TABLE CABINAXCIUDADANO(
	id_cabinaXciudadano INT PRIMARY KEY IDENTITY,
	id_cabina INT,
	id INT
);

CREATE TABLE PROCESOXEFECTO(
	id_procesoXefecto INT PRIMARY KEY IDENTITY,
	id_efecto INT,
	id_proceso INT
);

CREATE TABLE TIPO_PERSONAL(
    id_tipo INT PRIMARY KEY IDENTITY,
    tipo VARCHAR (50)
);

--llaves foraneas
ALTER TABLE PERSONAL
ADD CONSTRAINT FK_TIPO_PERSONAL
FOREIGN KEY (id_tipo) REFERENCES TIPO_PERSONAL (id_tipo);

ALTER TABLE PROCESO_VACUNA
ADD CONSTRAINT FK_IDENTIFICADOR_PERSONAL
FOREIGN KEY (identificador) REFERENCES PERSONAL (identificador);

ALTER TABLE PROCESOXEFECTO
ADD CONSTRAINT FK_PROEFEC
FOREIGN KEY (id_efecto) REFERENCES EFECTOS_SECUNDARIOS (id_efecto);

ALTER TABLE PROCESOXEFECTO
ADD CONSTRAINT FK_PROEFECTO
FOREIGN KEY (id_proceso) REFERENCES PROCESO_VACUNA (id_proceso);

ALTER TABLE CABINA
ADD CONSTRAINT FK_IDENTIFICADOR_EN_CABINA
FOREIGN KEY (identificador) REFERENCES PERSONAL (identificador);

ALTER TABLE CIUDADANO
ADD CONSTRAINT FK_INSTITUCION_CIUDADANO
FOREIGN KEY (id_institucion) REFERENCES INSTITUCION (id_institucion);

ALTER TABLE CABINAXCIUDADANO
ADD CONSTRAINT FK_CABINXCIUDA
FOREIGN KEY (id_cabina) REFERENCES CABINA (id_cabina);

ALTER TABLE CABINAXCIUDADANO
ADD CONSTRAINT FK_CABINAXCIUDADANO
FOREIGN KEY (id) REFERENCES CIUDADANO (id);

ALTER TABLE REGISTRO
ADD CONSTRAINT FK_REGISTROCABINA
FOREIGN KEY (id_cabina) REFERENCES CABINA (id_cabina);

ALTER TABLE REGISTRO
ADD CONSTRAINT FK_REGISTROPERSONAL
FOREIGN KEY (identificador) REFERENCES PERSONAL (identificador);

ALTER TABLE PROCESO_CITA
ADD CONSTRAINT FK_DUI
FOREIGN KEY (id) REFERENCES CIUDADANO (id);

ALTER TABLE PROCESO_CITA
ADD CONSTRAINT FK_IDENTIFICADOR
FOREIGN KEY (identificador) REFERENCES PERSONAL (identificador);


INSERT INTO TIPO_PERSONAL(tipo)
VALUES 
('Gestor'),
('Vacunador'),
('Asistente de Salud')

INSERT INTO PERSONAL (nombre, direccion, correo_electronico, usuario, contrasena, id_tipo)
VALUES 
('Fernando Quinteros', 'San Salvador','fquinteros@gob.com.sv', 'fquinteros', 'Quinteros01', 1),
('Fernando Cortez', 'San Salvador', 'fcortez@gob.com.sv','fcortez', 'Flamenco24@', 1),
('Emely Cruz', 'San Salvador', 'ecruz@gob.com.sv', 'ecruz', 'Cruz01', 2),
('Cristian Soto', 'San Salvador', 'csoto@gob.com.sv', 'csoto', 'Soto01', 2)

INSERT INTO CABINA (direccion,telefono, identificador)
VALUES 
('San Salvador', '2222-2222', 1),
('La Libertad', '2323-2323', 2)

INSERT INTO EFECTOS_SECUNDARIOS (descripcion)
VALUES 
('Ninguno'),
('Dolor'),
('Sensibilidad'),
('Enrojecimiento'),
('Fatiga'),
('Dolor de Cabeza'),
('Fiebre'),
('Mialgia'),
('Artralgia'),
('Anafiláxia'),
('Otros')

INSERT INTO INSTITUCION (institucion)
VALUES 
('Ninguno'),
('PNC'),
('Fuerza Armada'),
('Cuerpos de Socorro'),
('Personal de Fronteras'),
('Personal de Fronteras'),
('Personal de Centros Penales'),
('Personal del Sistema Integrado de Salud')