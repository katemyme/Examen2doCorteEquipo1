using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2docorte
{


    public partial class Form1 : Form
    {


        Stack<string> Pacienteurgente = new Stack<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pacienteurgente.Push(tbEmergencia.Text);
                tbEmergencia.Clear();
                MostrarPila();
            }
        }


        private void MostrarPila()
        {
            listBox1.Items.Clear();
            foreach (string paciente in Pacienteurgente)
            {
                listBox2.Items.Add(paciente);
                
            }
            tbEmergencia.Clear();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Pacienteurgente.Count > 0)
            {
                Pacienteurgente.Pop();
                MostrarPila();
            }
            else
            {
                MessageBox.Show("No hay pacientes en espera.");
            }
        }
    }



}
