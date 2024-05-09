using System;
using System.Collections.Generic;

namespace Aula1_17_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Disciplina disciplina = new Disciplina("Backend", 777, 20);
            string entrada;
            Aluno aluno;
            do
            {
                Console.Clear();
                Console.WriteLine("Entre com a opcao desejada:");
                Console.WriteLine("1 Cadastrar aluno");
                Console.WriteLine("2 Lancar Nota");
                Console.WriteLine("3 Consultar Nota");
                Console.WriteLine("4 Listar Notas");
                Console.WriteLine("5 Inserir Falta");
                Console.WriteLine("sair (Para encerrar)");
                entrada = Console.ReadLine();

                switch(entrada) {
                    case "1": 
                        disciplina.CadastrarAlunoViaConsole();
                        Console.WriteLine("Aluno cadastrado com sucesso");
                        break;
                    case "2":
                        Console.WriteLine("Entre com Nome ou Matricula do Aluno para lancar nota:");
                        aluno = disciplina.LocalizarAluno(Console.ReadLine());
                        Console.WriteLine($"Localizado : Aluno: {aluno.Nome} Matricula: {aluno.Matricula}");

                        Console.WriteLine("Entre com a nota np1:");
                        double np1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Entre com a nota np2:");
                        double np2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Entre com a nota Trabalho:");
                        double trabalho = Convert.ToDouble(Console.ReadLine());

                        disciplina.LancarNota(aluno, np1, np2, trabalho);
                        Console.WriteLine("Nota Final: " + disciplina.MapaDeNotas[aluno]);
                        break;

                    case "3":
                        Console.WriteLine("Entre com Nome ou Matricula do Aluno para Consulta nota:");
                        aluno = disciplina.LocalizarAluno(Console.ReadLine());
                        Console.WriteLine($" Aluno: {aluno.Nome} Matricula: {aluno.Matricula} Nota Final:  {disciplina.MapaDeNotas[aluno]}"); 
                        break;
                    
                    case "4":
                        Console.WriteLine("Listagem de Notas: ");
                        foreach (KeyValuePair<Aluno, double> alunoAtual in disciplina.MapaDeNotas) 
                        {
                            Console.WriteLine($"Aluno: {alunoAtual.Key.Nome} Nota Final: {alunoAtual.Value}");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Entre com Nome ou Matricula do Aluno para Consulta nota:");
                        aluno = disciplina.LocalizarAluno(Console.ReadLine());
                        disciplina.AddFalta(aluno);
                        Console.WriteLine("Falta cadastrada com sucesso: ");                        
                        break;
                    case "sair":
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
                Console.ReadKey();

            } while (entrada != "sair");
        }
    }
}
