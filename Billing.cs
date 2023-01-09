
using System.Linq;
using FullProgram;
using System.Windows.Forms;
using System;

namespace ChameleonProject
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        MinisterioDeSeguridadEntities db = new MinisterioDeSeguridadEntities();

        private void SelectDates(object sender, DateRangeEventArgs e)
        {
            label1.Text = "";
            IQueryable<LegajosVehiculare> legajos = db.LegajosVehiculares;


            if (cboTipoDocumento.SelectedIndex == 0)
            {
                DateTime fechaInicio = Convert.ToDateTime(monthCalendar.SelectionStart);
                DateTime fechaFin = Convert.ToDateTime(monthCalendar.SelectionEnd);

                legajos = legajos.Where(a => a.FechaCarga >= fechaInicio && a.FechaCarga <= fechaFin);
                label1.Text += "Registros Encontrados: " + legajos.Count();
            }

       



        }
    }
}
