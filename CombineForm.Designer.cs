namespace DiscGolfTurneeApp
{
    partial class CombineForm
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
            this.RoundListBox1 = new System.Windows.Forms.ListBox();
            this.CanCombineLabel = new System.Windows.Forms.Label();
            this.ButtonCombine = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelPlayers1 = new System.Windows.Forms.Label();
            this.LabelPlayers2 = new System.Windows.Forms.Label();
            this.RoundListBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RoundListBox1
            // 
            this.RoundListBox1.FormattingEnabled = true;
            this.RoundListBox1.HorizontalScrollbar = true;
            this.RoundListBox1.Location = new System.Drawing.Point(12, 12);
            this.RoundListBox1.Name = "RoundListBox1";
            this.RoundListBox1.Size = new System.Drawing.Size(279, 108);
            this.RoundListBox1.TabIndex = 0;
            this.RoundListBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CanCombineLabel
            // 
            this.CanCombineLabel.AutoSize = true;
            this.CanCombineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanCombineLabel.Location = new System.Drawing.Point(297, 12);
            this.CanCombineLabel.Name = "CanCombineLabel";
            this.CanCombineLabel.Size = new System.Drawing.Size(218, 20);
            this.CanCombineLabel.TabIndex = 1;
            this.CanCombineLabel.Text = "Select two rounds to combine";
            // 
            // ButtonCombine
            // 
            this.ButtonCombine.Location = new System.Drawing.Point(297, 193);
            this.ButtonCombine.Name = "ButtonCombine";
            this.ButtonCombine.Size = new System.Drawing.Size(122, 41);
            this.ButtonCombine.TabIndex = 2;
            this.ButtonCombine.Text = "Combine";
            this.ButtonCombine.UseVisualStyleBackColor = true;
            this.ButtonCombine.Click += new System.EventHandler(this.ButtonCombine_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LabelPlayers1
            // 
            this.LabelPlayers1.AutoSize = true;
            this.LabelPlayers1.Location = new System.Drawing.Point(301, 36);
            this.LabelPlayers1.Name = "LabelPlayers1";
            this.LabelPlayers1.Size = new System.Drawing.Size(69, 13);
            this.LabelPlayers1.TabIndex = 4;
            this.LabelPlayers1.Text = "Players in 1st";
            // 
            // LabelPlayers2
            // 
            this.LabelPlayers2.AutoSize = true;
            this.LabelPlayers2.Location = new System.Drawing.Point(426, 36);
            this.LabelPlayers2.Name = "LabelPlayers2";
            this.LabelPlayers2.Size = new System.Drawing.Size(73, 13);
            this.LabelPlayers2.TabIndex = 5;
            this.LabelPlayers2.Text = "Players in 2nd";
            // 
            // RoundListBox2
            // 
            this.RoundListBox2.FormattingEnabled = true;
            this.RoundListBox2.HorizontalScrollbar = true;
            this.RoundListBox2.Location = new System.Drawing.Point(12, 126);
            this.RoundListBox2.Name = "RoundListBox2";
            this.RoundListBox2.Size = new System.Drawing.Size(279, 108);
            this.RoundListBox2.TabIndex = 6;
            this.RoundListBox2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CombineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 242);
            this.Controls.Add(this.RoundListBox2);
            this.Controls.Add(this.LabelPlayers2);
            this.Controls.Add(this.LabelPlayers1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonCombine);
            this.Controls.Add(this.CanCombineLabel);
            this.Controls.Add(this.RoundListBox1);
            this.Name = "CombineForm";
            this.Text = "CombineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RoundListBox1;
        private System.Windows.Forms.Label CanCombineLabel;
        private System.Windows.Forms.Button ButtonCombine;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelPlayers1;
        private System.Windows.Forms.Label LabelPlayers2;
        private System.Windows.Forms.ListBox RoundListBox2;
    }
}