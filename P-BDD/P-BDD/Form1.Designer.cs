using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace P_BDD
{
    public partial class Form1
    {
        private System.Windows.Forms.TextBox textBoxResultat;
        private System.Windows.Forms.ComboBox comboBoxOptions;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;

        //
        private System.Windows.Forms.TextBox textBoxPartNumber;
        private System.Windows.Forms.TextBox textBoxPartDescription;
        private System.Windows.Forms.TextBox textBoxCatalogueNumber;
        private System.Windows.Forms.TextBox textBoxPartPrice;
        private System.Windows.Forms.TextBox textBoxIntroDate;
        private System.Windows.Forms.TextBox textBoxDiscontinuationDate;
        private System.Windows.Forms.TextBox textBoxLeadTime;
        private System.Windows.Forms.TextBox textBoxSpareItemSupplierSiret;

        //
        private System.Windows.Forms.TextBox textBoxBikeId;
        private System.Windows.Forms.TextBox textBoxBikeName;
        private System.Windows.Forms.TextBox textBoxBikeSize;
        private System.Windows.Forms.TextBox textBoxBikePrice;

        //
        private System.Windows.Forms.TextBox textBoxSupplierSiret;
        private System.Windows.Forms.TextBox textBoxSupplierCompanyName;
        private System.Windows.Forms.TextBox textBoxSupplierContact;
        private System.Windows.Forms.TextBox textBoxSupplierAddress;


        private void InitializeComponent()
        {
            this.textBoxResultat = new System.Windows.Forms.TextBox();
            this.comboBoxOptions = new System.Windows.Forms.ComboBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.textBoxPartNumber = new System.Windows.Forms.TextBox();
            this.textBoxPartDescription = new System.Windows.Forms.TextBox();
            this.textBoxCatalogueNumber = new System.Windows.Forms.TextBox();
            this.textBoxPartPrice = new System.Windows.Forms.TextBox();
            this.textBoxIntroDate = new System.Windows.Forms.TextBox();
            this.textBoxDiscontinuationDate = new System.Windows.Forms.TextBox();
            this.textBoxLeadTime = new System.Windows.Forms.TextBox();
            this.textBoxSpareItemSupplierSiret = new System.Windows.Forms.TextBox();
            this.textBoxBikeId = new System.Windows.Forms.TextBox();
            this.textBoxBikeName = new System.Windows.Forms.TextBox();
            this.textBoxBikeSize = new System.Windows.Forms.TextBox();
            this.textBoxBikePrice = new System.Windows.Forms.TextBox();
            this.textBoxSupplierSiret = new System.Windows.Forms.TextBox();
            this.textBoxSupplierCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxSupplierContact = new System.Windows.Forms.TextBox();
            this.textBoxSupplierAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxResultat
            // 
            this.textBoxResultat.Location = new System.Drawing.Point(25, 113);
            this.textBoxResultat.Multiline = true;
            this.textBoxResultat.Name = "textBoxResultat";
            this.textBoxResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultat.Size = new System.Drawing.Size(763, 144);
            this.textBoxResultat.TabIndex = 3;
            // 
            // comboBoxOptions
            // 
            this.comboBoxOptions.FormattingEnabled = true;
            this.comboBoxOptions.Items.AddRange(new object[] {
            "Pièces de rechange",
            "Vélos",
            "Fournisseurs",
            "Commandes",
            "Salariés",
            "Clients particuliers",
            "Clients Entreprise"});
            this.comboBoxOptions.Location = new System.Drawing.Point(25, 50);
            this.comboBoxOptions.Name = "comboBoxOptions";
            this.comboBoxOptions.Size = new System.Drawing.Size(325, 21);
            this.comboBoxOptions.TabIndex = 0;
            this.comboBoxOptions.SelectedIndexChanged += new System.EventHandler(this.comboBoxOptions_SelectedIndexChanged);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(378, 50);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(100, 30);
            this.btnAfficher.TabIndex = 2;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(510, 50);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 30);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(646, 50);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 30);
            this.btnSupprimer.TabIndex = 0;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // textBoxPartNumber
            // 
            this.textBoxPartNumber.Location = new System.Drawing.Point(25, 344);
            this.textBoxPartNumber.Name = "textBoxPartNumber";
            this.textBoxPartNumber.Size = new System.Drawing.Size(150, 20);
            this.textBoxPartNumber.TabIndex = 4;
            this.textBoxPartNumber.Text = "ID";
            // 
            // textBoxPartDescription
            // 
            this.textBoxPartDescription.Location = new System.Drawing.Point(439, 344);
            this.textBoxPartDescription.Name = "textBoxPartDescription";
            this.textBoxPartDescription.Size = new System.Drawing.Size(150, 20);
            this.textBoxPartDescription.TabIndex = 5;
            this.textBoxPartDescription.Text = "Description";
            // 
            // textBoxCatalogueNumber
            // 
            this.textBoxCatalogueNumber.Location = new System.Drawing.Point(646, 344);
            this.textBoxCatalogueNumber.Name = "textBoxCatalogueNumber";
            this.textBoxCatalogueNumber.Size = new System.Drawing.Size(150, 20);
            this.textBoxCatalogueNumber.TabIndex = 6;
            this.textBoxCatalogueNumber.Text = "Numéro de catalogue";
            // 
            // textBoxPartPrice
            // 
            this.textBoxPartPrice.Location = new System.Drawing.Point(646, 394);
            this.textBoxPartPrice.Name = "textBoxPartPrice";
            this.textBoxPartPrice.Size = new System.Drawing.Size(150, 20);
            this.textBoxPartPrice.TabIndex = 7;
            this.textBoxPartPrice.Text = "Prix";
            // 
            // textBoxIntroDate
            // 
            this.textBoxIntroDate.Location = new System.Drawing.Point(25, 394);
            this.textBoxIntroDate.Name = "textBoxIntroDate";
            this.textBoxIntroDate.Size = new System.Drawing.Size(150, 20);
            this.textBoxIntroDate.TabIndex = 8;
            this.textBoxIntroDate.Text = "Date d\'introduction";
            // 
            // textBoxDiscontinuationDate
            // 
            this.textBoxDiscontinuationDate.Location = new System.Drawing.Point(224, 344);
            this.textBoxDiscontinuationDate.Name = "textBoxDiscontinuationDate";
            this.textBoxDiscontinuationDate.Size = new System.Drawing.Size(150, 20);
            this.textBoxDiscontinuationDate.TabIndex = 9;
            this.textBoxDiscontinuationDate.Text = "Date de Discontinuation";
            // 
            // textBoxLeadTime
            // 
            this.textBoxLeadTime.Location = new System.Drawing.Point(439, 394);
            this.textBoxLeadTime.Name = "textBoxLeadTime";
            this.textBoxLeadTime.Size = new System.Drawing.Size(150, 20);
            this.textBoxLeadTime.TabIndex = 10;
            this.textBoxLeadTime.Text = "Temps d\'approvisionnement";
            // 
            // textBoxSpareItemSupplierSiret
            // 
            this.textBoxSpareItemSupplierSiret.Location = new System.Drawing.Point(224, 394);
            this.textBoxSpareItemSupplierSiret.Name = "textBoxSpareItemSupplierSiret";
            this.textBoxSpareItemSupplierSiret.Size = new System.Drawing.Size(150, 20);
            this.textBoxSpareItemSupplierSiret.TabIndex = 11;
            this.textBoxSpareItemSupplierSiret.Text = "Fournisseur";
            // 
            // textBoxBikeId
            // 
            this.textBoxBikeId.Location = new System.Drawing.Point(25, 344);
            this.textBoxBikeId.Name = "textBoxBikeId";
            this.textBoxBikeId.Text = "Bike_ID";
            this.textBoxBikeId.Size = new System.Drawing.Size(150, 20);
            this.textBoxBikeId.TabIndex = 12;
            // 
            // textBoxBikeName
            // 
            this.textBoxBikeName.Location = new System.Drawing.Point(224, 344);
            this.textBoxBikeName.Name = "textBoxBikeName";
            this.textBoxBikeName.Text = "Bike Name";
            this.textBoxBikeName.Size = new System.Drawing.Size(150, 20);
            this.textBoxBikeName.TabIndex = 13;
            // 
            // textBoxBikeSize
            // 
            this.textBoxBikeSize.Location = new System.Drawing.Point(646, 344);
            this.textBoxBikeSize.Name = "textBoxBikeSize";
            this.textBoxBikeSize.Text = "Size";
            this.textBoxBikeSize.Size = new System.Drawing.Size(150, 20);
            this.textBoxBikeSize.TabIndex = 14;
            // 
            // textBoxBikePrice
            // 
            this.textBoxBikePrice.Location = new System.Drawing.Point(439, 344);
            this.textBoxBikePrice.Name = "textBoxBikePrice";
            this.textBoxBikePrice.Text = "Price";
            this.textBoxBikePrice.Size = new System.Drawing.Size(150, 20);
            this.textBoxBikePrice.TabIndex = 15;
            // 
            // textBoxSupplierSiret
            // 
            this.textBoxSupplierSiret.Location = new System.Drawing.Point(25, 344);
            this.textBoxSupplierSiret.Name = "textBoxSupplierSiret";
            this.textBoxSupplierSiret.Text = "Supplier Name";
            this.textBoxSupplierSiret.Size = new System.Drawing.Size(150, 20);
            this.textBoxSupplierSiret.TabIndex = 16;
            // 
            // textBoxSupplierCompanyName
            // 
            this.textBoxSupplierCompanyName.Location = new System.Drawing.Point(25, 344);
            this.textBoxSupplierCompanyName.Name = "textBoxSupplierCompanyName";
            this.textBoxSupplierCompanyName.Text = "Company Name";
            this.textBoxSupplierCompanyName.Size = new System.Drawing.Size(150, 20);
            this.textBoxSupplierCompanyName.TabIndex = 17;
            // 
            // textBoxSupplierContact
            // 
            this.textBoxSupplierContact.Location = new System.Drawing.Point(224, 344);
            this.textBoxSupplierContact.Name = "textBoxSupplierContact";
            this.textBoxSupplierContact.Text = "Supplier Contact";
            this.textBoxSupplierContact.Size = new System.Drawing.Size(150, 20);
            this.textBoxSupplierContact.TabIndex = 18;
            // 
            // textBoxSupplierAddress
            // 
            this.textBoxSupplierAddress.Location = new System.Drawing.Point(439, 344);
            this.textBoxSupplierAddress.Name = "textBoxSupplierAddress";
            this.textBoxSupplierAddress.Text = "Supplier Adress";
            this.textBoxSupplierAddress.Size = new System.Drawing.Size(150, 20);
            this.textBoxSupplierAddress.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 720);
            this.Controls.Add(this.textBoxSpareItemSupplierSiret);
            this.Controls.Add(this.textBoxLeadTime);
            this.Controls.Add(this.textBoxDiscontinuationDate);
            this.Controls.Add(this.textBoxIntroDate);
            this.Controls.Add(this.textBoxPartPrice);
            this.Controls.Add(this.textBoxCatalogueNumber);
            this.Controls.Add(this.textBoxPartDescription);
            this.Controls.Add(this.textBoxPartNumber);
            this.Controls.Add(this.textBoxBikeId);
            this.Controls.Add(this.textBoxBikeName);
            this.Controls.Add(this.textBoxBikeSize);
            this.Controls.Add(this.textBoxBikePrice);
            this.Controls.Add(this.textBoxSupplierSiret);
            this.Controls.Add(this.textBoxSupplierCompanyName);
            this.Controls.Add(this.textBoxSupplierContact);
            this.Controls.Add(this.textBoxSupplierAddress);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.comboBoxOptions);
            this.Controls.Add(this.textBoxResultat);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        



        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Code pour le bouton Supprimer
        }

    }
}
