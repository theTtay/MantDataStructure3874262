using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MantDataStructure
{
	public partial class Use : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			
        }

		protected void btnLookUp_Click(object sender, EventArgs e)
		{
			//Declare a new array
			String[] strCategoryArray = new String[5];
			//Get the array from the session variable
			strCategoryArray = Session["strCategoryArray"] as String[];
			//Use the array as normal
			Int32 i32Index = Convert.ToInt32(txtIndex.Text);
			txtCategory.Text = strCategoryArray[i32Index];

		}
	}
}