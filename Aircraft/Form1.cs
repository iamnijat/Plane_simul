using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aircraft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

            /* Image img = pictureBox2;
            img.RotateFlip(RotateFlipType.Rotate270FlipY);
            pictureBox2.Image = img;  */


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {









          
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = comboBox1.Text;
            var b = comboBox2.Text;
            comboBox2.Text = a;
            comboBox1.Text = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label18.Text = "DESTINATION : " + comboBox1.Text + " - " + comboBox2.Text;
            label19.Text = "DATE : " + dateTimePicker1.Text;
            label20.Text = "TIME : " + maskedTextBox1.Text;
            
            label15.Visible = true;

            label16.Visible = true;
            label15.ResetText();
            label16.ResetText();
     
         label15.Text = comboBox1.SelectedItem.ToString();
           label16.Text = comboBox2.SelectedItem.ToString();
            timer1.Start();
            pictureBox2.Image = new Bitmap(@"C:\Users\Niko\Desktop\Praktika\images.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = pictureBox2.Location.X;
            int b = pictureBox2.Location.Y;
            pictureBox2.Location = new Point(a + 7, b - 3);
           
      
           
            label17.Text = "Coordinate : " + a + " , " + b;
            if (a > 450)
            {

                timer1.Stop();
                timer2.Start();
                pictureBox2.Image = new Bitmap(@"C:\Users\Niko\Desktop\Praktika\d.jpg");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
     
           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            int a = pictureBox2.Location.X;
            int b = pictureBox2.Location.Y;
            pictureBox2.Location = new Point(a + 7, b);
            label17.Text = "Coordinat : " + a + " , " + b;
            if (a > 757)
            {
                timer2.Stop();
               timer3.Start();
                pictureBox2.Image = new Bitmap(@"C:\Users\Niko\Desktop\Praktika\a.jpg");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int a = pictureBox2.Location.X;
            int b = pictureBox2.Location.Y;
            pictureBox2.Location = new Point(a + 7, b + 3);
            label17.Text = "Coordinat : " + a + " , " + b;
            if (a > 1214)
            {
                pictureBox2.Image = new Bitmap(@"C:\Users\Niko\Desktop\Praktika\d.jpg");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                int c = pictureBox2.Location.X;
                int d = pictureBox2.Location.Y;
                timer3.Stop();
                label17.Text = "Coordinat : " + c + " , " + d;

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int kor1 = MousePosition.X;
            int kor2 = MousePosition.Y;

            //addline grid
            //double rad2 = (180 / Math.PI) * kor1;
            //double rad3 = (180 / Math.PI) * kor2;
            double rad = kor2 / kor1;
            double derece = (rad * (180 / Math.PI));

            double minutes = (derece - Math.Floor(derece)) * 60.0;
            double seconds = (minutes - Math.Floor(minutes)) * 60.0;
            double tenths = (seconds - Math.Floor(seconds)) * 10.0;

            minutes = Math.Floor(minutes);
            seconds = Math.Floor(seconds);


            tenths = Math.Floor(tenths);

            label21.Text = "WGS-84 : " + minutes + "° " + seconds + "' " + tenths;
            /*
            double latitude = rad3;
            double longitude = rad2;
            int latSeconds = (int)Math.Round(latitude * 3600);
            int latDegrees = latSeconds / 3600;
            latSeconds = Math.Abs(latSeconds % 3600);
            int latMinutes = latSeconds / 60;
            latSeconds %= 60;

            int longSeconds = (int)Math.Round(longitude * 3600);
            int longDegrees = longSeconds / 3600;
            longSeconds = Math.Abs(longSeconds % 3600);
            int longMinutes = longSeconds / 60;
            longSeconds %= 60;
            label21.Text = latDegrees + " " + latMinutes + " " + latSeconds + " " + longDegrees + " " + longMinutes + " " + longSeconds;
            


            double coord = rad;
            int sec = (int)Math.Round(coord * 3600);
            int deg = sec / 3600;
            sec = Math.Abs(sec % 3600);
            int min = sec / 60;
            sec %= 60;


            label21.Text = "WGS-84 : " + deg + "° " + min + "' " + sec;
           */
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            int kor1 = MousePosition.X;
            int kor2 = MousePosition.Y;

            //addline grid
            //double rad2 = (180 / Math.PI) * kor1;
            //double rad3 = (180 / Math.PI) * kor2;
            double rad = kor2 / kor1;
            double derece = (rad * (180 / Math.PI));

            double minutes = (derece - Math.Floor(derece)) * 60.0;
            double seconds = (minutes - Math.Floor(minutes)) * 60.0;
            double tenths = (seconds - Math.Floor(seconds)) * 10.0;

            minutes = Math.Floor(minutes);
            seconds = Math.Floor(seconds);


            tenths = Math.Floor(tenths);

            label22.Text = "WGS-84 : " + minutes + "° " + seconds + "' " + tenths;
        }
    }
}
