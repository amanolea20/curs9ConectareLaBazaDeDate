using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace curs9ConectareLaBazaDeDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butonConectare_Click(object sender, EventArgs e)
        {
            // conectare la o BD Access
            //definim stringul de conectare
            string SirDEconectare;
            SirDEconectare = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\BDstudenti.accdb;Persist Security Info=False;";

            //definim o conexiune
            OleDbConnection conexiune;
            conexiune = new OleDbConnection();
            conexiune.ConnectionString = SirDEconectare;

            //deschidem conexiunea(realizam in mod efectiv conectarea la server
            conexiune.Open();

            //informam userul ca s-a realizat conexiunea la BD
            MessageBox.Show("Conexiune realizată!!");

            //folosim comenzi pentru a introduce date noi in BD
            OleDbCommand comanda;
            comanda = new OleDbCommand();
            //comanda.CommandText = "INSERT INTO localitati(codLocalitate, denLocalitate, judet) VALUES(5,'Negresti','VS')";
            comanda.CommandText = " INSERT INTO localitati(codLocalitate, denLocalitate, judet) VALUES(?,?,?)";
            comanda.Connection = conexiune; 

            comanda.Parameters.AddWithValue("codLocalitate", txtCod.Text);
            comanda.Parameters.AddWithValue("denLocalitate", txtLoc.Text);
            comanda.Parameters.AddWithValue("judet", txtJud.Text);
            MessageBox.Show("O sa execut comanda: " + comanda.CommandText);

            //executam comanda pe server
            comanda.ExecuteNonQuery();
            MessageBox.Show("Localitate adaugata cu succes!");



            //ne deconectam de la server
            conexiune.Close();

        }
    }
}
