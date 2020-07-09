namespace DB_Host
{
    partial class Country_Edit_Insert
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
            this.tb_avg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.tb_country = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bnt_cancel
            // 
            this.bnt_cancel.Location = new System.Drawing.Point(237, 115);
            this.bnt_cancel.Name = "bnt_cancel";
            this.bnt_cancel.Size = new System.Drawing.Size(60, 60);
            this.bnt_cancel.TabIndex = 23;
            this.bnt_cancel.TabStop = false;
            this.bnt_cancel.UseVisualStyleBackColor = true;
            this.bnt_cancel.Click += new System.EventHandler(this.bnt_cancel_Click);
            // 
            // bnt_confirm
            // 
            this.bnt_confirm.Location = new System.Drawing.Point(237, 20);
            this.bnt_confirm.Name = "bnt_confirm";
            this.bnt_confirm.Size = new System.Drawing.Size(60, 60);
            this.bnt_confirm.TabIndex = 22;
            this.bnt_confirm.TabStop = false;
            this.bnt_confirm.UseVisualStyleBackColor = true;
            this.bnt_confirm.Click += new System.EventHandler(this.bnt_confirm_Click);
            // 
            // tb_avg
            // 
            this.tb_avg.Location = new System.Drawing.Point(24, 137);
            this.tb_avg.Name = "tb_avg";
            this.tb_avg.Size = new System.Drawing.Size(161, 25);
            this.tb_avg.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(20, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "월 평균 매매기준율";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.country.Location = new System.Drawing.Point(20, 30);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(42, 22);
            this.country.TabIndex = 19;
            this.country.Text = "나라";
            // 
            // tb_country
            // 
            this.tb_country.Location = new System.Drawing.Point(24, 55);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(161, 25);
            this.tb_country.TabIndex = 18;
            // 
            // Country_Edit_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(328, 192);
            this.Controls.Add(this.bnt_cancel);
            this.Controls.Add(this.bnt_confirm);
            this.Controls.Add(this.tb_avg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.country);
            this.Controls.Add(this.tb_country);
            this.Name = "Country_Edit_Insert";
            this.Text = "나라 추가";
            this.Load += new System.EventHandler(this.Country_Edit_Insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_cancel;
        private System.Windows.Forms.Button bnt_confirm;
        private System.Windows.Forms.TextBox tb_avg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.TextBox tb_country;
    }
}