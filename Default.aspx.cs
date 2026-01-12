using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace WebAplikacijaZaDostavuPice
{
    public partial class _Default : Page
    {
        string cs = ConfigurationManager.ConnectionStrings["PizzaDeliveryDBConnectionString"].ConnectionString;

        protected void Page_Load( object sender, EventArgs e )
        {

        }
    }
}