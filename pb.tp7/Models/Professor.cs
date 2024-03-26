using System;
namespace pb.tp7.Models
{
    public class Professor
    {
        public int matricula { get; set; }
        public string nome { get; set; }

        public Professor(int matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;
        }
    }
}

