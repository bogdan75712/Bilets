using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaSSierYaremko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Admin 
            Admin admin = new Admin();
            //admin.createSeller(2, "seller2", "pass", 2);
            //admin.DeleteSeller(2, "seller2", 2);
            //admin.createOrganizator(4,"org1", "pass",3);
            //admin.DeleteOrganizator(4, "org1", 3);
            //admin.SendMailing(); на доработке


            //Organizator
            Organizator org = new Organizator();
            //DateTime date = new DateTime(2022, 6, 25);
            //string dater = date.ToShortDateString();
            //DateTime date1 = new DateTime(2022, 7, 25);
            //string dater1 = date1.ToShortDateString();                      
            //org.CreateEvent(7,"Concert", 1,20,100,"OOO Rock", 3,dater);
            //org.TransferEvent(7,dater1);
            //org.CloseEvent(2, 7);

            //Seller
            Seller sel = new Seller();
            //sel.SellTicket(1,1,1,3,"Alex","Blazer","78945612345",3);
            //sel.ReturnTicket(3,2);
        }
    }
}
