using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChipDeck
{
    public partial class Incio : Form
    {
        public Incio()
        {
            InitializeComponent();
        }
        private void Incio_Load(object sender, EventArgs e)
        {
            buscartiempo.Enabled = false;
        }

        private void controlBotones()
        {
            if (numero.Text.Trim() != string.Empty && numero.Text.All(Char.IsNumber))
            {
                buscartiempo.Enabled = true;
                errorProvider1.SetError(numero, "");
            }
            else
            {
                if (!(numero.Text.All(Char.IsNumber)))
                {
                    errorProvider1.SetError(numero, "Solo puedes escribir numeros");
                }
                else
                {
                    errorProvider1.SetError(numero, "Debes escribir tu numero de corredor");
                }
                buscartiempo.Enabled = false;
                numero.Focus();
            }
        }

        private void numero_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void buscartiempo_Click(object sender, EventArgs e)
        {

            Info infoCorrer = new Info(numero.Text);

            infoCorrer.ShowDialog();
        }
    }
}
