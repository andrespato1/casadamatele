using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograFinalBD
{
    public partial class ReportesDoctor : Form
    {
        public ReportesDoctor()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (OpcionesReporte.Text == "Citas Registradas en el Sistema")
            {
                label2.Show();
                FiltrarPor.Show();
                button3.Show();
                comboBox1.Hide();
                button4.Hide();
                label6.Hide();
                textBox5.Hide();
                button4.Hide();
                label6.Hide();
                textBox5.Hide();

            }
            if (OpcionesReporte.Text == "Diagnósticos asociados a un paciente")
            {
                label2.Show();
                comboBox1.Show();
                FiltrarPor.Hide();
                button4.Show();
                button3.Hide();
                label6.Show();
                textBox5.Show();
                label5.Hide();
                textBox4.Hide();
                label4.Hide();
                textBox3.Hide();
                label3.Hide();
                EstadoT.Hide();
                fecha.Hide();
                fecha1.Hide();
                textBox1.Hide();
                textBox2.Hide();
                fecha.Hide();
                fecha1.Hide();
                textBox1.Hide();
                textBox2.Hide();
                label8.Hide();
                textBox7.Hide();
                label7.Hide();
                textBox6.Hide();
            }
            if (OpcionesReporte.Text == "Tratamiento asociado a un paciente")
            {

            }
            if (OpcionesReporte.Text == "Cantidad de citas registradas en el sistema")
            {
                label2.Show();
                FiltrarPor.Show();
                button3.Show();
                comboBox1.Hide();
                button4.Hide();
                label6.Hide();
                textBox5.Hide();
                label5.Hide();
                textBox4.Hide();
                label4.Hide();
                textBox3.Hide();
                label3.Hide();
                EstadoT.Hide();
                fecha.Hide();
                fecha1.Hide();
                textBox1.Hide();
                textBox2.Hide();
            }
            if (OpcionesReporte.Text == "Cantidad de diagnósticos")
            {

            }
            if (OpcionesReporte.Text == "Cantidad de tratamientos")
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuDoctor volver = new MenuDoctor();
            volver.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FiltrarPor.Text == "Rango de Fechas")
            {
                fecha.Show();
                fecha1.Show();
                textBox1.Show();
                textBox2.Show();
                label5.Hide();
                textBox4.Hide();
                label4.Hide();
                textBox3.Hide();
                label3.Hide();
                EstadoT.Hide();
                label8.Hide();
                textBox7.Hide();
                label7.Hide();
                textBox6.Hide();


            }

            if (FiltrarPor.Text == "Estado")
            {
                label3.Show();
                EstadoT.Show();
                fecha.Hide();
                fecha1.Hide();
                textBox1.Hide();
                textBox2.Hide();
                label4.Hide();
                textBox3.Hide();
                label5.Hide();
                textBox4.Hide();
            }
            if (FiltrarPor.Text == "Especialidad")
            {
                label4.Show();
                textBox3.Show();
                label3.Hide();
                EstadoT.Hide();
                fecha.Hide();
                fecha1.Hide();
                textBox1.Hide();
                textBox2.Hide();
                label5.Hide();
                textBox4.Hide();

            }
            if (FiltrarPor.Text == "Nombre de paciente")
            {
                label5.Show();
                textBox4.Show();
                label4.Hide();
                textBox3.Hide();
                label3.Hide();
                EstadoT.Hide();
                fecha.Hide();
                fecha1.Hide();
                textBox1.Hide();
                textBox2.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Rango de Fechas")
            {
                fecha.Show();
                fecha1.Show();
                textBox1.Show();
                textBox2.Show();
                label8.Hide();
                textBox7.Hide();
                label7.Hide();
                textBox6.Hide();

            }

            if (comboBox1.Text == "Nivel")
            {
                label7.Show();
                textBox6.Show();
                fecha.Hide();
                fecha1.Hide();
                textBox1.Hide();
                label8.Hide();
                textBox7.Hide();
            }
            if (comboBox1.Text == "Nombre")
            {
                label8.Show();
                textBox7.Show();
                label7.Hide();
                textBox6.Hide();
                fecha.Hide();
                fecha1.Hide();
                textBox1.Hide();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string consulta;
            conexionBD consultaBase = new conexionBD();
            if (OpcionesReporte.Text == "Citas Registradas en el Sistema")
            {
                if (FiltrarPor.Text == "Rango de Fechas")
                {

                    consulta = "Select * " + "from cita " + "where fechaCita between '" + textBox1.Text + "' and '" + textBox2.Text + "' ";
                    consultaBase.seleccionarconjoin(dataGridView1, "cita", "numeroCita", consulta);

                }

                if (FiltrarPor.Text == "Estado")
                {
                    consulta = "Select * " + "from cita " + "where estadoCita = '" + EstadoT.Text + "' ";
                    consultaBase.seleccionarconjoin(dataGridView1, "cita", "numeroCita", consulta);
                }
                if (FiltrarPor.Text == "Especialidad")
                {
                    consulta = "Select * " + "from cita " + "where nombreArea = '" + textBox3.Text + "' ";
                    consultaBase.seleccionarconjoin(dataGridView1, "cita", "numeroCita", consulta);

                }
                if (FiltrarPor.Text == "Nombre de paciente")
                {
                    consulta = "Select * " + "from cita, pacientesolicitacita, persona " + "where  cita.numeroCita = pacientesolicitacita.numeroCita and pacientesolicitacita.cedula = persona.cedula and persona.nombre = '" + textBox3.Text + "' ";
                    consultaBase.seleccionarconjoin(dataGridView1, "cita", "numeroCita", consulta);
                }


            }
            if (OpcionesReporte.Text == "Diagnósticos asociados a un paciente")
            {
                if (comboBox1.Text == "Rango de Fechas")
                {
                    consulta = "Select * " + "from persona, pacientesolicitacita, cita, diagnostico_cita  " + "where persona.cedula = pacientesolicitacita.cedula and pacientesolicitacita.numeroCita = cita.numeroCita and cita.numeroCita = diagnostico_cita.numeroCita and cita.fechaCita between '" + textBox1.Text + "' and '" + textBox2.Text + "' ";
                    consultaBase.seleccionarconjoin(dataGridView1, "cita", "numeroCita", consulta);

                }

                if (comboBox1.Text == "Nivel")
                {
                    consulta = "Select * " + "from persona, pacientesolicitacita, cita, diagnostico_cita  " + "where persona.cedula = pacientesolicitacita.cedula and pacientesolicitacita.numeroCita = cita.numeroCita and cita.numeroCita = diagnostico_cita.numeroCita and diagnostico_cita.nivelDiagnostico = '" + textBox6.Text + "' ";
                    consultaBase.seleccionarconjoin(dataGridView1, "cita", "numeroCita", consulta);
                }
                if (comboBox1.Text == "Nombre")
                {

                    consulta = "Select * " + "from persona, pacientesolicitacita, cita, diagnostico_cita  " + "where persona.cedula = pacientesolicitacita.cedula and pacientesolicitacita.numeroCita = cita.numeroCita and cita.numeroCita = diagnostico_cita.numeroCita and diagnostico_cita.nombreDiagnostico = '" + textBox7.Text + "' and " + "persona.nombre = " + textBox5.Text;
                    consultaBase.seleccionarconjoin(dataGridView1, "cita", "numeroCita", consulta);
                }


            }
            if (OpcionesReporte.Text == "Tratamiento asociado a un paciente")
            {

            }
            if (OpcionesReporte.Text == "Cantidad de citas registradas en el sistema")
            {
                if (FiltrarPor.Text == "Rango de Fechas")
                {

                    consulta = "Select count(numeroCita) " + "from cita " + "where fechaCita between '" + textBox1.Text + "' and '" + textBox2.Text + "' ";
                    consultaBase.seleccionarconjoin(dataGridView1, "cita", "numeroCita", consulta);

                }

                if (FiltrarPor.Text == "Estado")
                {
                    consulta = "Select count(numeroCita) " + "from cita " + "where estadoCita = '" + EstadoT.Text + "' ";
                    consultaBase.seleccionarconjoin(dataGridView1, "cita", "numeroCita", consulta);
                }
                if (FiltrarPor.Text == "Especialidad")
                {
                    consulta = "Select count(numeroCita) " + "from cita " + "where nombreArea = '" + textBox3.Text + "' ";
                    consultaBase.seleccionarconjoin(dataGridView1, "cita", "numeroCita", consulta);

                }
            }
            if (OpcionesReporte.Text == "Cantidad de diagnósticos")
            {

            }
            if (OpcionesReporte.Text == "Cantidad de tratamientos")
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
              
                    }
                }
            }
        



