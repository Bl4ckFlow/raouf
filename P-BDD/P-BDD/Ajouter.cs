using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace P_BDD
{
    public partial class Form1 
    {
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string selectedOption = comboBoxOptions.SelectedItem.ToString();
            if(selectedOption == "Pièces de rechange")
            {
                ProcessPieceDeRechange();
            }
        }

        private void ProcessPieceDeRechange()
        {
            string partNumber = "";
            string partDescription = textBoxPartDescription.Text;
            int catalogueNumber = 0;
            float partPrice = 0;
            DateTime introDate = new DateTime(2024, 4, 25);
            DateTime discontinuationDate = new DateTime(2024, 4, 25);
            int leadTime = 0;
            string spareSupplierSiret = "";

            if (IsValid(textBoxPartNumber.Text)) { partNumber = textBoxPartNumber.Text; }
            if (int.TryParse(textBoxCatalogueNumber.Text, out int catNum)) { catalogueNumber = catNum; }
            if (float.TryParse(textBoxPartPrice.Text, out float floatvalue)) { partPrice = floatvalue; }
            if (DateTime.TryParseExact(textBoxIntroDate.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime introDateValue)) { introDate = introDateValue; }
            if (DateTime.TryParseExact(textBoxDiscontinuationDate.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime discDateValue)) { discontinuationDate = discDateValue; }
            if (int.TryParse(textBoxLeadTime.Text, out int lTime)) { leadTime = lTime; }
            if (CheckIfIntoBDD(textBoxSpareItemSupplierSiret.Text)) { spareSupplierSiret = textBoxSpareItemSupplierSiret.Text; }

            string query = $"INSERT INTO SPARE_PART (part_number, part_description, catalogue_number, part_price, intro_date, discontinuation_date, lead_time, supplier_siret) VALUES ('{partNumber}', '{partDescription}', {catalogueNumber}, {partPrice}, '{introDate.ToString("yyyy-MM-dd")}', '{discontinuationDate.ToString("yyyy-MM-dd")}', {leadTime}, '{spareSupplierSiret}')";

            string connectionString = "SERVER=localhost; PORT=3306; DATABASE=VeloMax; UID=root;PASSWORD=root";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pièce de rechange ajoutée avec succès !");
                        }
                        else
                        {
                            MessageBox.Show("Aucune pièce de rechange n'a été ajoutée.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de l'ajout des pièces de rechange : " + ex.Message);
                    }
                }
            }
        }

        private void ProcessVelo()
        {

        }


        private bool IsValid(string text)
        {
            if (text == null || text.Length < 3)
                return false;

            if (text[0] != 'S' || text[1] != 'P')
                return false;

            for (int i = 2; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i]))
                    return false;
            }

            return true;
        }

        private bool CheckIfIntoBDD(string text)
        {
            string connectionString = "SERVER=localhost; PORT=3306; DATABASE=VeloMax; UID=root;PASSWORD=root";
            string query = "SELECT EXISTS(SELECT 1 FROM SUPPLIER WHERE supplier_siret = @text)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@text", text);

                    try
                    {
                        connection.Open();
                        int result = Convert.ToInt32(command.ExecuteScalar());
                        return result == 1;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération des clients entreprises : " + ex.Message);
                    }
                }
            }

            return false;
        }



    }
}
