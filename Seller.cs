using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KaSSierYaremko
{
    class Seller
    {
        public int IDEvent, IDTicket, IDTicketType,Price;
        public string Title;
        public void SellTicket(int IDTicketType, int IDPlace, int IDEvent, int IDVisitor, string NameVisitor, string SurnameVisitor, string PhoneVisitor, int IDTicket)
        {
            SqlConnection connect = new SqlConnection(ClassTotal.connectString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Tickets VALUES(@IDTicket, @IDTicketType, @IDPlace, @IDEvent, null) " +
                "Insert into Visitors Values(@IDVisitor, @NameVisitor, @SurnameVisitor, @PhoneVisitor, @IDTicket)", connect);
            SqlParameter prm1 = new SqlParameter("@IDTicket", IDTicket);
            SqlParameter prm2 = new SqlParameter("@IDTicketType", IDTicketType);
            SqlParameter prm3 = new SqlParameter("@IDPlace", IDPlace);
            SqlParameter prm8 = new SqlParameter("@IDEvent", IDEvent);
            SqlParameter prm4 = new SqlParameter("@IDVisitor", IDVisitor);
            SqlParameter prm5 = new SqlParameter("@NameVisitor", NameVisitor);
            SqlParameter prm6 = new SqlParameter("@SurnameVisitor", SurnameVisitor);
            SqlParameter prm7 = new SqlParameter("@PhoneVisitor", PhoneVisitor);           
            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);
            cmd.Parameters.Add(prm3);
            cmd.Parameters.Add(prm4);
            cmd.Parameters.Add(prm5);
            cmd.Parameters.Add(prm6);
            cmd.Parameters.Add(prm7);
            cmd.Parameters.Add(prm8);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sucsesful");
        }
        public void ReturnTicket(int IDTicket, int IDTicketType)
        {
            SqlConnection connect = new SqlConnection(ClassTotal.connectString);
            SqlCommand cmd = new SqlCommand("Update Tickets Set [IDType] = @IDTicketType Where [ID] = @IDTicket", connect);
            SqlParameter prm1 = new SqlParameter("@IDTicketType", IDTicketType);
            SqlParameter prm2 = new SqlParameter("@IDTicket", IDTicket);           
            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);        
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sucsesful");
        }
    }
}
