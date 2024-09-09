using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertJpgToIcon
{
    public partial class FormTamañoIcono : Form
    {
        public string TamañoIcono { get; set; }
        
        public FormTamañoIcono()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            TamañoIcono = textBox1.Text.ToLower();
            string patron = @"^\d+(\.\d+)?x\d+(\.\d+)?$";
            if (Regex.IsMatch(TamañoIcono, patron))
            {
                // El texto ingresado cumple con el formato
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                // El texto ingresado no cumple con el formato
                MessageBox.Show("Formato incorrecto. Debe ser un número, seguido de 'x' y otro número.");
            }
        }
    }
}
