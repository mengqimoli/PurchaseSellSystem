namespace PurchaseSellSystem
{
    partial class formTHAdd
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
            this.buttonformTHAdd = new System.Windows.Forms.Button();
            this.dataGridViewformCG = new System.Windows.Forms.DataGridView();
            this.labelformTHMark = new System.Windows.Forms.Label();
            this.buttonformTHSearch = new System.Windows.Forms.Button();
            this.textBoxformTHSearch = new System.Windows.Forms.TextBox();
            this.comboBoxformTHGYS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnformTHCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnformTHGYS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnformTHFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnformTHFoodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnformTHDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnformTHDiscountL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnformTHRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnformTHNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewformCG)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonformTHAdd
            // 
            this.buttonformTHAdd.Location = new System.Drawing.Point(209, 311);
            this.buttonformTHAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonformTHAdd.Name = "buttonformTHAdd";
            this.buttonformTHAdd.Size = new System.Drawing.Size(56, 26);
            this.buttonformTHAdd.TabIndex = 15;
            this.buttonformTHAdd.Text = "添加";
            this.buttonformTHAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewformCG
            // 
            this.dataGridViewformCG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewformCG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnformTHCheck,
            this.ColumnformTHGYS,
            this.ColumnformTHFoodName,
            this.ColumnformTHFoodType,
            this.ColumnformTHDM,
            this.ColumnformTHDiscountL,
            this.ColumnformTHRest,
            this.ColumnformTHNumber});
            this.dataGridViewformCG.Location = new System.Drawing.Point(9, 72);
            this.dataGridViewformCG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewformCG.Name = "dataGridViewformCG";
            this.dataGridViewformCG.RowTemplate.Height = 27;
            this.dataGridViewformCG.Size = new System.Drawing.Size(765, 220);
            this.dataGridViewformCG.TabIndex = 13;
            // 
            // labelformTHMark
            // 
            this.labelformTHMark.AutoSize = true;
            this.labelformTHMark.Location = new System.Drawing.Point(226, 34);
            this.labelformTHMark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelformTHMark.Name = "labelformTHMark";
            this.labelformTHMark.Size = new System.Drawing.Size(11, 12);
            this.labelformTHMark.TabIndex = 12;
            this.labelformTHMark.Text = "|";
            // 
            // buttonformTHSearch
            // 
            this.buttonformTHSearch.Location = new System.Drawing.Point(421, 28);
            this.buttonformTHSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonformTHSearch.Name = "buttonformTHSearch";
            this.buttonformTHSearch.Size = new System.Drawing.Size(56, 25);
            this.buttonformTHSearch.TabIndex = 9;
            this.buttonformTHSearch.Text = "查询";
            this.buttonformTHSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxformTHSearch
            // 
            this.textBoxformTHSearch.ForeColor = System.Drawing.Color.Gray;
            this.textBoxformTHSearch.Location = new System.Drawing.Point(241, 30);
            this.textBoxformTHSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxformTHSearch.Name = "textBoxformTHSearch";
            this.textBoxformTHSearch.Size = new System.Drawing.Size(161, 21);
            this.textBoxformTHSearch.TabIndex = 8;
            this.textBoxformTHSearch.Text = "请输入商品名称";
            this.textBoxformTHSearch.Click += new System.EventHandler(this.textBoxformTHSearch_Click);
            // 
            // comboBoxformTHGYS
            // 
            this.comboBoxformTHGYS.FormattingEnabled = true;
            this.comboBoxformTHGYS.Location = new System.Drawing.Point(70, 31);
            this.comboBoxformTHGYS.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxformTHGYS.Name = "comboBoxformTHGYS";
            this.comboBoxformTHGYS.Size = new System.Drawing.Size(152, 20);
            this.comboBoxformTHGYS.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "供应商：";
            // 
            // ColumnformTHCheck
            // 
            this.ColumnformTHCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnformTHCheck.HeaderText = "";
            this.ColumnformTHCheck.Name = "ColumnformTHCheck";
            this.ColumnformTHCheck.Width = 21;
            // 
            // ColumnformTHGYS
            // 
            this.ColumnformTHGYS.HeaderText = "供应商";
            this.ColumnformTHGYS.Name = "ColumnformTHGYS";
            // 
            // ColumnformTHFoodName
            // 
            this.ColumnformTHFoodName.HeaderText = "商品";
            this.ColumnformTHFoodName.Name = "ColumnformTHFoodName";
            // 
            // ColumnformTHFoodType
            // 
            this.ColumnformTHFoodType.HeaderText = "商品类型";
            this.ColumnformTHFoodType.Name = "ColumnformTHFoodType";
            // 
            // ColumnformTHDM
            // 
            this.ColumnformTHDM.HeaderText = "进货单价";
            this.ColumnformTHDM.Name = "ColumnformTHDM";
            // 
            // ColumnformTHDiscountL
            // 
            this.ColumnformTHDiscountL.HeaderText = "折扣率";
            this.ColumnformTHDiscountL.Name = "ColumnformTHDiscountL";
            // 
            // ColumnformTHRest
            // 
            this.ColumnformTHRest.HeaderText = "仓库存货";
            this.ColumnformTHRest.Name = "ColumnformTHRest";
            // 
            // ColumnformTHNumber
            // 
            this.ColumnformTHNumber.HeaderText = "录入数量";
            this.ColumnformTHNumber.Name = "ColumnformTHNumber";
            // 
            // formTHAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonformTHAdd);
            this.Controls.Add(this.dataGridViewformCG);
            this.Controls.Add(this.labelformTHMark);
            this.Controls.Add(this.comboBoxformTHGYS);
            this.Controls.Add(this.buttonformTHSearch);
            this.Controls.Add(this.textBoxformTHSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formTHAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTHAdd";
            this.Load += new System.EventHandler(this.formTHAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewformCG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonformTHAdd;
        private System.Windows.Forms.DataGridView dataGridViewformCG;
        private System.Windows.Forms.Label labelformTHMark;
        private System.Windows.Forms.Button buttonformTHSearch;
        private System.Windows.Forms.TextBox textBoxformTHSearch;
        private System.Windows.Forms.ComboBox comboBoxformTHGYS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnformTHCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformTHGYS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformTHFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformTHFoodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformTHDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformTHDiscountL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformTHRest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformTHNumber;
    }
}