namespace LinqQueries
{
    partial class MainForm
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
            this.getResults = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbHeight = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbWeight = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mtbId = new System.Windows.Forms.MaskedTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // getResults
            // 
            this.getResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.getResults.Location = new System.Drawing.Point(565, 345);
            this.getResults.Name = "getResults";
            this.getResults.Size = new System.Drawing.Size(75, 23);
            this.getResults.TabIndex = 0;
            this.getResults.Text = "Pobierz";
            this.getResults.UseVisualStyleBackColor = true;
            this.getResults.Click += new System.EventHandler(this.getResults_Click);
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 109);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(636, 217);
            this.dgv.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(118, 32);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDay.Location = new System.Drawing.Point(225, 32);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(97, 20);
            this.dtpBirthDay.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "BirthDate";
            // 
            // mtbHeight
            // 
            this.mtbHeight.Location = new System.Drawing.Point(329, 31);
            this.mtbHeight.Mask = "00000";
            this.mtbHeight.Name = "mtbHeight";
            this.mtbHeight.Size = new System.Drawing.Size(43, 20);
            this.mtbHeight.TabIndex = 8;
            this.mtbHeight.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Weight";
            // 
            // mtbWeight
            // 
            this.mtbWeight.Location = new System.Drawing.Point(385, 31);
            this.mtbWeight.Mask = "00000";
            this.mtbWeight.Name = "mtbWeight";
            this.mtbWeight.Size = new System.Drawing.Size(43, 20);
            this.mtbWeight.TabIndex = 10;
            this.mtbWeight.ValidatingType = typeof(int);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(434, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mtbId
            // 
            this.mtbId.Location = new System.Drawing.Point(383, 71);
            this.mtbId.Mask = "00000";
            this.mtbId.Name = "mtbId";
            this.mtbId.Size = new System.Drawing.Size(43, 20);
            this.mtbId.TabIndex = 13;
            this.mtbId.ValidatingType = typeof(int);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(434, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(396, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Id";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(434, 51);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(302, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 387);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.mtbId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpBirthDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.getResults);
            this.Name = "MainForm";
            this.Text = "Start z LINQ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getResults;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbWeight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox mtbId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
    }
}

