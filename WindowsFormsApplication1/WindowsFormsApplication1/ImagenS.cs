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
    public partial class ImagenS : Form
    {
        public ImagenS()
        {
            InitializeComponent();
        }

        private void ImagenS_Load(object sender, EventArgs e)
        {
            //contardor para mi, solo para ver configuraciones de cambio en un mismo form
            int cont = 2;

            //declarar un nuevo form
            // Form Form1 = new Form();
            //size del form x, y, ancho y alto
            this.SetBounds(0, 300, 300, 400);
            //Nombre de encabezado del form
            this.Text = "Select con Imagen";

            //crear nuevo panel
            Panel p1 = new Panel();
            //ubicacion del panel1
            p1.SetBounds(0, 0, 300, 200);
            //crear nuevo label de texto
            Label text1 = new Label();
            //texto que contendra el label
            text1.Text = "1)Frutas Favoritas?";
            //ubicacion del label x, y, ancho y alto
            text1.SetBounds(10, 20, 100, 50);
            //agregar text1 al panel 1
            p1.Controls.Add(text1);

            Panel p4 = new Panel();
            p4.SetBounds(0, 50, 300, 200);
            //cuadro de seleccion
            CheckBox c1 = new CheckBox();
            CheckBox c2 = new CheckBox();
            //texto en el checkbox
            c1.Text = "Manzana";
            c2.Text = "Banana";

            Image imga = Image.FromFile("C:\\Users\\M&M\\Pictures\\IMAGENES\\music.jpg");




            Bitmap myBitmap = new Bitmap("C:\\Users\\M&M\\Pictures\\IMAGENES\\music.jpg");

            //DrawImageRect(e);
            Graphics g;
            


            //myGraphics.DrawImage(myBitmap, 0, 0);

            /*           this.PictureBox1.Size = new System.Drawing.Size(140, 140);

               //Set the SizeMode to center the image.
               this.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
               */

            c1.Image = myBitmap;
            
            c1.ImageAlign = ContentAlignment.MiddleRight;
            //ubicacion en el panel 4
            c1.SetBounds(10, 0, 80, 100);
            c1.Size = new System.Drawing.Size(100,100);
            c2.SetBounds(10, 120, 80, 20);
            //acciones para los checkbox
            c1.Click += new EventHandler(clickBotton1);
            c2.Click += new EventHandler(clickBotton1);

            

            //agregar a panel 4
            p4.Controls.Add(c1);
            p4.Controls.Add(c2);



            //adherir panel
            this.Controls.Add(p4);
            this.Controls.Add(p1);

        }

        private void DrawImageRect(PaintEventArgs e)
        {

            // Create image.
            Image newImage = Image.FromFile("SampImag.jpg");

            // Create rectangle for displaying image.
            Rectangle destRect = new Rectangle(100, 100, 450, 150);

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, destRect);
        }


        private void clickBotton1(object sender, EventArgs e)
        {
            
        }
    }
}
