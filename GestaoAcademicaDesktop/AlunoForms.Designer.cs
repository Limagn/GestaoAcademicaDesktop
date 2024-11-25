namespace GestaoAcademicaDesktop
{
  partial class AlunoForms
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
      btnApresentacao = new Button();
      btnAvaliarProfessor = new Button();
      btnVoltar = new Button();
      textMatriculaAluno = new TextBox();
      lblMatriculaAluno = new Label();
      btnConfirmaMatriculaAluno = new Button();
      lblMatriculaProfessor = new Label();
      textMatriculaProfessor = new TextBox();
      lblNotaProfessor = new Label();
      btnEnviar = new Button();
      numericNota = new NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)numericNota).BeginInit();
      SuspendLayout();
      // 
      // btnApresentacao
      // 
      btnApresentacao.Enabled = false;
      btnApresentacao.Location = new Point(297, 81);
      btnApresentacao.Name = "btnApresentacao";
      btnApresentacao.Size = new Size(130, 23);
      btnApresentacao.TabIndex = 2;
      btnApresentacao.Text = "Apresentação";
      btnApresentacao.UseVisualStyleBackColor = true;
      btnApresentacao.Click += btnApresentacao_Click;
      // 
      // btnAvaliarProfessor
      // 
      btnAvaliarProfessor.Enabled = false;
      btnAvaliarProfessor.Location = new Point(297, 129);
      btnAvaliarProfessor.Name = "btnAvaliarProfessor";
      btnAvaliarProfessor.Size = new Size(130, 23);
      btnAvaliarProfessor.TabIndex = 3;
      btnAvaliarProfessor.Text = "Avaliar Professor";
      btnAvaliarProfessor.UseVisualStyleBackColor = true;
      btnAvaliarProfessor.Click += btnAvaliarProfessor_Click;
      // 
      // btnVoltar
      // 
      btnVoltar.Location = new Point(229, 234);
      btnVoltar.Name = "btnVoltar";
      btnVoltar.Size = new Size(130, 23);
      btnVoltar.TabIndex = 7;
      btnVoltar.Text = "Voltar";
      btnVoltar.UseVisualStyleBackColor = true;
      btnVoltar.Click += btnVoltar_Click;
      // 
      // textMatriculaAluno
      // 
      textMatriculaAluno.Location = new Point(180, 35);
      textMatriculaAluno.Name = "textMatriculaAluno";
      textMatriculaAluno.Size = new Size(111, 23);
      textMatriculaAluno.TabIndex = 0;
      // 
      // lblMatriculaAluno
      // 
      lblMatriculaAluno.AutoSize = true;
      lblMatriculaAluno.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblMatriculaAluno.Location = new Point(100, 38);
      lblMatriculaAluno.Name = "lblMatriculaAluno";
      lblMatriculaAluno.Size = new Size(74, 20);
      lblMatriculaAluno.TabIndex = 10;
      lblMatriculaAluno.Text = "Matrícula:";
      // 
      // btnConfirmaMatriculaAluno
      // 
      btnConfirmaMatriculaAluno.Location = new Point(297, 35);
      btnConfirmaMatriculaAluno.Name = "btnConfirmaMatriculaAluno";
      btnConfirmaMatriculaAluno.Size = new Size(130, 23);
      btnConfirmaMatriculaAluno.TabIndex = 1;
      btnConfirmaMatriculaAluno.Text = "Confirmar Matrícula";
      btnConfirmaMatriculaAluno.UseVisualStyleBackColor = true;
      btnConfirmaMatriculaAluno.Click += btnConfirmaMatricula_Click;
      // 
      // lblMatriculaProfessor
      // 
      lblMatriculaProfessor.AutoSize = true;
      lblMatriculaProfessor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblMatriculaProfessor.Location = new Point(35, 132);
      lblMatriculaProfessor.Name = "lblMatriculaProfessor";
      lblMatriculaProfessor.Size = new Size(139, 20);
      lblMatriculaProfessor.TabIndex = 11;
      lblMatriculaProfessor.Text = "Matrícula Professor:";
      // 
      // textMatriculaProfessor
      // 
      textMatriculaProfessor.Enabled = false;
      textMatriculaProfessor.Location = new Point(180, 129);
      textMatriculaProfessor.Name = "textMatriculaProfessor";
      textMatriculaProfessor.Size = new Size(111, 23);
      textMatriculaProfessor.TabIndex = 4;
      textMatriculaProfessor.TextChanged += textMatriculaProfessor_TextChanged;
      // 
      // lblNotaProfessor
      // 
      lblNotaProfessor.AutoSize = true;
      lblNotaProfessor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblNotaProfessor.Location = new Point(129, 180);
      lblNotaProfessor.Name = "lblNotaProfessor";
      lblNotaProfessor.Size = new Size(45, 20);
      lblNotaProfessor.TabIndex = 12;
      lblNotaProfessor.Text = "Nota:";
      // 
      // btnEnviar
      // 
      btnEnviar.Enabled = false;
      btnEnviar.Location = new Point(297, 177);
      btnEnviar.Name = "btnEnviar";
      btnEnviar.Size = new Size(130, 23);
      btnEnviar.TabIndex = 6;
      btnEnviar.Text = "Enviar";
      btnEnviar.UseVisualStyleBackColor = true;
      btnEnviar.Click += btnEnviar_Click;
      // 
      // numericNota
      // 
      numericNota.Enabled = false;
      numericNota.Location = new Point(180, 177);
      numericNota.Name = "numericNota";
      numericNota.Size = new Size(111, 23);
      numericNota.TabIndex = 5;
      numericNota.ValueChanged += numericNota_ValueChanged;
      // 
      // AlunoForms
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(517, 309);
      Controls.Add(numericNota);
      Controls.Add(btnEnviar);
      Controls.Add(lblNotaProfessor);
      Controls.Add(lblMatriculaProfessor);
      Controls.Add(textMatriculaProfessor);
      Controls.Add(btnConfirmaMatriculaAluno);
      Controls.Add(lblMatriculaAluno);
      Controls.Add(textMatriculaAluno);
      Controls.Add(btnVoltar);
      Controls.Add(btnAvaliarProfessor);
      Controls.Add(btnApresentacao);
      Name = "AlunoForms";
      Text = "Aluno";
      Load += AlunoForms_Load;
      ((System.ComponentModel.ISupportInitialize)numericNota).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btnApresentacao;
    private Button btnAvaliarProfessor;
    private Button btnVoltar;
    private TextBox textMatriculaAluno;
    private Label lblMatriculaAluno;
    private Button btnConfirmaMatriculaAluno;
    private Label lblMatriculaProfessor;
    private TextBox textMatriculaProfessor;
    private Label lblNotaProfessor;
    private Button btnEnviar;
    private NumericUpDown numericNota;
  }
}