namespace Yunus_İNAN_Ticari_Otomasyon_Sistemi
{
    partial class frmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMail));
            this.label1 = new System.Windows.Forms.Label();
            this.tx_mailAdres = new DevExpress.XtraEditors.TextEdit();
            this.tx_Konu = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.rtx_Mesaj = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Gonder = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tx_mailAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Konu.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi:";
            // 
            // tx_mailAdres
            // 
            this.tx_mailAdres.Location = new System.Drawing.Point(123, 151);
            this.tx_mailAdres.Name = "tx_mailAdres";
            this.tx_mailAdres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_mailAdres.Properties.Appearance.Options.UseFont = true;
            this.tx_mailAdres.Size = new System.Drawing.Size(299, 26);
            this.tx_mailAdres.TabIndex = 1;
            // 
            // tx_Konu
            // 
            this.tx_Konu.Location = new System.Drawing.Point(123, 192);
            this.tx_Konu.Name = "tx_Konu";
            this.tx_Konu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Konu.Properties.Appearance.Options.UseFont = true;
            this.tx_Konu.Size = new System.Drawing.Size(299, 26);
            this.tx_Konu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu:";
            // 
            // rtx_Mesaj
            // 
            this.rtx_Mesaj.Location = new System.Drawing.Point(124, 241);
            this.rtx_Mesaj.Name = "rtx_Mesaj";
            this.rtx_Mesaj.Size = new System.Drawing.Size(299, 295);
            this.rtx_Mesaj.TabIndex = 4;
            this.rtx_Mesaj.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesaj:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 137);
            this.panel1.TabIndex = 6;
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Gonder.Appearance.Options.UseFont = true;
            this.btn_Gonder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btn_Gonder.Location = new System.Drawing.Point(176, 546);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(204, 39);
            this.btn_Gonder.TabIndex = 7;
            this.btn_Gonder.Text = "Gönder";
            this.btn_Gonder.Click += new System.EventHandler(this.btn_Gonder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LightCyan;
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail Gönderme Paneli";
            // 
            // frmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 603);
            this.Controls.Add(this.btn_Gonder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtx_Mesaj);
            this.Controls.Add(this.tx_Konu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_mailAdres);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAİL";
            this.Load += new System.EventHandler(this.frmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tx_mailAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Konu.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit tx_mailAdres;
        private DevExpress.XtraEditors.TextEdit tx_Konu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtx_Mesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_Gonder;
    }
}