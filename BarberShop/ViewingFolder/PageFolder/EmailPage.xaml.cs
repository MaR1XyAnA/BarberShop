using BarberShop.ViewingFolder.DataBaseFolder;
using System;
using System.Linq;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BarberShop.ViewingFolder.PageFolder
{
    public partial class EmailPage : Page
    {
        public EmailPage()
        {
            InitializeComponent();
        }

        private void GetEmail()
        {
            string LoginMail; // Стриноговое значение ЛОГИНА почты для программы 
            string PasswordMail; // Стриноговое значение ПАРОЛЯ почты для программы
            string ToSend; // Стринговое значения текста
            string EmailUsers; // Стринговое значение ЛОГИНА ПОЧТЫ ПОЛЬЗОВАТЕЛЯ
            string TopicLetters; // Стринговое значение ТЕМЫ
            string FromWhom; // Стринговое значение ОТ КОГО
            string smtp; // Стринговое значение SMTP
            string sqlLogin; // Стринговое значение ПОЛУЧЕННОГО ЛОГИНА
            string sqlPassword; // Стринговое значение ПОЛУЧЕННОГО ПАРОЛЯ
            EmailUsers = Convert.ToString(EmailTextBox.Text); // Конвертируем полученную почту

            try
            {
                var MailHelp = AppConnectClass.DataBase.WorkerTable.FirstOrDefault(mail => mail.EmailWorker == EmailUsers); // Ищем пользователей с такой почтой
                if (MailHelp == null) // если нет таких
                {
                    MessageBox.Show("Данного пользователя не существует в базе данных", "Ошибка авторизации"); // Ввыводим сообщение
                }
                else
                {
                    sqlLogin = MailHelp.LoginWorker; // Получаем логин пользователя, который находится под почтой, что он указал
                    sqlPassword = MailHelp.PasswordWorker; // Получаем пароль пользователя, который находится под почтой, что он указал
                    LoginMail = "barbershophelper@autorambler.ru"; // Логин почты для прогграммы
                    PasswordMail = "BarberShop1234567890"; // Пароль почты для прогаммы
                    smtp = "smtp.rambler.ru"; // smtp почты для программы
                    FromWhom = "BarberShopHelper"; // От кого
                    TopicLetters = "Help LOGIN and PASSWORD"; // тема письма
                    ToSend = "<html><body><div style='width: 100%; height: 120%; background: linear-gradient(#1a1a2e, #161a1e); vertical-align: center;'><b style='color: #e94560;'Добрый день. <br>Вы запросили LOGIN и PASSWORD для Входа в программу BarberShop<br> <br>LOGIN = " + sqlLogin + "<br>PASSWORD = " + sqlPassword + "<br><br>Если вы этого не делали, сообщите нашему системному администратору.<br></b></div></body></html>"; // Текст письма (в нашем случае HTML код)
                    try
                    {
                        /// Формируется сообщение и отпровляется на почту
                        SmtpClient mySmtpClient = new SmtpClient(smtp);
                        mySmtpClient.UseDefaultCredentials = false;
                        System.Net.NetworkCredential basicAuthenticationInfo = new System.Net.NetworkCredential(LoginMail, PasswordMail);
                        mySmtpClient.Credentials = basicAuthenticationInfo;
                        MailAddress from = new MailAddress(LoginMail, FromWhom);
                        MailAddress to = new MailAddress(EmailUsers, TopicLetters);
                        MailMessage myMail = new System.Net.Mail.MailMessage(from, to);
                        MailAddress replyTo = new MailAddress(LoginMail);
                        myMail.ReplyToList.Add(replyTo);
                        myMail.Subject = TopicLetters;
                        myMail.Body = ToSend;
                        myMail.IsBodyHtml = true;
                        mySmtpClient.Send(myMail);
                        myMail.SubjectEncoding = System.Text.Encoding.UTF8;
                        myMail.BodyEncoding = System.Text.Encoding.UTF8;
                    }
                    catch (SmtpException ex)
                    {
                        throw new ApplicationException("SmtpException has occured: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("" + EX, "Error EX");
            }
        }

        private void EmailNext_Click(object sender, RoutedEventArgs e)
        {
            GetEmail();
        }

        private void EmailTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                GetEmail();
            }
        }

        private void EmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (EmailTextBox.Text.Length == 0)
            {
                EmailTextTextBlock.Visibility = Visibility.Visible;
            }
            else
            {
                EmailTextTextBlock.Visibility = Visibility.Hidden;
            }
        }
    }
}
