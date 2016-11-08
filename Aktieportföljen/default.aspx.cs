using Aktieportföljen.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Aktieportföljen
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateTable(ListData());
        }

        public void CreateTable(List<Stockitem> newStockList)
        {
            foreach (Stockitem s in newStockList)
            {
                HtmlGenericControl tableElement = new HtmlGenericControl("tr");
                tableElement.InnerHtml = "<td>" + s.Stockname + "</td>" +
                    "<td>" + s.Buy + "</td>" +
                    "<td>" + s.Sell + "</td>" +
                    "<td>" + s.Stocklist + "</td>" +
                    "<td>" + s.Stocktype + "</td>";

                stocktable.Controls.Add(tableElement);                
            }
        }
        
        public List<Stockitem> ListData()
        {
            List<Stockitem> stocklist = new List<Stockitem>();

            XDocument xdoc = XDocument.Load(Server.MapPath("xml/aktier.xml"));
            IEnumerable<XElement> result = null;

            if (Request.QueryString["cap"] == "large")
            {
                if (DropDownLst.SelectedItem.Value == "A")
                {
                    result =
                    from minaktie in xdoc.Descendants("aktie")
                    where minaktie.Element("stockname").Attribute("stocklist").Value == "Large"
                    && minaktie.Element("stockname").Attribute("stocktype").Value == "A"
                    select minaktie;
                }
                else if (DropDownLst.SelectedItem.Value == "B")
                {
                    result =
                    from minaktie in xdoc.Descendants("aktie")
                    where minaktie.Element("stockname").Attribute("stocklist").Value == "Large"
                    && minaktie.Element("stockname").Attribute("stocktype").Value == "B"
                    select minaktie;
                }
                else
                {
                    result =
                        from minaktie in xdoc.Descendants("aktie")
                        where minaktie.Element("stockname").Attribute("stocklist").Value == "Large"
                        select minaktie;
                }
            }
            else if (Request.QueryString["cap"] == "mid")
            {
                if (DropDownLst.SelectedItem.Value == "A")
                {
                    result =
                    from minaktie in xdoc.Descendants("aktie")
                    where minaktie.Element("stockname").Attribute("stocklist").Value == "Mid"
                    && minaktie.Element("stockname").Attribute("stocktype").Value == "A"
                    select minaktie;
                }
                else if (DropDownLst.SelectedItem.Value == "B")
                {
                    result =
                    from minaktie in xdoc.Descendants("aktie")
                    where minaktie.Element("stockname").Attribute("stocklist").Value == "Mid"
                    && minaktie.Element("stockname").Attribute("stocktype").Value == "B"
                    select minaktie;
                }
                else
                {
                    result =
                        from minaktie in xdoc.Descendants("aktie")
                        where minaktie.Element("stockname").Attribute("stocklist").Value == "Mid"
                        select minaktie;
                }
            }
            else if (Request.QueryString["cap"] == "small")
            {
                if (DropDownLst.SelectedItem.Value == "A")
                {
                    result =
                    from minaktie in xdoc.Descendants("aktie")
                    where minaktie.Element("stockname").Attribute("stocklist").Value == "Small"
                    && minaktie.Element("stockname").Attribute("stocktype").Value == "A"
                    select minaktie;
                }
                else if (DropDownLst.SelectedItem.Value == "B")
                {
                    result =
                    from minaktie in xdoc.Descendants("aktie")
                    where minaktie.Element("stockname").Attribute("stocklist").Value == "Small"
                    && minaktie.Element("stockname").Attribute("stocktype").Value == "B"
                    select minaktie;
                }
                else
                {
                    result =
                        from minaktie in xdoc.Descendants("aktie")
                        where minaktie.Element("stockname").Attribute("stocklist").Value == "Small"
                        select minaktie;
                }
            }
            else
            {
                if (DropDownLst.SelectedItem.Value == "A")
                {
                    result =
                    from minaktie in xdoc.Descendants("aktie")
                    where minaktie.Element("stockname").Attribute("stocktype").Value == "A"
                    select minaktie;
                }
                else if (DropDownLst.SelectedItem.Value == "B")
                {
                    result =
                    from minaktie in xdoc.Descendants("aktie")
                    where minaktie.Element("stockname").Attribute("stocktype").Value == "B"
                    select minaktie;
                }
                else
                {
                    result =
                        from minaktie in xdoc.Descendants("aktie")                        
                        select minaktie;
                }
            }

            foreach (XElement xe in result)
            {
                Stockitem ak = new Stockitem();
                ak.Stockname = xe.Element("stockname").Value;
                ak.Buy = xe.Element("buy").Value;
                ak.Sell = xe.Element("sell").Value;
                ak.Stocklist = xe.Element("stockname").Attribute("stocklist").Value;
                ak.Stocktype = xe.Element("stockname").Attribute("stocktype").Value;

                stocklist.Add(ak);
            }

            return stocklist;
        }

        protected void DropDownLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            stocktable.Controls.Clear();
            CreateTable(ListData());
        }
    }
}