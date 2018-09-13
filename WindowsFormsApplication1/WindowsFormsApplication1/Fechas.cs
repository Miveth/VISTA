using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Fechas : Form
    {
        public Fechas()
        {
            InitializeComponent();
        }

        private void Fechas_Load(object sender, EventArgs e)
        {

            //contardor para mi, solo para ver configuraciones de cambio en un mismo form
            int cont = 2;

            //declarar un nuevo form
            // Form Form1 = new Form();
            //size del form x, y, ancho y alto
            this.SetBounds(0, 300, 300, 400);
            //Nombre de encabezado del form
            this.Text = "Fechas";

            if(cont == 0) { 
                //crear nuevo panel
                Panel p1 = new Panel();
                //ubicacion del panel1
                p1.SetBounds(0, 0, 300, 200);
                //crear nuevo label de texto
                Label text1 = new Label();
                //texto que contendra el label
                text1.Text = "¿Eres mayor de edad?";
                //ubicacion del label x, y, ancho y alto
                text1.SetBounds(10, 20, 200, 50);
                //agregar text1 al panel 1
                p1.Controls.Add(text1);

                Panel p2 = new Panel();
                p2.SetBounds(0, 60, 300, 100);
                Button si = new Button();
                si.SetBounds(100, 10, 40, 40);
                si.Text = "SI";
                si.Click += new EventHandler(clickBotton1);
                p2.Controls.Add(si);
                Button no = new Button();
                no.SetBounds(160, 10, 40, 40);
                no.Text = "NO";
                no.Click += new EventHandler(clickBotton1);
                p2.Controls.Add(no);

                this.Controls.Add(p2);
                this.Controls.Add(p1);

            }
            else if(cont ==1 )
            {

                //crear nuevo panel
                Panel p1 = new Panel();
                //ubicacion del panel1
                p1.SetBounds(0, 0, 300, 200);
                //crear nuevo label de texto
                Label text1 = new Label();
                //texto que contendra el label
                text1.Text = "¿Dime la fecha?";
                //ubicacion del label x, y, ancho y alto
                text1.SetBounds(10, 20, 200, 50);
                //agregar text1 al panel 1
                p1.Controls.Add(text1);

                Panel p2 = new Panel();
                p2.SetBounds(0, 60, 300, 300);

                DateTimePicker Date = new DateTimePicker();
                Date.Format = DateTimePickerFormat.Custom;
                //Date.ShowUpDown = true;
                Date.Location = new Point(100, 0);
                Date.Width = 100;
                p2.Controls.Add(Date);
                
                this.Controls.Add(p2);
                this.Controls.Add(p1);

            }

            else if (cont == 2)
            {

                //crear nuevo panel
                Panel p1 = new Panel();
                //ubicacion del panel1
                p1.SetBounds(0, 0, 300, 200);
                //crear nuevo label de texto
                Label text1 = new Label();
                //texto que contendra el label
                text1.Text = "1)Hora de ingreso con segundos?";
                //ubicacion del label x, y, ancho y alto
                text1.SetBounds(10, 20, 200, 50);
                //agregar text1 al panel 1
                p1.Controls.Add(text1);

                Panel p2 = new Panel();
                p2.SetBounds(0, 60, 300, 300);

                DateTimePicker hora = new DateTimePicker();
                hora.Format = DateTimePickerFormat.Time;
                hora.Location = new Point(100, 0);
                hora.CustomFormat = "HH";
                hora.ShowUpDown = true;
                hora.Width = 100;
                
                p2.Controls.Add(hora);

                this.Controls.Add(p2);
                this.Controls.Add(p1);

            }

        }


        private void monthCalendar1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            // Show the start and end dates in the text box.
            TextBox textBox1 = new TextBox();
            textBox1.Text = "Date Selected: Start = " +
                e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
            this.Controls.Add(textBox1);
        }

        private void monthCalendar1_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            // Show the start and end dates in the text box.
            TextBox textBox1 = new TextBox();
            textBox1.Text = "Date Changed: Start =  " +
                e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
            this.Controls.Add(textBox1);
        }

        private void clickBotton1(object sender, EventArgs e)
        {
            //condicion para los botones
            if (((Button)sender).Text == "SI")
                MessageBox.Show("seleccionaste SI", "Mensaje",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (((Button)sender).Text == "NO")
                MessageBox.Show("seleccionaste NO", "Mensaje",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}
