namespace GestaoAcademicaDesktop
{
  partial class ProfessorForms
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
      numericNota = new NumericUpDown();
      btnEnviar = new Button();
      lblNotaAluno = new Label();
      lblMatriculaAluno = new Label();
      textMatriculaAluno = new TextBox();
      btnConfirmaMatriculaProfessor = new Button();
      lblMatriculaProfessor = new Label();
      textMatriculaProfessor = new TextBox();
      btnVoltar = new Button();
      btnAvaliarAluno = new Button();
      btnApresentacao = new Button();
      ((System.ComponentModel.ISupportInitialize)numericNota).BeginInit();
      SuspendLayout();
      // 
      // numericNota
      // 
      numericNota.Enabled = false;
      numericNota.Location = new Point(181, 180);
      numericNota.Name = "numericNota";
      numericNota.Size = new Size(111, 23);
      numericNota.TabIndex = 18;
      numericNota.ValueChanged += numericNota_ValueChanged;
      // 
      // btnEnviar
      // 
      btnEnviar.Enabled = false;
      btnEnviar.Location = new Point(298, 180);
      btnEnviar.Name = "btnEnviar";
      btnEnviar.Size = new Size(130, 23);
      btnEnviar.TabIndex = 19;
      btnEnviar.Text = "Enviar";
      btnEnviar.UseVisualStyleBackColor = true;
      btnEnviar.Click += btnEnviar_Click;
      // 
      // lblNotaAluno
      // 
      lblNotaAluno.AutoSize = true;
      lblNotaAluno.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblNotaAluno.Location = new Point(130, 183);
      lblNotaAluno.Name = "lblNotaAluno";
      lblNotaAluno.Size = new Size(45, 20);
      lblNotaAluno.TabIndex = 23;
      lblNotaAluno.Text = "Nota:";
      // 
      // lblMatriculaAluno
      // 
      lblMatriculaAluno.AutoSize = true;
      lblMatriculaAluno.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblMatriculaAluno.Location = new Point(58, 135);
      lblMatriculaAluno.Name = "lblMatriculaAluno";
      lblMatriculaAluno.Size = new Size(117, 20);
      lblMatriculaAluno.TabIndex = 22;
      lblMatriculaAluno.Text = "Matrícula Aluno:";
      // 
      // textMatriculaAluno
      // 
      textMatriculaAluno.Enabled = false;
      textMatriculaAluno.Location = new Point(181, 132);
      textMatriculaAluno.Name = "textMatriculaAluno";
      textMatriculaAluno.Size = new Size(111, 23);
      textMatriculaAluno.TabIndex = 17;
      textMatriculaAluno.TextChanged += textMatriculaAluno_TextChanged;
      // 
      // btnConfirmaMatriculaProfessor
      // 
      btnConfirmaMatriculaProfessor.Location = new Point(298, 38);
      btnConfirmaMatriculaProfessor.Name = "btnConfirmaMatriculaProfessor";
      btnConfirmaMatriculaProfessor.Size = new Size(130, 23);
      btnConfirmaMatriculaProfessor.TabIndex = 14;
      btnConfirmaMatriculaProfessor.Text = "Confirmar Matrícula";
      btnConfirmaMatriculaProfessor.UseVisualStyleBackColor = true;
      btnConfirmaMatriculaProfessor.Click += btnConfirmaMatriculaProfessor_Click;
      // 
      // lblMatriculaProfessor
      // 
      lblMatriculaProfessor.AutoSize = true;
      lblMatriculaProfessor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      lblMatriculaProfessor.Location = new Point(101, 41);
      lblMatriculaProfessor.Name = "lblMatriculaProfessor";
      lblMatriculaProfessor.Size = new Size(74, 20);
      lblMatriculaProfessor.TabIndex = 21;
      lblMatriculaProfessor.Text = "Matrícula:";
      // 
      // textMatriculaProfessor
      // 
      textMatriculaProfessor.Location = new Point(181, 38);
      textMatriculaProfessor.Name = "textMatriculaProfessor";
      textMatriculaProfessor.Size = new Size(111, 23);
      textMatriculaProfessor.TabIndex = 13;
      // 
      // btnVoltar
      // 
      btnVoltar.Location = new Point(230, 237);
      btnVoltar.Name = "btnVoltar";
      btnVoltar.Size = new Size(130, 23);
      btnVoltar.TabIndex = 20;
      btnVoltar.Text = "Voltar";
      btnVoltar.UseVisualStyleBackColor = true;
      btnVoltar.Click += btnVoltar_Click;
      // 
      // btnAvaliarAluno
      // 
      btnAvaliarAluno.Enabled = false;
      btnAvaliarAluno.Location = new Point(298, 132);
      btnAvaliarAluno.Name = "btnAvaliarAluno";
      btnAvaliarAluno.Size = new Size(130, 23);
      btnAvaliarAluno.TabIndex = 16;
      btnAvaliarAluno.Text = "Avaliar Aluno";
      btnAvaliarAluno.UseVisualStyleBackColor = true;
      btnAvaliarAluno.Click += btnAvaliarAluno_Click;
      // 
      // btnApresentacao
      // 
      btnApresentacao.Enabled = false;
      btnApresentacao.Location = new Point(298, 84);
      btnApresentacao.Name = "btnApresentacao";
      btnApresentacao.Size = new Size(130, 23);
      btnApresentacao.TabIndex = 15;
      btnApresentacao.Text = "Apresentação";
      btnApresentacao.UseVisualStyleBackColor = true;
      btnApresentacao.Click += btnApresentacao_Click;
      // 
      // ProfessorForms
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(517, 310);
      Controls.Add(numericNota);
      Controls.Add(btnEnviar);
      Controls.Add(lblNotaAluno);
      Controls.Add(lblMatriculaAluno);
      Controls.Add(textMatriculaAluno);
      Controls.Add(btnConfirmaMatriculaProfessor);
      Controls.Add(lblMatriculaProfessor);
      Controls.Add(textMatriculaProfessor);
      Controls.Add(btnVoltar);
      Controls.Add(btnAvaliarAluno);
      Controls.Add(btnApresentacao);
      Name = "ProfessorForms";
      Text = "Professor";
      Load += ProfessorForms_Load;
      ((System.ComponentModel.ISupportInitialize)numericNota).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private NumericUpDown numericNota;
    private Button btnEnviar;
    private Label lblNotaAluno;
    private Label lblMatriculaAluno;
    private TextBox textMatriculaAluno;
    private Button btnConfirmaMatriculaProfessor;
    private Label lblMatriculaProfessor;
    private TextBox textMatriculaProfessor;
    private Button btnVoltar;
    private Button btnAvaliarAluno;
    private Button btnApresentacao;
  }
}