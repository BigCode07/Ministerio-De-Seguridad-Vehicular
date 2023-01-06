

using FullProgram;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace ChameleonProject
{
    public partial class Add : Form
    {


        MinisterioDeSeguridadEntities db = new MinisterioDeSeguridadEntities();


        public Add()
        {
            InitializeComponent();
        }



        public static string usuarioAdd;
        public static object Contador;

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

        private bool Exist()
        {

            int TipoAsamblea = Convert.ToInt32(cboTipoAsamblea.SelectedValue);
            DateTime fecha = Convert.ToDateTime(mskFecha.Text);

            var existe = db.ActasDeAsambleas.SingleOrDefault(a => a.NumeroActa == txtActa.Text && a.Fecha == fecha && a.IdTipoAsamblea == TipoAsamblea);
            if (existe != null)
            {
                return true;
            }
            else { return false; };

        }


        private void TypeActas()
        {
            //var type = db.TiposActasDeAsambleas.ToList();

            //if (type.Count() > 0)
            //{
            //    cboTipoAsamblea.DataSource = type;
            //    cboTipoAsamblea.DisplayMember = "Nombre";
            //    cboTipoAsamblea.ValueMember = "Id";
            //    cboTipoAsamblea.SelectedIndex = -1;
            //}
        }

     
        private void AddData(object sender, EventArgs e)
        {


                if (txtCaja.Text == "" && mskFecha.Text == "" && txtActa.Text == "" && cboTipoAsamblea.Text == "")
                {
                    showMessage("Faltan datos de cargar", 1500);
                    txtCaja.Focus();
                    return;
                }
                //if (!Exist())
                //{

                //    //acta.Caja = Convert.ToInt32(txtCaja.Text);
                //    //acta.NumeroActa = txtActa.Text;
                //    //acta.IdTipoAsamblea = Convert.ToInt32(cboTipoAsamblea.SelectedValue);
                //    //acta.Fecha = Convert.ToDateTime(mskFecha.Text);
                //    //acta.Usuario = usuarioAdd;
                //    //acta.FechaCarga = DateTime.Now;
                //    //db.ActasDeAsambleas.Add(acta);
                //    //db.SaveChanges();
                //    //showMessage("Se cargaron los datos", 1000);
                //    //dgvActasAsambleas.Rows.Add(txtCaja.Text, txtActa.Text, cboTipoAsamblea.Text, mskFecha.Text);
                //}
                //else if (Exist())
                //{
                //    showMessage("Ya existe un Registro.", 1000);
                //}
         
            Clear();
        }

        private void Clear()
        {
            if (cboTipoDocumento.SelectedIndex == 0)
            {
                txtActa.Text = mskFecha.Text = "";
                cboTipoAsamblea.SelectedIndex = -1;
                txtActa.Focus();
            }
         
        }

        private void Desplace(object sender, KeyPressEventArgs e)
        {

            if (cboTipoDocumento.SelectedIndex == 0)
            {
                if (e.KeyChar == (char)(Keys.Enter))
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");

                }
            }

            else if (cboTipoDocumento.SelectedIndex == 1)
            {
                if (e.KeyChar == (char)(Keys.Enter))
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
            }

            else if (cboTipoDocumento.SelectedIndex == 2)
            {
                if (e.KeyChar == (char)(Keys.Enter))
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
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

        private void StartProgram(object sender, EventArgs e)
        {
            TypeActas();
        }

        private void ClearAll(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == 0)
            {
                txtCaja.Text = txtActa.Text = mskFecha.Text = "";
                cboTipoAsamblea.SelectedIndex = -1;
                txtCaja.Focus();
            }
            else if (cboTipoDocumento.SelectedIndex == 1)
            {
                txtCajaAD.Text = txtActaAD.Text = txtDescripcionAD.Text = txtResolucionAD.Text = mskFechaAD.Text = "";
                txtCajaAD.Focus();
            }
            else if (cboTipoDocumento.SelectedIndex == 2)
            {
                txtCajaLA.Text = txtNombreLA.Text = txtDniLA.Text = txtBenifiLA.Text = txtBenefiLA.Text = txtNLegajo.Text = mskFCeseLA.Text = mskFIngresoLA.Text = mskFJubilacionLA.Text = "";
                txtCajaLA.Focus();
            }
        }



    }
}
