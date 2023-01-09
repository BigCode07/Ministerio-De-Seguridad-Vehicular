using FullProgram;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace ChameleonProject
{
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        MinisterioDeSeguridadEntities db = new MinisterioDeSeguridadEntities();

        private void showMessage(string msg, int duration)
        {
            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = duration;
                time.Tick += timeTick;  /* Evento enlazado */

                time.Start();

                /* Muestras el texto en el MB */
                MessageBox.Show(msg);
            }
        }

        private void timeTick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();  /* Detiene el Timer */
            SendKeys.Send("{ESC}"); /* Hace la simulación de la tecla Escape, también puedes usar {ENTER} */
        }

        private void CallPatents()
        {
            var patents = db.Vehiculos.ToList();

            cboPatents.DataSource = patents;
            cboPatents.DisplayMember = "ChapaPatente";
            cboPatents.ValueMember = "Id";


        }

        //private void CallCbo()
        //{
        //    var typeVehicle = db.TipoMovils.ToList();
        //    var Brand = db.Marcas.ToList();
        //    TipoMovilDgv.DataSource = typeVehicle;
        //    TipoMovilDgv.DisplayMember = "Nombre";
        //    TipoMovilDgv.ValueMember = "Id";
        //    MarcaDgv.DataSource = Brand;
        //    MarcaDgv.DisplayMember = "Nombre";
        //    MarcaDgv.ValueMember = "Id";
        //}

        private void QueryData(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            dgv.Rows.Clear();
            int Patent = Convert.ToInt32(cboPatents.SelectedValue);

            IQueryable<LegajosVehiculare> legajos = db.LegajosVehiculares;

            if (cboPatents.Text != "")
            {
                legajos = legajos.Where(v => v.IdVehiculo == Patent);
            }

            if (txtBox.Text != "")
            {
                int box = Convert.ToInt32(txtBox.Text);
                legajos = legajos.Where(a => a.Caja == box);
            }

            if (txtSubBox.Text != "")
            {
                int subbox = Convert.ToInt32(txtSubBox.Text);
                legajos = legajos.Where(a => a.SubCaja == subbox);
            }


            if (mskDate.MaskCompleted == true)
            {
                DateTime fecha = Convert.ToDateTime(mskDate.Text);
                legajos = legajos.Where(a => a.FechaCarga == fecha);
            }

            if (txtUser.Text != "")
            {
                legajos = legajos.Where(a => a.Usuario == txtUser.Text);
            }

            if (legajos.Count() > 0)
            {

                foreach (var le in legajos.ToList())
                {
                    dgv.Rows.Add(le.Id, le.Caja, le.SubCaja, le.Vehiculo.TipoMovil.Nombre, le.Vehiculo.Marca.Nombre, le.Vehiculo.ChapaPatente, le.Vehiculo.NumeroChasis, le.Vehiculo.NumeroMotor, le.Imagen, le.Usuario, le.FechaCarga);
                }
            }
            else
            {
                showMessage("No hay registros", 1500);
            }
        }

        private void CallDgv(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MessageBox.Show("Seguro desea Eliminar este Registro?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        var reg = db.LegajosVehiculares.Find(dgv.CurrentRow.Cells[0].Value);
                        db.LegajosVehiculares.Remove(reg);
                        db.SaveChanges();
                        showMessage("Registro Eliminado", 1250);
                        UpdateData();

                    }
                    catch { MessageBox.Show("Error en la operacion, verifique o complete datos faltantes"); }
                }

            }


            if (dgv.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                if (MessageBox.Show("Seguro desea modificar este registro?", "Modificar?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        var hc = db.LegajosVehiculares.Find(dgv.CurrentRow.Cells[0].Value);

                        if (dgv.CurrentRow.Cells[1].Value != null)
                        {
                            hc.Caja = Convert.ToInt32(dgv.CurrentRow.Cells[1].Value);
                        }

                        if (dgv.CurrentRow.Cells[2].Value != null)
                        {
                            hc.SubCaja = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value);
                        }
                        if (dgv.CurrentRow.Cells[8].Value != null)
                        {
                            hc.Imagen = dgv.CurrentRow.Cells[8].Value.ToString();
                        }
                     

                        db.SaveChanges();
                        showMessage("Registro Modificado", 1000);
                        UpdateData();

                    }
                    catch { MessageBox.Show("Error en la operacion, verifique o complete datos faltantes"); }
                }
            }
        }

        private void CallImage(object sender, DataGridViewCellEventArgs e)
        {

            axAcroPDF1.src = ConfigurationManager.AppSettings["Pictures"] + "\\" + dgv.CurrentRow.Cells["Imagen"].Value.ToString();
        }

        private void Desplace(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void DesplaceType(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void AllClear(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            cboPatents.SelectedIndex = -1;
            txtBox.Text = txtSubBox.Text = txtUser.Text = mskDate.Text = "";
            cboPatents.Focus();

        }

        private void StartProgram(object sender, EventArgs e)
        {
            cboPatents.Focus();
            CallPatents();

            cboPatents.SelectedIndex = -1;
        }
    }
}
