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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void NewPatient_Click(object sender, EventArgs e)
        {
            NewPatient newPatient = new HosptialSystemUI.NewPatient();
            Hide();
            newPatient.ShowDialog();
            Show();
        }

        private void ExistingPatient_Click(object sender, EventArgs e)
        {
            FindPatient findPatient = new FindPatient();
            Hide();
            findPatient.ShowDialog();
            Show();
        }
    }
}
