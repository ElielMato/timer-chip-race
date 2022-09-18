using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ChipDeck
{
    public partial class Info : Form
    {

        string numeroCorrer;
        string nom;
        string num;
        string cat;
        string time;
        string post;
        public Info(string numero)
        {
            InitializeComponent();
            numeroCorrer = numero;
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=chipdeck;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string info = "select tiempo, puesto, categoria, nombre, numero from `info` where numero=" + numeroCorrer;
            databaseConnection.Open();
            MySqlCommand command = new MySqlCommand(info, databaseConnection);
            MySqlDataReader registro = command.ExecuteReader();
            if (registro.Read())
            {
                nom = registro["nombre"].ToString();
                cat = registro["categoria"].ToString();
                time = registro["tiempo"].ToString();
                post = registro["puesto"].ToString();
            }
            databaseConnection.Close();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=chipdeck;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string info = "select tiempo, puesto, categoria, nombre, numero from `info` where numero=" + numeroCorrer;
            databaseConnection.Open();
            MySqlCommand command = new MySqlCommand(info, databaseConnection);
            MySqlDataReader registro = command.ExecuteReader();
            if (registro.Read())
            {
                nombre.Text += registro["nombre"].ToString();
                categoria.Text += registro["categoria"].ToString();
                tiempo.Text += registro["tiempo"].ToString();
                puesto.Text += registro["puesto"].ToString();
            }
            else
                MessageBox.Show("No se encontro informacion sobre usted.");
            databaseConnection.Close();
            
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Impri;
            printDocument1.Print();
        }

        private void Impri( object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Calibri", 20, FontStyle.Regular);

            e.Graphics.DrawString("Datos del Corredor\n\nNombre: " + nom+"\nCategoria: "+cat+"\nPuesto: "+post+"\nTiempo: "+time, font, Brushes.Black, new RectangleF(20, 20, 1000, 1700));
        }
    }
}
