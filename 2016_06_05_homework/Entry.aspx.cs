using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Testing_WebForms.Models;

namespace Testing_WebForms
{
	public partial class Entry : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			int indexEntry = Convert.ToInt32(Request.QueryString["id"]);

			TextBox tbEntryName = new TextBox();
			TextBox tbEntryDescription = new TextBox();
			TextBox tbEntryColor = new TextBox();
			Label labelName = new Label();
			Label labelDescription = new Label();
			Label labelColor = new Label();
			Label labelDate = new Label();
			EntryList entryList = new EntryList();
			Calendar calendar = new Calendar();

			MyEntry myEntry = entryList.getEntryList()[indexEntry];

			labelName.Text = "Name:";
			labelDescription.Text = "Description:";
			labelColor.Text = "Color:";
			labelDate.Text = "Data create:";
			labelName.Style["margin-right"] = "41px";
			labelDescription.Style["margin-right"] = "5px";
			labelColor.Style["margin-right"] = "43px";

			tbEntryName.Enabled = false;
			tbEntryDescription.Enabled = false;
			tbEntryColor.Enabled = false;
			tbEntryDescription.TextMode = TextBoxMode.MultiLine;

			tbEntryName.Attributes["name"] = myEntry.getListAttribute()[0].Name;
			tbEntryName.Attributes["type"] = myEntry.getListAttribute()[0].Type;
			tbEntryName.Attributes["value"] = myEntry.getListAttribute()[0].Value;

			tbEntryDescription.Attributes["name"] = myEntry.getListAttribute()[1].Name;
			tbEntryDescription.Attributes["type"] = myEntry.getListAttribute()[1].Type;
			tbEntryDescription.Attributes["placeholder"] = myEntry.getListAttribute()[1].Value;

			tbEntryColor.Attributes["name"] = myEntry.getListAttribute()[2].Name;
			tbEntryColor.Attributes["type"] = myEntry.getListAttribute()[2].Type;
			tbEntryColor.Attributes["value"] = myEntry.getListAttribute()[2].Value;
			tbEntryColor.Style["background-color"] = myEntry.getListAttribute()[2].Value;
			tbEntryColor.Style["color"] = "white";

			calendar.SelectedDate = Convert.ToDateTime(myEntry.getListAttribute()[3].Value);

			form1.Controls.Add(labelName);
			form1.Controls.Add(tbEntryName);
			form1.Controls.Add(new LiteralControl("<br/><br/>"));
			form1.Controls.Add(labelDescription);
			form1.Controls.Add(tbEntryDescription);
			form1.Controls.Add(new LiteralControl("<br/><br/>"));
			form1.Controls.Add(labelColor);
			form1.Controls.Add(tbEntryColor);
			form1.Controls.Add(new LiteralControl("<br/><br/>"));
			form1.Controls.Add(labelDate);
			form1.Controls.Add(calendar);
		}
	}
}