using AIF.TERMINAL.AIFTerminalService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIF.TERMINAL.Forms
{
    public partial class PaletYapma_3 : form_Base
    {
        public PaletYapma_3(string _formName, List<string> _list)
        {
            InitializeComponent();

            AutoScaleMode = AutoScaleMode.None;

            initialWidth = Width;
            initialHeight = Height;

            initialFontSize = lblArama.Font.Size;
            lblArama.Resize += Form_Resize;

            list = _list;

            txtPaletNo.Text = list[0].ToString();
            txtUrunKodu.Text = list[1].ToString();
            txtUrunTanim.Text = list[2].ToString();
            txtQty.Text = list[3].ToString();

            formName = _formName;
        }

        List<string> list = new List<string>();
        public static string dialogresult = "";
        public static double quantity = 0;
        string formName = "";
        private void Form_Resize(object sender, EventArgs e)
        {
            //start font
            SuspendLayout();

            float proportionalNewWidth = (float)Width / initialWidth;
            float proportionalNewHeight = (float)Height / initialHeight;

            lblArama.Font = new Font(lblArama.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                lblArama.Font.Style);

            label1.Font = new Font(lblArama.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                label1.Font.Style);

            lblForm.Font = new Font(lblForm.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                lblForm.Font.Style);

            lblUrunKodu.Font = new Font(lblUrunKodu.Font.FontFamily, initialFontSize *
               (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
               lblUrunKodu.Font.Style);

            lblTanim.Font = new Font(lblTanim.Font.FontFamily, initialFontSize *
               (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
               lblTanim.Font.Style);

            txtUrunKodu.Font = new Font(txtUrunKodu.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                txtUrunKodu.Font.Style);

            btnKapat.Font = new Font(btnKapat.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                btnKapat.Font.Style);

            txtPaletNo.Font = new Font(txtPaletNo.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                txtPaletNo.Font.Style);

            txtUrunTanim.Font = new Font(txtUrunTanim.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                txtUrunTanim.Font.Style);

            txtQty.Font = new Font(txtQty.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                txtQty.Font.Style); 

            ResumeLayout();
            //start yükseklik-genislik
            txtUrunKodu.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            txtPaletNo.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            txtUrunTanim.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            txtQty.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            //end yükseklik-genislik
            //end font
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

        //start font.
        public int initialWidth;
        public int initialHeight;
        public float initialFontSize;
        //end font  
        private void btnKapat_Click(object sender, EventArgs e)
        {
            dialogresult = "Ok";
            quantity = txtQty.Text == "" ? 0 : Convert.ToDouble(txtQty.Value);
            Close();
        }

        private void PaletYapma_3_Load(object sender, EventArgs e)
        {
            lblForm.Text = formName;

            txtQty.DecimalPlaces = Giris.genelParametreler.OndalikMiktar;
        }

        private void txtQty_Click(object sender, EventArgs e)
        {
            SayiKlavyesi sayiKlavyesi = new SayiKlavyesi(txtQty, null, false);
            sayiKlavyesi.ShowDialog();
        }
    }
}
