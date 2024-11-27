using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAcademicaDesktop.Models
{
  internal interface IAvaliacao
  {
    void Avaliar(string matricula, decimal nota);
  }
}
