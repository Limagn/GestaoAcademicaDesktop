using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademicaDesktop.Models
{
  public static class BancoDeDados
  {
    public static Dictionary<string, Aluno> DictAlunos = new();
    public static Dictionary<string, Professor> DictProfessores = new();
  }
}
