namespace ISharp_Temiz_Kod
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_Kadi = new System.Windows.Forms.TextBox();
            this.txt_Şifre = new System.Windows.Forms.TextBox();
            this.check_Kaydet = new System.Windows.Forms.CheckBox();
            this.btn_Giriş = new System.Windows.Forms.Button();
            this.group_TelefonOnay = new System.Windows.Forms.GroupBox();
            this.btn_TelefonOnayi = new System.Windows.Forms.Button();
            this.txt_TelefonOnay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.group_KoduDoğrula = new System.Windows.Forms.GroupBox();
            this.ResendButton = new System.Windows.Forms.Button();
            this.btn_Doğrula = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVerifyCode = new System.Windows.Forms.TextBox();
            this.LblForSmsEmail = new System.Windows.Forms.Label();
            this.group_DoğrulamaSeç = new System.Windows.Forms.GroupBox();
            this.btn_KodGönder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RadioVerifyWithEmail = new System.Windows.Forms.RadioButton();
            this.RadioVerifyWithPhoneNumber = new System.Windows.Forms.RadioButton();
            this.group_İkiFaktör = new System.Windows.Forms.GroupBox();
            this.btn_İkiFaktör = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTwoFactorCode = new System.Windows.Forms.TextBox();
            this.groupGiriş = new System.Windows.Forms.GroupBox();
            this.pic_ProfilResmi = new System.Windows.Forms.PictureBox();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_Takipçi = new System.Windows.Forms.Label();
            this.lbl_TakipEdilen = new System.Windows.Forms.Label();
            this.lbl_Gonderi = new System.Windows.Forms.Label();
            this.group_Profil = new System.Windows.Forms.GroupBox();
            this.txt_Biyografi = new System.Windows.Forms.TextBox();
            this.Mesaj = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_HedefKonum = new System.Windows.Forms.TextBox();
            this.txt_HedefHash = new System.Windows.Forms.TextBox();
            this.btn_HedefKaydet = new System.Windows.Forms.Button();
            this.btn_KonumEkle = new System.Windows.Forms.Button();
            this.btn_HashtagEkle = new System.Windows.Forms.Button();
            this.btn_KişiEkle = new System.Windows.Forms.Button();
            this.txt_HedefKişi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_BegeniBasla = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_BegeniKonum = new System.Windows.Forms.TextBox();
            this.txt_BegeniHash = new System.Windows.Forms.TextBox();
            this.txt_BegeniSayfa = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_YorumYorum = new System.Windows.Forms.TextBox();
            this.btn_Yorum = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txt_YorumKonum = new System.Windows.Forms.TextBox();
            this.txt_YorumHashtag = new System.Windows.Forms.TextBox();
            this.txt_YorumSayfa = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_Rapor = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txt_YardımPost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Açıklama = new System.Windows.Forms.TextBox();
            this.btn_Yükle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Etiket = new System.Windows.Forms.TextBox();
            this.lbl_Dosyayolu = new System.Windows.Forms.Label();
            this.pic_onizleme = new System.Windows.Forms.PictureBox();
            this.btn_DosyaSeç = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btn_Story = new System.Windows.Forms.Button();
            this.group_StoryAyar = new System.Windows.Forms.GroupBox();
            this.radio_StoryKonum = new System.Windows.Forms.RadioButton();
            this.radio_StoryHashtag = new System.Windows.Forms.RadioButton();
            this.radio_StoryAnket = new System.Windows.Forms.RadioButton();
            this.radio_StoryEtiket = new System.Windows.Forms.RadioButton();
            this.radio_StorySoru = new System.Windows.Forms.RadioButton();
            this.pic_StoryOnizleme = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_storyDosyaKonum = new System.Windows.Forms.Label();
            this.btn_StorySeç = new System.Windows.Forms.Button();
            this.group_StorySoruSor = new System.Windows.Forms.GroupBox();
            this.txt_groupSoruSor_yazirenk = new System.Windows.Forms.TextBox();
            this.txt_groupSoruSor_ArkaPlanRenk = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_groupSoruSor_Soru = new System.Windows.Forms.TextBox();
            this.txt_groupSoruSor_Rota = new System.Windows.Forms.TextBox();
            this.txt_groupSoruSor_Y = new System.Windows.Forms.TextBox();
            this.txt_groupSoruSor_X = new System.Windows.Forms.TextBox();
            this.group_StoryKonum = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_StoryKonumRota = new System.Windows.Forms.TextBox();
            this.txt_StoryKonumY = new System.Windows.Forms.TextBox();
            this.txt_StoryKonumX = new System.Windows.Forms.TextBox();
            this.txt_StoryKonumİsim = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.group_StoryEtiket = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_StoryEtiket = new System.Windows.Forms.TextBox();
            this.txt_StoryEtiketRota = new System.Windows.Forms.TextBox();
            this.txt_StoryEtiketY = new System.Windows.Forms.TextBox();
            this.txt_StoryEtiketX = new System.Windows.Forms.TextBox();
            this.group_StoryHashtag = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_StoryHashtag = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_StoryHashtagRota = new System.Windows.Forms.TextBox();
            this.txt_StoryHashtagY = new System.Windows.Forms.TextBox();
            this.txt_StoryHashtagX = new System.Windows.Forms.TextBox();
            this.group_StoryAnket = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_StoryAnketRota = new System.Windows.Forms.TextBox();
            this.txt_StoryAnketY = new System.Windows.Forms.TextBox();
            this.txt_StoryAnketX = new System.Windows.Forms.TextBox();
            this.txt_StoryAnketCevap2 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_StoryAnketCevap1 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_StoryAnketSoru = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btn_Başla = new System.Windows.Forms.Button();
            this.chk_Windows = new System.Windows.Forms.CheckBox();
            this.btn_KaydetBaşlaDurdur = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.btn_MesajBaşla = new System.Windows.Forms.Button();
            this.txt_MesajCevapları = new System.Windows.Forms.TextBox();
            this.btn_MesajCevapEkle = new System.Windows.Forms.Button();
            this.txt_MesajCevap = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txt_MesajAranacakKelime = new System.Windows.Forms.TextBox();
            this.chk_MesajOtoYanit = new System.Windows.Forms.CheckBox();
            this.btn_MesajKaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Mesaj = new System.Windows.Forms.TextBox();
            this.chk_MesajYeniTakip = new System.Windows.Forms.CheckBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.btn_TakipBasla = new System.Windows.Forms.Button();
            this.txt_TakipEdenler = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txt_TakipEttikleri = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txt_TakipKonum = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txt_TakipHashtag = new System.Windows.Forms.TextBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.btn_Veri_Cikar = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.veri_Cikar_profil_al_konum = new System.Windows.Forms.CheckBox();
            this.veri_Cikar_konum_al_konum = new System.Windows.Forms.CheckBox();
            this.veri_Cikar_mail_al_konum = new System.Windows.Forms.CheckBox();
            this.veri_Cikar_telefon_al_konum = new System.Windows.Forms.CheckBox();
            this.txt_Veri_Cikar_konum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.veri_Cikar_profil_al_sayfa = new System.Windows.Forms.CheckBox();
            this.veri_Cikar_konum_al_sayfa = new System.Windows.Forms.CheckBox();
            this.veri_Cikar_mail_al_sayfa = new System.Windows.Forms.CheckBox();
            this.veri_Cikar_telefon_al_sayfa = new System.Windows.Forms.CheckBox();
            this.txt_veri_Cikar_sayfa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.veri_Cikar_profil_al_hash = new System.Windows.Forms.CheckBox();
            this.veri_Cikar_konum_al_hash = new System.Windows.Forms.CheckBox();
            this.veri_Cikar_mail_al_hash = new System.Windows.Forms.CheckBox();
            this.veri_Cikar_Telefon_al_hash = new System.Windows.Forms.CheckBox();
            this.txt_veri_Cikar_hashtag = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer_Begeni = new System.Windows.Forms.Timer(this.components);
            this.timer_Mesaj = new System.Windows.Forms.Timer(this.components);
            this.timer_Yorum = new System.Windows.Forms.Timer(this.components);
            this.group_TelefonOnay.SuspendLayout();
            this.group_KoduDoğrula.SuspendLayout();
            this.group_DoğrulamaSeç.SuspendLayout();
            this.group_İkiFaktör.SuspendLayout();
            this.groupGiriş.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProfilResmi)).BeginInit();
            this.group_Profil.SuspendLayout();
            this.Mesaj.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_onizleme)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.group_StoryAyar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StoryOnizleme)).BeginInit();
            this.group_StorySoruSor.SuspendLayout();
            this.group_StoryKonum.SuspendLayout();
            this.group_StoryEtiket.SuspendLayout();
            this.group_StoryHashtag.SuspendLayout();
            this.group_StoryAnket.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Kadi
            // 
            this.txt_Kadi.Location = new System.Drawing.Point(12, 23);
            this.txt_Kadi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Kadi.Name = "txt_Kadi";
            this.txt_Kadi.Size = new System.Drawing.Size(132, 22);
            this.txt_Kadi.TabIndex = 0;
            this.txt_Kadi.Text = "Kullanıcı Adı";
            // 
            // txt_Şifre
            // 
            this.txt_Şifre.Location = new System.Drawing.Point(12, 55);
            this.txt_Şifre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Şifre.Name = "txt_Şifre";
            this.txt_Şifre.PasswordChar = '*';
            this.txt_Şifre.Size = new System.Drawing.Size(132, 22);
            this.txt_Şifre.TabIndex = 1;
            this.txt_Şifre.Text = "Şifre";
            // 
            // check_Kaydet
            // 
            this.check_Kaydet.AutoSize = true;
            this.check_Kaydet.Location = new System.Drawing.Point(12, 87);
            this.check_Kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.check_Kaydet.Name = "check_Kaydet";
            this.check_Kaydet.Size = new System.Drawing.Size(134, 21);
            this.check_Kaydet.TabIndex = 2;
            this.check_Kaydet.Text = "Bilgilerimi Hatırla";
            this.check_Kaydet.UseVisualStyleBackColor = true;
            // 
            // btn_Giriş
            // 
            this.btn_Giriş.Location = new System.Drawing.Point(12, 116);
            this.btn_Giriş.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Giriş.Name = "btn_Giriş";
            this.btn_Giriş.Size = new System.Drawing.Size(133, 28);
            this.btn_Giriş.TabIndex = 3;
            this.btn_Giriş.Text = "Giriş";
            this.btn_Giriş.UseVisualStyleBackColor = true;
            this.btn_Giriş.Click += new System.EventHandler(this.btn_Giriş_Click);
            // 
            // group_TelefonOnay
            // 
            this.group_TelefonOnay.Controls.Add(this.btn_TelefonOnayi);
            this.group_TelefonOnay.Controls.Add(this.txt_TelefonOnay);
            this.group_TelefonOnay.Controls.Add(this.label6);
            this.group_TelefonOnay.Location = new System.Drawing.Point(11, 181);
            this.group_TelefonOnay.Margin = new System.Windows.Forms.Padding(4);
            this.group_TelefonOnay.Name = "group_TelefonOnay";
            this.group_TelefonOnay.Padding = new System.Windows.Forms.Padding(4);
            this.group_TelefonOnay.Size = new System.Drawing.Size(365, 98);
            this.group_TelefonOnay.TabIndex = 16;
            this.group_TelefonOnay.TabStop = false;
            this.group_TelefonOnay.Text = "Telefon numaranızı onaylamanız gerekli";
            this.group_TelefonOnay.Visible = false;
            // 
            // btn_TelefonOnayi
            // 
            this.btn_TelefonOnayi.Location = new System.Drawing.Point(168, 63);
            this.btn_TelefonOnayi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TelefonOnayi.Name = "btn_TelefonOnayi";
            this.btn_TelefonOnayi.Size = new System.Drawing.Size(189, 28);
            this.btn_TelefonOnayi.TabIndex = 5;
            this.btn_TelefonOnayi.Text = "Kodu gönder";
            this.btn_TelefonOnayi.UseVisualStyleBackColor = true;
            this.btn_TelefonOnayi.Click += new System.EventHandler(this.btn_TelefonOnayi_Click);
            // 
            // txt_TelefonOnay
            // 
            this.txt_TelefonOnay.Location = new System.Drawing.Point(148, 31);
            this.txt_TelefonOnay.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TelefonOnay.Name = "txt_TelefonOnay";
            this.txt_TelefonOnay.Size = new System.Drawing.Size(208, 22);
            this.txt_TelefonOnay.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Telefon Numarası:";
            // 
            // group_KoduDoğrula
            // 
            this.group_KoduDoğrula.Controls.Add(this.ResendButton);
            this.group_KoduDoğrula.Controls.Add(this.btn_Doğrula);
            this.group_KoduDoğrula.Controls.Add(this.label4);
            this.group_KoduDoğrula.Controls.Add(this.txtVerifyCode);
            this.group_KoduDoğrula.Controls.Add(this.LblForSmsEmail);
            this.group_KoduDoğrula.Location = new System.Drawing.Point(11, 181);
            this.group_KoduDoğrula.Margin = new System.Windows.Forms.Padding(4);
            this.group_KoduDoğrula.Name = "group_KoduDoğrula";
            this.group_KoduDoğrula.Padding = new System.Windows.Forms.Padding(4);
            this.group_KoduDoğrula.Size = new System.Drawing.Size(385, 139);
            this.group_KoduDoğrula.TabIndex = 17;
            this.group_KoduDoğrula.TabStop = false;
            this.group_KoduDoğrula.Text = "Kod ile Doğrulama";
            this.group_KoduDoğrula.Visible = false;
            // 
            // ResendButton
            // 
            this.ResendButton.Location = new System.Drawing.Point(7, 98);
            this.ResendButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResendButton.Name = "ResendButton";
            this.ResendButton.Size = new System.Drawing.Size(179, 28);
            this.ResendButton.TabIndex = 12;
            this.ResendButton.Text = "Yeniden gönder";
            this.ResendButton.UseVisualStyleBackColor = true;
            // 
            // btn_Doğrula
            // 
            this.btn_Doğrula.Location = new System.Drawing.Point(193, 98);
            this.btn_Doğrula.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Doğrula.Name = "btn_Doğrula";
            this.btn_Doğrula.Size = new System.Drawing.Size(100, 28);
            this.btn_Doğrula.TabIndex = 11;
            this.btn_Doğrula.Text = "Doğrula";
            this.btn_Doğrula.UseVisualStyleBackColor = true;
            this.btn_Doğrula.Click += new System.EventHandler(this.btn_Doğrula_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doğrulama kodu:";
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.Location = new System.Drawing.Point(132, 66);
            this.txtVerifyCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.Size = new System.Drawing.Size(227, 22);
            this.txtVerifyCode.TabIndex = 6;
            // 
            // LblForSmsEmail
            // 
            this.LblForSmsEmail.AutoSize = true;
            this.LblForSmsEmail.Location = new System.Drawing.Point(8, 34);
            this.LblForSmsEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblForSmsEmail.Name = "LblForSmsEmail";
            this.LblForSmsEmail.Size = new System.Drawing.Size(312, 17);
            this.LblForSmsEmail.TabIndex = 1;
            this.LblForSmsEmail.Text = "Size doğrulama kodunu email/sms ile gönderdik.";
            this.LblForSmsEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // group_DoğrulamaSeç
            // 
            this.group_DoğrulamaSeç.Controls.Add(this.btn_KodGönder);
            this.group_DoğrulamaSeç.Controls.Add(this.label3);
            this.group_DoğrulamaSeç.Controls.Add(this.RadioVerifyWithEmail);
            this.group_DoğrulamaSeç.Controls.Add(this.RadioVerifyWithPhoneNumber);
            this.group_DoğrulamaSeç.Location = new System.Drawing.Point(11, 181);
            this.group_DoğrulamaSeç.Margin = new System.Windows.Forms.Padding(4);
            this.group_DoğrulamaSeç.Name = "group_DoğrulamaSeç";
            this.group_DoğrulamaSeç.Padding = new System.Windows.Forms.Padding(4);
            this.group_DoğrulamaSeç.Size = new System.Drawing.Size(253, 192);
            this.group_DoğrulamaSeç.TabIndex = 18;
            this.group_DoğrulamaSeç.TabStop = false;
            this.group_DoğrulamaSeç.Text = "Challenge gerekli";
            this.group_DoğrulamaSeç.Visible = false;
            // 
            // btn_KodGönder
            // 
            this.btn_KodGönder.Location = new System.Drawing.Point(39, 148);
            this.btn_KodGönder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KodGönder.Name = "btn_KodGönder";
            this.btn_KodGönder.Size = new System.Drawing.Size(100, 28);
            this.btn_KodGönder.TabIndex = 10;
            this.btn_KodGönder.Text = "Kodu Gönder";
            this.btn_KodGönder.UseVisualStyleBackColor = true;
            this.btn_KodGönder.Click += new System.EventHandler(this.btn_KodGönder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hesabınızı doğrulamanız gerekli.\r\nLütfen doğrulama metodu seçin.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RadioVerifyWithEmail
            // 
            this.RadioVerifyWithEmail.AutoSize = true;
            this.RadioVerifyWithEmail.Location = new System.Drawing.Point(39, 116);
            this.RadioVerifyWithEmail.Margin = new System.Windows.Forms.Padding(4);
            this.RadioVerifyWithEmail.Name = "RadioVerifyWithEmail";
            this.RadioVerifyWithEmail.Size = new System.Drawing.Size(63, 21);
            this.RadioVerifyWithEmail.TabIndex = 9;
            this.RadioVerifyWithEmail.Text = "Email";
            this.RadioVerifyWithEmail.UseVisualStyleBackColor = true;
            this.RadioVerifyWithEmail.Visible = false;
            // 
            // RadioVerifyWithPhoneNumber
            // 
            this.RadioVerifyWithPhoneNumber.AutoSize = true;
            this.RadioVerifyWithPhoneNumber.Checked = true;
            this.RadioVerifyWithPhoneNumber.Location = new System.Drawing.Point(39, 87);
            this.RadioVerifyWithPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.RadioVerifyWithPhoneNumber.Name = "RadioVerifyWithPhoneNumber";
            this.RadioVerifyWithPhoneNumber.Size = new System.Drawing.Size(77, 21);
            this.RadioVerifyWithPhoneNumber.TabIndex = 8;
            this.RadioVerifyWithPhoneNumber.TabStop = true;
            this.RadioVerifyWithPhoneNumber.Text = "Telefon";
            this.RadioVerifyWithPhoneNumber.UseVisualStyleBackColor = true;
            this.RadioVerifyWithPhoneNumber.Visible = false;
            // 
            // group_İkiFaktör
            // 
            this.group_İkiFaktör.Controls.Add(this.btn_İkiFaktör);
            this.group_İkiFaktör.Controls.Add(this.label5);
            this.group_İkiFaktör.Controls.Add(this.txtTwoFactorCode);
            this.group_İkiFaktör.Location = new System.Drawing.Point(181, 31);
            this.group_İkiFaktör.Margin = new System.Windows.Forms.Padding(4);
            this.group_İkiFaktör.Name = "group_İkiFaktör";
            this.group_İkiFaktör.Padding = new System.Windows.Forms.Padding(4);
            this.group_İkiFaktör.Size = new System.Drawing.Size(215, 128);
            this.group_İkiFaktör.TabIndex = 19;
            this.group_İkiFaktör.TabStop = false;
            this.group_İkiFaktör.Text = "İki faktörlü doğrulama";
            this.group_İkiFaktör.Visible = false;
            // 
            // btn_İkiFaktör
            // 
            this.btn_İkiFaktör.Location = new System.Drawing.Point(87, 71);
            this.btn_İkiFaktör.Margin = new System.Windows.Forms.Padding(4);
            this.btn_İkiFaktör.Name = "btn_İkiFaktör";
            this.btn_İkiFaktör.Size = new System.Drawing.Size(108, 28);
            this.btn_İkiFaktör.TabIndex = 5;
            this.btn_İkiFaktör.Text = "Gönder";
            this.btn_İkiFaktör.UseVisualStyleBackColor = true;
            this.btn_İkiFaktör.Click += new System.EventHandler(this.btn_İkiFaktör_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kod:";
            // 
            // txtTwoFactorCode
            // 
            this.txtTwoFactorCode.Location = new System.Drawing.Point(89, 31);
            this.txtTwoFactorCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtTwoFactorCode.Name = "txtTwoFactorCode";
            this.txtTwoFactorCode.Size = new System.Drawing.Size(107, 22);
            this.txtTwoFactorCode.TabIndex = 4;
            // 
            // groupGiriş
            // 
            this.groupGiriş.Controls.Add(this.btn_Giriş);
            this.groupGiriş.Controls.Add(this.txt_Kadi);
            this.groupGiriş.Controls.Add(this.txt_Şifre);
            this.groupGiriş.Controls.Add(this.check_Kaydet);
            this.groupGiriş.Location = new System.Drawing.Point(11, 15);
            this.groupGiriş.Margin = new System.Windows.Forms.Padding(4);
            this.groupGiriş.Name = "groupGiriş";
            this.groupGiriş.Padding = new System.Windows.Forms.Padding(4);
            this.groupGiriş.Size = new System.Drawing.Size(157, 159);
            this.groupGiriş.TabIndex = 20;
            this.groupGiriş.TabStop = false;
            this.groupGiriş.Text = "Giriş";
            // 
            // pic_ProfilResmi
            // 
            this.pic_ProfilResmi.Location = new System.Drawing.Point(35, 28);
            this.pic_ProfilResmi.Margin = new System.Windows.Forms.Padding(4);
            this.pic_ProfilResmi.Name = "pic_ProfilResmi";
            this.pic_ProfilResmi.Size = new System.Drawing.Size(133, 123);
            this.pic_ProfilResmi.TabIndex = 21;
            this.pic_ProfilResmi.TabStop = false;
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(87, 171);
            this.lbl_KullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(30, 17);
            this.lbl_KullaniciAdi.TabIndex = 22;
            this.lbl_KullaniciAdi.Text = "null";
            // 
            // lbl_Takipçi
            // 
            this.lbl_Takipçi.AutoSize = true;
            this.lbl_Takipçi.Location = new System.Drawing.Point(35, 194);
            this.lbl_Takipçi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Takipçi.Name = "lbl_Takipçi";
            this.lbl_Takipçi.Size = new System.Drawing.Size(61, 17);
            this.lbl_Takipçi.TabIndex = 23;
            this.lbl_Takipçi.Text = "Takipçi :";
            // 
            // lbl_TakipEdilen
            // 
            this.lbl_TakipEdilen.AutoSize = true;
            this.lbl_TakipEdilen.Location = new System.Drawing.Point(35, 225);
            this.lbl_TakipEdilen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TakipEdilen.Name = "lbl_TakipEdilen";
            this.lbl_TakipEdilen.Size = new System.Drawing.Size(94, 17);
            this.lbl_TakipEdilen.TabIndex = 24;
            this.lbl_TakipEdilen.Text = "Takip Edilen :";
            // 
            // lbl_Gonderi
            // 
            this.lbl_Gonderi.AutoSize = true;
            this.lbl_Gonderi.Location = new System.Drawing.Point(39, 257);
            this.lbl_Gonderi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gonderi.Name = "lbl_Gonderi";
            this.lbl_Gonderi.Size = new System.Drawing.Size(30, 17);
            this.lbl_Gonderi.TabIndex = 25;
            this.lbl_Gonderi.Text = "null";
            // 
            // group_Profil
            // 
            this.group_Profil.Controls.Add(this.txt_Biyografi);
            this.group_Profil.Controls.Add(this.pic_ProfilResmi);
            this.group_Profil.Controls.Add(this.lbl_KullaniciAdi);
            this.group_Profil.Controls.Add(this.lbl_Gonderi);
            this.group_Profil.Controls.Add(this.lbl_Takipçi);
            this.group_Profil.Controls.Add(this.lbl_TakipEdilen);
            this.group_Profil.Location = new System.Drawing.Point(628, 7);
            this.group_Profil.Margin = new System.Windows.Forms.Padding(4);
            this.group_Profil.Name = "group_Profil";
            this.group_Profil.Padding = new System.Windows.Forms.Padding(4);
            this.group_Profil.Size = new System.Drawing.Size(204, 357);
            this.group_Profil.TabIndex = 27;
            this.group_Profil.TabStop = false;
            this.group_Profil.Text = "Profil";
            this.group_Profil.Visible = false;
            // 
            // txt_Biyografi
            // 
            this.txt_Biyografi.Location = new System.Drawing.Point(8, 277);
            this.txt_Biyografi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Biyografi.Multiline = true;
            this.txt_Biyografi.Name = "txt_Biyografi";
            this.txt_Biyografi.ReadOnly = true;
            this.txt_Biyografi.Size = new System.Drawing.Size(187, 72);
            this.txt_Biyografi.TabIndex = 27;
            // 
            // Mesaj
            // 
            this.Mesaj.Controls.Add(this.tabPage1);
            this.Mesaj.Controls.Add(this.tabPage2);
            this.Mesaj.Controls.Add(this.tabPage3);
            this.Mesaj.Controls.Add(this.tabPage4);
            this.Mesaj.Controls.Add(this.tabPage5);
            this.Mesaj.Controls.Add(this.tabPage6);
            this.Mesaj.Controls.Add(this.tabPage7);
            this.Mesaj.Controls.Add(this.tabPage8);
            this.Mesaj.Controls.Add(this.tabPage9);
            this.Mesaj.Controls.Add(this.tabPage10);
            this.Mesaj.Location = new System.Drawing.Point(404, 47);
            this.Mesaj.Margin = new System.Windows.Forms.Padding(4);
            this.Mesaj.Name = "Mesaj";
            this.Mesaj.SelectedIndex = 0;
            this.Mesaj.Size = new System.Drawing.Size(609, 366);
            this.Mesaj.TabIndex = 28;
            this.Mesaj.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_HedefKonum);
            this.tabPage1.Controls.Add(this.txt_HedefHash);
            this.tabPage1.Controls.Add(this.btn_HedefKaydet);
            this.tabPage1.Controls.Add(this.btn_KonumEkle);
            this.tabPage1.Controls.Add(this.btn_HashtagEkle);
            this.tabPage1.Controls.Add(this.btn_KişiEkle);
            this.tabPage1.Controls.Add(this.txt_HedefKişi);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(601, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hedef";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_HedefKonum
            // 
            this.txt_HedefKonum.Enabled = false;
            this.txt_HedefKonum.Location = new System.Drawing.Point(367, 5);
            this.txt_HedefKonum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HedefKonum.Multiline = true;
            this.txt_HedefKonum.Name = "txt_HedefKonum";
            this.txt_HedefKonum.Size = new System.Drawing.Size(163, 246);
            this.txt_HedefKonum.TabIndex = 6;
            // 
            // txt_HedefHash
            // 
            this.txt_HedefHash.Enabled = false;
            this.txt_HedefHash.Location = new System.Drawing.Point(185, 7);
            this.txt_HedefHash.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HedefHash.Multiline = true;
            this.txt_HedefHash.Name = "txt_HedefHash";
            this.txt_HedefHash.Size = new System.Drawing.Size(163, 246);
            this.txt_HedefHash.TabIndex = 5;
            // 
            // btn_HedefKaydet
            // 
            this.btn_HedefKaydet.Enabled = false;
            this.btn_HedefKaydet.Location = new System.Drawing.Point(432, 298);
            this.btn_HedefKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HedefKaydet.Name = "btn_HedefKaydet";
            this.btn_HedefKaydet.Size = new System.Drawing.Size(159, 28);
            this.btn_HedefKaydet.TabIndex = 4;
            this.btn_HedefKaydet.Text = "Listeyi Kaydet";
            this.btn_HedefKaydet.UseVisualStyleBackColor = true;
            this.btn_HedefKaydet.Click += new System.EventHandler(this.btn_HedefKaydet_Click);
            // 
            // btn_KonumEkle
            // 
            this.btn_KonumEkle.Enabled = false;
            this.btn_KonumEkle.Location = new System.Drawing.Point(367, 262);
            this.btn_KonumEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KonumEkle.Name = "btn_KonumEkle";
            this.btn_KonumEkle.Size = new System.Drawing.Size(137, 28);
            this.btn_KonumEkle.TabIndex = 3;
            this.btn_KonumEkle.Text = "Konum Ekle";
            this.btn_KonumEkle.UseVisualStyleBackColor = true;
            this.btn_KonumEkle.Click += new System.EventHandler(this.btn_KonumEkle_Click);
            // 
            // btn_HashtagEkle
            // 
            this.btn_HashtagEkle.Enabled = false;
            this.btn_HashtagEkle.Location = new System.Drawing.Point(185, 262);
            this.btn_HashtagEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HashtagEkle.Name = "btn_HashtagEkle";
            this.btn_HashtagEkle.Size = new System.Drawing.Size(129, 28);
            this.btn_HashtagEkle.TabIndex = 2;
            this.btn_HashtagEkle.Text = "Hashtag ekle";
            this.btn_HashtagEkle.UseVisualStyleBackColor = true;
            this.btn_HashtagEkle.Click += new System.EventHandler(this.btn_HashtagEkle_Click);
            // 
            // btn_KişiEkle
            // 
            this.btn_KişiEkle.Enabled = false;
            this.btn_KişiEkle.Location = new System.Drawing.Point(8, 262);
            this.btn_KişiEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KişiEkle.Name = "btn_KişiEkle";
            this.btn_KişiEkle.Size = new System.Drawing.Size(107, 28);
            this.btn_KişiEkle.TabIndex = 1;
            this.btn_KişiEkle.Text = "Kişi Ekle";
            this.btn_KişiEkle.UseVisualStyleBackColor = true;
            this.btn_KişiEkle.Click += new System.EventHandler(this.btn_KişiEkle_Click);
            // 
            // txt_HedefKişi
            // 
            this.txt_HedefKişi.Enabled = false;
            this.txt_HedefKişi.Location = new System.Drawing.Point(5, 7);
            this.txt_HedefKişi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HedefKişi.Multiline = true;
            this.txt_HedefKişi.Name = "txt_HedefKişi";
            this.txt_HedefKişi.Size = new System.Drawing.Size(163, 246);
            this.txt_HedefKişi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_BegeniBasla);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_BegeniKonum);
            this.tabPage2.Controls.Add(this.txt_BegeniHash);
            this.tabPage2.Controls.Add(this.txt_BegeniSayfa);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(601, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Beğeni";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_BegeniBasla
            // 
            this.btn_BegeniBasla.Location = new System.Drawing.Point(467, 245);
            this.btn_BegeniBasla.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BegeniBasla.Name = "btn_BegeniBasla";
            this.btn_BegeniBasla.Size = new System.Drawing.Size(100, 66);
            this.btn_BegeniBasla.TabIndex = 8;
            this.btn_BegeniBasla.Text = "Beğeni İşlemini Başlat";
            this.btn_BegeniBasla.UseVisualStyleBackColor = true;
            this.btn_BegeniBasla.Click += new System.EventHandler(this.btn_BegeniBasla_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 198);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Her Satıra 1 Adet Ekleyin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Konum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hashtag";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Kişi/Sayfa";
            // 
            // txt_BegeniKonum
            // 
            this.txt_BegeniKonum.Location = new System.Drawing.Point(297, 241);
            this.txt_BegeniKonum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BegeniKonum.Multiline = true;
            this.txt_BegeniKonum.Name = "txt_BegeniKonum";
            this.txt_BegeniKonum.Size = new System.Drawing.Size(132, 84);
            this.txt_BegeniKonum.TabIndex = 2;
            // 
            // txt_BegeniHash
            // 
            this.txt_BegeniHash.Location = new System.Drawing.Point(155, 241);
            this.txt_BegeniHash.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BegeniHash.Multiline = true;
            this.txt_BegeniHash.Name = "txt_BegeniHash";
            this.txt_BegeniHash.Size = new System.Drawing.Size(132, 84);
            this.txt_BegeniHash.TabIndex = 1;
            // 
            // txt_BegeniSayfa
            // 
            this.txt_BegeniSayfa.Location = new System.Drawing.Point(12, 241);
            this.txt_BegeniSayfa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BegeniSayfa.Multiline = true;
            this.txt_BegeniSayfa.Name = "txt_BegeniSayfa";
            this.txt_BegeniSayfa.Size = new System.Drawing.Size(132, 84);
            this.txt_BegeniSayfa.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_YorumYorum);
            this.tabPage3.Controls.Add(this.btn_Yorum);
            this.tabPage3.Controls.Add(this.label36);
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.label34);
            this.tabPage3.Controls.Add(this.txt_YorumKonum);
            this.tabPage3.Controls.Add(this.txt_YorumHashtag);
            this.tabPage3.Controls.Add(this.txt_YorumSayfa);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(601, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Yorum";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_YorumYorum
            // 
            this.txt_YorumYorum.Location = new System.Drawing.Point(12, 98);
            this.txt_YorumYorum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_YorumYorum.Multiline = true;
            this.txt_YorumYorum.Name = "txt_YorumYorum";
            this.txt_YorumYorum.Size = new System.Drawing.Size(411, 83);
            this.txt_YorumYorum.TabIndex = 7;
            // 
            // btn_Yorum
            // 
            this.btn_Yorum.Location = new System.Drawing.Point(455, 245);
            this.btn_Yorum.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Yorum.Name = "btn_Yorum";
            this.btn_Yorum.Size = new System.Drawing.Size(100, 68);
            this.btn_Yorum.TabIndex = 6;
            this.btn_Yorum.Text = "Yorum işlemini başlat";
            this.btn_Yorum.UseVisualStyleBackColor = true;
            this.btn_Yorum.Click += new System.EventHandler(this.btn_Yorum_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(287, 208);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(52, 17);
            this.label36.TabIndex = 5;
            this.label36.Text = "Konum";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(153, 208);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(61, 17);
            this.label35.TabIndex = 4;
            this.label35.Text = "Hashtag";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(8, 209);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(78, 17);
            this.label34.TabIndex = 3;
            this.label34.Text = "Kişi / Sayfa";
            // 
            // txt_YorumKonum
            // 
            this.txt_YorumKonum.Location = new System.Drawing.Point(291, 230);
            this.txt_YorumKonum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_YorumKonum.Multiline = true;
            this.txt_YorumKonum.Name = "txt_YorumKonum";
            this.txt_YorumKonum.Size = new System.Drawing.Size(132, 95);
            this.txt_YorumKonum.TabIndex = 2;
            // 
            // txt_YorumHashtag
            // 
            this.txt_YorumHashtag.Location = new System.Drawing.Point(149, 230);
            this.txt_YorumHashtag.Margin = new System.Windows.Forms.Padding(4);
            this.txt_YorumHashtag.Multiline = true;
            this.txt_YorumHashtag.Name = "txt_YorumHashtag";
            this.txt_YorumHashtag.Size = new System.Drawing.Size(132, 95);
            this.txt_YorumHashtag.TabIndex = 1;
            // 
            // txt_YorumSayfa
            // 
            this.txt_YorumSayfa.Location = new System.Drawing.Point(8, 230);
            this.txt_YorumSayfa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_YorumSayfa.Multiline = true;
            this.txt_YorumSayfa.Name = "txt_YorumSayfa";
            this.txt_YorumSayfa.Size = new System.Drawing.Size(132, 95);
            this.txt_YorumSayfa.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txt_Rapor);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(601, 337);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rapor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_Rapor
            // 
            this.txt_Rapor.Location = new System.Drawing.Point(7, 7);
            this.txt_Rapor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Rapor.Multiline = true;
            this.txt_Rapor.Name = "txt_Rapor";
            this.txt_Rapor.ReadOnly = true;
            this.txt_Rapor.Size = new System.Drawing.Size(583, 309);
            this.txt_Rapor.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txt_YardımPost);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.txt_Açıklama);
            this.tabPage5.Controls.Add(this.btn_Yükle);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.txt_Etiket);
            this.tabPage5.Controls.Add(this.lbl_Dosyayolu);
            this.tabPage5.Controls.Add(this.pic_onizleme);
            this.tabPage5.Controls.Add(this.btn_DosyaSeç);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(601, 337);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Post At";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txt_YardımPost
            // 
            this.txt_YardımPost.Location = new System.Drawing.Point(165, 18);
            this.txt_YardımPost.Margin = new System.Windows.Forms.Padding(4);
            this.txt_YardımPost.Name = "txt_YardımPost";
            this.txt_YardımPost.Size = new System.Drawing.Size(100, 28);
            this.txt_YardımPost.TabIndex = 8;
            this.txt_YardımPost.Text = "Yardım";
            this.txt_YardımPost.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Açıklama";
            // 
            // txt_Açıklama
            // 
            this.txt_Açıklama.Location = new System.Drawing.Point(108, 144);
            this.txt_Açıklama.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Açıklama.Multiline = true;
            this.txt_Açıklama.Name = "txt_Açıklama";
            this.txt_Açıklama.Size = new System.Drawing.Size(340, 128);
            this.txt_Açıklama.TabIndex = 6;
            // 
            // btn_Yükle
            // 
            this.btn_Yükle.Location = new System.Drawing.Point(19, 289);
            this.btn_Yükle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Yükle.Name = "btn_Yükle";
            this.btn_Yükle.Size = new System.Drawing.Size(100, 28);
            this.btn_Yükle.TabIndex = 5;
            this.btn_Yükle.Text = "Yükle";
            this.btn_Yükle.UseVisualStyleBackColor = true;
            this.btn_Yükle.Click += new System.EventHandler(this.btn_Yükle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Etiketlenecek kullanıcı adı giriniz. ";
            this.label1.Visible = false;
            // 
            // txt_Etiket
            // 
            this.txt_Etiket.Location = new System.Drawing.Point(248, 92);
            this.txt_Etiket.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Etiket.Name = "txt_Etiket";
            this.txt_Etiket.Size = new System.Drawing.Size(200, 22);
            this.txt_Etiket.TabIndex = 3;
            this.txt_Etiket.Visible = false;
            // 
            // lbl_Dosyayolu
            // 
            this.lbl_Dosyayolu.AutoSize = true;
            this.lbl_Dosyayolu.Location = new System.Drawing.Point(19, 55);
            this.lbl_Dosyayolu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dosyayolu.Name = "lbl_Dosyayolu";
            this.lbl_Dosyayolu.Size = new System.Drawing.Size(30, 17);
            this.lbl_Dosyayolu.TabIndex = 2;
            this.lbl_Dosyayolu.Text = "null";
            // 
            // pic_onizleme
            // 
            this.pic_onizleme.Location = new System.Drawing.Point(457, 7);
            this.pic_onizleme.Margin = new System.Windows.Forms.Padding(4);
            this.pic_onizleme.Name = "pic_onizleme";
            this.pic_onizleme.Size = new System.Drawing.Size(133, 123);
            this.pic_onizleme.TabIndex = 1;
            this.pic_onizleme.TabStop = false;
            // 
            // btn_DosyaSeç
            // 
            this.btn_DosyaSeç.Location = new System.Drawing.Point(19, 18);
            this.btn_DosyaSeç.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DosyaSeç.Name = "btn_DosyaSeç";
            this.btn_DosyaSeç.Size = new System.Drawing.Size(133, 28);
            this.btn_DosyaSeç.TabIndex = 0;
            this.btn_DosyaSeç.Text = "Resim/Video Seç";
            this.btn_DosyaSeç.UseVisualStyleBackColor = true;
            this.btn_DosyaSeç.Click += new System.EventHandler(this.btn_DosyaSeç_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btn_Story);
            this.tabPage6.Controls.Add(this.group_StoryAyar);
            this.tabPage6.Controls.Add(this.pic_StoryOnizleme);
            this.tabPage6.Controls.Add(this.button1);
            this.tabPage6.Controls.Add(this.lbl_storyDosyaKonum);
            this.tabPage6.Controls.Add(this.btn_StorySeç);
            this.tabPage6.Controls.Add(this.group_StorySoruSor);
            this.tabPage6.Controls.Add(this.group_StoryKonum);
            this.tabPage6.Controls.Add(this.group_StoryEtiket);
            this.tabPage6.Controls.Add(this.group_StoryHashtag);
            this.tabPage6.Controls.Add(this.group_StoryAnket);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.Size = new System.Drawing.Size(601, 337);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Story At";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btn_Story
            // 
            this.btn_Story.Location = new System.Drawing.Point(215, 281);
            this.btn_Story.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Story.Name = "btn_Story";
            this.btn_Story.Size = new System.Drawing.Size(100, 28);
            this.btn_Story.TabIndex = 0;
            this.btn_Story.Text = "Story At";
            this.btn_Story.UseVisualStyleBackColor = true;
            this.btn_Story.Click += new System.EventHandler(this.btn_Story_Click);
            // 
            // group_StoryAyar
            // 
            this.group_StoryAyar.Controls.Add(this.radio_StoryKonum);
            this.group_StoryAyar.Controls.Add(this.radio_StoryHashtag);
            this.group_StoryAyar.Controls.Add(this.radio_StoryAnket);
            this.group_StoryAyar.Controls.Add(this.radio_StoryEtiket);
            this.group_StoryAyar.Controls.Add(this.radio_StorySoru);
            this.group_StoryAyar.Location = new System.Drawing.Point(24, 78);
            this.group_StoryAyar.Margin = new System.Windows.Forms.Padding(4);
            this.group_StoryAyar.Name = "group_StoryAyar";
            this.group_StoryAyar.Padding = new System.Windows.Forms.Padding(4);
            this.group_StoryAyar.Size = new System.Drawing.Size(128, 167);
            this.group_StoryAyar.TabIndex = 13;
            this.group_StoryAyar.TabStop = false;
            this.group_StoryAyar.Text = "Story Ayarları";
            this.group_StoryAyar.Visible = false;
            // 
            // radio_StoryKonum
            // 
            this.radio_StoryKonum.AutoSize = true;
            this.radio_StoryKonum.Location = new System.Drawing.Point(11, 138);
            this.radio_StoryKonum.Margin = new System.Windows.Forms.Padding(4);
            this.radio_StoryKonum.Name = "radio_StoryKonum";
            this.radio_StoryKonum.Size = new System.Drawing.Size(73, 21);
            this.radio_StoryKonum.TabIndex = 4;
            this.radio_StoryKonum.TabStop = true;
            this.radio_StoryKonum.Text = "Konum";
            this.radio_StoryKonum.UseVisualStyleBackColor = true;
            this.radio_StoryKonum.CheckedChanged += new System.EventHandler(this.radio_StoryKonum_CheckedChanged);
            // 
            // radio_StoryHashtag
            // 
            this.radio_StoryHashtag.AutoSize = true;
            this.radio_StoryHashtag.Location = new System.Drawing.Point(11, 110);
            this.radio_StoryHashtag.Margin = new System.Windows.Forms.Padding(4);
            this.radio_StoryHashtag.Name = "radio_StoryHashtag";
            this.radio_StoryHashtag.Size = new System.Drawing.Size(82, 21);
            this.radio_StoryHashtag.TabIndex = 3;
            this.radio_StoryHashtag.TabStop = true;
            this.radio_StoryHashtag.Text = "Hashtag";
            this.radio_StoryHashtag.UseVisualStyleBackColor = true;
            this.radio_StoryHashtag.CheckedChanged += new System.EventHandler(this.radio_StoryHashtag_CheckedChanged);
            // 
            // radio_StoryAnket
            // 
            this.radio_StoryAnket.AutoSize = true;
            this.radio_StoryAnket.Location = new System.Drawing.Point(11, 82);
            this.radio_StoryAnket.Margin = new System.Windows.Forms.Padding(4);
            this.radio_StoryAnket.Name = "radio_StoryAnket";
            this.radio_StoryAnket.Size = new System.Drawing.Size(91, 21);
            this.radio_StoryAnket.TabIndex = 2;
            this.radio_StoryAnket.TabStop = true;
            this.radio_StoryAnket.Text = "Anket Sor";
            this.radio_StoryAnket.UseVisualStyleBackColor = true;
            this.radio_StoryAnket.CheckedChanged += new System.EventHandler(this.radio_StoryAnket_CheckedChanged);
            // 
            // radio_StoryEtiket
            // 
            this.radio_StoryEtiket.AutoSize = true;
            this.radio_StoryEtiket.Location = new System.Drawing.Point(11, 53);
            this.radio_StoryEtiket.Margin = new System.Windows.Forms.Padding(4);
            this.radio_StoryEtiket.Name = "radio_StoryEtiket";
            this.radio_StoryEtiket.Size = new System.Drawing.Size(95, 21);
            this.radio_StoryEtiket.TabIndex = 1;
            this.radio_StoryEtiket.TabStop = true;
            this.radio_StoryEtiket.Text = "Etiket Ekle";
            this.radio_StoryEtiket.UseVisualStyleBackColor = true;
            this.radio_StoryEtiket.CheckedChanged += new System.EventHandler(this.radio_StoryEtiket_CheckedChanged);
            // 
            // radio_StorySoru
            // 
            this.radio_StorySoru.AutoSize = true;
            this.radio_StorySoru.Location = new System.Drawing.Point(11, 23);
            this.radio_StorySoru.Margin = new System.Windows.Forms.Padding(4);
            this.radio_StorySoru.Name = "radio_StorySoru";
            this.radio_StorySoru.Size = new System.Drawing.Size(85, 21);
            this.radio_StorySoru.TabIndex = 0;
            this.radio_StorySoru.TabStop = true;
            this.radio_StorySoru.Text = "Soru Sor";
            this.radio_StorySoru.UseVisualStyleBackColor = true;
            this.radio_StorySoru.CheckedChanged += new System.EventHandler(this.radio_StorySoru_CheckedChanged);
            // 
            // pic_StoryOnizleme
            // 
            this.pic_StoryOnizleme.Location = new System.Drawing.Point(457, 7);
            this.pic_StoryOnizleme.Margin = new System.Windows.Forms.Padding(4);
            this.pic_StoryOnizleme.Name = "pic_StoryOnizleme";
            this.pic_StoryOnizleme.Size = new System.Drawing.Size(133, 123);
            this.pic_StoryOnizleme.TabIndex = 12;
            this.pic_StoryOnizleme.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Yardım";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_storyDosyaKonum
            // 
            this.lbl_storyDosyaKonum.AutoSize = true;
            this.lbl_storyDosyaKonum.Location = new System.Drawing.Point(24, 55);
            this.lbl_storyDosyaKonum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_storyDosyaKonum.Name = "lbl_storyDosyaKonum";
            this.lbl_storyDosyaKonum.Size = new System.Drawing.Size(30, 17);
            this.lbl_storyDosyaKonum.TabIndex = 10;
            this.lbl_storyDosyaKonum.Text = "null";
            // 
            // btn_StorySeç
            // 
            this.btn_StorySeç.Location = new System.Drawing.Point(24, 18);
            this.btn_StorySeç.Margin = new System.Windows.Forms.Padding(4);
            this.btn_StorySeç.Name = "btn_StorySeç";
            this.btn_StorySeç.Size = new System.Drawing.Size(133, 28);
            this.btn_StorySeç.TabIndex = 9;
            this.btn_StorySeç.Text = "Resim/Video Seç";
            this.btn_StorySeç.UseVisualStyleBackColor = true;
            this.btn_StorySeç.Click += new System.EventHandler(this.btn_StorySeç_Click);
            // 
            // group_StorySoruSor
            // 
            this.group_StorySoruSor.Controls.Add(this.txt_groupSoruSor_yazirenk);
            this.group_StorySoruSor.Controls.Add(this.txt_groupSoruSor_ArkaPlanRenk);
            this.group_StorySoruSor.Controls.Add(this.label14);
            this.group_StorySoruSor.Controls.Add(this.label13);
            this.group_StorySoruSor.Controls.Add(this.label12);
            this.group_StorySoruSor.Controls.Add(this.txt_groupSoruSor_Soru);
            this.group_StorySoruSor.Controls.Add(this.txt_groupSoruSor_Rota);
            this.group_StorySoruSor.Controls.Add(this.txt_groupSoruSor_Y);
            this.group_StorySoruSor.Controls.Add(this.txt_groupSoruSor_X);
            this.group_StorySoruSor.Location = new System.Drawing.Point(165, 78);
            this.group_StorySoruSor.Margin = new System.Windows.Forms.Padding(4);
            this.group_StorySoruSor.Name = "group_StorySoruSor";
            this.group_StorySoruSor.Padding = new System.Windows.Forms.Padding(4);
            this.group_StorySoruSor.Size = new System.Drawing.Size(276, 170);
            this.group_StorySoruSor.TabIndex = 14;
            this.group_StorySoruSor.TabStop = false;
            this.group_StorySoruSor.Text = "Soru Sor";
            this.group_StorySoruSor.Visible = false;
            // 
            // txt_groupSoruSor_yazirenk
            // 
            this.txt_groupSoruSor_yazirenk.Location = new System.Drawing.Point(8, 60);
            this.txt_groupSoruSor_yazirenk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_groupSoruSor_yazirenk.Name = "txt_groupSoruSor_yazirenk";
            this.txt_groupSoruSor_yazirenk.Size = new System.Drawing.Size(176, 22);
            this.txt_groupSoruSor_yazirenk.TabIndex = 8;
            this.txt_groupSoruSor_yazirenk.Text = "#000000";
            // 
            // txt_groupSoruSor_ArkaPlanRenk
            // 
            this.txt_groupSoruSor_ArkaPlanRenk.Location = new System.Drawing.Point(8, 92);
            this.txt_groupSoruSor_ArkaPlanRenk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_groupSoruSor_ArkaPlanRenk.Name = "txt_groupSoruSor_ArkaPlanRenk";
            this.txt_groupSoruSor_ArkaPlanRenk.Size = new System.Drawing.Size(176, 22);
            this.txt_groupSoruSor_ArkaPlanRenk.TabIndex = 7;
            this.txt_groupSoruSor_ArkaPlanRenk.Text = "#ffffff";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(120, 121);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Rotasyon";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 118);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 118);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "X";
            // 
            // txt_groupSoruSor_Soru
            // 
            this.txt_groupSoruSor_Soru.Location = new System.Drawing.Point(9, 30);
            this.txt_groupSoruSor_Soru.Margin = new System.Windows.Forms.Padding(4);
            this.txt_groupSoruSor_Soru.Name = "txt_groupSoruSor_Soru";
            this.txt_groupSoruSor_Soru.Size = new System.Drawing.Size(257, 22);
            this.txt_groupSoruSor_Soru.TabIndex = 3;
            this.txt_groupSoruSor_Soru.Text = "Bana Bir Soru Sor?";
            // 
            // txt_groupSoruSor_Rota
            // 
            this.txt_groupSoruSor_Rota.Location = new System.Drawing.Point(124, 138);
            this.txt_groupSoruSor_Rota.Margin = new System.Windows.Forms.Padding(4);
            this.txt_groupSoruSor_Rota.Name = "txt_groupSoruSor_Rota";
            this.txt_groupSoruSor_Rota.Size = new System.Drawing.Size(61, 22);
            this.txt_groupSoruSor_Rota.TabIndex = 2;
            this.txt_groupSoruSor_Rota.Text = "0";
            // 
            // txt_groupSoruSor_Y
            // 
            this.txt_groupSoruSor_Y.Location = new System.Drawing.Point(64, 138);
            this.txt_groupSoruSor_Y.Margin = new System.Windows.Forms.Padding(4);
            this.txt_groupSoruSor_Y.Name = "txt_groupSoruSor_Y";
            this.txt_groupSoruSor_Y.Size = new System.Drawing.Size(49, 22);
            this.txt_groupSoruSor_Y.TabIndex = 1;
            this.txt_groupSoruSor_Y.Text = "0,5";
            // 
            // txt_groupSoruSor_X
            // 
            this.txt_groupSoruSor_X.Location = new System.Drawing.Point(8, 138);
            this.txt_groupSoruSor_X.Margin = new System.Windows.Forms.Padding(4);
            this.txt_groupSoruSor_X.Name = "txt_groupSoruSor_X";
            this.txt_groupSoruSor_X.Size = new System.Drawing.Size(45, 22);
            this.txt_groupSoruSor_X.TabIndex = 0;
            this.txt_groupSoruSor_X.Text = "0,5";
            // 
            // group_StoryKonum
            // 
            this.group_StoryKonum.Controls.Add(this.label31);
            this.group_StoryKonum.Controls.Add(this.label30);
            this.group_StoryKonum.Controls.Add(this.label29);
            this.group_StoryKonum.Controls.Add(this.txt_StoryKonumRota);
            this.group_StoryKonum.Controls.Add(this.txt_StoryKonumY);
            this.group_StoryKonum.Controls.Add(this.txt_StoryKonumX);
            this.group_StoryKonum.Controls.Add(this.txt_StoryKonumİsim);
            this.group_StoryKonum.Controls.Add(this.label28);
            this.group_StoryKonum.Location = new System.Drawing.Point(165, 78);
            this.group_StoryKonum.Margin = new System.Windows.Forms.Padding(4);
            this.group_StoryKonum.Name = "group_StoryKonum";
            this.group_StoryKonum.Padding = new System.Windows.Forms.Padding(4);
            this.group_StoryKonum.Size = new System.Drawing.Size(197, 138);
            this.group_StoryKonum.TabIndex = 18;
            this.group_StoryKonum.TabStop = false;
            this.group_StoryKonum.Text = "Konum";
            this.group_StoryKonum.Visible = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(129, 82);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(38, 17);
            this.label31.TabIndex = 7;
            this.label31.Text = "Rota";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(71, 82);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(17, 17);
            this.label30.TabIndex = 6;
            this.label30.Text = "Y";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(21, 82);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(17, 17);
            this.label29.TabIndex = 5;
            this.label29.Text = "X";
            // 
            // txt_StoryKonumRota
            // 
            this.txt_StoryKonumRota.Location = new System.Drawing.Point(111, 102);
            this.txt_StoryKonumRota.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryKonumRota.Name = "txt_StoryKonumRota";
            this.txt_StoryKonumRota.Size = new System.Drawing.Size(76, 22);
            this.txt_StoryKonumRota.TabIndex = 4;
            this.txt_StoryKonumRota.Text = "0";
            // 
            // txt_StoryKonumY
            // 
            this.txt_StoryKonumY.Location = new System.Drawing.Point(59, 102);
            this.txt_StoryKonumY.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryKonumY.Name = "txt_StoryKonumY";
            this.txt_StoryKonumY.Size = new System.Drawing.Size(45, 22);
            this.txt_StoryKonumY.TabIndex = 3;
            this.txt_StoryKonumY.Text = "0,5";
            // 
            // txt_StoryKonumX
            // 
            this.txt_StoryKonumX.Location = new System.Drawing.Point(8, 102);
            this.txt_StoryKonumX.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryKonumX.Name = "txt_StoryKonumX";
            this.txt_StoryKonumX.Size = new System.Drawing.Size(44, 22);
            this.txt_StoryKonumX.TabIndex = 2;
            this.txt_StoryKonumX.Text = "0,5";
            // 
            // txt_StoryKonumİsim
            // 
            this.txt_StoryKonumİsim.Location = new System.Drawing.Point(8, 39);
            this.txt_StoryKonumİsim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryKonumİsim.Name = "txt_StoryKonumİsim";
            this.txt_StoryKonumİsim.Size = new System.Drawing.Size(132, 22);
            this.txt_StoryKonumİsim.TabIndex = 1;
            this.txt_StoryKonumİsim.Text = "Türkiye";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 20);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 17);
            this.label28.TabIndex = 0;
            this.label28.Text = "Konum İsmi";
            // 
            // group_StoryEtiket
            // 
            this.group_StoryEtiket.Controls.Add(this.label18);
            this.group_StoryEtiket.Controls.Add(this.label21);
            this.group_StoryEtiket.Controls.Add(this.label20);
            this.group_StoryEtiket.Controls.Add(this.label19);
            this.group_StoryEtiket.Controls.Add(this.txt_StoryEtiket);
            this.group_StoryEtiket.Controls.Add(this.txt_StoryEtiketRota);
            this.group_StoryEtiket.Controls.Add(this.txt_StoryEtiketY);
            this.group_StoryEtiket.Controls.Add(this.txt_StoryEtiketX);
            this.group_StoryEtiket.Location = new System.Drawing.Point(165, 78);
            this.group_StoryEtiket.Margin = new System.Windows.Forms.Padding(4);
            this.group_StoryEtiket.Name = "group_StoryEtiket";
            this.group_StoryEtiket.Padding = new System.Windows.Forms.Padding(4);
            this.group_StoryEtiket.Size = new System.Drawing.Size(267, 123);
            this.group_StoryEtiket.TabIndex = 16;
            this.group_StoryEtiket.TabStop = false;
            this.group_StoryEtiket.Text = "Etiket";
            this.group_StoryEtiket.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 20);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "Kullanıcı Adı";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(153, 74);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 17);
            this.label21.TabIndex = 7;
            this.label21.Text = "Rota";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(77, 74);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 17);
            this.label20.TabIndex = 6;
            this.label20.Text = "Y";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 74);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 17);
            this.label19.TabIndex = 5;
            this.label19.Text = "X";
            // 
            // txt_StoryEtiket
            // 
            this.txt_StoryEtiket.Location = new System.Drawing.Point(8, 44);
            this.txt_StoryEtiket.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryEtiket.Name = "txt_StoryEtiket";
            this.txt_StoryEtiket.Size = new System.Drawing.Size(132, 22);
            this.txt_StoryEtiket.TabIndex = 3;
            // 
            // txt_StoryEtiketRota
            // 
            this.txt_StoryEtiketRota.Location = new System.Drawing.Point(139, 94);
            this.txt_StoryEtiketRota.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryEtiketRota.Name = "txt_StoryEtiketRota";
            this.txt_StoryEtiketRota.Size = new System.Drawing.Size(87, 22);
            this.txt_StoryEtiketRota.TabIndex = 2;
            this.txt_StoryEtiketRota.Text = "0";
            // 
            // txt_StoryEtiketY
            // 
            this.txt_StoryEtiketY.Location = new System.Drawing.Point(75, 94);
            this.txt_StoryEtiketY.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryEtiketY.Name = "txt_StoryEtiketY";
            this.txt_StoryEtiketY.Size = new System.Drawing.Size(56, 22);
            this.txt_StoryEtiketY.TabIndex = 1;
            this.txt_StoryEtiketY.Text = "0,5";
            // 
            // txt_StoryEtiketX
            // 
            this.txt_StoryEtiketX.Location = new System.Drawing.Point(8, 94);
            this.txt_StoryEtiketX.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryEtiketX.Name = "txt_StoryEtiketX";
            this.txt_StoryEtiketX.Size = new System.Drawing.Size(57, 22);
            this.txt_StoryEtiketX.TabIndex = 0;
            this.txt_StoryEtiketX.Text = "0,5";
            // 
            // group_StoryHashtag
            // 
            this.group_StoryHashtag.Controls.Add(this.label17);
            this.group_StoryHashtag.Controls.Add(this.txt_StoryHashtag);
            this.group_StoryHashtag.Controls.Add(this.label16);
            this.group_StoryHashtag.Controls.Add(this.label15);
            this.group_StoryHashtag.Controls.Add(this.label11);
            this.group_StoryHashtag.Controls.Add(this.txt_StoryHashtagRota);
            this.group_StoryHashtag.Controls.Add(this.txt_StoryHashtagY);
            this.group_StoryHashtag.Controls.Add(this.txt_StoryHashtagX);
            this.group_StoryHashtag.Location = new System.Drawing.Point(165, 78);
            this.group_StoryHashtag.Margin = new System.Windows.Forms.Padding(4);
            this.group_StoryHashtag.Name = "group_StoryHashtag";
            this.group_StoryHashtag.Padding = new System.Windows.Forms.Padding(4);
            this.group_StoryHashtag.Size = new System.Drawing.Size(287, 134);
            this.group_StoryHashtag.TabIndex = 15;
            this.group_StoryHashtag.TabStop = false;
            this.group_StoryHashtag.Text = "Hashtag";
            this.group_StoryHashtag.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 25);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Hashtag";
            // 
            // txt_StoryHashtag
            // 
            this.txt_StoryHashtag.Location = new System.Drawing.Point(9, 49);
            this.txt_StoryHashtag.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryHashtag.Name = "txt_StoryHashtag";
            this.txt_StoryHashtag.Size = new System.Drawing.Size(132, 22);
            this.txt_StoryHashtag.TabIndex = 6;
            this.txt_StoryHashtag.Text = "Türkiye";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(157, 82);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Rota";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(85, 84);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 84);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "X";
            // 
            // txt_StoryHashtagRota
            // 
            this.txt_StoryHashtagRota.Location = new System.Drawing.Point(133, 102);
            this.txt_StoryHashtagRota.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryHashtagRota.Name = "txt_StoryHashtagRota";
            this.txt_StoryHashtagRota.Size = new System.Drawing.Size(83, 22);
            this.txt_StoryHashtagRota.TabIndex = 2;
            this.txt_StoryHashtagRota.Text = "0";
            // 
            // txt_StoryHashtagY
            // 
            this.txt_StoryHashtagY.Location = new System.Drawing.Point(71, 103);
            this.txt_StoryHashtagY.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryHashtagY.Name = "txt_StoryHashtagY";
            this.txt_StoryHashtagY.Size = new System.Drawing.Size(52, 22);
            this.txt_StoryHashtagY.TabIndex = 1;
            this.txt_StoryHashtagY.Text = "0,5";
            // 
            // txt_StoryHashtagX
            // 
            this.txt_StoryHashtagX.Location = new System.Drawing.Point(9, 103);
            this.txt_StoryHashtagX.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryHashtagX.Name = "txt_StoryHashtagX";
            this.txt_StoryHashtagX.Size = new System.Drawing.Size(52, 22);
            this.txt_StoryHashtagX.TabIndex = 0;
            this.txt_StoryHashtagX.Text = "0,5";
            // 
            // group_StoryAnket
            // 
            this.group_StoryAnket.Controls.Add(this.label27);
            this.group_StoryAnket.Controls.Add(this.label26);
            this.group_StoryAnket.Controls.Add(this.label25);
            this.group_StoryAnket.Controls.Add(this.txt_StoryAnketRota);
            this.group_StoryAnket.Controls.Add(this.txt_StoryAnketY);
            this.group_StoryAnket.Controls.Add(this.txt_StoryAnketX);
            this.group_StoryAnket.Controls.Add(this.txt_StoryAnketCevap2);
            this.group_StoryAnket.Controls.Add(this.label24);
            this.group_StoryAnket.Controls.Add(this.txt_StoryAnketCevap1);
            this.group_StoryAnket.Controls.Add(this.label23);
            this.group_StoryAnket.Controls.Add(this.txt_StoryAnketSoru);
            this.group_StoryAnket.Controls.Add(this.label22);
            this.group_StoryAnket.Location = new System.Drawing.Point(165, 78);
            this.group_StoryAnket.Margin = new System.Windows.Forms.Padding(4);
            this.group_StoryAnket.Name = "group_StoryAnket";
            this.group_StoryAnket.Padding = new System.Windows.Forms.Padding(4);
            this.group_StoryAnket.Size = new System.Drawing.Size(267, 178);
            this.group_StoryAnket.TabIndex = 17;
            this.group_StoryAnket.TabStop = false;
            this.group_StoryAnket.Text = "Anket";
            this.group_StoryAnket.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(169, 129);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 17);
            this.label27.TabIndex = 11;
            this.label27.Text = "Rota";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(93, 127);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 17);
            this.label26.TabIndex = 10;
            this.label26.Text = "Y";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 128);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 17);
            this.label25.TabIndex = 9;
            this.label25.Text = "X";
            // 
            // txt_StoryAnketRota
            // 
            this.txt_StoryAnketRota.Location = new System.Drawing.Point(145, 148);
            this.txt_StoryAnketRota.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryAnketRota.Name = "txt_StoryAnketRota";
            this.txt_StoryAnketRota.Size = new System.Drawing.Size(77, 22);
            this.txt_StoryAnketRota.TabIndex = 8;
            this.txt_StoryAnketRota.Text = "0";
            // 
            // txt_StoryAnketY
            // 
            this.txt_StoryAnketY.Location = new System.Drawing.Point(77, 148);
            this.txt_StoryAnketY.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryAnketY.Name = "txt_StoryAnketY";
            this.txt_StoryAnketY.Size = new System.Drawing.Size(57, 22);
            this.txt_StoryAnketY.TabIndex = 7;
            this.txt_StoryAnketY.Text = "0,5";
            // 
            // txt_StoryAnketX
            // 
            this.txt_StoryAnketX.Location = new System.Drawing.Point(8, 148);
            this.txt_StoryAnketX.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryAnketX.Name = "txt_StoryAnketX";
            this.txt_StoryAnketX.Size = new System.Drawing.Size(60, 22);
            this.txt_StoryAnketX.TabIndex = 6;
            this.txt_StoryAnketX.Text = "0,5";
            // 
            // txt_StoryAnketCevap2
            // 
            this.txt_StoryAnketCevap2.Location = new System.Drawing.Point(133, 98);
            this.txt_StoryAnketCevap2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryAnketCevap2.Name = "txt_StoryAnketCevap2";
            this.txt_StoryAnketCevap2.Size = new System.Drawing.Size(124, 22);
            this.txt_StoryAnketCevap2.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(135, 79);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 17);
            this.label24.TabIndex = 4;
            this.label24.Text = "Cevap 2";
            // 
            // txt_StoryAnketCevap1
            // 
            this.txt_StoryAnketCevap1.Location = new System.Drawing.Point(8, 100);
            this.txt_StoryAnketCevap1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryAnketCevap1.Name = "txt_StoryAnketCevap1";
            this.txt_StoryAnketCevap1.Size = new System.Drawing.Size(116, 22);
            this.txt_StoryAnketCevap1.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 79);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 17);
            this.label23.TabIndex = 2;
            this.label23.Text = "Cevap 1";
            // 
            // txt_StoryAnketSoru
            // 
            this.txt_StoryAnketSoru.Location = new System.Drawing.Point(8, 46);
            this.txt_StoryAnketSoru.Margin = new System.Windows.Forms.Padding(4);
            this.txt_StoryAnketSoru.Name = "txt_StoryAnketSoru";
            this.txt_StoryAnketSoru.Size = new System.Drawing.Size(249, 22);
            this.txt_StoryAnketSoru.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 25);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 17);
            this.label22.TabIndex = 0;
            this.label22.Text = "Soru";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btn_Başla);
            this.tabPage7.Controls.Add(this.chk_Windows);
            this.tabPage7.Controls.Add(this.btn_KaydetBaşlaDurdur);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(601, 337);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Başla/Durdur";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btn_Başla
            // 
            this.btn_Başla.Location = new System.Drawing.Point(232, 245);
            this.btn_Başla.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Başla.Name = "btn_Başla";
            this.btn_Başla.Size = new System.Drawing.Size(100, 28);
            this.btn_Başla.TabIndex = 2;
            this.btn_Başla.Text = "Başla";
            this.btn_Başla.UseVisualStyleBackColor = true;
            this.btn_Başla.Click += new System.EventHandler(this.btn_Başla_Click);
            // 
            // chk_Windows
            // 
            this.chk_Windows.AutoSize = true;
            this.chk_Windows.Location = new System.Drawing.Point(20, 18);
            this.chk_Windows.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Windows.Name = "chk_Windows";
            this.chk_Windows.Size = new System.Drawing.Size(191, 21);
            this.chk_Windows.TabIndex = 1;
            this.chk_Windows.Text = "Windowsla Beraber Başla";
            this.chk_Windows.UseVisualStyleBackColor = true;
            // 
            // btn_KaydetBaşlaDurdur
            // 
            this.btn_KaydetBaşlaDurdur.Location = new System.Drawing.Point(19, 47);
            this.btn_KaydetBaşlaDurdur.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KaydetBaşlaDurdur.Name = "btn_KaydetBaşlaDurdur";
            this.btn_KaydetBaşlaDurdur.Size = new System.Drawing.Size(100, 28);
            this.btn_KaydetBaşlaDurdur.TabIndex = 0;
            this.btn_KaydetBaşlaDurdur.Text = "Kaydet";
            this.btn_KaydetBaşlaDurdur.UseVisualStyleBackColor = true;
            this.btn_KaydetBaşlaDurdur.Click += new System.EventHandler(this.btn_KaydetBaşlaDurdur_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.btn_MesajBaşla);
            this.tabPage8.Controls.Add(this.txt_MesajCevapları);
            this.tabPage8.Controls.Add(this.btn_MesajCevapEkle);
            this.tabPage8.Controls.Add(this.txt_MesajCevap);
            this.tabPage8.Controls.Add(this.label33);
            this.tabPage8.Controls.Add(this.label32);
            this.tabPage8.Controls.Add(this.txt_MesajAranacakKelime);
            this.tabPage8.Controls.Add(this.chk_MesajOtoYanit);
            this.tabPage8.Controls.Add(this.btn_MesajKaydet);
            this.tabPage8.Controls.Add(this.button2);
            this.tabPage8.Controls.Add(this.txt_Mesaj);
            this.tabPage8.Controls.Add(this.chk_MesajYeniTakip);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage8.Size = new System.Drawing.Size(601, 337);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Mesaj";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // btn_MesajBaşla
            // 
            this.btn_MesajBaşla.Location = new System.Drawing.Point(388, 198);
            this.btn_MesajBaşla.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MesajBaşla.Name = "btn_MesajBaşla";
            this.btn_MesajBaşla.Size = new System.Drawing.Size(100, 28);
            this.btn_MesajBaşla.TabIndex = 12;
            this.btn_MesajBaşla.Text = "Başla";
            this.btn_MesajBaşla.UseVisualStyleBackColor = true;
            this.btn_MesajBaşla.Click += new System.EventHandler(this.btn_MesajBaşla_Click);
            // 
            // txt_MesajCevapları
            // 
            this.txt_MesajCevapları.Location = new System.Drawing.Point(9, 238);
            this.txt_MesajCevapları.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MesajCevapları.Multiline = true;
            this.txt_MesajCevapları.Name = "txt_MesajCevapları";
            this.txt_MesajCevapları.Size = new System.Drawing.Size(580, 84);
            this.txt_MesajCevapları.TabIndex = 11;
            // 
            // btn_MesajCevapEkle
            // 
            this.btn_MesajCevapEkle.Location = new System.Drawing.Point(265, 198);
            this.btn_MesajCevapEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MesajCevapEkle.Name = "btn_MesajCevapEkle";
            this.btn_MesajCevapEkle.Size = new System.Drawing.Size(100, 28);
            this.btn_MesajCevapEkle.TabIndex = 10;
            this.btn_MesajCevapEkle.Text = "Ekle";
            this.btn_MesajCevapEkle.UseVisualStyleBackColor = true;
            this.btn_MesajCevapEkle.Click += new System.EventHandler(this.btn_MesajCevapEkle_Click);
            // 
            // txt_MesajCevap
            // 
            this.txt_MesajCevap.Location = new System.Drawing.Point(265, 146);
            this.txt_MesajCevap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MesajCevap.Name = "txt_MesajCevap";
            this.txt_MesajCevap.Size = new System.Drawing.Size(221, 22);
            this.txt_MesajCevap.TabIndex = 9;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(267, 123);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(110, 17);
            this.label33.TabIndex = 8;
            this.label33.Text = "Verilecek Cevap";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(267, 68);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(210, 17);
            this.label32.TabIndex = 7;
            this.label32.Text = "Gelen mesajda aranacak kelime";
            // 
            // txt_MesajAranacakKelime
            // 
            this.txt_MesajAranacakKelime.Location = new System.Drawing.Point(265, 91);
            this.txt_MesajAranacakKelime.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MesajAranacakKelime.Name = "txt_MesajAranacakKelime";
            this.txt_MesajAranacakKelime.Size = new System.Drawing.Size(221, 22);
            this.txt_MesajAranacakKelime.TabIndex = 6;
            // 
            // chk_MesajOtoYanit
            // 
            this.chk_MesajOtoYanit.AutoSize = true;
            this.chk_MesajOtoYanit.Location = new System.Drawing.Point(265, 20);
            this.chk_MesajOtoYanit.Margin = new System.Windows.Forms.Padding(4);
            this.chk_MesajOtoYanit.Name = "chk_MesajOtoYanit";
            this.chk_MesajOtoYanit.Size = new System.Drawing.Size(144, 21);
            this.chk_MesajOtoYanit.TabIndex = 5;
            this.chk_MesajOtoYanit.Text = "Otomatik yanıt ver";
            this.chk_MesajOtoYanit.UseVisualStyleBackColor = true;
            // 
            // btn_MesajKaydet
            // 
            this.btn_MesajKaydet.Location = new System.Drawing.Point(123, 198);
            this.btn_MesajKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MesajKaydet.Name = "btn_MesajKaydet";
            this.btn_MesajKaydet.Size = new System.Drawing.Size(117, 28);
            this.btn_MesajKaydet.TabIndex = 4;
            this.btn_MesajKaydet.Text = "Ayarları Kaydet";
            this.btn_MesajKaydet.UseVisualStyleBackColor = true;
            this.btn_MesajKaydet.Click += new System.EventHandler(this.btn_MesajKaydet_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 198);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Alıcı Adı Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Mesaj
            // 
            this.txt_Mesaj.Location = new System.Drawing.Point(7, 50);
            this.txt_Mesaj.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Mesaj.Multiline = true;
            this.txt_Mesaj.Name = "txt_Mesaj";
            this.txt_Mesaj.Size = new System.Drawing.Size(232, 133);
            this.txt_Mesaj.TabIndex = 1;
            this.txt_Mesaj.Text = "Merhabalar <@alıcıadı>,\r\nSayfamıza hoşgeldiniz... İçeriklerimize bir göz atın!\r\n";
            // 
            // chk_MesajYeniTakip
            // 
            this.chk_MesajYeniTakip.AutoSize = true;
            this.chk_MesajYeniTakip.Location = new System.Drawing.Point(11, 20);
            this.chk_MesajYeniTakip.Margin = new System.Windows.Forms.Padding(4);
            this.chk_MesajYeniTakip.Name = "chk_MesajYeniTakip";
            this.chk_MesajYeniTakip.Size = new System.Drawing.Size(209, 21);
            this.chk_MesajYeniTakip.TabIndex = 0;
            this.chk_MesajYeniTakip.Text = "Yeni takip edenlere mesaj at";
            this.chk_MesajYeniTakip.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.btn_TakipBasla);
            this.tabPage9.Controls.Add(this.txt_TakipEdenler);
            this.tabPage9.Controls.Add(this.label40);
            this.tabPage9.Controls.Add(this.label39);
            this.tabPage9.Controls.Add(this.txt_TakipEttikleri);
            this.tabPage9.Controls.Add(this.label38);
            this.tabPage9.Controls.Add(this.txt_TakipKonum);
            this.tabPage9.Controls.Add(this.label37);
            this.tabPage9.Controls.Add(this.txt_TakipHashtag);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage9.Size = new System.Drawing.Size(601, 337);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Takip";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // btn_TakipBasla
            // 
            this.btn_TakipBasla.Location = new System.Drawing.Point(465, 31);
            this.btn_TakipBasla.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TakipBasla.Name = "btn_TakipBasla";
            this.btn_TakipBasla.Size = new System.Drawing.Size(100, 55);
            this.btn_TakipBasla.TabIndex = 9;
            this.btn_TakipBasla.Text = "Takibe Başla";
            this.btn_TakipBasla.UseVisualStyleBackColor = true;
            this.btn_TakipBasla.Click += new System.EventHandler(this.btn_TakipBasla_Click);
            // 
            // txt_TakipEdenler
            // 
            this.txt_TakipEdenler.Location = new System.Drawing.Point(443, 234);
            this.txt_TakipEdenler.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TakipEdenler.Multiline = true;
            this.txt_TakipEdenler.Name = "txt_TakipEdenler";
            this.txt_TakipEdenler.Size = new System.Drawing.Size(121, 88);
            this.txt_TakipEdenler.TabIndex = 8;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(439, 213);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(96, 17);
            this.label40.TabIndex = 7;
            this.label40.Text = "Takip Edenler";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(295, 213);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(93, 17);
            this.label39.TabIndex = 6;
            this.label39.Text = "Takip Ettikleri";
            // 
            // txt_TakipEttikleri
            // 
            this.txt_TakipEttikleri.Location = new System.Drawing.Point(299, 234);
            this.txt_TakipEttikleri.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TakipEttikleri.Multiline = true;
            this.txt_TakipEttikleri.Name = "txt_TakipEttikleri";
            this.txt_TakipEttikleri.Size = new System.Drawing.Size(121, 88);
            this.txt_TakipEttikleri.TabIndex = 5;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(151, 214);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(52, 17);
            this.label38.TabIndex = 4;
            this.label38.Text = "Konum";
            // 
            // txt_TakipKonum
            // 
            this.txt_TakipKonum.Location = new System.Drawing.Point(155, 234);
            this.txt_TakipKonum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TakipKonum.Multiline = true;
            this.txt_TakipKonum.Name = "txt_TakipKonum";
            this.txt_TakipKonum.Size = new System.Drawing.Size(121, 88);
            this.txt_TakipKonum.TabIndex = 2;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(8, 214);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(61, 17);
            this.label37.TabIndex = 1;
            this.label37.Text = "Hashtag";
            // 
            // txt_TakipHashtag
            // 
            this.txt_TakipHashtag.Location = new System.Drawing.Point(11, 234);
            this.txt_TakipHashtag.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TakipHashtag.Multiline = true;
            this.txt_TakipHashtag.Name = "txt_TakipHashtag";
            this.txt_TakipHashtag.Size = new System.Drawing.Size(121, 88);
            this.txt_TakipHashtag.TabIndex = 0;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.btn_Veri_Cikar);
            this.tabPage10.Controls.Add(this.label41);
            this.tabPage10.Controls.Add(this.groupBox3);
            this.tabPage10.Controls.Add(this.groupBox2);
            this.tabPage10.Controls.Add(this.groupBox1);
            this.tabPage10.Location = new System.Drawing.Point(4, 25);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage10.Size = new System.Drawing.Size(601, 337);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Veri Çıkarma";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // btn_Veri_Cikar
            // 
            this.btn_Veri_Cikar.Location = new System.Drawing.Point(488, 80);
            this.btn_Veri_Cikar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Veri_Cikar.Name = "btn_Veri_Cikar";
            this.btn_Veri_Cikar.Size = new System.Drawing.Size(100, 28);
            this.btn_Veri_Cikar.TabIndex = 4;
            this.btn_Veri_Cikar.Text = "Verileri Al!";
            this.btn_Veri_Cikar.UseVisualStyleBackColor = true;
            this.btn_Veri_Cikar.Click += new System.EventHandler(this.btn_Veri_Cikar_ClickAsync);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(484, 27);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(95, 34);
            this.label41.TabIndex = 3;
            this.label41.Text = "Her satıra\r\n1 adet yazınız";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.veri_Cikar_profil_al_konum);
            this.groupBox3.Controls.Add(this.veri_Cikar_konum_al_konum);
            this.groupBox3.Controls.Add(this.veri_Cikar_mail_al_konum);
            this.groupBox3.Controls.Add(this.veri_Cikar_telefon_al_konum);
            this.groupBox3.Controls.Add(this.txt_Veri_Cikar_konum);
            this.groupBox3.Location = new System.Drawing.Point(323, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(145, 318);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Konum";
            // 
            // veri_Cikar_profil_al_konum
            // 
            this.veri_Cikar_profil_al_konum.AutoSize = true;
            this.veri_Cikar_profil_al_konum.Location = new System.Drawing.Point(9, 266);
            this.veri_Cikar_profil_al_konum.Margin = new System.Windows.Forms.Padding(4);
            this.veri_Cikar_profil_al_konum.Name = "veri_Cikar_profil_al_konum";
            this.veri_Cikar_profil_al_konum.Size = new System.Drawing.Size(127, 21);
            this.veri_Cikar_profil_al_konum.TabIndex = 9;
            this.veri_Cikar_profil_al_konum.Text = "Profil Bilgileri Al";
            this.veri_Cikar_profil_al_konum.UseVisualStyleBackColor = true;
            // 
            // veri_Cikar_konum_al_konum
            // 
            this.veri_Cikar_konum_al_konum.AutoSize = true;
            this.veri_Cikar_konum_al_konum.Location = new System.Drawing.Point(9, 236);
            this.veri_Cikar_konum_al_konum.Margin = new System.Windows.Forms.Padding(4);
            this.veri_Cikar_konum_al_konum.Name = "veri_Cikar_konum_al_konum";
            this.veri_Cikar_konum_al_konum.Size = new System.Drawing.Size(98, 21);
            this.veri_Cikar_konum_al_konum.TabIndex = 8;
            this.veri_Cikar_konum_al_konum.Text = "Konumu Al";
            this.veri_Cikar_konum_al_konum.UseVisualStyleBackColor = true;
            // 
            // veri_Cikar_mail_al_konum
            // 
            this.veri_Cikar_mail_al_konum.AutoSize = true;
            this.veri_Cikar_mail_al_konum.Location = new System.Drawing.Point(11, 208);
            this.veri_Cikar_mail_al_konum.Margin = new System.Windows.Forms.Padding(4);
            this.veri_Cikar_mail_al_konum.Name = "veri_Cikar_mail_al_konum";
            this.veri_Cikar_mail_al_konum.Size = new System.Drawing.Size(85, 21);
            this.veri_Cikar_mail_al_konum.TabIndex = 7;
            this.veri_Cikar_mail_al_konum.Text = "E-Mail Al";
            this.veri_Cikar_mail_al_konum.UseVisualStyleBackColor = true;
            // 
            // veri_Cikar_telefon_al_konum
            // 
            this.veri_Cikar_telefon_al_konum.AutoSize = true;
            this.veri_Cikar_telefon_al_konum.Location = new System.Drawing.Point(11, 180);
            this.veri_Cikar_telefon_al_konum.Margin = new System.Windows.Forms.Padding(4);
            this.veri_Cikar_telefon_al_konum.Name = "veri_Cikar_telefon_al_konum";
            this.veri_Cikar_telefon_al_konum.Size = new System.Drawing.Size(94, 21);
            this.veri_Cikar_telefon_al_konum.TabIndex = 6;
            this.veri_Cikar_telefon_al_konum.Text = "Telefon Al";
            this.veri_Cikar_telefon_al_konum.UseVisualStyleBackColor = true;
            // 
            // txt_Veri_Cikar_konum
            // 
            this.txt_Veri_Cikar_konum.Location = new System.Drawing.Point(8, 27);
            this.txt_Veri_Cikar_konum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Veri_Cikar_konum.Multiline = true;
            this.txt_Veri_Cikar_konum.Name = "txt_Veri_Cikar_konum";
            this.txt_Veri_Cikar_konum.Size = new System.Drawing.Size(132, 147);
            this.txt_Veri_Cikar_konum.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.veri_Cikar_profil_al_sayfa);
            this.groupBox2.Controls.Add(this.veri_Cikar_konum_al_sayfa);
            this.groupBox2.Controls.Add(this.veri_Cikar_mail_al_sayfa);
            this.groupBox2.Controls.Add(this.veri_Cikar_telefon_al_sayfa);
            this.groupBox2.Controls.Add(this.txt_veri_Cikar_sayfa);
            this.groupBox2.Location = new System.Drawing.Point(165, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(145, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sayfa";
            // 
            // veri_Cikar_profil_al_sayfa
            // 
            this.veri_Cikar_profil_al_sayfa.AutoSize = true;
            this.veri_Cikar_profil_al_sayfa.Location = new System.Drawing.Point(8, 268);
            this.veri_Cikar_profil_al_sayfa.Margin = new System.Windows.Forms.Padding(4);
            this.veri_Cikar_profil_al_sayfa.Name = "veri_Cikar_profil_al_sayfa";
            this.veri_Cikar_profil_al_sayfa.Size = new System.Drawing.Size(127, 21);
            this.veri_Cikar_profil_al_sayfa.TabIndex = 4;
            this.veri_Cikar_profil_al_sayfa.Text = "Profil Bilgileri Al";
            this.veri_Cikar_profil_al_sayfa.UseVisualStyleBackColor = true;
            // 
            // veri_Cikar_konum_al_sayfa
            // 
            this.veri_Cikar_konum_al_sayfa.AutoSize = true;
            this.veri_Cikar_konum_al_sayfa.Location = new System.Drawing.Point(8, 239);
            this.veri_Cikar_konum_al_sayfa.Margin = new System.Windows.Forms.Padding(4);
            this.veri_Cikar_konum_al_sayfa.Name = "veri_Cikar_konum_al_sayfa";
            this.veri_Cikar_konum_al_sayfa.Size = new System.Drawing.Size(98, 21);
            this.veri_Cikar_konum_al_sayfa.TabIndex = 3;
            this.veri_Cikar_konum_al_sayfa.Text = "Konumu Al";
            this.veri_Cikar_konum_al_sayfa.UseVisualStyleBackColor = true;
            // 
            // veri_Cikar_mail_al_sayfa
            // 
            this.veri_Cikar_mail_al_sayfa.AutoSize = true;
            this.veri_Cikar_mail_al_sayfa.Location = new System.Drawing.Point(9, 210);
            this.veri_Cikar_mail_al_sayfa.Margin = new System.Windows.Forms.Padding(4);
            this.veri_Cikar_mail_al_sayfa.Name = "veri_Cikar_mail_al_sayfa";
            this.veri_Cikar_mail_al_sayfa.Size = new System.Drawing.Size(85, 21);
            this.veri_Cikar_mail_al_sayfa.TabIndex = 2;
            this.veri_Cikar_mail_al_sayfa.Text = "E-Mail Al";
            this.veri_Cikar_mail_al_sayfa.UseVisualStyleBackColor = true;
            // 
            // veri_Cikar_telefon_al_sayfa
            // 
            this.veri_Cikar_telefon_al_sayfa.AutoSize = true;
            this.veri_Cikar_telefon_al_sayfa.Location = new System.Drawing.Point(9, 182);
            this.veri_Cikar_telefon_al_sayfa.Margin = new System.Windows.Forms.Padding(4);
            this.veri_Cikar_telefon_al_sayfa.Name = "veri_Cikar_telefon_al_sayfa";
            this.veri_Cikar_telefon_al_sayfa.Size = new System.Drawing.Size(94, 21);
            this.veri_Cikar_telefon_al_sayfa.TabIndex = 1;
            this.veri_Cikar_telefon_al_sayfa.Text = "Telefon Al";
            this.veri_Cikar_telefon_al_sayfa.UseVisualStyleBackColor = true;
            // 
            // txt_veri_Cikar_sayfa
            // 
            this.txt_veri_Cikar_sayfa.Location = new System.Drawing.Point(8, 27);
            this.txt_veri_Cikar_sayfa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_veri_Cikar_sayfa.Multiline = true;
            this.txt_veri_Cikar_sayfa.Name = "txt_veri_Cikar_sayfa";
            this.txt_veri_Cikar_sayfa.Size = new System.Drawing.Size(132, 147);
            this.txt_veri_Cikar_sayfa.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.veri_Cikar_profil_al_hash);
            this.groupBox1.Controls.Add(this.veri_Cikar_konum_al_hash);
            this.groupBox1.Controls.Add(this.veri_Cikar_mail_al_hash);
            this.groupBox1.Controls.Add(this.veri_Cikar_Telefon_al_hash);
            this.groupBox1.Controls.Add(this.txt_veri_Cikar_hashtag);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(145, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hashtag";
            // 
            // veri_Cikar_profil_al_hash
            // 
            this.veri_Cikar_profil_al_hash.AutoSize = true;
            this.veri_Cikar_profil_al_hash.Location = new System.Drawing.Point(9, 268);
            this.veri_Cikar_profil_al_hash.Margin = new System.Windows.Forms.Padding(4);
            this.veri_Cikar_profil_al_hash.Name = "veri_Cikar_profil_al_hash";
            this.veri_Cikar_profil_al_hash.Size = new System.Drawing.Size(127, 21);
            this.veri_Cikar_profil_al_hash.TabIndex = 4;
            this.veri_Cikar_profil_al_hash.Text = "Profil Bilgileri Al";
            this.veri_Cikar_profil_al_hash.UseVisualStyleBackColor = true;
            // 
            // veri_Cikar_konum_al_hash
            // 
            this.veri_Cikar_konum_al_hash.AutoSize = true;
            this.veri_Cikar_konum_al_hash.Location = new System.Drawing.Point(9, 239);
            this.veri_Cikar_konum_al_hash.Margin = new System.Windows.Forms.Padding(4);
            this.veri_Cikar_konum_al_hash.Name = "veri_Cikar_konum_al_hash";
            this.veri_Cikar_konum_al_hash.Size = new System.Drawing.Size(98, 21);
            this.veri_Cikar_konum_al_hash.TabIndex = 3;
            this.veri_Cikar_konum_al_hash.Text = "Konumu Al";
            this.veri_Cikar_konum_al_hash.UseVisualStyleBackColor = true;
            // 
            // veri_Cikar_mail_al_hash
            // 
            this.veri_Cikar_mail_al_hash.AutoSize = true;
            this.veri_Cikar_mail_al_hash.Location = new System.Drawing.Point(9, 210);
            this.veri_Cikar_mail_al_hash.Margin = new System.Windows.Forms.Padding(4);
            this.veri_Cikar_mail_al_hash.Name = "veri_Cikar_mail_al_hash";
            this.veri_Cikar_mail_al_hash.Size = new System.Drawing.Size(85, 21);
            this.veri_Cikar_mail_al_hash.TabIndex = 2;
            this.veri_Cikar_mail_al_hash.Text = "E-Mail Al";
            this.veri_Cikar_mail_al_hash.UseVisualStyleBackColor = true;
            // 
            // veri_Cikar_Telefon_al_hash
            // 
            this.veri_Cikar_Telefon_al_hash.AutoSize = true;
            this.veri_Cikar_Telefon_al_hash.Location = new System.Drawing.Point(9, 182);
            this.veri_Cikar_Telefon_al_hash.Margin = new System.Windows.Forms.Padding(4);
            this.veri_Cikar_Telefon_al_hash.Name = "veri_Cikar_Telefon_al_hash";
            this.veri_Cikar_Telefon_al_hash.Size = new System.Drawing.Size(94, 21);
            this.veri_Cikar_Telefon_al_hash.TabIndex = 1;
            this.veri_Cikar_Telefon_al_hash.Text = "Telefon Al";
            this.veri_Cikar_Telefon_al_hash.UseVisualStyleBackColor = true;
            // 
            // txt_veri_Cikar_hashtag
            // 
            this.txt_veri_Cikar_hashtag.Location = new System.Drawing.Point(8, 27);
            this.txt_veri_Cikar_hashtag.Margin = new System.Windows.Forms.Padding(4);
            this.txt_veri_Cikar_hashtag.Multiline = true;
            this.txt_veri_Cikar_hashtag.Name = "txt_veri_Cikar_hashtag";
            this.txt_veri_Cikar_hashtag.Size = new System.Drawing.Size(132, 147);
            this.txt_veri_Cikar_hashtag.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer_Begeni
            // 
            this.timer_Begeni.Tick += new System.EventHandler(this.timer_Begeni_Tick);
            // 
            // timer_Mesaj
            // 
            this.timer_Mesaj.Tick += new System.EventHandler(this.timer_Mesaj_Tick);
            // 
            // timer_Yorum
            // 
            this.timer_Yorum.Tick += new System.EventHandler(this.timer_Yorum_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 378);
            this.Controls.Add(this.Mesaj);
            this.Controls.Add(this.group_Profil);
            this.Controls.Add(this.group_İkiFaktör);
            this.Controls.Add(this.groupGiriş);
            this.Controls.Add(this.group_DoğrulamaSeç);
            this.Controls.Add(this.group_KoduDoğrula);
            this.Controls.Add(this.group_TelefonOnay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ISharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.group_TelefonOnay.ResumeLayout(false);
            this.group_TelefonOnay.PerformLayout();
            this.group_KoduDoğrula.ResumeLayout(false);
            this.group_KoduDoğrula.PerformLayout();
            this.group_DoğrulamaSeç.ResumeLayout(false);
            this.group_DoğrulamaSeç.PerformLayout();
            this.group_İkiFaktör.ResumeLayout(false);
            this.group_İkiFaktör.PerformLayout();
            this.groupGiriş.ResumeLayout(false);
            this.groupGiriş.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProfilResmi)).EndInit();
            this.group_Profil.ResumeLayout(false);
            this.group_Profil.PerformLayout();
            this.Mesaj.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_onizleme)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.group_StoryAyar.ResumeLayout(false);
            this.group_StoryAyar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_StoryOnizleme)).EndInit();
            this.group_StorySoruSor.ResumeLayout(false);
            this.group_StorySoruSor.PerformLayout();
            this.group_StoryKonum.ResumeLayout(false);
            this.group_StoryKonum.PerformLayout();
            this.group_StoryEtiket.ResumeLayout(false);
            this.group_StoryEtiket.PerformLayout();
            this.group_StoryHashtag.ResumeLayout(false);
            this.group_StoryHashtag.PerformLayout();
            this.group_StoryAnket.ResumeLayout(false);
            this.group_StoryAnket.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Kadi;
        private System.Windows.Forms.TextBox txt_Şifre;
        private System.Windows.Forms.CheckBox check_Kaydet;
        private System.Windows.Forms.Button btn_Giriş;
        private System.Windows.Forms.GroupBox group_TelefonOnay;
        private System.Windows.Forms.Button btn_TelefonOnayi;
        private System.Windows.Forms.TextBox txt_TelefonOnay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox group_KoduDoğrula;
        private System.Windows.Forms.Button ResendButton;
        private System.Windows.Forms.Button btn_Doğrula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVerifyCode;
        private System.Windows.Forms.Label LblForSmsEmail;
        private System.Windows.Forms.GroupBox group_DoğrulamaSeç;
        private System.Windows.Forms.Button btn_KodGönder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RadioVerifyWithEmail;
        private System.Windows.Forms.RadioButton RadioVerifyWithPhoneNumber;
        private System.Windows.Forms.GroupBox group_İkiFaktör;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTwoFactorCode;
        private System.Windows.Forms.GroupBox groupGiriş;
        private System.Windows.Forms.Button btn_İkiFaktör;
        private System.Windows.Forms.PictureBox pic_ProfilResmi;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_Takipçi;
        private System.Windows.Forms.Label lbl_TakipEdilen;
        private System.Windows.Forms.Label lbl_Gonderi;
        private System.Windows.Forms.GroupBox group_Profil;
        private System.Windows.Forms.TextBox txt_Biyografi;
        private System.Windows.Forms.TabControl Mesaj;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txt_Rapor;
        private System.Windows.Forms.Label lbl_Dosyayolu;
        private System.Windows.Forms.PictureBox pic_onizleme;
        private System.Windows.Forms.Button btn_DosyaSeç;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Yükle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Etiket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Açıklama;
        private System.Windows.Forms.Button txt_YardımPost;
        private System.Windows.Forms.Button btn_Story;
        private System.Windows.Forms.Button btn_KonumEkle;
        private System.Windows.Forms.Button btn_HashtagEkle;
        private System.Windows.Forms.Button btn_KişiEkle;
        private System.Windows.Forms.TextBox txt_HedefKişi;
        private System.Windows.Forms.Button btn_HedefKaydet;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.CheckBox chk_Windows;
        private System.Windows.Forms.Button btn_KaydetBaşlaDurdur;
        private System.Windows.Forms.Button btn_Başla;
        private System.Windows.Forms.TextBox txt_HedefKonum;
        private System.Windows.Forms.TextBox txt_HedefHash;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_BegeniKonum;
        private System.Windows.Forms.TextBox txt_BegeniHash;
        private System.Windows.Forms.TextBox txt_BegeniSayfa;
        private System.Windows.Forms.Button btn_BegeniBasla;
        private System.Windows.Forms.Timer timer_Begeni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_storyDosyaKonum;
        private System.Windows.Forms.Button btn_StorySeç;
        private System.Windows.Forms.PictureBox pic_StoryOnizleme;
        private System.Windows.Forms.GroupBox group_StoryAyar;
        private System.Windows.Forms.GroupBox group_StorySoruSor;
        private System.Windows.Forms.RadioButton radio_StoryHashtag;
        private System.Windows.Forms.RadioButton radio_StoryAnket;
        private System.Windows.Forms.RadioButton radio_StoryEtiket;
        private System.Windows.Forms.RadioButton radio_StorySoru;
        private System.Windows.Forms.TextBox txt_groupSoruSor_yazirenk;
        private System.Windows.Forms.TextBox txt_groupSoruSor_ArkaPlanRenk;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_groupSoruSor_Soru;
        private System.Windows.Forms.TextBox txt_groupSoruSor_Rota;
        private System.Windows.Forms.TextBox txt_groupSoruSor_Y;
        private System.Windows.Forms.TextBox txt_groupSoruSor_X;
        private System.Windows.Forms.GroupBox group_StoryHashtag;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_StoryHashtag;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_StoryHashtagRota;
        private System.Windows.Forms.TextBox txt_StoryHashtagY;
        private System.Windows.Forms.TextBox txt_StoryHashtagX;
        private System.Windows.Forms.GroupBox group_StoryEtiket;
        private System.Windows.Forms.RadioButton radio_StoryKonum;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_StoryEtiket;
        private System.Windows.Forms.TextBox txt_StoryEtiketRota;
        private System.Windows.Forms.TextBox txt_StoryEtiketY;
        private System.Windows.Forms.TextBox txt_StoryEtiketX;
        private System.Windows.Forms.GroupBox group_StoryAnket;
        private System.Windows.Forms.GroupBox group_StoryKonum;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txt_StoryKonumRota;
        private System.Windows.Forms.TextBox txt_StoryKonumY;
        private System.Windows.Forms.TextBox txt_StoryKonumX;
        private System.Windows.Forms.TextBox txt_StoryKonumİsim;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_StoryAnketRota;
        private System.Windows.Forms.TextBox txt_StoryAnketY;
        private System.Windows.Forms.TextBox txt_StoryAnketX;
        private System.Windows.Forms.TextBox txt_StoryAnketCevap2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_StoryAnketCevap1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_StoryAnketSoru;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button btn_MesajKaydet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_Mesaj;
        private System.Windows.Forms.CheckBox chk_MesajYeniTakip;
        private System.Windows.Forms.Button btn_MesajBaşla;
        private System.Windows.Forms.TextBox txt_MesajCevapları;
        private System.Windows.Forms.Button btn_MesajCevapEkle;
        private System.Windows.Forms.TextBox txt_MesajCevap;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txt_MesajAranacakKelime;
        private System.Windows.Forms.CheckBox chk_MesajOtoYanit;
        private System.Windows.Forms.Timer timer_Mesaj;
        private System.Windows.Forms.TextBox txt_YorumKonum;
        private System.Windows.Forms.TextBox txt_YorumHashtag;
        private System.Windows.Forms.TextBox txt_YorumSayfa;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btn_Yorum;
        private System.Windows.Forms.Timer timer_Yorum;
        private System.Windows.Forms.TextBox txt_YorumYorum;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txt_TakipKonum;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txt_TakipHashtag;
        private System.Windows.Forms.TextBox txt_TakipEdenler;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txt_TakipEttikleri;
        private System.Windows.Forms.Button btn_TakipBasla;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox veri_Cikar_profil_al_konum;
        private System.Windows.Forms.CheckBox veri_Cikar_konum_al_konum;
        private System.Windows.Forms.CheckBox veri_Cikar_mail_al_konum;
        private System.Windows.Forms.CheckBox veri_Cikar_telefon_al_konum;
        private System.Windows.Forms.TextBox txt_Veri_Cikar_konum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox veri_Cikar_profil_al_sayfa;
        private System.Windows.Forms.CheckBox veri_Cikar_konum_al_sayfa;
        private System.Windows.Forms.CheckBox veri_Cikar_mail_al_sayfa;
        private System.Windows.Forms.CheckBox veri_Cikar_telefon_al_sayfa;
        private System.Windows.Forms.TextBox txt_veri_Cikar_sayfa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox veri_Cikar_profil_al_hash;
        private System.Windows.Forms.CheckBox veri_Cikar_konum_al_hash;
        private System.Windows.Forms.CheckBox veri_Cikar_mail_al_hash;
        private System.Windows.Forms.CheckBox veri_Cikar_Telefon_al_hash;
        private System.Windows.Forms.TextBox txt_veri_Cikar_hashtag;
        private System.Windows.Forms.Button btn_Veri_Cikar;
    }
}

