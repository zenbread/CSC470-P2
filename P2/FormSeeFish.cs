using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class FormSeeFish : Form
    {
        private Fish _fish;

        public string decision;

        public FormSeeFish(Fish fish)
        {
            InitializeComponent();
            _fish = fish;
        }

        private void FormSeeFish_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            LoadPicture();
        }

        private void LoadPicture()
        {

            this.pictureBoxFish.Image = _fish.GetResource();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.decision = new Decision(button.Text.Split(' ').First()).GetOutput();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonThrowItBack_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.decision = new Decision(button.Text.Split(' ').First()).GetOutput();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonKeepIt_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.decision = new Decision(button.Text.Split(' ').First()).GetOutput();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
