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
    public partial class From_Summary : Form
    {
        ProcessesScheduling myScheduling;
        Panel[] panelExColorProcess;
        Label[] label_Aviral;
        Label[] label_Burst;
        Label[] label_Priority;
        Label[] label_process;
        public From_Summary()
        {
            InitializeComponent();
        }
        
        public From_Summary(ProcessesScheduling myScheduling)
        {
            InitializeComponent();
            this.myScheduling = myScheduling;
            panelExColorProcess = new Panel[10];
            label_Aviral    = new Label[10];
            label_Burst     = new Label[10];
            label_Priority  = new Label[10];
            label_process   = new Label[10];

            accessContent();
            setVisibleContent();
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

            clearData();
            setData();
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Result_form1 form2 = new Result_form1(myScheduling);
            form2.Show();
            form2.Location = this.Location;
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Input_Form form2 = new Input_Form(myScheduling);
            form2.Show();
            form2.Location = this.Location;
            Hide();
        }

        private void From_Summary_Load(object sender, EventArgs e)
        {

        }

        public void accessContent()
        {
            panelExColorProcess[0] = panel_ex_1;
            panelExColorProcess[1] = panel_ex_2;
            panelExColorProcess[2] = panel_ex_3;
            panelExColorProcess[3] = panel_ex_4;
            panelExColorProcess[4] = panel_ex_5;
            panelExColorProcess[5] = panel_ex_6;
            panelExColorProcess[6] = panel_ex_7;
            panelExColorProcess[7] = panel_ex_8;
            panelExColorProcess[8] = panel_ex_9;
            panelExColorProcess[9] = panel_ex_10;
            
            label_Aviral[0] = lbl_p1_Arrival;
            label_Aviral[1] = lbl_p2_Arrival;
            label_Aviral[2] = lbl_p3_Arrival;
            label_Aviral[3] = lbl_p4_Arrival;
            label_Aviral[4] = lbl_p5_Arrival;
            label_Aviral[5] = lbl_p6_Arrival;
            label_Aviral[6] = lbl_p7_Arrival;
            label_Aviral[7] = lbl_p8_Arrival;
            label_Aviral[8] = lbl_p9_Arrival;
            label_Aviral[9] = lbl_p10_Arrival;

            label_Burst[0] = lbl_p1_BurstTime;
            label_Burst[1] = lbl_p2_BurstTime;
            label_Burst[2] = lbl_p3_BurstTime;
            label_Burst[3] = lbl_p4_BurstTime;
            label_Burst[4] = lbl_p5_BurstTime;
            label_Burst[5] = lbl_p6_BurstTime;
            label_Burst[6] = lbl_p7_BurstTime;
            label_Burst[7] = lbl_p8_BurstTime;
            label_Burst[8] = lbl_p9_BurstTime;
            label_Burst[9] = lbl_p10_BurstTime;

            label_Priority[0] = lbl_p1_Priority;
            label_Priority[1] = lbl_p2_Priority;
            label_Priority[2] = lbl_p3_Priority;
            label_Priority[3] = lbl_p4_Priority;
            label_Priority[4] = lbl_p5_Priority;
            label_Priority[5] = lbl_p6_Priority;
            label_Priority[6] = lbl_p7_Priority;
            label_Priority[7] = lbl_p8_Priority;
            label_Priority[8] = lbl_p9_Priority;
            label_Priority[9] = lbl_p10_Priority;

            label_process[0] = lbl_p1;
            label_process[1] = lbl_p2;
            label_process[2] = lbl_p3;
            label_process[3] = lbl_p4;
            label_process[4] = lbl_p5;
            label_process[5] = lbl_p6;
            label_process[6] = lbl_p7;
            label_process[7] = lbl_p8;
            label_process[8] = lbl_p9;
            label_process[9] = lbl_p10;
        }

        private void setVisibleContent()
        {
            int num = myScheduling.getNumberProcess();
            for (int i = 0; i < 10; i++)
            {
                if (i < num)
                {
                    panelExColorProcess[i].Visible = true;
                    label_process[i].Visible = true;
                    label_Aviral[i].Visible = true;
                    label_Burst[i].Visible = true;
                    label_Priority[i].Visible = true;
                }
                else
                {
                    panelExColorProcess[i].Visible = false;
                    label_process[i].Visible = false;
                    label_Aviral[i].Visible = false;
                    label_Burst[i].Visible = false;
                    label_Priority[i].Visible = false;
                }
            }
        }

        public void setData()
        {
            int num = myScheduling.getNumberProcess();
            for (int i = 0; i < num; i++)
            {
                label_Aviral[i].Text = myScheduling.getArrivalTime(i).ToString();
                label_Burst[i].Text = myScheduling.getBrustTime(i).ToString();
                label_Priority[i].Text = myScheduling.getPriority(i).ToString();
            }

            if (myScheduling.getFlagFCFS())
            {
                lbl_avg_FCFS.Text = "" + myScheduling.getAVG_waitingTimeFCFS().ToString("0.00");
                lbl_contextSwitch_FCFS.Text = "" + myScheduling.getContextSwitch_FCFS();
            }
            if (myScheduling.getFlagSJF_P())
            {
                lbl_avg_SJF_P.Text = "" + myScheduling.getAVG_waitingTimePriority_P().ToString("0.00");
                lbl_contextSwitch_SJF_P.Text = "" + myScheduling.getContextSwitch_SJF_P();
            }
            if (myScheduling.getFlagSJF_N())
            {
                lbl_avg_SJF_N.Text = "" + myScheduling.getAVG_waitingTimeSJF_N().ToString("0.00");
                lbl_contextSwitch_SJF_N.Text = "" + myScheduling.getContextSwitch_SJF_N();
            }
            if (myScheduling.getFlagPriority_P())
            {
                lbl_avg_Priority_P.Text = "" + myScheduling.getAVG_waitingTimePriority_P().ToString("0.00");
                lbl_contextSwitch_Priority_P.Text = "" + myScheduling.getContextSwitch_Priority_P();
            
            }
            if (myScheduling.getFlagPriority_N())
            {
                lbl_avg_Priority_N.Text = "" + myScheduling.getAVG_waitingTimePriority_N().ToString("0.00");
                lbl_contextSwitch_Priority_N.Text = "" + myScheduling.getContextSwitch_Priority_N();
            }
            if (myScheduling.getFlagRR())
            {
                lbl_avg_RR.Text = "" + myScheduling.getAVG_waitingTimeRR().ToString("0.00");
                lbl_contextSwitch_RR.Text = "" + myScheduling.getContextSwitch_RR();
                lbl_quantumTime.Text = ""+ myScheduling.getQuantumTime().ToString();
            }
        }

        public void clearData()
        {
            lbl_avg_FCFS.Text = "-";
            lbl_avg_SJF_P.Text = "-";
            lbl_avg_SJF_N.Text = "-";
            lbl_avg_Priority_P.Text = "-";
            lbl_avg_Priority_N.Text = "-";
            lbl_avg_RR.Text = "-";

            lbl_contextSwitch_FCFS.Text = "-";
            lbl_contextSwitch_SJF_P.Text = "-";
            lbl_contextSwitch_SJF_N.Text = "-";
            lbl_contextSwitch_Priority_P.Text = "-";
            lbl_contextSwitch_Priority_N.Text = "-";
            lbl_contextSwitch_RR.Text = "-"; 
        }

        private void setVisibleLanguageBar()
        {
            lbl_language.Visible = myScheduling.flag_language_bar;
            comboBox_language.Visible = myScheduling.flag_language_bar;
        }

        private void setLanguage()
        {
            if (comboBox_language.SelectedIndex == 0)
            {
                myScheduling.language = "EN";
                lbl_language.Text = "language";
                groupBox_ResultProcess.Text = "Summary";

                lbl_arrival.Text = "Arrival";
                lbl_burst.Text = "Burst";
                lbl_priority.Text = "Priority";

                lbl_avg.Text = "Average waiting time";
                lbl_con.Text = "Context switch";
                lbl_topic.Text = "Your data";

                btn_back.Text = "Back";
                button7.Text = "Done";

                label_unit_con_1.Text = "times";
                label_unit_con_2.Text = "times";
                label_unit_con_3.Text = "times";
                label_unit_con_4.Text = "times";
                label_unit_con_5.Text = "times";
                label_unit_con_6.Text = "times";
                

                String p = "Process";
                for (int i = 0; i < 10; i++)
                {
                    label_process[i].Text = p + " " + (i + 1);
                }
            }
            else if (comboBox_language.SelectedIndex == 1)
            {
                myScheduling.language = "TH";
                lbl_language.Text = "       ภาษา";
                groupBox_ResultProcess.Text = "สรุปผล";

                lbl_arrival.Text = "เวลาที่มาถึง";
                lbl_burst.Text = "เวลาทำงาน";
                lbl_priority.Text = "ความสำคัญ";

                lbl_avg.Text = "           ค่าเฉลี่ยการรอ";
                lbl_con.Text = "สลับการทำงาน";
                lbl_topic.Text = "ข้อมูลของคุณ";
                label_unit_con_1.Text = "ครั้ง";
                label_unit_con_2.Text = "ครั้ง";
                label_unit_con_3.Text = "ครั้ง";
                label_unit_con_4.Text = "ครั้ง";
                label_unit_con_5.Text = "ครั้ง";
                label_unit_con_6.Text = "ครั้ง";

                btn_back.Text = "กลับ";
                button7.Text = "เสร็จสิ้น";


                String p = "โปรเซสที่ ";
                for (int i = 0; i < 10; i++)
                {
                    label_process[i].Text = p + " " + (i + 1);
                }
            }
        }

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLanguage();
        }
    }
}
