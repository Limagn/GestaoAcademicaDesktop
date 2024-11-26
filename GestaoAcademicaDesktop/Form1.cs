using GestaoAcademicaDesktop.Models;

namespace GestaoAcademicaDesktop
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      
    }
    private void btnAdmin_Click(object sender, EventArgs e)
    {
      var adminForm = new AdminForms();
      adminForm.ShowDialog();
    }
    private void btnAluno_Click(object sender, EventArgs e)
    {
      var alunoForm = new AlunoForms();
      alunoForm.ShowDialog();
    }
    private void btnProfessor_Click(object sender, EventArgs e)
    {
      var professorForm = new ProfessorForms();
      professorForm.ShowDialog();
    }
    private void btnSair_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
