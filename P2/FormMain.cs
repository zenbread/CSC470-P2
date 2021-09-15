using System;
using System.Windows.Forms;

namespace P2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            AddRadioToBox();
        }

        private void AddRadioToBox()
        {
            this.groupBox1.Controls.Add(this.radioButtonCrappie);
            this.groupBox1.Controls.Add(this.radioButtonPerch);
            this.groupBox1.Controls.Add(this.radioButtonWalleye);

        }

        private void buttonSeeFish_Click(object sender, EventArgs e)
        {
            string fishSelected = "";
            foreach (RadioButton rb in this.groupBox1.Controls)
            {
                if (rb.Checked)
                {
                    fishSelected = rb.Text.ToString();
                    break;
                }
            }

            FishType type = (FishType)Enum.Parse(typeof(FishType), fishSelected);
            Fish fish = new Fish(type);
            FormSeeFish formFish = new FormSeeFish(fish);
            DialogResult res = formFish.ShowDialog();

            if (res == DialogResult.OK)
                MessageBox.Show("Decision " + formFish.decision, "Decision Result");
            else
                MessageBox.Show("Nothing Selected, User exited.", "Nothing Clicked.");
        }
    }
}
