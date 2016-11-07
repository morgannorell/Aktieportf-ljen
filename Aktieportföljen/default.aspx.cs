using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Aktieportföljen
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateTable();
        }

        public void CreateTable()
        {
            HtmlGenericControl tableElement = new HtmlGenericControl("tr");
            tableElement.InnerHtml = "<td>Nytt värde</td><td>Nytt värde</td><td>Nytt Värde</td><td>Nytt värde</td><td>Nytt värde</td>";

            stocktable.Controls.Add(tableElement);
        }
    }
}