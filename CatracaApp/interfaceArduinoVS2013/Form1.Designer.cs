namespace interfaceArduinoVS2013
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblID = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPW1 = new System.Windows.Forms.TextBox();
            this.textBoxPW2 = new System.Windows.Forms.TextBox();
            this.textBoxPW3 = new System.Windows.Forms.TextBox();
            this.textBoxPW4 = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.textBoxReceber = new System.Windows.Forms.TextBox();
            this.tabUpdate = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxId3 = new System.Windows.Forms.TextBox();
            this.textBoxId2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExibirPorId = new System.Windows.Forms.TextBox();
            this.btnExibirPorId = new System.Windows.Forms.Button();
            this.btnAtivo = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.txtDelete3 = new System.Windows.Forms.TextBox();
            this.txtDelete2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxNovoStatus = new System.Windows.Forms.TextBox();
            this.txtBoxIdStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAlterarStatus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNovaSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdSenha = new System.Windows.Forms.TextBox();
            this.btnSenha = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.btConectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSincPicToDb = new System.Windows.Forms.Button();
            this.btnSincDbToPic = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabUpdate.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblID.Location = new System.Drawing.Point(64, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSenha.Location = new System.Drawing.Point(63, 75);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStatus.Location = new System.Drawing.Point(63, 105);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxID.Location = new System.Drawing.Point(129, 46);
            this.textBoxID.MaxLength = 1;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(26, 20);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxPW1
            // 
            this.textBoxPW1.Location = new System.Drawing.Point(129, 72);
            this.textBoxPW1.MaxLength = 1;
            this.textBoxPW1.Name = "textBoxPW1";
            this.textBoxPW1.PasswordChar = '#';
            this.textBoxPW1.Size = new System.Drawing.Size(26, 20);
            this.textBoxPW1.TabIndex = 4;
            this.textBoxPW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPW1.TextChanged += new System.EventHandler(this.textBoxPW1_TextChanged);
            // 
            // textBoxPW2
            // 
            this.textBoxPW2.Location = new System.Drawing.Point(161, 72);
            this.textBoxPW2.MaxLength = 1;
            this.textBoxPW2.Name = "textBoxPW2";
            this.textBoxPW2.PasswordChar = '#';
            this.textBoxPW2.Size = new System.Drawing.Size(26, 20);
            this.textBoxPW2.TabIndex = 5;
            this.textBoxPW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPW2.TextChanged += new System.EventHandler(this.textBoxPW2_TextChanged);
            // 
            // textBoxPW3
            // 
            this.textBoxPW3.Location = new System.Drawing.Point(193, 72);
            this.textBoxPW3.MaxLength = 1;
            this.textBoxPW3.Name = "textBoxPW3";
            this.textBoxPW3.PasswordChar = '#';
            this.textBoxPW3.Size = new System.Drawing.Size(26, 20);
            this.textBoxPW3.TabIndex = 6;
            this.textBoxPW3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPW3.TextChanged += new System.EventHandler(this.textBoxPW3_TextChanged);
            // 
            // textBoxPW4
            // 
            this.textBoxPW4.Location = new System.Drawing.Point(225, 72);
            this.textBoxPW4.MaxLength = 1;
            this.textBoxPW4.Name = "textBoxPW4";
            this.textBoxPW4.PasswordChar = '#';
            this.textBoxPW4.Size = new System.Drawing.Size(26, 20);
            this.textBoxPW4.TabIndex = 7;
            this.textBoxPW4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPW4.TextChanged += new System.EventHandler(this.textBoxPW4_TextChanged);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(129, 98);
            this.textBoxStatus.MaxLength = 1;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(26, 20);
            this.textBoxStatus.TabIndex = 8;
            this.textBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(64, 136);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 26);
            this.btnEnviar.TabIndex = 14;
            this.btnEnviar.Text = "Cadastrar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // textBoxReceber
            // 
            this.textBoxReceber.Location = new System.Drawing.Point(0, 436);
            this.textBoxReceber.Multiline = true;
            this.textBoxReceber.Name = "textBoxReceber";
            this.textBoxReceber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceber.Size = new System.Drawing.Size(10, 10);
            this.textBoxReceber.TabIndex = 4;
            this.textBoxReceber.TextChanged += new System.EventHandler(this.textBoxReceber_TextChanged);
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.tabPage1);
            this.tabUpdate.Controls.Add(this.tabPage2);
            this.tabUpdate.Controls.Add(this.tabDelete);
            this.tabUpdate.Controls.Add(this.tabPage3);
            this.tabUpdate.Controls.Add(this.tabPage4);
            this.tabUpdate.Controls.Add(this.tabPage5);
            this.tabUpdate.Location = new System.Drawing.Point(0, -2);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.SelectedIndex = 0;
            this.tabUpdate.Size = new System.Drawing.Size(338, 273);
            this.tabUpdate.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.OliveDrab;
            this.tabPage1.Controls.Add(this.textBoxId3);
            this.tabPage1.Controls.Add(this.textBoxId2);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnEnviar);
            this.tabPage1.Controls.Add(this.textBoxStatus);
            this.tabPage1.Controls.Add(this.textBoxID);
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.textBoxPW4);
            this.tabPage1.Controls.Add(this.lblID);
            this.tabPage1.Controls.Add(this.textBoxPW3);
            this.tabPage1.Controls.Add(this.lblSenha);
            this.tabPage1.Controls.Add(this.textBoxPW2);
            this.tabPage1.Controls.Add(this.textBoxPW1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(330, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBoxId3
            // 
            this.textBoxId3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxId3.Location = new System.Drawing.Point(193, 46);
            this.textBoxId3.MaxLength = 1;
            this.textBoxId3.Name = "textBoxId3";
            this.textBoxId3.Size = new System.Drawing.Size(26, 20);
            this.textBoxId3.TabIndex = 3;
            this.textBoxId3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxId3.TextChanged += new System.EventHandler(this.textBoxId3_TextChanged);
            // 
            // textBoxId2
            // 
            this.textBoxId2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxId2.Location = new System.Drawing.Point(161, 46);
            this.textBoxId2.MaxLength = 1;
            this.textBoxId2.Name = "textBoxId2";
            this.textBoxId2.Size = new System.Drawing.Size(26, 20);
            this.textBoxId2.TabIndex = 2;
            this.textBoxId2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxId2.TextChanged += new System.EventHandler(this.textBoxId2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(69, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cadastrar novo usuário";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtExibirPorId);
            this.tabPage2.Controls.Add(this.btnExibirPorId);
            this.tabPage2.Controls.Add(this.btnAtivo);
            this.tabPage2.Controls.Add(this.btnExibir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(330, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(100, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Consultar usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(119, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Informe o ID";
            // 
            // txtExibirPorId
            // 
            this.txtExibirPorId.Location = new System.Drawing.Point(101, 58);
            this.txtExibirPorId.MaxLength = 3;
            this.txtExibirPorId.Name = "txtExibirPorId";
            this.txtExibirPorId.Size = new System.Drawing.Size(119, 20);
            this.txtExibirPorId.TabIndex = 3;
            this.txtExibirPorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExibirPorId.TextChanged += new System.EventHandler(this.txtExibirPorId_TextChanged);
            // 
            // btnExibirPorId
            // 
            this.btnExibirPorId.Location = new System.Drawing.Point(101, 95);
            this.btnExibirPorId.Name = "btnExibirPorId";
            this.btnExibirPorId.Size = new System.Drawing.Size(119, 26);
            this.btnExibirPorId.TabIndex = 2;
            this.btnExibirPorId.Text = "Exibir por Id";
            this.btnExibirPorId.UseVisualStyleBackColor = true;
            this.btnExibirPorId.Click += new System.EventHandler(this.btnExibirPorId_Click);
            // 
            // btnAtivo
            // 
            this.btnAtivo.Location = new System.Drawing.Point(101, 138);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Size = new System.Drawing.Size(119, 23);
            this.btnAtivo.TabIndex = 1;
            this.btnAtivo.Text = "Clientes ativos";
            this.btnAtivo.UseVisualStyleBackColor = true;
            this.btnAtivo.Click += new System.EventHandler(this.btnAtivo_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(101, 178);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(119, 27);
            this.btnExibir.TabIndex = 0;
            this.btnExibir.Text = "Exibir todos clientes";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // tabDelete
            // 
            this.tabDelete.BackColor = System.Drawing.Color.MediumPurple;
            this.tabDelete.Controls.Add(this.txtDelete3);
            this.tabDelete.Controls.Add(this.txtDelete2);
            this.tabDelete.Controls.Add(this.label9);
            this.tabDelete.Controls.Add(this.label1);
            this.tabDelete.Controls.Add(this.txtDelete);
            this.tabDelete.Controls.Add(this.btnDelete);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(330, 247);
            this.tabDelete.TabIndex = 2;
            this.tabDelete.Text = "Deletar";
            this.tabDelete.Click += new System.EventHandler(this.tabDelete_Click);
            // 
            // txtDelete3
            // 
            this.txtDelete3.Location = new System.Drawing.Point(181, 61);
            this.txtDelete3.MaxLength = 1;
            this.txtDelete3.Name = "txtDelete3";
            this.txtDelete3.Size = new System.Drawing.Size(28, 20);
            this.txtDelete3.TabIndex = 5;
            this.txtDelete3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelete3.TextChanged += new System.EventHandler(this.txtDelete3_TextChanged);
            // 
            // txtDelete2
            // 
            this.txtDelete2.Location = new System.Drawing.Point(147, 61);
            this.txtDelete2.MaxLength = 1;
            this.txtDelete2.Name = "txtDelete2";
            this.txtDelete2.Size = new System.Drawing.Size(28, 20);
            this.txtDelete2.TabIndex = 4;
            this.txtDelete2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelete2.TextChanged += new System.EventHandler(this.txtDelete2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(106, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Deletar usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(125, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe o ID";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(113, 61);
            this.txtDelete.MaxLength = 1;
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(28, 20);
            this.txtDelete.TabIndex = 1;
            this.txtDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDelete.TextChanged += new System.EventHandler(this.txtDelete_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(110, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 27);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SpringGreen;
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtBoxNovoStatus);
            this.tabPage3.Controls.Add(this.txtBoxIdStatus);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnAlterarStatus);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBoxNovaSenha);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBoxIdSenha);
            this.tabPage3.Controls.Add(this.btnSenha);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(330, 247);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Alterar";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(108, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Alterar usuario";
            // 
            // txtBoxNovoStatus
            // 
            this.txtBoxNovoStatus.Location = new System.Drawing.Point(191, 131);
            this.txtBoxNovoStatus.MaxLength = 1;
            this.txtBoxNovoStatus.Name = "txtBoxNovoStatus";
            this.txtBoxNovoStatus.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNovoStatus.TabIndex = 5;
            this.txtBoxNovoStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxNovoStatus.TextChanged += new System.EventHandler(this.txtBoxNovoStatus_TextChanged);
            // 
            // txtBoxIdStatus
            // 
            this.txtBoxIdStatus.Location = new System.Drawing.Point(191, 93);
            this.txtBoxIdStatus.MaxLength = 3;
            this.txtBoxIdStatus.Name = "txtBoxIdStatus";
            this.txtBoxIdStatus.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIdStatus.TabIndex = 4;
            this.txtBoxIdStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxIdStatus.TextChanged += new System.EventHandler(this.txtBoxIdStatus_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Novo Status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Informe ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Alterar Status";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnAlterarStatus
            // 
            this.btnAlterarStatus.Location = new System.Drawing.Point(191, 157);
            this.btnAlterarStatus.Name = "btnAlterarStatus";
            this.btnAlterarStatus.Size = new System.Drawing.Size(103, 23);
            this.btnAlterarStatus.TabIndex = 6;
            this.btnAlterarStatus.Text = "Alterar";
            this.btnAlterarStatus.UseVisualStyleBackColor = true;
            this.btnAlterarStatus.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nova Senha";
            // 
            // textBoxNovaSenha
            // 
            this.textBoxNovaSenha.Location = new System.Drawing.Point(37, 131);
            this.textBoxNovaSenha.MaxLength = 4;
            this.textBoxNovaSenha.Name = "textBoxNovaSenha";
            this.textBoxNovaSenha.PasswordChar = '#';
            this.textBoxNovaSenha.Size = new System.Drawing.Size(100, 20);
            this.textBoxNovaSenha.TabIndex = 2;
            this.textBoxNovaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNovaSenha.TextChanged += new System.EventHandler(this.textBoxNovaSenha_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Informe ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alterar Senha";
            // 
            // textBoxIdSenha
            // 
            this.textBoxIdSenha.Location = new System.Drawing.Point(37, 93);
            this.textBoxIdSenha.MaxLength = 3;
            this.textBoxIdSenha.Name = "textBoxIdSenha";
            this.textBoxIdSenha.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdSenha.TabIndex = 1;
            this.textBoxIdSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIdSenha.TextChanged += new System.EventHandler(this.textBoxIdSenha_TextChanged);
            // 
            // btnSenha
            // 
            this.btnSenha.Location = new System.Drawing.Point(37, 157);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.Size = new System.Drawing.Size(100, 23);
            this.btnSenha.TabIndex = 3;
            this.btnSenha.Text = "Alterar";
            this.btnSenha.UseVisualStyleBackColor = true;
            this.btnSenha.Click += new System.EventHandler(this.btnSenha_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.OrangeRed;
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.btConectar);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(330, 247);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Conectar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(111, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Conexão serial ";
            // 
            // btConectar
            // 
            this.btConectar.BackColor = System.Drawing.Color.Aquamarine;
            this.btConectar.Location = new System.Drawing.Point(65, 77);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(81, 23);
            this.btConectar.TabIndex = 2;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = false;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.btnSincPicToDb);
            this.tabPage5.Controls.Add(this.btnSincDbToPic);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(330, 247);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Sincronizar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(65, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(205, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Sincronizar Banco de Dados";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(197, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "Download BD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(50, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Upload BD";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // btnSincPicToDb
            // 
            this.btnSincPicToDb.BackColor = System.Drawing.Color.Transparent;
            this.btnSincPicToDb.Location = new System.Drawing.Point(196, 103);
            this.btnSincPicToDb.Name = "btnSincPicToDb";
            this.btnSincPicToDb.Size = new System.Drawing.Size(75, 23);
            this.btnSincPicToDb.TabIndex = 1;
            this.btnSincPicToDb.Text = "Sincronizar";
            this.btnSincPicToDb.UseVisualStyleBackColor = false;
            this.btnSincPicToDb.Click += new System.EventHandler(this.btnSincPicToDb_Click);
            // 
            // btnSincDbToPic
            // 
            this.btnSincDbToPic.Location = new System.Drawing.Point(46, 103);
            this.btnSincDbToPic.Name = "btnSincDbToPic";
            this.btnSincDbToPic.Size = new System.Drawing.Size(75, 23);
            this.btnSincDbToPic.TabIndex = 0;
            this.btnSincDbToPic.Text = "Sincronizar";
            this.btnSincDbToPic.UseVisualStyleBackColor = true;
            this.btnSincDbToPic.Click += new System.EventHandler(this.btnSincDbToPic_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(4, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 199);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabUpdate);
            this.Controls.Add(this.textBoxReceber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CatracaApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabUpdate.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPW1;
        private System.Windows.Forms.TextBox textBoxPW2;
        private System.Windows.Forms.TextBox textBoxPW3;
        private System.Windows.Forms.TextBox textBoxPW4;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox textBoxReceber;
        private System.Windows.Forms.TabControl tabUpdate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAlterarStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNovaSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdSenha;
        private System.Windows.Forms.Button btnSenha;
        private System.Windows.Forms.TextBox txtBoxIdStatus;
        private System.Windows.Forms.TextBox txtBoxNovoStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExibirPorId;
        private System.Windows.Forms.Button btnExibirPorId;
        private System.Windows.Forms.Button btnAtivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDelete3;
        private System.Windows.Forms.TextBox txtDelete2;
        private System.Windows.Forms.TextBox textBoxId3;
        private System.Windows.Forms.TextBox textBoxId2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnSincPicToDb;
        private System.Windows.Forms.Button btnSincDbToPic;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer timer1;
    }
}

