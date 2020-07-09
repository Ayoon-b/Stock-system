namespace DB_Host
{
    partial class Country_Form
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
            this.bnt_insert = new System.Windows.Forms.Button();
            this.datas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnt_delete = new System.Windows.Forms.Button();
            this.combo_country = new System.Windows.Forms.ComboBox();
            this.country = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.combo_date = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bnt_select = new System.Windows.Forms.Button();
            this.bnt_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mode_date = new System.Windows.Forms.CheckBox();
            this.mode_month = new System.Windows.Forms.CheckBox();
            this.bnt_country = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datas)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_insert
            // 
            this.bnt_insert.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bnt_insert.Location = new System.Drawing.Point(753, 269);
            this.bnt_insert.Name = "bnt_insert";
            this.bnt_insert.Size = new System.Drawing.Size(70, 70);
            this.bnt_insert.TabIndex = 0;
            this.bnt_insert.TabStop = false;
            this.bnt_insert.UseVisualStyleBackColor = false;
            this.bnt_insert.Click += new System.EventHandler(this.bnt_insert_Click);
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
            this.Column4,
            this.Column5});
            this.datas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datas.Location = new System.Drawing.Point(12, 69);
            this.datas.MultiSelect = false;
            this.datas.Name = "datas";
            this.datas.RowTemplate.Height = 27;
            this.datas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datas.Size = new System.Drawing.Size(732, 422);
            this.datas.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "날짜";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "매매기준율";
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
            this.Column4.HeaderText = "현찰 (살 때)";
            this.Column4.Name = "Column4";
            this.Column4.Width = 115;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "현찰 (팔 때)";
            this.Column5.Name = "Column5";
            this.Column5.Width = 115;
            // 
            // bnt_delete
            // 
            this.bnt_delete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bnt_delete.Location = new System.Drawing.Point(753, 421);
            this.bnt_delete.Name = "bnt_delete";
            this.bnt_delete.Size = new System.Drawing.Size(70, 70);
            this.bnt_delete.TabIndex = 2;
            this.bnt_delete.TabStop = false;
            this.bnt_delete.UseVisualStyleBackColor = false;
            this.bnt_delete.Click += new System.EventHandler(this.bnt_delete_Click);
            // 
            // combo_country
            // 
            this.combo_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_country.FormattingEnabled = true;
            this.combo_country.Location = new System.Drawing.Point(61, 28);
            this.combo_country.Name = "combo_country";
            this.combo_country.Size = new System.Drawing.Size(114, 23);
            this.combo_country.TabIndex = 3;
            this.combo_country.TabStop = false;
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.country.Location = new System.Drawing.Point(13, 29);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(42, 22);
            this.country.TabIndex = 4;
            this.country.Text = "나라";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date.Location = new System.Drawing.Point(235, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(42, 22);
            this.date.TabIndex = 5;
            this.date.Text = "날짜";
            this.date.Visible = false;
            // 
            // combo_date
            // 
            this.combo_date.DropDownHeight = 98;
            this.combo_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_date.FormattingEnabled = true;
            this.combo_date.IntegralHeight = false;
            this.combo_date.ItemHeight = 15;
            this.combo_date.Location = new System.Drawing.Point(283, 28);
            this.combo_date.Name = "combo_date";
            this.combo_date.Size = new System.Drawing.Size(131, 23);
            this.combo_date.TabIndex = 6;
            this.combo_date.TabStop = false;
            this.combo_date.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(423, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "날짜 검색";
            // 
            // bnt_select
            // 
            this.bnt_select.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bnt_select.Location = new System.Drawing.Point(758, 10);
            this.bnt_select.Name = "bnt_select";
            this.bnt_select.Size = new System.Drawing.Size(60, 60);
            this.bnt_select.TabIndex = 9;
            this.bnt_select.TabStop = false;
            this.bnt_select.UseVisualStyleBackColor = false;
            this.bnt_select.Click += new System.EventHandler(this.bnt_select_Click);
            // 
            // bnt_update
            // 
            this.bnt_update.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bnt_update.Location = new System.Drawing.Point(753, 345);
            this.bnt_update.Name = "bnt_update";
            this.bnt_update.Size = new System.Drawing.Size(70, 70);
            this.bnt_update.TabIndex = 10;
            this.bnt_update.TabStop = false;
            this.bnt_update.UseVisualStyleBackColor = false;
            this.bnt_update.Click += new System.EventHandler(this.bnt_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(540, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "나라별 매매기준율";
            // 
            // mode_date
            // 
            this.mode_date.AutoSize = true;
            this.mode_date.Location = new System.Drawing.Point(511, 31);
            this.mode_date.Name = "mode_date";
            this.mode_date.Size = new System.Drawing.Size(18, 17);
            this.mode_date.TabIndex = 14;
            this.mode_date.UseVisualStyleBackColor = true;
            this.mode_date.CheckedChanged += new System.EventHandler(this.mode_date_CheckedChanged);
            // 
            // mode_month
            // 
            this.mode_month.AutoSize = true;
            this.mode_month.Location = new System.Drawing.Point(695, 31);
            this.mode_month.Name = "mode_month";
            this.mode_month.Size = new System.Drawing.Size(18, 17);
            this.mode_month.TabIndex = 15;
            this.mode_month.UseVisualStyleBackColor = true;
            this.mode_month.CheckedChanged += new System.EventHandler(this.mode_month_CheckedChanged);
            // 
            // bnt_country
            // 
            this.bnt_country.Location = new System.Drawing.Point(174, 27);
            this.bnt_country.Name = "bnt_country";
            this.bnt_country.Size = new System.Drawing.Size(50, 25);
            this.bnt_country.TabIndex = 16;
            this.bnt_country.Text = "상세";
            this.bnt_country.UseVisualStyleBackColor = true;
            this.bnt_country.Click += new System.EventHandler(this.bnt_country_Click);
            // 
            // Country_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.bnt_country);
            this.Controls.Add(this.mode_month);
            this.Controls.Add(this.mode_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt_update);
            this.Controls.Add(this.bnt_select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_date);
            this.Controls.Add(this.date);
            this.Controls.Add(this.country);
            this.Controls.Add(this.combo_country);
            this.Controls.Add(this.bnt_delete);
            this.Controls.Add(this.datas);
            this.Controls.Add(this.bnt_insert);
            this.Name = "Country_Form";
            this.Text = "시장지표";
            this.Load += new System.EventHandler(this.Country_Form_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Country_Form_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.datas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_insert;
        private System.Windows.Forms.DataGridView datas;
        private System.Windows.Forms.Button bnt_delete;
        private System.Windows.Forms.ComboBox combo_country;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.ComboBox combo_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnt_select;
        private System.Windows.Forms.Button bnt_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox mode_date;
        private System.Windows.Forms.CheckBox mode_month;
        private System.Windows.Forms.Button bnt_country;
    }
}