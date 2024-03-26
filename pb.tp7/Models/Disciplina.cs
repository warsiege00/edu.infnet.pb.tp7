using System;
namespace pb.tp7.Models
{
	public class Disciplina
	{
		public int codigo { get; set; }
		public string nome { get; set; }
		public Turma turma { get; set; }

		public Disciplina(int codigo, string nome)
		{
			this.codigo = codigo;
			this.nome = nome;
		}
	}
}

