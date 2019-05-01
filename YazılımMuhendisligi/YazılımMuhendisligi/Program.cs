using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımMuhendisligi
{
    static class Program
    {
        public static uygarEntities ctx = new uygarEntities();
        public static MySession ses = new MySession();
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /* var ctx = new uygarEntities();

             var x = new transportationservice()
             {
                 Bill_id = 2,
                 Campaign_campaignID = 5,
                 transportationID = 5
             };
             var y = new transportationservice()
             {
                 Bill_id = 1,
                 Campaign_campaignID = 2,
                 transportationID = 3
             };
             ctx.transportationservice.Add(y);
             ctx.transportationservice.Add(x);
             ctx.SaveChanges();
             var a = (from p in ctx.transportationservice where p.Bill_id == 2 select p).SingleOrDefault();
             MessageBox.Show(a.Campaign_campaignID.ToString());
             ctx.transportationservice.Remove(a);
             ctx.SaveChanges();*/
            if (ses.getInstance())
            {
                MessageBox.Show("İstemci zaten açık!");
                Environment.Exit(1);
            }
            Application.Run(new LoginForm());
       
        }
    }
}
