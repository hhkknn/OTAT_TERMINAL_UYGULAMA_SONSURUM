﻿namespace AIF.TERMINAL.Forms
{
    partial class SiparisliMalGirisi_3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgParties = new System.Windows.Forms.DataGridView();
            this.btnPartyCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUomCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.btnCollect = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtWhsQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.frmName = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnRowDel = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPartyQty = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPartyBarcode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPartyNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOnOrder = new System.Windows.Forms.NumericUpDown();
            this.txtUnAccepted = new System.Windows.Forms.NumericUpDown();
            this.txtAccepted = new System.Windows.Forms.NumericUpDown();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartyQty)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnAccepted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccepted)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgParties
            // 
            this.dtgParties.AllowUserToAddRows = false;
            this.dtgParties.AllowUserToDeleteRows = false;
            this.dtgParties.AllowUserToResizeRows = false;
            this.dtgParties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgParties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableLayoutPanel1.SetColumnSpan(this.dtgParties, 4);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgParties.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgParties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgParties.EnableHeadersVisualStyles = false;
            this.dtgParties.Location = new System.Drawing.Point(11, 205);
            this.dtgParties.Name = "dtgParties";
            this.dtgParties.ReadOnly = true;
            this.dtgParties.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dtgParties.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgParties.RowTemplate.Height = 40;
            this.dtgParties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgParties.Size = new System.Drawing.Size(361, 104);
            this.dtgParties.TabIndex = 15;
            this.dtgParties.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgParties_CellClick);
            this.dtgParties.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgParties_CellValidated);
            this.dtgParties.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dtgParties_Scroll);
            // 
            // btnPartyCreate
            // 
            this.btnPartyCreate.BackColor = System.Drawing.Color.Gold;
            this.btnPartyCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPartyCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartyCreate.Location = new System.Drawing.Point(3, 3);
            this.btnPartyCreate.Name = "btnPartyCreate";
            this.btnPartyCreate.Size = new System.Drawing.Size(80, 38);
            this.btnPartyCreate.TabIndex = 13;
            this.btnPartyCreate.Text = "OTOMATİK PARTİ OLUŞTUR";
            this.btnPartyCreate.UseVisualStyleBackColor = false;
            this.btnPartyCreate.Click += new System.EventHandler(this.btnPartyCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(213, 53);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "BİRİM";
            // 
            // txtUomCode
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtUomCode, 2);
            this.txtUomCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUomCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUomCode.Location = new System.Drawing.Point(306, 56);
            this.txtUomCode.Name = "txtUomCode";
            this.txtUomCode.ReadOnly = true;
            this.txtUomCode.Size = new System.Drawing.Size(86, 20);
            this.txtUomCode.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 53);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "DEPO MİKTARI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 34);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "ÜRÜN TANIMI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(213, 15);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ÜRÜN KODU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "BARKOD";
            // 
            // txtItemCode
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtItemCode, 2);
            this.txtItemCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtItemCode.Location = new System.Drawing.Point(306, 18);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(86, 20);
            this.txtItemCode.TabIndex = 8;
            // 
            // btnCollect
            // 
            this.btnCollect.BackColor = System.Drawing.Color.Gold;
            this.tableLayoutPanel1.SetColumnSpan(this.btnCollect, 3);
            this.btnCollect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCollect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollect.Location = new System.Drawing.Point(213, 175);
            this.btnCollect.Name = "btnCollect";
            this.tableLayoutPanel1.SetRowSpan(this.btnCollect, 2);
            this.btnCollect.Size = new System.Drawing.Size(179, 24);
            this.btnCollect.TabIndex = 14;
            this.btnCollect.Text = "ÜRÜN TOPLA";
            this.btnCollect.UseVisualStyleBackColor = false;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Controls.Add(this.txtBarCode, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtItemCode, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtItemName, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtWhsQuantity, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUomCode, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.btnComplete, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.dtgParties, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.btnRowDel, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.btnCollect, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtPartyQty, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtPartyBarcode, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtPartyNo, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.vScrollBar1, 5, 14);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 17;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.999798F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999747F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999747F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999747F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.2525125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.9999495F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.999545F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.2525125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.499924F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999747F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999747F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999747F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.999798F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.999798F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.99859F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.999596F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999495F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 394);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarCode.Location = new System.Drawing.Point(116, 18);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.ReadOnly = true;
            this.txtBarCode.Size = new System.Drawing.Size(91, 20);
            this.txtBarCode.TabIndex = 7;
            // 
            // txtItemName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtItemName, 4);
            this.txtItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtItemName.Location = new System.Drawing.Point(116, 37);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(276, 20);
            this.txtItemName.TabIndex = 9;
            // 
            // txtWhsQuantity
            // 
            this.txtWhsQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWhsQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWhsQuantity.Location = new System.Drawing.Point(116, 56);
            this.txtWhsQuantity.Name = "txtWhsQuantity";
            this.txtWhsQuantity.ReadOnly = true;
            this.txtWhsQuantity.Size = new System.Drawing.Size(91, 20);
            this.txtWhsQuantity.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 5);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(11, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(381, 1);
            this.label8.TabIndex = 29;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.frmName, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 346);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(381, 45);
            this.tableLayoutPanel2.TabIndex = 39;
            // 
            // frmName
            // 
            this.frmName.AutoSize = true;
            this.frmName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frmName.Location = new System.Drawing.Point(79, 6);
            this.frmName.Name = "frmName";
            this.frmName.Size = new System.Drawing.Size(222, 27);
            this.frmName.TabIndex = 34;
            this.frmName.Text = "form";
            this.frmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Gold;
            this.tableLayoutPanel1.SetColumnSpan(this.btnComplete, 5);
            this.btnComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(11, 315);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(381, 25);
            this.btnComplete.TabIndex = 22;
            this.btnComplete.Text = "TAMAMLA";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnRowDel
            // 
            this.btnRowDel.BackColor = System.Drawing.Color.Gold;
            this.tableLayoutPanel1.SetColumnSpan(this.btnRowDel, 2);
            this.btnRowDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRowDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRowDel.Location = new System.Drawing.Point(11, 175);
            this.btnRowDel.Name = "btnRowDel";
            this.tableLayoutPanel1.SetRowSpan(this.btnRowDel, 2);
            this.btnRowDel.Size = new System.Drawing.Size(196, 24);
            this.btnRowDel.TabIndex = 40;
            this.btnRowDel.Text = "SATIR SİL";
            this.btnRowDel.UseVisualStyleBackColor = false;
            this.btnRowDel.Click += new System.EventHandler(this.btnRowDel_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(11, 153);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.label14.Size = new System.Drawing.Size(99, 19);
            this.label14.TabIndex = 25;
            this.label14.Text = "MİKTAR";
            // 
            // txtPartyQty
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPartyQty, 2);
            this.txtPartyQty.DecimalPlaces = 2;
            this.txtPartyQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPartyQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPartyQty.Location = new System.Drawing.Point(116, 156);
            this.txtPartyQty.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtPartyQty.Name = "txtPartyQty";
            this.txtPartyQty.Size = new System.Drawing.Size(184, 20);
            this.txtPartyQty.TabIndex = 31;
            this.txtPartyQty.ThousandsSeparator = true;
            this.txtPartyQty.Click += new System.EventHandler(this.txtPartyQty_Click);
            this.txtPartyQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPartyQty_KeyDown);
            this.txtPartyQty.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPartyQty_MouseDown);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnPartyCreate, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(306, 118);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel4, 3);
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(86, 51);
            this.tableLayoutPanel4.TabIndex = 41;
            // 
            // txtPartyBarcode
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPartyBarcode, 2);
            this.txtPartyBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPartyBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPartyBarcode.Location = new System.Drawing.Point(116, 137);
            this.txtPartyBarcode.Name = "txtPartyBarcode";
            this.txtPartyBarcode.Size = new System.Drawing.Size(184, 20);
            this.txtPartyBarcode.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(11, 134);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label13.Size = new System.Drawing.Size(99, 19);
            this.label13.TabIndex = 24;
            this.label13.Text = "PARTİ BARKODU";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(11, 115);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.label12.Size = new System.Drawing.Size(99, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "PARTİ NO";
            // 
            // txtPartyNo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtPartyNo, 2);
            this.txtPartyNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPartyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPartyNo.Location = new System.Drawing.Point(116, 118);
            this.txtPartyNo.Name = "txtPartyNo";
            this.txtPartyNo.Size = new System.Drawing.Size(184, 20);
            this.txtPartyNo.TabIndex = 26;
            this.txtPartyNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPartyNo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 5);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(11, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 1);
            this.label1.TabIndex = 30;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 5);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtOnOrder, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtUnAccepted, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtAccepted, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 78);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(381, 29);
            this.tableLayoutPanel3.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 10);
            this.label7.TabIndex = 6;
            this.label7.Text = "SİPARİŞ EDİLEN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(129, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 10);
            this.label9.TabIndex = 7;
            this.label9.Text = "TOPLANAN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(256, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 10);
            this.label10.TabIndex = 8;
            this.label10.Text = "TOPLANMAYAN";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtOnOrder
            // 
            this.txtOnOrder.DecimalPlaces = 2;
            this.txtOnOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOnOrder.Enabled = false;
            this.txtOnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOnOrder.Location = new System.Drawing.Point(3, 13);
            this.txtOnOrder.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtOnOrder.Name = "txtOnOrder";
            this.txtOnOrder.ReadOnly = true;
            this.txtOnOrder.Size = new System.Drawing.Size(120, 20);
            this.txtOnOrder.TabIndex = 12;
            this.txtOnOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOnOrder.ThousandsSeparator = true;
            // 
            // txtUnAccepted
            // 
            this.txtUnAccepted.DecimalPlaces = 2;
            this.txtUnAccepted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUnAccepted.Enabled = false;
            this.txtUnAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnAccepted.Location = new System.Drawing.Point(256, 13);
            this.txtUnAccepted.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtUnAccepted.Name = "txtUnAccepted";
            this.txtUnAccepted.ReadOnly = true;
            this.txtUnAccepted.Size = new System.Drawing.Size(122, 20);
            this.txtUnAccepted.TabIndex = 13;
            this.txtUnAccepted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnAccepted.ThousandsSeparator = true;
            // 
            // txtAccepted
            // 
            this.txtAccepted.DecimalPlaces = 2;
            this.txtAccepted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAccepted.Enabled = false;
            this.txtAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAccepted.Location = new System.Drawing.Point(129, 13);
            this.txtAccepted.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtAccepted.Name = "txtAccepted";
            this.txtAccepted.ReadOnly = true;
            this.txtAccepted.Size = new System.Drawing.Size(121, 20);
            this.txtAccepted.TabIndex = 14;
            this.txtAccepted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccepted.ThousandsSeparator = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBar1.Location = new System.Drawing.Point(375, 202);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 110);
            this.vScrollBar1.TabIndex = 43;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // SiparisliMalGirisi_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIF.TERMINAL.Properties.Resources.Arkaplan_gri_jpeg;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "SiparisliMalGirisi_3";
            this.Text = "SiparisliMalGirisi_3";
            this.Load += new System.EventHandler(this.SiparisliMalGirisi_3_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtgParties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartyQty)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnAccepted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccepted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgParties;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPartyCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUomCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtWhsQuantity;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPartyNo;
        private System.Windows.Forms.TextBox txtPartyBarcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtPartyQty;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label frmName;
        private System.Windows.Forms.Button btnRowDel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtOnOrder;
        private System.Windows.Forms.NumericUpDown txtUnAccepted;
        private System.Windows.Forms.NumericUpDown txtAccepted;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}