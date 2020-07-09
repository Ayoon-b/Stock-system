namespace DB_Host
{
    partial class Menu_Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.bnt_country = new System.Windows.Forms.Button();
            this.bnt_market = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_country = new System.Windows.Forms.Label();
            this.lb_market = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(173, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "주식 서비스";
            // 
            // bnt_country
            // 
            this.bnt_country.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bnt_country.Font = new System.Drawing.Font("돋움체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_country.Location = new System.Drawing.Point(85, 380);
            this.bnt_country.Name = "bnt_country";
            this.bnt_country.Size = new System.Drawing.Size(100, 100);
            this.bnt_country.TabIndex = 1;
            this.bnt_country.TabStop = false;
            this.bnt_country.UseVisualStyleBackColor = false;
            this.bnt_country.Click += new System.EventHandler(this.bnt_country_Click);
            // 
            // bnt_market
            // 
            this.bnt_market.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bnt_market.Font = new System.Drawing.Font("돋움체", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bnt_market.Location = new System.Drawing.Point(325, 380);
            this.bnt_market.Name = "bnt_market";
            this.bnt_market.Size = new System.Drawing.Size(100, 100);
            this.bnt_market.TabIndex = 2;
            this.bnt_market.TabStop = false;
            this.bnt_market.UseVisualStyleBackColor = false;
            this.bnt_market.Click += new System.EventHandler(this.bnt_market_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lb_country
            // 
            this.lb_country.AutoSize = true;
            this.lb_country.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_country.Location = new System.Drawing.Point(97, 483);
            this.lb_country.Name = "lb_country";
            this.lb_country.Size = new System.Drawing.Size(78, 23);
            this.lb_country.TabIndex = 4;
            this.lb_country.Text = "시장지표";
            // 
            // lb_market
            // 
            this.lb_market.AutoSize = true;
            this.lb_market.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_market.Location = new System.Drawing.Point(337, 483);
            this.lb_market.Name = "lb_market";
            this.lb_market.Size = new System.Drawing.Size(78, 23);
            this.lb_market.TabIndex = 5;
            this.lb_market.Text = "해외증시";
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(502, 593);
            this.Controls.Add(this.lb_market);
            this.Controls.Add(this.lb_country);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bnt_market);
            this.Controls.Add(this.bnt_country);
            this.Controls.Add(this.label1);
            this.Name = "Menu_Form";
            this.Text = "주식 서비스";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_country;
        private System.Windows.Forms.Button bnt_market;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_country;
        private System.Windows.Forms.Label lb_market;
    }
}

