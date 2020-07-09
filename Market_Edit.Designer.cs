namespace DB_Host
{
    partial class Market_Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.mode_all = new System.Windows.Forms.CheckBox();
            this.tb_market = new System.Windows.Forms.TextBox();
            this.bnt_select = new System.Windows.Forms.Button();
            this.market = new System.Windows.Forms.Label();
            this.datas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.나라 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(366, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "전체 조회";
            // 
            // mode_all
            // 
            this.mode_all.AutoSize = true;
            this.mode_all.Location = new System.Drawing.Point(457, 31);
            this.mode_all.Name = "mode_all";
            this.mode_all.Size = new System.Drawing.Size(18, 17);
            this.mode_all.TabIndex = 20;
            this.mode_all.UseVisualStyleBackColor = true;
            this.mode_all.CheckedChanged += new System.EventHandler(this.mode_all_CheckedChanged);
            // 
            // tb_market
            // 
            this.tb_market.Location = new System.Drawing.Point(135, 26);
            this.tb_market.Name = "tb_market";
            this.tb_market.Size = new System.Drawing.Size(208, 25);
            this.tb_market.TabIndex = 19;
            // 
            // bnt_select
            // 
            this.bnt_select.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bnt_select.Location = new System.Drawing.Point(734, 12);
            this.bnt_select.Name = "bnt_select";
            this.bnt_select.Size = new System.Drawing.Size(60, 60);
            this.bnt_select.TabIndex = 18;
            this.bnt_select.TabStop = false;
            this.bnt_select.UseVisualStyleBackColor = false;
            this.bnt_select.Click += new System.EventHandler(this.bnt_select_Click);
            // 
            // market
            // 
            this.market.AutoSize = true;
            this.market.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.market.Location = new System.Drawing.Point(12, 29);
            this.market.Name = "market";
            this.market.Size = new System.Drawing.Size(117, 22);
            this.market.TabIndex = 17;
            this.market.Text = "해외증시 검색";
            // 
            // datas
            // 
            this.datas.AllowUserToAddRows = false;
            this.datas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.나라,
            this.Column2,
            this.Column3});
            this.datas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datas.Location = new System.Drawing.Point(12, 79);
            this.datas.MultiSelect = false;
            this.datas.Name = "datas";
            this.datas.RowTemplate.Height = 27;
            this.datas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datas.Size = new System.Drawing.Size(713, 292);
            this.datas.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "해외 주요지수";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // 나라
            // 
            this.나라.HeaderText = "나라";
            this.나라.Name = "나라";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "월간 종가 평균";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "월간 매매기준율 평균";
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Market_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(806, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mode_all);
            this.Controls.Add(this.tb_market);
            this.Controls.Add(this.bnt_select);
            this.Controls.Add(this.market);
            this.Controls.Add(this.datas);
            this.Name = "Market_Edit";
            this.Text = "해외증시 조회";
            this.Load += new System.EventHandler(this.Market_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox mode_all;
        private System.Windows.Forms.TextBox tb_market;
        private System.Windows.Forms.Button bnt_select;
        private System.Windows.Forms.Label market;
        private System.Windows.Forms.DataGridView datas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 나라;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}