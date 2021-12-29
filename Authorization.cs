using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace KaSSierYaremko
{
    public class Authorization
    {       
        static public string Login, Password;
        static public int ID, IDRole;

        public Authorization(string Login, string Password)
        {                                  
            SqlConnection connect = new SqlConnection(ClassTotal.connectString);
            try
            {
                connect.Open();
                MessageBox.Show("V SISTEME");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 17: MessageBox.Show("Wrong server name"); break;
                    case 4060: MessageBox.Show("Wrong Database name"); break;
                    case 18456: MessageBox.Show("Wrong user name or password"); break;
                }
                MessageBox.Show(ex.Message + "Exception level " + ex.Class); return;
            }
            SqlCommand command = connect.CreateCommand();
            string commandText;
            commandText = "SELECT * FROM[Users] WHERE [Login]=@Log AND [Pass]=@Pass";

            string log = "admin1";
            string pass = "admin1";


            SqlParameter paramPass = new SqlParameter("@Pasword", pass);
            command.Parameters.Add(paramPass);
            SqlParameter paramLog = new SqlParameter("@Log", log);
            command.Parameters.Add(paramLog);
            command.CommandText = commandText;
            SqlDataReader reader = command.ExecuteReader();


            int idUser = 0;
            if (reader.HasRows)
            {
                //this.Close();
                reader.Read();
                idUser = (int)reader["ID_user"];
                switch ((int)reader["id_role"])
                {
                    case 1:
                        MessageBox.Show("Вы вошли как админ");
                        //adminPanel admin = new adminPanel();
                        //admin.Show();
                        break;
                    case 2:
                        MessageBox.Show("Вы вошли как продавец");
                        //sellerPanelMenu seller = new sellerPanelMenu(idUser);
                        //agent.Show();
                        break;
                    case 3:
                        MessageBox.Show("Вы вошли как организатор");
                        //organizatorPanel direcor = new organizatorPanel();
                        //direcor.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Check your password or username!");
            }

            reader.Close();          
        }
    }
}
