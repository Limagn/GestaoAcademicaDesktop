using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademicaDesktop.Models
{
  public abstract class Pessoa
  {
    public Pessoa(string nome, string sobrenome, string matricula)
    {
      Nome = nome;
      Sobrenome = sobrenome;
      Matricula = matricula;
    }

    public Pessoa(string nome, string sobrenome, string matricula, int idade) : this(nome, sobrenome, matricula)
    {
      Idade = idade;
    }

    private string _nome;
    private string _sobrenome;
    private string _matricula;

    public string Nome
    {
      get => _nome;
      set => _nome = value;
    }

    public string Sobrenome
    {
      get => _sobrenome;
      set => _sobrenome = value;
    }

    public string Matricula
    {
      get => _matricula;
      set => _matricula = value;
    }
    public string NomeCompleto => $"{Nome} {Sobrenome}";
    public int Idade { get; set; }

    public abstract void Apresentacao();
  }
}
