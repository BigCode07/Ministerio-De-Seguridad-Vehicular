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
            if (patents.Count() > 0)
            {
                cboPatents.DataSource = patents;
                cboPatents.DisplayMember = "ChapaPatente";
                cboPatents.ValueMember = "Id";
                cboPatents.SelectedIndex = -1;
            }
            else { return; }
        }
        private void QueryData(object sender, EventArgs e)
        {


            dgv.Rows.Clear();

            IQueryable<LegajosVehiculare> legajos = db.LegajosVehiculares;
            IQueryable<Vehiculo> vehiculos = db.Vehiculos;

            if (cboPatents.Text != "")
            {
                vehiculos = vehiculos.Where(v => v.ChapaPatente == cboPatents.Text);
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


            //    if (mskFecha.MaskCompleted == true)
            //    {
            //        DateTime fecha = Convert.ToDateTime(mskFecha.Text);
            //        actas = actas.Where(a => a.Fecha == fecha);
            //    }

            //    if (cboTipoAsamblea.Text != "")
            //    {
            //        int type = Convert.ToInt32(cboTipoAsamblea.SelectedValue);
            //        actas = actas.Where(a => a.IdTipoAsamblea == type);
            //    }

            //    if (txtUsuario.Text != "")
            //    {
            //        actas = actas.Where(a => a.Usuario == txtUsuario.Text);
            //    }


            //    if (mskFCarga.MaskCompleted == true)
            //    {
            //        DateTime fecha = Convert.ToDateTime(mskFecha.Text);
            //        actas = actas.Where(a => a.Fecha == fecha);
            //    }

            if (actas.Count() > 0)
            {

                foreach (var le in actas.ToList())
                {
                    dgvActaDeAsamblea.Rows.Add(le.Id, le.Caja, le.NumeroActa, le.IdTipoAsamblea, le.Fecha, le.Imagen, le.Usuario, le.FechaCarga);
                }
            }
            //    else
            //    {
            //        showMessage("No hay registros", 1500);
            //    }
            //}




        }

        private void UpdateData()
        {

            //if (cboTipoDocumento.SelectedIndex == 0)
            //{
            //    dgvActaDeAsamblea.Rows.Clear();

            //    IQueryable<ActasDeAsambleas> actas = db.ActasDeAsambleas;



            //    if (txtCaja.Text != "")
            //    {
            //        int caja = Convert.ToInt32(txtCaja.Text);
            //        actas = actas.Where(a => a.Caja == caja);
            //    }

            //    if (txtActa.Text != "")
            //    {
            //        actas = actas.Where(a => a.NumeroActa == txtActa.Text);
            //    }

            //    if (mskFecha.MaskCompleted == true)
            //    {
            //        DateTime fecha = Convert.ToDateTime(mskFecha.Text);
            //        actas = actas.Where(a => a.Fecha == fecha);
            //    }

            //    if (cboTipoAsamblea.Text != "")
            //    {
            //        int type = Convert.ToInt32(cboTipoAsamblea.SelectedValue);
            //        actas = actas.Where(a => a.IdTipoAsamblea == type);
            //    }


            //    if (mskFCarga.MaskCompleted == true)
            //    {
            //        DateTime fecha = Convert.ToDateTime(mskFecha.Text);
            //        actas = actas.Where(a => a.Fecha == fecha);
            //    }


            //    if (actas.Count() > 0)
            //    {

            //        foreach (var le in actas.ToList())
            //        {
            //            dgvActaDeAsamblea.Rows.Add(le.Id, le.Caja, le.NumeroActa, le.IdTipoAsamblea, le.Fecha, le.Imagen, le.Usuario, le.FechaCarga);
            //        }


            //    }
            //    else
            //    {
            //        showMessage("No hay registros", 1500);
            //    }
            //}


        }

        private void CallDgv(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                //if (MessageBox.Show("Seguro desea Eliminar este Registro?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                //{
                //    try
                //    {
                //        var reg = db.ActasDeAsambleas.Find(dgvActaDeAsamblea.CurrentRow.Cells[0].Value);
                //        db.ActasDeAsambleas.Remove(reg);
                //        db.SaveChanges();
                //        showMessage("Registro Eliminado", 1250);
                //        UpdateData();

                //    }
                //    catch { MessageBox.Show("Error en la operacion, verifique o complete datos faltantes"); }
                //}

            }


            if (dgv.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                //if (MessageBox.Show("Seguro desea modificar este registro?", "Modificar?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                //{
                //    try
                //    {
                //        var hc = db.ActasDeAsambleas.Find(dgvActaDeAsamblea.CurrentRow.Cells[0].Value);

                //        if (dgvActaDeAsamblea.CurrentRow.Cells[1].Value != null)
                //        {
                //            hc.Caja = Convert.ToInt32(dgvActaDeAsamblea.CurrentRow.Cells[1].Value);
                //        }

                //        if (dgvActaDeAsamblea.CurrentRow.Cells[2].Value != null)
                //        {
                //            hc.NumeroActa = dgvActaDeAsamblea.CurrentRow.Cells[2].Value.ToString();
                //        }
                //        if (dgvActaDeAsamblea.CurrentRow.Cells[3].Value != null)
                //        {
                //            hc.IdTipoAsamblea = Convert.ToInt32(dgvActaDeAsamblea.CurrentRow.Cells[3].Value.ToString());
                //        }
                //        if (dgvActaDeAsamblea.CurrentRow.Cells[4].Value != null)
                //        {
                //            hc.Fecha = Convert.ToDateTime(dgvActaDeAsamblea.CurrentRow.Cells[4].Value.ToString());
                //        }

                //        if (dgvActaDeAsamblea.CurrentRow.Cells[5].Value != null)
                //        {
                //            hc.Imagen = dgvActaDeAsamblea.CurrentRow.Cells[5].Value.ToString();
                //        }

                //        db.SaveChanges();
                //        showMessage("Registro Modificado", 1000);
                //        UpdateData();

                //    }
                //    catch { MessageBox.Show("Error en la operacion, verifique o complete datos faltantes"); }
                //}
            }
        }

        private void CallImage(object sender, DataGridViewCellEventArgs e)
        {
            //axAcroPDF1.src = ConfigurationManager.AppSettings["ImagenesActaDeAsamblea"] + "\\" + dgvActaDeAsamblea.CurrentRow.Cells["Imagen"].Value.ToString();
            //axAcroPDF1.src = ConfigurationManager.AppSettings["ImagenesActaDeDirectorio"] + "\\" + dgvAD.CurrentRow.Cells["ImagenAD"].Value.ToString();
            //axAcroPDF1.src = ConfigurationManager.AppSettings["ImagenesLegajosAfiliados"] + "\\" + dgvAD.CurrentRow.Cells["ImagenLA"].Value.ToString();
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

        private void SelectedItems(object sender, EventArgs e)
        {
            //if (cboTipoDocumento.SelectedIndex == 1)
            //{
            //    DatosActaDeDirectorio.Visible = true;
            //    DatosActaDeDirectorio.Enabled = true;
            //    dgvAD.Visible = true;
            //    dgvAD.Enabled = true;

            //    DatosActaDeAsamblea.Visible = false;
            //    DatosActaDeAsamblea.Enabled = false;
            //    dgvActaDeAsamblea.Visible = false;
            //    dgvActaDeAsamblea.Enabled = false;

            //    gbLA.Visible = false;
            //    gbLA.Enabled = false;
            //    dgvLA.Visible = false;
            //    dgvLA.Enabled = false;
            //}
          
        }

        private void AllClear(object sender, EventArgs e)
        {

                //txtCaja.Text = txtActa.Text = mskFecha.Text = mskFCarga.Text = txtUsuario.Text = "";
                //cboTipoAsamblea.SelectedIndex = -1;
                //dgv.Rows.Clear();
                //txtCaja.Focus();
        
         
        }
    }
}
