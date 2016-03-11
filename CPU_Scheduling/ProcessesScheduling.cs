using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduling
{
    public class ProcessesScheduling
    {
        public String version_Program = "1.2";
        public String update_Date = "28 Feb 2016";

        public string language;
        public bool flag_language_bar;
        
        //First form
        private int num_process;

        // Input form
        private int[] cpu_brustTime;
        private int[] arrivalTime;
        private int[] priority;
        private int quantumTime;

        // After Process 
        public int[] waitingTime_FCFS;
        public int[] turnAroundTime_FCFS;
        public int[] ganttChart_FCFS;
        private int contextSwitch_FCFS;
        private float Avg_waitingTime_FCFS;
        public int num_ganttChart_FCFS;

        public int[] waitingTime_SJF_N;
        public int[] turnAroundTime_SJF_N;
        public int[] ganttChart_SJF_N;
        private int contextSwitch_SJF_N;
        private float Avg_waitingTime_SJF_N;
        public int num_ganttChart_SJF_N;

        public int[] waitingTime_SJF_P;
        public int[] turnAroundTime_SJF_P;
        public int[] ganttChart_SJF_P;
        private int contextSwitch_SJF_P;
        private float Avg_waitingTime_SJF_P;
        public int num_ganttChart_SJF_P;

        public int[] waitingTime_Priority_N;
        public int[] turnAroundTime_Priority_N;
        public int[] ganttChart_Priority_N;
        private int contextSwitch_Priority_N;
        private float Avg_waitingTime_Priority_N;
        public int num_ganttChart_Priority_N;

        public int[] waitingTime_Priority_P;
        public int[] turnAroundTime_Priority_P;
        public int[] ganttChart_Priority_P;
        private int contextSwitch_Priority_P;
        private float Avg_waitingTime_Priority_P;
        public int num_ganttChart_Priority_P;

        public int[] waitingTime_RR;
        public int[] turnAroundTime_RR;
        public int[] ganttChart_RR;
        private int contextSwitch_RR;
        private float Avg_waitingTime_RR;
        public int num_ganttChart_RR;

        // Flag 
        private bool flag_displayChart;
        private bool flag_FCFS;
        private bool flag_SJF_nonpre;
        private bool flag_SJF_pre;
        private bool flag_Priority_nonpre;
        private bool flag_Priority_pre;
        private bool flag_RR;

        // 
        public int number_ganttChart = 200;

        public ProcessesScheduling(){

            language = "EN";
            quantumTime = 5;
            flag_language_bar = false;

            waitingTime_FCFS = new int[10];
            turnAroundTime_FCFS = new int[10];
            ganttChart_FCFS = new int[number_ganttChart];

            waitingTime_SJF_N = new int[10];
            turnAroundTime_SJF_N = new int[10];
            ganttChart_SJF_N = new int[number_ganttChart];

            waitingTime_SJF_P = new int[10];
            turnAroundTime_SJF_P = new int[10];
            ganttChart_SJF_P = new int[number_ganttChart];

            waitingTime_Priority_N = new int[10];
            turnAroundTime_Priority_N = new int[10];
            ganttChart_Priority_N = new int[number_ganttChart];

            waitingTime_Priority_P = new int[10];
            turnAroundTime_Priority_P = new int[10];
            ganttChart_Priority_P = new int[number_ganttChart];

            waitingTime_RR = new int[10];
            turnAroundTime_RR = new int[10];
            ganttChart_RR = new int[number_ganttChart]; 

            cpu_brustTime = new int[10];
            arrivalTime = new int[10];
            priority = new int[10];

            // Initial value in array.
            clearArrayData(); // Clear waiting time.
            for (int i = 0; i < 10; i++)
            {
                cpu_brustTime[i] = 1;
                arrivalTime[i] = 0;
                priority[i] = 1;
            }

            for (int i = 0; i < number_ganttChart; i++)
            {
                ganttChart_FCFS[i] = -1;
                ganttChart_SJF_N[i] = -1;
                ganttChart_SJF_P[i] = -1;
                ganttChart_Priority_N[i] = -1;
                ganttChart_Priority_P[i] = -1;
                ganttChart_RR[i] = -1;
            }

            num_process = 1;
            flag_displayChart = true ;
            flag_FCFS = true;
            flag_SJF_nonpre = true;
            flag_SJF_pre = true;
            flag_Priority_nonpre = true;
            flag_Priority_pre = true;
            flag_RR = true;
            flag_displayChart = true ;

            Avg_waitingTime_FCFS = 0;
        }

        public void clearArrayData()
        {
            for (int i = 0; i < 10; i++)
            {
                waitingTime_FCFS[i] = 0;
                turnAroundTime_FCFS[i] = 0;

                waitingTime_SJF_N[i] = 0;
                turnAroundTime_SJF_N[i] = 0;

                waitingTime_SJF_P[i] = 0;
                turnAroundTime_SJF_P[i] = 0;

                waitingTime_Priority_P[i] = 0;
                turnAroundTime_Priority_P[i] = 0;

                waitingTime_Priority_N[i] = 0;
                turnAroundTime_Priority_N[i] = 0;

                waitingTime_RR[i] = 0;
                turnAroundTime_RR[i] = 0;
            }
        }

        public void clearDataRR()
        {
            for (int i = 0; i < 10; i++)
            {
                contextSwitch_RR = 0;
                waitingTime_RR[i] = 0;
                turnAroundTime_RR[i] = 0;
            }
        }

        public void clearContextSwitch()
        {
            contextSwitch_SJF_N = 0;
            contextSwitch_FCFS = 0;
            contextSwitch_SJF_P = 0;
            contextSwitch_Priority_N = 0;
            contextSwitch_Priority_P = 0;
            contextSwitch_RR = 0;
        }

        // Set and Get flag Display Gantt Chart.
        public void setFlagDisplayChart (bool value){
            flag_displayChart = value;
        }

        public bool getFlagDisplayChart(){
            return flag_displayChart;
        }

        // Set and Get Quantum Time.
        public int getQuantumTime()
        {
            return quantumTime;
        }

        public void setQuantunTime(int value)
        {
            quantumTime = value;
        }

        // Set and Get CPU Brust Time.
        public void setBrustTime(int index,int data){
            cpu_brustTime[index] = data;
        }

        public int getBrustTime(int index)
        {
            return cpu_brustTime[index];
        }

        // Set and Get Arrival Time.
        public void setArrivalTime(int index, int data)
        {
            arrivalTime[index] = data;
        }

        public int getArrivalTime(int index)
        {
            return arrivalTime[index];
        }

        // Set and Get Priority.
        public void setPriority(int index, int data)
        {
            priority[index] = data;
        }

        public int getPriority(int index)
        {
            return priority[index];
        }

        //Set and Get Number of Process.
        public void setNumberProcess(int value)
        {
            num_process = value;
        }

        public int getNumberProcess()
        {
            return num_process;
        }

        // Set All Flag Algorithm.
        public void setFlag_Algorithm(bool FCFS,bool SJF_P,bool SJF_N,bool priority_P,bool priority_N,bool RR)
        {
            flag_FCFS = FCFS;
            flag_SJF_pre = SJF_P;
            flag_SJF_nonpre = SJF_N;
            flag_Priority_pre = priority_P;
            flag_Priority_nonpre = priority_N;
            flag_RR = RR;
         }

        // Get Flag Algorithm.
        public bool getFlagFCFS()
        {
            return flag_FCFS;
        }

        public bool getFlagSJF_P()
        {
            return flag_SJF_pre;
        }

        public bool getFlagSJF_N()
        {
            return flag_SJF_nonpre;
        }

        public bool getFlagPriority_P()
        {
            return flag_Priority_pre;
        }

        public bool getFlagPriority_N()
        {
            return flag_Priority_nonpre;
        }

        public bool getFlagRR()
        {
            return flag_RR;
        }

        public float getAVG_waitingTimeFCFS()
        {
            return Avg_waitingTime_FCFS;
        }

        public int getContextSwitch_FCFS()
        {
            return contextSwitch_FCFS;
        }

        public float getAVG_waitingTimeSJF_N()
        {
            return Avg_waitingTime_SJF_N;
        }

        public int getContextSwitch_SJF_N()
        {
            return contextSwitch_SJF_N;
        }

        public float getAVG_waitingTimeSJF_P()
        {
            return Avg_waitingTime_SJF_P;
        }

        public int getContextSwitch_SJF_P()
        {
            return contextSwitch_SJF_P;
        }

        public float getAVG_waitingTimePriority_N()
        {
            return Avg_waitingTime_Priority_N;
        }

        public int getContextSwitch_Priority_N()
        {
            return contextSwitch_Priority_N;
        }

        public float getAVG_waitingTimePriority_P()
        {
            return Avg_waitingTime_Priority_P;
        }

        public int getContextSwitch_Priority_P()
        {
            return contextSwitch_Priority_P;
        }

        public float getAVG_waitingTimeRR()
        {
            return Avg_waitingTime_RR;
        }

        public int getContextSwitch_RR()
        {
            return contextSwitch_RR;
        }


        public void clearGanttChart()
        {
            for (int i = 0; i < number_ganttChart; i++)
            {
                ganttChart_FCFS[i] = -1;
                ganttChart_SJF_N[i] = -1;
                ganttChart_SJF_P[i] = -1;
            }
        }

        public void computeFCFS()
        {
            int n = num_process,min_arrival,index_min=0;
            int j;
            List<BlockData> myList = new List<BlockData>();
            for (int i = 0; i < num_process; i++)
            {
                // Add value in Array to list.
                myList.Add(new BlockData(i,arrivalTime[i],cpu_brustTime[i]));
            }

            int count = 0;
            int temp_index = 0;
            while (myList.Count !=0) // do until all process end.
            {
                
               min_arrival = myList.First().arrival;
               index_min   = myList.First().index ;

                j = 0;
                temp_index = 0;
                for(int i=0;i<myList.Count;i++,j++){
                    if (myList[i].arrival < min_arrival)
                    {
                        index_min = myList[i].index;
                        min_arrival = myList[i].arrival;
                        temp_index = j;  //for delete later.
                    }
                }

                while (count < min_arrival)
                {
                    ganttChart_FCFS[count] = -1;
                    count++;
                }

                waitingTime_FCFS[index_min] = count - arrivalTime[index_min];
                
                for (int i = 0; i < cpu_brustTime[index_min]; i++)
                {
                    if (count < number_ganttChart)
                    {
                        ganttChart_FCFS[count] = index_min; // set ganttchart in ms that is id process.
                    }
                    count++;
                }
                contextSwitch_FCFS++;
                turnAroundTime_FCFS[index_min] = count;
                 // find waiting time.
                myList.RemoveAt(temp_index);  // remove process in list.
            }

            if (count > number_ganttChart)
            {
                num_ganttChart_FCFS = number_ganttChart;
            }
            else
            {
                num_ganttChart_FCFS = count;
            }
           
            contextSwitch_FCFS--; // decrease last.
            Avg_waitingTime_FCFS = waitingTime_FCFS.Sum()/ (float)num_process;
            //return Avg_waitingTime_FCFS;
        }
        

        public void computeSJF_N()
        {
            int n = num_process, index_min = 0;
            int min_arrival, min_burst;
            int j;
            List<int> temp = new List<int>();
            List<BlockData> queueWaiting = new List<BlockData>();
            List<BlockData> myList = new List<BlockData>();
            for (int i = 0; i < num_process; i++)
            {
                // Add value in Array to list.
                myList.Add(new BlockData(i, arrivalTime[i], cpu_brustTime[i]));
            }

            int count = 0;
            int temp_index = 0;
            while (myList.Count > 0 || queueWaiting.Count > 0) // do until all process end.
            {
                // Find Process minimium Arrival. 
                j = 0;
                temp_index = 0;
                if (myList.Count > 0 && queueWaiting.Count == 0)
                {
                    min_arrival = myList.First().arrival;
                    index_min = myList.First().index;
                    for (int i = 0; i < myList.Count; i++, j++)
                    {
                        if (myList[i].arrival < min_arrival)
                        {
                           index_min = myList[i].index;
                           min_arrival = myList[i].arrival;
                           temp_index = j;  //for delete later.
                        }
                        if (myList[i].arrival <= count)
                        {
                          // Add process to waiting queue.
                            queueWaiting.Add(new BlockData(myList[i].index, myList[i].arrival, myList[i].burst_time));
                            temp.Add(i); // for delete later. 
                           // can not delete here because it effect with loop.
                        }
                    }

                   while (count < min_arrival)
                   {
                        ganttChart_SJF_N[count] = -1;
                        count++;
                   }
                }
                
                //delete value in list after move to QueueWaiting.
                while (temp.Count != 0)
                {
                    int temp_del = temp.Max(); // remove from Back list.
                    myList.RemoveAt(temp.Max());
                    temp.Remove(temp_del);
                }
                
                //queueWaiting.Add(myList[temp_index]);
                // remove process in list.

                // Find Process Minimium Brust.
                j = 0;
                temp_index = 0;
                if (queueWaiting.Count > 0)
                {
                    min_burst= queueWaiting.First().burst_time;
                    index_min = queueWaiting.First().index;
                    for (int i = 0; i < queueWaiting.Count; i++, j++)
                    {
                        if (queueWaiting[i].burst_time < min_burst)
                        {
                          index_min = queueWaiting[i].index;
                          min_burst= queueWaiting[i].burst_time;
                          temp_index = j;  //for delete later.
                        }
                    }

                    waitingTime_SJF_N[index_min] = count - arrivalTime[index_min];

                    for (int i = 0; i < cpu_brustTime[index_min]; i++)
                    {
                        if (count < number_ganttChart)
                        {
                            ganttChart_SJF_N[count] = index_min; // set ganttchart in ms that is id process.
                        }
                        count++;
                    }
                    turnAroundTime_SJF_N[index_min] = count;
                    contextSwitch_SJF_N++;
                    // find waiting time.
                    // flag_complete[index_min] = true; // complete process.
                    queueWaiting.RemoveAt(temp_index);  // remove process in list.
                }
            }

            if (count > number_ganttChart)
            {
                num_ganttChart_SJF_N = number_ganttChart;
            }
            else
            {
                num_ganttChart_SJF_N = count;
            }
           
            contextSwitch_SJF_N--; // decrease last.
            Avg_waitingTime_SJF_N = waitingTime_SJF_N.Sum() / (float)num_process;
        }

        public void computePriority_N()
        {
            int n = num_process, index_min = 0;
            int min_arrival, high_priority , burst;
            int j;
            List<int> temp = new List<int>();
            List<BlockData> queueWaiting = new List<BlockData>();
            List<BlockData> myList = new List<BlockData>();
            for (int i = 0; i < num_process; i++)
            {
                // Add value in Array to list.
                myList.Add(new BlockData(i, arrivalTime[i], cpu_brustTime[i],priority[i]));
            }

            int count = 0;
            int temp_index = 0;
            while (myList.Count > 0 || queueWaiting.Count > 0) // do until all process end.
            {
                // Find Process minimium Arrival. 
                j = 0;
                temp_index = 0;
                if (myList.Count > 0 && queueWaiting.Count==0)
                {
                    min_arrival = myList.First().arrival;
                    index_min = myList.First().index;
                    for (int i = 0; i < myList.Count; i++, j++)
                    {
                        if (myList[i].arrival < min_arrival)
                        {
                            index_min = myList[i].index;
                            min_arrival = myList[i].arrival;
                            temp_index = j;  //for delete later.
                        }
                        if (myList[i].arrival <= count)
                        {
                            // Add process to waiting queue.
                            queueWaiting.Add(new BlockData(myList[i].index, myList[i].arrival, myList[i].burst_time,myList[i].priority));
                            temp.Add(i); // for delete later. 
                            // can not delete here because it effect with loop.
                        }
                    }

                    while (count < min_arrival)
                    {
                        ganttChart_Priority_N[count] = -1;
                        count++;
                    }
                }

                //delete value in list after move to QueueWaiting.

                int temp_del;
                while (temp.Count != 0)
                {
                    temp_del = temp.Max(); // remove from Back list.
                    myList.RemoveAt(temp_del);
                    temp.Remove(temp_del);
                }

 
                // remove process in list.

                // Find Process Minimium Brust.
                j = 0;
                temp_index = 0;
                if (queueWaiting.Count > 0)
                {
                    // High Priority is minimium number Priority.
                    high_priority = queueWaiting.First().priority;
                    burst = queueWaiting.First().burst_time;
                    index_min = queueWaiting.First().index;
                    for (int i = 0; i < queueWaiting.Count; i++, j++)
                    {
                        if (queueWaiting[i].priority < high_priority)
                        {
                            index_min = queueWaiting[i].index;
                            high_priority = queueWaiting[i].priority;
                            temp_index = j;  //for delete later.
                        }
                    }

                    waitingTime_Priority_N[index_min] = count - arrivalTime[index_min];

                    for (int i = 0; i < cpu_brustTime[index_min]; i++)
                    {
                        if (count < number_ganttChart)
                        {
                            ganttChart_Priority_N[count] = index_min; // set ganttchart in ms that is id process.
                        }
                        count++;
                    }
                    turnAroundTime_Priority_N[index_min] = count;
                    contextSwitch_Priority_N++;
                    // find waiting time.
                    // flag_complete[index_min] = true; // complete process.
                    queueWaiting.RemoveAt(temp_index);  // remove process in list.
                }
            }

            if (count > number_ganttChart)
            {
                num_ganttChart_Priority_N = number_ganttChart;
            }
            else
            {
                num_ganttChart_Priority_N = count;
            }

            contextSwitch_Priority_N--; // decrease last.
            Avg_waitingTime_Priority_N = waitingTime_Priority_N.Sum() / (float)num_process;
        }

        public void computeSJF_P()
        {
            int n = num_process, index_min = 0;
            int index_process_before = -1; // not execute.
            int min_arrival, min_burst;
            int j;
            
            List<int> temp = new List<int>();
            List<BlockData> queueWaiting = new List<BlockData>();
            List<BlockData> myList = new List<BlockData>();

            // For use preemptive.
            int[] backup_cpu_burstTime = new int[num_process];
            int[] save_waitingTime= new int[num_process];
            int count_process_incomplete = num_process;

            for (int i = 0; i < num_process; i++)
            {
                // Add value in Array to list.
                myList.Add(new BlockData(i, arrivalTime[i], cpu_brustTime[i]));
                backup_cpu_burstTime[i] = cpu_brustTime[i];
            }

            int count = 0;
            int temp_index = 0;
            while (count_process_incomplete > 0) // do until all process end.
            {
                // Find Process minimium Arrival. 
                j = 0;
                temp_index = 0;
                if (myList.Count > 0)
                {
                    min_arrival = myList.First().arrival;
                    index_min = myList.First().index;
                    for (int i = 0; i < myList.Count; i++, j++)
                    {
                        if (myList[i].arrival < min_arrival)
                        {
                            index_min = myList[i].index;
                            min_arrival = myList[i].arrival;
                            temp_index = j;  //for delete later.
                        }
                        if (myList[i].arrival <= count)
                        {
                            // Add process to waiting queue.
                            queueWaiting.Add(new BlockData(myList[i].index, myList[i].arrival, myList[i].burst_time));
                            temp.Add(i); // for delete later. 
                            // can not delete here because it effect with loop.
                        }
                    }

                    if (queueWaiting.Count == 0)
                    {
                        while (count < min_arrival)
                        {
                            ganttChart_SJF_P[count] = -1;
                            count++;
                        }
                    }
                }

                //delete value in list after move to QueueWaiting.
                while (temp.Count != 0)
                {
                    int temp_del = temp.Max(); // remove from Back list.
                    myList.RemoveAt(temp_del);
                    temp.Remove(temp_del);
                }

                //queueWaiting.Add(myList[temp_index]);
                // remove process in list.

                // Find Process Minimium Brust.
                j = 0;
                temp_index = 0;
                if (queueWaiting.Count > 0)
                {
                    min_burst = queueWaiting.First().burst_time;
                    index_min = queueWaiting.First().index;
                    for (int i = 0; i < queueWaiting.Count; i++, j++)
                    {
                        if (queueWaiting[i].burst_time < min_burst)
                        {
                            index_min = queueWaiting[i].index;
                            min_burst = queueWaiting[i].burst_time;
                            temp_index = j;  //for delete later.
                        }
                    }

                    if(index_process_before == -1){
                        index_process_before = index_min;
                        waitingTime_SJF_P[index_min] = count;
                    }
                    else if (index_process_before != index_min)
                    {
                        waitingTime_SJF_P[index_min] += count - turnAroundTime_SJF_P[index_min];
                        turnAroundTime_SJF_P[index_process_before] = count;
                        contextSwitch_SJF_P++;
                    }
                    index_process_before = index_min;

                    // Excute 1 ms.
                    queueWaiting[temp_index].burst_time--;
                    if (queueWaiting[temp_index].burst_time == 0)
                    {
                        count_process_incomplete--;
                        turnAroundTime_SJF_P[index_min] = count;
                        queueWaiting.RemoveAt(temp_index);  // remove process in list.
                    }

                    if (count < number_ganttChart)
                    {
                        ganttChart_SJF_P[count] = index_min; // set ganttchart in ms that is id process.
                    }
                    count++;
                    // find waiting time.
                    // flag_complete[index_min] = true; // complete process.
                    
                }
            }

            if (count > number_ganttChart)
            {
                num_ganttChart_SJF_P = number_ganttChart;
            }
            else
            {
                num_ganttChart_SJF_P = count;
            }

            for (int i=0; i < num_process; i++)
            {
                waitingTime_SJF_P[i] = waitingTime_SJF_P[i] - arrivalTime[i];
            }

            turnAroundTime_SJF_P[index_process_before]++; // increase last 1 ms last process . 
            Avg_waitingTime_SJF_P = waitingTime_SJF_P.Sum() / (float)num_process;
        }

        public void computePriority_P()
        {
            int n = num_process, index_min = 0;
            int index_process_before = -1; // not execute.
            int min_arrival;
            int j, high_priority;

            List<int> temp = new List<int>();
            List<BlockData> queueWaiting = new List<BlockData>();
            List<BlockData> myList = new List<BlockData>();

            // For use preemptive.
            int[] backup_cpu_burstTime = new int[num_process];
            int[] save_waitingTime = new int[num_process];
            int count_process_incomplete = num_process;

            for (int i = 0; i < num_process; i++)
            {
                // Add value in Array to list.
                myList.Add(new BlockData(i, arrivalTime[i], cpu_brustTime[i],priority[i]));
                backup_cpu_burstTime[i] = cpu_brustTime[i];
            }

            int count = 0;
            int temp_index = 0;
            while (count_process_incomplete > 0) // do until all process end.
            {
                // Find Process minimium Arrival. 
                j = 0;
                temp_index = 0;
                if (myList.Count > 0)
                {
                    min_arrival = myList.First().arrival;
                    index_min = myList.First().index;
                    for (int i = 0; i < myList.Count; i++, j++)
                    {
                        if (myList[i].arrival < min_arrival)
                        {
                            index_min = myList[i].index;
                            min_arrival = myList[i].arrival;
                            temp_index = j;  //for delete later.
                        }
                        if (myList[i].arrival <= count)
                        {
                            // Add process to waiting queue.
                            queueWaiting.Add(new BlockData(myList[i].index, myList[i].arrival, myList[i].burst_time,myList[i].priority));
                            temp.Add(i); // for delete later. 
                            // can not delete here because it effect with loop.
                        }
                    }

                    if (queueWaiting.Count == 0)
                    {
                        while (count < min_arrival)
                        {
                            ganttChart_Priority_P[count] = -1;
                            count++;
                        }
                    }
                }

                //delete value in list after move to QueueWaiting.
                while (temp.Count != 0)
                {
                    int temp_del = temp.Max(); // remove from Back list.
                    myList.RemoveAt(temp_del);
                    temp.Remove(temp_del);
                }

                //queueWaiting.Add(myList[temp_index]);
                // remove process in list.

                // Find Process Minimium Brust.
                j = 0;
                temp_index = 0;
                if (queueWaiting.Count > 0)
                {
                    high_priority = queueWaiting.First().priority;
                    index_min = queueWaiting.First().index;
                    for (int i = 0; i < queueWaiting.Count; i++, j++)
                    {
                        if (queueWaiting[i].priority < high_priority)
                        {
                            index_min = queueWaiting[i].index;
                            //min_burst = queueWaiting[i].burst_time;
                            high_priority = queueWaiting[i].priority;
                            temp_index = j;  //for delete later.
                        }
                    }

                    if (index_process_before == -1)
                    {
                        index_process_before = index_min;
                        waitingTime_Priority_P[index_min] = count;
                    }
                    else if (index_process_before != index_min)
                    {
                        waitingTime_Priority_P[index_min] += count - turnAroundTime_Priority_P[index_min];
                        turnAroundTime_Priority_P[index_process_before] = count;
                        contextSwitch_Priority_P++;
                    }
                    index_process_before = index_min;

                    // Excute 1 ms.
                    queueWaiting[temp_index].burst_time--;
                    if (queueWaiting[temp_index].burst_time == 0)
                    {
                        count_process_incomplete--;
                        turnAroundTime_Priority_P[index_min] = count;
                        queueWaiting.RemoveAt(temp_index);  // remove process in list.
                    }

                    if (count < number_ganttChart)
                    {
                        ganttChart_Priority_P[count] = index_min; // set ganttchart in ms that is id process.
                    }
                    count++;
                }
            }

            if (count > number_ganttChart)
            {
                num_ganttChart_Priority_P = number_ganttChart;
            }
            else
            {
                num_ganttChart_Priority_P = count;
            }

            for (int i = 0; i < num_process; i++)
            {
                waitingTime_Priority_P[i] = waitingTime_Priority_P[i] - arrivalTime[i];
            }

            turnAroundTime_Priority_P[index_process_before]++; // increase last 1 ms last process . 
            Avg_waitingTime_Priority_P = waitingTime_Priority_P.Sum() / (float)num_process;
        }

        public void computeRR()
        {
            int n = num_process, index_min = 0;
            int index_process_before = -1; // not execute.
            int min_arrival;
            int j;
            int myQuantumTime = quantumTime;
            BlockData myData;

            List<int> temp = new List<int>();
            Queue<BlockData> queueWaiting = new Queue<BlockData>();
            List<BlockData> myList = new List<BlockData>();

            // For use preemptive.
            //int[] backup_cpu_burstTime = new int[num_process];
            int count_process_incomplete = num_process;

            for (int i = 0; i < num_process; i++)
            {
                // Add value in Array to list.
                myList.Add(new BlockData(i, arrivalTime[i], cpu_brustTime[i]));
                //backup_cpu_burstTime[i] = cpu_brustTime[i];
            }

            int count = 0;
            int temp_index = 0;
            while (count_process_incomplete > 0) // do until all process end.
            {
                // Find Process minimium Arrival. 
                j = 0;
                temp_index = 0;
                if (myList.Count > 0)
                {
                    min_arrival = myList.First().arrival;
                    index_min = myList.First().index;
                    for (int i = 0; i < myList.Count; i++, j++)
                    {
                        if (myList[i].arrival < min_arrival)
                        {
                            index_min = myList[i].index;
                            min_arrival = myList[i].arrival;
                            temp_index = j;  //for delete later.
                        }
                        if (myList[i].arrival <= count)
                        {
                            // Add process to waiting queue.
                            queueWaiting.Enqueue(new BlockData(myList[i].index, myList[i].arrival, myList[i].burst_time));
                            temp.Add(i); // for delete later. 
                            // can not delete here because it effect with loop.
                        }
                    }

                    if (queueWaiting.Count == 0)
                    {
                        while (count < min_arrival)
                        {
                            ganttChart_RR[count] = -1;
                            count++;
                        }
                    }
                }

                //delete value in list after move to QueueWaiting.
                while (temp.Count != 0)
                {
                    int temp_del = temp.Max(); // remove from Back list.
                    myList.RemoveAt(temp_del);
                    temp.Remove(temp_del);
                }

                //queueWaiting.Add(myList[temp_index]);
                // remove process in list.

                // Find Process Minimium Brust.
                j = 0;
                temp_index = 0;
                if (queueWaiting.Count > 0)
                {
                    myData = queueWaiting.Dequeue();

                    if (index_process_before == -1)
                    {
                        index_process_before = myData.index;
                        waitingTime_RR[myData.index] = count;
                    }
                    else if (index_process_before != myData.index)
                    {
                        waitingTime_RR[myData.index] += count - turnAroundTime_RR[myData.index];
                        turnAroundTime_RR[index_process_before] = count;
                        contextSwitch_RR++;
                    }
                    index_process_before = myData.index;

                    // Excute 1 ms.
                    for (int i = 0; i < myQuantumTime && myData.burst_time>0; i++)
                    {
                        myData.burst_time--;
                        if (count < number_ganttChart)
                        {
                            ganttChart_RR[count] = myData.index;
                        }
                        count++;
                    }

                    if (myData.burst_time == 0)
                    {
                        count_process_incomplete--;
                        turnAroundTime_RR[myData.index] = count;
                        myData = null;
                    }
                    else
                    {
                        queueWaiting.Enqueue(new BlockData(myData.index,myData.arrival,myData.burst_time));
                    }   
                }
            }

            if (count > number_ganttChart)
            {
                num_ganttChart_RR = number_ganttChart;
            }
            else
            {
                num_ganttChart_RR = count;
            }

            for (int i = 0; i < num_process; i++)
            {
                waitingTime_RR[i] = waitingTime_RR[i] - arrivalTime[i];
            }

            turnAroundTime_RR[index_process_before]++; // increase last 1 ms last process . 
            Avg_waitingTime_RR = waitingTime_RR.Sum() / (float)num_process;
        } 
    }
}
