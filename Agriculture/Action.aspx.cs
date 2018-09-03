using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.IO;

namespace Agriculture
{
    public partial class Action : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Stop();
            UpdateStatus();
        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            Start();
            UpdateStatus();
        }

        protected void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
            UpdateStatus();
        }

        protected void UpdateStatus()
        {
            StreamReader reader = new StreamReader("D:\\comm.txt");
            if (reader.ReadLine() == "stop")
            {
                lblMessage.Text = "Status: Offline";
            }
            else
            {
                lblMessage.Text = "Status: Online";
            }
            reader.Close();
        }
        
        protected void Stop()
        {
            StreamWriter writer = new StreamWriter("D:\\comm.txt");
            writer.WriteLine("stop");
            writer.Close();
        }

        protected void Start()
        {
            StreamWriter writer = new StreamWriter("D:\\comm.txt");
            writer.WriteLine("start");
            writer.Close();
        }

    }
}