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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* si queremos enviar algun parametro desde el metodo void main
         *  public Form1(int x, int y, int ancho, int alto)
        {
            InitializeComponent();
           
        }
        */

        private void Form1_Load(object sender, EventArgs e)
        {

            //declarar un nuevo form
            // Form Form1 = new Form();
            //size del form x, y, ancho y alto
            this.SetBounds(0, 300, 300, 400);
            //Nombre de encabezado del form
            this.Text = "NOMBRE";

            //crear nuevo panel
            Panel p1 = new Panel();
            //ubicacion del panel1
            p1.SetBounds(0, 0, 300, 200);
            //crear nuevo label de texto
            Label text1 = new Label();
            //texto que contendra el label
            text1.Text = "Prueba de texto:";
            //ubicacion del label x, y, ancho y alto
            text1.SetBounds(10, 20, 100, 50);
            //agregar text1 al panel 1
            p1.Controls.Add(text1);
            //nuevo textbox para ingreso de datos
            TextBox caja1 = new TextBox();
            //ubicacion del textbox en el panel1
            caja1.SetBounds(110, 20, 150, 50);
            caja1.Enabled = true;

            caja1.Anchor = AnchorStyles.Top;
            //Agregamos caja1 en el panel 1
            p1.Controls.Add(caja1);

            Panel p2 = new Panel();
            p2.SetBounds(0, 210, 60, 200);
            //agregar cuadro numerico al panel 1
            NumericUpDown edad = new NumericUpDown();
            //inicializacion del updown en 0
            edad.Value = 0;
            //numero maximo 100
            edad.Maximum = 100;
            //numero minimo 0
            edad.Minimum = 0;
            //ubicacion en el panel 2 x, y, ancho y alto
            edad.SetBounds(20, 0, 40, 50);
            p2.Controls.Add(edad);

            Panel p3 = new Panel();
            p3.SetBounds(60, 210, 120, 200);
            //radiobutton para seleccion 
            RadioButton b1 = new RadioButton();
            RadioButton b2 = new RadioButton();
            RadioButton b3 = new RadioButton();
            //texto en cada radio button
            b1.Text = "Meses";
            b2.Text = "Anios";
            b3.Text = "Desconocidos";
            //tamanio y posicion en el panel 3
            b1.SetBounds(10, 0, 80, 20);
            b2.SetBounds(10, 20, 80, 20);
            b3.SetBounds(10, 40, 110, 20);
            //agregamos al panel 3
            p3.Controls.Add(b1);
            p3.Controls.Add(b2);
            p3.Controls.Add(b3);

            Panel p4 = new Panel();
            p4.SetBounds(180, 210, 120, 200);
            //cuadro de seleccion
            CheckBox c1 = new CheckBox();
            CheckBox c2 = new CheckBox();
            //texto en el checkbox
            c1.Text = "Femenino";
            c2.Text = "Masculino";
            //ubicacion en el panel 4
            c1.SetBounds(10, 0, 80, 20);
            c2.SetBounds(10, 20, 80, 20);
            //acciones para los checkbox
            c1.Click += new EventHandler(clickBotton1);
            c2.Click += new EventHandler(clickBotton1);

            //agregar a panel 4
            p4.Controls.Add(c1);
            p4.Controls.Add(c2);



            //adherir panel
            this.Controls.Add(p1);
            this.Controls.Add(p2);
            this.Controls.Add(p3);
            this.Controls.Add(p4);




        }

        private void clickBotton1(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)

                MessageBox.Show("seleccionaste este checkbox", "My Application",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            /* foreach (CheckBox cbox in Controls)
                 if (!cbox.Equals(sender))
                     cbox.Checked = false;*/
        }
    }
}
