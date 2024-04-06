using System;
namespace pb.tp7.Models
{
	public class Aluno
	{
		public int matricula { get; set; }
        	public string nome { get; set; }
		public Turma turma { get; set; }

	        public Aluno(int matricula, string nome)
		{
			this.matricula = matricula;
			this.nome = nome;
		}
	}
}

