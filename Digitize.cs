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


        MinisterioDeSeguridadEntities db = new MinisterioDeSeguridadEntities();

        public static string usuarioAdd;
        public static object Contador;

        public string OriginChassis { get; private set; }
        public int OriginCar { get; private set; }


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

        private bool Exist()
        {
            int box = Convert.ToInt32(txtBox.Text);
            int subBox = Convert.ToInt32(txtSubBox.Text);
            var exist = db.LegajosVehiculares.SingleOrDefault(a => a.Caja == box && a.SubCaja == subBox && a.IdVehiculo == OriginCar);
            if (exist != null)
            {
                return true;
            }
            else { return false; };
        }


        private void Clear()
        {
            txtBox.Text = txtSubBox.Text = "";
            cboPatents.Focus();
        }

        private void Desplace(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void StartProgram(object sender, EventArgs e)
        {
            CallPatents();
            cboPatents.Focus();
        }

        private void ClearAll(object sender, EventArgs e)
        {

            txtBox.Text = txtSubBox.Text = "";
            cboPatents.SelectedIndex = -1;
            cboPatents.Focus();

        }

        private void AddData(object sender, EventArgs e)
        {
            LegajosVehiculare legajos = new LegajosVehiculare();


            if (txtBox.Text == null && txtSubBox.Text == null && cboPatents.Text == null)
            {
                showMessage("Faltan datos de cargar", 1500);
                cboPatents.Focus();
                return;
            }
            if (!Exist())
            {

                legajos.Caja = Convert.ToInt32(txtBox.Text);
                legajos.SubCaja = Convert.ToInt32(txtSubBox.Text);
                legajos.IdVehiculo = OriginCar;
                legajos.FechaCarga = DateTime.Now;
                legajos.Usuario = "SystemsTesting";
                db.LegajosVehiculares.Add(legajos);
                db.SaveChanges();
                showMessage("Se cargaron los datos", 1000);
                dgvAA.Rows.Add(txtBox.Text, txtSubBox.Text, OriginCar, DateTime.Now);


            }

            else
            {
                MessageBox.Show("Cuidado, ya hay una imagen creada.", "Mensaje de aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (MessageBox.Show("Desea agragarle hojas?, presione SI para continuar y NO para cancelar", "Interfile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            int cant = Scan();
            for (int i = 0; i < cant; i++)
            {
 
            }


            Clear();

        }

        public int Scan()
        {

            int cant = 0;
            string archivo = OriginChassis + ".pdf";
            string ruta = ConfigurationManager.AppSettings["Pictures"];
            comprobarDiretorio(ruta);
            ruta = ruta + @"\" + archivo;
            bool bandera = true;

            showMessage("Escaneando", 500);
            while (bandera)
            {

                if (checkImage.Checked)
                {
                    EZTwain.SetHideUI(false);
                }
                else
                {
                    EZTwain.SetHideUI(true);
                }

                // EZTwain.SetHideUI(true);
                EZTwain.SetJpegQuality(75);
                if (EZTwain.OpenDefaultSource())
                {

                    EZTwain.EnableDuplex(true);
                    EZTwain.SetBlankPageMode(1);
                    EZTwain.SelectFeeder(true);
                    EZTwain.SetBlankPageThreshold(0.005);
                    EZTwain.SetFileAppendFlag(true);
                    EZTwain.SetPixelType(0);
                    EZTwain.SetResolution(200);
                    // If you can't get a Window handle, use IntPtr.Zero:
                    EZTwain.AcquireMultipageFile(this.Handle, ruta);
                    cant += EZTwain.MultipageCount();


                }
                if (EZTwain.LastErrorCode() != 0)
                {
                    EZTwain.ReportLastError("Unable to scan.");
                }

                agregar(ruta);

                if (MessageBox.Show("Desea agregar otra hoja a este Lote?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    txtBox.Focus();
                    bandera = false;

                }

            }
            int box = Convert.ToInt32(txtBox.Text);
            int subBox = Convert.ToInt32(txtSubBox.Text);
            var update = db.LegajosVehiculares.SingleOrDefault(a => a.Caja == box && a.SubCaja == subBox && a.IdVehiculo == OriginCar);
            update.Imagen = archivo;
            db.SaveChanges();

            showMessage("Se actualizaron los datos del registro", 1000);
            return cant;
        }

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

        private void CallChassis(object sender, EventArgs e)
        {
            if (cboPatents.Text != "")
            {

                string patents = cboPatents.Text;
                var IdVehiculo = db.Vehiculos.Where(l => l.ChapaPatente == patents).Select(l => l.Id).SingleOrDefault();
                var chassis = db.Vehiculos.Where(l => l.ChapaPatente == patents).Select(l => l.NumeroChasis).SingleOrDefault();
                var motor = db.Vehiculos.Where(l => l.ChapaPatente == patents).Select(l => l.NumeroMotor).SingleOrDefault();
                if (chassis != null) { OriginChassis = chassis; OriginCar = IdVehiculo; labelChasis.Text = chassis; labelMotor.Text = motor; }
                else { return; }

            }
        }

        private void DesplaceToBox(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
