namespace ChameleonProject
{
    partial class Query
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPatents = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMovilDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chasis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroMotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(291, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 31);
            this.btnClear.TabIndex = 9;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.AllClear);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(70, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 31);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.QueryData);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Caja,
            this.SubCaja,
            this.TipoMovilDgv,
            this.MarcaDgv,
            this.Patente,
            this.Chasis,
            this.NumeroMotor,
            this.Imagen,
            this.Usuario,
            this.FechaCarga,
            this.Modificar,
            this.Eliminar});
            this.dgv.Location = new System.Drawing.Point(12, 370);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1097, 139);
            this.dgv.TabIndex = 366;
            this.dgv.TabStop = false;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CallDgv);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 37);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(532, 20);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(577, 344);
            this.axAcroPDF1.TabIndex = 383;
            this.axAcroPDF1.TabStop = false;
            // 
            // gbData
            // 
            this.gbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbData.BackColor = System.Drawing.Color.Cornsilk;
            this.gbData.Controls.Add(this.mskDate);
            this.gbData.Controls.Add(this.label4);
            this.gbData.Controls.Add(this.cboPatents);
            this.gbData.Controls.Add(this.label3);
            this.gbData.Controls.Add(this.txtUser);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.txtBox);
            this.gbData.Controls.Add(this.label5);
            this.gbData.Controls.Add(this.txtSubBox);
            this.gbData.Controls.Add(this.label9);
            this.gbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbData.Location = new System.Drawing.Point(12, 20);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(514, 301);
            this.gbData.TabIndex = 384;
            this.gbData.TabStop = false;
            this.gbData.Text = "Datos a Consultar";
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(219, 200);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(201, 26);
            this.mskDate.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Patente:";
            // 
            // cboPatents
            // 
            this.cboPatents.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboPatents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPatents.FormattingEnabled = true;
            this.cboPatents.Location = new System.Drawing.Point(219, 71);
            this.cboPatents.Name = "cboPatents";
            this.cboPatents.Size = new System.Drawing.Size(201, 28);
            this.cboPatents.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha Carga:";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUser.Location = new System.Drawing.Point(219, 168);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(201, 26);
            this.txtUser.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario:";
            // 
            // txtBox
            // 
            this.txtBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBox.Location = new System.Drawing.Point(219, 105);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(201, 26);
            this.txtBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Caja:";
            // 
            // txtSubBox
            // 
            this.txtSubBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSubBox.Location = new System.Drawing.Point(219, 136);
            this.txtSubBox.Name = "txtSubBox";
            this.txtSubBox.Size = new System.Drawing.Size(201, 26);
            this.txtSubBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "SubCaja:";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Caja
            // 
            this.Caja.HeaderText = "Caja";
            this.Caja.Name = "Caja";
            // 
            // SubCaja
            // 
            this.SubCaja.HeaderText = "Sub Caja";
            this.SubCaja.Name = "SubCaja";
            // 
            // TipoMovilDgv
            // 
            this.TipoMovilDgv.HeaderText = "Tipo Movil";
            this.TipoMovilDgv.Name = "TipoMovilDgv";
            this.TipoMovilDgv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MarcaDgv
            // 
            this.MarcaDgv.HeaderText = "Marca";
            this.MarcaDgv.Name = "MarcaDgv";
            this.MarcaDgv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            // 
            // Chasis
            // 
            this.Chasis.HeaderText = "Nro Chasis";
            this.Chasis.Name = "Chasis";
            // 
            // NumeroMotor
            // 
            this.NumeroMotor.HeaderText = "Nro Motor";
            this.NumeroMotor.Name = "NumeroMotor";
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // FechaCarga
            // 
            this.FechaCarga.HeaderText = "Fecha Carga";
            this.FechaCarga.Name = "FechaCarga";
            this.FechaCarga.ReadOnly = true;
            // 
            // Modificar
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.Modificar.DefaultCellStyle = dataGridViewCellStyle11;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "Modificar";
            this.Modificar.ToolTipText = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle12;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.ToolTipText = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // Query
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1121, 537);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Query";
            this.Text = "<e";
            this.Load += new System.EventHandler(this.StartProgram);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPatents;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMovilDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chasis;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroMotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCarga;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}