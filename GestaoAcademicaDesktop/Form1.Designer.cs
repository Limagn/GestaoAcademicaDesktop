
namespace GestaoAcademicaDesktop
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      btnAdmin = new Button();
      btnAluno = new Button();
      btnProfessor = new Button();
      btnSair = new Button();
      lblTitulo = new Label();
      SuspendLayout();
      // 
      // btnAdmin
      // 
      btnAdmin.Location = new Point(99, 86);
      btnAdmin.Name = "btnAdmin";
      btnAdmin.Size = new Size(75, 23);
      btnAdmin.TabIndex = 0;
      btnAdmin.Text = "Admin";
      btnAdmin.UseVisualStyleBackColor = true;
      btnAdmin.Click += btnAdmin_Click;
      // 
      // btnAluno
      // 
      btnAluno.Location = new Point(99, 140);
      btnAluno.Name = "btnAluno";
      btnAluno.Size = new Size(75, 23);
      btnAluno.TabIndex = 1;
      btnAluno.Text = "Aluno";
      btnAluno.UseVisualStyleBackColor = true;
      btnAluno.Click += btnAluno_Click;
      // 
      // btnProfessor
      // 
      btnProfessor.Location = new Point(99, 192);
      btnProfessor.Name = "btnProfessor";
      btnProfessor.Size = new Size(75, 23);
      btnProfessor.TabIndex = 2;
      btnProfessor.Text = "Professor";
      btnProfessor.UseVisualStyleBackColor = true;
      btnProfessor.Click += btnProfessor_Click;
      // 
      // btnSair
      // 
      btnSair.Location = new Point(99, 243);
      btnSair.Name = "btnSair";
      btnSair.Size = new Size(75, 23);
      btnSair.TabIndex = 3;
      btnSair.Text = "Sair";
      btnSair.UseVisualStyleBackColor = true;
      btnSair.Click += btnSair_Click;
      // 
      // lblTitulo
      // 
      lblTitulo.AutoSize = true;
      lblTitulo.Location = new Point(29, 32);
      lblTitulo.Name = "lblTitulo";
      lblTitulo.Size = new Size(220, 15);
      lblTitulo.TabIndex = 4;
      lblTitulo.Text = "Bem-vindo(a)!! Selecione sua permissão.";
      lblTitulo.Click += label1_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(275, 321);
      Controls.Add(lblTitulo);
      Controls.Add(btnSair);
      Controls.Add(btnProfessor);
      Controls.Add(btnAluno);
      Controls.Add(btnAdmin);
      Name = "Form1";
      Text = "Gestão Acadêmica";
      Load += Form1_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btnAdmin;
    private Button btnAluno;
    private Button btnProfessor;
    private Button btnSair;
    private Label lblTitulo;
  }
}
