namespace CPU_Scheduling
{
    partial class Form_Menu
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
            this.btn_back = new System.Windows.Forms.Button();
            this.numeric_numProcess = new System.Windows.Forms.NumericUpDown();
            this.groupBox_numberProcess = new System.Windows.Forms.GroupBox();
            this.btn_ok_number_of_process = new System.Windows.Forms.Button();
            this.checkBox_FCFS = new System.Windows.Forms.CheckBox();
            this.checkBox_SJF_P = new System.Windows.Forms.CheckBox();
            this.checkBox_RR = new System.Windows.Forms.CheckBox();
            this.groupbox_algorithm = new System.Windows.Forms.GroupBox();
            this.lbl_Priority_N = new System.Windows.Forms.Label();
            this.checkBox_Priority_N = new System.Windows.Forms.CheckBox();
            this.lbl_Priority_P = new System.Windows.Forms.Label();
            this.checkBox_Priority_P = new System.Windows.Forms.CheckBox();
            this.lbl_SJF_N = new System.Windows.Forms.Label();
            this.checkBox_SJF_N = new System.Windows.Forms.CheckBox();
            this.lbl_RR = new System.Windows.Forms.Label();
            this.lbl_SJF_P = new System.Windows.Forms.Label();
            this.lbl_FCFS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_language = new System.Windows.Forms.Label();
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numProcess)).BeginInit();
            this.groupBox_numberProcess.SuspendLayout();
            this.groupbox_algorithm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_back.Location = new System.Drawing.Point(12, 507);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 42);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // numeric_numProcess
            // 
            this.numeric_numProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numeric_numProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_numProcess.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_numProcess.ForeColor = System.Drawing.SystemColors.GrayText;
            this.numeric_numProcess.Location = new System.Drawing.Point(26, 38);
            this.numeric_numProcess.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_numProcess.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_numProcess.Name = "numeric_numProcess";
            this.numeric_numProcess.Size = new System.Drawing.Size(450, 46);
            this.numeric_numProcess.TabIndex = 4;
            this.numeric_numProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_numProcess.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox_numberProcess
            // 
            this.groupBox_numberProcess.Controls.Add(this.numeric_numProcess);
            this.groupBox_numberProcess.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_numberProcess.ForeColor = System.Drawing.Color.Gray;
            this.groupBox_numberProcess.Location = new System.Drawing.Point(64, 14);
            this.groupBox_numberProcess.Name = "groupBox_numberProcess";
            this.groupBox_numberProcess.Size = new System.Drawing.Size(502, 103);
            this.groupBox_numberProcess.TabIndex = 6;
            this.groupBox_numberProcess.TabStop = false;
            this.groupBox_numberProcess.Text = "Number of process";
            // 
            // btn_ok_number_of_process
            // 
            this.btn_ok_number_of_process.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_ok_number_of_process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok_number_of_process.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_number_of_process.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok_number_of_process.Location = new System.Drawing.Point(64, 367);
            this.btn_ok_number_of_process.Name = "btn_ok_number_of_process";
            this.btn_ok_number_of_process.Size = new System.Drawing.Size(502, 46);
            this.btn_ok_number_of_process.TabIndex = 5;
            this.btn_ok_number_of_process.Text = "Next";
            this.btn_ok_number_of_process.UseVisualStyleBackColor = false;
            this.btn_ok_number_of_process.Click += new System.EventHandler(this.btn_ok_number_of_process_Click);
            // 
            // checkBox_FCFS
            // 
            this.checkBox_FCFS.AutoSize = true;
            this.checkBox_FCFS.Checked = true;
            this.checkBox_FCFS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_FCFS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_FCFS.Location = new System.Drawing.Point(26, 38);
            this.checkBox_FCFS.Name = "checkBox_FCFS";
            this.checkBox_FCFS.Size = new System.Drawing.Size(76, 34);
            this.checkBox_FCFS.TabIndex = 19;
            this.checkBox_FCFS.Text = "FCFS";
            this.checkBox_FCFS.UseVisualStyleBackColor = true;
            this.checkBox_FCFS.CheckedChanged += new System.EventHandler(this.checkBox_FCFS_CheckedChanged);
            // 
            // checkBox_SJF_P
            // 
            this.checkBox_SJF_P.AutoSize = true;
            this.checkBox_SJF_P.Checked = true;
            this.checkBox_SJF_P.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SJF_P.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SJF_P.Location = new System.Drawing.Point(26, 82);
            this.checkBox_SJF_P.Name = "checkBox_SJF_P";
            this.checkBox_SJF_P.Size = new System.Drawing.Size(171, 34);
            this.checkBox_SJF_P.TabIndex = 20;
            this.checkBox_SJF_P.Text = "SJF preemptive";
            this.checkBox_SJF_P.UseVisualStyleBackColor = true;
            this.checkBox_SJF_P.CheckedChanged += new System.EventHandler(this.checkBox_SJF_P_CheckedChanged);
            // 
            // checkBox_RR
            // 
            this.checkBox_RR.AutoSize = true;
            this.checkBox_RR.Checked = true;
            this.checkBox_RR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_RR.Location = new System.Drawing.Point(26, 171);
            this.checkBox_RR.Name = "checkBox_RR";
            this.checkBox_RR.Size = new System.Drawing.Size(58, 34);
            this.checkBox_RR.TabIndex = 21;
            this.checkBox_RR.Text = "RR";
            this.checkBox_RR.UseVisualStyleBackColor = true;
            this.checkBox_RR.CheckedChanged += new System.EventHandler(this.checkBox_RR_CheckedChanged);
            // 
            // groupbox_algorithm
            // 
            this.groupbox_algorithm.Controls.Add(this.lbl_Priority_N);
            this.groupbox_algorithm.Controls.Add(this.checkBox_Priority_N);
            this.groupbox_algorithm.Controls.Add(this.lbl_Priority_P);
            this.groupbox_algorithm.Controls.Add(this.checkBox_Priority_P);
            this.groupbox_algorithm.Controls.Add(this.lbl_SJF_N);
            this.groupbox_algorithm.Controls.Add(this.checkBox_SJF_N);
            this.groupbox_algorithm.Controls.Add(this.lbl_RR);
            this.groupbox_algorithm.Controls.Add(this.lbl_SJF_P);
            this.groupbox_algorithm.Controls.Add(this.lbl_FCFS);
            this.groupbox_algorithm.Controls.Add(this.checkBox_RR);
            this.groupbox_algorithm.Controls.Add(this.checkBox_SJF_P);
            this.groupbox_algorithm.Controls.Add(this.checkBox_FCFS);
            this.groupbox_algorithm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_algorithm.ForeColor = System.Drawing.Color.Gray;
            this.groupbox_algorithm.Location = new System.Drawing.Point(64, 123);
            this.groupbox_algorithm.Name = "groupbox_algorithm";
            this.groupbox_algorithm.Size = new System.Drawing.Size(502, 226);
            this.groupbox_algorithm.TabIndex = 24;
            this.groupbox_algorithm.TabStop = false;
            this.groupbox_algorithm.Text = "Algorithm";
            // 
            // lbl_Priority_N
            // 
            this.lbl_Priority_N.AutoSize = true;
            this.lbl_Priority_N.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Priority_N.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Priority_N.Location = new System.Drawing.Point(268, 156);
            this.lbl_Priority_N.Name = "lbl_Priority_N";
            this.lbl_Priority_N.Size = new System.Drawing.Size(186, 13);
            this.lbl_Priority_N.TabIndex = 30;
            this.lbl_Priority_N.Text = "Priority Scheduling Nonpreemptive";
            // 
            // checkBox_Priority_N
            // 
            this.checkBox_Priority_N.AutoSize = true;
            this.checkBox_Priority_N.Checked = true;
            this.checkBox_Priority_N.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Priority_N.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Priority_N.Location = new System.Drawing.Point(252, 127);
            this.checkBox_Priority_N.Name = "checkBox_Priority_N";
            this.checkBox_Priority_N.Size = new System.Drawing.Size(243, 34);
            this.checkBox_Priority_N.TabIndex = 29;
            this.checkBox_Priority_N.Text = "Priority nonpreemptive";
            this.checkBox_Priority_N.UseVisualStyleBackColor = true;
            this.checkBox_Priority_N.CheckedChanged += new System.EventHandler(this.checkBox_Priority_N_CheckedChanged);
            // 
            // lbl_Priority_P
            // 
            this.lbl_Priority_P.AutoSize = true;
            this.lbl_Priority_P.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Priority_P.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Priority_P.Location = new System.Drawing.Point(42, 156);
            this.lbl_Priority_P.Name = "lbl_Priority_P";
            this.lbl_Priority_P.Size = new System.Drawing.Size(163, 13);
            this.lbl_Priority_P.TabIndex = 28;
            this.lbl_Priority_P.Text = "Priority Scheduling Preemptive";
            // 
            // checkBox_Priority_P
            // 
            this.checkBox_Priority_P.AutoSize = true;
            this.checkBox_Priority_P.Checked = true;
            this.checkBox_Priority_P.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Priority_P.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Priority_P.Location = new System.Drawing.Point(26, 127);
            this.checkBox_Priority_P.Name = "checkBox_Priority_P";
            this.checkBox_Priority_P.Size = new System.Drawing.Size(207, 34);
            this.checkBox_Priority_P.TabIndex = 27;
            this.checkBox_Priority_P.Text = "Priority preemptive";
            this.checkBox_Priority_P.UseVisualStyleBackColor = true;
            this.checkBox_Priority_P.CheckedChanged += new System.EventHandler(this.checkBox_Priority_P_CheckedChanged);
            // 
            // lbl_SJF_N
            // 
            this.lbl_SJF_N.AutoSize = true;
            this.lbl_SJF_N.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SJF_N.ForeColor = System.Drawing.Color.Gray;
            this.lbl_SJF_N.Location = new System.Drawing.Point(273, 111);
            this.lbl_SJF_N.Name = "lbl_SJF_N";
            this.lbl_SJF_N.Size = new System.Drawing.Size(178, 13);
            this.lbl_SJF_N.TabIndex = 26;
            this.lbl_SJF_N.Text = "Shortest Job First Nonpreemptive";
            // 
            // checkBox_SJF_N
            // 
            this.checkBox_SJF_N.AutoSize = true;
            this.checkBox_SJF_N.Checked = true;
            this.checkBox_SJF_N.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SJF_N.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SJF_N.Location = new System.Drawing.Point(252, 82);
            this.checkBox_SJF_N.Name = "checkBox_SJF_N";
            this.checkBox_SJF_N.Size = new System.Drawing.Size(207, 34);
            this.checkBox_SJF_N.TabIndex = 25;
            this.checkBox_SJF_N.Text = "SJF nonpreemptive";
            this.checkBox_SJF_N.UseVisualStyleBackColor = true;
            this.checkBox_SJF_N.CheckedChanged += new System.EventHandler(this.checkBox_SJF_N_CheckedChanged);
            // 
            // lbl_RR
            // 
            this.lbl_RR.AutoSize = true;
            this.lbl_RR.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RR.ForeColor = System.Drawing.Color.Gray;
            this.lbl_RR.Location = new System.Drawing.Point(42, 200);
            this.lbl_RR.Name = "lbl_RR";
            this.lbl_RR.Size = new System.Drawing.Size(76, 13);
            this.lbl_RR.TabIndex = 24;
            this.lbl_RR.Text = "Round Robin";
            // 
            // lbl_SJF_P
            // 
            this.lbl_SJF_P.AutoSize = true;
            this.lbl_SJF_P.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SJF_P.ForeColor = System.Drawing.Color.Gray;
            this.lbl_SJF_P.Location = new System.Drawing.Point(42, 111);
            this.lbl_SJF_P.Name = "lbl_SJF_P";
            this.lbl_SJF_P.Size = new System.Drawing.Size(155, 13);
            this.lbl_SJF_P.TabIndex = 23;
            this.lbl_SJF_P.Text = "Shortest Job First Preemptive";
            // 
            // lbl_FCFS
            // 
            this.lbl_FCFS.AutoSize = true;
            this.lbl_FCFS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FCFS.ForeColor = System.Drawing.Color.Gray;
            this.lbl_FCFS.Location = new System.Drawing.Point(42, 66);
            this.lbl_FCFS.Name = "lbl_FCFS";
            this.lbl_FCFS.Size = new System.Drawing.Size(113, 13);
            this.lbl_FCFS.TabIndex = 22;
            this.lbl_FCFS.Text = "First come First serve";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_ok_number_of_process);
            this.panel1.Controls.Add(this.groupbox_algorithm);
            this.panel1.Controls.Add(this.groupBox_numberProcess);
            this.panel1.Location = new System.Drawing.Point(72, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 427);
            this.panel1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(114, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 42);
            this.button1.TabIndex = 26;
            this.button1.Text = "Developer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.BackColor = System.Drawing.Color.Transparent;
            this.lbl_language.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_language.ForeColor = System.Drawing.Color.White;
            this.lbl_language.Location = new System.Drawing.Point(534, 21);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_language.Size = new System.Drawing.Size(74, 21);
            this.lbl_language.TabIndex = 45;
            this.lbl_language.Text = "language";
            this.lbl_language.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_language.Click += new System.EventHandler(this.lbl_language_Click);
            // 
            // comboBox_language
            // 
            this.comboBox_language.DisplayMember = "0";
            this.comboBox_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_language.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Items.AddRange(new object[] {
            "English",
            "ไทย"});
            this.comboBox_language.Location = new System.Drawing.Point(622, 21);
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.Size = new System.Drawing.Size(121, 25);
            this.comboBox_language.TabIndex = 44;
            this.comboBox_language.ValueMember = "0";
            this.comboBox_language.SelectedIndexChanged += new System.EventHandler(this.comboBox_language_SelectedIndexChanged);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.ForeColor = System.Drawing.Color.Azure;
            this.btn_about.Location = new System.Drawing.Point(268, 507);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(266, 42);
            this.btn_about.TabIndex = 47;
            this.btn_about.Text = "About and Feedback";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.ForeColor = System.Drawing.Color.Azure;
            this.btn_setting.Location = new System.Drawing.Point(540, 507);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(139, 42);
            this.btn_setting.TabIndex = 48;
            this.btn_setting.Text = "Setting";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CPU_Scheduling.Properties.Resources.BG_Blur;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_language);
            this.Controls.Add(this.comboBox_language);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Menu";
            this.Text = "Visual Processes Scheduling";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numProcess)).EndInit();
            this.groupBox_numberProcess.ResumeLayout(false);
            this.groupbox_algorithm.ResumeLayout(false);
            this.groupbox_algorithm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.NumericUpDown numeric_numProcess;
        private System.Windows.Forms.GroupBox groupBox_numberProcess;
        private System.Windows.Forms.Button btn_ok_number_of_process;
        private System.Windows.Forms.CheckBox checkBox_FCFS;
        private System.Windows.Forms.CheckBox checkBox_SJF_P;
        private System.Windows.Forms.CheckBox checkBox_RR;
        private System.Windows.Forms.GroupBox groupbox_algorithm;
        private System.Windows.Forms.Label lbl_RR;
        private System.Windows.Forms.Label lbl_SJF_P;
        private System.Windows.Forms.Label lbl_FCFS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_language;
        private System.Windows.Forms.ComboBox comboBox_language;
        private System.Windows.Forms.Label lbl_Priority_N;
        private System.Windows.Forms.CheckBox checkBox_Priority_N;
        private System.Windows.Forms.Label lbl_Priority_P;
        private System.Windows.Forms.CheckBox checkBox_Priority_P;
        private System.Windows.Forms.Label lbl_SJF_N;
        private System.Windows.Forms.CheckBox checkBox_SJF_N;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_setting;
    }
}