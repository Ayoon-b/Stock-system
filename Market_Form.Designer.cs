namespace DB_Host
{
    partial class Market_Form
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
            this.bnt_market = new System.Windows.Forms.Button();
            this.mode_date = new System.Windows.Forms.CheckBox();
            this.bnt_select = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_date = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.Label();
            this.market = new System.Windows.Forms.Label();
            this.combo_market = new System.Windows.Forms.ComboBox();
            this.datas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datas)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_market
            // 
            this.bnt_market.Location = new System.Drawing.Point(206, 27);
            this.bnt_market.Name = "bnt_market";
            this.bnt_market.Size = new System.Drawing.Size(50, 25);
            this.bnt_market.TabIndex = 25;
            this.bnt_market.Text = "상세";
            this.bnt_market.UseVisualStyleBackColor = true;
            this.bnt_market.Click += new System.EventHandler(this.bnt_market_Click);
            // 
            // mode_date
            // 
            this.mode_date.AutoSize = true;
            this.mode_date.Location = new System.Drawing.Point(574, 31);
            this.mode_date.Name = "mode_date";
            this.mode_date.Size = new System.Drawing.Size(18, 17);
            this.mode_date.TabIndex = 24;
            this.mode_date.UseVisualStyleBackColor = true;
            this.mode_date.CheckedChanged += new System.EventHandler(this.mode_date_CheckedChanged);
            // 
            // bnt_select
            // 
            this.bnt_select.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bnt_select.Location = new System.Drawing.Point(690, 8);
            this.bnt_select.Name = "bnt_select";
            this.bnt_select.Size = new System.Drawing.Size(60, 60);
            this.bnt_select.TabIndex = 23;
            this.bnt_select.TabStop = false;
            this.bnt_select.UseVisualStyleBackColor = false;
            this.bnt_select.Click += new System.EventHandler(this.bnt_select_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(486, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "날짜 검색";
            // 
            // combo_date
            // 
            this.combo_date.DropDownHeight = 98;
            this.combo_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_date.FormattingEnabled = true;
            this.combo_date.IntegralHeight = false;
            this.combo_date.ItemHeight = 15;
            this.combo_date.Location = new System.Drawing.Point(331, 28);
            this.combo_date.Name = "combo_date";
            this.combo_date.Size = new System.Drawing.Size(131, 23);
            this.combo_date.TabIndex = 21;
            this.combo_date.TabStop = false;
            this.combo_date.Visible = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date.Location = new System.Drawing.Point(283, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(42, 22);
            this.date.TabIndex = 20;
            this.date.Text = "날짜";
            this.date.Visible = false;
            // 
            // market
            // 
            this.market.AutoSize = true;
            this.market.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.market.Location = new System.Drawing.Point(13, 29);
            this.market.Name = "market";
            this.market.Size = new System.Drawing.Size(74, 22);
            this.market.TabIndex = 19;
            this.market.Text = "해외증시";
            // 
            // combo_market
            // 
            this.combo_market.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_market.FormattingEnabled = true;
            this.combo_market.Location = new System.Drawing.Point(93, 28);
            this.combo_market.Name = "combo_market";
            this.combo_market.Size = new System.Drawing.Size(114, 23);
            this.combo_market.TabIndex = 18;
            this.combo_market.TabStop = false;
            // 
            // datas
            // 
            this.datas.AllowUserToAddRows = false;
            this.datas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.datas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datas.Location = new System.Drawing.Point(12, 69);
            this.datas.MultiSelect = false;
            this.datas.Name = "datas";
            this.datas.RowTemplate.Height = 27;
            this.datas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datas.Size = new System.Drawing.Size(727, 367);
            this.datas.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "날짜";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "종가";
            this.Column2.Name = "Column2";
            this.Column2.Width = 115;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "전일대비";
            this.Column3.Name = "Column3";
            this.Column3.Width = 105;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "시가";
            this.Column4.Name = "Column4";
            this.Column4.Width = 115;
            // 
            // Market_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(762, 448);
            this.Controls.Add(this.bnt_market);
            this.Controls.Add(this.mode_date);
            this.Controls.Add(this.bnt_select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_date);
            this.Controls.Add(this.date);
            this.Controls.Add(this.market);
            this.Controls.Add(this.combo_market);
            this.Controls.Add(this.datas);
            this.Name = "Market_Form";
            this.Text = "해외증시";
            this.Load += new System.EventHandler(this.Market_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_market;
        private System.Windows.Forms.CheckBox mode_date;
        private System.Windows.Forms.Button bnt_select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_date;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label market;
        private System.Windows.Forms.ComboBox combo_market;
        private System.Windows.Forms.DataGridView datas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}