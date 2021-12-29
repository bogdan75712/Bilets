using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KaSSierYaremko
{
    public class Organizator
    {
        public int IDEvent, IDStatus, SoldTickets, VolumeTickets,IDUser;
        public string Title, NameEvent, Organization;
        public DateTime DateEvent;

        public void CloseEvent(int IDStatus, int IDEvent)
        {
            SqlConnection connect = new SqlConnection(ClassTotal.connectString);
            SqlCommand cmd = new SqlCommand("Update Events Set [IDStatus] = @IDStatus Where [ID] = @IDEvent", connect);
            SqlParameter prm1 = new SqlParameter("@IDStatus", IDStatus);
            SqlParameter prm2 = new SqlParameter("@IDEvent", IDEvent);            
            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sucsesful");
        }
        public void CreateEvent(int IDEvent, string NameEvent, int IDStatus, int SoldTickets, int VolumeTickets, string Organization, int IDUser, string DateEvent)
        {
            SqlConnection connect = new SqlConnection(ClassTotal.connectString);
            SqlCommand cmd = new SqlCommand("Insert into Events Values (@IDEvent, @NameEvent, @IDStatus, @SoldTickets, @VolumeTickets, @Organization, @IDUser, @DateEvent)", connect);
            SqlParameter prm1 = new SqlParameter("@IDEvent", IDEvent);           
            SqlParameter prm3 = new SqlParameter("@IDStatus", IDStatus);
            SqlParameter prm4 = new SqlParameter("@SoldTickets", SoldTickets);
            SqlParameter prm5 = new SqlParameter("@VolumeTickets", VolumeTickets);
            SqlParameter prm6 = new SqlParameter("@Organization", Organization);
            SqlParameter prm7 = new SqlParameter("@IDUser", IDUser);
            SqlParameter prm8 = new SqlParameter("@DateEvent", DateEvent);
            SqlParameter prm9 = new SqlParameter("@NameEvent", NameEvent);
            cmd.Parameters.Add(prm1);            
            cmd.Parameters.Add(prm3);
            cmd.Parameters.Add(prm4);
            cmd.Parameters.Add(prm5);
            cmd.Parameters.Add(prm6);
            cmd.Parameters.Add(prm7);
            cmd.Parameters.Add(prm8);
            cmd.Parameters.Add(prm9);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sucsesful");
        }
        public void TransferEvent(int IDEvent, string DateEvent)
        {
            SqlConnection connect = new SqlConnection(ClassTotal.connectString);
            SqlCommand cmd = new SqlCommand("Update Events Set [DateEvent] = @DateEvent Where [ID] = @IDEvent", connect);
            SqlParameter prm1 = new SqlParameter("@IDEvent", IDEvent);
            SqlParameter prm2 = new SqlParameter("@DateEvent", DateEvent);
            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sucsesful");
        }
    }
}
