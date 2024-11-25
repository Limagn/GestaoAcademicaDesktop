using GestaoAcademicaDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoAcademicaDesktop
{
  public partial class ProfessorForms : Form
  {
    public ProfessorForms()
    {
      InitializeComponent();
    }

    private void ProfessorForms_Load(object sender, EventArgs e)
    {

    }

    private void btnConfirmaMatriculaProfessor_Click(object sender, EventArgs e)
    {
      string matricula = textMatriculaProfessor.Text;

      if (BancoDeDados.DictProfessores.TryGetValue(matricula, out Professor professor))
      {
        MessageBox.Show($"Bem-vindo(a), {professor.NomeCompleto}!");
        btnApresentacao.Enabled = true;
        btnAvaliarAluno.Enabled = true;
      }
      else
      {
        MessageBox.Show("Matrícula inválida.");
      }
    }

    private void btnApresentacao_Click(object sender, EventArgs e)
    {
      BancoDeDados.DictProfessores.TryGetValue(textMatriculaProfessor.Text, out Professor professor);
      professor.Apresentacao();
    }

    private void btnAvaliarAluno_Click(object sender, EventArgs e)
    {
      textMatriculaAluno.Enabled = true;
      numericNota.Enabled = true;
    }

    private void btnEnviar_Click(object sender, EventArgs e)
    {
      BancoDeDados.DictProfessores.TryGetValue(textMatriculaProfessor.Text, out Professor professor);
      professor.Avaliar(textMatriculaAluno.Text, numericNota.Value);
      textMatriculaAluno.Clear();
      textMatriculaAluno.Enabled = false;
      numericNota.Value = 0;
      numericNota.Enabled = false;
    }

    private void btnVoltar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    //--------------
    // Utilitários |
    //--------------
    private void VerificarCaixasPreenchidasAvaliarAluno()
    {
      if (textMatriculaAluno.Text != "" && numericNota != null)
        btnEnviar.Enabled = true;
      else
        btnEnviar.Enabled = false;
    }

    private void textMatriculaAluno_TextChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasAvaliarAluno();
    }

    private void numericNota_ValueChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasAvaliarAluno();
    }
  }
}
