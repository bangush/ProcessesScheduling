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
    public partial class Result_form1 : Form
    {
        Panel[] panelArray;
        Panel[] panelExColorProcess;
        Label[] processWaitingTime;
        Label[] processTurnaroundTime;
        Label[] valueGanttChart;
        Label[] label_process;

        ProcessesScheduling myScheduling;

        static Color colorProcess1 = Color.Red;
        static Color colorProcess2 = Color.Yellow;
        static Color colorProcess3 = Color.Magenta;
        static Color colorProcess4 = Color.Blue;
        static Color colorProcess5 = Color.Lime;
        static Color colorProcess6 = Color.Chocolate;
        static Color colorProcess7 = Color.Aqua;
        static Color colorProcess8 = Color.DarkGreen;
        static Color colorProcess9 = Color.Maroon;
        static Color colorProcess10 = Color.Pink;
        static Color colorFreeTime = Color.Silver;
        static Color color_btn_choose = Color.Silver;
        static Color color_btn_not_choose= Color.WhiteSmoke;

        public Result_form1()
        {  
            InitializeComponent();
        }

        public Result_form1(ProcessesScheduling myScheduling)
        {
            InitializeComponent();
            this.myScheduling = myScheduling;

            panelExColorProcess = new Panel[10];
            processWaitingTime = new Label[10];
            processTurnaroundTime = new Label[10];
            label_process = new Label[10];
            
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

           
            
            panelArray      = new Panel[myScheduling.number_ganttChart];
            valueGanttChart = new Label[myScheduling.number_ganttChart];
            
            setEnableButtonMenu();
            setColorButtonMenu();
            setVisibleQuantumTime(false);

            // Check want display Gantt Chart.
            if (myScheduling.getFlagDisplayChart())
            {
                DrawGanttChart();
            }

            if (myScheduling.getFlagFCFS())
            {
                btn_FCFS.BackColor = color_btn_choose;
                if (myScheduling.getFlagDisplayChart())
                {
                    putColorInPanel("FCFS");
                }
                displayFCFS();
            }
            else if (myScheduling.getFlagSJF_P())
            {
                btn_SJF_P.BackColor = color_btn_choose;
                if (myScheduling.getFlagDisplayChart())
                {
                    putColorInPanel("SJF_P");
                }
                displaySJF_P();
            }
            else if (myScheduling.getFlagSJF_N())
            {
                btn_SJF_N.BackColor = color_btn_choose;
                if (myScheduling.getFlagDisplayChart())
                {
                    putColorInPanel("SJF_N");
                }
                displaySJF_N();
            }
            else if (myScheduling.getFlagPriority_P())
            {
                btn_Priority_P.BackColor = color_btn_choose;
                if (myScheduling.getFlagDisplayChart())
                {
                    putColorInPanel("Priority_P");
                }
                displayPriority_P();
            }
            else if (myScheduling.getFlagPriority_N())
            {
                btn_Priority_N.BackColor = color_btn_choose;
                if (myScheduling.getFlagDisplayChart())
                {
                    putColorInPanel("Priority_N");
                }
                displayPriority_N();
            }
            else if (myScheduling.getFlagRR())
            {
                setVisibleQuantumTime(true);
                numeric_quantumTime.Value = myScheduling.getQuantumTime();
                btn_RR.BackColor = color_btn_choose;
                if (myScheduling.getFlagDisplayChart())
                {
                    putColorInPanel("RR");
                }
                displayRR();
            }
            
        }

        public void setColorButtonMenu()
        {
            btn_FCFS.BackColor = color_btn_not_choose;
            btn_SJF_P.BackColor = color_btn_not_choose;
            btn_SJF_N.BackColor = color_btn_not_choose;
            btn_Priority_P.BackColor = color_btn_not_choose;
            btn_Priority_N.BackColor = color_btn_not_choose;
            btn_RR.BackColor = color_btn_not_choose;
        }

        public void setEnableButtonMenu()
        {
            // Start All Button disenabled.
            // Enible button for button user choose only.
            if (myScheduling.getFlagFCFS())
            {
                btn_FCFS.Enabled = true; ;
            }
            if (myScheduling.getFlagPriority_P())
            {
                btn_Priority_P.Enabled = true;
            }
            if (myScheduling.getFlagPriority_N())
            {
                btn_Priority_N.Enabled = true;
            }
            if (myScheduling.getFlagSJF_P())
            {
                btn_SJF_P.Enabled = true;
            }
            if (myScheduling.getFlagSJF_N())
            {
                btn_SJF_N.Enabled = true;
            }
            if (myScheduling.getFlagRR())
            {
                btn_RR.Enabled = true;
            }
        }

        public void DrawGanttChart()
        {
            int xPos = 9, yPos = 10;
            tabPage_GanttChart.AutoScroll = true;
            tabPage_GanttChart.VerticalScroll.LargeChange = tabPage_GanttChart.VerticalScroll.Maximum / 2;
            for (int i = 0; i < myScheduling.number_ganttChart; i++)
            {
                panelArray[i] = new Panel();
                panelArray[i].Width = 20;
                panelArray[i].Height = 20;
                panelArray[i].Location = new Point(xPos, yPos);
                
                valueGanttChart[i] = new Label();
                valueGanttChart[i].Text = "" + i;
                valueGanttChart[i].Font = labelEX.Font;
                valueGanttChart[i].Size = new Size(20, 10);
                valueGanttChart[i].Location = new Point(xPos - 4, 40);
                valueGanttChart[i].TextAlign = ContentAlignment.MiddleLeft;
                valueGanttChart[i].ForeColor = Color.Gray;
                valueGanttChart[i].BackColor = Color.Transparent;
                valueGanttChart[i].Visible = false; 

                xPos += panelArray[i].Width;
                tabPage_GanttChart.Controls.Add(panelArray[i]);
                tabPage_GanttChart.Controls.Add(valueGanttChart[i]);
            }
        }

        public void clearVisibleLabel()
        {
            for (int i = 0; i < myScheduling.number_ganttChart; i++)
            {
                valueGanttChart[i].Visible = false;
            }
        }

        public void setVisibleQuantumTime(bool value)
        {
            lbl_quantumTime.Visible = value;
            numeric_quantumTime.Visible = value;
            btn_ok_quantumTime.Visible = value;
        }

        public void clearGanttChart()
        {
            for (int i = 0; i < myScheduling.number_ganttChart; i++)
            {
                panelArray[i].BackColor = Color.White;
                valueGanttChart[i].Visible = false;
            }
        }

        public int findNumGanttfromName(string key)
        {
            int num = 0;
            switch (key)
            {
                case "FCFS": num = myScheduling.num_ganttChart_FCFS; break;
                case "SJF_N": num = myScheduling.num_ganttChart_SJF_N; break;
                case "SJF_P": num = myScheduling.num_ganttChart_SJF_P; break;
                case "Priority_N": num = myScheduling.num_ganttChart_Priority_N; break;
                case "Priority_P": num = myScheduling.num_ganttChart_Priority_P; break;
                case "RR": num = myScheduling.num_ganttChart_RR; break;
            }
            return num;
        }

        public void putColorInPanel(string key)
        {
            int num_ganttChart=0;
            num_ganttChart = findNumGanttfromName(key);
            //clearColorAllPanel();
            valueGanttChart[0].Visible = true;
            for (int i = 0; i < num_ganttChart; i++)
            {
                switch (key)
                {
                    case "FCFS": panelArray[i].BackColor = getColorThisPanel(myScheduling.ganttChart_FCFS[i]); break;
                    case "SJF_N": panelArray[i].BackColor = getColorThisPanel(myScheduling.ganttChart_SJF_N[i]); break;
                    case "SJF_P": panelArray[i].BackColor = getColorThisPanel(myScheduling.ganttChart_SJF_P[i]); break;
                    case "Priority_N": panelArray[i].BackColor = getColorThisPanel(myScheduling.ganttChart_Priority_N[i]); break;
                    case "Priority_P": panelArray[i].BackColor = getColorThisPanel(myScheduling.ganttChart_Priority_P[i]); break;
                    case "RR": panelArray[i].BackColor = getColorThisPanel(myScheduling.ganttChart_RR[i]); break;
                    
                    //case "FCFS": panelArray[i].BackColor = getColorThisPanel(myScheduling.ganttChart_FCFS[i]); break;

                }
                if (i>0)
                {
                    // Visible Label Value Gantt Chart.
                    if (panelArray[i-1].BackColor != panelArray[i].BackColor)
                    {
                        valueGanttChart[i].Visible = true;
                    }
                }
            }

            // if Gantt chart many too with page. 
            if (num_ganttChart == myScheduling.number_ganttChart)
            {
                panelArray[num_ganttChart - 1].BackColor = Color.White;
                valueGanttChart[num_ganttChart-1].Visible = true;
            }
            else
            {
                
                valueGanttChart[num_ganttChart].Visible = true;
            }
            
        }

        public Color getColorThisPanel(int key)
        {
            Color temp = Color.Silver;
            switch(key){
                case 0: temp = colorProcess1; break;
                case 1: temp = colorProcess2; break;
                case 2: temp = colorProcess3; break;
                case 3: temp = colorProcess4; break;
                case 4: temp = colorProcess5; break;
                case 5: temp = colorProcess6; break;
                case 6: temp = colorProcess7; break;
                case 7: temp = colorProcess8; break;
                case 8: temp = colorProcess9; break;
                case 9: temp = colorProcess10; break;
                default : temp = colorFreeTime; break;
            }
            return temp;
        }

        public void setLabelGanttChart_FCFS()
        {
            int num = myScheduling.num_ganttChart_FCFS;
            for (int i = 1; i < num; i++)
            {
                if(myScheduling.ganttChart_FCFS[i]!=myScheduling.ganttChart_FCFS[i-1]){
                    //
                }
            }
        }

        public void displayFCFS()
        {
            int num = myScheduling.getNumberProcess();
            for (int i = 0; i < num; i++)
            {
                processWaitingTime[i].Text = myScheduling.waitingTime_FCFS[i].ToString();
                processTurnaroundTime[i].Text = myScheduling.turnAroundTime_FCFS[i].ToString();
            }

            lbl_avg_waitingTime.Text = "" + myScheduling.getAVG_waitingTimeFCFS().ToString("0.00");
            lbl_contextSwitch.Text = "" + myScheduling.getContextSwitch_FCFS();
        }

        public void displaySJF_N()
        {
            int num = myScheduling.getNumberProcess();
            for (int i = 0; i < num; i++)
            {
                processWaitingTime[i].Text = myScheduling.waitingTime_SJF_N[i].ToString();
                processTurnaroundTime[i].Text = myScheduling.turnAroundTime_SJF_N[i].ToString();
            }
            lbl_avg_waitingTime.Text = "" + myScheduling.getAVG_waitingTimeSJF_N().ToString("0.00");
            lbl_contextSwitch.Text = "" + myScheduling.getContextSwitch_SJF_N();
        }

        public void displaySJF_P()
        {
            int num = myScheduling.getNumberProcess();
            for (int i = 0; i < num; i++)
            {
                processWaitingTime[i].Text = myScheduling.waitingTime_SJF_P[i].ToString();
                processTurnaroundTime[i].Text = myScheduling.turnAroundTime_SJF_P[i].ToString();
            }
            lbl_avg_waitingTime.Text = "" + myScheduling.getAVG_waitingTimeSJF_P().ToString("0.00");
            lbl_contextSwitch.Text = "" + myScheduling.getContextSwitch_SJF_P();
        }

        public void displayPriority_N()
        {
            int num = myScheduling.getNumberProcess();
            for (int i = 0; i < num; i++)
            {
                processWaitingTime[i].Text = myScheduling.waitingTime_Priority_N[i].ToString();
                processTurnaroundTime[i].Text = myScheduling.turnAroundTime_Priority_N[i].ToString();
            }
            lbl_avg_waitingTime.Text = "" + myScheduling.getAVG_waitingTimePriority_N().ToString("0.00");
            lbl_contextSwitch.Text = "" + myScheduling.getContextSwitch_Priority_N();
        }

        public void displayPriority_P()
        {
            int num = myScheduling.getNumberProcess();
            for (int i = 0; i < num; i++)
            {
                processWaitingTime[i].Text = myScheduling.waitingTime_Priority_P[i].ToString();
                processTurnaroundTime[i].Text = myScheduling.turnAroundTime_Priority_P[i].ToString();
            }
            lbl_avg_waitingTime.Text = "" + myScheduling.getAVG_waitingTimePriority_P().ToString("0.00");
            lbl_contextSwitch.Text = "" + myScheduling.getContextSwitch_Priority_P();
        }

        public void displayRR()
        {
            int num = myScheduling.getNumberProcess();
            for (int i = 0; i < num; i++)
            {
                processWaitingTime[i].Text = myScheduling.waitingTime_RR[i].ToString();
                processTurnaroundTime[i].Text = myScheduling.turnAroundTime_RR[i].ToString();
            }
            lbl_avg_waitingTime.Text = "" + myScheduling.getAVG_waitingTimeRR().ToString("0.00");
            lbl_contextSwitch.Text = "" + myScheduling.getContextSwitch_RR();
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

            processWaitingTime[0] = lbl_p1_waitingTime;
            processWaitingTime[1] = lbl_p2_waitingTime;
            processWaitingTime[2] = lbl_p3_waitingTime;
            processWaitingTime[3] = lbl_p4_waitingTime;
            processWaitingTime[4] = lbl_p5_waitingTime;
            processWaitingTime[5] = lbl_p6_waitingTime;
            processWaitingTime[6] = lbl_p7_waitingTime;
            processWaitingTime[7] = lbl_p8_waitingTime;
            processWaitingTime[8] = lbl_p9_waitingTime;
            processWaitingTime[9] = lbl_p10_waitingTime;

            processTurnaroundTime[0] = lbl_p1_turnaroundTime;
            processTurnaroundTime[1] = lbl_p2_turnaroundTime;
            processTurnaroundTime[2] = lbl_p3_turnaroundTime;
            processTurnaroundTime[3] = lbl_p4_turnaroundTime;
            processTurnaroundTime[4] = lbl_p5_turnaroundTime;
            processTurnaroundTime[5] = lbl_p6_turnaroundTime;
            processTurnaroundTime[6] = lbl_p7_turnaroundTime;
            processTurnaroundTime[7] = lbl_p8_turnaroundTime;
            processTurnaroundTime[8] = lbl_p9_turnaroundTime;
            processTurnaroundTime[9] = lbl_p10_turnaroundTime;

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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Input_Form form2 = new Input_Form(myScheduling);
            form2.Show();
            form2.Location = this.Location;
            //form2.StartPosition = this.StartPosition;
            Hide();  
        }

        private void Result_form1_Load(object sender, EventArgs e)
        {

        }

       private void setVisibleContent(){
           int num = myScheduling.getNumberProcess();
           for (int i = 0; i < 10; i++)
           {
               if (i < num)
               {
                   panelExColorProcess[i].Visible = true ;
                   processWaitingTime[i].Visible = true;
                   processTurnaroundTime[i].Visible = true;
                   label_process[i].Visible = true;
               }
               else
               {
                   panelExColorProcess[i].Visible = false;
                   processWaitingTime[i].Visible = false;
                   processTurnaroundTime[i].Visible = false;
                   label_process[i].Visible = false;
               }
           } 
        }
      
        private void btn_FCFS_Click(object sender, EventArgs e)
        {
            setColorButtonMenu();
            setVisibleQuantumTime(false);
            btn_FCFS.BackColor = color_btn_choose;
            if (myScheduling.getFlagDisplayChart())
            {
                clearGanttChart();
                putColorInPanel("FCFS");
            }

            displayFCFS();
        }

        private void btn_SJF_P_Click(object sender, EventArgs e)
        {
            setColorButtonMenu();
            setVisibleQuantumTime(false);
            btn_SJF_P.BackColor = color_btn_choose;
            if (myScheduling.getFlagDisplayChart())
            {
                clearGanttChart();
                putColorInPanel("SJF_P");
            }

            displaySJF_P();
        }

        private void btn_SJF_N_Click(object sender, EventArgs e)
        {
            setColorButtonMenu();
            setVisibleQuantumTime(false);
            btn_SJF_N.BackColor = color_btn_choose;
            if (myScheduling.getFlagDisplayChart())
            {
                clearGanttChart();
                putColorInPanel("SJF_N");
            }
            displaySJF_N();
        }

        private void btn_Priority_N_Click(object sender, EventArgs e)
        {
            setColorButtonMenu();
            setVisibleQuantumTime(false);
            btn_Priority_N.BackColor = color_btn_choose;
            if (myScheduling.getFlagDisplayChart())
            {
                clearGanttChart();
                putColorInPanel("Priority_N");
            }
            displayPriority_N();
        }

        private void btn_Priority_P_Click(object sender, EventArgs e)
        {
            setColorButtonMenu();
            setVisibleQuantumTime(false);
            btn_Priority_P.BackColor = color_btn_choose;
            if (myScheduling.getFlagDisplayChart())
            {
                clearGanttChart();
                putColorInPanel("Priority_P");
            }
            displayPriority_P();
        }

        private void btn_RR_Click(object sender, EventArgs e)
        {
            setColorButtonMenu();
            setVisibleQuantumTime(true);
            numeric_quantumTime.Value = myScheduling.getQuantumTime();
            btn_RR.BackColor = color_btn_choose;
            if (myScheduling.getFlagDisplayChart())
            {
                clearGanttChart();
                putColorInPanel("RR");
            }
            displayRR();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            From_Summary form2 = new From_Summary(myScheduling);
            form2.Show();
            form2.Location = this.Location;
            Hide();
        }

        private void btn_ok_quantumTime_Click(object sender, EventArgs e)
        {
            myScheduling.setQuantunTime((int)numeric_quantumTime.Value);
            myScheduling.clearDataRR();
            myScheduling.computeRR();
            if (myScheduling.getFlagDisplayChart())
            {
                clearVisibleLabel();
                putColorInPanel("RR");
            }
            displayRR();
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
                groupBox_ResultProcess.Text = "Result";
                tabPage_GanttChart.Text = "Gantt Chart";
                lbl_quantumTime.Text = "Quantum time";
                btn_ok_quantumTime.Text = "Calculate";

                lbl_waitingTime_l.Text = "Waiting time";
                lbl_waitingTime_r.Text ="Waiting time";
                lbl_turnaroundTime_l.Text = "Turnaround time";
                lbl_turnaroundTime_r.Text = "Turnaround time";

                lbl_avg_wait.Text = "Average waiting time";
                lbl_con.Text = "Context switch";
                lbl_freeTime.Text = "Free time";
                btn_back.Text = "Back";
                button7.Text = "Next";
                lbl_con_times.Text = "times";

                String p = "Process";
                for (int i = 0; i < 10; i++)
                {
                    label_process[i].Text = p +" " +(i+1);
                }
            }
            else if (comboBox_language.SelectedIndex == 1)
            {
                myScheduling.language = "TH";
                lbl_language.Text = "       ภาษา";
                groupBox_ResultProcess.Text = "ผลลัพธ์";
                tabPage_GanttChart.Text = "แผนภูมิแกนต์";
                lbl_quantumTime.Text = "  เวลาควันตัม";
                btn_ok_quantumTime.Text = "คำนวณ";

                lbl_waitingTime_l.Text = "เวลาที่รอ";
                lbl_waitingTime_r.Text = "เวลาที่รอ";
                lbl_turnaroundTime_l.Text = "เวลาครบงาน";
                lbl_turnaroundTime_r.Text = "เวลาครบงาน";

                lbl_avg_wait.Text = "        ค่าเฉลี่ยการรอ";
                lbl_con.Text = "การสลับการทำงาน";
                lbl_freeTime.Text = "เวลาว่าง";
                btn_back.Text = "กลับ";
                button7.Text = "ต่อไป";
                lbl_con_times.Text = "ครั้ง";

                String p = "โปรเซสที่";
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
