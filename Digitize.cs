using System;
using System.Linq;
using FullProgram;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using WindowsApplication1;

namespace ChameleonProject
{
    public partial class Digitize : Form
    {
        public Digitize()
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

        private void SelectedItem(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == 1)
            {
                gbAD.Visible = true;
                gbAD.Enabled = true;
                dgvAD.Visible = true;
                dgvAD.Enabled = true;

                DatosActaDeAsamblea.Visible = false;
                DatosActaDeAsamblea.Enabled = false;
                dgvAA.Visible = false;
                dgvAA.Enabled = false;

                gbLegajosAfiliados.Visible = false;
                gbLegajosAfiliados.Enabled = false;
                dgvLA.Visible = false;
                dgvLA.Enabled = false;
            }

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

        //private bool Exist()
        //{

        //    //int TipoAsamblea = Convert.ToInt32(cboTipoAsamblea.SelectedValue);
        //    //DateTime fecha = Convert.ToDateTime(mskFecha.Text);

        //    //var existe = db.ActasDeAsambleas.SingleOrDefault(a => a.NumeroActa == txtActa.Text && a.Fecha == fecha && a.IdTipoAsamblea == TipoAsamblea);
        //    //if (existe != null)
        //    //{
        //    //    return true;
        //    //}
        //    //else { return false; };

        //}


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

        private void StartProgram(object sender, EventArgs e)
        {
            TypeActas();
        }

        private void ClearAll(object sender, EventArgs e)
        {

            txtCaja.Text = txtActa.Text = mskFecha.Text = "";
            cboTipoAsamblea.SelectedIndex = -1;
            txtCaja.Focus();

        }

        private void AddData(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == 0)
            {

                //if (txtCaja.Text == "" && mskFecha.Text == "" && txtActa.Text == "" && cboTipoAsamblea.Text == "")
                //{
                //    showMessage("Faltan datos de cargar", 1500);
                //    txtCaja.Focus();
                //    return;
                //}
                //if (!Exist())
                //{

                //    actas.Caja = Convert.ToInt32(txtCaja.Text);
                //    actas.NumeroActa = txtActa.Text;
                //    actas.IdTipoAsamblea = Convert.ToInt32(cboTipoAsamblea.SelectedValue);
                //    actas.Fecha = Convert.ToDateTime(mskFecha.Text);
                //    actas.FechaCarga = DateTime.Now;
                //    actas.Usuario = usuarioAdd;
                //    db.ActasDeAsambleas.Add(actas);
                //    db.SaveChanges();
                //    showMessage("Se cargaron los datos", 1000);
                //    dgvAA.Rows.Add(txtCaja.Text, txtActa.Text, cboTipoAsamblea.Text, mskFecha.Text);


            }

            else
            {
                MessageBox.Show("Cuidado, ya hay una imagen creada.", "Mensaje de aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (MessageBox.Show("Desea agragarle hojas?, presione SI para continuar y NO para cancelar", "Interfile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            //int cant = ScanAA();
            //for (int i = 0; i < cant; i++)
            //{
            //    Contador.ToString();
            //}




            Clear();

        }

        //private int Scan()
        //{

        //    int cant = 0;
        //    string archivo = txtActa.Text + "-" + cboTipoAsamblea.Text + ".pdf";
        //    string ruta = ConfigurationManager.AppSettings["ImagenesActaDeAsamblea"];
        //    comprobarDiretorio(ruta);
        //    ruta = ruta + @"\" + archivo;
        //    bool bandera = true;

        //    showMessage("Escaneando", 500);
        //    while (bandera)
        //    {

        //        if (checkAA.Checked)
        //        {
        //            EZTwain.SetHideUI(false);
        //        }
        //        else
        //        {
        //            EZTwain.SetHideUI(true);
        //        }

        //        // EZTwain.SetHideUI(true);
        //        EZTwain.SetJpegQuality(75);
        //        if (EZTwain.OpenDefaultSource())
        //        {

        //            EZTwain.EnableDuplex(true);
        //            EZTwain.SetBlankPageMode(1);
        //            EZTwain.SelectFeeder(true);
        //            EZTwain.SetBlankPageThreshold(0.005);
        //            EZTwain.SetFileAppendFlag(true);
        //            EZTwain.SetPixelType(0);
        //            EZTwain.SetResolution(200);
        //            // If you can't get a Window handle, use IntPtr.Zero:
        //            EZTwain.AcquireMultipageFile(this.Handle, ruta);
        //            cant += EZTwain.MultipageCount();


        //        }
        //        if (EZTwain.LastErrorCode() != 0)
        //        {
        //            EZTwain.ReportLastError("Unable to scan.");
        //        }

        //        agregar(ruta);

        //        if (MessageBox.Show("Desea agregar otra hoja a este Lote?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
        //        {
        //            txtCaja.Focus();
        //            bandera = false;

        //        }
        //    }

        //    //int TipoAsamblea = Convert.ToInt32(cboTipoAsamblea.SelectedValue);
        //    //DateTime fecha = Convert.ToDateTime(mskFecha.Text);
        //    //var update = db.ActasDeAsambleas.SingleOrDefault(a => a.NumeroActa == txtActa.Text && a.Fecha == fecha && a.IdTipoAsamblea == TipoAsamblea);

        //    //update.Imagen = archivo;
        //    //db.SaveChanges();

        //    //showMessage("Se actualizaron los datos del registro", 1000);
        //    //return cant;
        //}

       

        private void agregar(string nombre)
        {

            axAcroPDF1.LoadFile(nombre);
            axAcroPDF1.Show();

        }

        private void comprobarDiretorio(string dire)
        {
            DirectoryInfo DIR = new DirectoryInfo(dire);

            if (!DIR.Exists)
            {
                DIR.Create();
            }

        }
    }
}
