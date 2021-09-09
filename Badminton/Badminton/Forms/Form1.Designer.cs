
namespace Badminton.Forms
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
            this.btnCustomerBooking = new System.Windows.Forms.Button();
            this.btnCourtBooking = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlCourtShowPlaceHolder = new System.Windows.Forms.Panel();
            this.ShowCourtPlaceHolder = new Badminton.Forms.txtCourtDetails();
            this.pnlCustomerShowPlaceholder = new System.Windows.Forms.Panel();
            this.showCustomerInfo1 = new Badminton.Forms.ShowCustomerInfo();
            this.btnBackToMainMenu2 = new Badminton.Forms.btnBackToMainMenu();
            this.pnlCourtShowPlaceHolder.SuspendLayout();
            this.pnlCustomerShowPlaceholder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomerBooking
            // 
            this.btnCustomerBooking.BackColor = System.Drawing.Color.Chocolate;
            this.btnCustomerBooking.FlatAppearance.BorderSize = 2;
            this.btnCustomerBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerBooking.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerBooking.ForeColor = System.Drawing.Color.Yellow;
            this.btnCustomerBooking.Location = new System.Drawing.Point(7, 8);
            this.btnCustomerBooking.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.btnCustomerBooking.Name = "btnCustomerBooking";
            this.btnCustomerBooking.Size = new System.Drawing.Size(163, 57);
            this.btnCustomerBooking.TabIndex = 1;
            this.btnCustomerBooking.Text = "Kund";
            this.btnCustomerBooking.UseVisualStyleBackColor = false;
            this.btnCustomerBooking.Click += new System.EventHandler(this.CreateBookingGoToSelectCustomer);
            // 
            // btnCourtBooking
            // 
            this.btnCourtBooking.BackColor = System.Drawing.Color.Chocolate;
            this.btnCourtBooking.FlatAppearance.BorderSize = 2;
            this.btnCourtBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourtBooking.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourtBooking.ForeColor = System.Drawing.Color.Yellow;
            this.btnCourtBooking.Location = new System.Drawing.Point(7, 142);
            this.btnCourtBooking.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.btnCourtBooking.Name = "btnCourtBooking";
            this.btnCourtBooking.Size = new System.Drawing.Size(163, 57);
            this.btnCourtBooking.TabIndex = 2;
            this.btnCourtBooking.Text = "Bana";
            this.btnCourtBooking.UseVisualStyleBackColor = false;
            this.btnCourtBooking.Click += new System.EventHandler(this.CreateCustomerGoToSelectCourt);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(293, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lägg till";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.PlaceTheBookingBtnClick);
            // 
            // pnlCourtShowPlaceHolder
            // 
            this.pnlCourtShowPlaceHolder.Controls.Add(this.ShowCourtPlaceHolder);
            this.pnlCourtShowPlaceHolder.Location = new System.Drawing.Point(183, 142);
            this.pnlCourtShowPlaceHolder.Name = "pnlCourtShowPlaceHolder";
            this.pnlCourtShowPlaceHolder.Size = new System.Drawing.Size(229, 128);
            this.pnlCourtShowPlaceHolder.TabIndex = 8;
            // 
            // ShowCourtPlaceHolder
            // 
            this.ShowCourtPlaceHolder.BackColor = System.Drawing.Color.Ivory;
            this.ShowCourtPlaceHolder.BookingDate = null;
            this.ShowCourtPlaceHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowCourtPlaceHolder.EndingTime = null;
            this.ShowCourtPlaceHolder.GameType = null;
            this.ShowCourtPlaceHolder.Location = new System.Drawing.Point(0, 0);
            this.ShowCourtPlaceHolder.Name = "ShowCourtPlaceHolder";
            this.ShowCourtPlaceHolder.Size = new System.Drawing.Size(229, 128);
            this.ShowCourtPlaceHolder.StartingTime = null;
            this.ShowCourtPlaceHolder.TabIndex = 0;
            this.ShowCourtPlaceHolder.Visible = false;
            // 
            // pnlCustomerShowPlaceholder
            // 
            this.pnlCustomerShowPlaceholder.Controls.Add(this.showCustomerInfo1);
            this.pnlCustomerShowPlaceholder.Location = new System.Drawing.Point(183, 8);
            this.pnlCustomerShowPlaceholder.Name = "pnlCustomerShowPlaceholder";
            this.pnlCustomerShowPlaceholder.Size = new System.Drawing.Size(229, 128);
            this.pnlCustomerShowPlaceholder.TabIndex = 9;
            // 
            // showCustomerInfo1
            // 
            this.showCustomerInfo1.Adress = null;
            this.showCustomerInfo1.BackColor = System.Drawing.Color.Ivory;
            this.showCustomerInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showCustomerInfo1.Email = null;
            this.showCustomerInfo1.FirstName = null;
            this.showCustomerInfo1.LastName = null;
            this.showCustomerInfo1.Location = new System.Drawing.Point(0, 0);
            this.showCustomerInfo1.Name = "showCustomerInfo1";
            this.showCustomerInfo1.Phone = null;
            this.showCustomerInfo1.PostalCode = null;
            this.showCustomerInfo1.Size = new System.Drawing.Size(229, 128);
            this.showCustomerInfo1.TabIndex = 0;
            this.showCustomerInfo1.Visible = false;
            // 
            // btnBackToMainMenu2
            // 
            this.btnBackToMainMenu2.Location = new System.Drawing.Point(247, 278);
            this.btnBackToMainMenu2.Name = "btnBackToMainMenu2";
            this.btnBackToMainMenu2.Size = new System.Drawing.Size(32, 32);
            this.btnBackToMainMenu2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(430, 327);
            this.Controls.Add(this.btnBackToMainMenu2);
            this.Controls.Add(this.pnlCustomerShowPlaceholder);
            this.Controls.Add(this.pnlCourtShowPlaceHolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCourtBooking);
            this.Controls.Add(this.btnCustomerBooking);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlCourtShowPlaceHolder.ResumeLayout(false);
            this.pnlCustomerShowPlaceholder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerBooking;
        private System.Windows.Forms.Button btnCourtBooking;
        private btnBackToMainMenu btnBackToMainMenu1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlCourtShowPlaceHolder;
        private txtCourtDetails txtCourtDetails1;
        private System.Windows.Forms.Panel pnlCustomerShowPlaceholder;
        private txtCourtDetails ShowCourtPlaceHolder;
        private ShowCustomerInfo showCustomerInfo1;
        private btnBackToMainMenu btnBackToMainMenu2;
    }
}