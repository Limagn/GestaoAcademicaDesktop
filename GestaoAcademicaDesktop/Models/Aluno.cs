using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademicaDesktop.Models
{
  public class Aluno : Pessoa, IAvaliacao
  {
    public Aluno(string nome, string sobrenome, string matricula, string curso) : base(nome, sobrenome, matricula)
    {
      Curso = curso;
    }
    protected string Curso { get; set; }

    public override void Apresentacao()
    {
      if (Idade != 0)
      {
        MessageBox.Show($"Olá! Meu nome é {NomeCompleto} e tenho {Idade} anos. Sou aluno na UniFOA e estudo {Curso}");
      }
      else
      {
        MessageBox.Show($"Olá! Meu nome é {NomeCompleto}. Sou aluno na UniFOA e estudo {Curso}");
      }
    }
    public void Avaliar(string matricProfessor, int nota)
    {
      if (BancoDeDados.DictProfessores.TryGetValue(matricProfessor, out Professor professor))
      {
        MessageBox.Show($"O aluno {NomeCompleto} avaliou o professor {professor.NomeCompleto} com a nota {nota}.");
      }
      else
      {
        MessageBox.Show("Professor não encontrado.");
      }
    }
    public override string ToString()
    {
      return $"{Matricula} - {NomeCompleto} - {Curso}";
    }

  }
}
