namespace PurchaseSellSystem
{
    partial class formCGAdd
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
            this.textBoxformCGSearch = new System.Windows.Forms.TextBox();
            this.buttonformCGSearch = new System.Windows.Forms.Button();
            this.comboBoxformCGGYS = new System.Windows.Forms.ComboBox();
            this.labelformCGMark = new System.Windows.Forms.Label();
            this.dataGridViewformCG = new System.Windows.Forms.DataGridView();
            this.buttonformCGAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnformCGCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnformCGGYS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnformCGFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnformCGFoodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnformCGDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnformCGDiscountL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnformCGQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnformCGText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnformCGNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewformCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxformCGSearch
            // 
            this.textBoxformCGSearch.ForeColor = System.Drawing.Color.Gray;
            this.textBoxformCGSearch.Location = new System.Drawing.Point(247, 38);
            this.textBoxformCGSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxformCGSearch.Name = "textBoxformCGSearch";
            this.textBoxformCGSearch.Size = new System.Drawing.Size(142, 21);
            this.textBoxformCGSearch.TabIndex = 0;
            this.textBoxformCGSearch.Text = "请输入商品名称";
            this.textBoxformCGSearch.Click += new System.EventHandler(this.textBoxformCGSearch_Click);
            // 
            // buttonformCGSearch
            // 
            this.buttonformCGSearch.Location = new System.Drawing.Point(412, 36);
            this.buttonformCGSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonformCGSearch.Name = "buttonformCGSearch";
            this.buttonformCGSearch.Size = new System.Drawing.Size(56, 25);
            this.buttonformCGSearch.TabIndex = 1;
            this.buttonformCGSearch.Text = "查询";
            this.buttonformCGSearch.UseVisualStyleBackColor = true;
            this.buttonformCGSearch.Click += new System.EventHandler(this.buttonformCGSearch_Click);
            // 
            // comboBoxformCGGYS
            // 
            this.comboBoxformCGGYS.FormattingEnabled = true;
            this.comboBoxformCGGYS.Location = new System.Drawing.Point(70, 38);
            this.comboBoxformCGGYS.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxformCGGYS.Name = "comboBoxformCGGYS";
            this.comboBoxformCGGYS.Size = new System.Drawing.Size(158, 20);
            this.comboBoxformCGGYS.TabIndex = 2;
            this.comboBoxformCGGYS.SelectedIndexChanged += new System.EventHandler(this.comboBoxformCGGYS_SelectedIndexChanged);
            // 
            // labelformCGMark
            // 
            this.labelformCGMark.AutoSize = true;
            this.labelformCGMark.Location = new System.Drawing.Point(232, 42);
            this.labelformCGMark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelformCGMark.Name = "labelformCGMark";
            this.labelformCGMark.Size = new System.Drawing.Size(11, 12);
            this.labelformCGMark.TabIndex = 4;
            this.labelformCGMark.Text = "|";
            // 
            // dataGridViewformCG
            // 
            this.dataGridViewformCG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewformCG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnformCGCheck,
            this.ColumnformCGGYS,
            this.ColumnformCGFoodName,
            this.ColumnformCGFoodType,
            this.ColumnformCGDM,
            this.ColumnformCGDiscountL,
            this.ColumnformCGQuantity,
            this.ColumnformCGText,
            this.ColumnformCGNumber});
            this.dataGridViewformCG.Location = new System.Drawing.Point(9, 80);
            this.dataGridViewformCG.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewformCG.Name = "dataGridViewformCG";
            this.dataGridViewformCG.RowTemplate.Height = 27;
            this.dataGridViewformCG.Size = new System.Drawing.Size(865, 115);
            this.dataGridViewformCG.TabIndex = 5;
            // 
            // buttonformCGAdd
            // 
            this.buttonformCGAdd.Location = new System.Drawing.Point(309, 318);
            this.buttonformCGAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonformCGAdd.Name = "buttonformCGAdd";
            this.buttonformCGAdd.Size = new System.Drawing.Size(56, 26);
            this.buttonformCGAdd.TabIndex = 7;
            this.buttonformCGAdd.Text = "添加";
            this.buttonformCGAdd.UseVisualStyleBackColor = true;
            this.buttonformCGAdd.Click += new System.EventHandler(this.buttonformCGAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "供应商：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 199);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(865, 83);
            this.dataGridView1.TabIndex = 10;
            // 
            // ColumnformCGCheck
            // 
            this.ColumnformCGCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnformCGCheck.HeaderText = "";
            this.ColumnformCGCheck.Name = "ColumnformCGCheck";
            this.ColumnformCGCheck.Width = 21;
            // 
            // ColumnformCGGYS
            // 
            this.ColumnformCGGYS.HeaderText = "供应商";
            this.ColumnformCGGYS.Name = "ColumnformCGGYS";
            // 
            // ColumnformCGFoodName
            // 
            this.ColumnformCGFoodName.HeaderText = "商品";
            this.ColumnformCGFoodName.Name = "ColumnformCGFoodName";
            // 
            // ColumnformCGFoodType
            // 
            this.ColumnformCGFoodType.HeaderText = "商品类型";
            this.ColumnformCGFoodType.Name = "ColumnformCGFoodType";
            // 
            // ColumnformCGDM
            // 
            this.ColumnformCGDM.HeaderText = "单价";
            this.ColumnformCGDM.Name = "ColumnformCGDM";
            // 
            // ColumnformCGDiscountL
            // 
            this.ColumnformCGDiscountL.HeaderText = "折扣率";
            this.ColumnformCGDiscountL.Name = "ColumnformCGDiscountL";
            // 
            // ColumnformCGQuantity
            // 
            this.ColumnformCGQuantity.HeaderText = "商家存货";
            this.ColumnformCGQuantity.Name = "ColumnformCGQuantity";
            // 
            // ColumnformCGText
            // 
            this.ColumnformCGText.HeaderText = "备注";
            this.ColumnformCGText.Name = "ColumnformCGText";
            // 
            // ColumnformCGNumber
            // 
            this.ColumnformCGNumber.HeaderText = "录入数量";
            this.ColumnformCGNumber.Name = "ColumnformCGNumber";
            // 
            // formCGAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonformCGAdd);
            this.Controls.Add(this.dataGridViewformCG);
            this.Controls.Add(this.labelformCGMark);
            this.Controls.Add(this.comboBoxformCGGYS);
            this.Controls.Add(this.buttonformCGSearch);
            this.Controls.Add(this.textBoxformCGSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formCGAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加商品";
            this.Load += new System.EventHandler(this.formCGAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewformCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxformCGSearch;
        private System.Windows.Forms.Button buttonformCGSearch;
        private System.Windows.Forms.ComboBox comboBoxformCGGYS;
        private System.Windows.Forms.Label labelformCGMark;
        private System.Windows.Forms.DataGridView dataGridViewformCG;
        private System.Windows.Forms.Button buttonformCGAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnformCGCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformCGGYS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformCGFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformCGFoodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformCGDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformCGDiscountL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformCGQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformCGText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnformCGNumber;
    }
}