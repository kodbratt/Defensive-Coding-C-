using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Pedometer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            var result = customer.CalculatePercentOfGoalSteps(this.TextBox1.Text, this.TextBox2.Text);

            Label1.Text = "You reached " + result + "% of your goal!";


        }
    }
}