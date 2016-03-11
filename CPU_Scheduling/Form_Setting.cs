using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduling
{
    public partial class Form_Setting : Form
    {
        ProcessesScheduling myScheduling;
        public Form_Setting()
        {
            InitializeComponent();
        }

        public Form_Setting(ProcessesScheduling myScheduling)
        {
            InitializeComponent();
            this.myScheduling = myScheduling;

            checkBox_avialable_lang_bar.Checked = myScheduling.flag_language_bar;
            //set init Language.
            if (myScheduling.language == "EN")
            {
                comboBox_language.SelectedIndex = 0;
            }
            else if (myScheduling.language == "TH")
            {
                comboBox_language.SelectedIndex = 1;
            }
            setLanguage();

        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {

        }

        private void setLanguage()
        {
            if (comboBox_language.SelectedIndex == 0)
            {
                lbl_language.Text = "Language";
                groupBox_setting.Text = "Setting";
                checkBox_avialable_lang_bar.Text = "Avialable this every page";
                btn_back.Text = "Back";
                btn_done.Text = "Done";
            }
            else if (comboBox_language.SelectedIndex == 1)
            {
                lbl_language.Text = "       ภาษา";
                groupBox_setting.Text = "ตั้งค่า";
                checkBox_avialable_lang_bar.Text = "มองเห็นมุมสำหรับเปลี่ยนภาษาในทุกหน้า";
                btn_back.Text = "กลับ";
                btn_done.Text = "เสร็จสิ้น";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_Menu form = new Form_Menu(myScheduling);
            form.Show();
            form.Location = this.Location;
            Hide();
        }

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLanguage();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            myScheduling.flag_language_bar = checkBox_avialable_lang_bar.Checked;
            if (comboBox_language.SelectedIndex == 0)
            {
                myScheduling.language = "EN";
            }
            else if (comboBox_language.SelectedIndex == 1)
            {
                myScheduling.language = "TH";
            }

            Form_Menu form = new Form_Menu(myScheduling);
            form.Show();
            form.Location = this.Location;
            Hide();
        }
    }
}
