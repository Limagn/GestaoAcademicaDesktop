using GestaoAcademicaDesktop.Models;

namespace GestaoAcademicaDesktop
{
  public partial class Form1 : Form
  {
    private Administrador adm = new();
    private Usuario user = new();
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void btnAdmin_Click(object sender, EventArgs e)
    {
      var adminForm = new AdminForm();

      adminForm.ShowDialog();
    }

    private void btnAluno_Click(object sender, EventArgs e)
    {

    }

    private void btnProfessor_Click(object sender, EventArgs e)
    {

    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
