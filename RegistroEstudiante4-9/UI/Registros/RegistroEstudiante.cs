using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroEstudiante4_9.BLL;
using RegistroEstudiante4_9.Entidades;

namespace RegistroEstudiante4_9
{
    public partial class RegistroEstudiante : Form
    {
        public RegistroEstudiante()
        {
            InitializeComponent();
        }



        private void Limpiar()
        {
            IdnumericUpDown1.Value = 0;
            MatriculatextBox.Text = string.Empty;
            NombreTexbox.Text = string.Empty;
            ApellidostextBox.Text = string.Empty;
            CedulatextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            CelularmaskedTextBox.Text = string.Empty;
            EmailtextBox7.Text = string.Empty;
            BalancetextBox.Text = string.Empty;
            FechaNacimientodateTimePicker1.Value = DateTime.Now;
            SexocomboBox.Text = string.Empty;

        }

        
        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteID = Convert.ToInt32(IdnumericUpDown1.Value);
            estudiante.Matricula = MatriculatextBox.Text;
            estudiante.Nombres = NombreTexbox.Text;
            estudiante.Apellidos = ApellidostextBox.Text;
            estudiante.Cedula = CedulatextBox.Text;
            estudiante.Telefono = TelefonomaskedTextBox.Text;
            estudiante.Celular = CelularmaskedTextBox.Text;
            estudiante.Email = EmailtextBox7.Text;
            estudiante.FechaNacimiento = FechaNacimientodateTimePicker1.Value;
            estudiante.Sexo = SexocomboBox.Text;
            estudiante.Balance = BalancetextBox.Text;

            return estudiante;
        }

        private bool ExisteEnBaseDeDatos()
        {
            Estudiantes estudiante = EstudiantesBll.Buscar((int)IdnumericUpDown1.Value);
            return (estudiante != null);
        }

        private void LlenaCampo(Estudiantes estudiante)
        {
            IdnumericUpDown1.Value = estudiante.EstudianteID;
            MatriculatextBox.Text = estudiante.Matricula;
            NombreTexbox.Text = estudiante.Nombres;
            ApellidostextBox.Text = estudiante.Apellidos;
            CedulatextBox.Text = estudiante.Cedula;
            TelefonomaskedTextBox.Text = estudiante.Telefono;
            CelularmaskedTextBox.Text = estudiante.Celular;
            EmailtextBox7.Text = estudiante.Email;
            FechaNacimientodateTimePicker1.Value = estudiante.FechaNacimiento;
            SexocomboBox.Text = estudiante.Sexo;
            BalancetextBox.Text = estudiante.Balance;

        }
       

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();



            if (NombreTexbox.Text == string.Empty)
            {
                MyerrorProvider.SetError(NombreTexbox, "El campo Nombre no puede estar vacio");
                NombreTexbox.Focus();
                paso = false;
            }


            if (string.IsNullOrWhiteSpace(CedulatextBox.Text.Replace("-", "")))
            {
                MyerrorProvider.SetError(CedulatextBox, "El campo Cedula no puede estar vacio");
                CedulatextBox.Focus();
                paso = false;
            }




            return paso;
        }

       

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            Estudiantes estudiante;
            bool paso = false;

            if (!Validar())
                return;

            estudiante = LlenaClase();

            if (IdnumericUpDown1.Value == 0)
                paso = EstudiantesBll.Guardar(estudiante);
            else
            {
                if (!ExisteEnBaseDeDatos())
                {
                    MessageBox.Show("LO SIENTO, no es posible modificar el estudiante, no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = EstudiantesBll.Modificar(estudiante);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado con exito", "Existe,", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No se pudo guardar al Estudiante!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();
            int id;
            id = Convert.ToInt32(IdnumericUpDown1.Value);

            Limpiar();

            if (EstudiantesBll.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MyerrorProvider.SetError(IdnumericUpDown1, "No se puede  eliminar una persona no existente");
            }
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            int id;
            Estudiantes estudiante = new Estudiantes();
            id = Convert.ToInt32(IdnumericUpDown1.Value);

            Limpiar();

            estudiante = EstudiantesBll.Buscar(id);

            if (estudiante != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenaCampo(estudiante);
            }
            else
            {
                MessageBox.Show("Persona no Encontrada");
            }
        }
    }
}
