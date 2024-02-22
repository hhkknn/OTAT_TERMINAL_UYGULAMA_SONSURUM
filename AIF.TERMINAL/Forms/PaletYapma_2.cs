﻿using AIF.TERMINAL.AIFTerminalService;
using AIF.TERMINAL.Models;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIF.TERMINAL.Forms
{
    public partial class PaletYapma_2 : form_Base
    {
        //start font.
        public int initialWidth;
        public int initialHeight;
        public float initialFontSize;
        //end font
        public PaletYapma_2(string _formName, string _paletNo)
        {
            InitializeComponent();
            //start font
            AutoScaleMode = AutoScaleMode.None;

            initialWidth = Width;
            initialHeight = Height;

            initialFontSize = frmName.Font.Size;
            frmName.Resize += Form_Resize;

            //initialFontSize = dtpStartDate.Font.Size;
            //dtpStartDate.Resize += Form_Resize;

            //initialFontSize = dtpEndDate.Font.Size;
            //dtpEndDate.Resize += Form_Resize;

            //initialFontSize = txtSearch.Font.Size;
            //txtSearch.Resize += Form_Resize;

            //initialFontSize = dtgPaletListesiDetay.Font.Size;
            //dtgPaletListesiDetay.Resize += Form_Resize;
            //end font

            formName = _formName;
            paletNo = _paletNo;
            txtPaletNo.Text = paletNo;

            PaletYapmaListesiDetay();

        }
        //declares
        [DllImport("user32.dll")]
        private static extern bool PostMessage(
        IntPtr hWnd, // handle to destination window
        Int32 msg, // message
        Int32 wParam, // first message parameter
        Int32 lParam // second message parameter
        );

        private const Int32 WM_LBUTTONDOWN = 0x0201;

        //
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

        private void Form_Resize(object sender, EventArgs e)
        {
            //start font
            SuspendLayout();

            float proportionalNewWidth = (float)Width / initialWidth;
            float proportionalNewHeight = (float)Height / initialHeight;

            btnRafEtkYazdir.Font = new Font(btnRafEtkYazdir.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                btnRafEtkYazdir.Font.Style);


            label2.Font = new Font(label2.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                label2.Font.Style);

            label3.Font = new Font(label3.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                label3.Font.Style);

            label4.Font = new Font(label4.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                label4.Font.Style);

            frmName.Font = new Font(frmName.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                frmName.Font.Style);

            dtgPaletListesiDetay.Font = new Font(dtgPaletListesiDetay.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                dtgPaletListesiDetay.Font.Style);

            btnDetay.Font = new Font(btnDetay.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                btnDetay.Font.Style);

            btnOnayla.Font = new Font(btnOnayla.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                btnOnayla.Font.Style);

            btnSatirSil.Font = new Font(btnSatirSil.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                btnSatirSil.Font.Style);

            txtBarkod.Font = new Font(txtBarkod.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                txtBarkod.Font.Style);

            cmbPrinter.Font = new Font(cmbPrinter.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                cmbPrinter.Font.Style);

            cmbDurum.Font = new Font(cmbDurum.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                cmbDurum.Font.Style);

            btnSevkEtkYazdir.Font = new Font(btnSevkEtkYazdir.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                btnSevkEtkYazdir.Font.Style);

            lblToplamKap.Font = new Font(lblToplamKap.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                lblToplamKap.Font.Style);

            lblNetKilo.Font = new Font(lblNetKilo.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                lblNetKilo.Font.Style);

            lblBrutKilo.Font = new Font(lblBrutKilo.Font.FontFamily, initialFontSize *
                (proportionalNewWidth > proportionalNewHeight ? proportionalNewHeight : proportionalNewWidth),
                lblBrutKilo.Font.Style);

            ResumeLayout();
            //start yükseklik-genislik 
            txtPaletNo.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            txtBarkod.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            txtToplamKap.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            txtNetKilo.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            txtBrutKilo.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            cmbPrinter.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            cmbDurum.Font = new Font("Microsoft Sans Serif", 22, FontStyle.Bold);
            //end yükseklik-genislik
            //end font
        }

        string formName = "";
        string paletNo = "";
        public static bool kayitYapildi = false;
        DataTable dtPaletYapmaListesiDetay = new DataTable();
        private void PaletYapma2_Load(object sender, EventArgs e)
        {
            frmName.Text = formName;

            txtNetKilo.DecimalPlaces = Giris.genelParametreler.OndalikMiktar;
            txtBrutKilo.DecimalPlaces = Giris.genelParametreler.OndalikMiktar;
            txtToplamKap.DecimalPlaces = Giris.genelParametreler.OndalikMiktar; 

            ComboboxItem item = new ComboboxItem();
            item.Text = "AKTIF";
            item.Value = "A";

            cmbDurum.Items.Add(item);

            item = new ComboboxItem();
            item.Text = "PASIF";
            item.Value = "P";

            cmbDurum.Items.Add(item);

            cmbDurum.SelectedIndex = 0;
        }

        private void PaletYapmaListesiDetay()
        {
            AIFTerminalServiceSoapClient aIFTerminalServiceSoapClient = new AIFTerminalServiceSoapClient();
            Response resp = aIFTerminalServiceSoapClient.getPaletYapmaListesiDetaylari(Giris._dbName, paletNo, Giris.mKodValue, Giris.genelParametreler.CekmeListesiKalemleriniGrupla);

            if (resp._list != null)
            {
                dtPaletYapmaListesiDetay = resp._list;
                dtgPaletListesiDetay.DataSource = null;

                dtgPaletListesiDetay.DataSource = dtPaletYapmaListesiDetay;

                dtgPaletListesiDetay.RowTemplate.Height = 55;
                dtgPaletListesiDetay.ColumnHeadersHeight = 60;

                dtgPaletListesiDetay.Columns["Miktar"].DefaultCellStyle.Format = "N" + Giris.genelParametreler.OndalikMiktar;


                dtPaletYapmaListesiDetay.Columns.Add("dtgSira", typeof(int));


                for (int i = 0; i <= dtgPaletListesiDetay.Rows.Count - 1; i++)
                {
                    dtgPaletListesiDetay.Rows[i].Cells["dtgSira"].Value = Convert.ToInt32(i);
                }

                dtgPaletListesiDetay.Columns["Kalem Tanimi"].Name = "Kalem Tanımı";
                dtgPaletListesiDetay.Columns["dtgSira"].Visible = false;
                dtgPaletListesiDetay.Columns["ToplamKap"].Visible = false;
                dtgPaletListesiDetay.Columns["NetKilo"].Visible = false;
                dtgPaletListesiDetay.Columns["BrutKilo"].Visible = false;
                dtgPaletListesiDetay.Columns["SiparisNumarasi"].Visible = false;
                dtgPaletListesiDetay.Columns["SiparisSatirNo"].Visible = false;
                listAllPrinters();

                vScrollBar1.Maximum = dtgPaletListesiDetay.RowCount + 5;

                if (resp._list.Rows.Count > 0)
                {
                    txtToplamKap.Text = resp._list.Rows[0]["ToplamKap"] == DBNull.Value ? "0" : string.Format("{0:#,##0.0000}", double.Parse(resp._list.Rows[0]["ToplamKap"].ToString()));
                    txtNetKilo.Text = resp._list.Rows[0]["NetKilo"] == DBNull.Value ? "0" : string.Format("{0:#,##0.0000}", double.Parse(resp._list.Rows[0]["NetKilo"].ToString()));
                    txtBrutKilo.Text = resp._list.Rows[0]["BrutKilo"] == DBNull.Value ? "0" : string.Format("{0:#,##0.0000}", double.Parse(resp._list.Rows[0]["BrutKilo"].ToString()));
                }
            }
            else
            {
                dtgPaletListesiDetay.DataSource = null;
            }
        }

        private bool doubleclick = false;
        private void btnDetay_Click(object sender, EventArgs e)
        {
            try
            {

                try
                {
                    var cekmeNo = dtgPaletListesiDetay.Rows[currentRow].Cells["CekmeNo"].Value.ToString();

                    if (cekmeNo != null && cekmeNo.ToString() != "" && cekmeNo != "-1")
                    {
                        CustomMsgBox.Show("ÇEKME LİSTESİNDEN EKLENEN BU PALETİN İÇERİĞİ YALNIZCA ÇEKME LİSTESİNDEN DÜZENLENEBİLİR.", "Uyarı", "Tamam", "");
                        return;
                    }



                }
                catch (Exception ex)
                {

                }

                if (dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("Barkod") == txtBarkod.Text).Count() == 0 && dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("MuhatapKatalogNo") == txtBarkod.Text).Count() == 0 && dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("Kalem Kodu") == txtBarkod.Text).Count() == 0)
                {
                    bool urunBulundu = false;
                    AIFTerminalServiceSoapClient aIFTerminalServiceSoapClient = new AIFTerminalServiceSoapClient();
                    Response resp = new Response();

                    if (txtBarkod.Text != "TANIMSIZ")
                    {
                        resp = aIFTerminalServiceSoapClient.GetProductByBarCode(Giris._dbName, txtBarkod.Text, Giris.mKodValue);
                    }



                    if (resp._list == null)
                    {
                        resp = aIFTerminalServiceSoapClient.GetProductByMuhatapKatalogNoWithWareHouse(Giris._dbName, txtBarkod.Text, "", "", Giris.mKodValue);
                    }
                    else
                    {
                        urunBulundu = true;
                    }

                    if (resp._list == null)
                    {
                        resp = aIFTerminalServiceSoapClient.GetProductByItemCode(Giris._dbName, txtBarkod.Text, Giris.mKodValue);
                    }

                    if (resp._list != null)
                    {
                        urunBulundu = true;
                    }


                    if (urunBulundu)
                    {
                        DataRow dr = dtPaletYapmaListesiDetay.NewRow();
                        dr["Palet No"] = txtPaletNo.Text;
                        dr["Kalem Kodu"] = resp._list.Rows[0]["Kalem Kodu"].ToString();
                        dr["Kalem Tanimi"] = resp._list.Rows[0]["Kalem Tanımı"].ToString();
                        dr["Miktar"] = "0";

                        resp = aIFTerminalServiceSoapClient.getKalemKoduMuhatapKatalogNoBarkod(Giris._dbName, resp._list.Rows[0]["Kalem Kodu"].ToString(), "", Giris.mKodValue);

                        if (resp._list != null)
                        {
                            dr["MuhatapKatalogNo"] = resp._list.Rows[0]["MuhatapKatalogNo"].ToString();
                            dr["Barkod"] = resp._list.Rows[0]["Barkod"].ToString();
                        }

                        dtPaletYapmaListesiDetay.Rows.Add(dr);

                        dtgPaletListesiDetay.DataSource = dtPaletYapmaListesiDetay;

                        for (int i = 0; i <= dtgPaletListesiDetay.Rows.Count - 1; i++)
                        {
                            dtgPaletListesiDetay.Rows[i].Cells["dtgSira"].Value = Convert.ToInt32(i);
                        }


                        currentRow = dtgPaletListesiDetay.Rows.Count - 1;
                        kalemKodu = dtPaletYapmaListesiDetay.Rows[dtPaletYapmaListesiDetay.Rows.Count - 1]["Kalem Kodu"].ToString();
                        kalemTanimi = dtPaletYapmaListesiDetay.Rows[dtPaletYapmaListesiDetay.Rows.Count - 1]["Kalem Tanimi"].ToString();
                        miktar = dtgPaletListesiDetay.Rows[dtPaletYapmaListesiDetay.Rows.Count - 1].Cells["Miktar"].Value == DBNull.Value || dtgPaletListesiDetay.Rows[dtPaletYapmaListesiDetay.Rows.Count - 1].Cells["Miktar"].Value.ToString() == "" ? 0 : Convert.ToDouble(dtgPaletListesiDetay.Rows[dtPaletYapmaListesiDetay.Rows.Count - 1].Cells["Miktar"].Value);

                        List<string> s = new List<string>();
                        s.Add(txtPaletNo.Text);
                        s.Add(kalemKodu);
                        s.Add(kalemTanimi);
                        s.Add(miktar.ToString());

                        PaletYapma_3 paletYapma_3 = new PaletYapma_3("PALET LİSTESİ MİKTAR", s);
                        paletYapma_3.ShowDialog();

                        if (PaletYapma_3.dialogresult == "Ok")
                        {
                            dtPaletYapmaListesiDetay.Rows[currentRow]["Miktar"] = PaletYapma_3.quantity;


                            PaletYapma_3.dialogresult = "";
                        }

                        if (PaletYapma_3.quantity == 0)
                        {
                            dtPaletYapmaListesiDetay.Rows.RemoveAt(currentRow);
                        }

                        dtgPaletListesiDetay.Rows[currentRow].Selected = false;

                        kalemKodu = "";
                        kalemTanimi = "";
                        miktar = 0;
                    }
                }
                else
                {
                    if (!doubleclick)
                    {
                        int sira = -1;
                        if (dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("Barkod") == txtBarkod.Text).Count() > 0)
                        {
                            sira = dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("Barkod") == txtBarkod.Text).Select(c => c.Field<int>("dtgSira")).FirstOrDefault();
                            var arg = new DataGridViewCellEventArgs(dtPaletYapmaListesiDetay.Rows.Count, sira);
                            dtgPaletListesiDetay_CellClick(dtgPaletListesiDetay, arg);
                        }
                        else if (dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("MuhatapKatalogNo") == txtBarkod.Text).Count() > 0)
                        {
                            sira = dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("MuhatapKatalogNo") == txtBarkod.Text).Select(c => c.Field<int>("dtgSira")).FirstOrDefault();
                            var arg = new DataGridViewCellEventArgs(dtPaletYapmaListesiDetay.Rows.Count, sira);
                            dtgPaletListesiDetay_CellClick(dtgPaletListesiDetay, arg);
                        }
                        else if (dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("UrunKodu") == txtBarkod.Text).Count() > 0)
                        {
                            sira = dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("UrunKodu") == txtBarkod.Text).Select(c => c.Field<int>("dtgSira")).FirstOrDefault();
                            var arg = new DataGridViewCellEventArgs(dtgPaletListesiDetay.Rows.Count, sira);
                            dtgPaletListesiDetay_CellClick(dtgPaletListesiDetay, arg);
                        }

                        if (sira == -1)
                        {
                            return;
                        }
                    }

                    List<string> s = new List<string>();
                    s.Add(txtPaletNo.Text);
                    s.Add(kalemKodu);
                    s.Add(kalemTanimi);
                    s.Add(miktar.ToString());

                    PaletYapma_3 paletYapma_3 = new PaletYapma_3("PALET LİSTESİ MİKTAR", s);
                    paletYapma_3.ShowDialog();

                    if (PaletYapma_3.dialogresult == "Ok")
                    {
                        dtPaletYapmaListesiDetay.Rows[currentRow]["Miktar"] = PaletYapma_3.quantity;

                        if (PaletYapma_3.quantity == 0)
                        {
                            dtPaletYapmaListesiDetay.Rows.RemoveAt(currentRow);
                        }
                        PaletYapma_3.dialogresult = "";
                    }
                    dtgPaletListesiDetay.Rows[currentRow].Selected = false;
                }
                txtBarkod.Text = "";
                doubleclick = false;
            }
            catch (Exception)
            {

            }
        }

        private void btnSatirSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgPaletListesiDetay.DataSource == null)
                {
                    return;
                }
                if (currentRow > -1)
                {
                    if (dtgPaletListesiDetay.CurrentCell != null)
                    {
                        DialogResult resp = CustomMsgBtn.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "Uyarı", "EVET", "HAYIR");

                        if (CustomMsgBtn.result == DialogResult.Yes)
                        {
                            string dtgSira = dtgPaletListesiDetay.Rows[currentRow].Cells["dtgSira"].Value.ToString();

                            if (dtgSira != "")
                            {

                                silinecekPaletlers.Add(new SilinecekPaletler
                                {
                                    paletNo = dtgPaletListesiDetay.Rows[currentRow].Cells["Palet No"].Value.ToString(),
                                    siparisNo = Convert.ToInt32(dtgPaletListesiDetay.Rows[currentRow].Cells["SiparisNumarasi"].Value),
                                    siparisSatirNo = Convert.ToInt32(dtgPaletListesiDetay.Rows[currentRow].Cells["SiparisSatirNo"].Value),
                                    cekmeNo = dtgPaletListesiDetay.Rows[currentRow].Cells["CekmeNo"].Value.ToString(),
                                    kalemKodu = dtgPaletListesiDetay.Rows[currentRow].Cells["Kalem Kodu"].Value.ToString(),
                                    kaynak = dtgPaletListesiDetay.Rows[currentRow].Cells["Kaynak"].Value.ToString(),
                                    miktar = Math.Round(Convert.ToDouble(dtgPaletListesiDetay.Rows[currentRow].Cells["Miktar"].Value), Giris.genelParametreler.OndalikMiktar)
                                });


                                var query = dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<int>("dtgSira") == Convert.ToInt32(dtgSira));

                                foreach (var row in query.ToList())
                                    row.Delete();

                                dtPaletYapmaListesiDetay.AcceptChanges();
                            }

                            //dtgPaletListesiDetay.Rows.RemoveAt(currentRow);
                            //dtgPaletListesiDetay.Refresh();
                        }


                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public static int currentRow;
        int satirNumarasi = -1;
        string barcode = "";
        string muhatapkatalogno = "";
        string kalemKodu = "";
        string kalemTanimi = "";
        int siparisNo = 0;
        int siparisSatirNo = 0;
        double miktar = 0;
        private void dtgPaletListesiDetay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                barcode = dtgPaletListesiDetay.Rows[e.RowIndex].Cells["Barkod"].Value.ToString();
                muhatapkatalogno = dtgPaletListesiDetay.Rows[e.RowIndex].Cells["MuhatapKatalogNo"].Value.ToString();
                kalemKodu = dtgPaletListesiDetay.Rows[e.RowIndex].Cells["Kalem Kodu"].Value.ToString();
                kalemTanimi = dtgPaletListesiDetay.Rows[e.RowIndex].Cells["Kalem Tanımı"].Value.ToString();
                miktar = dtgPaletListesiDetay.Rows[e.RowIndex].Cells["Miktar"].Value == DBNull.Value || dtgPaletListesiDetay.Rows[e.RowIndex].Cells["Miktar"].Value.ToString() == "" ? 0 : Convert.ToDouble(dtgPaletListesiDetay.Rows[e.RowIndex].Cells["Miktar"].Value);
                siparisNo = dtgPaletListesiDetay.Rows[e.RowIndex].Cells["SiparisNumarasi"].Value == DBNull.Value || dtgPaletListesiDetay.Rows[e.RowIndex].Cells["SiparisNumarasi"].Value.ToString() == "" ? 0 : Convert.ToInt32(dtgPaletListesiDetay.Rows[e.RowIndex].Cells["Miktar"].Value);
                siparisSatirNo = dtgPaletListesiDetay.Rows[e.RowIndex].Cells["SiparisSatirNo"].Value == DBNull.Value || dtgPaletListesiDetay.Rows[e.RowIndex].Cells["SiparisSatirNo"].Value.ToString() == "" ? 0 : Convert.ToInt32(dtgPaletListesiDetay.Rows[e.RowIndex].Cells["SiparisSatirNo"].Value);

                if (barcode != "")
                {
                    txtBarkod.Text = barcode;
                }
                else if (muhatapkatalogno != "")
                {
                    txtBarkod.Text = muhatapkatalogno;
                }
                else if (kalemKodu != "")
                {
                    txtBarkod.Text = kalemKodu;
                }
                currentRow = e.RowIndex;
            }
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtBarkod.Focus();

                    if (txtBarkod.Text != "")
                    {
                        bool urunbulundu = false;
                        var exits = dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("Barkod") == txtBarkod.Text).ToList();

                        if (exits.Count > 0)
                        {
                            var dtgSira = dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("Barkod") == txtBarkod.Text).Select(x => x.Field<int>("dtgSira")).FirstOrDefault();
                            var arg = new DataGridViewCellEventArgs(dtPaletYapmaListesiDetay.Rows.Count, dtgSira);
                            dtgPaletListesiDetay_CellClick(dtgPaletListesiDetay, arg);

                            dtgPaletListesiDetay.ClearSelection();

                            dtgPaletListesiDetay.Rows[dtgSira].Cells[0].Selected = true;
                            btnDetay.PerformClick();
                            urunbulundu = true;
                        }

                        if (!urunbulundu)
                        {
                            exits = dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("MuhatapKatalogNo") == txtBarkod.Text).ToList();
                            if (exits.Count > 0)
                            {
                                var dtgSira = dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("MuhatapKatalogNo") == txtBarkod.Text).Select(x => x.Field<int>("dtgSira")).FirstOrDefault();
                                var arg = new DataGridViewCellEventArgs(dtPaletYapmaListesiDetay.Rows.Count, dtgSira);
                                dtgPaletListesiDetay_CellClick(dtgPaletListesiDetay, arg);

                                dtgPaletListesiDetay.ClearSelection();

                                dtgPaletListesiDetay.Rows[dtgSira].Cells[0].Selected = true;
                                btnDetay.PerformClick();
                                urunbulundu = true;
                            }
                        }

                        if (!urunbulundu)
                        {
                            exits = dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("Kalem Kodu") == txtBarkod.Text).ToList();
                            if (exits.Count > 0)
                            {
                                var dtgSira = dtPaletYapmaListesiDetay.AsEnumerable().Where(x => x.Field<string>("Kalem Kodu") == txtBarkod.Text).Select(x => x.Field<int>("dtgSira")).FirstOrDefault();
                                var arg = new DataGridViewCellEventArgs(dtPaletYapmaListesiDetay.Rows.Count, dtgSira);
                                dtgPaletListesiDetay_CellClick(dtgPaletListesiDetay, arg);

                                dtgPaletListesiDetay.ClearSelection();

                                dtgPaletListesiDetay.Rows[dtgSira].Cells[0].Selected = true;

                                urunbulundu = true;
                            }
                        }

                        //if (!urunbulundu)
                        //{
                        //    CustomMsgBox.Show("BARKOD BULUNAMADI.", "Uyarı", "Tamam", "");
                        //    txtBarkod.Focus();
                        //    txtBarkod.Select(0, txtBarkod.Text.Length);
                        //    txtBarkod.Text = "";
                        //    return;
                        //}

                        //if (urunbulundu)
                        //{
                        btnDetay.PerformClick();
                        //}
                        //else
                        //{
                        //    CustomMsgBox.Show("BARKOD BULUNAMADI.", "Uyarı", "Tamam", "");
                        //    txtBarkod.Focus();
                        //    txtBarkod.Select(0, txtBarkod.Text.Length);
                        //    return;
                        //}

                        txtBarkod.Text = "";
                    }

                }
            }
            catch (Exception)
            {
            }
        }

        private void dtgPaletListesiDetay_DoubleClick(object sender, EventArgs e)
        {
            var cekmeNo = dtgPaletListesiDetay.Rows[currentRow].Cells["CekmeNo"].Value.ToString();

            if ( cekmeNo != null && cekmeNo.ToString() != "" && cekmeNo != "-1" )
            {
                CustomMsgBox.Show("ÇEKME LİSTESİNDEN EKLENEN BU PALETİN İÇERİĞİ YALNIZCA ÇEKME LİSTESİNDEN DÜZENLENEBİLİR.", "Uyarı", "Tamam", "");
                return;
            }


            doubleclick = true;
            btnDetay.PerformClick();
            doubleclick = false;
        }
        List<SilinecekPaletler> silinecekPaletlers = new List<SilinecekPaletler>();
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                //if (dtgPaletListesiDetay.Rows.Count == 0)
                //{
                //    //ne uyarısı yazılabilir buraya?
                //    CustomMsgBox.Show("ÜRÜN OLMADAN PALET OLUŞTURULAMAZ.", "Uyarı", "Tamam", "");
                //    return;
                //}

                DialogResult dialog = new DialogResult();
                dialog = CustomMsgBtn.Show("BELGE KAYDEDİLECEKTİR.DEVAM ETMEK İSTİYOR MUSUNUZ?", "UYARI", "EVET", "HAYIR");

                if (dialog == DialogResult.No)
                {
                    return;
                }

                PaletYapma paletYapma = new PaletYapma();
                PaletYapmaDetay paletYapmaDetay = new PaletYapmaDetay();
                List<PaletYapmaDetay> paletYapmaDetays = new List<PaletYapmaDetay>();
                AIFTerminalServiceSoapClient aIFTerminalServiceSoapClient1 = new AIFTerminalServiceSoapClient();

                int i = 1;
                paletYapma.PaletNumarasi = txtPaletNo.Text;

                ComboboxItem aa = (ComboboxItem)cmbDurum.SelectedItem;

                paletYapma.Durum = aa.Value.ToString();

                paletYapma.ToplamKap = txtToplamKap.Text == "" ? 0 : Convert.ToDouble(txtToplamKap.Text);
                paletYapma.NetKilo = txtNetKilo.Text == "" ? 0 : Convert.ToDouble(txtNetKilo.Text);
                paletYapma.BrutKilo = txtBrutKilo.Text == "" ? 0 : Convert.ToDouble(txtBrutKilo.Text);
                if (dtgPaletListesiDetay.Rows.Count == 0)
                {
                    paletYapma.Durum = "P";
                }

                foreach (DataRow items in dtPaletYapmaListesiDetay.Rows)
                {

                    //if (items.RowState == DataRowState.Deleted)
                    //{
                    //    continue;
                    //}

                    if (items["Miktar"].ToString() == "0" || items["Miktar"].ToString() == "")
                    {
                        continue;
                    }


                    paletYapmaDetays.Add(new PaletYapmaDetay
                    {
                        Barkod = items["Barkod"].ToString(),
                        MuhatapKatalogNo = items["MuhatapKatalogNo"].ToString(),
                        KalemKodu = items["Kalem Kodu"].ToString(),
                        KalemTanimi = items["Kalem Tanimi"].ToString(),
                        Quantity = Math.Round(Convert.ToDouble(items["Miktar"]), Giris.genelParametreler.OndalikMiktar),
                        SiparisNumarasi = items["SiparisNumarasi"] == DBNull.Value ? -1 : Convert.ToInt32(items["SiparisNumarasi"]),
                        SiparisSatirNo = items["SiparisSatirNo"] == DBNull.Value ? -1 : Convert.ToInt32(items["SiparisSatirNo"]),
                        CekmeNo = items["CekmeNo"] == DBNull.Value ? -1 : Convert.ToInt32(items["CekmeNo"]),
                        Kaynak = items["Kaynak"] == DBNull.Value ? "" : items["Kaynak"].ToString(),
                    });

                    paletYapma.paletYapmaDetays = paletYapmaDetays.ToArray();
                    i++;
                }


                var resp1 = aIFTerminalServiceSoapClient1.addOrUpdatePaletYapmaListesi(Giris._dbName, paletYapma);

                if (resp1.Val == 0)
                {
                    if (silinecekPaletlers.Count > 0)
                    {
                        var resp2 = aIFTerminalServiceSoapClient1.deletePaletListesi(Giris._dbName, silinecekPaletlers.ToArray(), Giris.genelParametreler.CekmeListesiKalemleriniGrupla);

                        if (resp2.Val != 0)
                        {
                            CustomMsgBox.Show(resp2.Desc, "Uyarı", "Tamam", "");
                            return;
                        }
                    }
                    kayitYapildi = true;
                    Close();
                }
                else
                {
                    CustomMsgBox.Show(resp1.Desc, "Uyarı", "Tamam", "");
                }
            }
            catch (Exception ex)
            {
                CustomMsgBox.Show("HATA" + ex.Message, "Uyarı", "Tamam", "");
            }
        }

        private void listAllPrinters()
        {
            cmbPrinter.Items.Clear();
            cmbPrinter.Items.Add("");

            foreach (var item in PrinterSettings.InstalledPrinters)
            {
                cmbPrinter.Items.Add(item);
            }
            //default
            PrintDocument printDocument = new PrintDocument();
            string defaultPrinter = printDocument.PrinterSettings.PrinterName;
            cmbPrinter.SelectedItem = defaultPrinter;

        }


        int yazdirMik = 0;

        private void RafPrint()
        {
            #region Crystal reports işlemlerinin yapıldığı yer

            try
            {
                string path = "";

                if (Giris._dbName == "ZTEST2")
                {
                    path = System.AppDomain.CurrentDomain.BaseDirectory + "ZTest2_Plt_105_70_mm_1.rpt";
                }
                else if (Giris._dbName == "ANATOLYA_DB")
                {
                    path = System.AppDomain.CurrentDomain.BaseDirectory + "Plt_105_70_mm_1.rpt";
                }

                ReportDocument cryRpt = new ReportDocument();

                cryRpt.Load(path);

                string server = @"ANATOLYA-SAP\SAPB1";

                cryRpt.SetDatabaseLogon("sa", "Eropa2018!", server, Giris._dbName);

                cryRpt.VerifyDatabase();

                cryRpt.SetParameterValue(0, txtPaletNo.Text);

                cryRpt.PrintOptions.PrinterName = cmbPrinter.Text;

                //cryRpt.PrintToPrinter(txtPrintMik.Text == "" ? 1 : Convert.ToInt32(txtPrintMik.Text), false, 0, 1);
                cryRpt.PrintToPrinter(1, false, 0, 0);

                cryRpt.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

            #endregion Crystal reports işlemlerinin yapıldığı yer
        }

        private void SevkPrint()
        {
            #region Crystal reports işlemlerinin yapıldığı yer

            try
            {
                string path = "";

                if (Giris._dbName == "ZTEST2")
                {
                    path = System.AppDomain.CurrentDomain.BaseDirectory + "ZTest2_SVK_A4_1.rpt";
                }
                else if (Giris._dbName == "ANATOLYA_DB")
                {
                    path = System.AppDomain.CurrentDomain.BaseDirectory + "SVK_A4_1.rpt";
                }


                //path = System.AppDomain.CurrentDomain.BaseDirectory + "SVK_A4_1.rpt";

                ReportDocument cryRpt = new ReportDocument();

                cryRpt.Load(path);

                string server = @"ANATOLYA-SAP\SAPB1";

                cryRpt.SetDatabaseLogon("sa", "Eropa2018!", server, Giris._dbName);

                cryRpt.VerifyDatabase();

                cryRpt.SetParameterValue(0, txtPaletNo.Text);
                //cryRpt.SetParameterValue(1, "");

                cryRpt.PrintOptions.PrinterName = cmbPrinter.Text;

                //cryRpt.PrintToPrinter(txtPrintMik.Text == "" ? 1 : Convert.ToInt32(txtPrintMik.Text), false, 0, 1);
                cryRpt.PrintToPrinter(1, false, 0, 0);

                cryRpt.Close();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

            #endregion Crystal reports işlemlerinin yapıldığı yer
        }


        private void btnRafEtkYazdir_Click(object sender, EventArgs e)
        {
            RafPrint();
        }


        private void btnSevkEtkYazdir_Click(object sender, EventArgs e)
        {
            SevkPrint();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                dtgPaletListesiDetay.FirstDisplayedScrollingRowIndex = e.NewValue;
            }
            catch (Exception)
            {

            }
        }

        private void dtgPaletListesiDetay_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                vScrollBar1.Value = e.NewValue;
            }
            catch (Exception)
            {
            }
        }

        private void txtNetKilo_Click(object sender, EventArgs e)
        {

        }

        private void txtBrutKilo_Click(object sender, EventArgs e)
        {

        }

        private void nmrcToplamKap_Click(object sender, EventArgs e)
        {

        }

        private void txtToplamKap_Click(object sender, EventArgs e)
        {

        }

        private void txtToplamKap_Click_1(object sender, EventArgs e)
        {
            try
            {
                SayiKlavyesi n = new SayiKlavyesi(txtToplamKap, null, false);
                n.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void txtNetKilo_Click_1(object sender, EventArgs e)
        {
            try
            {
                SayiKlavyesi n = new SayiKlavyesi(txtNetKilo, null, false);
                n.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void txtBrutKilo_Click_1(object sender, EventArgs e)
        {
            try
            {
                SayiKlavyesi n = new SayiKlavyesi(txtBrutKilo, null, false);
                n.ShowDialog();
            }
            catch (Exception)
            {
            }
        }
    }
}
