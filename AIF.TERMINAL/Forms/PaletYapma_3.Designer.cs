
namespace AIF.TERMINAL.Forms
{
    partial class PaletYapma_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.txtPaletNo = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblForm = new System.Windows.Forms.Label();
            this.lblTanim = new System.Windows.Forms.Label();
            this.txtUrunTanim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Controls.Add(this.btnKapat, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblUrunKodu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPaletNo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblArama, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUrunKodu, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblTanim, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUrunTanim, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtQty, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 394);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Gold;
            this.tableLayoutPanel1.SetColumnSpan(this.btnKapat, 6);
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(11, 315);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(380, 33);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "TAMAMLA";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.AutoSize = true;
            this.lblUrunKodu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUrunKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKodu.Location = new System.Drawing.Point(11, 7);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lblUrunKodu.Size = new System.Drawing.Size(95, 27);
            this.lblUrunKodu.TabIndex = 0;
            this.lblUrunKodu.Text = "PALET NO";
            // 
            // txtPaletNo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPaletNo, 5);
            this.txtPaletNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPaletNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPaletNo.Location = new System.Drawing.Point(112, 10);
            this.txtPaletNo.Name = "txtPaletNo";
            this.txtPaletNo.ReadOnly = true;
            this.txtPaletNo.Size = new System.Drawing.Size(279, 20);
            this.txtPaletNo.TabIndex = 2;
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.Location = new System.Drawing.Point(11, 34);
            this.lblArama.Name = "lblArama";
            this.lblArama.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lblArama.Size = new System.Drawing.Size(95, 27);
            this.lblArama.TabIndex = 0;
            this.lblArama.Text = "ÜRÜN KODU";
            // 
            // txtUrunKodu
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtUrunKodu, 5);
            this.txtUrunKodu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrunKodu.Location = new System.Drawing.Point(112, 37);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.ReadOnly = true;
            this.txtUrunKodu.Size = new System.Drawing.Size(279, 20);
            this.txtUrunKodu.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 6);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lblForm, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 354);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(380, 37);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForm.Location = new System.Drawing.Point(79, 5);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(222, 22);
            this.lblForm.TabIndex = 0;
            this.lblForm.Text = "form";
            this.lblForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTanim
            // 
            this.lblTanim.AutoSize = true;
            this.lblTanim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTanim.Location = new System.Drawing.Point(11, 61);
            this.lblTanim.Name = "lblTanim";
            this.lblTanim.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lblTanim.Size = new System.Drawing.Size(95, 27);
            this.lblTanim.TabIndex = 1;
            this.lblTanim.Text = "ÜRÜN TANIM";
            // 
            // txtUrunTanim
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtUrunTanim, 5);
            this.txtUrunTanim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrunTanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunTanim.Location = new System.Drawing.Point(112, 64);
            this.txtUrunTanim.Name = "txtUrunTanim";
            this.txtUrunTanim.ReadOnly = true;
            this.txtUrunTanim.Size = new System.Drawing.Size(279, 20);
            this.txtUrunTanim.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 88);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "MİKTAR";
            // 
            // txtQty
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtQty, 3);
            this.txtQty.DecimalPlaces = 2;
            this.txtQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQty.Location = new System.Drawing.Point(112, 91);
            this.txtQty.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(154, 20);
            this.txtQty.TabIndex = 33;
            this.txtQty.ThousandsSeparator = true;
            this.txtQty.Click += new System.EventHandler(this.txtQty_Click);
            // 
            // PaletYapma_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIF.TERMINAL.Properties.Resources.Arkaplan_gri_jpeg;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PaletYapma_3";
            this.Text = "PALET LİSTESİ MİKTAR";
            this.Load += new System.EventHandler(this.PaletYapma_3_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.Label lblTanim;
        private System.Windows.Forms.TextBox txtPaletNo;
        private System.Windows.Forms.TextBox txtUrunTanim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtQty;
    }
}