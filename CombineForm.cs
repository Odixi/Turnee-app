using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscGolfTurneeApp
{
    public partial class CombineForm : Form
    {

        private TurneeData td;
        private const string defaultText = "Select two rounds to combine";

        private TurneeData.RoundData first;
        private TurneeData.RoundData second;

        private bool namesOk = false;
        private bool parsOk = false;

        private TurneeMainForm mf;

        public CombineForm(TurneeData data, TurneeMainForm mainForm)
        {
            td = data;
            mf = mainForm;
            InitializeComponent();

            foreach (TurneeData.RoundData rd in td.data)
            {
                RoundListBox1.Items.Add(rd);
                RoundListBox2.Items.Add(rd);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoundListBox1.SelectedItem != null)
            {
                first = (TurneeData.RoundData)RoundListBox1.SelectedItem;
                LabelPlayers1.Text = "Players in 1st";
                foreach (TurneeData.PlayerScore ps in first.playerScores)
                {
                    LabelPlayers1.Text += "\n" + ps.playerName;
                }
            }
            if (RoundListBox2.SelectedItem != null)
            {
                second = (TurneeData.RoundData)RoundListBox2.SelectedItem;
                LabelPlayers2.Text = "Players in 2nd";
                foreach (TurneeData.PlayerScore ps in second.playerScores)
                {
                    LabelPlayers2.Text += "\n" + ps.playerName;
                }
            }

            if (RoundListBox1.SelectedItem != null && RoundListBox2.SelectedItem != null)
            {
                namesOk = true;
                foreach (TurneeData.PlayerScore ps in first.playerScores)
                {
                    namesOk = second.playerScores.Contains(ps) ? false : namesOk;
                }
                CanCombineLabel.Text = namesOk ? CanCombineLabel.Text : "Same names found!";

                parsOk = first.pars.SequenceEqual(second.pars);
                CanCombineLabel.Text = parsOk ? CanCombineLabel.Text : "Courses don't match!";

                if (parsOk && namesOk)
                {
                    CanCombineLabel.Text = "Rounds can be combined";
                }

            } else
            {
                CanCombineLabel.Text = defaultText;
            }




        }

        private void ButtonCombine_Click(object sender, EventArgs e)
        {
            if (parsOk && namesOk)
            {
                td.CombineRounds(first, second);
                mf.UpdateRounds();
                this.Close();
            } else
            {
                MessageBox.Show("Can't combine!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
