using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;


namespace Check_mysql_database_exist_or_not_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string folder;
            //string logindication;
            //String clogindication;
            string connStr = "server=localhost;user=root;database=world;port=3306;password=123456;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                MessageBox.Show("Connecting to MySQL...");
                
                conn.Open();
                MessageBox.Show("ok");
                // Perform database operations
            }
            catch (Exception ex)
            {
                if (ex.Message.ToString().Equals("Unable to connect to any of the specified MySQL hosts."))
                {
                    if (ex.ToString().Equals(@"MySql.Data.MySqlClient.MySqlException (0x80004005): Unable to connect to any of the specified MySQL hosts. ---> System.Net.Sockets.SocketException (0x80004005): No such host is known
   at System.Net.Dns.GetAddrInfo(String name)
   at System.Net.Dns.InternalGetHostByName(String hostName, Boolean includeIPv6)
   at System.Net.Dns.GetHostEntry(String hostNameOrAddress)
   at MySql.Data.Common.MyNetworkStream.CreateStream(MySqlConnectionStringBuilder settings, Boolean unix)
   at MySql.Data.Common.StreamCreator.GetStream(MySqlConnectionStringBuilder settings)
   at MySql.Data.MySqlClient.NativeDriver.Open()
   at MySql.Data.MySqlClient.NativeDriver.Open()
   at MySql.Data.MySqlClient.Driver.Open()
   at MySql.Data.MySqlClient.Driver.Create(MySqlConnectionStringBuilder settings)
   at MySql.Data.MySqlClient.MySqlPool.GetPooledConnection()
   at MySql.Data.MySqlClient.MySqlPool.TryToGetDriver()
   at MySql.Data.MySqlClient.MySqlPool.GetConnection()
   at MySql.Data.MySqlClient.MySqlConnection.Open()
   at Check_mysql_database_exist_or_not_form.Form1.button1_Click(Object sender, EventArgs e) in D:\Projects\Development_Laboratory\Visual_Studio_2010\Check_mysql_database_exist_or_not\Check_mysql_database_exist_or_not_form\Form1.cs:line 34"))
                    {
                        MessageBox.Show("unable to find the specified server on the network");
                    }
                    if (ex.ToString().Equals(@"MySql.Data.MySqlClient.MySqlException (0x80004005): Unable to connect to any of the specified MySQL hosts.
   at MySql.Data.MySqlClient.NativeDriver.Open()
   at MySql.Data.MySqlClient.Driver.Open()
   at MySql.Data.MySqlClient.Driver.Create(MySqlConnectionStringBuilder settings)
   at MySql.Data.MySqlClient.MySqlPool.GetPooledConnection()
   at MySql.Data.MySqlClient.MySqlPool.TryToGetDriver()
   at MySql.Data.MySqlClient.MySqlPool.GetConnection()
   at MySql.Data.MySqlClient.MySqlConnection.Open()
   at Check_mysql_database_exist_or_not_form.Form1.button1_Click(Object sender, EventArgs e) in D:\Projects\Development_Laboratory\Visual_Studio_2010\Check_mysql_database_exist_or_not\Check_mysql_database_exist_or_not_form\Form1.cs:line 34"))
                    {
                        MessageBox.Show("Mysql is not running on the server with correct configuration");
                    }

                    //MessageBox.Show(ex.Data.ToString());
                    //MessageBox.Show(ex.Message.ToString());
                    //MessageBox.Show(ex.HelpLink.ToString());
                    //MessageBox.Show(ex.InnerException.ToString());
                    //MessageBox.Show(ex.Source.ToString());
                    //MessageBox.Show(ex.StackTrace.ToString());
                    //MessageBox.Show(ex.TargetSite.ToString());
                    //MessageBox.Show(ex.ToString());
                    //folder = @"D:\Research_Files\Temporary_location";
                    //System.IO.Directory.CreateDirectory(folder);
                    // Create  file names for the files you want to create.  
                    //logindication = "temp.txt";
                    //clogindication = System.IO.Path.Combine(folder, logindication);

                    //System.IO.File.WriteAllText(clogindication, ex.ToString());


                    //MessageBox.Show("Incorrect mysql configuration");
                }

                if (ex.Message.ToString().Equals("Authentication to host 'localhost' for user 'root' using method 'mysql_native_password' failed with message: Access denied for user 'root'@'localhost' (using password: YES)"))
                {
                    MessageBox.Show("the password for the root account is incorrect");
                }

                if (ex.Message.ToString().Equals("Authentication to host 'localhost' for user 'root' using method 'mysql_native_password' failed with message: Unknown database 'world'"))
                {
                    MessageBox.Show("Database 'world' not found,please import database 'world' to the mysql server");
                }
                
                
                //if (ex.Message.ToString().Equals("Authentication to host 'localhost' for user 'root' using method 'mysql_native_password' failed with message: Access denied for user 'root'@'localhost' (using password: YES)"))
                //{
                  //  MessageBox.Show("the password for the root account is incorrect");
                //}
                //MessageBox.Show(ex.ToString());
                //MessageBox.Show(ex.Data.ToString());
                //MessageBox.Show(ex.Message.ToString());
                //MessageBox.Show(ex.HelpLink.ToString());
                //MessageBox.Show(ex.InnerException.ToString());
                //MessageBox.Show(ex.Source.ToString());
                //MessageBox.Show(ex.StackTrace.ToString());
                //MessageBox.Show(ex.TargetSite.ToString());
                //folder = @"D:\Research_Files\Temporary_location";
                //System.IO.Directory.CreateDirectory(folder);
                // Create  file names for the files you want to create.  
                //logindication = "temp.txt";
                //clogindication = System.IO.Path.Combine(folder, logindication);
                
                //System.IO.File.WriteAllText(clogindication, ex.Message.ToString());









            }
            conn.Close();
            
        }
    }
}
