using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rae_Kenneth___TugasWeek4
{
    public partial class FormTampilan : Form
    {
        public FormTampilan(string formString)
        {
            InitializeComponent();
            textBoxName.Text = formString;
            textBoxAddress.Text = formString;
            textBoxPhone.Text = formString;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPenambahan form = new FormPenambahan();
            form.ShowDialog();
        }
    }
}
