namespace XPTO
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_DataNasc = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_SobreNome = new System.Windows.Forms.TextBox();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.txt_CPF = new System.Windows.Forms.TextBox();
            this.mask_DataNasc = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_Nao = new System.Windows.Forms.RadioButton();
            this.rbtn_Sim = new System.Windows.Forms.RadioButton();
            this.cbo_Vaga = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(134, 3);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(49, 15);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(483, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SobreNome *";
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Idade.Location = new System.Drawing.Point(677, 46);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(46, 15);
            this.lbl_Idade.TabIndex = 2;
            this.lbl_Idade.Text = "Idade *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(77, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Maior de Idade?  *";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CPF.Location = new System.Drawing.Point(530, 46);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(35, 15);
            this.lbl_CPF.TabIndex = 2;
            this.lbl_CPF.Text = "CPF *";
            // 
            // lbl_DataNasc
            // 
            this.lbl_DataNasc.AutoSize = true;
            this.lbl_DataNasc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DataNasc.Location = new System.Drawing.Point(54, 38);
            this.lbl_DataNasc.Name = "lbl_DataNasc";
            this.lbl_DataNasc.Size = new System.Drawing.Size(129, 15);
            this.lbl_DataNasc.TabIndex = 2;
            this.lbl_DataNasc.Text = "Data De Nascimento *";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(189, 3);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(226, 23);
            this.txt_Nome.TabIndex = 0;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            // 
            // txt_SobreNome
            // 
            this.txt_SobreNome.Location = new System.Drawing.Point(571, 3);
            this.txt_SobreNome.Name = "txt_SobreNome";
            this.txt_SobreNome.Size = new System.Drawing.Size(226, 23);
            this.txt_SobreNome.TabIndex = 1;
            // 
            // txt_Idade
            // 
            this.txt_Idade.Location = new System.Drawing.Point(724, 46);
            this.txt_Idade.MaxLength = 2;
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(73, 23);
            this.txt_Idade.TabIndex = 4;
            this.txt_Idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Idade_KeyPress);
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(571, 46);
            this.txt_CPF.MaxLength = 11;
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(100, 23);
            this.txt_CPF.TabIndex = 3;
            this.txt_CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CPF_KeyPress);
            // 
            // mask_DataNasc
            // 
            this.mask_DataNasc.Location = new System.Drawing.Point(189, 35);
            this.mask_DataNasc.Mask = "00/00/0000";
            this.mask_DataNasc.Name = "mask_DataNasc";
            this.mask_DataNasc.Size = new System.Drawing.Size(111, 23);
            this.mask_DataNasc.TabIndex = 2;
            this.mask_DataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rbtn_Nao);
            this.groupBox1.Controls.Add(this.rbtn_Sim);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(189, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 40);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rbtn_Nao
            // 
            this.rbtn_Nao.AutoSize = true;
            this.rbtn_Nao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_Nao.Location = new System.Drawing.Point(60, 13);
            this.rbtn_Nao.Name = "rbtn_Nao";
            this.rbtn_Nao.Size = new System.Drawing.Size(47, 19);
            this.rbtn_Nao.TabIndex = 1;
            this.rbtn_Nao.TabStop = true;
            this.rbtn_Nao.Text = "Não";
            this.rbtn_Nao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbtn_Nao.UseVisualStyleBackColor = true;
            // 
            // rbtn_Sim
            // 
            this.rbtn_Sim.AutoSize = true;
            this.rbtn_Sim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_Sim.Location = new System.Drawing.Point(8, 15);
            this.rbtn_Sim.Name = "rbtn_Sim";
            this.rbtn_Sim.Size = new System.Drawing.Size(46, 19);
            this.rbtn_Sim.TabIndex = 0;
            this.rbtn_Sim.TabStop = true;
            this.rbtn_Sim.Text = "Sim";
            this.rbtn_Sim.UseVisualStyleBackColor = true;
            // 
            // cbo_Vaga
            // 
            this.cbo_Vaga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Vaga.FormattingEnabled = true;
            this.cbo_Vaga.Items.AddRange(new object[] {
            "Trainee Engenharia\t",
            "Trainee Marketing",
            "Trainee Comercial",
            "Trainee TI",
            "Trainee Desenvolvedor"});
            this.cbo_Vaga.Location = new System.Drawing.Point(363, 96);
            this.cbo_Vaga.Name = "cbo_Vaga";
            this.cbo_Vaga.Size = new System.Drawing.Size(205, 23);
            this.cbo_Vaga.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Somente Numeros";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.dataGridViewTextBoxColumn1,
            this.CPF,
            this.DataNascimento,
            this.Idade,
            this.Vaga,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.Location = new System.Drawing.Point(53, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(744, 303);
            this.dataGridView1.TabIndex = 12;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "SobreNome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // DataNascimento
            // 
            this.DataNascimento.HeaderText = "Data De Nascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            // 
            // Vaga
            // 
            this.Vaga.HeaderText = "Vaga";
            this.Vaga.Name = "Vaga";
            this.Vaga.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Maior Idade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gravar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Gravar.Location = new System.Drawing.Point(652, 90);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(145, 33);
            this.btn_Gravar.TabIndex = 7;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = false;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Location = new System.Drawing.Point(53, 438);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(188, 37);
            this.btn_Salvar.TabIndex = 8;
            this.btn_Salvar.Text = "Salvar Lista";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(609, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Concluir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(363, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Selecione a Vaga *";
            // 
            // btn_Remover
            // 
            this.btn_Remover.BackColor = System.Drawing.Color.Red;
            this.btn_Remover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Remover.Location = new System.Drawing.Point(336, 438);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(188, 37);
            this.btn_Remover.TabIndex = 17;
            this.btn_Remover.Text = "REMOVER";
            this.btn_Remover.UseVisualStyleBackColor = false;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(831, 487);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_Vaga);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mask_DataNasc);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.txt_SobreNome);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_DataNasc);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Idade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XPTO Cadastro Trainee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Nome;
        private Label label2;
        private Label lbl_Idade;
        private Label label4;
        private Label lbl_CPF;
        private Label lbl_DataNasc;
        private TextBox txt_Nome;
        private TextBox txt_SobreNome;
        private TextBox txt_Idade;
        private TextBox txt_CPF;
        private MaskedTextBox mask_DataNasc;
        private GroupBox groupBox1;
        private RadioButton rbtn_Nao;
        private RadioButton rbtn_Sim;
        private ComboBox cbo_Vaga;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btn_Gravar;
        private Button btn_Salvar;
        private Button button3;
        private Label label1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn DataNascimento;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewTextBoxColumn Vaga;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button btn_Remover;
    }
}