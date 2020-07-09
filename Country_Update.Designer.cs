namespace DB_Host
{
    partial class Country_Update
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
            this.bnt_cancel = new System.Windows.Forms.Button();
            this.bnt_confirm = new System.Windows.Forms.Button();
            this.tb_cash_sold = new System.Windows.Forms.TextBox();
            this.tb_cash_buy = new System.Windows.Forms.TextBox();
            this.tb_compared = new System.Windows.Forms.TextBox();
            this.tb_rate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.combo_country = new System.Windows.Forms.ComboBox();
            this.country = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bnt_cancel
            // 
            this.bnt_cancel.Location = new System.Drawing.Point(405, 145);
            this.bnt_cancel.Name = "bnt_cancel";
            this.bnt_cancel.Size = new System.Drawing.Size(60, 60);
            this.bnt_cancel.TabIndex = 31;
            this.bnt_cancel.TabStop = false;
            this.bnt_cancel.UseVisualStyleBackColor = true;
            this.bnt_cancel.Click += new System.EventHandler(this.bnt_cancel_Click);
            // 
            // bnt_confirm
            // 
            this.bnt_confirm.Location = new System.Drawing.Point(405, 57);
            this.bnt_confirm.Name = "bnt_confirm";
            this.bnt_confirm.Size = new System.Drawing.Size(60, 60);
            this.bnt_confirm.TabIndex = 30;
            this.bnt_confirm.TabStop = false;
            this.bnt_confirm.UseVisualStyleBackColor = true;
            this.bnt_confirm.Click += new System.EventHandler(this.bnt_confirm_Click);
            // 
            // tb_cash_sold
            // 
            this.tb_cash_sold.Location = new System.Drawing.Point(115, 216);
            this.tb_cash_sold.Name = "tb_cash_sold";
            this.tb_cash_sold.Size = new System.Drawing.Size(161, 25);
            this.tb_cash_sold.TabIndex = 29;
            // 
            // tb_cash_buy
            // 
            this.tb_cash_buy.Location = new System.Drawing.Point(115, 176);
            this.tb_cash_buy.Name = "tb_cash_buy";
            this.tb_cash_buy.Size = new System.Drawing.Size(161, 25);
            this.tb_cash_buy.TabIndex = 28;
            // 
            // tb_compared
            // 
            this.tb_compared.Location = new System.Drawing.Point(115, 136);
            this.tb_compared.Name = "tb_compared";
            this.tb_compared.Size = new System.Drawing.Size(161, 25);
            this.tb_compared.TabIndex = 27;
            // 
            // tb_rate
            // 
            this.tb_rate.Location = new System.Drawing.Point(115, 96);
            this.tb_rate.Name = "tb_rate";
            this.tb_rate.Size = new System.Drawing.Size(161, 25);
            this.tb_rate.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(13, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "현찰(팔 때)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(35, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "전일대비";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "현찰(살 때)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(20, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "매매기준율";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date.Location = new System.Drawing.Point(67, 58);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(42, 22);
            this.date.TabIndex = 21;
            this.date.Text = "날짜";
            // 
            // combo_country
            // 
            this.combo_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_country.FormattingEnabled = true;
            this.combo_country.Location = new System.Drawing.Point(115, 16);
            this.combo_country.Name = "combo_country";
            this.combo_country.Size = new System.Drawing.Size(121, 23);
            this.combo_country.TabIndex = 18;
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.country.Location = new System.Drawing.Point(67, 18);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(42, 22);
            this.country.TabIndex = 20;
            this.country.Text = "나라";
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(115, 56);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(161, 25);
            this.tb_date.TabIndex = 19;
            // 
            // Country_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(502, 273);
            this.Controls.Add(this.bnt_cancel);
            this.Controls.Add(this.bnt_confirm);
            this.Controls.Add(this.tb_cash_sold);
            this.Controls.Add(this.tb_cash_buy);
            this.Controls.Add(this.tb_compared);
            this.Controls.Add(this.tb_rate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.combo_country);
            this.Controls.Add(this.country);
            this.Controls.Add(this.tb_date);
            this.Name = "Country_Update";
            this.Text = "일별시세 수정";
            this.Load += new System.EventHandler(this.Country_Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_cancel;
        private System.Windows.Forms.Button bnt_confirm;
        private System.Windows.Forms.TextBox tb_cash_sold;
        private System.Windows.Forms.TextBox tb_cash_buy;
        private System.Windows.Forms.TextBox tb_compared;
        private System.Windows.Forms.TextBox tb_rate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.ComboBox combo_country;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.TextBox tb_date;
    }
}