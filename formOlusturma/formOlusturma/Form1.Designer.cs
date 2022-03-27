
namespace formOlusturma
{
    partial class form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.girisBilgileri = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.bitisSayisi = new System.Windows.Forms.MaskedTextBox();
            this.lblBitis = new System.Windows.Forms.Label();
            this.baslangicSayisi = new System.Windows.Forms.MaskedTextBox();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TabControl();
            this.tekSayilar = new System.Windows.Forms.TabPage();
            this.listTek = new System.Windows.Forms.ListView();
            this.ciftSayilar = new System.Windows.Forms.TabPage();
            this.listCift = new System.Windows.Forms.ListView();
            this.asalSayilar = new System.Windows.Forms.TabPage();
            this.listAsal = new System.Windows.Forms.ListView();
            this.mukemmelSayilar = new System.Windows.Forms.TabPage();
            this.listMukemmel = new System.Windows.Forms.ListView();
            this.notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.girisBilgileri.SuspendLayout();
            this.x.SuspendLayout();
            this.tekSayilar.SuspendLayout();
            this.ciftSayilar.SuspendLayout();
            this.asalSayilar.SuspendLayout();
            this.mukemmelSayilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisBilgileri
            // 
            this.girisBilgileri.Controls.Add(this.btnTemizle);
            this.girisBilgileri.Controls.Add(this.btnCalistir);
            this.girisBilgileri.Controls.Add(this.bitisSayisi);
            this.girisBilgileri.Controls.Add(this.lblBitis);
            this.girisBilgileri.Controls.Add(this.baslangicSayisi);
            this.girisBilgileri.Controls.Add(this.lblBaslangic);
            this.girisBilgileri.Location = new System.Drawing.Point(26, 36);
            this.girisBilgileri.Name = "girisBilgileri";
            this.girisBilgileri.Size = new System.Drawing.Size(779, 173);
            this.girisBilgileri.TabIndex = 0;
            this.girisBilgileri.TabStop = false;
            this.girisBilgileri.Text = "GİRİŞ BİLGİLERİ";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(500, 84);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 29);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCalistir
            // 
            this.btnCalistir.Location = new System.Drawing.Point(500, 30);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(120, 46);
            this.btnCalistir.TabIndex = 4;
            this.btnCalistir.Text = "ÇALIŞTIR";
            this.btnCalistir.UseVisualStyleBackColor = true;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // bitisSayisi
            // 
            this.bitisSayisi.Location = new System.Drawing.Point(256, 85);
            this.bitisSayisi.Mask = "00000";
            this.bitisSayisi.Name = "bitisSayisi";
            this.bitisSayisi.Size = new System.Drawing.Size(125, 27);
            this.bitisSayisi.TabIndex = 3;
            this.bitisSayisi.ValidatingType = typeof(int);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(156, 88);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(81, 20);
            this.lblBitis.TabIndex = 2;
            this.lblBitis.Text = "Bitiş Sayısı:";
            // 
            // baslangicSayisi
            // 
            this.baslangicSayisi.Location = new System.Drawing.Point(256, 40);
            this.baslangicSayisi.Mask = "00000";
            this.baslangicSayisi.Name = "baslangicSayisi";
            this.baslangicSayisi.Size = new System.Drawing.Size(125, 27);
            this.baslangicSayisi.TabIndex = 1;
            this.baslangicSayisi.ValidatingType = typeof(int);
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(121, 47);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(116, 20);
            this.lblBaslangic.TabIndex = 0;
            this.lblBaslangic.Text = "Başlangıç Sayısı:";
            // 
            // x
            // 
            this.x.Controls.Add(this.tekSayilar);
            this.x.Controls.Add(this.ciftSayilar);
            this.x.Controls.Add(this.asalSayilar);
            this.x.Controls.Add(this.mukemmelSayilar);
            this.x.Location = new System.Drawing.Point(26, 235);
            this.x.Name = "x";
            this.x.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.x.SelectedIndex = 0;
            this.x.Size = new System.Drawing.Size(783, 452);
            this.x.TabIndex = 1;
            // 
            // tekSayilar
            // 
            this.tekSayilar.Controls.Add(this.listTek);
            this.tekSayilar.Location = new System.Drawing.Point(4, 29);
            this.tekSayilar.Name = "tekSayilar";
            this.tekSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tekSayilar.Size = new System.Drawing.Size(775, 419);
            this.tekSayilar.TabIndex = 0;
            this.tekSayilar.Text = "Tek sayılar";
            this.tekSayilar.UseVisualStyleBackColor = true;
            // 
            // listTek
            // 
            this.listTek.HideSelection = false;
            this.listTek.Location = new System.Drawing.Point(6, 17);
            this.listTek.Name = "listTek";
            this.listTek.Size = new System.Drawing.Size(763, 396);
            this.listTek.TabIndex = 2;
            this.listTek.UseCompatibleStateImageBehavior = false;
            this.listTek.View = System.Windows.Forms.View.List;
            // 
            // ciftSayilar
            // 
            this.ciftSayilar.Controls.Add(this.listCift);
            this.ciftSayilar.Location = new System.Drawing.Point(4, 29);
            this.ciftSayilar.Name = "ciftSayilar";
            this.ciftSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.ciftSayilar.Size = new System.Drawing.Size(775, 419);
            this.ciftSayilar.TabIndex = 1;
            this.ciftSayilar.Text = "Çift Sayılar";
            this.ciftSayilar.UseVisualStyleBackColor = true;
            // 
            // listCift
            // 
            this.listCift.HideSelection = false;
            this.listCift.Location = new System.Drawing.Point(6, 17);
            this.listCift.Name = "listCift";
            this.listCift.Size = new System.Drawing.Size(763, 396);
            this.listCift.TabIndex = 2;
            this.listCift.UseCompatibleStateImageBehavior = false;
            this.listCift.View = System.Windows.Forms.View.List;
            // 
            // asalSayilar
            // 
            this.asalSayilar.Controls.Add(this.listAsal);
            this.asalSayilar.Location = new System.Drawing.Point(4, 29);
            this.asalSayilar.Name = "asalSayilar";
            this.asalSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.asalSayilar.Size = new System.Drawing.Size(775, 419);
            this.asalSayilar.TabIndex = 2;
            this.asalSayilar.Text = "Asal Sayılar";
            this.asalSayilar.UseVisualStyleBackColor = true;
            // 
            // listAsal
            // 
            this.listAsal.HideSelection = false;
            this.listAsal.Location = new System.Drawing.Point(6, 17);
            this.listAsal.Name = "listAsal";
            this.listAsal.Size = new System.Drawing.Size(763, 396);
            this.listAsal.TabIndex = 1;
            this.listAsal.UseCompatibleStateImageBehavior = false;
            this.listAsal.View = System.Windows.Forms.View.List;
            // 
            // mukemmelSayilar
            // 
            this.mukemmelSayilar.Controls.Add(this.listMukemmel);
            this.mukemmelSayilar.Location = new System.Drawing.Point(4, 29);
            this.mukemmelSayilar.Name = "mukemmelSayilar";
            this.mukemmelSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.mukemmelSayilar.Size = new System.Drawing.Size(775, 419);
            this.mukemmelSayilar.TabIndex = 3;
            this.mukemmelSayilar.Text = "Mükemmel Sayılar";
            this.mukemmelSayilar.UseVisualStyleBackColor = true;
            // 
            // listMukemmel
            // 
            this.listMukemmel.HideSelection = false;
            this.listMukemmel.Location = new System.Drawing.Point(6, 16);
            this.listMukemmel.Name = "listMukemmel";
            this.listMukemmel.Size = new System.Drawing.Size(763, 397);
            this.listMukemmel.TabIndex = 0;
            this.listMukemmel.UseCompatibleStateImageBehavior = false;
            this.listMukemmel.View = System.Windows.Forms.View.List;
            // 
            // notification
            // 
            this.notification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notification.Icon = ((System.Drawing.Icon)(resources.GetObject("notification.Icon")));
            this.notification.Text = "bildirim";
            this.notification.Visible = true;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 699);
            this.Controls.Add(this.x);
            this.Controls.Add(this.girisBilgileri);
            this.Name = "form";
            this.Text = "Hesap Makinesi";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.form_Load);
            this.girisBilgileri.ResumeLayout(false);
            this.girisBilgileri.PerformLayout();
            this.x.ResumeLayout(false);
            this.tekSayilar.ResumeLayout(false);
            this.ciftSayilar.ResumeLayout(false);
            this.asalSayilar.ResumeLayout(false);
            this.mukemmelSayilar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox girisBilgileri;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.MaskedTextBox bitisSayisi;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.MaskedTextBox baslangicSayisi;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.TabControl x;
        private System.Windows.Forms.TabPage tekSayilar;
        private System.Windows.Forms.TabPage ciftSayilar;
        private System.Windows.Forms.TabPage asalSayilar;
        private System.Windows.Forms.TabPage mukemmelSayilar;
        private System.Windows.Forms.ListView listTek;
        private System.Windows.Forms.ListView listCift;
        private System.Windows.Forms.ListView listAsal;
        private System.Windows.Forms.ListView listMukemmel;
        private System.Windows.Forms.ListView l;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.NotifyIcon notification;
    }
}

