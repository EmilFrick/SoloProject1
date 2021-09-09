
namespace Badminton.Forms
{
    partial class SelectCourt
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBadminton = new System.Windows.Forms.Label();
            this.lblSquash = new System.Windows.Forms.Label();
            this.lblTennis = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingTimeTo = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBackToMainMenu1 = new Badminton.Forms.btnBackToMainMenu();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblBadminton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSquash, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTennis, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(201, 148);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBadminton
            // 
            this.lblBadminton.BackColor = System.Drawing.Color.Ivory;
            this.lblBadminton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBadminton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBadminton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBadminton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBadminton.Location = new System.Drawing.Point(3, 108);
            this.lblBadminton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblBadminton.Name = "lblBadminton";
            this.lblBadminton.Size = new System.Drawing.Size(195, 30);
            this.lblBadminton.TabIndex = 6;
            this.lblBadminton.Text = "Badminton";
            this.lblBadminton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBadminton.Click += new System.EventHandler(this.MarkSelection);
            // 
            // lblSquash
            // 
            this.lblSquash.BackColor = System.Drawing.Color.Ivory;
            this.lblSquash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSquash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSquash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSquash.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquash.Location = new System.Drawing.Point(3, 59);
            this.lblSquash.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblSquash.Name = "lblSquash";
            this.lblSquash.Size = new System.Drawing.Size(195, 29);
            this.lblSquash.TabIndex = 5;
            this.lblSquash.Text = "Squash";
            this.lblSquash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSquash.Click += new System.EventHandler(this.MarkSelection);
            // 
            // lblTennis
            // 
            this.lblTennis.BackColor = System.Drawing.Color.Ivory;
            this.lblTennis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTennis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTennis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTennis.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennis.Location = new System.Drawing.Point(3, 10);
            this.lblTennis.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblTennis.Name = "lblTennis";
            this.lblTennis.Size = new System.Drawing.Size(195, 29);
            this.lblTennis.TabIndex = 4;
            this.lblTennis.Text = "Tennis";
            this.lblTennis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTennis.Click += new System.EventHandler(this.MarkSelection);
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.AllowDrop = true;
            this.dtpBookingDate.CalendarFont = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.CalendarMonthBackground = System.Drawing.Color.Ivory;
            this.dtpBookingDate.CustomFormat = "HH:mm";
            this.dtpBookingDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpBookingDate.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Location = new System.Drawing.Point(0, 35);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(224, 23);
            this.dtpBookingDate.TabIndex = 0;
            this.dtpBookingDate.Value = new System.DateTime(2021, 9, 7, 0, 0, 0, 0);
            // 
            // dtpBookingTimeFrom
            // 
            this.dtpBookingTimeFrom.AllowDrop = true;
            this.dtpBookingTimeFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBookingTimeFrom.CalendarFont = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingTimeFrom.CalendarMonthBackground = System.Drawing.Color.Ivory;
            this.dtpBookingTimeFrom.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpBookingTimeFrom.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpBookingTimeFrom.CustomFormat = "HH:mm";
            this.dtpBookingTimeFrom.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingTimeFrom.Location = new System.Drawing.Point(39, 6);
            this.dtpBookingTimeFrom.Name = "dtpBookingTimeFrom";
            this.dtpBookingTimeFrom.ShowUpDown = true;
            this.dtpBookingTimeFrom.Size = new System.Drawing.Size(67, 23);
            this.dtpBookingTimeFrom.TabIndex = 1;
            this.dtpBookingTimeFrom.Value = new System.DateTime(2021, 9, 4, 12, 0, 0, 0);
            // 
            // dtpBookingTimeTo
            // 
            this.dtpBookingTimeTo.AllowDrop = true;
            this.dtpBookingTimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBookingTimeTo.CalendarFont = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingTimeTo.CalendarMonthBackground = System.Drawing.Color.Ivory;
            this.dtpBookingTimeTo.CustomFormat = "HH:mm";
            this.dtpBookingTimeTo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingTimeTo.Location = new System.Drawing.Point(154, 6);
            this.dtpBookingTimeTo.Name = "dtpBookingTimeTo";
            this.dtpBookingTimeTo.ShowUpDown = true;
            this.dtpBookingTimeTo.Size = new System.Drawing.Size(67, 23);
            this.dtpBookingTimeTo.TabIndex = 2;
            this.dtpBookingTimeTo.Value = new System.DateTime(2021, 9, 4, 13, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpBookingDate);
            this.panel1.Controls.Add(this.dtpBookingTimeFrom);
            this.panel1.Controls.Add(this.dtpBookingTimeTo);
            this.panel1.Location = new System.Drawing.Point(263, 22);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panel1.Size = new System.Drawing.Size(224, 62);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Till";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Från";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chocolate;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(68, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Bekräfta Uppgifter";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.SelectCourtGoToCreateBooking);
            // 
            // btnBackToMainMenu1
            // 
            this.btnBackToMainMenu1.Location = new System.Drawing.Point(12, 195);
            this.btnBackToMainMenu1.Name = "btnBackToMainMenu1";
            this.btnBackToMainMenu1.Size = new System.Drawing.Size(32, 33);
            this.btnBackToMainMenu1.TabIndex = 6;
            // 
            // SelectCourt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(499, 240);
            this.Controls.Add(this.btnBackToMainMenu1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SelectCourt";
            this.Text = "SelectCourt";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.DateTimePicker dtpBookingTimeFrom;
        private System.Windows.Forms.DateTimePicker dtpBookingTimeTo;
        private System.Windows.Forms.Label lblSquash;
        private System.Windows.Forms.Label lblTennis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private btnBackToMainMenu btnBackToMainMenu1;
        public System.Windows.Forms.Label lblBadminton;
    }
}