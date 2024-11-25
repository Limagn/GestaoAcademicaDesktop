using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademicaDesktop.Models
{
  public class Professor : Pessoa, IAvaliacao
  {
    public Professor(string nome, string sobrenome, string matricula, string disciplina) : base(nome, sobrenome, matricula)
    {
      Disciplina = disciplina;
    }
    protected string Disciplina { get; set; }

    public override void Apresentacao()
    {
      if (Idade != 0)
      {
        MessageBox.Show($"Olá! Meu nome é {NomeCompleto} e tenho {Idade} anos. Sou professor na UniFOA e dou aula de {Disciplina} ");
      }
      else
      {
        MessageBox.Show($"Olá! Meu nome é {NomeCompleto}. Sou aluno na UniFOA e dou aula de {Disciplina} ");
      }
    }
    public void Avaliar(string matricAluno, int nota)
    {
      if (BancoDeDados.DictAlunos.TryGetValue(matricAluno, out Aluno aluno))
      {
        MessageBox.Show($"O aluno {NomeCompleto} avaliou o professor {aluno.NomeCompleto} com a nota {nota}.");
      }
      else
      {
        MessageBox.Show("Professor não encontrado.");
      }
    }
    public override string ToString()
    {
      return $"{Matricula} - {NomeCompleto} - {Disciplina}";
    }
  }
}
