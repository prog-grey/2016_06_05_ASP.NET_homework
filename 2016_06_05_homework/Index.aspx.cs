using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Testing_WebForms.Models;

namespace Testing_WebForms
{
	public partial class Index : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Panel panelEntry;
			Label labelEntry;
			HyperLink linkEntry;
			EntryList entryList = new EntryList();
			int id = 0;
			foreach(MyEntry entry in entryList.getEntryList()) 
			{
				panelEntry = new Panel();
				labelEntry = new Label();
				linkEntry = new HyperLink();

				panelEntry.CssClass = "entry";
				panelEntry.Style.Add("border-color", entry.Color);
				linkEntry.Text = entry.Name;
				linkEntry.NavigateUrl = "/Entry.aspx?id=" + id.ToString();
				labelEntry.Text = "<br/>" + entry.Description + "<br/>" + entry.DateCreate.Date.ToShortDateString() + "<br/>" + entry.Color;
				panelEntry.Controls.Add(linkEntry);
				panelEntry.Controls.Add(labelEntry);
				entrys.Controls.Add(panelEntry);
				id++;
			}

		}
	}
}