namespace SBDproject
{
    partial class Real_Estate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.propertiesView = new System.Windows.Forms.DataGridView();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.NeighborhoodBox = new System.Windows.Forms.ComboBox();
            this.FacingBox = new System.Windows.Forms.ComboBox();
            this.PriceBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.myPropertiesButton = new System.Windows.Forms.Button();
            this.saleCheckbox = new System.Windows.Forms.CheckBox();
            this.rentCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 28);
            this.panel1.TabIndex = 7;
            // 
            // propertiesView
            // 
            this.propertiesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertiesView.Location = new System.Drawing.Point(12, 155);
            this.propertiesView.Name = "propertiesView";
            this.propertiesView.Size = new System.Drawing.Size(758, 247);
            this.propertiesView.TabIndex = 8;
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(12, 61);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(121, 21);
            this.typeBox.TabIndex = 9;
            // 
            // cityBox
            // 
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(139, 60);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 21);
            this.cityBox.TabIndex = 10;
            this.cityBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectionChanged);
            // 
            // NeighborhoodBox
            // 
            this.NeighborhoodBox.FormattingEnabled = true;
            this.NeighborhoodBox.Location = new System.Drawing.Point(266, 60);
            this.NeighborhoodBox.Name = "NeighborhoodBox";
            this.NeighborhoodBox.Size = new System.Drawing.Size(121, 21);
            this.NeighborhoodBox.TabIndex = 11;
            // 
            // FacingBox
            // 
            this.FacingBox.FormattingEnabled = true;
            this.FacingBox.Location = new System.Drawing.Point(393, 61);
            this.FacingBox.Name = "FacingBox";
            this.FacingBox.Size = new System.Drawing.Size(121, 21);
            this.FacingBox.TabIndex = 12;
            // 
            // PriceBox
            // 
            this.PriceBox.FormattingEnabled = true;
            this.PriceBox.Location = new System.Drawing.Point(520, 61);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(121, 21);
            this.PriceBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Neighborhood";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Facing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(290, 109);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // myPropertiesButton
            // 
            this.myPropertiesButton.Location = new System.Drawing.Point(371, 109);
            this.myPropertiesButton.Name = "myPropertiesButton";
            this.myPropertiesButton.Size = new System.Drawing.Size(83, 23);
            this.myPropertiesButton.TabIndex = 22;
            this.myPropertiesButton.Text = "My properties";
            this.myPropertiesButton.UseVisualStyleBackColor = true;
            this.myPropertiesButton.Click += new System.EventHandler(this.myPropertiesButton_Click);
            // 
            // saleCheckbox
            // 
            this.saleCheckbox.AutoSize = true;
            this.saleCheckbox.Location = new System.Drawing.Point(672, 47);
            this.saleCheckbox.Name = "saleCheckbox";
            this.saleCheckbox.Size = new System.Drawing.Size(65, 17);
            this.saleCheckbox.TabIndex = 23;
            this.saleCheckbox.Text = "For Sale";
            this.saleCheckbox.UseVisualStyleBackColor = true;
            // 
            // rentCheckbox
            // 
            this.rentCheckbox.AutoSize = true;
            this.rentCheckbox.Location = new System.Drawing.Point(672, 70);
            this.rentCheckbox.Name = "rentCheckbox";
            this.rentCheckbox.Size = new System.Drawing.Size(67, 17);
            this.rentCheckbox.TabIndex = 24;
            this.rentCheckbox.Text = "For Rent";
            this.rentCheckbox.UseVisualStyleBackColor = true;
            // 
            // Real_Estate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(180)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(782, 414);
            this.Controls.Add(this.rentCheckbox);
            this.Controls.Add(this.saleCheckbox);
            this.Controls.Add(this.myPropertiesButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.FacingBox);
            this.Controls.Add(this.NeighborhoodBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.propertiesView);
            this.Controls.Add(this.panel1);
            this.Name = "Real_Estate";
            this.Text = "Real_Estate";
            this.Load += new System.EventHandler(this.Real_Estate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertiesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView propertiesView;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.ComboBox NeighborhoodBox;
        private System.Windows.Forms.ComboBox FacingBox;
        private System.Windows.Forms.ComboBox PriceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button myPropertiesButton;
        private System.Windows.Forms.CheckBox saleCheckbox;
        private System.Windows.Forms.CheckBox rentCheckbox;
    }
}