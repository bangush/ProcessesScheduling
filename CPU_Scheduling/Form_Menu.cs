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
    public partial class Form_Menu : Form
    {
        ProcessesScheduling myScheduling;
        public Form_Menu(ProcessesScheduling myScheduling)
        {
            InitializeComponent();
            this.myScheduling = myScheduling;
            //set init Language.
            if (myScheduling.language == "EN")
            {
                comboBox_language.SelectedIndex = 0;
            }
            else if (myScheduling.language == "TH")
            {
                comboBox_language.SelectedIndex = 1;
            }
            setVisibleLanguageBar();
            setLanguage();
            setContent();
        }

        public Form_Menu()
        {
            InitializeComponent();
        }

        public void setContent()
        {
            // Set value in content form Object.
            numeric_numProcess.Value = myScheduling.getNumberProcess();
            checkBox_FCFS.Checked = myScheduling.getFlagFCFS();
            checkBox_SJF_P.Checked = myScheduling.getFlagSJF_P();
            checkBox_SJF_N.Checked = myScheduling.getFlagSJF_N();
            checkBox_Priority_P.Checked = myScheduling.getFlagPriority_P();
            checkBox_Priority_N.Checked = myScheduling.getFlagPriority_N();
            checkBox_RR.Checked = myScheduling.getFlagRR();
        }

        public void check_AllCheckboxNotChecked()
        {
            bool FCFS = checkBox_FCFS.Checked;
            bool SJF_P = checkBox_SJF_P.Checked;
            bool SJF_N = checkBox_SJF_N.Checked;
            bool Priority_P = checkBox_Priority_P.Checked;
            bool Priority_N = checkBox_Priority_N.Checked;
            bool RR = checkBox_RR.Checked;
            if (!FCFS && !SJF_P && !SJF_N && !Priority_P && !Priority_N && !RR)
            {
                btn_ok_number_of_process.Enabled = false;
            }
            else
            {
                btn_ok_number_of_process.Enabled = true;
            }
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(myScheduling);
            form.Show();
            form.Location = this.Location;
            //form2.StartPosition = this.StartPosition;
            Hide();
        }

        private void btn_ok_number_of_process_Click(object sender, EventArgs e)
        {
            // Set number of Process to Object.
            myScheduling.setNumberProcess((int)numeric_numProcess.Value);

            // Set checked box to Object.
            bool FCFS = checkBox_FCFS.Checked;
            bool SJF_P = checkBox_SJF_P.Checked;
            bool SJF_N = checkBox_SJF_N.Checked;
            bool Priority_P = checkBox_Priority_P.Checked;
            bool Priority_N = checkBox_Priority_N.Checked;
            bool RR = checkBox_RR.Checked;
            myScheduling.setFlag_Algorithm(FCFS, SJF_P, SJF_N, Priority_P, Priority_N, RR);

            // Navigate Page.
            Input_Form form = new Input_Form(myScheduling);
            form.Show();
            form.Location = this.Location;
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Navigate Page.
            Form_Developer form = new Form_Developer(myScheduling);
            form.Show();
            form.Location = this.Location;
            Hide();
        }

        private void checkBox_FCFS_CheckedChanged(object sender, EventArgs e)
        {
            check_AllCheckboxNotChecked();
        }

        private void checkBox_SJF_P_CheckedChanged(object sender, EventArgs e)
        {
            check_AllCheckboxNotChecked();
        }

        private void checkBox_SJF_N_CheckedChanged(object sender, EventArgs e)
        {
            check_AllCheckboxNotChecked();
        }

        private void checkBox_Priority_P_CheckedChanged(object sender, EventArgs e)
        {
            check_AllCheckboxNotChecked();
        }

        private void checkBox_Priority_N_CheckedChanged(object sender, EventArgs e)
        {
            check_AllCheckboxNotChecked();
        }

        private void checkBox_RR_CheckedChanged(object sender, EventArgs e)
        {
            check_AllCheckboxNotChecked();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }

        private void setVisibleLanguageBar(){
            lbl_language.Visible = myScheduling.flag_language_bar;
            comboBox_language.Visible = myScheduling.flag_language_bar;
        }

        private void setLanguage()
        {
            if (comboBox_language.SelectedIndex ==0)
            {
                myScheduling.language = "EN";
                lbl_language.Text = "Language";
                groupBox_numberProcess.Text = "Number of process";
                groupbox_algorithm.Text = "Algorithm";
                btn_back.Text = "Back";
                btn_about.Text = "About and Feedback";
                btn_setting.Text = "Setting";
                button1.Text = "Developer";
                btn_ok_number_of_process.Text = "Next";

                lbl_FCFS.Text = "First come First Serve";
                lbl_SJF_P.Text = "Shortest Job First Preemptive";
                lbl_SJF_N.Text = "Shortest Job First Nonpreemptive";
                lbl_Priority_P.Text = "Priority Preemptive";
                lbl_Priority_N.Text = "Priority Nonpreemptive";
                lbl_RR.Text = "Round Robin";
            }
            else if (comboBox_language.SelectedIndex == 1)
            {
                myScheduling.language = "TH";
                lbl_language.Text = "       ภาษา";
                groupBox_numberProcess.Text = "จำนวนโปรเซส";
                groupbox_algorithm.Text = "อัลกอริทึม";
                btn_back.Text = "กลับ";
                btn_about.Text = "เกี่ยวกับเราและตอบกลับ";
                btn_setting.Text = "ตั้งค่า";
                button1.Text = "ผู้พัฒนา";
                btn_ok_number_of_process.Text = "ต่อไป";

                lbl_FCFS.Text = "มาก่อน ได้ทำงานก่อน";
                lbl_SJF_P.Text = "งานสั้นทำก่อน แทรกการทำงาน";
                lbl_SJF_N.Text = "งานสั้นทำก่อน ไม่แทรกการทำงาน";
                lbl_Priority_P.Text = "ความคำสัญสูงทำงานก่อน แทรกการทำงาน";
                lbl_Priority_N.Text = "ความคำสัญสูงทำงานก่อน ไม่แทรกการทำงาน";
                lbl_RR.Text = "การจัดแบบวนรอบ";
            }
        }

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLanguage();
        }

        private void lbl_language_Click(object sender, EventArgs e)
        {

        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            // Navigate Page.
            Form_About form = new Form_About(myScheduling);
            form.Show();
            form.Location = this.Location;
            Hide();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Form_Setting form = new Form_Setting(myScheduling);
            form.Show();
            form.Location = this.Location;
            Hide();
        }
        
    }
}
