namespace DiscGolfTurneeApp
{
    partial class TurneeMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RoundsListBox = new System.Windows.Forms.ListBox();
            this.ButtonAddRound = new System.Windows.Forms.Button();
            this.ButtonCombineRounds = new System.Windows.Forms.Button();
            this.ButtonDeleteRound = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabTotal = new System.Windows.Forms.TabPage();
            this.TotalGrid = new System.Windows.Forms.DataGridView();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Throws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Par = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromNext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eagles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birdies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bogeys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doubles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Others = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabRound = new System.Windows.Forms.TabPage();
            this.RoundGrid = new System.Windows.Forms.DataGridView();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.roundDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.TabControl.SuspendLayout();
            this.TabTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalGrid)).BeginInit();
            this.TabRound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoundGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // RoundsListBox
            // 
            this.RoundsListBox.FormattingEnabled = true;
            this.RoundsListBox.HorizontalScrollbar = true;
            this.RoundsListBox.Location = new System.Drawing.Point(13, 13);
            this.RoundsListBox.MinimumSize = new System.Drawing.Size(112, 69);
            this.RoundsListBox.Name = "RoundsListBox";
            this.RoundsListBox.Size = new System.Drawing.Size(337, 82);
            this.RoundsListBox.TabIndex = 0;
            this.RoundsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ButtonAddRound
            // 
            this.ButtonAddRound.Location = new System.Drawing.Point(356, 13);
            this.ButtonAddRound.Name = "ButtonAddRound";
            this.ButtonAddRound.Size = new System.Drawing.Size(121, 33);
            this.ButtonAddRound.TabIndex = 1;
            this.ButtonAddRound.Text = "Add Round";
            this.ButtonAddRound.UseVisualStyleBackColor = true;
            this.ButtonAddRound.Click += new System.EventHandler(this.ButtonAddRound_Click);
            // 
            // ButtonCombineRounds
            // 
            this.ButtonCombineRounds.Location = new System.Drawing.Point(356, 49);
            this.ButtonCombineRounds.Name = "ButtonCombineRounds";
            this.ButtonCombineRounds.Size = new System.Drawing.Size(121, 33);
            this.ButtonCombineRounds.TabIndex = 2;
            this.ButtonCombineRounds.Text = "Combine rounds";
            this.ButtonCombineRounds.UseVisualStyleBackColor = true;
            this.ButtonCombineRounds.Click += new System.EventHandler(this.ButtonCombineRounds_Click);
            // 
            // ButtonDeleteRound
            // 
            this.ButtonDeleteRound.Location = new System.Drawing.Point(483, 13);
            this.ButtonDeleteRound.Name = "ButtonDeleteRound";
            this.ButtonDeleteRound.Size = new System.Drawing.Size(121, 33);
            this.ButtonDeleteRound.TabIndex = 3;
            this.ButtonDeleteRound.Text = "Delete Round";
            this.ButtonDeleteRound.UseVisualStyleBackColor = true;
            this.ButtonDeleteRound.Click += new System.EventHandler(this.ButtonDeleteRound_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabTotal);
            this.TabControl.Controls.Add(this.TabRound);
            this.TabControl.Location = new System.Drawing.Point(13, 107);
            this.TabControl.MinimumSize = new System.Drawing.Size(447, 333);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(727, 333);
            this.TabControl.TabIndex = 4;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // TabTotal
            // 
            this.TabTotal.Controls.Add(this.TotalGrid);
            this.TabTotal.Location = new System.Drawing.Point(4, 22);
            this.TabTotal.Name = "TabTotal";
            this.TabTotal.Padding = new System.Windows.Forms.Padding(3);
            this.TabTotal.Size = new System.Drawing.Size(719, 307);
            this.TabTotal.TabIndex = 0;
            this.TabTotal.Text = "Total score";
            this.TabTotal.UseVisualStyleBackColor = true;
            // 
            // TotalGrid
            // 
            this.TotalGrid.AllowUserToAddRows = false;
            this.TotalGrid.AllowUserToDeleteRows = false;
            this.TotalGrid.AllowUserToOrderColumns = true;
            this.TotalGrid.AllowUserToResizeColumns = false;
            this.TotalGrid.AllowUserToResizeRows = false;
            this.TotalGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TotalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.Throws,
            this.Par,
            this.FromLeader,
            this.FromNext,
            this.Eagles,
            this.Birdies,
            this.Pars,
            this.Bogeys,
            this.Doubles,
            this.Others});
            this.TotalGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalGrid.Location = new System.Drawing.Point(3, 3);
            this.TotalGrid.MultiSelect = false;
            this.TotalGrid.Name = "TotalGrid";
            this.TotalGrid.ReadOnly = true;
            this.TotalGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TotalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TotalGrid.Size = new System.Drawing.Size(713, 301);
            this.TotalGrid.TabIndex = 0;
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            this.NameCol.Width = 60;
            // 
            // Throws
            // 
            this.Throws.HeaderText = "Total throws";
            this.Throws.Name = "Throws";
            this.Throws.ReadOnly = true;
            this.Throws.Width = 60;
            // 
            // Par
            // 
            this.Par.HeaderText = "From par";
            this.Par.Name = "Par";
            this.Par.ReadOnly = true;
            this.Par.Width = 60;
            // 
            // FromLeader
            // 
            this.FromLeader.HeaderText = "From leader";
            this.FromLeader.Name = "FromLeader";
            this.FromLeader.ReadOnly = true;
            this.FromLeader.Width = 60;
            // 
            // FromNext
            // 
            this.FromNext.HeaderText = "From next";
            this.FromNext.Name = "FromNext";
            this.FromNext.ReadOnly = true;
            this.FromNext.Width = 60;
            // 
            // Eagles
            // 
            this.Eagles.HeaderText = "Eagles";
            this.Eagles.Name = "Eagles";
            this.Eagles.ReadOnly = true;
            this.Eagles.Width = 60;
            // 
            // Birdies
            // 
            this.Birdies.HeaderText = "Birdies";
            this.Birdies.Name = "Birdies";
            this.Birdies.ReadOnly = true;
            this.Birdies.Width = 60;
            // 
            // Pars
            // 
            this.Pars.HeaderText = "Pars";
            this.Pars.Name = "Pars";
            this.Pars.ReadOnly = true;
            this.Pars.Width = 60;
            // 
            // Bogeys
            // 
            this.Bogeys.HeaderText = "Bogeys";
            this.Bogeys.Name = "Bogeys";
            this.Bogeys.ReadOnly = true;
            this.Bogeys.Width = 60;
            // 
            // Doubles
            // 
            this.Doubles.HeaderText = "Double bogeys";
            this.Doubles.Name = "Doubles";
            this.Doubles.ReadOnly = true;
            this.Doubles.Width = 60;
            // 
            // Others
            // 
            this.Others.HeaderText = "Others";
            this.Others.Name = "Others";
            this.Others.ReadOnly = true;
            this.Others.Width = 60;
            // 
            // TabRound
            // 
            this.TabRound.Controls.Add(this.RoundGrid);
            this.TabRound.Location = new System.Drawing.Point(4, 22);
            this.TabRound.Name = "TabRound";
            this.TabRound.Padding = new System.Windows.Forms.Padding(3);
            this.TabRound.Size = new System.Drawing.Size(703, 307);
            this.TabRound.TabIndex = 1;
            this.TabRound.Text = "Round score";
            this.TabRound.UseVisualStyleBackColor = true;
            // 
            // RoundGrid
            // 
            this.RoundGrid.AllowUserToAddRows = false;
            this.RoundGrid.AllowUserToDeleteRows = false;
            this.RoundGrid.AllowUserToResizeColumns = false;
            this.RoundGrid.AllowUserToResizeRows = false;
            this.RoundGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoundGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.RoundGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoundGrid.DefaultCellStyle = dataGridViewCellStyle35;
            this.RoundGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoundGrid.Location = new System.Drawing.Point(3, 3);
            this.RoundGrid.MultiSelect = false;
            this.RoundGrid.Name = "RoundGrid";
            this.RoundGrid.ReadOnly = true;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoundGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.RoundGrid.RowHeadersWidth = 75;
            this.RoundGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.RoundGrid.Size = new System.Drawing.Size(697, 301);
            this.RoundGrid.TabIndex = 0;
            this.RoundGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabRoundScore_CellContentClick);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(610, 13);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(121, 33);
            this.ButtonLoad.TabIndex = 5;
            this.ButtonLoad.Text = "Load Turnee";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(610, 49);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(121, 33);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "Save Turnee";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // roundDataBindingSource
            // 
            this.roundDataBindingSource.DataSource = typeof(DiscGolfTurneeApp.TurneeData.RoundData);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // TurneeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(743, 440);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ButtonDeleteRound);
            this.Controls.Add(this.ButtonCombineRounds);
            this.Controls.Add(this.ButtonAddRound);
            this.Controls.Add(this.RoundsListBox);
            this.MinimumSize = new System.Drawing.Size(744, 479);
            this.Name = "TurneeMainForm";
            this.Text = "Turnee App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TurneeMainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.TabTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TotalGrid)).EndInit();
            this.TabRound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoundGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox RoundsListBox;
        private System.Windows.Forms.Button ButtonAddRound;
        private System.Windows.Forms.Button ButtonCombineRounds;
        private System.Windows.Forms.Button ButtonDeleteRound;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabTotal;
        private System.Windows.Forms.TabPage TabRound;
        private System.Windows.Forms.DataGridView TotalGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Throws;
        private System.Windows.Forms.DataGridViewTextBoxColumn Par;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eagles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birdies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bogeys;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doubles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Others;
        private System.Windows.Forms.DataGridView RoundGrid;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource roundDataBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

