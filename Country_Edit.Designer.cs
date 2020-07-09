namespace DB_Host
{
    partial class Country_Edit
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
            this.bnt_select = new System.Windows.Forms.Button();
            this.country = new System.Windows.Forms.Label();
            this.datas = new System.Windows.Forms.DataGridView();
            this.tb_country = new System.Windows.Forms.TextBox();
            this.mode_all = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bnt_insert = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datas)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_select
            // 
            this.bnt_select.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bnt_select.Location = new System.Drawing.Point(532, 10);
            this.bnt_select.Name = "bnt_select";
            this.bnt_select.Size = new System.Drawing.Size(60, 60);
            this.bnt_select.TabIndex = 12;
            this.bnt_select.TabStop = false;
            this.bnt_select.UseVisualStyleBackColor = false;
            this.bnt_select.Click += new System.EventHandler(this.bnt_select_Click);
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.country.Location = new System.Drawing.Point(12, 29);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(85, 22);
            this.country.TabIndex = 11;
            this.country.Text = "나라 검색";
            // 
            // datas
            // 
            this.datas.AllowUserToAddRows = false;
            this.datas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.datas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datas.Location = new System.Drawing.Point(12, 79);
            this.datas.MultiSelect = false;
            this.datas.Name = "datas";
            this.datas.RowTemplate.Height = 27;
            this.datas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datas.Size = new System.Drawing.Size(509, 292);
            this.datas.TabIndex = 10;
            // 
            // tb_country
            // 
            this.tb_country.Location = new System.Drawing.Point(103, 26);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(208, 25);
            this.tb_country.TabIndex = 13;
            // 
            // mode_all
            // 
            this.mode_all.AutoSize = true;
            this.mode_all.Location = new System.Drawing.Point(422, 31);
            this.mode_all.Name = "mode_all";
            this.mode_all.Size = new System.Drawing.Size(18, 17);
            this.mode_all.TabIndex = 14;
            this.mode_all.UseVisualStyleBackColor = true;
            this.mode_all.CheckedChanged += new System.EventHandler(this.mode_all_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(334, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "전체 조회";
            // 
            // bnt_insert
            // 
            this.bnt_insert.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bnt_insert.Location = new System.Drawing.Point(527, 301);
            this.bnt_insert.Name = "bnt_insert";
            this.bnt_insert.Size = new System.Drawing.Size(70, 70);
            this.bnt_insert.TabIndex = 16;
            this.bnt_insert.TabStop = false;
            this.bnt_insert.UseVisualStyleBackColor = false;
            this.bnt_insert.Click += new System.EventHandler(this.bnt_insert_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "나라";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "월간 매매기준율 평균";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Country_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(602, 383);
            this.Controls.Add(this.bnt_insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mode_all);
            this.Controls.Add(this.tb_country);
            this.Controls.Add(this.bnt_select);
            this.Controls.Add(this.country);
            this.Controls.Add(this.datas);
            this.Name = "Country_Edit";
            this.Text = "나라 조회";
            this.Load += new System.EventHandler(this.Country_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_select;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.DataGridView datas;
        private System.Windows.Forms.TextBox tb_country;
        private System.Windows.Forms.CheckBox mode_all;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}