﻿/*2*/
SELECT a.NOME_ALUNO, c.NOME_CURSO FROM TBALUNO AS a
INNER JOIN TBMATRICULA AS m   ON a.ID_ALUNO =  m.ALUNO_ID  
INNER JOIN TBCURSO AS c ON c.ID_CURSO =  m.CURSO_ID 
ORDER BY NOME_CURSO

/*3*/
SELECT Email FROM TBALUNO WHERE DATA_NASCIMENTO < '1996'

/*4*/
SELECT COUNT(*) FROM TBALUNO

/*5*/
SELECT COUNT(c.ID_CURSO) FROM TBCURSO AS c 
INNER JOIN TBMATRICULA  AS m 
ON c.ID_CURSO = m.CURSO_ID 
GROUP BY c.ID_CURSO

/*6*/
SELECT NOME_ALUNO FROM TBALUNO WHERE DATA_NASCIMENTO < '1996' 

/*7*/
SELECT NOME_ALUNO FROM TBALUNO WHERE SEXO = 'F'

/*8*/
SELECT a.NOME_ALUNO, c.ID_CURSO FROM TBALUNO AS a 
INNER JOIN TBMATRICULA AS m  
ON a.ID_ALUNO = m.ALUNO_ID  
INNER JOIN TBCURSO AS c 
ON c.ID_CURSO = m.CURSO_ID  WHERE c.ID_CURSO = 5 AND SEXO = 'F'

/*9*/
SELECT NOME_CURSO FROM TBCURSO ORDER BY NOME_CURSO