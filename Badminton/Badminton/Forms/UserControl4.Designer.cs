
namespace Badminton.Forms
{
    partial class txtToFlowSeeBookings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBookingText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBookingText
            // 
            this.lblBookingText.BackColor = System.Drawing.Color.Ivory;
            this.lblBookingText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBookingText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingText.Location = new System.Drawing.Point(5, 5);
            this.lblBookingText.Margin = new System.Windows.Forms.Padding(0);
            this.lblBookingText.Name = "lblBookingText";
            this.lblBookingText.Size = new System.Drawing.Size(75, 30);
            this.lblBookingText.TabIndex = 0;
            this.lblBookingText.Text = "T1 (13-15)";
            this.lblBookingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtToFlowSeeBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.lblBookingText);
            this.Name = "txtToFlowSeeBookings";
            this.Size = new System.Drawing.Size(85, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBookingText;
    }
}
