using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static parcialAlgoritmosCorte2.estudiantes;

namespace parcialAlgoritmosCorte2
{
    public partial class Form1 : Form
    {


        static List<Estudiantes> listaEstudiantes = new List<Estudiantes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" || txtApellido.Text == "" || txtGenero.Text == "" || txtFecha.Text == "" || txtGrado.Text == "" || txtTelefono.Text == "" || txtMadre.Text =="" || txtPadre.Text =="" || txtNumDoc.Text =="" || txtTipoDoc.Text == "")

            {
                MessageBox.Show("Hay campos vacios, por favor completar");
            }
            else
            {
                Estudiantes est = new Estudiantes(txtNombre.Text, txtApellido.Text, txtTipoDoc.SelectedItem.ToString(), txtNumDoc.Text, txtFecha.Text, txtGenero.SelectedItem.ToString(), txtGrado.SelectedItem.ToString(),    txtTelefono.Text,  txtMadre.Text, txtPadre.Text);

                listaEstudiantes.Add(est);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaEstudiantes;

            }



        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumDoc.Clear();
            txtNumDoc.Clear();
            txtTelefono.Clear();
            txtMadre.Clear();
            txtPadre.Clear();
            txtGenero.SelectedIndex = -1;
            txtGrado.SelectedIndex = -1;
            txtTipoDoc.SelectedIndex = -1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
