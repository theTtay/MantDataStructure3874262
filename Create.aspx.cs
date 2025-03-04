﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MantDataStructure
{
	public partial class CreateCategoryArray : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			
		}

		protected void btnCreateArray_Click(object sender, EventArgs e)
		{
			//Declare and load the array
			String[] strCategoryArray = new String[5];
			strCategoryArray[0] = "Footwear - Men's";
			strCategoryArray[1] = "Clothing - Men's";
			strCategoryArray[2] = "Raquets";
			strCategoryArray[3] = "Footwear - Women's";
			strCategoryArray[4] = "Clothing - Women's";
			//Save the array in a session variable to future use
			Session["strCategoryArray"] = strCategoryArray;
			//Go to the next page
			Response.Redirect("Use.aspx");
		}
	}
}