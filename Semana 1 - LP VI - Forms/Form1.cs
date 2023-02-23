using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Semana_1___LP_VI___Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
           
        }
       
        private void MostrarMensaje(object sender, EventArgs e)
        {
            label1.Text = "Mi Primer Programa";
          

        }

        private void BtnForm2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir", "Aplicacion",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();//salir de la aplicacion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_TiposDatos frm3 = new Form_TiposDatos();
            frm3.Show();
        }

        private void BtnForm3_Click(object sender, EventArgs e)
        {
            Form3 frm3=new Form3();
            frm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Text = " ***  Form C# *** ";
            
        }
    }
}