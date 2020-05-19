using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.ServiceReferenceA;
using WebApp.ServiceReferenceB;
using WebApp.ServiceReferenceWeb;

namespace WebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CallWeb_Click(object sender, EventArgs e)
        {
            ServiceWebClient client = null;
            try
            {
                client = new ServiceWebClient();
                LiteralWeb.Text = "Web:" + client.GetSomething();
            }
            finally
            {
                client.Close();
            }
        }

        protected void CallWebA_Click(object sender, EventArgs e)
        {
            ServiceWebClient client = null;
            try
            {
                client = new ServiceWebClient();
                LiteralWeb.Text = "Web A:" + client.PassSomethingToA();
            }
            finally
            {
                client.Close();
            }
        }

        protected void CallWebAB_Click(object sender, EventArgs e)
        {
            ServiceWebClient client = null;
            try
            {
                client = new ServiceWebClient();
                LiteralWeb.Text = "Web A -> B:" + client.PassSomethingToAToB();
            }
            finally
            {
                client.Close();
            }
        }

        protected void CallWebB_Click(object sender, EventArgs e)
        {
            ServiceWebClient client = null;
            try
            {
                client = new ServiceWebClient();
                LiteralWeb.Text = "Web B:" + client.PassSomethingToB();
            }
            finally
            {
                client.Close();
            }
        }

        protected void CallWebBA_Click(object sender, EventArgs e)
        {
            ServiceWebClient client = null;
            try
            {
                client = new ServiceWebClient();
                LiteralWeb.Text = "Web B -> A:" + client.PassSomethingToBToA();
            }
            finally
            {
                client.Close();
            }
        }

        protected void CallA_Click(object sender, EventArgs e)
        {
            ServiceAClient client = null;
            try
            {
                client = new ServiceAClient();
                LiteralWeb.Text = "A:" + client.GetSomething();
            }
            finally
            {
                client.Close();
            }
        }

        protected void CallAB_Click(object sender, EventArgs e)
        {
            ServiceAClient client = null;
            try
            {
                client = new ServiceAClient();
                LiteralWeb.Text = "A -> B:" + client.PassSomethingToB();
            }
            finally
            {
                client.Close();
            }
        }

        protected void CallB_Click(object sender, EventArgs e)
        {
            ServiceBClient client = null;
            try
            {
                client = new ServiceBClient();
                LiteralWeb.Text = "B:" + client.GetSomething();
            }
            finally
            {
                client.Close();
            }
        }

        protected void CallBA_Click(object sender, EventArgs e)
        {
            ServiceBClient client = null;
            try
            {
                client = new ServiceBClient();
                LiteralWeb.Text = "B -> A:" + client.PassSomethingToA();
            }
            finally
            {
                client.Close();
            }
        }
    }
}