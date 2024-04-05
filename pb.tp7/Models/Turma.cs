using System;
namespace pb.tp7.Models
{
	public class Turma
	{
		public int codigo { get; set; }
		private List<Aluno> alunos { get; set; }
		public Professor professor { get; set; }
		public Disciplina disciplina { get; set; }

		public Turma(int codigo, Professor professor, Disciplina disciplina)
		{
			this.codigo = codigo;
			this.professor = professor;
			this.disciplina = disciplina;
			this.alunos = new List<Aluno>();
		}


		public string addAluno(Aluno aluno)
		{
			bool turmaCheia = this.alunos.Count >= 10;

			if (turmaCheia) return "Turma Cheia!";

			this.alunos.Add(aluno);
		        return "Aluno adicionado!";
		
		}


		public bool abrirTurma()
		{
	            bool temNumeroAdequadoAlunos = this.alunos.Count >= 2 && this.alunos.Count <=10;
			if (temNumeroAdequadoAlunos)
			{
				return true;
			}
			else {
				return false;
			}
		}

        public string gerarPauta()
        {
		string pauta = $"Turma: {this.codigo} \n" +
			$"Disciplina: {this.disciplina.nome} \n" +
			$"Professor: {this.professor.nome} \n" +
			$"Lista de Alunos:\n";
	
		foreach(Aluno aluno in this.alunos)
		{
			pauta += $"{aluno.nome}\n";
		}
		return pauta;
        }
		
    }
}

