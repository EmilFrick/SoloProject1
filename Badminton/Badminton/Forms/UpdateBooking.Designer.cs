
namespace Badminton.Forms
{
    partial class UpdateBooking
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
            this.lstbListingBookings = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBackToMainMenu1 = new Badminton.Forms.btnBackToMainMenu();
            this.SuspendLayout();
            // 
            // lstbListingBookings
            // 
            this.lstbListingBookings.BackColor = System.Drawing.Color.Ivory;
            this.lstbListingBookings.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbListingBookings.FormattingEnabled = true;
            this.lstbListingBookings.ItemHeight = 16;
            this.lstbListingBookings.Location = new System.Drawing.Point(27, 12);
            this.lstbListingBookings.Name = "lstbListingBookings";
            this.lstbListingBookings.Size = new System.Drawing.Size(515, 132);
            this.lstbListingBookings.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(400, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ändra Bokning";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnBackToMainMenu1
            // 
            this.btnBackToMainMenu1.Location = new System.Drawing.Point(353, 149);
            this.btnBackToMainMenu1.Name = "btnBackToMainMenu1";
            this.btnBackToMainMenu1.Size = new System.Drawing.Size(32, 32);
            this.btnBackToMainMenu1.TabIndex = 2;
            // 
            // UpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(567, 198);
            this.Controls.Add(this.btnBackToMainMenu1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstbListingBookings);
            this.Name = "UpdateBooking";
            this.Text = "UpdateBooking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbListingBookings;
        private System.Windows.Forms.Button button1;
        private btnBackToMainMenu btnBackToMainMenu1;
    }
}