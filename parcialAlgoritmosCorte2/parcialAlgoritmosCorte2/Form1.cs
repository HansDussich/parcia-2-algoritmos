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


        public void actForm()
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


        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) ||
                    string.IsNullOrEmpty(txtFecha.Text) || string.IsNullOrEmpty(txtGenero.Text) ||
                    string.IsNullOrEmpty(txtGrado.Text) || string.IsNullOrEmpty(txtNumDoc.Text) ||
                    string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtTipoDoc.Text) ||
                    string.IsNullOrEmpty(txtPadre.Text) || string.IsNullOrEmpty(txtMadre.Text)
                    )
                {
                    throw new Exception("Hay campos vacios, por favor completar");
                }
                Estudiantes est = new Estudiantes(txtNombre.Text, txtApellido.Text, txtTipoDoc.SelectedItem.ToString(), txtNumDoc.Text, txtFecha.Text, txtGenero.SelectedItem.ToString(), txtGrado.SelectedItem.ToString(), txtTelefono.Text, txtMadre.Text, txtPadre.Text);

                listaEstudiantes.Add(est);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaEstudiantes;

                actForm();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hay campos vacios, por favor completar el formulario");
            }


            

            



        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }




        private void btnModificar_Click(object sender, EventArgs e)
        {
            String selec = docSel.Text;

            foreach (Estudiantes est in listaEstudiantes)
            {
                if (selec == est.NumDoc)
                {
                    est.Nombre = txtNombre.Text;
                    est.Apellido = txtApellido.Text;
                    est.TipoDoc = txtTipoDoc.Text;
                    est.NumDoc = txtNumDoc.Text;
                    est.Fecha_nacimiento = txtFecha.Text;
                    est.Grado = txtGrado.Text;
                    est.Genero = txtGenero.Text;
                    est.Telefono = txtTelefono.Text;
                    est.Nombre_madre = txtMadre.Text;
                    est.Nombre_padre = txtPadre.Text;

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listaEstudiantes;

                    MessageBox.Show("Se modifico exitosamente");
                    break;
                }
                
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String seleccion = docSel.Text;

            foreach (Estudiantes estudiantes in listaEstudiantes)
            {
                if (seleccion == estudiantes.NumDoc)
                {
                    listaEstudiantes.Remove(estudiantes);
                    break;
                }
                
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaEstudiantes;

        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String selec = docSel.Text;

            foreach (Estudiantes est in listaEstudiantes)
            {
                if (selec == est.NumDoc)
                {
                    txtNombre.Text = est.Nombre;
                    txtApellido.Text = est.Apellido;
                    txtFecha.Text = est.Fecha_nacimiento;
                    txtGenero.Text = est.Genero;
                    txtGrado.Text = est.Grado;
                    txtMadre.Text = est.Nombre_madre;
                    txtPadre.Text = est.Nombre_padre;
                    txtTelefono.Text = est.Telefono;
                    txtNumDoc.Text =est.NumDoc;
                    txtTipoDoc.Text = est.TipoDoc;
                    

                    break;
                }
                else
                {
                    MessageBox.Show("El estudiante no fue encontrado");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
