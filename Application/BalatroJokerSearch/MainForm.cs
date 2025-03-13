using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using Dapper;
using System.CodeDom;

namespace BalatroJokerSearch
{
    public partial class MainForm: Form
    {

        public String connectionString;
        public SqlConnection connection;

        public MainForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.connection = new SqlConnection(connectionString);

            costFromComboBox.SelectedIndex = 0;
            costToComboBox.SelectedIndex = 10;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var search = new JokerSearch
            {
                NameContains = nameTextBox.Text,
                CostMin = Int32.Parse(costFromComboBox.Text),
                CostMax = Int32.Parse(costToComboBox.Text),
                Rarity = rarityComboBox.Text,
                Ability = abilityComboBox.Text
            };

            String storedProcedureName = "spSearchJokers";

            List<Joker> jokers = connection.Query<Joker>(storedProcedureName, search, commandType: CommandType.StoredProcedure).ToList();

            resultsGroupBox.Text = "Results - " + jokers.Count();

            jokerListView.Items.Clear();
            foreach (Joker joker in jokers)
            {

                jokerListView.Items.Add(
                    new ListViewItem { ImageIndex = joker.JokerID, Text = joker.Name }
                );
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            costFromComboBox.SelectedIndex = 0;
            costToComboBox.SelectedIndex = 10;
            rarityComboBox.SelectedIndex = 0;
            abilityComboBox.SelectedIndex = 0;
        }

        private void jokerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jokerListView.SelectedItems.Count == 0) { return; }
            String procedureName = "spGetJokerByID";
            JokerIndex jokerID = new JokerIndex
            {
                JokerID = jokerListView.SelectedItems[0].ImageIndex
            };
            Joker joker = connection.QueryFirstOrDefault<Joker>(procedureName, jokerID, commandType: CommandType.StoredProcedure);
            detailGroupBox.Text = joker.Name;
            jokerDescriptionLabel.Text = joker.getWrappedDesc();
            jokerCostLabel.Text = "$"+joker.Cost.ToString();
            jokerRarityLabel.Text = joker.Rarity;
            jokerAbilityLabel.Text = joker.Ability;

        }
    }

    public class Joker
    {
        public static int DescriptionLineWrap = 30;
        public int JokerID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int Cost { get; set; }
        public String Rarity { get; set; }
        public String Ability { get; set; }

        public String getWrappedDesc()
        {
            StringBuilder newDesc = new StringBuilder();
            String[] words = Description.Split(' ');
            String line = "";

            foreach (String word in words)
            {
                if ((line + word).Length > DescriptionLineWrap) {
                    newDesc.AppendLine(line);
                    line = "";
                }
                line += String.Format("{0} ", word);
            }
            if (line.Length > 0)
            {
                newDesc.AppendLine(line);
            }
            return newDesc.ToString();
        }
    }

    public class JokerSearch
    {
        public String NameContains { get; set; }
        public int CostMin { get; set; }
        public int CostMax { get; set; }
        public String Rarity { get; set; }
        public String Ability { get; set; }
    }

    public class JokerIndex
    {
        public int JokerID { get; set; }
    }
}
