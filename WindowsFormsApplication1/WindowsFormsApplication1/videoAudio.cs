using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//agregada para la reproduccion de audio    
using System.Media;

using WMPLib;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class videoAudio : Form
    {
        public videoAudio()
        {
            InitializeComponent();
        }

        private void videoAudio_Load(object sender, EventArgs e)
        {
            //de la 89 a 94
            this.SetBounds(0, 300, 300, 400);
            //Nombre de encabezado del form
            this.Text = "NOMBRE";

            //crear nuevo panel
            Panel p1 = new Panel();
            //ubicacion del panel1
            p1.SetBounds(0, 0, 300, 100);
            //crear nuevo label de texto
            Label text1 = new Label();
            //texto que contendra el label
            text1.Text = "Prueba de audio";
            //ubicacion del label x, y, ancho y alto
            text1.SetBounds(10, 20, 100, 50);
            //agregar text1 al panel 1
            p1.Controls.Add(text1);

            //agregamos nuevo panel
            Panel p2 = new Panel();
            p2.SetBounds(0,70,300, 100);
            Button reproducir = new Button();
            reproducir.SetBounds(100, 20, 100, 50);
            reproducir.Text = "Reproducir";
            reproducir.Click += new EventHandler(clickBotton1);
            p2.Controls.Add(reproducir);



            this.Controls.Add(p2);
            this.Controls.Add(p1);


        }

        private void clickBotton1(object sender, EventArgs e)
        {
            playSimpleSound();
        }

        //para reproducir sonidos
        
        private void playSimpleSound()
        {
            //para reproducir audio wav (:P no lo probe)
            /* SoundPlayer simpleSound = new SoundPlayer();
             simpleSound.SoundLocation = (@"My Wav File.wav");
             simpleSound.Play();
             */
            //para reproducir audio mp3
            WindowsMediaPlayer wplayer = new WindowsMediaPlayer();


            wplayer.URL = "C:\\Users\\M&M\\Documents\\Cosas\\Musica\\MUSICA 64KBPS\\ave maria.mp3";
            wplayer.controls.play();


        }
    }
}
