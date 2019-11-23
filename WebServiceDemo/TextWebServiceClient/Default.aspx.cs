using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextWebServiceClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            var webService = new TextWebService.TextWebService();
            toLowerLabel.Text = webService.ToLower(TextBox1.Text);
            toUpperLabel.Text = webService.ToUpper(TextBox1.Text);
        }
    }
}