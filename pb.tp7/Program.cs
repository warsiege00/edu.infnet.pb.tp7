// See https://aka.ms/new-console-template for more information
using pb.tp7.Models;

Console.WriteLine("----Sistema de Cadastro Academico----");

Professor professor = new Professor(1, "Jose");
Disciplina disciplina = new Disciplina(1, "Matemática");


Turma turma = new Turma(1, professor, disciplina);

Aluno a1 = new Aluno(1, "Matheus");
Aluno a2 = new Aluno(2, "Maria");

Console.WriteLine("Adicionando aluno na turma");
string r1 = turma.addAluno(a1);
string r2 = turma.addAluno(a2);
Console.WriteLine(r1);
Console.WriteLine(r2);
Console.WriteLine(turma.addAluno(a2));
Console.WriteLine(turma.addAluno(a2));
Console.WriteLine(turma.addAluno(a2));
Console.WriteLine(turma.addAluno(a2));
Console.WriteLine(turma.addAluno(a2));
Console.WriteLine(turma.addAluno(a2));
Console.WriteLine(turma.addAluno(a2));
Console.WriteLine(turma.addAluno(a2));
Console.WriteLine(turma.addAluno(a2));
Console.WriteLine(turma.addAluno(a2));

if (turma.abrirTurma())
{
    Console.WriteLine("Turma Aberta com Sucesso!");
    Console.WriteLine("---Pauta---");
    Console.WriteLine(turma.gerarPauta());
}


Console.ReadLine();