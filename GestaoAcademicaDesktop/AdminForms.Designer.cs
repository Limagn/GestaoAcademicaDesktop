namespace GestaoAcademicaDesktop
{
  partial class AdminForms
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      btnAddAluno = new Button();
      btnAddProfessor = new Button();
      btnListarAlunos = new Button();
      btnListarProfessores = new Button();
      btnVoltar = new Button();
      textMatriculaAluno = new TextBox();
      textNomeAluno = new TextBox();
      textSobrenomeAluno = new TextBox();
      textCurso = new TextBox();
      lnlNomeAluno = new Label();
      lblSobrenomeAluno = new Label();
      lblMatriculaAluno = new Label();
      lblCurso = new Label();
      lblDisciplina = new Label();
      label2 = new Label();
      label3 = new Label();
      label4 = new Label();
      textDisciplina = new TextBox();
      textSobrenomeProfessor = new TextBox();
      textNomeProfessor = new TextBox();
      textMatriculaProfessor = new TextBox();
      listAlunos = new ListBox();
      listProfessores = new ListBox();
      btnRemoverAluno = new Button();
      btnRemoverProfessor = new Button();
      btnLogin = new Button();
      textUsuario = new TextBox();
      textSenha = new TextBox();
      lblUsuario = new Label();
      lblSenha = new Label();
      SuspendLayout();
      // 
      // btnAddAluno
      // 
      btnAddAluno.Enabled = false;
      btnAddAluno.Location = new Point(116, 301);
      btnAddAluno.Name = "btnAddAluno";
      btnAddAluno.Size = new Size(125, 23);
      btnAddAluno.TabIndex = 8;
      btnAddAluno.Text = "Adicionar Aluno";
      btnAddAluno.UseVisualStyleBackColor = true;
      btnAddAluno.Click += btnAddAluno_Click;
      // 
      // btnAddProfessor
      // 
      btnAddProfessor.Enabled = false;
      btnAddProfessor.Location = new Point(800, 301);
      btnAddProfessor.Name = "btnAddProfessor";
      btnAddProfessor.Size = new Size(125, 23);
      btnAddProfessor.TabIndex = 16;
      btnAddProfessor.Text = "Adicionar Professor";
      btnAddProfessor.UseVisualStyleBackColor = true;
      btnAddProfessor.Click += btnAddProfessor_Click;
      // 
      // btnListarAlunos
      // 
      btnListarAlunos.Enabled = false;
      btnListarAlunos.Location = new Point(346, 301);
      btnListarAlunos.Name = "btnListarAlunos";
      btnListarAlunos.Size = new Size(125, 23);
      btnListarAlunos.TabIndex = 10;
      btnListarAlunos.Text = "Listar Alunos";
      btnListarAlunos.UseVisualStyleBackColor = true;
      btnListarAlunos.Click += btnListarAlunos_Click;
      // 
      // btnListarProfessores
      // 
      btnListarProfessores.Enabled = false;
      btnListarProfessores.Location = new Point(1034, 301);
      btnListarProfessores.Name = "btnListarProfessores";
      btnListarProfessores.Size = new Size(125, 23);
      btnListarProfessores.TabIndex = 18;
      btnListarProfessores.Text = "Listar Professores";
      btnListarProfessores.UseVisualStyleBackColor = true;
      btnListarProfessores.Click += btnListarProfessores_Click;
      // 
      // btnVoltar
      // 
      btnVoltar.Location = new Point(666, 364);
      btnVoltar.Name = "btnVoltar";
      btnVoltar.Size = new Size(75, 23);
      btnVoltar.TabIndex = 20;
      btnVoltar.Text = "Voltar";
      btnVoltar.UseVisualStyleBackColor = true;
      btnVoltar.Click += btnVoltar_Click;
      // 
      // textMatriculaAluno
      // 
      textMatriculaAluno.Enabled = false;
      textMatriculaAluno.Location = new Point(116, 105);
      textMatriculaAluno.Name = "textMatriculaAluno";
      textMatriculaAluno.Size = new Size(125, 23);
      textMatriculaAluno.TabIndex = 4;
      textMatriculaAluno.TextChanged += txtMatriculaAluno_TextChanged;
      // 
      // textNomeAluno
      // 
      textNomeAluno.Enabled = false;
      textNomeAluno.Location = new Point(116, 152);
      textNomeAluno.Name = "textNomeAluno";
      textNomeAluno.Size = new Size(125, 23);
      textNomeAluno.TabIndex = 5;
      textNomeAluno.TextChanged += txtNomeAluno_TextChanged;
      // 
      // textSobrenomeAluno
      // 
      textSobrenomeAluno.Enabled = false;
      textSobrenomeAluno.Location = new Point(116, 200);
      textSobrenomeAluno.Name = "textSobrenomeAluno";
      textSobrenomeAluno.Size = new Size(125, 23);
      textSobrenomeAluno.TabIndex = 6;
      textSobrenomeAluno.TextChanged += txtSobrenomeAluno_TextChanged;
      // 
      // textCurso
      // 
      textCurso.Enabled = false;
      textCurso.Location = new Point(116, 247);
      textCurso.Name = "textCurso";
      textCurso.Size = new Size(125, 23);
      textCurso.TabIndex = 7;
      textCurso.TextChanged += txtCurso_TextChanged;
      // 
      // lnlNomeAluno
      // 
      lnlNomeAluno.AutoSize = true;
      lnlNomeAluno.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lnlNomeAluno.Location = new Point(57, 155);
      lnlNomeAluno.Name = "lnlNomeAluno";
      lnlNomeAluno.Size = new Size(53, 20);
      lnlNomeAluno.TabIndex = 31;
      lnlNomeAluno.Text = "Nome:";
      // 
      // lblSobrenomeAluno
      // 
      lblSobrenomeAluno.AutoSize = true;
      lblSobrenomeAluno.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblSobrenomeAluno.Location = new Point(21, 203);
      lblSobrenomeAluno.Name = "lblSobrenomeAluno";
      lblSobrenomeAluno.Size = new Size(89, 20);
      lblSobrenomeAluno.TabIndex = 32;
      lblSobrenomeAluno.Text = "Sobrenome:";
      // 
      // lblMatriculaAluno
      // 
      lblMatriculaAluno.AutoSize = true;
      lblMatriculaAluno.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblMatriculaAluno.Location = new Point(36, 108);
      lblMatriculaAluno.Name = "lblMatriculaAluno";
      lblMatriculaAluno.Size = new Size(74, 20);
      lblMatriculaAluno.TabIndex = 30;
      lblMatriculaAluno.Text = "Matricula:";
      // 
      // lblCurso
      // 
      lblCurso.AutoSize = true;
      lblCurso.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblCurso.Location = new Point(61, 250);
      lblCurso.Name = "lblCurso";
      lblCurso.Size = new Size(49, 20);
      lblCurso.TabIndex = 33;
      lblCurso.Text = "Curso:";
      // 
      // lblDisciplina
      // 
      lblDisciplina.AutoSize = true;
      lblDisciplina.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblDisciplina.Location = new Point(717, 250);
      lblDisciplina.Name = "lblDisciplina";
      lblDisciplina.Size = new Size(77, 20);
      lblDisciplina.TabIndex = 37;
      lblDisciplina.Text = "Disciplina:";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label2.Location = new Point(720, 108);
      label2.Name = "label2";
      label2.Size = new Size(74, 20);
      label2.TabIndex = 34;
      label2.Text = "Matricula:";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label3.Location = new Point(705, 203);
      label3.Name = "label3";
      label3.Size = new Size(89, 20);
      label3.TabIndex = 36;
      label3.Text = "Sobrenome:";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label4.Location = new Point(741, 155);
      label4.Name = "label4";
      label4.Size = new Size(53, 20);
      label4.TabIndex = 35;
      label4.Text = "Nome:";
      // 
      // textDisciplina
      // 
      textDisciplina.Enabled = false;
      textDisciplina.Location = new Point(800, 247);
      textDisciplina.Name = "textDisciplina";
      textDisciplina.Size = new Size(125, 23);
      textDisciplina.TabIndex = 15;
      textDisciplina.TextChanged += txtDisciplina_TextChanged;
      // 
      // textSobrenomeProfessor
      // 
      textSobrenomeProfessor.Enabled = false;
      textSobrenomeProfessor.Location = new Point(800, 200);
      textSobrenomeProfessor.Name = "textSobrenomeProfessor";
      textSobrenomeProfessor.Size = new Size(125, 23);
      textSobrenomeProfessor.TabIndex = 14;
      textSobrenomeProfessor.TextChanged += txtSobrenomeProfessor_TextChanged;
      // 
      // textNomeProfessor
      // 
      textNomeProfessor.Enabled = false;
      textNomeProfessor.Location = new Point(800, 152);
      textNomeProfessor.Name = "textNomeProfessor";
      textNomeProfessor.Size = new Size(125, 23);
      textNomeProfessor.TabIndex = 13;
      textNomeProfessor.TextChanged += txtNomeProfessor_TextChanged;
      // 
      // textMatriculaProfessor
      // 
      textMatriculaProfessor.Enabled = false;
      textMatriculaProfessor.Location = new Point(800, 105);
      textMatriculaProfessor.Name = "textMatriculaProfessor";
      textMatriculaProfessor.Size = new Size(125, 23);
      textMatriculaProfessor.TabIndex = 12;
      textMatriculaProfessor.TextChanged += txtMatriculaProfessor_TextChanged;
      // 
      // listAlunos
      // 
      listAlunos.FormattingEnabled = true;
      listAlunos.ItemHeight = 15;
      listAlunos.Location = new Point(272, 105);
      listAlunos.Name = "listAlunos";
      listAlunos.Size = new Size(406, 169);
      listAlunos.TabIndex = 9;
      listAlunos.SelectedIndexChanged += listAlunos_SelectedIndexChanged;
      // 
      // listProfessores
      // 
      listProfessores.FormattingEnabled = true;
      listProfessores.ItemHeight = 15;
      listProfessores.Location = new Point(959, 105);
      listProfessores.Name = "listProfessores";
      listProfessores.Size = new Size(406, 169);
      listProfessores.TabIndex = 17;
      listProfessores.SelectedIndexChanged += listProfessores_SelectedIndexChanged;
      // 
      // btnRemoverAluno
      // 
      btnRemoverAluno.Enabled = false;
      btnRemoverAluno.Location = new Point(477, 301);
      btnRemoverAluno.Name = "btnRemoverAluno";
      btnRemoverAluno.Size = new Size(125, 23);
      btnRemoverAluno.TabIndex = 11;
      btnRemoverAluno.Text = "Remover Aluno";
      btnRemoverAluno.UseVisualStyleBackColor = true;
      btnRemoverAluno.Click += btnRemoverAluno_Click;
      // 
      // btnRemoverProfessor
      // 
      btnRemoverProfessor.Enabled = false;
      btnRemoverProfessor.Location = new Point(1165, 301);
      btnRemoverProfessor.Name = "btnRemoverProfessor";
      btnRemoverProfessor.Size = new Size(125, 23);
      btnRemoverProfessor.TabIndex = 19;
      btnRemoverProfessor.Text = "Remover Professor";
      btnRemoverProfessor.UseVisualStyleBackColor = true;
      btnRemoverProfessor.Click += btnRemoverProfessor_Click;
      // 
      // btnLogin
      // 
      btnLogin.Enabled = false;
      btnLogin.Location = new Point(863, 30);
      btnLogin.Name = "btnLogin";
      btnLogin.Size = new Size(75, 23);
      btnLogin.TabIndex = 3;
      btnLogin.Text = "Login";
      btnLogin.UseVisualStyleBackColor = true;
      btnLogin.Click += btnLogin_Click;
      // 
      // textUsuario
      // 
      textUsuario.Location = new Point(573, 30);
      textUsuario.Name = "textUsuario";
      textUsuario.Size = new Size(100, 23);
      textUsuario.TabIndex = 1;
      textUsuario.TextChanged += txtUsuario_TextChanged;
      // 
      // textSenha
      // 
      textSenha.Location = new Point(741, 30);
      textSenha.Name = "textSenha";
      textSenha.PasswordChar = '*';
      textSenha.Size = new Size(100, 23);
      textSenha.TabIndex = 2;
      textSenha.TextChanged += txtSenha_TextChanged;
      // 
      // lblUsuario
      // 
      lblUsuario.AutoSize = true;
      lblUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblUsuario.Location = new Point(505, 33);
      lblUsuario.Name = "lblUsuario";
      lblUsuario.Size = new Size(62, 20);
      lblUsuario.TabIndex = 28;
      lblUsuario.Text = "Usuario:";
      // 
      // lblSenha
      // 
      lblSenha.AutoSize = true;
      lblSenha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblSenha.Location = new Point(683, 33);
      lblSenha.Name = "lblSenha";
      lblSenha.Size = new Size(52, 20);
      lblSenha.TabIndex = 29;
      lblSenha.Text = "Senha:";
      // 
      // AdminForms
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1408, 426);
      Controls.Add(lblSenha);
      Controls.Add(lblUsuario);
      Controls.Add(textSenha);
      Controls.Add(textUsuario);
      Controls.Add(btnLogin);
      Controls.Add(btnRemoverProfessor);
      Controls.Add(btnRemoverAluno);
      Controls.Add(listProfessores);
      Controls.Add(listAlunos);
      Controls.Add(lblDisciplina);
      Controls.Add(label2);
      Controls.Add(label3);
      Controls.Add(label4);
      Controls.Add(textDisciplina);
      Controls.Add(textSobrenomeProfessor);
      Controls.Add(textNomeProfessor);
      Controls.Add(textMatriculaProfessor);
      Controls.Add(lblCurso);
      Controls.Add(lblMatriculaAluno);
      Controls.Add(lblSobrenomeAluno);
      Controls.Add(lnlNomeAluno);
      Controls.Add(textCurso);
      Controls.Add(textSobrenomeAluno);
      Controls.Add(textNomeAluno);
      Controls.Add(textMatriculaAluno);
      Controls.Add(btnVoltar);
      Controls.Add(btnListarProfessores);
      Controls.Add(btnListarAlunos);
      Controls.Add(btnAddProfessor);
      Controls.Add(btnAddAluno);
      Name = "AdminForms";
      Text = "Admin";
      Load += AdminForm_Load;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btnAddAluno;
    private Button btnAddProfessor;
    private Button btnListarAlunos;
    private Button btnListarProfessores;
    private Button btnVoltar;
    private TextBox textMatriculaAluno;
    private TextBox textNomeAluno;
    private TextBox textSobrenomeAluno;
    private TextBox textCurso;
    private Label lnlNomeAluno;
    private Label lblSobrenomeAluno;
    private Label lblMatriculaAluno;
    private Label lblCurso;
    private Label lblDisciplina;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox textDisciplina;
    private TextBox textSobrenomeProfessor;
    private TextBox textNomeProfessor;
    private TextBox textMatriculaProfessor;
    private ListBox listAlunos;
    private ListBox listProfessores;
    private Button btnRemoverAluno;
    private Button btnRemoverProfessor;
    private Button btnLogin;
    private TextBox textUsuario;
    private TextBox textSenha;
    private Label lblUsuario;
    private Label lblSenha;
  }
}