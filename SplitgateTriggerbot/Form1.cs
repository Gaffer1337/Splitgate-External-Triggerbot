using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using AutoItX3Lib;

namespace SplitgateTriggerbot
{
    public partial class Form1 : Form
    {

        AutoItX3 au3 = new AutoItX3();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string green = "65280";
            string red = "16711680";
            string shotgungreen = "65024";
            string shotgunred = "15860226";
            while (true)
            {
                object pix1 = au3.PixelGetColor(1280, 720);
                object pix3 = au3.PixelGetColor(1280, 672);
                object pix4 = au3.PixelGetColor(1326, 749);
                object pix5 = au3.PixelGetColor(1297, 719);
                object pix6 = au3.PixelGetColor(1249, 674);
                object pix7 = au3.PixelGetColor(1318, 681);
                object pix8 = au3.PixelGetColor(1238, 756);
                object pix9 = au3.PixelGetColor(1262, 720);
                object pix10 = au3.PixelGetColor(1280, 715);
                object pix11 = au3.PixelGetColor(1280, 720);
                object pix12 = au3.PixelGetColor(1280, 720);
                object pix13 = au3.PixelGetColor(1280, 720);
                object pix14 = au3.PixelGetColor(1280, 720);
                var smg = pix1.ToString();
                var carbine = pix11.ToString();
                var battle = pix12.ToString();
                var bfb = pix13.ToString();
                var rocket = pix14.ToString();
                var plasma = pix3.ToString();
                var shotgun = pix4.ToString();
                var shotgun2 = pix6.ToString();
                var shotgun3 = pix7.ToString();
                var shotgun4 = pix8.ToString();
                var pistol = pix5.ToString();
                var pistol2 = pix9.ToString();
                var pistol3 = pix10.ToString();
                if (smg == "16711680" || pistol == "14550020" || pistol2 == "14615556" || pistol3 == "15532803" || plasma == "16711680")//auto
                {
                    au3.MouseDown("LEFT");
                }
                else if(shotgun == "16122113" || shotgun2 == "16121856" || shotgun3 == "15729154" || shotgun4 == "16711680" || carbine == "16711680" || battle == "16711680" || bfb == "16711680" || rocket == "16711680")//semi auto
                {
                    au3.MouseClick("LEFT");
                }
                else
                {

                }
            }
        }

        private void leftuponce()
        {
            au3.MouseUp("LEFT");
            
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
