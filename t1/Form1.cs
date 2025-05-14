using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace t1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing; 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtbarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtbarea.Text = string.Empty;
            txtbperimetro.Text = string.Empty;
            txtRaio.Text = string.Empty;
            txtBaseLad.Text = string.Empty;
            txtAlt.Text = string.Empty;
            rbtnQuadrado.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbtnQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            lblBaseLado.Visible = true;
            txtBaseLad.Visible = true;
            lblBaseLado.Text = "Lado:";
            lblAlt.Visible = false;
            lblRaio.Visible = false;
            txtAlt.Visible = false;
            txtRaio.Visible = false;
            
        }

        private void rbtnretangulo_CheckedChanged(object sender, EventArgs e)
        {
            lblBaseLado.Visible = true;
            txtBaseLad.Visible = true;
            lblBaseLado.Text = "Base:";
            lblAlt.Visible = true;
            txtAlt.Visible = true;
            lblRaio.Visible = false;
            txtRaio.Visible = false;
        }

        private void rbtncirculo_CheckedChanged(object sender, EventArgs e)
        {
            lblBaseLado.Visible = false;
            txtBaseLad.Visible = false;
            lblAlt.Visible = false;
            txtAlt.Visible = false;
            lblRaio.Visible = true;
            txtRaio.Visible = true;
        }

        private void rbtntriangulo_CheckedChanged(object sender, EventArgs e)
        {
            lblBaseLado.Visible = true;
            txtBaseLad.Visible = true;
            lblBaseLado.Text = "Base:";
            lblAlt.Visible = true;
            txtAlt.Visible = true;
            lblRaio.Visible = false;
            txtRaio.Visible = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double perimetro, area, lado, raio, largura, alt;
            string figGeo;
            if (rbtncirculo.Checked)
            {
                try
                {
                    raio = double.Parse(txtRaio.Text);
                    area = Math.Round(Math.PI * Math.Pow(raio,2), 2);
                    perimetro = Math.Round(2 * Math.PI * raio, 2);
                    figGeo = "Círculo";

                    txtbarea.Text = area.ToString();
                    txtbperimetro.Text = perimetro.ToString();

                    if (chkAtvHist.Checked) {
                        lstHist.Items.Add(figGeo);
                        lstHist.Items.Add("Raio: " +  raio);
                        lstHist.Items.Add("Area: " + area);
                        lstHist.Items.Add("Perimetro: " + perimetro);
                        lstHist.Items.Add("----------------------------------");

                    }

                } catch
                {
                    MessageBox.Show("Valor Invalido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rbtnQuadrado.Checked) {
                try
                {
                    lado = double.Parse(txtBaseLad.Text);
                    area = Math.Round(Math.Pow(lado, 2), 2);
                    perimetro = Math.Round(lado * 4, 2);
                    figGeo = "Quadrado";


                    txtbarea.Text = area.ToString();
                    txtbperimetro.Text = perimetro.ToString();
                    if (chkAtvHist.Checked)
                    {
                        lstHist.Items.Add(figGeo);
                        lstHist.Items.Add("Lado: " + lado);
                        lstHist.Items.Add("Area: " + area);
                        lstHist.Items.Add("Perimetro: " + perimetro);
                        lstHist.Items.Add("----------------------------------");

                    }
                }
                catch
                {
                    MessageBox.Show("Valor Invalido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rbtnretangulo.Checked)
            {
                try
                {
                    alt = double.Parse(txtAlt.Text);
                    largura = double.Parse(txtBaseLad.Text);
                    area = Math.Round(largura * alt, 2);
                    perimetro = Math.Round(largura * 2 + alt * 2, 2);
                    figGeo = "Retangulo";


                    txtbarea.Text = area.ToString();
                    txtbperimetro.Text = perimetro.ToString();
                    if (chkAtvHist.Checked)
                    {
                        lstHist.Items.Add(figGeo);
                        lstHist.Items.Add("Base: " + largura);
                        lstHist.Items.Add("Altura: " + alt);
                        lstHist.Items.Add("Area: " + area);
                        lstHist.Items.Add("Perimetro: " + perimetro);
                        lstHist.Items.Add("----------------------------------");

                    }
                }
                catch
                {
                    MessageBox.Show("Valor Invalido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rbtntriangulo.Checked)
            {
                try
                {
                    alt = double.Parse(txtAlt.Text);
                    largura = double.Parse(txtBaseLad.Text);
                    area = Math.Round((largura * alt)/2, 2);
                    perimetro = Math.Round(largura * 3, 2);
                    figGeo = "Triangulo";


                    txtbarea.Text = area.ToString();
                    txtbperimetro.Text = perimetro.ToString();
                    if (chkAtvHist.Checked)
                    {
                        lstHist.Items.Add(figGeo);
                        lstHist.Items.Add("Base: " + largura);
                        lstHist.Items.Add("Altura: " + alt);
                        lstHist.Items.Add("Area: " + area);
                        lstHist.Items.Add("Perimetro: " + perimetro);
                        lstHist.Items.Add("----------------------------------");

                    }
                }
                catch
                {
                    MessageBox.Show("Valor Invalido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimHist_Click(object sender, EventArgs e)
        {
            lstHist.Items.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           
           DialogResult resposta = MessageBox.Show("Deseja Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void imgGeo_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
