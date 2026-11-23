using DemoLibrary;
using System.ComponentModel;

namespace WinFormMiniProject
{
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public PersonEntry()
        {
            InitializeComponent();

            addressesList.DataSource = addresses;
            addressesList.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddressEntry entry = new AddressEntry(this);

            entry.Show();
        }

        public void AddNewAddressComplete(AddressModel address)
        {

        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel 
            { 
                FirstName = firstNameTextBox.Text,
                LastName = lastNameText.Text,
                IsActive = isActive.Checked,
                Addresses = addresses.ToList()
            };
        }
    }
}
