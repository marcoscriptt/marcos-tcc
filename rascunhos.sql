
 select current_value from sys.sequences where name = 'SEQ_PROVA2'

 select * from SistemaP.dbo.TBPROVA

 select * from SistemaP.dbo.TBPROVA_QUESTAO

	 SELECT IDQUESTAO FROM SistemaP.DBO.TBQUESTAO where titulo='?????????'

 INSERT INTO SistemaP.DBO.TBPROVA_QUESTAO (idProva, IDQUESTAO) VALUES (next value for SistemaP.DBO.SEQ_PROVA2, SELECT IDQUESTAO FROM SistemaP.DBO.TBQUESTAO WHERE MATERIA = 'ASOO')
--DROP USER EQUIPE7 CASCADE;
SELECT IDQUESTAO FROM SistemaP.DBO.TBQUESTAO WHERE MATERIA = 'ASOO'
--DELETE * FROM EQUIPE7;



SELECT * FROM SistemaP.DBO.TB_ADMIN where nome like'%luc%' or rm_admin like'%luc%'




 select q.rm_aluno, q.nome, p.turma_alu, q.num_chamada, s.prova,

 Z.NOTA  from SistemaP.DBO.tb_aluno as q inner join SistemaP.DBO.tb_turma

 as p on p.id_turma = q.id_turma inner join SistemaP.dbo.TBPROVA as s on
  
  p.id_turma = q.id_turma  inner join SistemaP.dbo.TBNOTAS_ALUNO
  as z on 
  z.prova = s.PROVA WHERE Q.RM_ALUNO = Z.RM_ALUNO

  SELECT * FROM SistemaP.DBO.TBNOTAS_ALUNO where idprova =4
  
SELECT q.questao,Q.TITULO , q.respostaA,q.respostaB,q.respostaC,q.respostaD,q.respostaCerta FROM SistemaP.DBO.tbquestao q INNER JOIN SistemaP.DBO.tbprova_questao b on q.idquestao = b.idquestao where b.idprova = ''
  
  SELECT q.questao,Q.TITULO , q.respostaA,q.respostaB,q.respostaC,q.respostaD,q.respostaCerta FROM SistemaP.DBO.tbquestao q INNER JOIN SistemaP.DBO.tbprova_questao b on q.idquestao = b.idquestao

  SELECT A.RM_ALUNO,A.NUM_CHAMADA, A.NOME , N.PROVA, N.NOTA , T.TURMA_ALU FROM  TBNOTAS_ALUNO N RIGHT OUTER JOIN TB_ALUNO A ON N.RM_ALUNO = A.RM_ALUNO INNER JOIN TB_TURMA T ON A.ID_TURMA = T.ID_TURMA where T.TURMA_ALU like'%INF1C %' AND A.nome like'%%' AND N.PROVA like'%PROVA PAT%'


  SELECT A.RM_ALUNO,A.NUM_CHAMADA, A.NOME , N.PROVA, N.NOTA , T.TURMA_ALU FROM  TBNOTAS_ALUNO N RIGHT OUTER JOIN TB_ALUNO A ON N.RM_ALUNO = A.RM_ALUNO INNER JOIN TB_TURMA T ON A.ID_TURMA = T.ID_TURMA where T.TURMA_ALU like'%INF1C%' AND A.nome like'%" + keyword + "%' OR N.PROVA like'% %'

  SELECT A.RM_ALUNO,A.NUM_CHAMADA, A.NOME , N.PROVA, N.NOTA , T.TURMA_ALU FROM  TBNOTAS_ALUNO N RIGHT OUTER JOIN TB_ALUNO A ON N.RM_ALUNO = A.RM_ALUNO INNER JOIN TB_TURMA T ON A.ID_TURMA = T.ID_TURMA where T.TURMA_ALU like'%" + TextoTeste + "%' AND A.nome like'%" + keyword + "%' OR N.PROVA like'%" + comboBox1.Text + "%'


  select current_value from sys.sequences where name = 'SEQ_PROVA'

 select idprova,prova, turmaatual,MATERIA_PROVA, materia_prova FROM SistemaP.DBO.tbprova

	 SELECT A.RM_ALUNO,A.NUM_CHAMADA, A.NOME , N.PROVA, N.NOTA , T.TURMA_ALU FROM   SistemaP.DBO.TBNOTAS_ALUNO N RIGHT OUTER JOIN  SistemaP.DBO.TB_ALUNO A ON N.RM_ALUNO = A.RM_ALUNO INNER JOIN  SistemaP.DBO.TB_TURMA T ON A.ID_TURMA = T.ID_TURMA where T.TURMA_ALU like'%INF1A ' or A.nome like'%fdgdfgdf%' and N.PROVA    like '%fgdfgdf%'


 select * from SistemaP.DBO.tb_user

 select q.rm_aluno, q.nome, p.turma_alu, q.num_chamada, s.prova, z.nota 
 from SistemaP.DBO.tb_aluno as q inner join SistemaP.DBO.tb_turma as p on
  p.id_turma = q.id_turma inner join SistemaP.dbo.TBPROVA as s on  p.id_turma = q.id_turma 
  inner join SistemaP.dbo.TBNOTAS_ALUNO as z on z.prova = s.PROVA
   select current_value from sys.sequences where name = 'SEQ_PROVA'



SELECT * FROM TB_USER





select * from  SistemaP.DBO.PROF_MATERIA





SELECT q.rm_admin, q.NOME, p.LOGIN,p.Senha,q.CADASTRO,q.ULTIMOACESSO,q.STATUS FROM SistemaP.DBO.TB_ADMIN AS q INNER JOIN SistemaP.DBO.TB_USER AS p on q.LOGIN = p.LOGIN

select q.rm_aluno, q.nome, p.turma_alu, q.num_chamada, q.login, q.cadastro,q.ultimoacesso, s.SENHA, q.status from SistemaP.DBO.tb_aluno as q inner join SistemaP.DBO.tb_turma as p on p.ID_TURMA = q.ID_TURMA inner join SistemaP.DBO.tb_user as s on q.login = s.login           
SELECT * FROM SistemaP.DBO.tb_turma where turma_alu =  ' INF1B '

SELECT ID_TURMA FROM SistemaP.DBO.tb_turma where turma_alu ='INF1D'





select q.rm_aluno, q.nome, p.turma_alu, q.num_chamada, q.login, q.status from SistemaP.DBO.tb_aluno as q inner join SistemaP.DBO.tb_turma as p on p.ID_TURMA = q.ID_TURMA where q.STATUS ='1' 








INSERT TB_ADMIN (RM_ADMIN, NOME, login,  ULTIMOACESSO, CADASTRO, STATUS) VALUES ('12348', 'mp"', 'mp_12348','24/02/2018','24/02/2018', '1');























































--alter table SistemaP.DBO.TB_NIVELDEACESSO modify NivelAcesso VARCHAR(15);

--SELECT CEP, SUBSTR(CEP,9,1)|| SUBSTR(CEP,1,7) FROM CEP2D;

--UP varchar(50) CEP SET CEP=SUBSTR(CEP,9,1)|| SUBSTR(CEP,1,7);






--CREATE OR REPLACE PROCEDURE SistemaP.SP_INSERIR_ADM
--(
--VRM_ADMIN IN VARCHAR,
--VNOME IN VARCHAR,
--VLOGIN IN VARCHAR,
--VULTIMOACESSO IN VARCHAR,
--VSTATUS IN INTEGER,
--VCADASTRO IN VARCHAR
--) AS BEGIN

 --INSERT INTO SistemaP.DBO.TB_ADMIN(RM_ADMIN, NOME,
 --LOGIN,ULTIMOACESSO,CADASTRO, STATUS) VALUES (VRM_ADMIN, VNOME,
 --VLOGIN,VULTIMOACESSO,VCADASTRO ,VSTATUS);
 
-- END SP_INSERIR_ADM;
































exec sp_addlinkedserver 'SistemaP', 'sql server';





exec sp_configure 'remote access', 1;

exec sp_configure 'remote query timeout',600
exec sp_configure 'remote proc trans',0
reconfigure with override

select q.rm_aluno, q.nome, p.turma_alu, q.num_chamada, r.login from
 SistemaP.DBO.tb_aluno as q inner join SistemaP.DBO.tb_turma as p
  on p.id_turma = q.id_turma inner join SistemaP.DBO.TB_USER  r on r.login=q.login  where TURMA_ALU = ' INF1C '
               

/*


select * into tb_teste from tb_teste2 -----ele copia a tabela

CREATE TABLE SistemaP.DBO.teste
(


RM_PROFESSOR INTEGER NOT NULL,
MATERIA_PROF VARCHAR(30)





--------------------------------------------------------------


--EXEMPLO DE INNER JOIN SQL SERVER PARA DESKTOP

);
SELECT q.questao, q.idquestao, q.respostaA,q.respostaB,q.respostaC,q.respostaD,q.respostaCerta FROM SistemaP.DBO.tbquestao AS q INNER JOIN SistemaP.DBO.tbprova_questao AS b on q.idquestao = b.idquestao


--------------------------------------------------------------



select q.rm_aluno, q.nome, p.turma_alu, q.num_chamada, login, status from SistemaP.DBO.tb_aluno as q inner join SistemaP.DBO.tb_turma as p where status =0










UPDATE SistemaP.DBO.TbQuestao SET status ='1' ,Questao ='" + Questao + "',respostaA ='" + RespostaA + "',respostaB='" + RespostaB + "' ,respostaC ='" + RespostaC + "',respostaD ='" + RespostaC + "', respostaCerta ='" + RespostaCerta + "' WHERE IDQUESTAO = ' 1';

UPDATE SistemaP.DBO.TbQuestao SET status ='1' ,Questao ='MARCOS',respostaA ='MARCOS',respostaB='MARCOS' ,respostaC ='MARCOS',respostaD ='MARCOS', respostaCerta ='MARCOS' WHERE IDQUESTAO = '1'



UPDATE SistemaP.DBO.TbQuestao SET status ='1' ,Questao ='" + _Questao + "',respostaA ='" + _RespostaA + "',respostaB='" + RespostaB + "' ,respostaC ='" + _RespostaC + "',respostaD ='" + _RespostaC + "', respostaCerta ='" + _RespostaCerta + "' WHERE IDQUESTAO = '1';



SELECT p.nome_prof,p.materia_prova FROM SistemaP.DBO.tbprova p inner join SistemaP.DBO.tbprova_questao on p.idprova = tbprova_questao.idprova

SELECT pq.idprova,pq.idquestao FROM SistemaP.DBO.tbprova_questao pq inner join SistemaP.DBO.tbprova p on pq.idprova = p.idprova

--SELECT tbprova.prova,tbprova.idprova, tbprova_questao.idprova FROM SistemaP.DBO.tbprova, tb.prova_questao inner join tbprova.idprova = tbprova_questao.idprova

--SELECT SistemaP.SEQ_MATERIA.NEXTVAL FROM DUAL

--SELECT pq.idprova,pq.idquestao FROM SistemaP.DBO.tbrova_questao pq inner join SistemaP.DBO.tbprova_questao b on p.idquestao = b.idquestao


SELECT q.questao, q.idquestao, q.respostaA,q.respostaB,q.respostaC,q.respostaD,q.respostaCerta FROM SistemaP.DBO.tbquestao q INNER JOIN SistemaP.DBO.tbprova_questao b on q.idquestao = b.idquestao;

--correto
SELECT p.quantidade FROM SistemaP.DBO.tbprova p inner join SistemaP.DBO.tbprova_questao b on p.idprova = b.idprova


--SELECT SistemaP.DBO.tbquestao.questao,SistemaP.DBO.tbquestao.idquestao, SistemaP.DBO.tbprova_questao.idquestao FROM SistemaP.DBO.tbquestao, equipe7tb.prova_questao inner join SistemaP.DBO.tbquestao.idquestao = SistemaP.DBO.tbprova_questao.idquestao;

*/
