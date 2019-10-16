using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        Refrigerator refrigerator = new Refrigerator();
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            refrigerator.MaxWeight = Convert.ToDouble(maxWeightTakeTextBox.Text);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            refrigerator.NumberOfItem = Convert.ToInt32(itemTextBox.Text);
            refrigerator.UnitWeight = Convert.ToDouble(weightTextBox.Text);

            currentWeightTextBox.Text = refrigerator.CurrentWeight().ToString();
            remainingWeightTextBox.Text = refrigerator.RemainingWeight().ToString();

        }
    }
}
