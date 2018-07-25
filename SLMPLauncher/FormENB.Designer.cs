namespace SLMPLauncher
{
	partial class FormENB
	{
		private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_deleteAllENB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_unpackENB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_AA;
        private System.Windows.Forms.Button button_Compress;
        private System.Windows.Forms.Button button_FPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_WaitBuffer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_AF;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_OC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_AutoMemory;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonExpandMemory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_deleteAllENB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button_unpackENB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_Close = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button_AA = new System.Windows.Forms.Button();
            this.button_Compress = new System.Windows.Forms.Button();
            this.button_FPS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_WaitBuffer = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_AF = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button_OC = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button_AutoMemory = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonExpandMemory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(244, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 242);
            this.listBox1.TabIndex = 13;
            this.listBox1.TabStop = false;
            // 
            // button_deleteAllENB
            // 
            this.button_deleteAllENB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deleteAllENB.Location = new System.Drawing.Point(368, 280);
            this.button_deleteAllENB.Name = "button_deleteAllENB";
            this.button_deleteAllENB.Size = new System.Drawing.Size(117, 30);
            this.button_deleteAllENB.TabIndex = 11;
            this.button_deleteAllENB.TabStop = false;
            this.button_deleteAllENB.Text = "Удалить";
            this.button_deleteAllENB.UseVisualStyleBackColor = true;
            this.button_deleteAllENB.Click += new System.EventHandler(this.button_deleteAllENB_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(248, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Файлы из Skyrim\\ENB";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_unpackENB
            // 
            this.button_unpackENB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_unpackENB.Location = new System.Drawing.Point(243, 280);
            this.button_unpackENB.Name = "button_unpackENB";
            this.button_unpackENB.Size = new System.Drawing.Size(117, 30);
            this.button_unpackENB.TabIndex = 10;
            this.button_unpackENB.TabStop = false;
            this.button_unpackENB.Text = "Установить";
            this.button_unpackENB.UseVisualStyleBackColor = true;
            this.button_unpackENB.Click += new System.EventHandler(this.button_unpackENB_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(5, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Резервирование:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::SLMPLauncher.Properties.Resources.line;
            this.pictureBox3.Location = new System.Drawing.Point(236, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 317);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(5, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Сглаживание:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(5, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "FPS лимит:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.BackgroundImage = global::SLMPLauncher.Properties.Resources.buttonClose;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(459, 8);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(25, 25);
            this.button_Close.TabIndex = 14;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            this.button_Close.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.button_Close.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(5, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Сжимать память:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_AA
            // 
            this.button_AA.BackColor = System.Drawing.Color.Transparent;
            this.button_AA.BackgroundImage = global::SLMPLauncher.Properties.Resources.buttonToggleDisable;
            this.button_AA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_AA.FlatAppearance.BorderSize = 0;
            this.button_AA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_AA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_AA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AA.Location = new System.Drawing.Point(179, 34);
            this.button_AA.Name = "button_AA";
            this.button_AA.Size = new System.Drawing.Size(50, 22);
            this.button_AA.TabIndex = 3;
            this.button_AA.TabStop = false;
            this.button_AA.UseVisualStyleBackColor = false;
            this.button_AA.Click += new System.EventHandler(this.button_AA_Click);
            // 
            // button_Compress
            // 
            this.button_Compress.BackColor = System.Drawing.Color.Transparent;
            this.button_Compress.BackgroundImage = global::SLMPLauncher.Properties.Resources.buttonToggleDisable;
            this.button_Compress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Compress.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Compress.FlatAppearance.BorderSize = 0;
            this.button_Compress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_Compress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_Compress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Compress.Location = new System.Drawing.Point(179, 202);
            this.button_Compress.Name = "button_Compress";
            this.button_Compress.Size = new System.Drawing.Size(50, 22);
            this.button_Compress.TabIndex = 6;
            this.button_Compress.TabStop = false;
            this.button_Compress.UseVisualStyleBackColor = false;
            this.button_Compress.Click += new System.EventHandler(this.button_Compress_Click);
            // 
            // button_FPS
            // 
            this.button_FPS.BackColor = System.Drawing.Color.Transparent;
            this.button_FPS.BackgroundImage = global::SLMPLauncher.Properties.Resources.buttonToggleDisable;
            this.button_FPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_FPS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_FPS.FlatAppearance.BorderSize = 0;
            this.button_FPS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_FPS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_FPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FPS.Location = new System.Drawing.Point(179, 146);
            this.button_FPS.Name = "button_FPS";
            this.button_FPS.Size = new System.Drawing.Size(50, 22);
            this.button_FPS.TabIndex = 9;
            this.button_FPS.TabStop = false;
            this.button_FPS.UseVisualStyleBackColor = false;
            this.button_FPS.Click += new System.EventHandler(this.button_FPS_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 317);
            this.label1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "30",
            "60",
            "75",
            "90",
            "120",
            "144",
            "240"});
            this.comboBox1.Location = new System.Drawing.Point(123, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(50, 23);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(5, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ожидание кадра:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_WaitBuffer
            // 
            this.button_WaitBuffer.BackColor = System.Drawing.Color.Transparent;
            this.button_WaitBuffer.BackgroundImage = global::SLMPLauncher.Properties.Resources.buttonToggleDisable;
            this.button_WaitBuffer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_WaitBuffer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_WaitBuffer.FlatAppearance.BorderSize = 0;
            this.button_WaitBuffer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_WaitBuffer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_WaitBuffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WaitBuffer.Location = new System.Drawing.Point(179, 118);
            this.button_WaitBuffer.Name = "button_WaitBuffer";
            this.button_WaitBuffer.Size = new System.Drawing.Size(50, 22);
            this.button_WaitBuffer.TabIndex = 8;
            this.button_WaitBuffer.TabStop = false;
            this.button_WaitBuffer.UseVisualStyleBackColor = false;
            this.button_WaitBuffer.Click += new System.EventHandler(this.button_WaitBuffer_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(10, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(219, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Системные настройки";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(5, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Фильтрация:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_AF
            // 
            this.button_AF.BackColor = System.Drawing.Color.Transparent;
            this.button_AF.BackgroundImage = global::SLMPLauncher.Properties.Resources.buttonToggleDisable;
            this.button_AF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AF.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_AF.FlatAppearance.BorderSize = 0;
            this.button_AF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_AF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_AF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AF.Location = new System.Drawing.Point(179, 62);
            this.button_AF.Name = "button_AF";
            this.button_AF.Size = new System.Drawing.Size(50, 22);
            this.button_AF.TabIndex = 4;
            this.button_AF.TabStop = false;
            this.button_AF.UseVisualStyleBackColor = false;
            this.button_AF.Click += new System.EventHandler(this.button_AF_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "384",
            "512",
            "640",
            "768",
            "896",
            "1024"});
            this.comboBox3.Location = new System.Drawing.Point(179, 229);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(50, 23);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.TabStop = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(5, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Отсечение окклюзии:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_OC
            // 
            this.button_OC.BackColor = System.Drawing.Color.Transparent;
            this.button_OC.BackgroundImage = global::SLMPLauncher.Properties.Resources.buttonToggleDisable;
            this.button_OC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_OC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_OC.FlatAppearance.BorderSize = 0;
            this.button_OC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_OC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_OC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OC.Location = new System.Drawing.Point(179, 90);
            this.button_OC.Name = "button_OC";
            this.button_OC.Size = new System.Drawing.Size(50, 22);
            this.button_OC.TabIndex = 5;
            this.button_OC.TabStop = false;
            this.button_OC.UseVisualStyleBackColor = false;
            this.button_OC.Click += new System.EventHandler(this.button_OC_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(5, 259);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Видео память авто.:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_AutoMemory
            // 
            this.button_AutoMemory.BackColor = System.Drawing.Color.Transparent;
            this.button_AutoMemory.BackgroundImage = global::SLMPLauncher.Properties.Resources.buttonToggleDisable;
            this.button_AutoMemory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AutoMemory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_AutoMemory.FlatAppearance.BorderSize = 0;
            this.button_AutoMemory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_AutoMemory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_AutoMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AutoMemory.Location = new System.Drawing.Point(179, 258);
            this.button_AutoMemory.Name = "button_AutoMemory";
            this.button_AutoMemory.Size = new System.Drawing.Size(50, 22);
            this.button_AutoMemory.TabIndex = 7;
            this.button_AutoMemory.TabStop = false;
            this.button_AutoMemory.UseVisualStyleBackColor = false;
            this.button_AutoMemory.Click += new System.EventHandler(this.button_AutoMemory_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(164, 286);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10240,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 21);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(5, 287);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(173, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Видео память:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(5, 175);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(187, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Сдвинуть память";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonExpandMemory
            // 
            this.buttonExpandMemory.BackColor = System.Drawing.Color.Transparent;
            this.buttonExpandMemory.BackgroundImage = global::SLMPLauncher.Properties.Resources.buttonToggleDisable;
            this.buttonExpandMemory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExpandMemory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExpandMemory.FlatAppearance.BorderSize = 0;
            this.buttonExpandMemory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonExpandMemory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonExpandMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpandMemory.Location = new System.Drawing.Point(179, 174);
            this.buttonExpandMemory.Name = "buttonExpandMemory";
            this.buttonExpandMemory.Size = new System.Drawing.Size(50, 22);
            this.buttonExpandMemory.TabIndex = 8;
            this.buttonExpandMemory.TabStop = false;
            this.buttonExpandMemory.UseVisualStyleBackColor = false;
            this.buttonExpandMemory.Click += new System.EventHandler(this.buttonExpandMemory_Click);
            // 
            // FormENB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SLMPLauncher.Properties.Resources.FormBackgroundNone;
            this.ClientSize = new System.Drawing.Size(492, 317);
            this.ControlBox = false;
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonExpandMemory);
            this.Controls.Add(this.button_WaitBuffer);
            this.Controls.Add(this.button_AutoMemory);
            this.Controls.Add(this.button_Compress);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button_FPS);
            this.Controls.Add(this.button_AF);
            this.Controls.Add(this.button_OC);
            this.Controls.Add(this.button_AA);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button_unpackENB);
            this.Controls.Add(this.button_deleteAllENB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormENB";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SLMP: ENB Menu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormENB_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

		}
    }
}