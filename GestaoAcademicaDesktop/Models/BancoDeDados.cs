using GestaoAcademicaDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademicaDesktop.Models
{
  internal static class BancoDeDados
  {
    internal static Dictionary<string, Aluno> DictAlunos = new();
    internal static Dictionary<string, Professor> DictProfessores = new();
  }
}