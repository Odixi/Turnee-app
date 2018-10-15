using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;

namespace DiscGolfTurneeApp
{
    public partial class TurneeMainForm : Form
    {
        private bool unsavedChanges = false;
        TurneeData td;
        public TurneeMainForm()
        {
            td = new TurneeData();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Change round score table
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoundGrid.Rows.Clear();
            RoundGrid.Columns.Clear();
            RoundGrid.Refresh();
            TurneeData.RoundData roundData = ((TurneeData.RoundData)RoundsListBox.SelectedItem);
            RoundGrid.ColumnCount = roundData.playerScores.Length + 1;
            var playerTotalScores = new int[roundData.playerScores.Length+1];

            // Add player columns
            for (int i = 0; i < RoundGrid.ColumnCount; i++)
            {
                RoundGrid.Columns[i].HeaderText = i == 0 ? "Par" : roundData.playerScores[i-1].playerName;
                RoundGrid.Columns[i].Width = 60;
                RoundGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Add scores
            var row = new string[roundData.playerScores.Length+1];
            for (int i = 0; i < roundData.pars.Length; i++)
            {
                for (int j = 0; j < roundData.playerScores.Length; j++)
                {
                    row[j+1] = roundData.playerScores[j].scores[i].ToString();
                    playerTotalScores[j+1] += roundData.playerScores[j].scores[i];
                }
                row[0] = roundData.pars[i].ToString();
                playerTotalScores[0] += roundData.pars[i];
                RoundGrid.Rows.Add(row);
                RoundGrid.Rows[i].HeaderCell.Value = (i+1).ToString();
            }

            // Add total score
            for (int i = 0; i < RoundGrid.ColumnCount; i++)
            {
                var sign = (playerTotalScores[i] - playerTotalScores[0]) >= 0 ? "+" : "";
                row[i] = i == 0 ?
                    playerTotalScores[0].ToString() :
                    playerTotalScores[i].ToString() + " (" + sign + (playerTotalScores[i] - playerTotalScores[0]).ToString() + ")";
            }
            RoundGrid.Rows.Add(row);
            RoundGrid.Rows[RoundGrid.Rows.Count - 1].HeaderCell.Value = "Total";

            for (int c = 1; c < RoundGrid.Columns.Count; c++)
            {
                for (int r = 0; r < RoundGrid.Rows.Count -1; r++)
                {
                    switch (int.Parse(RoundGrid.Rows[r].Cells[c].Value.ToString()) - int.Parse(RoundGrid.Rows[r].Cells[0].Value.ToString()))
                    {

                        case -3:
                            RoundGrid.Rows[r].Cells[c].Style.BackColor = Color.White;
                            break;

                        case -2:
                            RoundGrid.Rows[r].Cells[c].Style.BackColor = Color.White;
                            break;

                        case -1:
                            RoundGrid.Rows[r].Cells[c].Style.BackColor = Color.DodgerBlue;
                            break;

                        case 0:
                            RoundGrid.Rows[r].Cells[c].Style.BackColor = Color.Lime;
                            break;

                        case 1:
                            RoundGrid.Rows[r].Cells[c].Style.BackColor = Color.Yellow;
                            break;

                        case 2:
                            RoundGrid.Rows[r].Cells[c].Style.BackColor = Color.DarkOrange;
                            break;

                        default:
                            RoundGrid.Rows[r].Cells[c].Style.BackColor = Color.Red;
                            break;
                    }
                }
            }
            UpdateComponentSizes();
        }

        public void UpdateComponentSizes()
        {
            if (TabControl.SelectedTab.Name == "TabRound")
            {
                // Tabs 697; 301 - 711; 333
                TabControl.Height = RoundGrid.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + RoundGrid.ColumnHeadersHeight + 34;
                TabControl.Width = RoundGrid.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + RoundGrid.RowHeadersWidth + 24;
                // Grids
                RoundGrid.Height = TabControl.Height;
                RoundGrid.Width = TabControl.Width;
                // Form
                this.Width = TabControl.Width + 31; // 742 , 711
                this.Height = TabControl.Height + 144; // 477 , 333
            }
            else
            {
                // Tabs
                TabControl.Height = TotalGrid.Rows.GetRowsHeight(DataGridViewElementStates.None) + TotalGrid.ColumnHeadersHeight + 34;
                TabControl.Width = TotalGrid.Columns.GetColumnsWidth(DataGridViewElementStates.None) + TotalGrid.RowHeadersWidth + 24;
                // Grids
                TotalGrid.Height = TabControl.Height;
                TotalGrid.Width = TabControl.Width;
                // Form
                this.Width = TabControl.Width + 31; // 742 , 711
                this.Height = TabControl.Height + 144; // 477 , 333
            }

        }

        /// <summary>
        /// Update total scoreboard. Called after adding / removing / loading rounds
        /// </summary>
        public void UpdateTotalScore()
        {
            // 0 names       // 6 Birdies
            // 1 throws      // 7 Par
            // 2 from par    // 8 Bogeys
            // 3 from leader // 9 Double bogeys
            // 4 from next   // 10 others
            // 5 Eagles

            TotalGrid.Rows.Clear();
            TotalGrid.Refresh();

            List<string> names = new List<string>();
            List<int> throws = new List<int>();
            int par = 0;
            List<int> eagles = new List<int>();
            List<int> birdies = new List<int>();
            List<int> pars = new List<int>();
            List<int> bogeys = new List<int>();
            List<int> doublesBogeys = new List<int>();
            List<int> others = new List<int>();
            int stages = td.data.Select(x => x.pars.Length).Sum();

            TotalGrid.Columns[0].HeaderText = td.data.Count + " | " + stages.ToString() + " Name";

            int i; // current player index

            foreach (TurneeData.RoundData rd in RoundsListBox.Items)
            {
                par += rd.pars.Sum();
                // Players on round
                for (int p = 0; p < rd.playerScores.Length; p++)
                {
                    var indexOf = names.IndexOf(rd.playerScores[p].playerName);
                    if (indexOf != -1)
                    {
                        i = indexOf;
                    }
                    else
                    {
                        Debug.WriteLine("." + rd.playerScores[p].playerName + ".");
                        names.Add(rd.playerScores[p].playerName);
                        throws.Add(0);
                        eagles.Add(0);
                        birdies.Add(0);
                        pars.Add(0);
                        bogeys.Add(0);
                        doublesBogeys.Add(0);
                        others.Add(0);
                        i = names.Count - 1;
                    }
                    // stages (väylät)
                    for (int v = 0; v < rd.pars.Length; v++)
                    {
                        
                        throws[i] += rd.playerScores[p].scores[v];
                        switch (rd.playerScores[p].scores[v] - rd.pars[v])
                        {
                            case -2:
                                eagles[i]++;
                                break;

                            case -1:
                                birdies[i]++;
                                break;

                            case 0:
                                pars[i]++;
                                break;

                            case 1:
                                bogeys[i]++;
                                break;

                            case 2:
                                doublesBogeys[i]++;
                                break;

                            default:
                                others[i]++;
                                break;
                        } // switch
                    } // for stages
                } // for players
            } // for rounds

            for (i=0; i < names.Count; i++)
            {
               var query = throws.Where(x => x < throws[i]);
               int nextLowest = query.Any() || query.Count() > 1 ? query.Max() : throws[i];
                TotalGrid.Rows.Add(new string[] {
                    names[i],
                    throws[i].ToString(),
                    (throws[i] - par).ToString(),
                    (throws[i] - throws.Min()).ToString(),
                    (throws[i] - nextLowest).ToString(),
                    eagles[i].ToString() + " (" + ((float)eagles[i]*100 /(float)stages).ToString("0.0") + "%)" ,
                    birdies[i].ToString() + " (" + ((float)birdies[i]*100 /(float)stages).ToString("0.0") + "%)",
                    pars[i].ToString() + " (" + ((float)pars[i]*100 /(float)stages).ToString("0.0") + "%)",
                    bogeys[i].ToString() + " (" + ((float)bogeys[i]*100 /(float)stages).ToString("0.0") + "%)",
                    doublesBogeys[i].ToString() + " (" + ((float)doublesBogeys[i]*100 /(float)stages).ToString("0.0") + "%)",
                    others[i].ToString() + " (" + ((float)others[i]*100 /(float)stages).ToString("0.0") + "%)",
                });
            }

            UpdateComponentSizes();
        }

        public void UpdateRounds()
        {
            RoundsListBox.Items.Clear();
            foreach (TurneeData.RoundData rd in td.data)
            {
                RoundsListBox.Items.Add(rd);
            }
  
            UpdateTotalScore();
        }

        private void ButtonAddRound_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    td.AddRoundFromFile(openFileDialog1.FileName);
                    UpdateRounds();
                    unsavedChanges = true;
                }
                catch (Exception exception)
                {
                    // Do nothing
                }
            }
        }

        private void TabRoundScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComponentSizes();
        }

        private void ButtonDeleteRound_Click(object sender, EventArgs e)
        {
            if (RoundsListBox.SelectedItem == null)
            {
                MessageBox.Show("Nothing selected");
                return;
            }

            var dialogResult = MessageBox.Show(this, "Are you sure you want to delete " + RoundsListBox.Text + "?", "Delete",MessageBoxButtons.YesNo ,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = td.DeleteRound((TurneeData.RoundData)RoundsListBox.SelectedItem);
                if (!result)
                {
                    MessageBox.Show("Could not remove selected item");
                }
                unsavedChanges = true;
                UpdateRounds();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    TurneeData.WriteToXmlFile<TurneeData>(saveFileDialog1.FileName, td, false);
                    unsavedChanges = false;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("There was an error saving the file: " + exception.GetType().ToString());
                }
            }
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    td = TurneeData.ReadFromXmlFile<TurneeData>(openFileDialog1.FileName);
                    unsavedChanges = false;
                    UpdateRounds();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("There was an error loading the file: " + exception.GetType().ToString());
                }
            }
        }

        private void TurneeMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unsavedChanges)
            {
                var dialogResult = MessageBox.Show(this, "You have unsaved changes. Do you want to save?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    ButtonSave_Click(this, EventArgs.Empty);
                }
            }
        }

        private void ButtonCombineRounds_Click(object sender, EventArgs e)
        {
            CombineForm cf = new CombineForm(td, this);
            cf.ShowDialog();
        }
    }
}
