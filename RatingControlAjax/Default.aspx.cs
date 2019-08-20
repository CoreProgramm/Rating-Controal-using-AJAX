using AjaxControlToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RatingControlAjax
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void OnRatingChanged(object sender, RatingEventArgs e)
        {
            hdn_Rating.Value = e.Value;
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            lbl_Value.Text ="You Selected rating as "+ hdn_Rating.Value.ToString() + "" ;
        }
    }
}