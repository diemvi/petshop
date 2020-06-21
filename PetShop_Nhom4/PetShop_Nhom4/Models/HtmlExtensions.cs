using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PetShop_Nhom4
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString ShowImage(this HtmlHelper html, byte[] image)
        {
            String img = "";
            if (image != null)
            {
                img = String.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(image));
            }
            else
            {
                img = "https://vincom.com.vn/sites/default/files/2016-09/pet%20shop.png";
            }
            return new MvcHtmlString("<img src='" + img + "'/>");
        }
    }
}

