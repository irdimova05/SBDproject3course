namespace SBDproject
{
    partial class Edit_Property
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
            this.editButton = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.ComboBox();
            this.city = new System.Windows.Forms.ComboBox();
            this.neighborhood = new System.Windows.Forms.ComboBox();
            this.facing = new System.Windows.Forms.ComboBox();
            this.radioSale = new System.Windows.Forms.RadioButton();
            this.radioRent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 36);
            this.panel1.TabIndex = 9;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(915, 469);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 26);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(598, 101);
            this.type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(160, 24);
            this.type.TabIndex = 11;
            // 
            // city
            // 
            this.city.FormattingEnabled = true;
            this.city.Location = new System.Drawing.Point(598, 157);
            this.city.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(160, 24);
            this.city.TabIndex = 12;
            this.city.SelectedIndexChanged += new System.EventHandler(this.OnSelectionChanged);
            // 
            // neighborhood
            // 
            this.neighborhood.FormattingEnabled = true;
            this.neighborhood.Location = new System.Drawing.Point(598, 224);
            this.neighborhood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.neighborhood.Name = "neighborhood";
            this.neighborhood.Size = new System.Drawing.Size(160, 24);
            this.neighborhood.TabIndex = 13;
            // 
            // facing
            // 
            this.facing.FormattingEnabled = true;
            this.facing.Location = new System.Drawing.Point(598, 293);
            this.facing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.facing.Name = "facing";
            this.facing.Size = new System.Drawing.Size(160, 24);
            this.facing.TabIndex = 14;
            // 
            // radioSale
            // 
            this.radioSale.AutoSize = true;
            this.radioSale.Location = new System.Drawing.Point(598, 421);
            this.radioSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioSale.Name = "radioSale";
            this.radioSale.Size = new System.Drawing.Size(76, 20);
            this.radioSale.TabIndex = 16;
            this.radioSale.TabStop = true;
            this.radioSale.Text = "For Sale";
            this.radioSale.UseVisualStyleBackColor = true;
            // 
            // radioRent
            // 
            this.radioRent.AutoSize = true;
            this.radioRent.Location = new System.Drawing.Point(598, 465);
            this.radioRent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioRent.Name = "radioRent";
            this.radioRent.Size = new System.Drawing.Size(76, 20);
            this.radioRent.TabIndex = 17;
            this.radioRent.TabStop = true;
            this.radioRent.Text = "For Rent";
            this.radioRent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Choose the type of the property:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Choose the city of the property:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Chose the neighborhood of the property based on the city:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Choose the facing of the property:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 451);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Set the price for the property:";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(598, 360);
            this.price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(160, 22);
            this.price.TabIndex = 25;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Select the id of the property:";
            // 
            // id
            // 
            this.id.FormattingEnabled = true;
            this.id.Location = new System.Drawing.Point(598, 51);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(160, 24);
            this.id.TabIndex = 27;
            // 
            // Edit_Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(180)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1043, 510);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioRent);
            this.Controls.Add(this.radioSale);
            this.Controls.Add(this.facing);
            this.Controls.Add(this.neighborhood);
            this.Controls.Add(this.city);
            this.Controls.Add(this.type);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Edit_Property";
            this.Text = "Edit_Property";
            this.Load += new System.EventHandler(this.Edit_Property_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.ComboBox neighborhood;
        private System.Windows.Forms.ComboBox facing;
        private System.Windows.Forms.RadioButton radioSale;
        private System.Windows.Forms.RadioButton radioRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox id;
    }
}