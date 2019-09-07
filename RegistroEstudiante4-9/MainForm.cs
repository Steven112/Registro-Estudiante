using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroEstudiante4_9.Entidades;
using System.Windows.Forms;
using RegistroEstudiante4_9.BLL;



namespace RegistroEstudiante4_9
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

         
        
       

        

       
       

        
            




       

        private void MatriculatextBox_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void NombreTexbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApellidostextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CedulatextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelefonotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CelulartextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailtextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void BalancetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaNacimientodateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void IdEstuduantedomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }


        private void IdnumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SexocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        

        private void CelularmaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TelefonomaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void RegistroEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registro = new RegistroEstudiante();
            registro.Show();
        }
    }
}
