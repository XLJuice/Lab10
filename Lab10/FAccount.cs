using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class FAccount : Form
    {
        public Account ThePerson;

        public FAccount(Account t)
        {
            ThePerson = t;
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            ThePerson.Name = tB1.Text.Trim();
            ThePerson.Surname = tB2.Text.Trim();
            ThePerson.ID = int.Parse(tB3.Text.Trim());
            ThePerson.Telephone = double.Parse(tB5.Text.Trim());
            ThePerson.Toreturn = tB4.Text.Trim();
            ThePerson.Onhand = tB6.Text.Trim();
            ThePerson.Allow = cB1.Checked;
            DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FPerson_Load(object sender, EventArgs e)
        {
            if (ThePerson != null)
            {
                tB1.Text = ThePerson.Name;
                tB2.Text = ThePerson.Surname;
                tB3.Text = ThePerson.ID.ToString();
                tB5.Text = ThePerson.Telephone.ToString();
                tB4.Text = ThePerson.Toreturn;
                tB6.Text = ThePerson.Onhand;
                cB1.Checked = ThePerson.Allow;
            }
        }
    }
}
