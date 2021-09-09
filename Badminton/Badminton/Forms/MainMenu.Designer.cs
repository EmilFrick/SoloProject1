
namespace Badminton.Forms
{
    partial class MainMenu
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
            System.Windows.Forms.Button btnMainMenuSeeBookings;
            System.Windows.Forms.Button btnMainMenuCreateBooking;
            System.Windows.Forms.Button btnMainMenuUpdateBooking;
            System.Windows.Forms.Button btnMainMenuCheckAvailability;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btnMainMenuSeeBookings = new System.Windows.Forms.Button();
            btnMainMenuCreateBooking = new System.Windows.Forms.Button();
            btnMainMenuUpdateBooking = new System.Windows.Forms.Button();
            btnMainMenuCheckAvailability = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainMenuSeeBookings
            // 
            btnMainMenuSeeBookings.AutoSize = true;
            btnMainMenuSeeBookings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnMainMenuSeeBookings.BackColor = System.Drawing.Color.Chocolate;
            btnMainMenuSeeBookings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnMainMenuSeeBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            btnMainMenuSeeBookings.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            btnMainMenuSeeBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMainMenuSeeBookings.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnMainMenuSeeBookings.ForeColor = System.Drawing.SystemColors.Control;
            btnMainMenuSeeBookings.Location = new System.Drawing.Point(0, 54);
            btnMainMenuSeeBookings.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            btnMainMenuSeeBookings.Name = "btnMainMenuSeeBookings";
            btnMainMenuSeeBookings.Size = new System.Drawing.Size(200, 30);
            btnMainMenuSeeBookings.TabIndex = 0;
            btnMainMenuSeeBookings.Text = "Se Bokningar";
            btnMainMenuSeeBookings.UseVisualStyleBackColor = false;
            btnMainMenuSeeBookings.Click += new System.EventHandler(this.MainMenuGoToSeeBookings);
            // 
            // btnMainMenuCreateBooking
            // 
            btnMainMenuCreateBooking.AutoSize = true;
            btnMainMenuCreateBooking.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnMainMenuCreateBooking.BackColor = System.Drawing.Color.Chocolate;
            btnMainMenuCreateBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnMainMenuCreateBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            btnMainMenuCreateBooking.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            btnMainMenuCreateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMainMenuCreateBooking.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnMainMenuCreateBooking.ForeColor = System.Drawing.SystemColors.Control;
            btnMainMenuCreateBooking.Location = new System.Drawing.Point(0, 8);
            btnMainMenuCreateBooking.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            btnMainMenuCreateBooking.Name = "btnMainMenuCreateBooking";
            btnMainMenuCreateBooking.Size = new System.Drawing.Size(200, 30);
            btnMainMenuCreateBooking.TabIndex = 1;
            btnMainMenuCreateBooking.Text = "Skapa en Bokning";
            btnMainMenuCreateBooking.UseVisualStyleBackColor = false;
            btnMainMenuCreateBooking.Click += new System.EventHandler(this.MainMenuGoToCreateBooking);
            // 
            // btnMainMenuUpdateBooking
            // 
            btnMainMenuUpdateBooking.AutoSize = true;
            btnMainMenuUpdateBooking.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnMainMenuUpdateBooking.BackColor = System.Drawing.Color.Chocolate;
            btnMainMenuUpdateBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnMainMenuUpdateBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            btnMainMenuUpdateBooking.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            btnMainMenuUpdateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMainMenuUpdateBooking.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnMainMenuUpdateBooking.ForeColor = System.Drawing.SystemColors.Control;
            btnMainMenuUpdateBooking.Location = new System.Drawing.Point(0, 100);
            btnMainMenuUpdateBooking.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            btnMainMenuUpdateBooking.Name = "btnMainMenuUpdateBooking";
            btnMainMenuUpdateBooking.Size = new System.Drawing.Size(200, 30);
            btnMainMenuUpdateBooking.TabIndex = 2;
            btnMainMenuUpdateBooking.Text = "Uppdatera en Bokning";
            btnMainMenuUpdateBooking.UseVisualStyleBackColor = false;
            btnMainMenuUpdateBooking.Click += new System.EventHandler(this.MainMenuGoToUpdateBooking);
            // 
            // btnMainMenuCheckAvailability
            // 
            btnMainMenuCheckAvailability.AutoSize = true;
            btnMainMenuCheckAvailability.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnMainMenuCheckAvailability.BackColor = System.Drawing.Color.Chocolate;
            btnMainMenuCheckAvailability.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnMainMenuCheckAvailability.Dock = System.Windows.Forms.DockStyle.Fill;
            btnMainMenuCheckAvailability.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            btnMainMenuCheckAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMainMenuCheckAvailability.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnMainMenuCheckAvailability.ForeColor = System.Drawing.SystemColors.Control;
            btnMainMenuCheckAvailability.Location = new System.Drawing.Point(0, 146);
            btnMainMenuCheckAvailability.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            btnMainMenuCheckAvailability.Name = "btnMainMenuCheckAvailability";
            btnMainMenuCheckAvailability.Size = new System.Drawing.Size(200, 30);
            btnMainMenuCheckAvailability.TabIndex = 3;
            btnMainMenuCheckAvailability.Text = "Kontrollera Tillgänglighet";
            btnMainMenuCheckAvailability.UseVisualStyleBackColor = false;
            btnMainMenuCheckAvailability.Click += new System.EventHandler(this.MainMenuGoToCheckAvailability);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(btnMainMenuCheckAvailability, 0, 3);
            this.tableLayoutPanel1.Controls.Add(btnMainMenuCreateBooking, 0, 0);
            this.tableLayoutPanel1.Controls.Add(btnMainMenuUpdateBooking, 0, 2);
            this.tableLayoutPanel1.Controls.Add(btnMainMenuSeeBookings, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 184);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.Text = "MainMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}