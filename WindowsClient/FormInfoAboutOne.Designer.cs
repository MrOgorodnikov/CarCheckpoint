namespace WindowsClient
{
    partial class FormInfoAboutOne
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.paymentsGridView = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrancesDataGrid = new System.Windows.Forms.DataGridView();
            this.cardsGridView = new System.Windows.Forms.DataGridView();
            this.CardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrancesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Garage";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(205, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birthday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Car number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Home Adress";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(205, 88);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(164, 22);
            this.nameTextBox.TabIndex = 9;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(205, 127);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(164, 22);
            this.surnameTextBox.TabIndex = 10;
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(205, 191);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(164, 22);
            this.adressTextBox.TabIndex = 11;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(205, 233);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(164, 22);
            this.balanceTextBox.TabIndex = 12;
            // 
            // carTextBox
            // 
            this.carTextBox.Location = new System.Drawing.Point(205, 269);
            this.carTextBox.Name = "carTextBox";
            this.carTextBox.Size = new System.Drawing.Size(164, 22);
            this.carTextBox.TabIndex = 13;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Location = new System.Drawing.Point(205, 314);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(164, 22);
            this.birthdayTextBox.TabIndex = 14;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(435, 84);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(205, 157);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(164, 22);
            this.phoneTextBox.TabIndex = 16;
            // 
            // paymentsGridView
            // 
            this.paymentsGridView.AllowUserToAddRows = false;
            this.paymentsGridView.AllowUserToDeleteRows = false;
            this.paymentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Payment});
            this.paymentsGridView.Location = new System.Drawing.Point(8, 448);
            this.paymentsGridView.Name = "paymentsGridView";
            this.paymentsGridView.ReadOnly = true;
            this.paymentsGridView.RowHeadersVisible = false;
            this.paymentsGridView.RowTemplate.Height = 24;
            this.paymentsGridView.Size = new System.Drawing.Size(240, 150);
            this.paymentsGridView.TabIndex = 17;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // entrancesDataGrid
            // 
            this.entrancesDataGrid.AllowUserToAddRows = false;
            this.entrancesDataGrid.AllowUserToDeleteRows = false;
            this.entrancesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entrancesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateCol,
            this.Count});
            this.entrancesDataGrid.Location = new System.Drawing.Point(268, 448);
            this.entrancesDataGrid.Name = "entrancesDataGrid";
            this.entrancesDataGrid.ReadOnly = true;
            this.entrancesDataGrid.RowHeadersVisible = false;
            this.entrancesDataGrid.RowTemplate.Height = 24;
            this.entrancesDataGrid.Size = new System.Drawing.Size(240, 150);
            this.entrancesDataGrid.TabIndex = 18;
            // 
            // cardsGridView
            // 
            this.cardsGridView.AllowUserToAddRows = false;
            this.cardsGridView.AllowUserToDeleteRows = false;
            this.cardsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CardId});
            this.cardsGridView.Location = new System.Drawing.Point(531, 448);
            this.cardsGridView.Name = "cardsGridView";
            this.cardsGridView.ReadOnly = true;
            this.cardsGridView.RowHeadersVisible = false;
            this.cardsGridView.RowTemplate.Height = 24;
            this.cardsGridView.Size = new System.Drawing.Size(240, 150);
            this.cardsGridView.TabIndex = 19;
            // 
            // CardId
            // 
            this.CardId.HeaderText = "Card Number";
            this.CardId.Name = "CardId";
            this.CardId.ReadOnly = true;
            this.CardId.Width = 200;
            // 
            // DateCol
            // 
            this.DateCol.HeaderText = "Date";
            this.DateCol.Name = "DateCol";
            this.DateCol.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 67);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormInfoAboutOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 710);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardsGridView);
            this.Controls.Add(this.entrancesDataGrid);
            this.Controls.Add(this.paymentsGridView);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.carTextBox);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormInfoAboutOne";
            this.Text = "FormInfoAboutOne";
            this.Load += new System.EventHandler(this.FormInfoAboutOne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrancesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox carTextBox;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.DataGridView paymentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridView entrancesDataGrid;
        private System.Windows.Forms.DataGridView cardsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Button button1;
    }
}