using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_BDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxOptions.SelectedIndex = 0;
        }

        private void comboBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxOptions.SelectedItem.ToString();
            ShowSparePartControls(selectedItem);
            ShowBikeControls(selectedItem);
            ShowSupplierControls(selectedItem);
            
        }

        private void ShowSparePartControls(string listed_Item)
        {
            bool choice = false;
            if (listed_Item == "Pièces de rechange")
            {
                choice = true;
                textBoxPartNumber.Visible = choice;
                textBoxPartDescription.Visible = choice;
                textBoxCatalogueNumber.Visible = choice;
                textBoxPartPrice.Visible = choice;
                textBoxIntroDate.Visible = choice;
                textBoxDiscontinuationDate.Visible = choice;
                textBoxLeadTime.Visible = choice;
                textBoxSpareItemSupplierSiret.Visible = choice;
            }
            else
            {
                textBoxPartNumber.Visible = choice;
                textBoxPartDescription.Visible = choice;
                textBoxCatalogueNumber.Visible = choice;
                textBoxPartPrice.Visible = choice;
                textBoxIntroDate.Visible = choice;
                textBoxDiscontinuationDate.Visible = choice;
                textBoxLeadTime.Visible = choice;
                textBoxSpareItemSupplierSiret.Visible = choice;
            }
        }

        private void ShowBikeControls(string listed_Item)
        {
            bool choice = false;
            if (listed_Item == "Vélos")
            {
                choice = true;
                textBoxBikeId.Visible = choice;
                textBoxBikeName.Visible = choice;
                textBoxBikePrice.Visible = choice;
                textBoxBikeSize.Visible = choice;
            }
            else
            {
                textBoxBikeId.Visible = choice;
                textBoxBikeName.Visible = choice;
                textBoxBikePrice.Visible = choice;
                textBoxBikeSize.Visible = choice;
            }
        }

        private void ShowSupplierControls(string listed_Item) 
        {
            bool choice = false;
            if (listed_Item == "Fournisseurs")
            {
                choice = true;
                textBoxSupplierSiret.Visible = choice;
                textBoxSupplierContact.Visible = choice;
                textBoxSupplierCompanyName.Visible = choice;
                textBoxSupplierAddress.Visible = choice;
            }
            else
            {
                textBoxSupplierSiret.Visible = choice;
                textBoxSupplierContact.Visible = choice;
                textBoxSupplierCompanyName.Visible = choice;
                textBoxSupplierAddress.Visible = choice;
            }
        }

    }
}
