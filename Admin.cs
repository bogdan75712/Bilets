using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace KaSSierYaremko
{
    public  class Admin
    {
        static public string Login, Password;
        static public int ID, IDRole;

        
        public void createSeller(int ID, string Login, string Password, int IDRole)
        {
            SqlConnection connect = new SqlConnection(ClassTotal.connectString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES(@ID, @Login, @Password, @IDRole)", connect);
            SqlParameter prm1 = new SqlParameter("@Password", Password);
            SqlParameter prm2 = new SqlParameter("@Login", Login);
            SqlParameter prm3 = new SqlParameter("@ID", ID);
            SqlParameter prm4 = new SqlParameter("@IDRole", IDRole);
            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);
            cmd.Parameters.Add(prm4);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sucsesful");
        }
        //public void createStatictic() // Аналитика
        //{ 
        //
        //}
        public void SendMailing()
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("admin.kascc@gmail.com", "Admin");
            // кому отправляем
            MailAddress to = new MailAddress("visitor@gmail.com");
            // создаем объект сообщения
            MailMessage message = new MailMessage(from, to);
            // тема письма
            message.Subject = "Повторяющиеся письмо";
            // текст письма
            message.Body = "<h2>Новостная рассылка</h2>";
            // письмо представляет код html
            message.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("admin.kascc@gmail.com", "password");
            smtp.EnableSsl = true;
            smtp.Send(message);
        }
        public void createOrganizator(int ID, string Login, string Password, int IDRole)
        {
            SqlConnection connect = new SqlConnection(ClassTotal.connectString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES(@ID, @Login, @Password, @IDRole)", connect);
            SqlParameter prm1 = new SqlParameter("@Password", Password);
            SqlParameter prm2 = new SqlParameter("@Login", Login);
            SqlParameter prm3 = new SqlParameter("@ID", ID);
            SqlParameter prm4 = new SqlParameter("@IDRole", IDRole);
            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);
            cmd.Parameters.Add(prm4);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sucsesful");
        }
        public void DeleteOrganizator(int ID, string Login, int IDRole)
        {
            if (IDRole == 3)
            {
                SqlConnection connect = new SqlConnection(ClassTotal.connectString);
                SqlCommand cmd = new SqlCommand("Delete From Users where Users.Login = @Login and Users.ID = @ID", connect);
                SqlParameter prm1 = new SqlParameter("@Login", Login);
                SqlParameter prm2 = new SqlParameter("@ID", ID);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Sucsesful");
            }
            else
            {
                MessageBox.Show("НЕа");
                return;
            }
            
        }
        public void DeleteSeller(int ID, string Login,int IDRole)
        {
            if (IDRole == 2)
            {
                SqlConnection connect = new SqlConnection(ClassTotal.connectString);
                SqlCommand cmd = new SqlCommand("Delete From Users where Users.Login = @Login and Users.ID = @ID", connect);
                SqlParameter prm1 = new SqlParameter("@Login", Login);
                SqlParameter prm2 = new SqlParameter("@ID", ID);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Sucsesful");
            }
            else
            {
                MessageBox.Show("Неа");
                return;
            }       
        }
    }
}
