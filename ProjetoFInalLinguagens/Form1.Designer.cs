namespace ProjetoFInalLinguagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            Cadastrar = new TabPage();
            btnCalcular = new Button();
            lblResultadoPreco = new Label();
            cbPlaca = new ComboBox();
            label2 = new Label();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtCPF = new TextBox();
            lblCPF = new Label();
            btnCadastroAluguel = new Button();
            lblPreco = new Label();
            dtRetorno = new DateTimePicker();
            lblretorno = new Label();
            dtSaida = new DateTimePicker();
            lblSaida = new Label();
            cbVeiculo = new ComboBox();
            lblVeiculo = new Label();
            txtName = new TextBox();
            lblName = new Label();
            Buscar = new TabPage();
            textBox2 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            MODELO = new DataGridViewTextBoxColumn();
            PLACA = new DataGridViewTextBoxColumn();
            CLIENTE = new DataGridViewTextBoxColumn();
            Alterar = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            Cadastrar.SuspendLayout();
            Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(257, 65);
            label1.Name = "label1";
            label1.Size = new Size(487, 133);
            label1.TabIndex = 1;
            label1.Text = "CARental";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Cadastrar);
            tabControl1.Controls.Add(Buscar);
            tabControl1.Controls.Add(Alterar);
            tabControl1.Location = new Point(111, 210);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(727, 435);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 2;
            // 
            // Cadastrar
            // 
            Cadastrar.Controls.Add(btnCalcular);
            Cadastrar.Controls.Add(lblResultadoPreco);
            Cadastrar.Controls.Add(cbPlaca);
            Cadastrar.Controls.Add(label2);
            Cadastrar.Controls.Add(txtTelefone);
            Cadastrar.Controls.Add(lblTelefone);
            Cadastrar.Controls.Add(txtCPF);
            Cadastrar.Controls.Add(lblCPF);
            Cadastrar.Controls.Add(btnCadastroAluguel);
            Cadastrar.Controls.Add(lblPreco);
            Cadastrar.Controls.Add(dtRetorno);
            Cadastrar.Controls.Add(lblretorno);
            Cadastrar.Controls.Add(dtSaida);
            Cadastrar.Controls.Add(lblSaida);
            Cadastrar.Controls.Add(cbVeiculo);
            Cadastrar.Controls.Add(lblVeiculo);
            Cadastrar.Controls.Add(txtName);
            Cadastrar.Controls.Add(lblName);
            Cadastrar.Location = new Point(4, 24);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Padding = new Padding(3);
            Cadastrar.Size = new Size(719, 407);
            Cadastrar.TabIndex = 0;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Image = (Image)resources.GetObject("btnCalcular.Image");
            btnCalcular.Location = new Point(633, 213);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(38, 39);
            btnCalcular.TabIndex = 3;
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultadoPreco
            // 
            lblResultadoPreco.AutoSize = true;
            lblResultadoPreco.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultadoPreco.Location = new Point(200, 265);
            lblResultadoPreco.Name = "lblResultadoPreco";
            lblResultadoPreco.Size = new Size(48, 32);
            lblResultadoPreco.TabIndex = 28;
            lblResultadoPreco.Text = "R$ ";
            // 
            // cbPlaca
            // 
            cbPlaca.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbPlaca.Font = new Font("Segoe UI", 12F);
            cbPlaca.FormattingEnabled = true;
            cbPlaca.Location = new Point(499, 148);
            cbPlaca.Margin = new Padding(3, 2, 3, 2);
            cbPlaca.Name = "cbPlaca";
            cbPlaca.Size = new Size(191, 29);
            cbPlaca.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(420, 145);
            label2.Name = "label2";
            label2.Size = new Size(73, 32);
            label2.TabIndex = 25;
            label2.Text = "Placa:";
            // 
            // txtTelefone
            // 
            txtTelefone.Cursor = Cursors.IBeam;
            txtTelefone.Location = new Point(199, 100);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(234, 32);
            txtTelefone.TabIndex = 24;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 18F);
            lblTelefone.Location = new Point(71, 100);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(111, 32);
            lblTelefone.TabIndex = 23;
            lblTelefone.Text = "Telefone:";
            // 
            // txtCPF
            // 
            txtCPF.Cursor = Cursors.IBeam;
            txtCPF.Location = new Point(200, 62);
            txtCPF.Multiline = true;
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(234, 32);
            txtCPF.TabIndex = 22;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Segoe UI", 18F);
            lblCPF.Location = new Point(128, 62);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(59, 32);
            lblCPF.TabIndex = 21;
            lblCPF.Text = "CPF:";
            // 
            // btnCadastroAluguel
            // 
            btnCadastroAluguel.BackColor = Color.YellowGreen;
            btnCadastroAluguel.Cursor = Cursors.Hand;
            btnCadastroAluguel.DialogResult = DialogResult.Continue;
            btnCadastroAluguel.Image = (Image)resources.GetObject("btnCadastroAluguel.Image");
            btnCadastroAluguel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastroAluguel.Location = new Point(320, 304);
            btnCadastroAluguel.Name = "btnCadastroAluguel";
            btnCadastroAluguel.Size = new Size(136, 38);
            btnCadastroAluguel.TabIndex = 20;
            btnCadastroAluguel.Text = "ALUGAR";
            btnCadastroAluguel.UseVisualStyleBackColor = false;
            btnCadastroAluguel.Click += btnCadastroAluguel_Click;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 18F);
            lblPreco.Location = new Point(18, 265);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(164, 32);
            lblPreco.TabIndex = 16;
            lblPreco.Text = "Preço aluguel:";
            // 
            // dtRetorno
            // 
            dtRetorno.Format = DateTimePickerFormat.Short;
            dtRetorno.Location = new Point(199, 229);
            dtRetorno.Name = "dtRetorno";
            dtRetorno.Size = new Size(389, 23);
            dtRetorno.TabIndex = 15;
            // 
            // lblretorno
            // 
            lblretorno.AutoSize = true;
            lblretorno.Font = new Font("Segoe UI", 18F);
            lblretorno.Location = new Point(18, 221);
            lblretorno.Name = "lblretorno";
            lblretorno.Size = new Size(161, 32);
            lblretorno.TabIndex = 14;
            lblretorno.Text = "Data  retorno:";
            // 
            // dtSaida
            // 
            dtSaida.Format = DateTimePickerFormat.Short;
            dtSaida.Location = new Point(199, 192);
            dtSaida.Name = "dtSaida";
            dtSaida.Size = new Size(389, 23);
            dtSaida.TabIndex = 13;
            // 
            // lblSaida
            // 
            lblSaida.AutoSize = true;
            lblSaida.Font = new Font("Segoe UI", 18F);
            lblSaida.Location = new Point(16, 183);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(163, 32);
            lblSaida.TabIndex = 12;
            lblSaida.Text = "Data de saida:";
            // 
            // cbVeiculo
            // 
            cbVeiculo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbVeiculo.Font = new Font("Segoe UI", 12F);
            cbVeiculo.FormattingEnabled = true;
            cbVeiculo.Location = new Point(200, 145);
            cbVeiculo.Margin = new Padding(3, 2, 3, 2);
            cbVeiculo.Name = "cbVeiculo";
            cbVeiculo.Size = new Size(191, 29);
            cbVeiculo.TabIndex = 11;
            cbVeiculo.SelectedIndexChanged += cbVeiculo_SelectedIndexChanged;
            // 
            // lblVeiculo
            // 
            lblVeiculo.AutoSize = true;
            lblVeiculo.Font = new Font("Segoe UI", 18F);
            lblVeiculo.Location = new Point(3, 142);
            lblVeiculo.Name = "lblVeiculo";
            lblVeiculo.Size = new Size(192, 32);
            lblVeiculo.TabIndex = 2;
            lblVeiculo.Text = "Modelo veículo: ";
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.IBeam;
            txtName.Location = new Point(199, 21);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(389, 32);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 18F);
            lblName.Location = new Point(6, 21);
            lblName.Name = "lblName";
            lblName.Size = new Size(197, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Nome locatário : ";
            // 
            // Buscar
            // 
            Buscar.Controls.Add(textBox2);
            Buscar.Controls.Add(label5);
            Buscar.Controls.Add(button1);
            Buscar.Controls.Add(textBox1);
            Buscar.Controls.Add(comboBox1);
            Buscar.Controls.Add(label4);
            Buscar.Controls.Add(label3);
            Buscar.Controls.Add(dataGridView1);
            Buscar.Location = new Point(4, 24);
            Buscar.Name = "Buscar";
            Buscar.Padding = new Padding(3);
            Buscar.Size = new Size(719, 407);
            Buscar.TabIndex = 1;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(403, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 23);
            textBox2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 45);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 15;
            label5.Text = "CPF:";
            // 
            // button1
            // 
            button1.Location = new Point(309, 140);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 83);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 29);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 91);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Carro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 45);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 1;
            label3.Text = "Cliente: ";
            label3.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MODELO, PLACA, CLIENTE });
            dataGridView1.Location = new Point(72, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(557, 150);
            dataGridView1.TabIndex = 0;
            // 
            // MODELO
            // 
            MODELO.HeaderText = "MODELO";
            MODELO.Name = "MODELO";
            // 
            // PLACA
            // 
            PLACA.HeaderText = "PLACA";
            PLACA.Name = "PLACA";
            // 
            // CLIENTE
            // 
            CLIENTE.HeaderText = "CLIENTE";
            CLIENTE.Name = "CLIENTE";
            // 
            // Alterar
            // 
            Alterar.Location = new Point(4, 24);
            Alterar.Name = "Alterar";
            Alterar.Size = new Size(719, 407);
            Alterar.TabIndex = 2;
            Alterar.Text = "Alterar";
            Alterar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(1009, 666);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            Cadastrar.ResumeLayout(false);
            Cadastrar.PerformLayout();
            Buscar.ResumeLayout(false);
            Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage Cadastrar;
        private TabPage Buscar;
        private TabPage Alterar;
        private TextBox txtName;
        private Label lblName;
        private Label lblVeiculo;
        private DateTimePicker dtRetorno;
        private Label lblretorno;
        private DateTimePicker dtSaida;
        private Label lblSaida;
        private ComboBox cbVeiculo;
        private Label lblPreco;
        private Button btnCadastroAluguel;
        private Label label2;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtCPF;
        private Label lblCPF;
        private ComboBox cbPlaca;
        private Label lblResultadoPreco;
        private Button btnCalcular;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MODELO;
        private DataGridViewTextBoxColumn PLACA;
        private DataGridViewTextBoxColumn CLIENTE;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}
