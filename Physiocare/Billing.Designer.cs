
namespace Physiocare
{
    partial class Billing
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
            this.lblBillFormat = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBillFormat = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtPatientFirstName = new System.Windows.Forms.TextBox();
            this.lblPatientFirstName = new System.Windows.Forms.Label();
            this.txtPatientLastName = new System.Windows.Forms.TextBox();
            this.lblPatientLastName = new System.Windows.Forms.Label();
            this.txtPerSessionCost = new System.Windows.Forms.TextBox();
            this.lblPerSessionCost = new System.Windows.Forms.Label();
            this.txtTotalNumberOfVisits = new System.Windows.Forms.TextBox();
            this.lblTotalNumberOfVisits = new System.Windows.Forms.Label();
            this.txtPatientProblem = new System.Windows.Forms.TextBox();
            this.lblPatientProblem = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPatientMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblPatientPrefix = new System.Windows.Forms.Label();
            this.cmbPatientPrefix = new System.Windows.Forms.ComboBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.lblBillNumber = new System.Windows.Forms.Label();
            this.btnBrowseDestination = new System.Windows.Forms.Button();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.lblDestinationPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBillFormat
            // 
            this.lblBillFormat.AutoSize = true;
            this.lblBillFormat.Location = new System.Drawing.Point(48, 63);
            this.lblBillFormat.Name = "lblBillFormat";
            this.lblBillFormat.Size = new System.Drawing.Size(125, 17);
            this.lblBillFormat.TabIndex = 0;
            this.lblBillFormat.Text = "Select Bill Format :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtBillFormat
            // 
            this.txtBillFormat.Location = new System.Drawing.Point(220, 60);
            this.txtBillFormat.Name = "txtBillFormat";
            this.txtBillFormat.Size = new System.Drawing.Size(421, 22);
            this.txtBillFormat.TabIndex = 1;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(220, 267);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(252, 22);
            this.txtPatientID.TabIndex = 3;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(48, 270);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(77, 17);
            this.lblPatientID.TabIndex = 2;
            this.lblPatientID.Text = "Patient ID :";
            // 
            // txtPatientFirstName
            // 
            this.txtPatientFirstName.Location = new System.Drawing.Point(220, 350);
            this.txtPatientFirstName.Name = "txtPatientFirstName";
            this.txtPatientFirstName.Size = new System.Drawing.Size(252, 22);
            this.txtPatientFirstName.TabIndex = 5;
            // 
            // lblPatientFirstName
            // 
            this.lblPatientFirstName.AutoSize = true;
            this.lblPatientFirstName.Location = new System.Drawing.Point(48, 353);
            this.lblPatientFirstName.Name = "lblPatientFirstName";
            this.lblPatientFirstName.Size = new System.Drawing.Size(142, 17);
            this.lblPatientFirstName.TabIndex = 4;
            this.lblPatientFirstName.Text = "Patient\'s First Name :";
            // 
            // txtPatientLastName
            // 
            this.txtPatientLastName.Location = new System.Drawing.Point(220, 425);
            this.txtPatientLastName.Name = "txtPatientLastName";
            this.txtPatientLastName.Size = new System.Drawing.Size(252, 22);
            this.txtPatientLastName.TabIndex = 7;
            // 
            // lblPatientLastName
            // 
            this.lblPatientLastName.AutoSize = true;
            this.lblPatientLastName.Location = new System.Drawing.Point(48, 428);
            this.lblPatientLastName.Name = "lblPatientLastName";
            this.lblPatientLastName.Size = new System.Drawing.Size(142, 17);
            this.lblPatientLastName.TabIndex = 6;
            this.lblPatientLastName.Text = "Patient\'s Last Name :";
            // 
            // txtPerSessionCost
            // 
            this.txtPerSessionCost.Location = new System.Drawing.Point(220, 466);
            this.txtPerSessionCost.Name = "txtPerSessionCost";
            this.txtPerSessionCost.Size = new System.Drawing.Size(252, 22);
            this.txtPerSessionCost.TabIndex = 9;
            // 
            // lblPerSessionCost
            // 
            this.lblPerSessionCost.AutoSize = true;
            this.lblPerSessionCost.Location = new System.Drawing.Point(48, 469);
            this.lblPerSessionCost.Name = "lblPerSessionCost";
            this.lblPerSessionCost.Size = new System.Drawing.Size(124, 17);
            this.lblPerSessionCost.TabIndex = 8;
            this.lblPerSessionCost.Text = "Per Session Cost :";
            // 
            // txtTotalNumberOfVisits
            // 
            this.txtTotalNumberOfVisits.Location = new System.Drawing.Point(220, 503);
            this.txtTotalNumberOfVisits.Name = "txtTotalNumberOfVisits";
            this.txtTotalNumberOfVisits.Size = new System.Drawing.Size(252, 22);
            this.txtTotalNumberOfVisits.TabIndex = 11;
            // 
            // lblTotalNumberOfVisits
            // 
            this.lblTotalNumberOfVisits.AutoSize = true;
            this.lblTotalNumberOfVisits.Location = new System.Drawing.Point(48, 506);
            this.lblTotalNumberOfVisits.Name = "lblTotalNumberOfVisits";
            this.lblTotalNumberOfVisits.Size = new System.Drawing.Size(158, 17);
            this.lblTotalNumberOfVisits.TabIndex = 10;
            this.lblTotalNumberOfVisits.Text = "Total Number Of Visits :";
            // 
            // txtPatientProblem
            // 
            this.txtPatientProblem.Location = new System.Drawing.Point(220, 549);
            this.txtPatientProblem.Name = "txtPatientProblem";
            this.txtPatientProblem.Size = new System.Drawing.Size(252, 22);
            this.txtPatientProblem.TabIndex = 13;
            // 
            // lblPatientProblem
            // 
            this.lblPatientProblem.AutoSize = true;
            this.lblPatientProblem.Location = new System.Drawing.Point(48, 552);
            this.lblPatientProblem.Name = "lblPatientProblem";
            this.lblPatientProblem.Size = new System.Drawing.Size(126, 17);
            this.lblPatientProblem.TabIndex = 12;
            this.lblPatientProblem.Text = "Patient\'s Problem :";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(220, 589);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(252, 22);
            this.txtStartDate.TabIndex = 15;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(48, 592);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(80, 17);
            this.lblStartDate.TabIndex = 14;
            this.lblStartDate.Text = "Start Date :";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(220, 629);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(252, 22);
            this.txtEndDate.TabIndex = 17;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(48, 632);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(75, 17);
            this.lblEndDate.TabIndex = 16;
            this.lblEndDate.Text = "End Date :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(720, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(416, 22);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(1165, 63);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 20);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Search";
            // 
            // dgvBilling
            // 
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilling.Location = new System.Drawing.Point(720, 117);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.RowHeadersWidth = 51;
            this.dgvBilling.RowTemplate.Height = 24;
            this.dgvBilling.Size = new System.Drawing.Size(558, 255);
            this.dgvBilling.TabIndex = 20;
            this.dgvBilling.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBilling_RowHeaderMouseClick);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(175, 792);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(151, 45);
            this.btnPreview.TabIndex = 21;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBill.Location = new System.Drawing.Point(839, 792);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(151, 45);
            this.btnGenerateBill.TabIndex = 22;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = true;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1126, 792);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 45);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(220, 88);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(119, 33);
            this.btnBrowse.TabIndex = 24;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPatientMiddleName
            // 
            this.txtPatientMiddleName.Location = new System.Drawing.Point(220, 388);
            this.txtPatientMiddleName.Name = "txtPatientMiddleName";
            this.txtPatientMiddleName.Size = new System.Drawing.Size(252, 22);
            this.txtPatientMiddleName.TabIndex = 26;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(48, 391);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(156, 17);
            this.lblMiddleName.TabIndex = 25;
            this.lblMiddleName.Text = "Patient\'s Middle Name :";
            // 
            // lblPatientPrefix
            // 
            this.lblPatientPrefix.AutoSize = true;
            this.lblPatientPrefix.Location = new System.Drawing.Point(48, 307);
            this.lblPatientPrefix.Name = "lblPatientPrefix";
            this.lblPatientPrefix.Size = new System.Drawing.Size(109, 17);
            this.lblPatientPrefix.TabIndex = 27;
            this.lblPatientPrefix.Text = "Patient\'s Prefix :";
            // 
            // cmbPatientPrefix
            // 
            this.cmbPatientPrefix.FormattingEnabled = true;
            this.cmbPatientPrefix.Items.AddRange(new object[] {
            "Mrs.",
            "Ms.",
            "Miss."});
            this.cmbPatientPrefix.Location = new System.Drawing.Point(220, 307);
            this.cmbPatientPrefix.Name = "cmbPatientPrefix";
            this.cmbPatientPrefix.Size = new System.Drawing.Size(121, 24);
            this.cmbPatientPrefix.TabIndex = 28;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(220, 672);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(252, 22);
            this.txtTotalCost.TabIndex = 30;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(48, 675);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(169, 17);
            this.lblTotalCost.TabIndex = 29;
            this.lblTotalCost.Text = "Total Cost :                 Rs.";
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Location = new System.Drawing.Point(220, 725);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(252, 22);
            this.txtBillNumber.TabIndex = 32;
            // 
            // lblBillNumber
            // 
            this.lblBillNumber.AutoSize = true;
            this.lblBillNumber.Location = new System.Drawing.Point(48, 728);
            this.lblBillNumber.Name = "lblBillNumber";
            this.lblBillNumber.Size = new System.Drawing.Size(88, 17);
            this.lblBillNumber.TabIndex = 31;
            this.lblBillNumber.Text = "Bill Number :";
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Location = new System.Drawing.Point(220, 187);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Size = new System.Drawing.Size(119, 33);
            this.btnBrowseDestination.TabIndex = 35;
            this.btnBrowseDestination.Text = "Browse";
            this.btnBrowseDestination.UseVisualStyleBackColor = true;
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(220, 159);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(421, 22);
            this.txtDestinationPath.TabIndex = 34;
            // 
            // lblDestinationPath
            // 
            this.lblDestinationPath.AutoSize = true;
            this.lblDestinationPath.Location = new System.Drawing.Point(48, 162);
            this.lblDestinationPath.Name = "lblDestinationPath";
            this.lblDestinationPath.Size = new System.Drawing.Size(120, 17);
            this.lblDestinationPath.TabIndex = 33;
            this.lblDestinationPath.Text = "Destination Path :";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1300, 619);
            this.Controls.Add(this.btnBrowseDestination);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.lblDestinationPath);
            this.Controls.Add(this.txtBillNumber);
            this.Controls.Add(this.lblBillNumber);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.cmbPatientPrefix);
            this.Controls.Add(this.lblPatientPrefix);
            this.Controls.Add(this.txtPatientMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dgvBilling);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtPatientProblem);
            this.Controls.Add(this.lblPatientProblem);
            this.Controls.Add(this.txtTotalNumberOfVisits);
            this.Controls.Add(this.lblTotalNumberOfVisits);
            this.Controls.Add(this.txtPerSessionCost);
            this.Controls.Add(this.lblPerSessionCost);
            this.Controls.Add(this.txtPatientLastName);
            this.Controls.Add(this.lblPatientLastName);
            this.Controls.Add(this.txtPatientFirstName);
            this.Controls.Add(this.lblPatientFirstName);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.txtBillFormat);
            this.Controls.Add(this.lblBillFormat);
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Physiocare";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillFormat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtBillFormat;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtPatientFirstName;
        private System.Windows.Forms.Label lblPatientFirstName;
        private System.Windows.Forms.TextBox txtPatientLastName;
        private System.Windows.Forms.Label lblPatientLastName;
        private System.Windows.Forms.TextBox txtPerSessionCost;
        private System.Windows.Forms.Label lblPerSessionCost;
        private System.Windows.Forms.TextBox txtTotalNumberOfVisits;
        private System.Windows.Forms.Label lblTotalNumberOfVisits;
        private System.Windows.Forms.TextBox txtPatientProblem;
        private System.Windows.Forms.Label lblPatientProblem;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvBilling;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPatientMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblPatientPrefix;
        private System.Windows.Forms.ComboBox cmbPatientPrefix;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.Label lblBillNumber;
        private System.Windows.Forms.Button btnBrowseDestination;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Label lblDestinationPath;
    }
}