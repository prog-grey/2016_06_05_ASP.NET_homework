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

			Panel panelTask;
			Label labelTask;
			HyperLink linkTask;
			TaskList taskList = new TaskList();
			int id = 0;
			foreach(MyTask task in taskList.getTaskList()) 
			{
				panelTask = new Panel();
				labelTask = new Label();
				linkTask = new HyperLink();

				panelTask.CssClass = "task";
				panelTask.Style.Add("border-color", task.Color);
				linkTask.Text = task.Name;
				linkTask.NavigateUrl = "/Task.aspx?id=" + id.ToString();
				labelTask.Text = "<br/>" + task.Description + "<br/>" + task.DateCreate + "<br/>" + task.Color;

				panelTask.Controls.Add(linkTask);
				panelTask.Controls.Add(labelTask);
				tasks.Controls.Add(panelTask);
				id++;
			}
		}
	}
}