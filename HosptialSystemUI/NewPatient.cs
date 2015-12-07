using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HosptialSystemUI
{
    public partial class NewPatient : Form
    {

        public NewPatient()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPatient_Load(object sender, EventArgs e)
        {

        }

        private void accept_Click(object sender, EventArgs e)
        {
            HosptialSystem.NewPatient add = new HosptialSystem.NewPatient();
            HosptialSystem.Patient newPatient;
            Button accept = sender as Button;
            newPatient = add.assignPatientID();
            add.assignPatientName(newPatient, firstName.Text, lastName.Text);
            add.assignPatientPhonenumber(newPatient, phoneNumber.Text);
            add.assignPatientAddress(newPatient, address1.Text, address2.Text, city.Text, zipCode.Text, state.Text);
            add.assignPatientBirthDate(newPatient, dateOfBirth.Text);
            add.assignPatientInsuranceInfo(newPatient, insuranceProvider.Text, insuranceMemberID.Text, insuranceGroupID.Text, insuranceExpirationDate.Text);
            add.addNewPatientToDatabase(newPatient);
            MessageBox.Show(newPatient.personFirstName + " " + newPatient.personLastName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
