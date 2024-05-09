using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_17_08
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public int Cargahoraria { get; set; }
        public List<Aluno> ListAlunos { get; set;}

        public Dictionary<Aluno, double> MapaDeNotas { get; set; }
        public Dictionary<Aluno, int> MapaDeFaltas { get; set; }
        public int Faltas { get; set; }

        public Disciplina(String Nome, int Codigo, int Cargahoraria) 
        {
            this.Nome = Nome;
            this.Codigo = Codigo;
            this.Cargahoraria = Cargahoraria;

            ListAlunos = new List<Aluno>();
            MapaDeNotas = new Dictionary<Aluno, double>();
            MapaDeFaltas = new Dictionary<Aluno, int>();
        }

        public void LancarNota(Aluno aluno, double np1, double np2, double trabalho) 
        {
            double Notafinal = 0;
            Notafinal = (np1 * 0.3) + (np2 * 0.3) + (trabalho * 0.4);
            MapaDeNotas[aluno] = Notafinal;
        }
        public Aluno LocalizarAluno(string strBusca) {
            bool isCodigo = false;
            int codigo = -1;
            try
            {
                codigo = Convert.ToInt32(strBusca);
                    isCodigo = true;
            }
            catch
            {
                isCodigo = false;
            }
            if (isCodigo == true)
               return ListAlunos.First(o => o.Matricula == codigo);

            return ListAlunos.First(o => o.Nome.Equals(strBusca.ToLower()));
        }

        public void CadastrarAlunoViaConsole()
        {
            Aluno novoAluno = new Aluno();
            novoAluno.CadastrarAlunoViaConsole();
            ListAlunos.Add(novoAluno);
            MapaDeNotas.Add(novoAluno, 0) ;
            MapaDeFaltas.Add(novoAluno, 0);
        }

        public void AddFalta(Aluno aluno)
        {
            MapaDeFaltas[aluno]++;
 
        }

    }
}
