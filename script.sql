CREATE DATABASE db_escola;
USE db_escola;

CREATE TABLE curso (
idCurso INT (4) NOT NULL PRIMARY KEY AUTO_INCREMENT,
nomeCurso VARCHAR(50) NOT NULL,
cargaHoraria INT (4) NOT NULL
);

CREATE TABLE turma (
idTurma INT (4) NOT NULL PRIMARY KEY AUTO_INCREMENT,
nomeTurma VARCHAR(50) NOT NULL,
turno VARCHAR(5) NOT NULL,
idCurso INT(4) NOT NULL,
foreign key (idCurso) references curso (idCurso)
);

CREATE TABLE professor (
idProfessor INT (4) NOT NULL PRIMARY KEY AUTO_INCREMENT,
cpfProfessor LONG NOT NULL,
nomeProfessor VARCHAR(50) NOT NULL,
telefoneProfessor LONG NOT NULL,
celularProfessor LONG NOT NULL,
emailProfessor VARCHAR(50) NOT NULL,
senhaProfessor VARCHAR(50) NOT NULL,
ruaProfessor VARCHAR(50) NOT NULL,
numeroProfessor INT (5) NOT NULL,
bairroProfessor VARCHAR(50) NOT NULL,
cidadeProfessor VARCHAR(50) NOT NULL,
idTurma INT(4) NOT NULL,
cepProfessor LONG NOT NULL,
dataNasc DATE NOT NULL,
foreign key (idTurma) references turma (idTurma)
);

CREATE TABLE aluno (
idAluno INT (4) NOT NULL PRIMARY KEY AUTO_INCREMENT,
cpfAluno LONG NOT NULL,
nomeAluno VARCHAR(50) NOT NULL,
telefoneAluno LONG NOT NULL,
celularAluno LONG NOT NULL,
emailAluno VARCHAR(50) NOT NULL,
senhaAluno VARCHAR(50) NOT NULL,
ruaAluno VARCHAR(50) NOT NULL,
numeroAluno INT NULL,
bairroAluno VARCHAR(50) NOT NULL,
cidadeAluno VARCHAR(50) NOT NULL,
idTurma INT(4) NOT NULL,
cepAluno LONG NOT NULL,
dataNasc DATE NOT NULL,
foreign key (idTurma) references turma (idTurma)
);

CREATE TABLE materia (
idMateria INT (4) NOT NULL PRIMARY KEY AUTO_INCREMENT,
idCurso INT(4) NOT NULL,
nomeMateria VARCHAR(50) NOT NULL,
foreign key (idCurso) references curso (idCurso)
);

CREATE TABLE nota (
idNota INT (4) NOT NULL PRIMARY KEY auto_increment,
idAluno INT(4) NOT NULL,
idMateria INT(4) NOT NULL,
nota INT(3) NOT NULL,
foreign key (idAluno) references aluno (idAluno),
foreign key (idMateria) references materia (idMateria)
);

CREATE TABLE loginAssistente (
idAssistente INT (4) NOT NULL PRIMARY KEY AUTO_INCREMENT,
emailAssistente VARCHAR(50) NOT NULL,
senhaAssistente VARCHAR(50) NOT NULL
);

insert into loginAssistente (emailAssistente, senhaAssistente) values ("assistente@gmail.com", "12345");


