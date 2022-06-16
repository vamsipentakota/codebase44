using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cricketers
{
    public partial class Cricketers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {



                string[] str = new string[] { "bhoom", "ishan kishan", "rohit", "russell","surya" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".JFIF";




            if (DropDownList1.Items.FindByText("bhoom").Selected == true)
            {
                Label1.Text = "Price: 120000000/-";
            }
            else if (DropDownList1.Items.FindByText("ishan kishan").Selected == true)
            {
                Label1.Text = "Price: 150000000/-";
            }
            else if (DropDownList1.Items.FindByText("rohit").Selected == true)
            {
                Label1.Text = "Price: 160000000/-";
            }
            else if (DropDownList1.Items.FindByText("russell").Selected == true)
            {
                Label1.Text = "Price: 21,70,00,000/-";
            }
            else if (DropDownList1.Items.FindByText("surya").Selected == true)
            {
                Label1.Text = "Price: 20,70,00,000/-";
            }


        }
    }
}