namespace ChameleonProject
{
    partial class Digitize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Digitize));
            this.dgvAA = new System.Windows.Forms.DataGridView();
            this.Caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NActa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAsamblea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.panelPatents = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPatents = new System.Windows.Forms.ComboBox();
            this.checkImage = new System.Windows.Forms.CheckBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelChasis = new System.Windows.Forms.Label();
            this.labelMotor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAA)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbData.SuspendLayout();
            this.panelPatents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAA
            // 
            this.dgvAA.AllowUserToAddRows = false;
            this.dgvAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAA.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caja,
            this.NActa,
            this.TipoAsamblea,
            this.FechaCarga});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAA.Enabled = false;
            this.dgvAA.Location = new System.Drawing.Point(12, 402);
            this.dgvAA.Name = "dgvAA";
            this.dgvAA.Size = new System.Drawing.Size(1097, 123);
            this.dgvAA.TabIndex = 6;
            this.dgvAA.TabStop = false;
            // 
            // Caja
            // 
            this.Caja.HeaderText = "Caja";
            this.Caja.Name = "Caja";
            this.Caja.ReadOnly = true;
            // 
            // NActa
            // 
            this.NActa.HeaderText = "N°Acta";
            this.NActa.Name = "NActa";
            this.NActa.ReadOnly = true;
            // 
            // TipoAsamblea
            // 
            this.TipoAsamblea.HeaderText = "Tipo Asamblea";
            this.TipoAsamblea.Name = "TipoAsamblea";
            this.TipoAsamblea.ReadOnly = true;
            // 
            // FechaCarga
            // 
            this.FechaCarga.HeaderText = "FechaCarga";
            this.FechaCarga.Name = "FechaCarga";
            this.FechaCarga.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.BtnAdd);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 56);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(284, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 35);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ClearAll);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(25, 10);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(211, 35);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Cargar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.AddData);
            this.BtnAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // gbData
            // 
            this.gbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbData.BackColor = System.Drawing.Color.Cornsilk;
            this.gbData.Controls.Add(this.panelPatents);
            this.gbData.Controls.Add(this.checkImage);
            this.gbData.Controls.Add(this.txtBox);
            this.gbData.Controls.Add(this.label5);
            this.gbData.Controls.Add(this.txtSubBox);
            this.gbData.Controls.Add(this.label9);
            this.gbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbData.Location = new System.Drawing.Point(12, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(514, 322);
            this.gbData.TabIndex = 33;
            this.gbData.TabStop = false;
            this.gbData.Text = "Datos a Cargar";
            // 
            // panelPatents
            // 
            this.panelPatents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPatents.Controls.Add(this.labelMotor);
            this.panelPatents.Controls.Add(this.labelChasis);
            this.panelPatents.Controls.Add(this.label3);
            this.panelPatents.Controls.Add(this.label2);
            this.panelPatents.Controls.Add(this.label1);
            this.panelPatents.Controls.Add(this.cboPatents);
            this.panelPatents.Location = new System.Drawing.Point(91, 37);
            this.panelPatents.Name = "panelPatents";
            this.panelPatents.Size = new System.Drawing.Size(325, 93);
            this.panelPatents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patente:";
            // 
            // cboPatents
            // 
            this.cboPatents.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboPatents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPatents.FormattingEnabled = true;
            this.cboPatents.Location = new System.Drawing.Point(121, 7);
            this.cboPatents.Name = "cboPatents";
            this.cboPatents.Size = new System.Drawing.Size(135, 28);
            this.cboPatents.TabIndex = 0;
            this.cboPatents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DesplaceToBox);
            this.cboPatents.Leave += new System.EventHandler(this.CallChassis);
            // 
            // checkImage
            // 
            this.checkImage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkImage.AutoSize = true;
            this.checkImage.BackColor = System.Drawing.Color.Transparent;
            this.checkImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkImage.Location = new System.Drawing.Point(230, 252);
            this.checkImage.Name = "checkImage";
            this.checkImage.Size = new System.Drawing.Size(74, 19);
            this.checkImage.TabIndex = 337;
            this.checkImage.TabStop = false;
            this.checkImage.Text = "Interfaz";
            this.checkImage.UseVisualStyleBackColor = false;
            // 
            // txtBox
            // 
            this.txtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBox.Location = new System.Drawing.Point(204, 155);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(201, 26);
            this.txtBox.TabIndex = 1;
            this.txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Caja:";
            // 
            // txtSubBox
            // 
            this.txtSubBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSubBox.Location = new System.Drawing.Point(204, 186);
            this.txtSubBox.Name = "txtSubBox";
            this.txtSubBox.Size = new System.Drawing.Size(201, 26);
            this.txtSubBox.TabIndex = 2;
            this.txtSubBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "SubCaja:";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(532, 12);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(577, 384);
            this.axAcroPDF1.TabIndex = 377;
            this.axAcroPDF1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero Chasis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero Motor:";
            // 
            // labelChasis
            // 
            this.labelChasis.AutoSize = true;
            this.labelChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChasis.Location = new System.Drawing.Point(118, 42);
            this.labelChasis.Name = "labelChasis";
            this.labelChasis.Size = new System.Drawing.Size(0, 16);
            this.labelChasis.TabIndex = 10;
            // 
            // labelMotor
            // 
            this.labelMotor.AutoSize = true;
            this.labelMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotor.Location = new System.Drawing.Point(118, 68);
            this.labelMotor.Name = "labelMotor";
            this.labelMotor.Size = new System.Drawing.Size(0, 16);
            this.labelMotor.TabIndex = 11;
            // 
            // Digitize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1121, 537);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvAA);
            this.Controls.Add(this.gbData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Digitize";
            this.Text = "Digitize";
            this.Load += new System.EventHandler(this.StartProgram);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAA)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.panelPatents.ResumeLayout(false);
            this.panelPatents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.CheckBox checkImage;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelPatents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPatents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn NActa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAsamblea;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCarga;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelChasis;
        private System.Windows.Forms.Label labelMotor;
    }
}