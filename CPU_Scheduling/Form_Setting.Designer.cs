namespace CPU_Scheduling
{
    partial class Form_Setting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_projectName = new System.Windows.Forms.Label();
            this.groupBox_setting = new System.Windows.Forms.GroupBox();
            this.checkBox_avialable_lang_bar = new System.Windows.Forms.CheckBox();
            this.lbl_language = new System.Windows.Forms.Label();
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.btn_done = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox_setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_back.Location = new System.Drawing.Point(12, 507);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 42);
            this.btn_back.TabIndex = 28;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_projectName);
            this.panel1.Controls.Add(this.groupBox_setting);
            this.panel1.Location = new System.Drawing.Point(46, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 433);
            this.panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(181, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Algorithm in Operating system ";
            // 
            // lbl_projectName
            // 
            this.lbl_projectName.AutoSize = true;
            this.lbl_projectName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_projectName.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_projectName.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_projectName.Location = new System.Drawing.Point(145, 32);
            this.lbl_projectName.Name = "lbl_projectName";
            this.lbl_projectName.Size = new System.Drawing.Size(370, 47);
            this.lbl_projectName.TabIndex = 28;
            this.lbl_projectName.Text = "Processes Scheduling";
            // 
            // groupBox_setting
            // 
            this.groupBox_setting.Controls.Add(this.checkBox_avialable_lang_bar);
            this.groupBox_setting.Controls.Add(this.lbl_language);
            this.groupBox_setting.Controls.Add(this.comboBox_language);
            this.groupBox_setting.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_setting.ForeColor = System.Drawing.Color.Gray;
            this.groupBox_setting.Location = new System.Drawing.Point(19, 135);
            this.groupBox_setting.Name = "groupBox_setting";
            this.groupBox_setting.Size = new System.Drawing.Size(659, 240);
            this.groupBox_setting.TabIndex = 25;
            this.groupBox_setting.TabStop = false;
            this.groupBox_setting.Text = "Setting";
            // 
            // checkBox_avialable_lang_bar
            // 
            this.checkBox_avialable_lang_bar.AutoSize = true;
            this.checkBox_avialable_lang_bar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_avialable_lang_bar.Location = new System.Drawing.Point(202, 135);
            this.checkBox_avialable_lang_bar.Name = "checkBox_avialable_lang_bar";
            this.checkBox_avialable_lang_bar.Size = new System.Drawing.Size(240, 29);
            this.checkBox_avialable_lang_bar.TabIndex = 49;
            this.checkBox_avialable_lang_bar.Text = "Avialable this every page";
            this.checkBox_avialable_lang_bar.UseVisualStyleBackColor = true;
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.BackColor = System.Drawing.Color.Transparent;
            this.lbl_language.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_language.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_language.Location = new System.Drawing.Point(197, 104);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_language.Size = new System.Drawing.Size(95, 25);
            this.lbl_language.TabIndex = 48;
            this.lbl_language.Text = "Language";
            // 
            // comboBox_language
            // 
            this.comboBox_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_language.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Items.AddRange(new object[] {
            "English",
            "ไทย"});
            this.comboBox_language.Location = new System.Drawing.Point(298, 104);
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.Size = new System.Drawing.Size(121, 25);
            this.comboBox_language.TabIndex = 47;
            this.comboBox_language.SelectedIndexChanged += new System.EventHandler(this.comboBox_language_SelectedIndexChanged);
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.Transparent;
            this.btn_done.FlatAppearance.BorderSize = 0;
            this.btn_done.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.ForeColor = System.Drawing.Color.White;
            this.btn_done.Location = new System.Drawing.Point(676, 507);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(96, 42);
            this.btn_done.TabIndex = 50;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CPU_Scheduling.Properties.Resources.BG_Blur;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Setting";
            this.Text = "Visual Processes Scheduling";
            this.Load += new System.EventHandler(this.Form_Setting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_setting.ResumeLayout(false);
            this.groupBox_setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_projectName;
        private System.Windows.Forms.GroupBox groupBox_setting;
        private System.Windows.Forms.Label lbl_language;
        private System.Windows.Forms.ComboBox comboBox_language;
        private System.Windows.Forms.CheckBox checkBox_avialable_lang_bar;
        private System.Windows.Forms.Button btn_done;
    }
}