namespace GestaoAcademicaDesktop
{
  partial class MainForm
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
      label1 = new Label();
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
      // 
      // btnAluno
      // 
      btnAluno.Location = new Point(99, 140);
      btnAluno.Name = "btnAluno";
      btnAluno.Size = new Size(75, 23);
      btnAluno.TabIndex = 1;
      btnAluno.Text = "Aluno";
      btnAluno.UseVisualStyleBackColor = true;
      // 
      // btnProfessor
      // 
      btnProfessor.Location = new Point(99, 192);
      btnProfessor.Name = "btnProfessor";
      btnProfessor.Size = new Size(75, 23);
      btnProfessor.TabIndex = 2;
      btnProfessor.Text = "Professor";
      btnProfessor.UseVisualStyleBackColor = true;
      // 
      // btnSair
      // 
      btnSair.Location = new Point(99, 243);
      btnSair.Name = "btnSair";
      btnSair.Size = new Size(75, 23);
      btnSair.TabIndex = 3;
      btnSair.Text = "Sair";
      btnSair.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(29, 32);
      label1.Name = "label1";
      label1.Size = new Size(220, 15);
      label1.TabIndex = 4;
      label1.Text = "Bem-vindo(a)!! Selecione sua permissão.";
      label1.Click += label1_Click;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(275, 321);
      Controls.Add(label1);
      Controls.Add(btnSair);
      Controls.Add(btnProfessor);
      Controls.Add(btnAluno);
      Controls.Add(btnAdmin);
      Name = "MainForm";
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
    private Label label1;
  }
}
