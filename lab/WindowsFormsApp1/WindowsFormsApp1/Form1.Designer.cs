namespace WindowsFormsApp1
{
    partial class Form1
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
            this.angajatiDataGriedView = new System.Windows.Forms.DataGridView();
            this.restaurantDataGriedView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.restaurantIdTextField = new System.Windows.Forms.TextBox();
            this.adresaRestaurantTextField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.angajatIdTextField = new System.Windows.Forms.TextBox();
            this.numeAngajatTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.functieTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.salariuTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateAngajatButton = new System.Windows.Forms.Button();
            this.removeAngajatButton = new System.Windows.Forms.Button();
            this.addAngajatButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.angajatiDataGriedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.restaurantDataGriedView)).BeginInit();
            this.SuspendLayout();
            // 
            // angajatiDataGriedView
            // 
            this.angajatiDataGriedView.Location = new System.Drawing.Point(819, 126);
            this.angajatiDataGriedView.Name = "angajatiDataGriedView";
            this.angajatiDataGriedView.Size = new System.Drawing.Size(670, 262);
            this.angajatiDataGriedView.TabIndex = 0;
            this.angajatiDataGriedView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.angajatiDataGriedView_CellClick);
            // 
            // restaurantDataGriedView
            // 
            this.restaurantDataGriedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restaurantDataGriedView.Location = new System.Drawing.Point(37, 126);
            this.restaurantDataGriedView.Name = "restaurantDataGriedView";
            this.restaurantDataGriedView.Size = new System.Drawing.Size(451, 262);
            this.restaurantDataGriedView.TabIndex = 1;
            this.restaurantDataGriedView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.restaurantDataGriedView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(37, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restaurante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(1390, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Angajati";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(37, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Restaurant ID";
            // 
            // restaurantIdTextField
            // 
            this.restaurantIdTextField.Location = new System.Drawing.Point(261, 472);
            this.restaurantIdTextField.Name = "restaurantIdTextField";
            this.restaurantIdTextField.ReadOnly = true;
            this.restaurantIdTextField.Size = new System.Drawing.Size(227, 20);
            this.restaurantIdTextField.TabIndex = 5;
            // 
            // adresaRestaurantTextField
            // 
            this.adresaRestaurantTextField.Location = new System.Drawing.Point(261, 534);
            this.adresaRestaurantTextField.Name = "adresaRestaurantTextField";
            this.adresaRestaurantTextField.ReadOnly = true;
            this.adresaRestaurantTextField.Size = new System.Drawing.Size(227, 20);
            this.adresaRestaurantTextField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(37, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adresa Restaurant";
            // 
            // angajatIdTextField
            // 
            this.angajatIdTextField.Location = new System.Drawing.Point(1113, 446);
            this.angajatIdTextField.Name = "angajatIdTextField";
            this.angajatIdTextField.ReadOnly = true;
            this.angajatIdTextField.Size = new System.Drawing.Size(376, 20);
            this.angajatIdTextField.TabIndex = 9;
            // 
            // numeAngajatTextBox
            // 
            this.numeAngajatTextBox.Location = new System.Drawing.Point(1113, 509);
            this.numeAngajatTextBox.Name = "numeAngajatTextBox";
            this.numeAngajatTextBox.Size = new System.Drawing.Size(376, 20);
            this.numeAngajatTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(819, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nume Angajat";
            // 
            // functieTextBox
            // 
            this.functieTextBox.Location = new System.Drawing.Point(1113, 571);
            this.functieTextBox.Name = "functieTextBox";
            this.functieTextBox.Size = new System.Drawing.Size(376, 20);
            this.functieTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(819, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Functie";
            // 
            // salariuTextBox
            // 
            this.salariuTextBox.Location = new System.Drawing.Point(1113, 631);
            this.salariuTextBox.Name = "salariuTextBox";
            this.salariuTextBox.Size = new System.Drawing.Size(376, 20);
            this.salariuTextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(819, 626);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Salariu";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(819, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Angajat ID";
            // 
            // updateAngajatButton
            // 
            this.updateAngajatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.updateAngajatButton.Location = new System.Drawing.Point(819, 688);
            this.updateAngajatButton.Name = "updateAngajatButton";
            this.updateAngajatButton.Size = new System.Drawing.Size(195, 33);
            this.updateAngajatButton.TabIndex = 19;
            this.updateAngajatButton.Text = "Update";
            this.updateAngajatButton.UseVisualStyleBackColor = true;
            this.updateAngajatButton.Click += new System.EventHandler(this.updateAngajatButton_Click);
            // 
            // removeAngajatButton
            // 
            this.removeAngajatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.removeAngajatButton.Location = new System.Drawing.Point(1294, 688);
            this.removeAngajatButton.Name = "removeAngajatButton";
            this.removeAngajatButton.Size = new System.Drawing.Size(195, 33);
            this.removeAngajatButton.TabIndex = 20;
            this.removeAngajatButton.Text = "Remove";
            this.removeAngajatButton.UseVisualStyleBackColor = true;
            this.removeAngajatButton.Click += new System.EventHandler(this.removeAngajatButton_Click);
            // 
            // addAngajatButton
            // 
            this.addAngajatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.addAngajatButton.Location = new System.Drawing.Point(1060, 688);
            this.addAngajatButton.Name = "addAngajatButton";
            this.addAngajatButton.Size = new System.Drawing.Size(195, 33);
            this.addAngajatButton.TabIndex = 21;
            this.addAngajatButton.Text = "Add";
            this.addAngajatButton.UseVisualStyleBackColor = true;
            this.addAngajatButton.Click += new System.EventHandler(this.addAngajatButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(37, 634);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(560, 73);
            this.errorLabel.TabIndex = 22;
            this.errorLabel.Text = "Aici afisez erorile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 744);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.addAngajatButton);
            this.Controls.Add(this.removeAngajatButton);
            this.Controls.Add(this.updateAngajatButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salariuTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.functieTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numeAngajatTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.angajatIdTextField);
            this.Controls.Add(this.adresaRestaurantTextField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.restaurantIdTextField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restaurantDataGriedView);
            this.Controls.Add(this.angajatiDataGriedView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.angajatiDataGriedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.restaurantDataGriedView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label errorLabel;

        private System.Windows.Forms.Button addAngajatButton;

        private System.Windows.Forms.Button removeAngajatButton;

        private System.Windows.Forms.Button updateAngajatButton;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numeAngajatTextBox;
        private System.Windows.Forms.TextBox functieTextBox;
        private System.Windows.Forms.TextBox salariuTextBox;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adresaRestaurantTextField;
        private System.Windows.Forms.TextBox angajatIdTextField;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox restaurantIdTextField;

        #endregion

        private System.Windows.Forms.DataGridView angajatiDataGriedView;
        private System.Windows.Forms.DataGridView restaurantDataGriedView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}