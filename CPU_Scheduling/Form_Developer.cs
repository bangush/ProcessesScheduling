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
    public partial class Form_Developer : Form
    {
        ProcessesScheduling myScheduling;
        public Form_Developer()
        {
            InitializeComponent();
        }

        public Form_Developer(ProcessesScheduling myScheduling)
        {
            InitializeComponent();
            this.myScheduling = myScheduling;
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

        }

        private void Form_Developer_Load(object sender, EventArgs e)
        {

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
                groupBox_dev.Text = "Developer";
                groupBox_support.Text = "Support";
                lbl_benz.Text = "Mr. Panuwat Jantawee";
                lbl_nam.Text = "Miss Patcharaporn Todkhaw";
                lbl_tong.Text = "Mr. Chawakorn Tinsuk";
                lbl_gun.Text = "Mr. Thanaporn Chaiyo";
                lbl_james.Text = "Mr. Apiwat Autama";
                lbl_ma.Text = "Miss Fatima Mama";
                btn_back.Text = "Back";
            }
            else if (comboBox_language.SelectedIndex == 1)
            {
                myScheduling.language = "TH";
                lbl_language.Text = "       ภาษา";
                groupBox_dev.Text = "ผู้พัฒนา";
                groupBox_support.Text = "สนับสนุน";
                lbl_benz.Text = "นาย ภาณุวัฒน จันทวี";
                lbl_nam.Text = "นางสาว พัชรพร ต๊อดแก้ว";
                lbl_tong.Text = "นาย ชวกร ถิ่นสุข";
                lbl_gun.Text = "นาย ธนพร ไยโช";
                lbl_james.Text = "นาย อภิวัฒน์ อุตมะ";
                lbl_ma.Text = "นางสาว ฟาตีมา มามาะ";
                btn_back.Text = "กลับ";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_Menu form2 = new Form_Menu(myScheduling);

            form2.Show();
            form2.Location = this.Location;
            Hide();
        }

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLanguage();
        }

        private void lbl_projectName_Click(object sender, EventArgs e)
        {

        }
    }
}
