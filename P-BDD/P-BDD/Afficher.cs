using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace P_BDD
{
    public partial class Form1 : Form
    {

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (comboBoxOptions.SelectedItem != null)
            {
                textBoxResultat.Clear();

                string selectedOption = comboBoxOptions.SelectedItem.ToString();

                switch (selectedOption)
                {
                    case "Pièces de rechange":
                        AfficherPiecesDeRechange();
                        break;
                    case "Vélos":
                        AfficherVelos();
                        break;
                    case "Fournisseurs":
                        AfficherFournisseurs();
                        break;
                    case "Commandes":
                        AfficherCommandes();
                        break;
                    case "Salariés":
                        AfficherSalarie();
                        break;
                    case "Clients particuliers":
                        AfficherCltParticulier();
                        break;
                    case "Clients entreprise":
                        AfficherCltEntrprise();
                        break;

                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une option dans la liste déroulante.");
            }
        }
        private void AfficherPiecesDeRechange()
        {
            string connectionString = "SERVER=localhost; PORT=3306; DATABASE=VeloMax; UID=root;PASSWORD=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM SPARE_PART";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                textBoxResultat.Text += reader.GetValue(i).ToString() + "\t";
                            }
                            textBoxResultat.Text += Environment.NewLine;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération des pièces de rechange : " + ex.Message);
                    }
                }
            }
        }

        private void AfficherVelos()
        {
            string connectionString = "SERVER=localhost; PORT=3306; DATABASE=VeloMax; UID=root;PASSWORD=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM BICYCLE";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                textBoxResultat.Text += reader.GetValue(i).ToString() + "\t";
                            }
                            textBoxResultat.Text += Environment.NewLine;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération des vélos : " + ex.Message);
                    }
                }
            }
        }

        private void AfficherFournisseurs()
        {
            string connectionString = "SERVER=localhost; PORT=3306; DATABASE=VeloMax; UID=root;PASSWORD=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM SUPPLIER";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                textBoxResultat.Text += reader.GetValue(i).ToString() + "\t";
                            }
                            textBoxResultat.Text += Environment.NewLine;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération des fournisseurs : " + ex.Message);
                    }
                }
            }
        }

        private void AfficherCommandes()
        {
            string connectionString = "SERVER=localhost; PORT=3306; DATABASE=VeloMax; UID=root;PASSWORD=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM ORDERS";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                textBoxResultat.Text += reader.GetValue(i).ToString() + "\t";
                            }
                            textBoxResultat.Text += Environment.NewLine;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération des commandes : " + ex.Message);
                    }
                }
            }
        }

        private void AfficherSalarie()
        {
            string connectionString = "SERVER=localhost; PORT=3306; DATABASE=VeloMax; UID=root;PASSWORD=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM EMPLOYEE";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                textBoxResultat.Text += reader.GetValue(i).ToString() + "\t";
                            }
                            textBoxResultat.Text += Environment.NewLine;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération des salariés : " + ex.Message);
                    }
                }
            }
        }

        private void AfficherCltParticulier()
        {
            string connectionString = "SERVER=localhost; PORT=3306; DATABASE=VeloMax; UID=root;PASSWORD=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM INDIVIDUAL";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                textBoxResultat.Text += reader.GetValue(i).ToString() + "\t";
                            }
                            textBoxResultat.Text += Environment.NewLine;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération des clients individuels : " + ex.Message);
                    }
                }
            }
        }

        private void AfficherCltEntrprise()
        {
            string connectionString = "SERVER=localhost; PORT=3306; DATABASE=VeloMax; UID=root;PASSWORD=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM COMPANY";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                textBoxResultat.Text += reader.GetValue(i).ToString() + "\t";
                            }
                            textBoxResultat.Text += Environment.NewLine;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération des clients entreprises : " + ex.Message);
                    }
                }
            }
        }
    }
}
