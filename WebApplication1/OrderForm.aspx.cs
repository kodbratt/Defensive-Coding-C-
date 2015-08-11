using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ACM.BL;


namespace WebApplication1
{
    public partial class OrderForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PlaceOrderNow();
        }

        private void PlaceOrderNow()
        {
            var customer = new Customer();
            // Populate instance

            var order = new Order();
            // Populate instance
            var payment = new Payment();
            //populate payment info from UI


        

            var orderController = new OrderController();
            orderController.PlaceOrder(customer, order, payment, allowSplitOrders:false, emailReceipt:true);
        }


    }
}