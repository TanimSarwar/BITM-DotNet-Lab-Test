namespace LabTest1QS_B
{
    partial class EmailKeeper
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
            this.button1 = new System.Windows.Forms.Button();
            this.searcButton = new System.Windows.Forms.Button();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addListView = new System.Windows.Forms.ListView();
            this.searchListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searcButton
            // 
            this.searcButton.Location = new System.Drawing.Point(661, 72);
            this.searcButton.Name = "searcButton";
            this.searcButton.Size = new System.Drawing.Size(86, 31);
            this.searcButton.TabIndex = 1;
            this.searcButton.Text = "Search";
            this.searcButton.UseVisualStyleBackColor = true;
            this.searcButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(177, 22);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(183, 29);
            this.addTextBox.TabIndex = 2;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(564, 25);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(183, 29);
            this.searchTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email to add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email to search";
            // 
            // addListView
            // 
            this.addListView.Location = new System.Drawing.Point(60, 125);
            this.addListView.Name = "addListView";
            this.addListView.Size = new System.Drawing.Size(300, 215);
            this.addListView.TabIndex = 6;
            this.addListView.UseCompatibleStateImageBehavior = false;
            this.addListView.View = System.Windows.Forms.View.List;
            // 
            // searchListView
            // 
            this.searchListView.Location = new System.Drawing.Point(422, 125);
            this.searchListView.Name = "searchListView";
            this.searchListView.Size = new System.Drawing.Size(325, 215);
            this.searchListView.TabIndex = 7;
            this.searchListView.UseCompatibleStateImageBehavior = false;
            this.searchListView.View = System.Windows.Forms.View.List;
            // 
            // EmailKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 383);
            this.Controls.Add(this.searchListView);
            this.Controls.Add(this.addListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.searcButton);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmailKeeper";
            this.Text = "Email Keeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button searcButton;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView addListView;
        private System.Windows.Forms.ListView searchListView;
    }
}

