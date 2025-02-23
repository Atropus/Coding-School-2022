﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShopLibrary;

namespace Session_11
{
    public partial class AddNewPetForm : Form
    {
        private PetShopManager _petShop;
        
        

        public AddNewPetForm(PetShopManager petShopManager)
        {
            InitializeComponent();
            
            _petShop = petShopManager;
            this.CenterToScreen();
        }

        private void AddNewPetForm_Load(object sender, EventArgs e)
        {
            cmbAnimalType.DataSource = Enum.GetValues(typeof(AnimalType));
            cmbAnimalType.SelectedIndex = -1;
            cmbAnimalType.Text = "Please choose a type";
            cmbStatus.DataSource = Enum.GetValues(typeof(PetStatus));
            cmbStatus.SelectedIndex = -1;
            cmbStatus.Text = "Please choose a status";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbAnimalType.SelectedIndex < 0 || txtBreed.Text == String.Empty || cmbStatus.SelectedIndex < 0 || txtPrice.Text == String.Empty || txtCost.Text == String.Empty) return;
            int animalTypeIndex = cmbAnimalType.SelectedIndex;
            string breed = txtBreed.Text;
            int statusIndex = cmbStatus.SelectedIndex;
            decimal price = Convert.ToDecimal(txtPrice.Text.Split()[0]);
            decimal cost = Convert.ToDecimal(txtCost.Text.Split()[0]);

            if(animalTypeIndex >= 0 && breed != "" && statusIndex >= 0  && price>= 0 && cost >=0) 
            {
                if (price >= cost)
                {
                    AnimalType animalType = (AnimalType)animalTypeIndex;
                    PetStatus status = (PetStatus)statusIndex;
                    

                    Pet pet = new Pet()
                    {
                        AnimalType = animalType,
                        Breed = breed,
                        HealthStatus = status,
                        Cost = cost,
                        Price = price
                    };


                    
                    _petShop.Add(pet);
                    //_petShop.Save();
                    
                }
                else
                {
                    MessageBox.Show("Check again the price and cost ");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");

            }
            MessageBox.Show("Saved");

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void txtPrice_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
