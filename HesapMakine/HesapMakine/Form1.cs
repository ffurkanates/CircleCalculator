using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Double sonuc = 0 ;
        String islem = "";
        bool girilen_deger = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void More_Click(object sender, EventArgs e)
        {
            this.Width = 736;
            this.label1.Width = 736;
        }
        private void Nomore_Click(object sender, EventArgs e)
        {
            this.Width = 420;
            this.label1.Width = 420;
        }
        private void Numara_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "0") || girilen_deger)
                label1.Text = "";
            girilen_deger = false;

            Button buton = (Button)sender;
            if (buton.Text == ".")
            {
                if (!label1.Text.Contains("."))
                    label1.Text += buton.Text;
            }
            else
                label1.Text += buton.Text;
        }
        private void Temizle_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";
        }
        private void Sil_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);
            }
            if (label1.Text =="")
            {
                label1.Text = "0";
            }
        }     
        private void Aritmetik_Islemler_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            islem = buton.Text;
            sonuc = Double.Parse(label1.Text);
            
            label1.Text = "";
            label2.Text = System.Convert.ToString(sonuc) + "" + islem;
            history.Text += $"{label2.Text}";
            history.Text += $"{label1.Text}";



        }
        private void Esittir_Click(object sender, EventArgs e)
        {
            history.Text += $"{label1.Text}";
            label2.Text = "";
            switch (islem)
            {
                case "+":                   
                    label1.Text = (sonuc + Double.Parse(label1.Text)).ToString();
                    break;
                case "-":
                    label1.Text = (sonuc - Double.Parse(label1.Text)).ToString();                 
                    break;
                case "x":
                    label1.Text = (sonuc * Double.Parse(label1.Text)).ToString();          
                    break;
                case "÷":
                    label1.Text = (sonuc / Double.Parse(label1.Text)).ToString();               
                    break;
                case "mod":
                    label1.Text = (sonuc % Double.Parse(label1.Text)).ToString();                  
                    break;
                case "xʸ":
                    label1.Text = Math.Pow(sonuc, Double.Parse(label1.Text)).ToString();                  
                    break;
                case "%":
                    label1.Text = (sonuc / 100 * Double.Parse(label1.Text)).ToString();                 
                    break;
            }

            history.Text += $"={label1.Text}\n";

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }   
        private void Log_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(label1.Text);
            label2.Text = System.Convert.ToString("log" + "(" + (label1.Text) + ")");
            log = Math.Log10(log);
            label1.Text = System.Convert.ToString(log);
            history.Text += $"{label2.Text}={label1.Text}\n";
            
        }

        private void Karekok_Click(object sender, EventArgs e)
        {
            Double karekok = Double.Parse(label1.Text);
            label2.Text=System.Convert.ToString("√" + label1.Text);
            karekok = Math.Sqrt(karekok);
            label1.Text = System.Convert.ToString(karekok);
            history.Text += $"{label2.Text}={label1.Text}\n";

        }

        private void artieksi_Click(object sender, EventArgs e)
        {
           
                label1.Text = System.Convert.ToString(-1 * Double.Parse(label1.Text));                               
        }

        private void faktoryel_Click(object sender, EventArgs e)
        {
            int faktoryelsayi = 1;           
            for (int i = 1; i <= Double.Parse(label1.Text); i++)
            {
                faktoryelsayi *= i;
            }
            label1.Text = faktoryelsayi.ToString();
            history.Text += $"{label2.Text}={label1.Text}\n";
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(label1.Text);
            label2.Text = System.Convert.ToString("sin" + "(" + (label1.Text) + ")");
            sin = Math.Sin(sin);
            label1.Text = System.Convert.ToString(sin);
            history.Text += $"{label2.Text}={label1.Text}\n";
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(label1.Text);
            label2.Text = System.Convert.ToString("cos" + "(" + (label1.Text) + ")");
            cos = Math.Cos(cos);
            label1.Text = System.Convert.ToString(cos);
            history.Text += $"{label2.Text}={label1.Text}\n";
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(label1.Text);
            label2.Text = System.Convert.ToString("tan" + "(" + (label1.Text) + ")");
            tan = Math.Tan(tan);
            label1.Text = System.Convert.ToString(tan);
            history.Text += $"{label2.Text}={label1.Text}\n";
        }

        private void Cot_Click(object sender, EventArgs e)
        {
            double cot = Double.Parse(label1.Text);
            label2.Text = System.Convert.ToString("cot" + "(" + (label1.Text) + ")");
            cot = 1/Math.Tan(cot);
            label1.Text = System.Convert.ToString(cot);
            history.Text += $"{label2.Text}={label1.Text}\n";
        }

        private void E_Click(object sender, EventArgs e)
        {
;            label1.Text = "2,718281";
        }

        private void Sinh_Click(object sender, EventArgs e)
        {
            double sinh =Double.Parse(label1.Text);
            label2.Text = System.Convert.ToString("sinh" + "("+(label1.Text)+")");
            sinh = Math.Sinh(sinh);
            label1.Text = System.Convert.ToString(sinh);
            history.Text += $"{label2.Text}={label1.Text}\n";
        }

        private void Cosh_Click(object sender, EventArgs e)
        {
            double cosh = Double.Parse(label1.Text);
            label2.Text = System.Convert.ToString("cosh" + "(" + (label1.Text) + ")");
            cosh = Math.Cosh(cosh);
            label1.Text = System.Convert.ToString(cosh);
            history.Text += $"{label2.Text}={label1.Text}\n";
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            label1.Text = "3,14159265";
        }

        private void Ln_Click(object sender, EventArgs e)
        {
            double ln = Double.Parse(label1.Text);
            label2.Text = System.Convert.ToString("ln" + "(" + (label1.Text) + ")");
            ln = Math.Log(ln);
            label1.Text = System.Convert.ToString(ln);
            history.Text += $"{label2.Text}={label1.Text}\n";
        }
    }
    public class CircularButton : Button
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }
        public float Angle { get; set; }
        protected override void OnPaint(PaintEventArgs renk)
        {
            GraphicsPath daire = new GraphicsPath();
            daire.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(daire);
            LinearGradientBrush boya = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle);
            Graphics graphics = renk.Graphics;
            graphics.FillRectangle(boya, this.ClientRectangle);
            base.OnPaint(renk);
        }

    }
    public class GradientPanel : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }
        public float Angle { get; set; }

        protected override void OnPaint(PaintEventArgs renk)
        {
            LinearGradientBrush boya = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle);
            Graphics graphics = renk.Graphics;
            graphics.FillRectangle(boya, this.ClientRectangle);
            base.OnPaint(renk);
        }
    }
}
