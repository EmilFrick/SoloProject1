
namespace Badminton.Forms
{
    partial class SelectCustomer
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
            this.btnExisting = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnExisting, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 97);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnExisting
            // 
            this.btnExisting.BackColor = System.Drawing.Color.Chocolate;
            this.btnExisting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExisting.FlatAppearance.BorderSize = 2;
            this.btnExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExisting.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExisting.ForeColor = System.Drawing.Color.Yellow;
            this.btnExisting.Location = new System.Drawing.Point(203, 20);
            this.btnExisting.Margin = new System.Windows.Forms.Padding(10, 20, 20, 20);
            this.btnExisting.Name = "btnExisting";
            this.btnExisting.Size = new System.Drawing.Size(163, 57);
            this.btnExisting.TabIndex = 1;
            this.btnExisting.Text = "Befintlig Kund";
            this.btnExisting.UseVisualStyleBackColor = false;
            this.btnExisting.Click += new System.EventHandler(this.btnExisting_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Chocolate;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Yellow;
            this.btnNew.Location = new System.Drawing.Point(20, 20);
            this.btnNew.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(163, 57);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Ny Kund";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.CreateNewCustomerClick);
            // 
            // SelectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(386, 97);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SelectCustomer";
            this.Text = "SelectCustomer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExisting;
        private System.Windows.Forms.Button btnNew;
    }
}