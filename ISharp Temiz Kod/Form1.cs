using System;
using System.Drawing;
using System.Windows.Forms;
using InstagramApiSharp.API;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes.SessionHandlers;
using System.Threading.Tasks;
using InstagramApiSharp.Classes.Models;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Net;
using System.IO;
using Microsoft.Win32;
using InstagramApiSharp;
using MyProg;
using System.Linq;
using System.ComponentModel;
using System.Text;

namespace ISharp_Temiz_Kod
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.kadi))
            {
                txt_Kadi.Text = Properties.Settings.Default.kadi;
                txt_Şifre.Text = Properties.Settings.Default.şifre;
                check_Kaydet.Checked = true;
            }
        }

        private async void btn_Giriş_Click(object sender, EventArgs e)
        {
            UserSessionData kullanici = new UserSessionData
            {
                UserName = txt_Kadi.Text,
                Password = txt_Şifre.Text
            };

            api = InstaApiBuilder.CreateBuilder().
                SetUser(kullanici).
                UseLogger(new DebugLogger(LogLevel.Exceptions)).
                SetRequestDelay(RequestDelay.FromSeconds(0, 1)).
                SetSessionHandler(new FileSessionHandler
                {
                    FilePath = "state.bin"
                }).
                Build();
            Text = "ISharp - Bağlanılıyor";
            SessionYukle();
            if (!api.IsUserAuthenticated)
            {
                await api.SendRequestsBeforeLoginAsync();
                await Task.Delay(5000);
                var giris = await api.LoginAsync();
                Raporyaz(giris.Value.ToString());
                if (giris.Succeeded)
                {
                    await api.SendRequestsAfterLoginAsync();
                    SessionKaydet();
                    ///IResult<InstaCurrentUser> cruser = await api.GetCurrentUserAsync();
                    Text = "ISharp - Bağlanıldı";
                    girisbasarili();
                }
                else
                {
                    switch (giris.Value)
                    {
                        case InstaLoginResult.BadPassword:
                            MessageBox.Show("Yanlış Şifre");
                            return;
                        case InstaLoginResult.InvalidUser:
                            MessageBox.Show("Yanlış Kullanıcı adı");
                            return;
                        case InstaLoginResult.LimitError:
                            MessageBox.Show("Limit hatası!(5-10 dakika bekledikten sonra tekrar deneyin)");
                            return;
                        case InstaLoginResult.ChallengeRequired:
                            var challange = await api.GetChallengeRequireVerifyMethodAsync();
                            if (challange.Succeeded)
                            {
                                if (challange.Value.SubmitPhoneRequired)
                                {
                                    group_TelefonOnay.Visible = true;
                                    Size = ChallengeSize;

                                }
                                else if (challange.Value.StepData != null)
                                {
                                    if (!string.IsNullOrEmpty(challange.Value.StepData.PhoneNumber))
                                    {
                                        RadioVerifyWithPhoneNumber.Checked = false;
                                        RadioVerifyWithPhoneNumber.Visible = true;
                                        RadioVerifyWithPhoneNumber.Text = challange.Value.StepData.PhoneNumber;
                                    }
                                    if (!string.IsNullOrEmpty(challange.Value.StepData.Email))
                                    {
                                        RadioVerifyWithEmail.Checked = false;
                                        RadioVerifyWithEmail.Visible = true;
                                        RadioVerifyWithEmail.Text = challange.Value.StepData.Email;
                                    }
                                    group_DoğrulamaSeç.Visible = true;
                                    Size = ChallengeSize;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hata bu: "+challange.Info.Message);
                            }
                            break;
                        case InstaLoginResult.TwoFactorRequired:
                            group_İkiFaktör.Visible = true;
                            Size = ChallengeSize;
                            break;
                    }
                }
            }
            else
            {


                //var giris = await api.LoginAsync();
                IResult<InstaCurrentUser> cruser = await api.GetCurrentUserAsync();
                if (cruser.Succeeded)
                {
                    Text = "ISharp - Bağlanıldı (" + cruser.Value.UserName + ")";
                    girisbasarili();
                }
                else
                {
                    MessageBox.Show("Hataaa : " + cruser.Info.Message);
                    //girisbasarili(true);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = girisSize;
            //using (WebClient wc = new WebClient())
            //{
            //    wc.DownloadFileAsync(new Uri("http://www.sayka.com/downloads/front_view.jpg"), "sürüm.txt");
            //    wc.DownloadFileCompleted += kontrol;
            //}
            IniFile ıniFile = new IniFile(Application.StartupPath + "\\veriler.ini");
            ıniFile.Write("sira", "0", "begenisira");

        }

        void kontrol(object sender, AsyncCompletedEventArgs e)
        {
            var txt = File.ReadAllText("sürüm.txt");
            if (txt != Properties.Settings.Default.sürüm)
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://www.googleapis.com/drive/v3/files/1HmyvhWLDbQ5U6seve6nGOzQl5nlDeBn4/?key=AIzaSyCW2dYV-sCOcn5Ad3KHrZogWh6sCw0EL0k&alt=media", "ISharp yeni.exe");
                    client.DownloadFileCompleted += Bitti;
                }
            }
        }
        void Bitti(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("İndirme tamamlandı!");
            Close();
        }

        void Raporyaz(string yazi)
        {
            string saat = DateTime.Now.ToString("hh.mm.ss");
            txt_Rapor.Text += saat + " " + yazi + Environment.NewLine;
        }

        public async void girisbasarili(bool asd = false)
        {
            var kullaniciadi = await api.UserProcessor.GetCurrentUserAsync();
            if (asd == true)
            {
                if (kullaniciadi.Succeeded)
                    Text = "ISharp - Bağlanıldı (" + txt_Kadi.Text + ")";
            }
            if (!Directory.Exists(Application.StartupPath + "\\" + txt_Kadi.Text))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\" + txt_Kadi.Text);
                Directory.CreateDirectory(Application.StartupPath + "\\" + txt_Kadi.Text + "\\ayarlar");
                Directory.CreateDirectory(Application.StartupPath + "\\" + txt_Kadi.Text + "\\listeler");
            }
            if (Properties.Settings.Default.otocevap)
            {
                chk_MesajOtoYanit.Checked = true;
            }
            if (Properties.Settings.Default.takipcevap)
            {
                chk_MesajYeniTakip.Checked = true;
            }
            if (File.Exists(Application.StartupPath + "\\kisi"))
            {
                txt_HedefKişi.Text = File.ReadAllText(Application.StartupPath + "\\kisi");
            }

            if (File.Exists(Application.StartupPath + "\\hash"))
            {
                txt_HedefHash.Text = File.ReadAllText(Application.StartupPath + "\\hash");
            }

            if (File.Exists(Application.StartupPath + "\\konum"))
            {
                txt_HedefKonum.Text = File.ReadAllText(Application.StartupPath + "\\konum");
            }
            if (File.Exists(Application.StartupPath + "\\" + txt_Kadi.Text + "\\ayarlar\\yenitakipcevap.txt"))
            {
                txt_Mesaj.Text = File.ReadAllText(Application.StartupPath + "\\" + txt_Kadi.Text + "\\ayarlar\\yenitakipcevap.txt");
            }
            if (File.Exists(Application.StartupPath + "\\" + txt_Kadi.Text + "\\ayarlar\\mesajacevap.txt"))
            {
                txt_MesajCevapları.Text = File.ReadAllText(Application.StartupPath + "\\" + txt_Kadi.Text + "\\ayarlar\\mesajacevap.txt");
            }

            txt_HedefKişi.ScrollBars = ScrollBars.Vertical;
            txt_HedefKonum.ScrollBars = ScrollBars.Vertical;
            txt_HedefHash.ScrollBars = ScrollBars.Vertical;
            txt_Rapor.ScrollBars = ScrollBars.Vertical;
            Properties.Settings.Default.kadi = txt_Kadi.Text;
            Properties.Settings.Default.şifre = txt_Şifre.Text;
            Properties.Settings.Default.Save();
            groupGiriş.Visible = false;
            Mesaj.Visible = true;
            var pp = await api.UserProcessor.GetUserAsync(txt_Kadi.Text);
            if (pp.Succeeded)
            {
                string ppurl = pp.Value.ProfilePicUrl;
                WebRequest istek = WebRequest.Create(pp.Value.ProfilePicture);
                using (WebResponse isharp = istek.GetResponse())
                {
                    using (Stream stream = isharp.GetResponseStream())
                    {
                        pic_ProfilResmi.Image = Image.FromStream(stream);
                        pic_ProfilResmi.SizeMode = PictureBoxSizeMode.StretchImage;
                        Raporyaz("Profil resmi ayarlandı..");
                    }
                }
                lbl_KullaniciAdi.Text = pp.Value.FullName;
            }
            else
            {
                Raporyaz("Profil resmi alınırken hata!" + Environment.NewLine + pp.Info.Message);
            }
            try
            {

                 var takip = await api.UserProcessor.GetUserInfoByUsernameAsync(pp.Value.UserName);
                 lbl_TakipEdilen.Text += takip.Value.FollowingCount.ToString();
                 lbl_Takipçi.Text += takip.Value.FollowerCount.ToString();
                 lbl_Gonderi.Text = takip.Value.MediaCount.ToString() + " gönderiniz var";
                 group_Profil.Visible = true;
                 Size = TamSize;
                 Raporyaz("Profil Bilgileriniz başarıyla alındı");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SessionKaydet()
        {
            if (api != null)
            {
                if (api.IsUserAuthenticated)
                {
                    api.SessionHandler.FilePath = Application.StartupPath + "\\" + txt_Kadi.Text + ".bin";
                    api.SessionHandler.Save();
                }
            }
        }

        private void SessionYukle()
        {
            if (api != null)
            {
                ISessionHandler sessionHandler = api.SessionHandler;
                if (sessionHandler != null)
                {
                    sessionHandler.FilePath = Application.StartupPath + "\\" + txt_Kadi.Text + ".bin";
                    sessionHandler.Load();
                }
            }
        }


        private readonly Size NormalSize = new Size(230, 128);
        private readonly Size ChallengeSize = new Size(319, 347);
        private readonly Size TamSize = new Size(652, 347);
        private readonly Size girisSize = new Size(149, 187);
        public static IInstaApi api;

        private async void btn_TelefonOnayi_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_TelefonOnay.Text) || string.IsNullOrWhiteSpace(txt_TelefonOnay.Text))
                {
                    MessageBox.Show("Lütfen doğru bir telefon numarası giriniz.(Ülke kodu ile birlikte)\r\nörnek: +905555555555");
                }
                else
                {
                    string phoneNumber = txt_TelefonOnay.Text;
                    if (!phoneNumber.StartsWith("+"))
                    {
                        phoneNumber = "+" + phoneNumber;
                    }
                    IResult<InstaChallengeRequireSMSVerify> onay = await api.SubmitPhoneNumberForChallengeRequireAsync(phoneNumber, false);
                    if (onay.Succeeded)
                    {
                        group_KoduDoğrula.Visible = true;
                        group_TelefonOnay.Visible = false;
                        girisbasarili();
                    }
                    else
                    {
                        MessageBox.Show(onay.Info.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btn_Doğrula_Click(object sender, EventArgs e)
        {
            txtVerifyCode.Text = txtVerifyCode.Text.Trim();
            txtVerifyCode.Text = txtVerifyCode.Text.Replace(" ", "");
            Regex regex = new Regex("^-*[0-9,\\.]+$");
            if (!regex.IsMatch(txtVerifyCode.Text))
            {
                MessageBox.Show("Doğrulama kodu sayı olmalıdır!!!");
            }
            else
            {
                if (txtVerifyCode.Text.Length != 6)
                {
                    MessageBox.Show("Doğrulama kodu en az 6 haneli olmalıdır!!!");
                }
                else
                {
                    try
                    {
                        IResult<InstaLoginResult> sonuc = await api.VerifyCodeForChallengeRequireAsync(txtVerifyCode.Text);
                        if (sonuc.Succeeded)
                        {
                            Control verifyCodeGroupBox = group_KoduDoğrula;
                            Control selectMethodGroupBox = group_DoğrulamaSeç;
                            selectMethodGroupBox.Visible = false;
                            verifyCodeGroupBox.Visible = false;
                            Size = ChallengeSize;
                            SessionKaydet();
                            IResult<InstaCurrentUser> cruser = await api.GetCurrentUserAsync();
                            Text = "ISharp - Bağlanıldı (" + cruser.Value.UserName + ")";
                            girisbasarili();
                        }
                        else
                        {
                            group_DoğrulamaSeç.Visible = false;
                            group_KoduDoğrula.Visible = false;
                            if (sonuc.Value == InstaLoginResult.TwoFactorRequired)
                            {
                                group_İkiFaktör.Visible = true;
                                btn_İkiFaktör.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show(sonuc.Info.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata mesajı : " + ex.Message);
                    }
                }
            }
        }

        private async void btn_İkiFaktör_Click(object sender, EventArgs e)
        {
            if (api != null)
            {
                if (string.IsNullOrEmpty(txtTwoFactorCode.Text))
                {
                    MessageBox.Show("İki faktörlü doğrulama kodunu yazınız ve doğrula butonuna basın.");
                }
                else
                {
                    IResult<InstaLoginTwoFactorResult> result = await api.TwoFactorLoginAsync(txtTwoFactorCode.Text);
                    IResult<InstaLoginTwoFactorResult> twoFactorLogin = result;
                    Debug.WriteLine(twoFactorLogin.Value);
                    if (twoFactorLogin.Succeeded)
                    {
                        SessionKaydet();
                        Size = ChallengeSize;
                        group_İkiFaktör.Visible = false;
                        IResult<InstaCurrentUser> result2 = await api.GetCurrentUserAsync();
                        IResult<InstaCurrentUser> cruser = result2;
                        Text = "ISharp - Bağlanıldı (" + cruser.Value.UserName + ")";
                        girisbasarili();
                    }
                    else
                    {
                        MessageBox.Show(twoFactorLogin.Info.Message);
                    }
                }
            }
        }

        private async void btn_KodGönder_Click(object sender, EventArgs e)
        {
            bool isEmail = false;
            if (RadioVerifyWithEmail.Checked)
            {
                isEmail = true;
            }
            try
            {
                if (isEmail)
                {
                    IResult<InstaChallengeRequireEmailVerify> result = await api.RequestVerifyCodeToEmailForChallengeRequireAsync(false);
                    IResult<InstaChallengeRequireEmailVerify> email = result;
                    result = null;
                    if (email.Succeeded)
                    {
                        LblForSmsEmail.Text = "Doğrulama maili gönderildi:\n" + email.Value.StepData.ContactPoint;
                        group_KoduDoğrula.Visible = true;
                        group_DoğrulamaSeç.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(email.Info.Message);
                    }
                    email = null;
                }
                else
                {
                    IResult<InstaChallengeRequireSMSVerify> result2 = await api.RequestVerifyCodeToSMSForChallengeRequireAsync(false);
                    IResult<InstaChallengeRequireSMSVerify> phoneNumber = result2;
                    result2 = null;
                    if (phoneNumber.Succeeded)
                    {
                        LblForSmsEmail.Text = "Doğrulama kodu  telefona gönderildi: \n" + phoneNumber.Value.StepData.ContactPoint;
                        group_KoduDoğrula.Visible = true;

                        group_DoğrulamaSeç.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show(phoneNumber.Info.Message);
                    }
                    phoneNumber = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DosyaSeç_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyaları|*.jpg;*.jpeg;; |Video Dosyası|*.mp4;";
            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                txt_Etiket.Visible = false;
                label1.Visible = false;
                lbl_Dosyayolu.Text = openFileDialog1.FileName;
                if (openFileDialog1.FileName.Contains(".jpg") || openFileDialog1.FileName.Contains(".jpeg"))
                {
                    pic_onizleme.Image = Image.FromFile(openFileDialog1.FileName);
                    pic_onizleme.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    if (openFileDialog1.FileName.Contains(".mp4"))
                    {
                        txt_Etiket.Visible = true;
                        label1.Visible = true;
                        if (File.Exists(Application.StartupPath + "\\onizleme.jpg"))
                        {
                            File.Delete(Application.StartupPath + "\\onizleme.jpg");
                        }
                        Bitmap onizleme = GetThumbnail(openFileDialog1.FileName, Application.StartupPath + "\\onizleme.jpg");
                        if (onizleme.Height > 1)
                        {
                            pic_onizleme.Image = onizleme;
                            pic_onizleme.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else
                        {
                            MessageBox.Show("FFmpeg bulunamadı! Otomatik olarak indirilecek. İndirme bittiğinde bilgi mesajını göreceksiniz");
                            if (File.Exists(Application.StartupPath + "\\ffmpegindir.exe"))
                            {
                                Process.Start(Application.StartupPath + "\\ffmpegindir.exe");
                            }
                            else
                            {
                                MessageBox.Show("İndirme uygulaması bulunamadı. Manuel olarak indirin.");
                            }
                        }
                    }
                }
            }
        }

        public static Bitmap GetThumbnail(string video, string thumbnail)
        {
            if (File.Exists(Application.StartupPath + "\\ffmpeg.exe"))
            {
                string cmd = string.Concat(new string[]
{
                "ffmpeg  -itsoffset -1  -i \"",
                video,
                "\" -vcodec mjpeg -vframes 1 -an -f rawvideo -s 100x100 \"",
                thumbnail,
                "\""
});
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/C " + cmd
                };
                Process process = new Process
                {
                    StartInfo = startInfo
                };
                process.Start();
                process.WaitForExit(5000);
                return LoadImage(thumbnail);
            }
            else
            {
                MessageBox.Show("ffmpeg.exe bulunamadı! Lütfen indikten sonra tekrar deneyin!");
                Bitmap B = new Bitmap(1, 1);
                return B;
            }

        }

        private static Bitmap LoadImage(string path)
        {
            MemoryStream ms = new MemoryStream(File.ReadAllBytes(path));
            return (Bitmap)Image.FromStream(ms);
        }

        private async void btn_Yükle_Click(object sender, EventArgs e)
        {
            if (lbl_Dosyayolu.Text.Contains(".jpeg") || lbl_Dosyayolu.Text.Contains(".jpg"))
            {
                Image img = Image.FromFile(lbl_Dosyayolu.Text);
                InstaImageUpload mediaImage = new InstaImageUpload
                {
                    Height = img.Height,
                    Width = img.Width,
                    Uri = lbl_Dosyayolu.Text
                };
                Raporyaz("Resim Yükleme işlemi başladı!");
                IResult<InstaMedia> result3 = await api.MediaProcessor.UploadPhotoAsync(mediaImage, txt_Açıklama.Text, null);
                IResult<InstaMedia> result = result3;
                Raporyaz(result.Succeeded ? ("Medya Yüklendi: " + result.Value.Pk) : ("Medya Yüklemede Hata! " + result.Info.Message));
            }
            else if (lbl_Dosyayolu.Text.Contains(".mp4"))
            {
                if (File.Exists(Application.StartupPath + "\\onizleme.jpg"))
                {
                    File.Delete(Application.StartupPath + "\\onizleme.jpg");
                }
                GetThumbnail(lbl_Dosyayolu.Text, Application.StartupPath + "\\onizleme.jpg");
                InstaVideoUpload video = new InstaVideoUpload
                {
                    Video = new InstaVideo(lbl_Dosyayolu.Text, 0, 0),
                    VideoThumbnail = new InstaImage(Application.StartupPath + "\\onizleme.jpg", 100, 100)
                };
                if (!string.IsNullOrEmpty(txt_Etiket.Text))
                {
                    video.UserTags.Add(new InstaUserTagVideoUpload
                    {
                        Username = txt_Etiket.Text
                    });
                }
                Raporyaz("Video yükleme işlemi başladı!");
                IResult<InstaMedia> result4 = await api.MediaProcessor.UploadVideoAsync(video, txt_Açıklama.Text, null);
                IResult<InstaMedia> result2 = result4;
                Raporyaz(result2.Succeeded ? string.Format("Video yüklendi: {0}, {1}", result2.Value.Pk, result2.Value.Caption) : ("Video Yüklemede Hata!: " + result2.Info.Message));
            }
        }

        private async void btn_Story_Click(object sender, EventArgs e)
        {
            if (radio_StorySoru.Checked)
            {
                var storyAyarlari = new InstaStoryUploadOptions();
                double x = double.Parse(txt_groupSoruSor_X.Text);
                double y = double.Parse(txt_groupSoruSor_Y.Text);
                double rotasyon = double.Parse(txt_groupSoruSor_Rota.Text);
                string soru = txt_groupSoruSor_Soru.Text;
                string arkaplanrenk = txt_groupSoruSor_ArkaPlanRenk.Text;
                string yazirenk = txt_groupSoruSor_yazirenk.Text;
                storyAyarlari.Questions.Add(new InstaStoryQuestionUpload
                {
                    X = x, // center of image
                    Y = y, // center of image
                    Z = 0,
                    Width = 0.4753681,
                    Height = 0.16234669,
                    Rotation = rotasyon,
                    Question = soru,
                    BackgroundColor = "#ffffff", // #ffffff is white
                    TextColor = "#000000" // #000000 is black
                });
                var resim = new InstaImage { Uri = @"" + lbl_storyDosyaKonum.Text };

                var result = await api.StoryProcessor.UploadStoryPhotoAsync(resim, "someawesomepicture", storyAyarlari);
                // upload video
                //var result = await InstaApi.MediaProcessor.UploadVideoAsync(video, "ramtinak", storyOptions);
                Raporyaz(result.Succeeded
                    ? $"Story created: {result.Value.Media.Pk}"
                    : $"Unable to upload photo story: {result.Info.Message}");
            }
            if (radio_StoryEtiket.Checked)
            {
                double x = double.Parse(txt_StoryEtiketX.Text);
                double y = double.Parse(txt_StoryEtiketY.Text);
                double rotasyon = double.Parse(txt_StoryEtiketRota.Text);

                var storyAyarlari = new InstaStoryUploadOptions();
                storyAyarlari.Mentions.Add(new InstaStoryMentionUpload
                {
                    X = x, // center of image
                    Y = y, // center of image
                    Z = 0,
                    Width = 0.7972222,
                    Height = 0.21962096,
                    Rotation = rotasyon,
                    Username = txt_StoryEtiket.Text
                });
                var resim = new InstaImage { Uri = @"" + lbl_storyDosyaKonum.Text };

                var result = await api.StoryProcessor.UploadStoryPhotoAsync(resim, "someawesomepicture", storyAyarlari);
                Raporyaz(result.Succeeded
                    ? $"Story created: {result.Value.Media.Pk}"
                    : $"Unable to upload photo story: {result.Info.Message}");
            }
            if (radio_StoryAnket.Checked)
            {
                var storyAyarlari = new InstaStoryUploadOptions();
                storyAyarlari.Polls.Add(new InstaStoryPollUpload
                {
                    X = float.Parse(txt_StoryAnketX.Text), // center of image
                    Y = float.Parse(txt_StoryAnketY.Text), // center of image
                    Z = 0,
                    Width = 0.3148148,
                    Height = 0.110367894,
                    Rotation = int.Parse(txt_StoryAnketRota.Text),
                    Question = txt_StoryAnketSoru.Text,
                    Answer1 = txt_StoryAnketCevap1.Text, // "YES" answer
                    Answer2 = txt_StoryAnketCevap2.Text // "NO" answer
                });
                var resim = new InstaImage { Uri = @"" + lbl_storyDosyaKonum.Text };

                var result = await api.StoryProcessor.UploadStoryPhotoAsync(resim, "someawesomepicture", storyAyarlari);
                // upload video
                //var result = await InstaApi.MediaProcessor.UploadVideoAsync(video, "ramtinak", storyOptions);
                Raporyaz(result.Succeeded
                    ? $"Story created: {result.Value.Media.Pk}"
                    : $"Unable to upload photo story: {result.Info.Message}");
            }
            if (radio_StoryHashtag.Checked)
            {
                var storyAyarlari = new InstaStoryUploadOptions();
                double x = double.Parse(txt_StoryHashtagX.Text);
                double y = double.Parse(txt_StoryHashtagY.Text);
                double rotasyon = double.Parse(txt_StoryHashtagRota.Text);
                storyAyarlari.Hashtags.Add(new InstaStoryHashtagUpload
                {
                    X = x,
                    Y = y,
                    Z = 0,
                    Width = 0.3148148,
                    Height = 0.110367894,
                    Rotation = rotasyon,
                    TagName = txt_StoryHashtag.Text
                });
                var resim = new InstaImage { Uri = @"" + lbl_storyDosyaKonum.Text };

                var result = await api.StoryProcessor.UploadStoryPhotoAsync(resim, "someawesomepicture", storyAyarlari);
                // upload video
                //var result = await InstaApi.MediaProcessor.UploadVideoAsync(video, "ramtinak", storyOptions);
                Raporyaz(result.Succeeded
                    ? $"Story created: {result.Value.Media.Pk}"
                    : $"Unable to upload photo story: {result.Info.Message}");
            }
            if (radio_StoryKonum.Checked)
            {
                var storyAyarlari = new InstaStoryUploadOptions();
                var locationsResult = await api.LocationProcessor.SearchLocationAsync(0, 0, txt_StoryKonumİsim.Text);
                var firstLocation = locationsResult.Value.FirstOrDefault();
                var locationId = firstLocation.ExternalId;

                storyAyarlari.Locations.Add(new InstaStoryLocationUpload
                {
                    X = float.Parse(txt_StoryKonumX.Text), // center of image
                    Y = float.Parse(txt_StoryKonumY.Text), // center of image
                    Z = 0,
                    Width = 0.3148148,
                    Height = 0.110367894,
                    Rotation = float.Parse(txt_StoryKonumRota.Text),
                    LocationId = locationId
                });
                var resim = new InstaImage { Uri = @"" + lbl_storyDosyaKonum.Text };

                var result = await api.StoryProcessor.UploadStoryPhotoAsync(resim, "someawesomepicture", storyAyarlari);
                // upload video
                //var result = await InstaApi.MediaProcessor.UploadVideoAsync(video, "ramtinak", storyOptions);
                Raporyaz(result.Succeeded
                    ? $"Story created: {result.Value.Media.Pk}"
                    : $"Unable to upload photo story: {result.Info.Message}");
            }
        }

        private void btn_KişiEkle_Click(object sender, EventArgs e)
        {
            txt_HedefKişi.Text += "@hesapadiburaya" + Environment.NewLine;
        }

        private void btn_HashtagEkle_Click(object sender, EventArgs e)
        {
            txt_HedefHash.Text += "#hashtagburaya" + Environment.NewLine;
        }

        private void btn_KonumEkle_Click(object sender, EventArgs e)
        {
            txt_HedefKonum.Text += "!konumadiburaya" + Environment.NewLine;
        }

        private void btn_HedefKaydet_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\kisi"))
            {
                File.Delete(Application.StartupPath + "\\kisi");
                File.WriteAllText(Application.StartupPath + "\\kisi", txt_HedefKişi.Text);
            }
            else
            {
                File.WriteAllText(Application.StartupPath + "\\kisi", txt_HedefKişi.Text);
            }

            if (File.Exists(Application.StartupPath + "\\hash"))
            {
                File.Delete(Application.StartupPath + "\\hash");
                File.WriteAllText(Application.StartupPath + "\\hash", txt_HedefHash.Text);
            }
            else
            {
                File.WriteAllText(Application.StartupPath + "\\hash", txt_HedefHash.Text);
            }

            if (File.Exists(Application.StartupPath + "\\konum"))
            {
                File.Delete(Application.StartupPath + "\\konum");
                File.WriteAllText(Application.StartupPath + "\\konum", txt_HedefKonum.Text);
            }
            else
            {
                File.WriteAllText(Application.StartupPath + "\\konum", txt_HedefKonum.Text);
            }
        }

        private void btn_KaydetBaşlaDurdur_Click(object sender, EventArgs e)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (chk_Windows.Checked)
            {
                registryKey.SetValue("ISharp", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("ISharp");
            }
        }

        private void btn_Başla_Click(object sender, EventArgs e)
        {
            string[] kisiliste = txt_HedefKişi.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[] hashliste = txt_HedefHash.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[] konumliste = txt_HedefKonum.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            File.WriteAllLines(Application.StartupPath + "\\kisi", Array.ConvertAll(kisiliste, x => x.ToString()));
            File.WriteAllLines(Application.StartupPath + "\\hash", Array.ConvertAll(hashliste, x => x.ToString()));
            File.WriteAllLines(Application.StartupPath + "\\konum", Array.ConvertAll(konumliste, x => x.ToString()));
        }

        private async void btn_BegeniBasla_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_BegeniHash.Text))
            {
                string[] txtBegeniHash = txt_BegeniHash.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                for (int a = 0;a <= txtBegeniHash.Count();a++)
                {
                    Raporyaz(txtBegeniHash[a] + " hashtagına ait medyalar alınıyor!");
                    var begenilecekkisi = await api.HashtagProcessor.GetRecentHashtagMediaListAsync(txtBegeniHash[a], PaginationParameters.MaxPagesToLoad(3));
                    var begenilecekkisi2 = begenilecekkisi.Value.Medias;
                    string[] vs = new string[begenilecekkisi2.Count];
                    foreach (var deger in begenilecekkisi2)
                    {
                        if (File.Exists(Application.StartupPath + "\\listeler\\begenilecekler.txt"))
                        {
                            File.WriteAllText(Application.StartupPath + "\\listeler\\begenilecekler.txt", File.ReadAllText(Application.StartupPath + "\\listeler\\begenilecekler.txt") + deger.Pk + Environment.NewLine);
                        }
                        else
                        {
                            File.WriteAllText(Application.StartupPath + "\\listeler\\begenilecekler.txt", deger.Pk + Environment.NewLine);
                        }
                    }
                    File.WriteAllLines(Application.StartupPath + "\\listeler\\begenilecekler.txt", vs);
                    Raporyaz(txtBegeniHash[a] + " hashtagına ait medyalar alındı!");
                    if (a == txtBegeniHash.Count() - 1)
                    {
                        break;
                    }
                }
                Raporyaz("Hashtag alma işlemi bitti");
            }

            if (!string.IsNullOrEmpty(txt_BegeniSayfa.Text))
            {
                string[] txtBegeniSayfa = txt_BegeniSayfa.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                for (int a = 0;a <= txtBegeniSayfa.Count();a++)
                {
                    Raporyaz(txtBegeniSayfa[a] + "'nın gönderileri alınıyor..");
                    var medyar = await api.UserProcessor.GetUserMediaAsync(txtBegeniSayfa[0], PaginationParameters.MaxPagesToLoad(3));
                    if (medyar.Succeeded)
                    {
                        foreach (var deger in medyar.Value)
                        {
                            if (File.Exists(Application.StartupPath + "\\listeler\\begenilecekler.txt"))
                            {
                                File.WriteAllText(Application.StartupPath + "\\listeler\\begenilecekler.txt", File.ReadAllText(Application.StartupPath + "\\listeler\\begenilecekler.txt") + deger.Pk + Environment.NewLine);
                            }
                            else
                            {
                                File.WriteAllText(Application.StartupPath + "\\listeler\\begenilecekler.txt", deger.Pk + Environment.NewLine);
                            }
                        }
                        Raporyaz(txtBegeniSayfa[a] + "'nın gönderileri alındı.");
                        if (a == txtBegeniSayfa.Count() - 1)
                        {
                            Raporyaz("Gönderi alma işlemi tamamlandı..");
                            break;
                        }
                    }
                    else
                    {
                        Raporyaz(txtBegeniSayfa[a] + "'nın gönderilerini alırken hata! :" + medyar.Info.Message);
                    }

                }
            }

            if (!string.IsNullOrEmpty(txt_BegeniKonum.Text))
            {
                string[] txtBegeniKonum = txt_BegeniKonum.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var a in txtBegeniKonum)
                {
                    Raporyaz(a + " konumunundaki gönderiler alınıyor..");
                    var locationsResult = await api.LocationProcessor.SearchLocationAsync(0, 0, a);
                    var firstLocation = locationsResult.Value.FirstOrDefault();
                    var locationId = firstLocation.ExternalId;
                    var medya = await api.LocationProcessor.GetRecentLocationFeedsAsync(long.Parse(locationId), PaginationParameters.MaxPagesToLoad(3));
                    foreach (var deger in medya.Value.Medias)
                    {
                        if (File.Exists(Application.StartupPath + "\\listeler\\begenilecekler.txt"))
                        {
                            File.WriteAllText(Application.StartupPath + "\\listeler\\begenilecekler.txt", File.ReadAllText(Application.StartupPath + "\\listeler\\begenilecekler.txt") + deger.Pk + Environment.NewLine);
                        }
                        else
                        {
                            File.WriteAllText(Application.StartupPath + "\\listeler\\begenilecekler.txt", deger.Pk + Environment.NewLine);
                        }
                    }
                    Raporyaz(a + " konumundaki gönderiler alındı..");
                }

            }
            var inifile = new IniFile(Application.StartupPath + "\\veriler.ini");
            inifile.Write("sira", "0", "begenisira");
            timer_Begeni_Tick(new object(), new EventArgs());
            timer_Begeni.Interval = 120000;
            timer_Begeni.Enabled = true;
        }

        private async void timer_Begeni_Tick(object sender, EventArgs e)
        {
        Etiket1:
            string[] listebegeni = File.ReadAllLines(Application.StartupPath + "\\listeler\\begenilecekler.txt");
            if (listebegeni.Count() <= 0)
            {
                Raporyaz("Beğenilecek gönderi yok! Daha fazla hedef eklemeyi deneyin!");
                timer_Begeni.Enabled = false;
                return;
            }
            var a = await api.MediaProcessor.GetMediaByIdAsync(listebegeni[0]);
            if (a.Value.Pk.Count() < listebegeni.Count())
            {
                return;
            }
            if (a.Value.HasLiked)
            {
                siradaki(Application.StartupPath + "\\listeler\\begenilecekler.txt");
                var abs = File.ReadAllLines(Application.StartupPath + "\\listeler\\begenilecekler.txt");
                if (abs.Count() <= 0)
                {
                    Raporyaz("Tüm postlar beğenildi!");
                    return;
                }
                goto Etiket1;
            }
            var begeni = await api.MediaProcessor.LikeMediaAsync(listebegeni[0]);
            if (begeni.Succeeded)
            {
                if (a.Succeeded)
                {
                    Raporyaz(a.Value.User.UserName + " adlı kişinin postu beğenildi! (" + listebegeni[0] + ")");
                }
            }
            else
            {
                Raporyaz("Beğenme işlem sırasında hata :" + begeni.Info.Message);
            }
            siradaki(Application.StartupPath + "\\listeler\\begenilecekler.txt");
            if (File.ReadAllLines(Application.StartupPath + "\\listeler\\begenilecekler.txt").Count() <= 0)
            {
                Raporyaz("Beğenilecek tüm postlar beğenildi!");
                timer_Begeni.Enabled = false;
                return;
            }
        }

        private void btn_StorySeç_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyaları|*.jpg;*.jpeg;; |Video Dosyası|*.mp4;";
            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                if (openFileDialog1.FileName.Contains(".mp4"))
                {
                    if (File.Exists(Application.StartupPath + "\\onizleme.jpg"))
                    {
                        File.Delete(Application.StartupPath + "\\onizleme.jpg");
                    }
                    Bitmap onizleme = GetThumbnail(openFileDialog1.FileName, Application.StartupPath + "\\onizleme.jpg");
                    if (onizleme.Height > 1)
                    {
                        pic_StoryOnizleme.Image = onizleme;
                        pic_StoryOnizleme.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    lbl_storyDosyaKonum.Text = openFileDialog1.FileName;
                }
                else if (openFileDialog1.FileName.Contains(".jpg") || openFileDialog1.FileName.Contains(".jpeg"))
                {
                    pic_StoryOnizleme.Image = Image.FromFile(openFileDialog1.FileName);
                    pic_StoryOnizleme.SizeMode = PictureBoxSizeMode.StretchImage;
                    lbl_storyDosyaKonum.Text = openFileDialog1.FileName;
                    group_StoryAyar.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Dosya seçimi yapmadınız!");
            }

        }

        private void radio_StorySoru_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_StorySoru.Checked)
            {
                group_StorySoruSor.Visible = true;
                group_StoryHashtag.Visible = false;
                group_StoryEtiket.Visible = false;
                group_StoryAnket.Visible = false;
                group_StoryKonum.Visible = false;
            }
        }

        private void radio_StoryEtiket_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_StoryEtiket.Checked)
            {
                group_StoryEtiket.Visible = true;
                group_StorySoruSor.Visible = false;
                group_StoryHashtag.Visible = false;
                group_StoryAnket.Visible = false;
                group_StoryKonum.Visible = false;
            }
        }

        private void radio_StoryAnket_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_StoryAnket.Checked)
            {
                group_StorySoruSor.Visible = false;
                group_StoryHashtag.Visible = false;
                group_StoryEtiket.Visible = false;
                group_StoryAnket.Visible = true;
                group_StoryKonum.Visible = false;
            }
        }

        private void radio_StoryHashtag_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_StoryHashtag.Checked)
            {
                group_StorySoruSor.Visible = false;
                group_StoryHashtag.Visible = true;
                group_StoryEtiket.Visible = false;
                group_StoryAnket.Visible = false;
                group_StoryKonum.Visible = false;
            }
        }

        private void radio_StoryKonum_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_StoryKonum.Checked)
            {
                group_StorySoruSor.Visible = false;
                group_StoryHashtag.Visible = false;
                group_StoryEtiket.Visible = false;
                group_StoryAnket.Visible = false;
                group_StoryKonum.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Mesaj.Text += "<@alıcıadı>";
        }

        private async void btn_MesajKaydet_Click(object sender, EventArgs e)
        {
            var kullaniciadi = await api.UserProcessor.GetCurrentUserAsync();
            File.WriteAllText(Application.StartupPath + "\\" + txt_Kadi.Text + "\\ayarlar\\yenitakipcevap.txt", txt_Mesaj.Text);
            File.WriteAllText(Application.StartupPath + "\\" + txt_Kadi.Text + "\\ayarlar\\mesajacevap.txt", txt_MesajCevapları.Text);
            if (chk_MesajOtoYanit.Checked)
            {
                Properties.Settings.Default.otocevap = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.otocevap = false;
                Properties.Settings.Default.Save();
            }
            if (chk_MesajYeniTakip.Checked)
            {
                Properties.Settings.Default.takipcevap = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.takipcevap = false;
                Properties.Settings.Default.Save();
            }

        }

        private void btn_MesajCevapEkle_Click(object sender, EventArgs e)
        {
            txt_MesajCevapları.Text += '"' + txt_MesajAranacakKelime.Text + '"' + '<' + txt_MesajCevap.Text + '>' + System.Environment.NewLine;
        }

        private void btn_MesajBaşla_Click(object sender, EventArgs e)
        {
            timer_Mesaj.Interval = 60000;
            timer_Mesaj.Enabled = true;
            timer_Mesaj_Tick(new object(), new EventArgs());
        }

        private void timer_Mesaj_Tick(object sender, EventArgs e)
        {
            if (chk_MesajOtoYanit.Checked)
            {
                string[] sep = new string[] { "\r\n" };
                string[] lines = txt_MesajCevapları.Text.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                foreach (var abc in lines)
                {
                    if (!string.IsNullOrEmpty(abc))
                    {
                        string aranacak = StringBetween(abc, "\"", "\"");
                        string gonderilecek = StringBetween(abc, "<", ">");
                        Cevapla(aranacak, gonderilecek);
                    }
                }
            }
            if (chk_MesajYeniTakip.Checked)
            {
                yenitakipcevapla();
            }
        }

        public async void Cevapla(string aranacak, string gonderilecek)
        {
            var gelen = await api.MessagingProcessor.GetDirectInboxAsync(PaginationParameters.Empty);
            if (gelen.Succeeded)
            {
                foreach (var thread in gelen.Value.Inbox.Threads)
                {
                    if (thread.HasUnreadMessage)
                    {
                        foreach (var asd in thread.Items)
                        {
                            if (!string.IsNullOrEmpty(asd.Text))
                            {
                                if (asd.Text.ToLower().Contains(aranacak))
                                {
                                    var gonderme = await api.MessagingProcessor.SendDirectTextAsync(null, thread.ThreadId, gonderilecek);
                                    if (gonderme.Succeeded)
                                    {
                                        Raporyaz("cevaplandı : " + thread.Title);
                                    }
                                    else
                                    {
                                        Raporyaz("cevaplamada hata : " + thread.ThreadId);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Raporyaz("Mesaj kutusu alınırken hata! :" + gelen.Info.Message);
            }
        }

        public async void yenitakipcevapla()
        {
            var kullaniciadi = await api.UserProcessor.GetCurrentUserAsync();
            if (File.Exists(Application.StartupPath + "\\" + txt_Kadi.Text + "\\ayarlar\\yenitakipliste.txt"))
            {
                var deneme = await api.UserProcessor.GetCurrentUserFollowersAsync(PaginationParameters.Empty);
                if (deneme.Succeeded)
                {
                    string[] fark = new string[deneme.Value.Count];
                    int x = 0;
                    foreach (var a in deneme.Value)
                    {
                        fark[x] = a.UserName;
                        x++;
                    }
                    string[] varolanliste = File.ReadAllLines(Application.StartupPath + "\\" + txt_Kadi.Text + "\\ayarlar\\yenitakipliste.txt");
                    var farklar = fark.Except(varolanliste);
                    foreach (var a in farklar)
                    {
                        var pk = await api.UserProcessor.GetUserInfoByUsernameAsync(a);
                        if (pk.Succeeded)
                        {
                            var friendshipamk = await api.UserProcessor.GetFriendshipStatusAsync(pk.Value.Pk);
                            if (friendshipamk.Succeeded || friendshipamk.Value.FollowedBy)
                            {
                                var inbox = await api.MessagingProcessor.GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(1));
                                var desireThread = inbox.Value.Inbox.Threads
                                    .Find(u => u.Users.FirstOrDefault().UserName.ToLower() == a);
                                var requestedThreadId = desireThread.ThreadId;
                                string atilcakmesaj1 = txt_Mesaj.Text;
                                atilcakmesaj1 = atilcakmesaj1.Replace("<@alıcıadı>", pk.Value.Username);
                                var mesajat = await api.MessagingProcessor.SendDirectTextAsync(null, requestedThreadId, atilcakmesaj1);
                                Raporyaz("Yeni takipçi " + a + " 'ya mesaj iletildi.");
                            }
                        }
                    }
                    int b = 0;
                    string[] array1 = new string[deneme.Value.Count()];
                    foreach (var yazi in deneme.Value)
                    {
                        array1[b] = yazi.UserName;
                        b++;
                    }
                    File.WriteAllLines(Application.StartupPath + "\\" + txt_Kadi.Text + "\\ayarlar\\yenitakipliste.txt", array1);
                    Raporyaz("Takipçi listesi güncellendi!");
                }
            }
            else
            {
                var deneme = await api.UserProcessor.GetCurrentUserFollowersAsync(PaginationParameters.Empty);
                if (deneme.Succeeded)
                {
                    int x = 0;
                    string[] array1 = new string[deneme.Value.Count()];
                    foreach (var yazi in deneme.Value)
                    {
                        array1[x] = yazi.UserName;
                        x++;
                    }
                    File.WriteAllLines(Application.StartupPath + "\\" + txt_Kadi.Text + "\\ayarlar\\yenitakipliste.txt", array1);
                    Raporyaz("Takip listesi alındı!");
                }
            }
        }

        public string StringBetween(string STR, string FirstString, string LastString)
        {
            int pFrom = STR.IndexOf(FirstString) + FirstString.Length;
            int pTo = STR.LastIndexOf(LastString);
            string result = STR.Substring(pFrom, pTo - pFrom);
            return result;
        }

        private async void btn_Yorum_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\listeler\\yorumlanacak.txt"))
                File.Delete(Application.StartupPath + "\\listeler\\yorumlanacak.txt");
            //var fileStream = new FileStream(Application.StartupPath + "\\listeler\\yorumlanacak.txt", FileMode.OpenOrCreate, FileAccess.Write);
            var kullaniciadi = await api.UserProcessor.GetCurrentUserAsync();
            if (!string.IsNullOrEmpty(txt_YorumSayfa.Text))
            {
                string[] yorumsayfa = txt_YorumSayfa.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var f1 in yorumsayfa)
                {
                    Raporyaz(f1 + "'nın gönderileri alınıyor..");
                    var medyar = await api.UserProcessor.GetUserMediaAsync(f1, PaginationParameters.Empty);
                    foreach (var deger in medyar.Value)
                    {                     
                        if (File.Exists(Application.StartupPath + "\\listeler\\yorumlanacak.txt"))
                        {
                            File.WriteAllText(Application.StartupPath + "\\listeler\\yorumlanacak.txt", File.ReadAllText(Application.StartupPath + "\\listeler\\yorumlanacak.txt") + deger.Pk + Environment.NewLine);
                        }
                        else
                        {
                            File.WriteAllText(Application.StartupPath + "\\listeler\\yorumlanacak.txt", deger.Pk + Environment.NewLine);
                        }

                    }
                    Raporyaz(f1 + "'nın gönderileri alındı.");
                }
            }
            if (!string.IsNullOrEmpty(txt_YorumHashtag.Text))
            {
                string[] yorumhash = txt_YorumHashtag.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var f2 in yorumhash)
                {
                    Raporyaz(f2 + " hashtagina ait medyalar alınıyor!");
                    var medya = await api.HashtagProcessor.GetRecentHashtagMediaListAsync(f2, PaginationParameters.MaxPagesToLoad(5));
                    string[] vs3 = new string[medya.Value.Medias.Count()];
                    var hashtag = medya.Value.Medias;
                    foreach (var deger in hashtag)
                    {
                        if (File.Exists(Application.StartupPath + "\\listeler\\yorumlanacak.txt"))
                        {
                            File.WriteAllText(Application.StartupPath + "\\listeler\\yorumlanacak.txt", File.ReadAllText(Application.StartupPath + "\\listeler\\yorumlanacak.txt") + deger.Pk + Environment.NewLine);
                        }
                        else
                        {
                            File.WriteAllText(Application.StartupPath + "\\listeler\\yorumlanacak.txt", deger.Pk + Environment.NewLine);
                        }
                    }


                }
                if (!string.IsNullOrEmpty(txt_YorumKonum.Text))
                {
                    string[] yorumkonum = txt_YorumKonum.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var f2 in yorumkonum)
                    {
                        Raporyaz(f2 + " konumuna ait medyalar alınıyor!");
                        var locationsResult = await api.LocationProcessor.SearchLocationAsync(0, 0, txt_StoryKonumİsim.Text);
                        var firstLocation = locationsResult.Value.FirstOrDefault();
                        var locationId = firstLocation.ExternalId;
                        if (locationsResult.Succeeded)
                        {
                            var yorumkonum2 = await api.LocationProcessor.GetRecentLocationFeedsAsync(long.Parse(locationId), PaginationParameters.MaxPagesToLoad(5));
                            if (yorumkonum2.Succeeded)
                            {
                                foreach (var deger in yorumkonum2.Value.Medias)
                                {
                                    if (File.Exists(Application.StartupPath + "\\listeler\\yorumlanacak.txt"))
                                    {
                                        File.WriteAllText(Application.StartupPath + "\\listeler\\yorumlanacak.txt", File.ReadAllText(Application.StartupPath + "\\listeler\\yorumlanacak.txt") + deger.Pk + Environment.NewLine);
                                    }
                                    else
                                    {
                                        File.WriteAllText(Application.StartupPath + "\\listeler\\yorumlanacak.txt", deger.Pk + Environment.NewLine);
                                    }
                                }
                            }
                            else
                            {
                                Raporyaz(f2 + " konumu medyaları alınırken hata!");
                            }
                        }
                        else
                        {
                            Raporyaz(f2 + " konumu alınırken hata!" + locationsResult.Info.Message);
                        }

                    }
                }
            }
            timer_Yorum.Interval = 120000;
            timer_Yorum.Enabled = true;
            timer_Yorum_Tick(new object(), new EventArgs());
        }

        private async void timer_Yorum_Tick(object sender, EventArgs e)
        {
            var inifile = new IniFile(Application.StartupPath + "\\veriler.ini");
            if(!File.Exists(Application.StartupPath + "\\listeler\\yorumlanacak.txt"))
            {
                File.Create(Application.StartupPath + "\\listeler\\yorumlanacak.txt");
            }
            string[] listeyorum = File.ReadAllLines(Application.StartupPath + "\\listeler\\yorumlanacak.txt");
                      
            if (listeyorum.Count() <= 0)
            {
                Raporyaz("Yorumlanacak gönderi yok! Daha fazla hedef eklemeyi deneyin!");
                timer_Yorum.Enabled = false;
                return;
            }
            var a = await api.MediaProcessor.GetMediaByIdAsync(listeyorum.FirstOrDefault());
            if (a.Value.Pk.Count() < listeyorum.Count())
            {
                return;
            }
            var yorum = await api.CommentProcessor.CommentMediaAsync(listeyorum.FirstOrDefault(), txt_YorumYorum.Text);
            if (yorum.Succeeded)
            {
                if (a.Succeeded)
                {
                    Raporyaz(a.Value.User.UserName + " adlı kişinin postu yorumlandı! (" + yorum.Value.Pk + ")");
                }
            }
            else
            {
                Raporyaz("Yorum işlemi sırasında hata :" + yorum.Info.Message);
            }
            siradaki(Application.StartupPath + "\\listeler\\yorumlanacak.txt");
        }

        void siradaki(string path)
        {
            if (File.Exists(path))
            {
                var list = File.ReadAllLines(path);
                string[] list2 = new string[1];
                list2[0] = list[0];
                var fark = list.Except(list2);
                File.WriteAllLines(path, fark);
            }
        }

        private async void btn_TakipBasla_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_TakipHashtag.Text))
            {
                string[] takip = txt_TakipHashtag.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach(var deger in takip)
                {
                    Raporyaz(deger + " hashtagında ki kişiler alınıyor");
                    var hashtag = await api.HashtagProcessor.GetRecentHashtagMediaListAsync(deger, PaginationParameters.MaxPagesToLoad(5));
                    if (hashtag.Succeeded)
                    {
                        foreach (var deger2 in hashtag.Value.Medias)
                        {
                            if (File.Exists(Application.StartupPath + "\\listeler\\takipedilecek.txt"))
                            {
                                File.WriteAllText(Application.StartupPath + "\\listeler\\takipedilecek.txt", File.ReadAllText(Application.StartupPath + "\\listeler\\takipedilecek.txt") + deger2.User.Pk + Environment.NewLine);
                            }
                            else
                            {
                                File.WriteAllText(Application.StartupPath + "\\listeler\\takipedilecek.txt", deger2.User.Pk + Environment.NewLine);
                            }
                        }
                        Raporyaz(deger + " hashtagında ki kişiler alındı!");
                    }
                    else
                    {
                        Raporyaz(deger + " hashtagında ki kişiler alınırken hata! " + hashtag.Info.Message);
                    }
                }
            }
            if (!string.IsNullOrEmpty(txt_TakipKonum.Text))
            {
                string[] takip = txt_TakipKonum.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var f2 in takip)
                {
                    Raporyaz(f2 + " konumundaki kişiler alınıyor!");
                    var locationsResult = await api.LocationProcessor.SearchLocationAsync(0, 0, txt_StoryKonumİsim.Text);
                    var firstLocation = locationsResult.Value.FirstOrDefault();
                    var locationId = firstLocation.ExternalId;
                    if (locationsResult.Succeeded)
                    {
                        var takipkonum = await api.LocationProcessor.GetRecentLocationFeedsAsync(long.Parse(locationId), PaginationParameters.MaxPagesToLoad(5));
                        if (takipkonum.Succeeded)
                        {
                            foreach (var deger in takipkonum.Value.Medias)
                            {
                                if (File.Exists(Application.StartupPath + "\\listeler\\takipedilecek.txt"))
                                {
                                    File.WriteAllText(Application.StartupPath + "\\listeler\\takipedilecek.txt", File.ReadAllText(Application.StartupPath + "\\listeler\\yorumlanacak.txt") + deger.Pk + Environment.NewLine);
                                }
                                else
                                {
                                    File.WriteAllText(Application.StartupPath + "\\listeler\\takipedilecek.txt", deger.Pk + Environment.NewLine);
                                }
                            }
                        }
                        else
                        {
                            Raporyaz(f2 + " konumu kişiler alınırken hata! " + takipkonum.Info.Message);
                        }
                    }
                    else
                    {
                        Raporyaz(f2 + " konumu alınırken hata!" + locationsResult.Info.Message);
                    }

                }
                if (!string.IsNullOrEmpty(txt_TakipEdenler.Text))
                {
                    string[] takipeden = txt_TakipEdenler.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    MessageBox.Show(takipeden[0]);
                    foreach(var deger in takipeden)
                    {
                        Raporyaz(deger + " adlı kişinin takipçileri alınıyor!");
                        var takipedenler = await api.UserProcessor.GetUserFollowersAsync(deger, PaginationParameters.Empty);
                        if (takipedenler.Succeeded)
                        {
                            Raporyaz(deger + " adlı kişinin takipçileri alındı!");
                            foreach(var deger2 in takipedenler.Value)
                            {
                                if (File.Exists(Application.StartupPath + "\\listeler\\takipedilecek.txt"))
                                {
                                    File.WriteAllText(Application.StartupPath + "\\listeler\\takipedilecek.txt", File.ReadAllText(Application.StartupPath + "\\listeler\\yorumlanacak.txt") + deger2.UserName + Environment.NewLine);
                                }
                                else
                                {
                                    File.WriteAllText(Application.StartupPath + "\\listeler\\takipedilecek.txt", deger2.UserName + Environment.NewLine);
                                }
                            }
                        }
                    }
                }
                if (!string.IsNullOrEmpty(txt_TakipEttikleri.Text))
                {

                }
            }
        }
        private void lisans()
        {
             var request = (HttpWebRequest)WebRequest.Create("https://www.lcsgrafik.site/is/lic.php");
             var postData = "d="+DateTime.Now.ToShortDateString();
             postData += "&id=" + getHwid();
             var data = Encoding.ASCII.GetBytes(postData);
             request.Method = "POST";
             request.ContentType = "application/x-www-form-urlencoded";
             request.ContentLength = data.Length;
             using (var stream = request.GetRequestStream())
             {
                  stream.Write(data, 0, data.Length);
             }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            MessageBox.Show("");
        }

        public string getHwid()
        {

            return "";
        }
        private async void btn_Veri_Cikar_ClickAsync(object sender, EventArgs e)
        {
            if(veri_Cikar_konum_al_hash.Checked == true || veri_Cikar_mail_al_hash.Checked == true || veri_Cikar_profil_al_hash.Checked == true || veri_Cikar_Telefon_al_hash.Checked == true)
            {
                if (string.IsNullOrEmpty(txt_veri_Cikar_hashtag.Text))
                {
                    MessageBox.Show("Hashtag listesi iste boş!");
                    return;
                }
            }
            if (veri_Cikar_konum_al_konum.Checked == true || veri_Cikar_mail_al_konum.Checked == true || veri_Cikar_profil_al_konum.Checked == true || veri_Cikar_telefon_al_konum.Checked == true)
            {
                if (string.IsNullOrEmpty(txt_Veri_Cikar_konum.Text))
                {
                    MessageBox.Show("Konum listesi boş!");
                    return;
                }
            }
            if (veri_Cikar_konum_al_sayfa.Checked == true || veri_Cikar_mail_al_sayfa.Checked == true || veri_Cikar_profil_al_sayfa.Checked == true || veri_Cikar_telefon_al_sayfa.Checked == true)
            {
                if (string.IsNullOrEmpty(txt_veri_Cikar_sayfa.Text))
                {
                    MessageBox.Show("Sayfa listesi boş!");
                    return;
                }
            }

            if (veri_Cikar_Telefon_al_hash.Checked)
            {
                string[] liste = txt_veri_Cikar_hashtag.Text.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach(var a in liste)
                {
                    var hashtag = await api.HashtagProcessor.GetRecentHashtagMediaListAsync(a, PaginationParameters.MaxPagesToLoad(20));
                    if (hashtag.Succeeded)
                    {
                        Raporyaz("(Veri Çıkar) " + a + " hashtagının listesi alındı!");
                        var medya = hashtag.Value.Medias;
                        foreach(var b in medya)
                        {
                            var telf = await api.UserProcessor.GetFullUserInfoAsync(b.User.Pk);
                            if (telf.Succeeded)
                            {
                                var c = telf.Value.UserDetail.IsCallToActionEnabled;
                                string no = telf.Value.UserDetail.PublicPhoneCountryCode + telf.Value.UserDetail.PublicPhoneNumber;
                                Raporyaz("(Veri Çıkar) " + no + telf.Value.UserDetail.Username);
                            }
                            else
                                Raporyaz("(Veri Çıkar) " + b.User.UserName + " 'nin profili alınırken hata!");
                        }

                    }
                    else
                        Raporyaz("(Veri Çıkar) Hashtag alınırken hata");
                }
            }


        }
    }
}
 

