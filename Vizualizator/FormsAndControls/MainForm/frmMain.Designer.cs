namespace FormsAndControls.MainForm.Vizualizator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.btnResetFire = new System.Windows.Forms.Button();
            this.btnOffBd = new System.Windows.Forms.Button();
            this.btnConvertDB = new System.Windows.Forms.Button();
            this.btnSelectDb = new System.Windows.Forms.Button();
            this.stateText = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnWorkWithComPort = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TypeASU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberPPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AboutZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.offOSU = new System.Windows.Forms.Label();
            this.flame = new System.Windows.Forms.Label();
            this.shortCircuit = new System.Windows.Forms.Label();
            this.countFlameLbl = new System.Windows.Forms.Label();
            this.disconnectOSU = new System.Windows.Forms.Label();
            this.countBreaksLbl = new System.Windows.Forms.Label();
            this.Breaks = new System.Windows.Forms.Label();
            this.countShortCircuitLbl = new System.Windows.Forms.Label();
            this.countDisconnectOsuLbl = new System.Windows.Forms.Label();
            this.countOffOsu = new System.Windows.Forms.Label();
            this.pnlState = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.themeButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectDataBaseFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlState.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.messageTextBox);
            this.panel1.Controls.Add(this.btnResetFire);
            this.panel1.Controls.Add(this.btnOffBd);
            this.panel1.Controls.Add(this.btnConvertDB);
            this.panel1.Controls.Add(this.btnSelectDb);
            this.panel1.Location = new System.Drawing.Point(0, 690);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 69);
            this.panel1.TabIndex = 0;
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageTextBox.Location = new System.Drawing.Point(346, 24);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(131, 26);
            this.messageTextBox.TabIndex = 7;
            // 
            // btnResetFire
            // 
            this.btnResetFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnResetFire.FlatAppearance.BorderSize = 0;
            this.btnResetFire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnResetFire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFire.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnResetFire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btnResetFire.Location = new System.Drawing.Point(633, 3);
            this.btnResetFire.Name = "btnResetFire";
            this.btnResetFire.Size = new System.Drawing.Size(154, 62);
            this.btnResetFire.TabIndex = 6;
            this.btnResetFire.Text = "Сброс пожара";
            this.btnResetFire.UseVisualStyleBackColor = false;
            // 
            // btnOffBd
            // 
            this.btnOffBd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnOffBd.FlatAppearance.BorderSize = 0;
            this.btnOffBd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOffBd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffBd.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOffBd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btnOffBd.Location = new System.Drawing.Point(483, 3);
            this.btnOffBd.Name = "btnOffBd";
            this.btnOffBd.Size = new System.Drawing.Size(147, 62);
            this.btnOffBd.TabIndex = 5;
            this.btnOffBd.Text = "Отключить БД";
            this.btnOffBd.UseVisualStyleBackColor = false;
            this.btnOffBd.Click += new System.EventHandler(this.btnOnData_Click);
            // 
            // btnConvertDB
            // 
            this.btnConvertDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnConvertDB.FlatAppearance.BorderSize = 0;
            this.btnConvertDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnConvertDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertDB.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvertDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btnConvertDB.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertDB.Image")));
            this.btnConvertDB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConvertDB.Location = new System.Drawing.Point(147, 2);
            this.btnConvertDB.Name = "btnConvertDB";
            this.btnConvertDB.Size = new System.Drawing.Size(193, 62);
            this.btnConvertDB.TabIndex = 1;
            this.btnConvertDB.Text = "Конвертация БД";
            this.btnConvertDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertDB.UseVisualStyleBackColor = false;
            // 
            // btnSelectDb
            // 
            this.btnSelectDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSelectDb.FlatAppearance.BorderSize = 0;
            this.btnSelectDb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnSelectDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDb.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectDb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btnSelectDb.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectDb.Image")));
            this.btnSelectDb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectDb.Location = new System.Drawing.Point(3, 3);
            this.btnSelectDb.Name = "btnSelectDb";
            this.btnSelectDb.Size = new System.Drawing.Size(138, 62);
            this.btnSelectDb.TabIndex = 0;
            this.btnSelectDb.Text = "Выбор БД";
            this.btnSelectDb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectDb.UseVisualStyleBackColor = false;
            this.btnSelectDb.Click += new System.EventHandler(this.btnSelectDB_Click);
            // 
            // stateText
            // 
            this.stateText.AutoSize = true;
            this.stateText.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.stateText.Location = new System.Drawing.Point(896, 7);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(110, 21);
            this.stateText.TabIndex = 12;
            this.stateText.Tag = "7";
            this.stateText.Text = "в ожидании";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.stateLabel.Location = new System.Drawing.Point(792, 7);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(110, 21);
            this.stateLabel.TabIndex = 11;
            this.stateLabel.Text = "Состояние:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.btnWorkWithComPort);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.btn);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(792, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 738);
            this.panel4.TabIndex = 2;
            // 
            // btnWorkWithComPort
            // 
            this.btnWorkWithComPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnWorkWithComPort.FlatAppearance.BorderSize = 0;
            this.btnWorkWithComPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnWorkWithComPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkWithComPort.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWorkWithComPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btnWorkWithComPort.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkWithComPort.Image")));
            this.btnWorkWithComPort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWorkWithComPort.Location = new System.Drawing.Point(1, 672);
            this.btnWorkWithComPort.Name = "btnWorkWithComPort";
            this.btnWorkWithComPort.Size = new System.Drawing.Size(407, 62);
            this.btnWorkWithComPort.TabIndex = 13;
            this.btnWorkWithComPort.Text = "Настройка подключение к COM-порту";
            this.btnWorkWithComPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkWithComPort.UseVisualStyleBackColor = false;
            this.btnWorkWithComPort.Click += new System.EventHandler(this.btnWorkWithComPort_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(200, 618);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(207, 55);
            this.button7.TabIndex = 12;
            this.button7.Text = "Удалить запись";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn.Location = new System.Drawing.Point(3, 618);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(194, 55);
            this.btn.TabIndex = 11;
            this.btn.Text = "Показать всё";
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.button5.Location = new System.Drawing.Point(316, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 26);
            this.button5.TabIndex = 10;
            this.button5.Text = "Нет приёма";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.button4.Location = new System.Drawing.Point(69, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 26);
            this.button4.TabIndex = 9;
            this.button4.Text = "Отключенны";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.button3.Location = new System.Drawing.Point(217, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 26);
            this.button3.TabIndex = 8;
            this.button3.Text = "К.замыкания";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.button2.Location = new System.Drawing.Point(157, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "Обрывы";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.button1.Location = new System.Drawing.Point(9, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Пожары";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeASU,
            this.LineNumber,
            this.NumberPPK,
            this.AboutZone,
            this.Date});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(404, 304);
            this.dataGridView1.TabIndex = 2;
            // 
            // TypeASU
            // 
            this.TypeASU.HeaderText = "Тип АСУ";
            this.TypeASU.Name = "TypeASU";
            this.TypeASU.ReadOnly = true;
            this.TypeASU.Width = 95;
            // 
            // LineNumber
            // 
            this.LineNumber.HeaderText = "№ Линии";
            this.LineNumber.Name = "LineNumber";
            this.LineNumber.ReadOnly = true;
            this.LineNumber.Width = 95;
            // 
            // NumberPPK
            // 
            this.NumberPPK.HeaderText = "№ ППК";
            this.NumberPPK.Name = "NumberPPK";
            this.NumberPPK.ReadOnly = true;
            this.NumberPPK.Width = 80;
            // 
            // AboutZone
            // 
            this.AboutZone.HeaderText = "Описание зоны";
            this.AboutZone.Name = "AboutZone";
            this.AboutZone.ReadOnly = true;
            this.AboutZone.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pnlState);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Состояние";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.offOSU);
            this.groupBox2.Controls.Add(this.flame);
            this.groupBox2.Controls.Add(this.shortCircuit);
            this.groupBox2.Controls.Add(this.countFlameLbl);
            this.groupBox2.Controls.Add(this.disconnectOSU);
            this.groupBox2.Controls.Add(this.countBreaksLbl);
            this.groupBox2.Controls.Add(this.Breaks);
            this.groupBox2.Controls.Add(this.countShortCircuitLbl);
            this.groupBox2.Controls.Add(this.countDisconnectOsuLbl);
            this.groupBox2.Controls.Add(this.countOffOsu);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(393, 173);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Количество";
            // 
            // offOSU
            // 
            this.offOSU.AutoSize = true;
            this.offOSU.Font = new System.Drawing.Font("JetBrains Mono", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.offOSU.Image = ((System.Drawing.Image)(resources.GetObject("offOSU.Image")));
            this.offOSU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.offOSU.Location = new System.Drawing.Point(16, 143);
            this.offOSU.Name = "offOSU";
            this.offOSU.Size = new System.Drawing.Size(210, 22);
            this.offOSU.TabIndex = 10;
            this.offOSU.Text = "    Отключенных АСУ:";
            // 
            // flame
            // 
            this.flame.AutoSize = true;
            this.flame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flame.Font = new System.Drawing.Font("JetBrains Mono", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flame.Image = ((System.Drawing.Image)(resources.GetObject("flame.Image")));
            this.flame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.flame.Location = new System.Drawing.Point(16, 31);
            this.flame.Name = "flame";
            this.flame.Size = new System.Drawing.Size(150, 22);
            this.flame.TabIndex = 6;
            this.flame.Text = "    Пожаров:  ";
            this.flame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shortCircuit
            // 
            this.shortCircuit.AutoSize = true;
            this.shortCircuit.Font = new System.Drawing.Font("JetBrains Mono", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shortCircuit.Image = ((System.Drawing.Image)(resources.GetObject("shortCircuit.Image")));
            this.shortCircuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shortCircuit.Location = new System.Drawing.Point(16, 88);
            this.shortCircuit.Name = "shortCircuit";
            this.shortCircuit.Size = new System.Drawing.Size(250, 22);
            this.shortCircuit.TabIndex = 8;
            this.shortCircuit.Text = "    Короткого замыкания:";
            // 
            // countFlameLbl
            // 
            this.countFlameLbl.AutoSize = true;
            this.countFlameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.countFlameLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countFlameLbl.Location = new System.Drawing.Point(294, 28);
            this.countFlameLbl.Name = "countFlameLbl";
            this.countFlameLbl.Size = new System.Drawing.Size(23, 25);
            this.countFlameLbl.TabIndex = 1;
            this.countFlameLbl.Tag = "2";
            this.countFlameLbl.Text = "0";
            this.countFlameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disconnectOSU
            // 
            this.disconnectOSU.AutoSize = true;
            this.disconnectOSU.Font = new System.Drawing.Font("JetBrains Mono", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disconnectOSU.Image = ((System.Drawing.Image)(resources.GetObject("disconnectOSU.Image")));
            this.disconnectOSU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disconnectOSU.Location = new System.Drawing.Point(16, 115);
            this.disconnectOSU.Name = "disconnectOSU";
            this.disconnectOSU.Size = new System.Drawing.Size(230, 22);
            this.disconnectOSU.TabIndex = 9;
            this.disconnectOSU.Text = "    Нет приёма от АСУ:";
            // 
            // countBreaksLbl
            // 
            this.countBreaksLbl.AutoSize = true;
            this.countBreaksLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.countBreaksLbl.Location = new System.Drawing.Point(294, 56);
            this.countBreaksLbl.Name = "countBreaksLbl";
            this.countBreaksLbl.Size = new System.Drawing.Size(23, 25);
            this.countBreaksLbl.TabIndex = 2;
            this.countBreaksLbl.Tag = "3";
            this.countBreaksLbl.Text = "0";
            this.countBreaksLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Breaks
            // 
            this.Breaks.AutoSize = true;
            this.Breaks.Font = new System.Drawing.Font("JetBrains Mono", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Breaks.Image = ((System.Drawing.Image)(resources.GetObject("Breaks.Image")));
            this.Breaks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Breaks.Location = new System.Drawing.Point(16, 59);
            this.Breaks.Name = "Breaks";
            this.Breaks.Size = new System.Drawing.Size(130, 22);
            this.Breaks.TabIndex = 7;
            this.Breaks.Text = "    Обрывов:";
            // 
            // countShortCircuitLbl
            // 
            this.countShortCircuitLbl.AutoSize = true;
            this.countShortCircuitLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.countShortCircuitLbl.Location = new System.Drawing.Point(294, 84);
            this.countShortCircuitLbl.Name = "countShortCircuitLbl";
            this.countShortCircuitLbl.Size = new System.Drawing.Size(23, 25);
            this.countShortCircuitLbl.TabIndex = 3;
            this.countShortCircuitLbl.Tag = "4";
            this.countShortCircuitLbl.Text = "0";
            this.countShortCircuitLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countDisconnectOsuLbl
            // 
            this.countDisconnectOsuLbl.AutoSize = true;
            this.countDisconnectOsuLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.countDisconnectOsuLbl.Location = new System.Drawing.Point(294, 112);
            this.countDisconnectOsuLbl.Name = "countDisconnectOsuLbl";
            this.countDisconnectOsuLbl.Size = new System.Drawing.Size(23, 25);
            this.countDisconnectOsuLbl.TabIndex = 4;
            this.countDisconnectOsuLbl.Tag = "5";
            this.countDisconnectOsuLbl.Text = "0";
            this.countDisconnectOsuLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countOffOsu
            // 
            this.countOffOsu.AutoSize = true;
            this.countOffOsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.countOffOsu.Location = new System.Drawing.Point(294, 140);
            this.countOffOsu.Name = "countOffOsu";
            this.countOffOsu.Size = new System.Drawing.Size(23, 25);
            this.countOffOsu.TabIndex = 5;
            this.countOffOsu.Tag = "6";
            this.countOffOsu.Text = "0";
            this.countOffOsu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlState
            // 
            this.pnlState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.pnlState.Controls.Add(this.label1);
            this.pnlState.Location = new System.Drawing.Point(6, 32);
            this.pnlState.Name = "pnlState";
            this.pnlState.Size = new System.Drawing.Size(393, 40);
            this.pnlState.TabIndex = 0;
            this.pnlState.Tag = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нормально";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.stateText);
            this.panel2.Controls.Add(this.themeButton);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.stateLabel);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1203, 30);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // themeButton
            // 
            this.themeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.themeButton.FlatAppearance.BorderSize = 0;
            this.themeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.themeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.themeButton.Image = global::Vizualizator.Properties.Resources.lightMode_l;
            this.themeButton.Location = new System.Drawing.Point(762, 0);
            this.themeButton.Name = "themeButton";
            this.themeButton.Size = new System.Drawing.Size(31, 29);
            this.themeButton.TabIndex = 10;
            this.themeButton.UseVisualStyleBackColor = false;
            this.themeButton.Click += new System.EventHandler(this.themeButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.label12.Location = new System.Drawing.Point(36, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Visualizer";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1173, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 597);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // selectDataBaseFile
            // 
            this.selectDataBaseFile.DefaultExt = "mdb";
            this.selectDataBaseFile.FileName = "dataBase";
            this.selectDataBaseFile.Title = "Выбор БД";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 759);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlState.ResumeLayout(false);
            this.pnlState.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Button btnConvertDB;
        private Button btnSelectDb;
        private Button btnResetFire;
        private Button btnOffBd;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label offOSU;
        private Label flame;
        private Label shortCircuit;
        private Label countFlameLbl;
        private Label disconnectOSU;
        private Label countBreaksLbl;
        private Label Breaks;
        private Label countShortCircuitLbl;
        private Label countDisconnectOsuLbl;
        private Label countOffOsu;
        private Panel pnlState;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TypeASU;
        private DataGridViewTextBoxColumn LineNumber;
        private DataGridViewTextBoxColumn NumberPPK;
        private DataGridViewTextBoxColumn AboutZone;
        private DataGridViewTextBoxColumn Date;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button7;
        private Button btn;
        private Button btnClose;
        private PictureBox pictureBox2;
        private Label label12;
        private OpenFileDialog selectDataBaseFile;
        private Button themeButton;
        private Label stateLabel;
        private Label stateText;
        private TextBox messageTextBox;
        private Button btnWorkWithComPort;

        public Button BtnConvertDB { get => btnConvertDB; set => btnConvertDB = value; }
        public Button BtnSelectDb { get => btnSelectDb; set => btnSelectDb = value; }
        public Button ThemeButton { get => themeButton; set => themeButton = value; }
        
        public Label OffOSU { get => offOSU; set => offOSU = value; }
        public Label Flame { get => flame; set => flame = value; }
        public Label DisconnectOSU { get => disconnectOSU; set => disconnectOSU = value; }
        public Label Label8 { get => Breaks; set => Breaks = value; }
        public Label Label9 { get => shortCircuit; set => shortCircuit = value; }
    }
}