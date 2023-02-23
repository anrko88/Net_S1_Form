using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Semana_1___LP_VI___Forms
{
    public partial class Form_TiposDatos : Form
    {
        public Form_TiposDatos()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("TiposDeDatos.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_TiposDatos fromtd = new Form_TiposDatos();
            fromtd.Hide();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
        
        }
    }
}