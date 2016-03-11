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
    public partial class Input_Form : Form
    {
        NumericUpDown[] arrivalTimeArray;
        NumericUpDown[] burstTimeArray;
        NumericUpDown[] priorityArray;
        Label[] lbl_process;

        ProcessesScheduling myScheduling;
        public Input_Form()
        {
            InitializeComponent();
        }

        public Input_Form(ProcessesScheduling myScheduling)
        {
            InitializeComponent();
            this.myScheduling = myScheduling;
            accessContent();
            setVisibleLanguageBar();
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

            
            setEnableContent();
            setValueFromObject();
        }

        public void accessContent()
        {
            arrivalTimeArray = new NumericUpDown[10];
            arrivalTimeArray[0] = num_p1_arrival;
            arrivalTimeArray[1] = num_p2_arrival;
            arrivalTimeArray[2] = num_p3_arrival;
            arrivalTimeArray[3] = num_p4_arrival;
            arrivalTimeArray[4] = num_p5_arrival;
            arrivalTimeArray[5] = num_p6_arrival;
            arrivalTimeArray[6] = num_p7_arrival;
            arrivalTimeArray[7] = num_p8_arrival;
            arrivalTimeArray[8] = num_p9_arrival;
            arrivalTimeArray[9] = num_p10_arrival;

            burstTimeArray = new NumericUpDown[10];
            burstTimeArray[0] = num_p1_burst;
            burstTimeArray[1] = num_p2_burst;
            burstTimeArray[2] = num_p3_burst;
            burstTimeArray[3] = num_p4_burst;
            burstTimeArray[4] = num_p5_burst;
            burstTimeArray[5] = num_p6_burst;
            burstTimeArray[6] = num_p7_burst;
            burstTimeArray[7] = num_p8_burst;
            burstTimeArray[8] = num_p9_burst;
            burstTimeArray[9] = num_p10_burst;

            priorityArray = new NumericUpDown[10];
            priorityArray[0] = num_p1_priority;
            priorityArray[1] = num_p2_priority;
            priorityArray[2] = num_p3_priority;
            priorityArray[3] = num_p4_priority;
            priorityArray[4] = num_p5_priority;
            priorityArray[5] = num_p6_priority;
            priorityArray[6] = num_p7_priority;
            priorityArray[7] = num_p8_priority;
            priorityArray[8] = num_p9_priority;
            priorityArray[9] = num_p10_priority;

            lbl_process = new Label[10];
            lbl_process[0] = lbl_p1;
            lbl_process[1] = lbl_p2;
            lbl_process[2] = lbl_p3;
            lbl_process[3] = lbl_p4;
            lbl_process[4] = lbl_p5;
            lbl_process[5] = lbl_p6;
            lbl_process[6] = lbl_p7;
            lbl_process[7] = lbl_p8;
            lbl_process[8] = lbl_p9;
            lbl_process[9] = lbl_p10;
        }

        public void setValueFromObject()
        {
            int num = myScheduling.getNumberProcess();
            numericUpDown_QuantumTime.Value = myScheduling.getQuantumTime();
            for (int i = 0; i < num; i++)
            {
                arrivalTimeArray[i].Value = myScheduling.getArrivalTime(i);
                burstTimeArray[i].Value = myScheduling.getBrustTime(i);
                priorityArray[i].Value = myScheduling.getPriority(i);
            }
            checkBox_displayChart.Checked = myScheduling.getFlagDisplayChart();
        }

        public void setEnableContent()
        {
            int num_process = myScheduling.getNumberProcess();

            for(int i=0;i<num_process;i++){
                arrivalTimeArray[i].Enabled = true;
                arrivalTimeArray[i].BackColor = Color.FromArgb(192, 255, 192);
                burstTimeArray[i].Enabled = true;
                burstTimeArray[i].BackColor = Color.FromArgb(192, 255, 192);
                priorityArray[i].Enabled = true;
                priorityArray[i].BackColor = Color.FromArgb(192, 255, 192);
            }
        }

        public void addDatatoObjectScheduling()
        {
            int num_process = myScheduling.getNumberProcess();
            for (int i = 0; i < num_process ; i++)
            {
                myScheduling.setArrivalTime(i,(int) arrivalTimeArray[i].Value);
                myScheduling.setBrustTime(i, (int) burstTimeArray[i].Value);
                myScheduling.setPriority(i, (int)priorityArray[i].Value);
            }
            myScheduling.setFlagDisplayChart(checkBox_displayChart.Checked);
        }

        private void groupBox_processDetail_Enter(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_Menu form2 = new Form_Menu(myScheduling);

            form2.Show();
            form2.Location = this.Location;
            //form2.StartPosition = this.StartPosition;
            Hide();
        }

        // Set Numeric Updown Arrivaltime is 0 because all process arrive same time.
        private void button_AllProcessArriveSametime_Click(object sender, EventArgs e)
        {
            int num_process = myScheduling.getNumberProcess();
            for (int i = 0; i < num_process; i++)
            {
                arrivalTimeArray[i].Value = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add value to object.
            addDatatoObjectScheduling();
            myScheduling.clearContextSwitch();
            myScheduling.clearArrayData();
            //MessageBox.Show(""+myScheduling.getBrustTime(0)+"  "+myScheduling.getBrustTime(1)+"  "+myScheduling.getBrustTime(2));
            if (myScheduling.getFlagFCFS())
            {
                myScheduling.computeFCFS();
            }
            if (myScheduling.getFlagSJF_N())
            {
                myScheduling.computeSJF_N();
            }
            if (myScheduling.getFlagPriority_N())
            {
                myScheduling.computePriority_N();
            }
            if (myScheduling.getFlagSJF_P())
            {
                myScheduling.computeSJF_P();
            }
            if (myScheduling.getFlagPriority_P())
            {
                myScheduling.computePriority_P();
            }
            if (myScheduling.getFlagRR())
            {
                myScheduling.setQuantunTime((int)numericUpDown_QuantumTime.Value);
                myScheduling.computeRR();
            }
           // MessageBox.Show("" + myScheduling.Debug_FCFS());
            //MessageBox.Show("" + myScheduling.waitingTime_FCFS[0] +" " +myScheduling.waitingTime_FCFS[1] + "  " + myScheduling.waitingTime_FCFS[2]);

            Result_form1 form2 = new Result_form1(myScheduling);
            form2.Show();
            form2.Location = this.Location;
            Hide();
        }

        private void setValueToDefault()
        {
            numericUpDown_QuantumTime.Value = myScheduling.getQuantumTime();
            for (int i = 0; i < 10; i++)
            {
                arrivalTimeArray[i].Value = 0;
                burstTimeArray[i].Value = 1;
                priorityArray[i].Value = 1;
            }
        }

        private void Input_Form_Load(object sender, EventArgs e)
        {

        }

        private void button_AllProcessArriveSametime_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                arrivalTimeArray[i].Value = 0;
            }
        }

        private void setVisibleLanguageBar()
        {
            lbl_language.Visible = myScheduling.flag_language_bar;
            comboBox_language.Visible = myScheduling.flag_language_bar;
        }

        public void setLanguage()
        {
            if (comboBox_language.SelectedIndex == 0)
            {
                myScheduling.language = "EN";
                lbl_language.Text = "language";
                groupBox_processDetail.Text = "Process Detail";
                groupBox_option.Text = "Option";

                lbl_arrival_l.Text = "Arrival time (ms)";
                lbl_arrival_r.Text = "Arrival time (ms)";

                lbl_burst_l.Text = "Burst time (ms)";
                lbl_burst_r.Text = "Burst time (ms)";

                lbl_priority_l.Text = "Priority";
                lbl_priority_r.Text = "Priority";

                lbl_quantum.Text = "Quantum Time";
                checkBox_displayChart.Text = "Display Gantt chart";
                lbl_descrip_priority.Text = "For priority have value less number is  more high priority.";
                button_AllProcessArriveSametime.Text = "Every process arrive in same time";
                lbl_default.Text = "Restore the default";
                btn_DecProcess.Text = "Decrease process";
                btn_InsProcess.Text = "Increase process";

                String p = "Process";
                for (int i = 0; i < 10; i++)
                {
                    lbl_process[i].Text = p + " " + (i+1);
                }

                btn_back.Text = "Back";
                button2.Text = "Next";
            }
            else if (comboBox_language.SelectedIndex == 1)
            {
                myScheduling.language = "TH";
                lbl_language.Text = "       ภาษา";
                groupBox_processDetail.Text = "รายละเอียด";
                groupBox_option.Text = "ตัวเลือก";

                lbl_arrival_l.Text = "เวลาที่มาถึง (ms)";
                lbl_arrival_r.Text = "เวลาที่มาถึง (ms)";

                lbl_burst_l.Text = "เวลาทำงาน (ms)";
                lbl_burst_r.Text = "เวลาทำงาน (ms)";

                lbl_priority_l.Text = "ความสำคัญ";
                lbl_priority_r.Text = "ความสำคัญ";

                lbl_quantum.Text = "   เวลาควันตัม";
                checkBox_displayChart.Text = "แสดงแผนภูมิแกนต์";
                lbl_descrip_priority.Text = "      กระบวนการที่มีความสำคัญมาก จะมีค่าตัวเลขความสำคัญน้อย";
                button_AllProcessArriveSametime.Text = "ทุกโปรเซสมาถึงในเวลาเดียวกัน";
                lbl_default.Text = "คืนค่าเริ่มต้น";
                btn_DecProcess.Text = "ลดจำนวนโปรเซส";
                btn_InsProcess.Text = "เพิ่มจำนวนโปรเซส";

                String p = "โปรเซสที่";
                for (int i = 0; i < 10; i++)
                {
                    lbl_process[i].Text = p + " " + (i + 1);
                }

                btn_back.Text = "กลับ";
                button2.Text = "ต่อไป";
            }
        }

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLanguage();
        }

        private void lbl_default_Click(object sender, EventArgs e)
        {
            setValueToDefault();
        }



        private void groupBox_option_Enter(object sender, EventArgs e)
        {

        }

        private void btn_InsProcess_Click(object sender, EventArgs e)
        {
            int num = myScheduling.getNumberProcess();
            if (num < 10)
            {
                arrivalTimeArray[num].Enabled = true;
                arrivalTimeArray[num].BackColor = Color.FromArgb(192, 255, 192);

                burstTimeArray[num].Enabled = true;
                burstTimeArray[num].BackColor = Color.FromArgb(192, 255, 192);

                priorityArray[num].Enabled = true;
                priorityArray[num].BackColor = Color.FromArgb(192, 255, 192);

                myScheduling.setNumberProcess(num+1);
            } 
        }

        private void btn_DecProcess_Click(object sender, EventArgs e)
        {
            int num = myScheduling.getNumberProcess();
            if (num >1)
            {
                arrivalTimeArray[num - 1].Enabled = false;
                arrivalTimeArray[num - 1].BackColor = Color.Gainsboro;
                arrivalTimeArray[num - 1].Value = 0;

                burstTimeArray[num - 1].Enabled = false;
                burstTimeArray[num - 1].BackColor = Color.Gainsboro;
                burstTimeArray[num - 1].Value = 1;

                priorityArray[num - 1].Enabled = false;
                priorityArray[num - 1].BackColor = Color.Gainsboro;
                priorityArray[num - 1].Value = 1;

                myScheduling.setNumberProcess(num - 1);
            } 
        }

    }
}
