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
  public partial class AdminForms : Form
  {
    Administrador adm = new Administrador();
    public AdminForms()
    {
      InitializeComponent();
    }

    private void AdminForm_Load(object sender, EventArgs e)
    {

    }

    //---------
    // Login |
    //---------
    private void btnLogin_Click(object sender, EventArgs e)
    {
      if (textUsuario.Text == adm.Usuario && textSenha.Text == adm.Senha)
      {
        textMatriculaAluno.Enabled = true;
        textNomeAluno.Enabled = true;
        textSobrenomeAluno.Enabled = true;
        textCurso.Enabled = true;
        textMatriculaProfessor.Enabled = true;
        textNomeProfessor.Enabled = true;
        textSobrenomeProfessor.Enabled = true;
        textDisciplina.Enabled = true;
        btnListarAlunos.Enabled = true;
        btnListarProfessores.Enabled = true;
        textSenha.Clear();
        textUsuario.Enabled = false;
        textSenha.Enabled = false;
      }
      else
      {
        MessageBox.Show("Usuário inválido!");
      }
    }

    //---------
    // Alunos |
    //---------
    private void btnAddAluno_Click(object sender, EventArgs e)
    {
      Aluno aluno = new Aluno(textNomeAluno.Text, textSobrenomeAluno.Text, textMatriculaAluno.Text, textCurso.Text);

      BancoDeDados.DictAlunos.TryAdd(textMatriculaAluno.Text, aluno);
      MessageBox.Show("Aluno adicionado com sucesso!");
      LimparCaixasAluno();
    }

    private void btnListarAlunos_Click(object sender, EventArgs e)
    {
      listAlunos.Items.Clear();

      foreach (var aluno in BancoDeDados.DictAlunos)
      {
        listAlunos.Items.Add(aluno.Value);
      }
    }
    private void listAlunos_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listAlunos.SelectedIndex >= 0)
      {
        string[] itens = listAlunos.GetItemText(listAlunos.SelectedItem).Split(" - ");
        textMatriculaAluno.Text = itens[0];

        btnRemoverAluno.Enabled = true;
      }
    }
    private void btnRemoverAluno_Click(object sender, EventArgs e)
    {
      if (listAlunos.SelectedItem != null)
      {
        listAlunos.Items.Remove(listAlunos.SelectedItem);
        BancoDeDados.DictAlunos.Remove(textMatriculaAluno.Text);
        textMatriculaAluno.Clear();

        MessageBox.Show("Aluno excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        btnRemoverAluno.Enabled = false;
      }
    }

    //--------------
    // Professores |
    //--------------
    private void btnAddProfessor_Click(object sender, EventArgs e)
    {
      Professor professor = new Professor(textNomeProfessor.Text, textSobrenomeProfessor.Text, textMatriculaProfessor.Text, textDisciplina.Text);

      BancoDeDados.DictProfessores.TryAdd(textMatriculaProfessor.Text, professor);
      MessageBox.Show("Professor adicionado com sucesso!");
      LimparCaixasProfessor();
    }

    private void btnListarProfessores_Click(object sender, EventArgs e)
    {
      listProfessores.Items.Clear();

      foreach (var professor in BancoDeDados.DictProfessores)
      {
        listProfessores.Items.Add(professor.Value);
      }
    }
    private void listProfessores_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listProfessores.SelectedIndex >= 0)
      {
        string[] itens = listProfessores.GetItemText(listProfessores.SelectedItem).Split(" - ");
        textMatriculaProfessor.Text = itens[0];

        btnRemoverProfessor.Enabled = true;
      }
    }
    private void btnRemoverProfessor_Click(object sender, EventArgs e)
    {
      if (listProfessores.SelectedItem != null)
      {
        listProfessores.Items.Remove(listProfessores.SelectedItem);
        BancoDeDados.DictProfessores.Remove(textMatriculaProfessor.Text);
        textMatriculaProfessor.Clear();

        MessageBox.Show("Professor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        btnRemoverProfessor.Enabled = false;
      }
    }
    //--------------------
    // Utilitários Aluno |
    //--------------------
    private void btnVoltar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void VerificarCaixasPreenchidasAluno()
    {
      if (
          textMatriculaAluno.Text != "" && textNomeAluno.Text != ""
          && textSobrenomeAluno.Text != "" && textCurso.Text != ""
         )
        btnAddAluno.Enabled = true;
      else
        btnAddAluno.Enabled = false;
    }
    private void LimparCaixasAluno()
    {
      textMatriculaAluno.Clear();
      textNomeAluno.Clear();
      textSobrenomeAluno.Clear();
      textCurso.Clear();
    }

    private void txtMatriculaAluno_TextChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasAluno();
    }

    private void txtNomeAluno_TextChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasAluno();

    }

    private void txtSobrenomeAluno_TextChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasAluno();

    }

    private void txtCurso_TextChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasAluno();

    }

    //------------------------
    // Utilitários Professor |
    //------------------------

    private void VerificarCaixasPreenchidasProfessor()
    {
      if (
          textMatriculaProfessor.Text != "" && textNomeProfessor.Text != ""
          && textSobrenomeProfessor.Text != "" && textDisciplina.Text != ""
         )
        btnAddProfessor.Enabled = true;
      else
        btnAddProfessor.Enabled = false;
    }
    private void LimparCaixasProfessor()
    {
      textMatriculaProfessor.Clear();
      textNomeProfessor.Clear();
      textSobrenomeProfessor.Clear();
      textDisciplina.Clear();
    }

    private void txtMatriculaProfessor_TextChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasProfessor();
    }

    private void txtNomeProfessor_TextChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasProfessor();
    }

    private void txtSobrenomeProfessor_TextChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasProfessor();
    }

    private void txtDisciplina_TextChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasProfessor();
    }

    //--------------------
    // Utilitários Login |
    //--------------------

    private void VerificarCaixasPreenchidasLogin()
    {
      if (textUsuario.Text != "" && textSenha.Text != "")
        btnLogin.Enabled = true;
      else
        btnLogin.Enabled = false;
    }
    private void txtUsuario_TextChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasLogin();
    }

    private void txtSenha_TextChanged(object sender, EventArgs e)
    {
      VerificarCaixasPreenchidasLogin();
    }

  }
}
