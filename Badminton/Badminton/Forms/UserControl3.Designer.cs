
namespace Badminton.Forms
{
    partial class txtCourtDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCourtNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCourtTimeFrom = new System.Windows.Forms.Label();
            this.lblCourtTimeTo = new System.Windows.Forms.Label();
            this.lblCourtDate = new System.Windows.Forms.Label();
            this.lblCourtType = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCourtNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.lblCourtDate);
            this.panel1.Controls.Add(this.lblCourtType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 125);
            this.panel1.TabIndex = 0;
            // 
            // lblCourtNumber
            // 
            this.lblCourtNumber.AutoSize = true;
            this.lblCourtNumber.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourtNumber.Location = new System.Drawing.Point(158, 12);
            this.lblCourtNumber.Name = "lblCourtNumber";
            this.lblCourtNumber.Size = new System.Drawing.Size(60, 17);
            this.lblCourtNumber.TabIndex = 4;
            this.lblCourtNumber.Text = "(Bana 3)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Till:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Från:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Ivory;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblCourtTimeFrom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCourtTimeTo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(225, 50);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblCourtTimeFrom
            // 
            this.lblCourtTimeFrom.BackColor = System.Drawing.Color.Ivory;
            this.lblCourtTimeFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCourtTimeFrom.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourtTimeFrom.Location = new System.Drawing.Point(3, 0);
            this.lblCourtTimeFrom.Name = "lblCourtTimeFrom";
            this.lblCourtTimeFrom.Size = new System.Drawing.Size(106, 50);
            this.lblCourtTimeFrom.TabIndex = 3;
            this.lblCourtTimeFrom.Text = "00:00";
            this.lblCourtTimeFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourtTimeTo
            // 
            this.lblCourtTimeTo.BackColor = System.Drawing.Color.Ivory;
            this.lblCourtTimeTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCourtTimeTo.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourtTimeTo.Location = new System.Drawing.Point(115, 0);
            this.lblCourtTimeTo.Name = "lblCourtTimeTo";
            this.lblCourtTimeTo.Size = new System.Drawing.Size(107, 50);
            this.lblCourtTimeTo.TabIndex = 2;
            this.lblCourtTimeTo.Text = "00:00";
            this.lblCourtTimeTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourtDate
            // 
            this.lblCourtDate.BackColor = System.Drawing.Color.Ivory;
            this.lblCourtDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCourtDate.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourtDate.Location = new System.Drawing.Point(0, 39);
            this.lblCourtDate.Name = "lblCourtDate";
            this.lblCourtDate.Size = new System.Drawing.Size(225, 33);
            this.lblCourtDate.TabIndex = 1;
            this.lblCourtDate.Text = "Badminton";
            this.lblCourtDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourtType
            // 
            this.lblCourtType.BackColor = System.Drawing.Color.Ivory;
            this.lblCourtType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCourtType.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourtType.Location = new System.Drawing.Point(0, 0);
            this.lblCourtType.Name = "lblCourtType";
            this.lblCourtType.Size = new System.Drawing.Size(225, 39);
            this.lblCourtType.TabIndex = 0;
            this.lblCourtType.Text = "Badminton";
            this.lblCourtType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCourtDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.panel1);
            this.Name = "txtCourtDetails";
            this.Size = new System.Drawing.Size(225, 125);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCourtDate;
        private System.Windows.Forms.Label lblCourtType;
        private System.Windows.Forms.Label lblCourtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCourtTimeFrom;
        private System.Windows.Forms.Label lblCourtTimeTo;
    }
}
