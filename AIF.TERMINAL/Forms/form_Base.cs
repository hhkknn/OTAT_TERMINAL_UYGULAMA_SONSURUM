using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIF.TERMINAL.Forms
{
    public partial class form_Base : Form
    {
        public form_Base()
        {
            InitializeComponent();

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.ClassStyle |= 0x20000;

                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }
        private void baseBackButton_Click(object sender, EventArgs e)
        {
            //var menus = (Menu)sender;
            //Menu menu = new Forms.Menu(null, null);
            //menu.Show(); 
            this.Close();
        }

        private void baseExitButton_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            CustomMsgBoxQuestion.Show("UYGULAMA KAPATILACAKTIR.DEVAM ETMEK İSTİYOR MUSUNUZ?", "Uyarı", "Evet", "Hayır");
        }

        private void form_Base_Load(object sender, EventArgs e)
        {
            if (Giris.mKodValue == "10TRMN")
            {
                //lblGirisBaslik.Text = "TUNÇMATİK BAYİ YÖNETİM SİSTEMİ";
                this.BackgroundImage = Properties.Resources.OTAT_UVT_ArkaPlanV3;
            }
            else if (Giris.mKodValue == "30TRMN")
            {
                //pictureEdit1.Image = Properties.Resources.AIFTeam2;
                //this.BackgroundImage = Properties.Resources.Arkaplan_gri_jpeg;
                this.BackgroundImage = Properties.Resources.ANATOLYA_ARKAPLAN_jpeg;


            }
        }
        bool formresize = false;
        private void form_Base_Resize(object sender, EventArgs e)
        {
            //if (formresize)
            //{
            //    return;
            //}
            //if (WindowState == FormWindowState.Minimized)
            //{
            //    foreach (Form form in Application.OpenForms)
            //    {
            //        formresize = true;
            //        form.WindowState = FormWindowState.Minimized;
            //    }

            //}
            //else if (WindowState == FormWindowState.Maximized)
            //{
            //    foreach (Form form in Application.OpenForms)
            //    {
            //        form.WindowState = FormWindowState.Maximized;
            //    }
            //}

            //formresize = false;
        }

        private void buttonBaseMinimized_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
        }

        private void baseLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
