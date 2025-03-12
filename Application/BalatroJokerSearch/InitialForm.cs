using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using System.CodeDom;

namespace BalatroJokerSearch
{
    public partial class InitialForm: Form
    {
        public const String INSERTION_SCRIPT = "INSERT INTO Jokers (JokerID, Name, Description, Cost, Rarity, Ability) VALUES (0, 'My Joker', 'My custom joker', 2, 'Common', 'Nothing')";

        public InitialForm()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            String connectionString = connectionStringTextBox.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                } catch (SqlException ex)
                {
                    MessageBox.Show("Connection failed:\n" + ex.Message);
                    return;
                }

                MainForm mainForm = new MainForm(connectionString);
                mainForm.Show();
                this.Hide();

            }
            
        }
    }
}
