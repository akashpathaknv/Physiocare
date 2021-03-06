
namespace Physiocare
{
    partial class Attendance
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
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtPatientLastName = new System.Windows.Forms.TextBox();
            this.lblPatientLastName = new System.Windows.Forms.Label();
            this.txtPatientFirstName = new System.Windows.Forms.TextBox();
            this.lblPatientFirstName = new System.Windows.Forms.Label();
            this.lblMarkAttendance = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.btnMarkAttendance = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpAttendance = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(24, 82);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(77, 17);
            this.lblPatientID.TabIndex = 0;
            this.lblPatientID.Text = "Patient ID :";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(181, 77);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(154, 22);
            this.txtPatientID.TabIndex = 1;
            // 
            // txtPatientLastName
            // 
            this.txtPatientLastName.Location = new System.Drawing.Point(181, 158);
            this.txtPatientLastName.Name = "txtPatientLastName";
            this.txtPatientLastName.Size = new System.Drawing.Size(154, 22);
            this.txtPatientLastName.TabIndex = 3;
            // 
            // lblPatientLastName
            // 
            this.lblPatientLastName.AutoSize = true;
            this.lblPatientLastName.Location = new System.Drawing.Point(24, 163);
            this.lblPatientLastName.Name = "lblPatientLastName";
            this.lblPatientLastName.Size = new System.Drawing.Size(142, 17);
            this.lblPatientLastName.TabIndex = 2;
            this.lblPatientLastName.Text = "Patient\'s Last Name :";
            // 
            // txtPatientFirstName
            // 
            this.txtPatientFirstName.Location = new System.Drawing.Point(181, 119);
            this.txtPatientFirstName.Name = "txtPatientFirstName";
            this.txtPatientFirstName.Size = new System.Drawing.Size(154, 22);
            this.txtPatientFirstName.TabIndex = 5;
            // 
            // lblPatientFirstName
            // 
            this.lblPatientFirstName.AutoSize = true;
            this.lblPatientFirstName.Location = new System.Drawing.Point(24, 122);
            this.lblPatientFirstName.Name = "lblPatientFirstName";
            this.lblPatientFirstName.Size = new System.Drawing.Size(142, 17);
            this.lblPatientFirstName.TabIndex = 4;
            this.lblPatientFirstName.Text = "Patient\'s First Name :";
            // 
            // lblMarkAttendance
            // 
            this.lblMarkAttendance.AutoSize = true;
            this.lblMarkAttendance.Location = new System.Drawing.Point(24, 206);
            this.lblMarkAttendance.Name = "lblMarkAttendance";
            this.lblMarkAttendance.Size = new System.Drawing.Size(123, 17);
            this.lblMarkAttendance.TabIndex = 6;
            this.lblMarkAttendance.Text = "Mark Attendance :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(627, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(418, 22);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(1085, 63);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 20);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search";
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(627, 106);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersWidth = 51;
            this.dgvAttendance.RowTemplate.Height = 24;
            this.dgvAttendance.Size = new System.Drawing.Size(668, 290);
            this.dgvAttendance.TabIndex = 10;
            this.dgvAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellContentClick);
            this.dgvAttendance.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAttendance_RowHeaderMouseClick);
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAttendance.Location = new System.Drawing.Point(707, 473);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(242, 58);
            this.btnMarkAttendance.TabIndex = 11;
            this.btnMarkAttendance.Text = "Mark Attendance";
            this.btnMarkAttendance.UseVisualStyleBackColor = true;
            this.btnMarkAttendance.Click += new System.EventHandler(this.btnMarkAttendance_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1043, 473);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(242, 58);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpAttendance
            // 
            this.dtpAttendance.CustomFormat = "";
            this.dtpAttendance.Location = new System.Drawing.Point(181, 206);
            this.dtpAttendance.Name = "dtpAttendance";
            this.dtpAttendance.Size = new System.Drawing.Size(246, 22);
            this.dtpAttendance.TabIndex = 13;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1300, 619);
            this.Controls.Add(this.dtpAttendance);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMarkAttendance);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblMarkAttendance);
            this.Controls.Add(this.txtPatientFirstName);
            this.Controls.Add(this.lblPatientFirstName);
            this.Controls.Add(this.txtPatientLastName);
            this.Controls.Add(this.lblPatientLastName);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblPatientID);
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Physiocare";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtPatientLastName;
        private System.Windows.Forms.Label lblPatientLastName;
        private System.Windows.Forms.TextBox txtPatientFirstName;
        private System.Windows.Forms.Label lblPatientFirstName;
        private System.Windows.Forms.Label lblMarkAttendance;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Button btnMarkAttendance;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpAttendance;
    }
}