namespace DEMO_PROJET_07449.GUI.Views;

partial class PatientMultiView {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.lblTextId = new System.Windows.Forms.Label();
            this.lblTextFirstName = new System.Windows.Forms.Label();
            this.lblTextLastName = new System.Windows.Forms.Label();
            this.lblTextHealthCard = new System.Windows.Forms.Label();
            this.lblTextDateCreated = new System.Windows.Forms.Label();
            this.lvlValueId = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.healthCardTextBox = new System.Windows.Forms.TextBox();
            this.dateCreatedDTPicker = new System.Windows.Forms.DateTimePicker();
            this.actionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextId
            // 
            this.lblTextId.Location = new System.Drawing.Point(12, 40);
            this.lblTextId.Name = "lblTextId";
            this.lblTextId.Size = new System.Drawing.Size(150, 25);
            this.lblTextId.TabIndex = 0;
            this.lblTextId.Text = "ID:";
            this.lblTextId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTextFirstName
            // 
            this.lblTextFirstName.Location = new System.Drawing.Point(12, 80);
            this.lblTextFirstName.Name = "lblTextFirstName";
            this.lblTextFirstName.Size = new System.Drawing.Size(150, 25);
            this.lblTextFirstName.TabIndex = 1;
            this.lblTextFirstName.Text = "First name:";
            this.lblTextFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTextLastName
            // 
            this.lblTextLastName.Location = new System.Drawing.Point(12, 120);
            this.lblTextLastName.Name = "lblTextLastName";
            this.lblTextLastName.Size = new System.Drawing.Size(150, 25);
            this.lblTextLastName.TabIndex = 2;
            this.lblTextLastName.Text = "Last name:";
            this.lblTextLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTextHealthCard
            // 
            this.lblTextHealthCard.Location = new System.Drawing.Point(12, 160);
            this.lblTextHealthCard.Name = "lblTextHealthCard";
            this.lblTextHealthCard.Size = new System.Drawing.Size(150, 25);
            this.lblTextHealthCard.TabIndex = 3;
            this.lblTextHealthCard.Text = "Health card number:";
            this.lblTextHealthCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTextDateCreated
            // 
            this.lblTextDateCreated.Location = new System.Drawing.Point(12, 200);
            this.lblTextDateCreated.Name = "lblTextDateCreated";
            this.lblTextDateCreated.Size = new System.Drawing.Size(150, 25);
            this.lblTextDateCreated.TabIndex = 4;
            this.lblTextDateCreated.Text = "Creation date:";
            this.lblTextDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvlValueId
            // 
            this.lvlValueId.AutoSize = true;
            this.lvlValueId.Location = new System.Drawing.Point(168, 42);
            this.lvlValueId.Name = "lvlValueId";
            this.lvlValueId.Size = new System.Drawing.Size(88, 20);
            this.lvlValueId.TabIndex = 5;
            this.lvlValueId.Text = "placeholder";
            this.lvlValueId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(168, 80);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PlaceholderText = "First name";
            this.firstNameTextBox.Size = new System.Drawing.Size(300, 27);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(168, 119);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PlaceholderText = "Last name";
            this.lastNameTextBox.Size = new System.Drawing.Size(300, 27);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // healthCardTextBox
            // 
            this.healthCardTextBox.Location = new System.Drawing.Point(168, 159);
            this.healthCardTextBox.Name = "healthCardTextBox";
            this.healthCardTextBox.PlaceholderText = "RAMQ number";
            this.healthCardTextBox.Size = new System.Drawing.Size(300, 27);
            this.healthCardTextBox.TabIndex = 8;
            // 
            // dateCreatedDTPicker
            // 
            this.dateCreatedDTPicker.Location = new System.Drawing.Point(168, 200);
            this.dateCreatedDTPicker.Name = "dateCreatedDTPicker";
            this.dateCreatedDTPicker.Size = new System.Drawing.Size(300, 27);
            this.dateCreatedDTPicker.TabIndex = 9;
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(168, 258);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(217, 37);
            this.actionButton.TabIndex = 10;
            this.actionButton.Text = "placeholder";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // PatientMultiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 353);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.dateCreatedDTPicker);
            this.Controls.Add(this.healthCardTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lvlValueId);
            this.Controls.Add(this.lblTextDateCreated);
            this.Controls.Add(this.lblTextHealthCard);
            this.Controls.Add(this.lblTextLastName);
            this.Controls.Add(this.lblTextFirstName);
            this.Controls.Add(this.lblTextId);
            this.Name = "PatientMultiView";
            this.Text = "Patient View";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label lblTextId;
    private Label lblTextFirstName;
    private Label lblTextLastName;
    private Label lblTextHealthCard;
    private Label lblTextDateCreated;
    private Label lvlValueId;
    private TextBox firstNameTextBox;
    private TextBox lastNameTextBox;
    private TextBox healthCardTextBox;
    private DateTimePicker dateCreatedDTPicker;
    private Button actionButton;
}