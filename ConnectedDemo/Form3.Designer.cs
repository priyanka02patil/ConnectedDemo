namespace ConnectedDemo
{
    partial class Form3
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
            this.labelrollno = new System.Windows.Forms.Label();
            this.textBoxrollno = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxstudbranch = new System.Windows.Forms.ComboBox();
            this.dataGridViewStud = new System.Windows.Forms.DataGridView();
            this.labelSName = new System.Windows.Forms.Label();
            this.labelSBranch = new System.Windows.Forms.Label();
            this.textBoxsname = new System.Windows.Forms.TextBox();
            this.textBoxstudpercent = new System.Windows.Forms.TextBox();
            this.labelSPercent = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowStudList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStud)).BeginInit();
            this.SuspendLayout();
            // 
            // labelrollno
            // 
            this.labelrollno.AutoSize = true;
            this.labelrollno.Location = new System.Drawing.Point(103, 63);
            this.labelrollno.Name = "labelrollno";
            this.labelrollno.Size = new System.Drawing.Size(60, 20);
            this.labelrollno.TabIndex = 0;
            this.labelrollno.Text = "Roll No";
            this.labelrollno.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxrollno
            // 
            this.textBoxrollno.Location = new System.Drawing.Point(210, 63);
            this.textBoxrollno.Name = "textBoxrollno";
            this.textBoxrollno.Size = new System.Drawing.Size(233, 26);
            this.textBoxrollno.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 408);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxstudbranch
            // 
            this.comboBoxstudbranch.FormattingEnabled = true;
            this.comboBoxstudbranch.Items.AddRange(new object[] {
            "CS",
            "IT",
            "EXTC",
            "MECHANICAL",
            "ENTC"});
            this.comboBoxstudbranch.Location = new System.Drawing.Point(213, 203);
            this.comboBoxstudbranch.Name = "comboBoxstudbranch";
            this.comboBoxstudbranch.Size = new System.Drawing.Size(283, 28);
            this.comboBoxstudbranch.TabIndex = 3;
            // 
            // dataGridViewStud
            // 
            this.dataGridViewStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStud.Location = new System.Drawing.Point(645, 40);
            this.dataGridViewStud.Name = "dataGridViewStud";
            this.dataGridViewStud.RowHeadersWidth = 62;
            this.dataGridViewStud.RowTemplate.Height = 28;
            this.dataGridViewStud.Size = new System.Drawing.Size(557, 395);
            this.dataGridViewStud.TabIndex = 4;
            this.dataGridViewStud.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelSName
            // 
            this.labelSName.AutoSize = true;
            this.labelSName.Location = new System.Drawing.Point(103, 134);
            this.labelSName.Name = "labelSName";
            this.labelSName.Size = new System.Drawing.Size(51, 20);
            this.labelSName.TabIndex = 5;
            this.labelSName.Text = "Name";
            // 
            // labelSBranch
            // 
            this.labelSBranch.AutoSize = true;
            this.labelSBranch.Location = new System.Drawing.Point(103, 203);
            this.labelSBranch.Name = "labelSBranch";
            this.labelSBranch.Size = new System.Drawing.Size(60, 20);
            this.labelSBranch.TabIndex = 6;
            this.labelSBranch.Text = "Branch";
            this.labelSBranch.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxsname
            // 
            this.textBoxsname.Location = new System.Drawing.Point(213, 134);
            this.textBoxsname.Name = "textBoxsname";
            this.textBoxsname.Size = new System.Drawing.Size(233, 26);
            this.textBoxsname.TabIndex = 7;
            // 
            // textBoxstudpercent
            // 
            this.textBoxstudpercent.Location = new System.Drawing.Point(213, 277);
            this.textBoxstudpercent.Name = "textBoxstudpercent";
            this.textBoxstudpercent.Size = new System.Drawing.Size(233, 26);
            this.textBoxstudpercent.TabIndex = 8;
            // 
            // labelSPercent
            // 
            this.labelSPercent.AutoSize = true;
            this.labelSPercent.Location = new System.Drawing.Point(103, 277);
            this.labelSPercent.Name = "labelSPercent";
            this.labelSPercent.Size = new System.Drawing.Size(91, 20);
            this.labelSPercent.TabIndex = 9;
            this.labelSPercent.Text = "Percentage";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(310, 408);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 50);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(166, 408);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 50);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(454, 408);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 50);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowStudList
            // 
            this.btnShowStudList.Location = new System.Drawing.Point(753, 460);
            this.btnShowStudList.Name = "btnShowStudList";
            this.btnShowStudList.Size = new System.Drawing.Size(323, 59);
            this.btnShowStudList.TabIndex = 13;
            this.btnShowStudList.Text = "Show All List Of Student";
            this.btnShowStudList.UseVisualStyleBackColor = true;
            this.btnShowStudList.Click += new System.EventHandler(this.btnShowStudList_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 602);
            this.Controls.Add(this.btnShowStudList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelSPercent);
            this.Controls.Add(this.textBoxstudpercent);
            this.Controls.Add(this.textBoxsname);
            this.Controls.Add(this.labelSBranch);
            this.Controls.Add(this.labelSName);
            this.Controls.Add(this.dataGridViewStud);
            this.Controls.Add(this.comboBoxstudbranch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxrollno);
            this.Controls.Add(this.labelrollno);
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelrollno;
        private System.Windows.Forms.TextBox textBoxrollno;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxstudbranch;
        private System.Windows.Forms.DataGridView dataGridViewStud;
        private System.Windows.Forms.Label labelSName;
        private System.Windows.Forms.Label labelSBranch;
        private System.Windows.Forms.TextBox textBoxsname;
        private System.Windows.Forms.TextBox textBoxstudpercent;
        private System.Windows.Forms.Label labelSPercent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowStudList;
    }
}