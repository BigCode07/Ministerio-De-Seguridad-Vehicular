namespace ChameleonProject
{
    partial class Add
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
            this.cboTipoDocument = new System.Windows.Forms.GroupBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LegajosDeAfiliados = new System.Windows.Forms.GroupBox();
            this.txtBenefiLA = new System.Windows.Forms.TextBox();
            this.txtBenifiLA = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDniLA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCajaLA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreLA = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvActaDirectorio = new System.Windows.Forms.DataGridView();
            this.CajaAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActaAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResolucionAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.cboTipoDocument.SuspendLayout();
            this.LegajosDeAfiliados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActaDirectorio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTipoDocument
            // 
            this.cboTipoDocument.BackColor = System.Drawing.Color.Cornsilk;
            this.cboTipoDocument.Controls.Add(this.cboTipoDocumento);
            this.cboTipoDocument.Controls.Add(this.label8);
            this.cboTipoDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.cboTipoDocument.Location = new System.Drawing.Point(12, 19);
            this.cboTipoDocument.Name = "cboTipoDocument";
            this.cboTipoDocument.Size = new System.Drawing.Size(514, 71);
            this.cboTipoDocument.TabIndex = 2;
            this.cboTipoDocument.TabStop = false;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "Actas De Asambleas",
            "Actas De Directorios",
            "Legajos Afiliados"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(200, 21);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(247, 26);
            this.cboTipoDocumento.TabIndex = 0;
            this.cboTipoDocumento.TabStop = false;

            this.cboTipoDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DesplaceType);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tipo De Vehiculo:";
            // 
            // LegajosDeAfiliados
            // 
            this.LegajosDeAfiliados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LegajosDeAfiliados.BackColor = System.Drawing.Color.Cornsilk;
            this.LegajosDeAfiliados.Controls.Add(this.txtBenefiLA);
            this.LegajosDeAfiliados.Controls.Add(this.txtBenifiLA);
            this.LegajosDeAfiliados.Controls.Add(this.label14);
            this.LegajosDeAfiliados.Controls.Add(this.label11);
            this.LegajosDeAfiliados.Controls.Add(this.txtDniLA);
            this.LegajosDeAfiliados.Controls.Add(this.label12);
            this.LegajosDeAfiliados.Controls.Add(this.txtCajaLA);
            this.LegajosDeAfiliados.Controls.Add(this.label13);
            this.LegajosDeAfiliados.Controls.Add(this.txtNombreLA);
            this.LegajosDeAfiliados.Controls.Add(this.label15);
            this.LegajosDeAfiliados.Enabled = false;
            this.LegajosDeAfiliados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegajosDeAfiliados.Location = new System.Drawing.Point(12, 96);
            this.LegajosDeAfiliados.Name = "LegajosDeAfiliados";
            this.LegajosDeAfiliados.Size = new System.Drawing.Size(514, 357);
            this.LegajosDeAfiliados.TabIndex = 13;
            this.LegajosDeAfiliados.TabStop = false;
            this.LegajosDeAfiliados.Text = "Datos Legajos De Afiliados";
            this.LegajosDeAfiliados.Visible = false;
            // 
            // txtBenefiLA
            // 
            this.txtBenefiLA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBenefiLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenefiLA.Location = new System.Drawing.Point(200, 223);
            this.txtBenefiLA.Name = "txtBenefiLA";
            this.txtBenefiLA.Size = new System.Drawing.Size(227, 24);
            this.txtBenefiLA.TabIndex = 4;
            this.txtBenefiLA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // txtBenifiLA
            // 
            this.txtBenifiLA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBenifiLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenifiLA.Location = new System.Drawing.Point(200, 189);
            this.txtBenifiLA.Name = "txtBenifiLA";
            this.txtBenifiLA.Size = new System.Drawing.Size(227, 24);
            this.txtBenifiLA.TabIndex = 3;
            this.txtBenifiLA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(55, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 18);
            this.label14.TabIndex = 14;
            this.label14.Text = "Beneficio:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Beneficiario:";
            // 
            // txtDniLA
            // 
            this.txtDniLA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDniLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniLA.Location = new System.Drawing.Point(200, 155);
            this.txtDniLA.Name = "txtDniLA";
            this.txtDniLA.Size = new System.Drawing.Size(227, 24);
            this.txtDniLA.TabIndex = 2;
            this.txtDniLA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(55, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 18);
            this.label12.TabIndex = 10;
            this.label12.Text = "Dni:";
            // 
            // txtCajaLA
            // 
            this.txtCajaLA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCajaLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCajaLA.Location = new System.Drawing.Point(200, 87);
            this.txtCajaLA.Name = "txtCajaLA";
            this.txtCajaLA.Size = new System.Drawing.Size(227, 24);
            this.txtCajaLA.TabIndex = 0;
            this.txtCajaLA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(55, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "Caja:";
            // 
            // txtNombreLA
            // 
            this.txtNombreLA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombreLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLA.Location = new System.Drawing.Point(200, 121);
            this.txtNombreLA.Name = "txtNombreLA";
            this.txtNombreLA.Size = new System.Drawing.Size(227, 24);
            this.txtNombreLA.TabIndex = 1;
            this.txtNombreLA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(55, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Nombre:";
            // 
            // dgvActaDirectorio
            // 
            this.dgvActaDirectorio.AllowUserToAddRows = false;
            this.dgvActaDirectorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActaDirectorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActaDirectorio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvActaDirectorio.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvActaDirectorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActaDirectorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CajaAD,
            this.ActaAD,
            this.ResolucionAD,
            this.FechaAD,
            this.Descripcion});
            this.dgvActaDirectorio.Enabled = false;
            this.dgvActaDirectorio.Location = new System.Drawing.Point(541, 19);
            this.dgvActaDirectorio.Name = "dgvActaDirectorio";
            this.dgvActaDirectorio.Size = new System.Drawing.Size(568, 506);
            this.dgvActaDirectorio.TabIndex = 11;
            this.dgvActaDirectorio.Visible = false;
            // 
            // CajaAD
            // 
            this.CajaAD.HeaderText = "Caja";
            this.CajaAD.Name = "CajaAD";
            this.CajaAD.ReadOnly = true;
            // 
            // ActaAD
            // 
            this.ActaAD.HeaderText = "N°Acta";
            this.ActaAD.Name = "ActaAD";
            this.ActaAD.ReadOnly = true;
            // 
            // ResolucionAD
            // 
            this.ResolucionAD.HeaderText = "Resolucion";
            this.ResolucionAD.Name = "ResolucionAD";
            this.ResolucionAD.ReadOnly = true;
            // 
            // FechaAD
            // 
            this.FechaAD.HeaderText = "Fecha";
            this.FechaAD.Name = "FechaAD";
            this.FechaAD.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.BtnAdd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 459);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(283, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ClearAll);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(24, 16);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(211, 35);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Cargar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.AddData);
            this.BtnAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desplace);
            // 
            // Add
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1121, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboTipoDocument);
            this.Controls.Add(this.dgvActaDirectorio);
            this.Controls.Add(this.LegajosDeAfiliados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add";
            this.Load += new System.EventHandler(this.StartProgram);
            this.cboTipoDocument.ResumeLayout(false);
            this.cboTipoDocument.PerformLayout();
            this.LegajosDeAfiliados.ResumeLayout(false);
            this.LegajosDeAfiliados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActaDirectorio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox cboTipoDocument;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.DataGridView dgvActaDirectorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CajaAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActaAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResolucionAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox LegajosDeAfiliados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDniLA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCajaLA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreLA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBenefiLA;
        private System.Windows.Forms.TextBox txtBenifiLA;
    }
}