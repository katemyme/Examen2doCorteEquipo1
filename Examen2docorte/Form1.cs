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
        Queue<string> Pacientes = new Queue<string>();
        Stack<string> Pacienteurgente = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Pacientes.Count > 0)
            {
                string pacienteAtendido = Pacientes.Dequeue();
                MessageBox.Show("Paciente atendido: " + pacienteAtendido);
                MostrarPacientes();
            }
            else
            {
                MessageBox.Show("No hay pacientes en espera.");
            }
        }
        private void tbNormal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Pacientes.Enqueue(tbNormal.Text);
                tbNormal.Clear();
                tbNormal.Focus();
                MostrarPacientes();
            }
        }
        private void MostrarPacientes()
        {
            lbNormal.Items.Clear();
            foreach (var paciente in Pacientes)
            {
                lbNormal.Items.Add(paciente);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
       
        private void MostrarPila()
        {
            lbCritico.Items.Clear();
            foreach (string paciente in Pacienteurgente)
            {
                lbCritico.Items.Add(paciente);

            }
            tbCritico.Clear();
        }

        private void tbCritico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pacienteurgente.Push(tbCritico.Text);
                tbCritico.Clear();
                tbCritico.Focus();
                MostrarPila();
            }
        }

        private void btnEliminarPacienteCritico_Click(object sender, EventArgs e)
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

