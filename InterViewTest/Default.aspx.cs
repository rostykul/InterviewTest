﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterViewTest
{
    public partial class Default : System.Web.UI.Page
    {
        private static string LabelText = "Sample Text";

        public static void setLabelText(string txt)
        {
            LabelText = txt;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = LabelText;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Popup.aspx");
        }
    }
}