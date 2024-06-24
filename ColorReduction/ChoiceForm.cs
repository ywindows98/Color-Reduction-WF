using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorReduction
{
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
        }

        private void RandomReduceButton_Click(object sender, EventArgs e)
        {
            ColorReductionForm newForm = new ColorReductionForm();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpecificPointsReductionForm newForm = new SpecificPointsReductionForm();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
