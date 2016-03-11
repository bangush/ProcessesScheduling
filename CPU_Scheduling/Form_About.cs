using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduling
{
    public partial class Form_About : Form
    {
        ProcessesScheduling myScheduling;
        public Form_About()
        {
            InitializeComponent();
        }

        public Form_About(ProcessesScheduling myScheduling)
        {
            InitializeComponent();
            this.myScheduling = myScheduling;
            comboBox_rating.SelectedIndex = 0;

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

            label_versionProgram.Text = "" + myScheduling.version_Program;
            label_updateDate.Text = "" + myScheduling.update_Date;
        }


        private void Form_About_Load(object sender, EventArgs e)
        {

        }

        private void btn_send_msg_Click(object sender, EventArgs e)
        {
            if (comboBox_rating.SelectedIndex != 0)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("benznest.dev@gmail.com");
                    mail.To.Add("benznest.dev@gmail.com");
                    mail.Subject = "Feedback from Processes Scheduling";
                    mail.Body = " Rating : " + comboBox_rating.SelectedItem.ToString()+"\r\n    " + txt_body.Text;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("benznest.dev@gmail.com", "");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    if (myScheduling.language == "EN")
                    {
                        MessageBox.Show("Message send success , Thank you for your feedback.");
                    }
                    else if (myScheduling.language == "TH")
                    {
                        MessageBox.Show("ข้อความถูกส่งเรียบร้อยแล้ว , ขอบคุณสำหรับการตอบกลับของคุณ.");
                    }
                    
               }
               catch (Exception ex)
               {
                   if (myScheduling.language == "EN")
                   {
                       MessageBox.Show(ex.ToString() + " Please try check your internet.");
                   }
                   else if (myScheduling.language == "TH")
                   {
                       MessageBox.Show(ex.ToString() +" เราพบข้อผิดพลาดบางอย่าง กรุณาตรวจสอบการเชื่อมต่อของคุณ และลองอีกครั้ง");
                   }
                    
               }
            }
            else
            {
                if (myScheduling.language == "EN")
                {
                    MessageBox.Show("Please choose rating before send your message.");
                }
                else if (myScheduling.language == "TH")
                {
                    MessageBox.Show("กรุณาให้คะแนนก่อนการส่งข้อความ");
                }
            }
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
                lbl_language.Text = "Language";
                btn_back.Text = "Back";
                groupBox_About.Text = "About";
                groupBox_Feedback.Text = "Feedback";
                lbl_version.Text = "Version";
                lbl_update.Text = "Updated";
                lbl_thx.Text = "Thank you for using our app.";
                lbl_feedbackToUs.Text = "Feedback to us.";
                lbl_writeMessage.Text = "Write your message to us.";
                lbl_rating.Text = "Rating";
                btn_send_msg.Text = "Send message now";
            }
            else if (comboBox_language.SelectedIndex == 1)
            {
                myScheduling.language = "TH";
                lbl_language.Text = "       ภาษา";
                btn_back.Text = "กลับ";
                groupBox_About.Text = "เกี่ยวกับ";
                groupBox_Feedback.Text = "ตอบกลับ";
                lbl_version.Text = "เวอชั่น";
                lbl_update.Text = "อัพเดทล่าสุด";
                lbl_thx.Text = "ขอบคุณสำหรับการใช้งานของคุณ";
                lbl_feedbackToUs.Text = "ติดต่อเราได้ที่";
                lbl_writeMessage.Text = "เขียนข้อความของคุณถึงเรา";
                lbl_rating.Text = "ให้คะแนน";
                btn_send_msg.Text = "ส่งข้อความตอนนี้";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // Navigate Page.
            Form_Menu form = new Form_Menu(myScheduling);
            form.Show();
            form.Location = this.Location;
            Hide();
        }

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLanguage();
        }

    }
}
