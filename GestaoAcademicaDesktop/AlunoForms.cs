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
  public partial class AlunoForms : Form
  {
    public AlunoForms()
    {
      InitializeComponent();
    }

    private void AlunoForms_Load(object sender, EventArgs e)
    {

    }
    private void btnConfirmaMatricula_Click(object sender, EventArgs e)
    {
      string matricula = textMatriculaAluno.Text;

      if (BancoDeDados.DictAlunos.TryGetValue(matricula, out Aluno aluno))
      {
        MessageBox.Show($"Bem-vindo(a), {aluno.NomeCompleto}!");
        btnApresentacao.Enabled = true;
        btnAvaliarProfessor.Enabled = true;
      }
      else
      {
        MessageBox.Show("Matrícula inválida.","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private void btnApresentacao_Click(object sender, EventArgs e)
    {
      BancoDeDados.DictAlunos.TryGetValue(textMatriculaAluno.Text, out Aluno aluno);
      aluno.Apresentacao();
    }
    private void btnAvaliarProfessor_Click(object sender, EventArgs e)
    {
      textMatriculaProfessor.Enabled = true;
      numericNota.Enabled = true;
    }
    private void btnEnviar_Click(object sender, EventArgs e)
    {
      BancoDeDados.DictAlunos.TryGetValue(textMatriculaAluno.Text, out Aluno aluno);
      aluno.Avaliar(textMatriculaProfessor.Text, numericNota.Value);
      textMatriculaProfessor.Clear();
      textMatriculaProfessor.Enabled = false;
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
    private void VerificarCaixasPreenchidasAvaliarProfessor()
    {
      if (textMatriculaProfessor.Text != "" && numericNota != null)
        btnEnviar.Enabled = true;
      else
        btnEnviar.Enabled = false;
    }
    private void textMatriculaProfessor_TextChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasAvaliarProfessor();
    }
    private void numericNota_ValueChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasAvaliarProfessor();
    }
  }
}
