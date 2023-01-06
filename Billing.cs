
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

    

        private void SelectDates(object sender, DateRangeEventArgs e)
        {
            label1.Text = "";
            //IQueryable<ActasDeAsambleas> actasDeAsambleas = db.ActasDeAsambleas;


            if (cboTipoDocumento.SelectedIndex == 0)
            {
                //DateTime fechaInicio = Convert.ToDateTime(monthCalendar.SelectionStart);
                //DateTime fechaFin = Convert.ToDateTime(monthCalendar.SelectionEnd);

                //actasDeAsambleas = actasDeAsambleas.Where(a => a.FechaCarga >= fechaInicio && a.FechaCarga <= fechaFin);
                //label1.Text += "Registros Encontrados: " + actasDeAsambleas.Count();
            }

       



        }
    }
}
