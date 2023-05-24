namespace Vizualizator.FormsAndControls.Controls
{
    partial class ComPortSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComPortSettingForm));
            this.cmbxStopBits = new System.Windows.Forms.ComboBox();
            this.cmbxDataBits = new System.Windows.Forms.ComboBox();
            this.cmbxParity = new System.Windows.Forms.ComboBox();
            this.cmbxBaudRates = new System.Windows.Forms.ComboBox();
            this.cmbxComPorts = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOffCom = new System.Windows.Forms.Button();
            this.btnOnCom = new System.Windows.Forms.Button();
            this.lblStopBit = new System.Windows.Forms.Label();
            this.lblDataBit = new System.Windows.Forms.Label();
            this.lblPariy = new System.Windows.Forms.Label();
            this.lblBoudRate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.stateText = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPortName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxStopBits
            // 
            this.cmbxStopBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cmbxStopBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxStopBits.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbxStopBits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.cmbxStopBits.FormattingEnabled = true;
            this.cmbxStopBits.Items.AddRange(new object[] {
            "One",
            "Two",
            "None",
            "OnePointFive"});
            this.cmbxStopBits.Location = new System.Drawing.Point(222, 212);
            this.cmbxStopBits.Name = "cmbxStopBits";
            this.cmbxStopBits.Size = new System.Drawing.Size(121, 29);
            this.cmbxStopBits.TabIndex = 47;
            // 
            // cmbxDataBits
            // 
            this.cmbxDataBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cmbxDataBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxDataBits.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbxDataBits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.cmbxDataBits.FormattingEnabled = true;
            this.cmbxDataBits.Items.AddRange(new object[] {
            "8"});
            this.cmbxDataBits.Location = new System.Drawing.Point(222, 177);
            this.cmbxDataBits.Name = "cmbxDataBits";
            this.cmbxDataBits.Size = new System.Drawing.Size(121, 29);
            this.cmbxDataBits.TabIndex = 46;
            // 
            // cmbxParity
            // 
            this.cmbxParity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cmbxParity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxParity.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbxParity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.cmbxParity.FormattingEnabled = true;
            this.cmbxParity.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.cmbxParity.Location = new System.Drawing.Point(222, 142);
            this.cmbxParity.Name = "cmbxParity";
            this.cmbxParity.Size = new System.Drawing.Size(121, 29);
            this.cmbxParity.TabIndex = 45;
            // 
            // cmbxBaudRates
            // 
            this.cmbxBaudRates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cmbxBaudRates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxBaudRates.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbxBaudRates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.cmbxBaudRates.FormattingEnabled = true;
            this.cmbxBaudRates.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cmbxBaudRates.Location = new System.Drawing.Point(222, 107);
            this.cmbxBaudRates.Name = "cmbxBaudRates";
            this.cmbxBaudRates.Size = new System.Drawing.Size(121, 29);
            this.cmbxBaudRates.TabIndex = 44;
            // 
            // cmbxComPorts
            // 
            this.cmbxComPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cmbxComPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxComPorts.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbxComPorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.cmbxComPorts.FormattingEnabled = true;
            this.cmbxComPorts.Location = new System.Drawing.Point(222, 72);
            this.cmbxComPorts.Name = "cmbxComPorts";
            this.cmbxComPorts.Size = new System.Drawing.Size(121, 29);
            this.cmbxComPorts.TabIndex = 43;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.lblState.Location = new System.Drawing.Point(113, 410);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(140, 21);
            this.lblState.TabIndex = 42;
            this.lblState.Tag = "1";
            this.lblState.Text = "Не подключен ";
            this.lblState.Click += new System.EventHandler(this.lblState_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.label5.Location = new System.Drawing.Point(3, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Состояние: ";
            // 
            // btnOffCom
            // 
            this.btnOffCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnOffCom.FlatAppearance.BorderSize = 0;
            this.btnOffCom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOffCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffCom.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOffCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btnOffCom.Image = ((System.Drawing.Image)(resources.GetObject("btnOffCom.Image")));
            this.btnOffCom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOffCom.Location = new System.Drawing.Point(3, 311);
            this.btnOffCom.Name = "btnOffCom";
            this.btnOffCom.Size = new System.Drawing.Size(340, 62);
            this.btnOffCom.TabIndex = 40;
            this.btnOffCom.Tag = "";
            this.btnOffCom.Text = "Отключиться от COM-порта";
            this.btnOffCom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffCom.UseVisualStyleBackColor = false;
            this.btnOffCom.Click += new System.EventHandler(this.btnOffCom_Click);
            // 
            // btnOnCom
            // 
            this.btnOnCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnOnCom.FlatAppearance.BorderSize = 0;
            this.btnOnCom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOnCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnCom.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOnCom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.btnOnCom.Image = ((System.Drawing.Image)(resources.GetObject("btnOnCom.Image")));
            this.btnOnCom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnCom.Location = new System.Drawing.Point(3, 247);
            this.btnOnCom.Name = "btnOnCom";
            this.btnOnCom.Size = new System.Drawing.Size(340, 62);
            this.btnOnCom.TabIndex = 39;
            this.btnOnCom.Tag = "";
            this.btnOnCom.Text = "Подключиться к COM-порту";
            this.btnOnCom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnCom.UseVisualStyleBackColor = false;
            this.btnOnCom.Click += new System.EventHandler(this.btnOnCom_Click);
            // 
            // lblStopBit
            // 
            this.lblStopBit.AutoSize = true;
            this.lblStopBit.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStopBit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.lblStopBit.Location = new System.Drawing.Point(3, 220);
            this.lblStopBit.Name = "lblStopBit";
            this.lblStopBit.Size = new System.Drawing.Size(100, 21);
            this.lblStopBit.TabIndex = 38;
            this.lblStopBit.Text = "Стоп бит:";
            // 
            // lblDataBit
            // 
            this.lblDataBit.AutoSize = true;
            this.lblDataBit.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataBit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.lblDataBit.Location = new System.Drawing.Point(3, 185);
            this.lblDataBit.Name = "lblDataBit";
            this.lblDataBit.Size = new System.Drawing.Size(120, 21);
            this.lblDataBit.TabIndex = 37;
            this.lblDataBit.Text = "Бит данных:";
            // 
            // lblPariy
            // 
            this.lblPariy.AutoSize = true;
            this.lblPariy.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPariy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.lblPariy.Location = new System.Drawing.Point(3, 150);
            this.lblPariy.Name = "lblPariy";
            this.lblPariy.Size = new System.Drawing.Size(140, 21);
            this.lblPariy.TabIndex = 36;
            this.lblPariy.Text = "Бит четности:";
            // 
            // lblBoudRate
            // 
            this.lblBoudRate.AutoSize = true;
            this.lblBoudRate.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBoudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.lblBoudRate.Location = new System.Drawing.Point(3, 115);
            this.lblBoudRate.Name = "lblBoudRate";
            this.lblBoudRate.Size = new System.Drawing.Size(190, 21);
            this.lblBoudRate.TabIndex = 35;
            this.lblBoudRate.Text = "Скорость передачи:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.CloseBtn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.stateText);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 32);
            this.panel2.TabIndex = 34;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(364, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(30, 30);
            this.CloseBtn.TabIndex = 15;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(521, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 0);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // stateText
            // 
            this.stateText.AutoSize = true;
            this.stateText.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.stateText.Location = new System.Drawing.Point(845, 7);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(110, 21);
            this.stateText.TabIndex = 12;
            this.stateText.Tag = "7";
            this.stateText.Text = "в ожидании";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.label12.Location = new System.Drawing.Point(36, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "COM-ports config";
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
            // 
            // lblPortName
            // 
            this.lblPortName.AutoSize = true;
            this.lblPortName.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.lblPortName.Location = new System.Drawing.Point(3, 80);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(100, 21);
            this.lblPortName.TabIndex = 33;
            this.lblPortName.Text = "COM-порт:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(352, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 48;
            this.button2.Tag = "";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ComPortSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbxStopBits);
            this.Controls.Add(this.cmbxDataBits);
            this.Controls.Add(this.cmbxParity);
            this.Controls.Add(this.cmbxBaudRates);
            this.Controls.Add(this.cmbxComPorts);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOffCom);
            this.Controls.Add(this.btnOnCom);
            this.Controls.Add(this.lblStopBit);
            this.Controls.Add(this.lblDataBit);
            this.Controls.Add(this.lblPariy);
            this.Controls.Add(this.lblBoudRate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPortName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComPortSettingForm";
            this.Text = "ComPortSettingForm";
            this.Load += new System.EventHandler(this.ComPortSettingForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbxStopBits;
        private ComboBox cmbxDataBits;
        private ComboBox cmbxParity;
        private ComboBox cmbxBaudRates;
        private ComboBox cmbxComPorts;
        private Label lblState;
        private Label label5;
        private Button btnOffCom;
        private Button btnOnCom;
        private Label lblStopBit;
        private Label lblDataBit;
        private Label lblPariy;
        private Label lblBoudRate;
        private Panel panel2;
        private Button button1;
        private Label stateText;
        private Label label12;
        private PictureBox pictureBox2;
        private Button btnClose;
        private Label lblPortName;
        private Button CloseBtn;
        private Button button2;
    }
}