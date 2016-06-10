using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Testing_WebForms.Models
{
	public class MyTask
	{
		public string Name { get; }
		public string Description { get; }
		public DateTime DateCreate { get; }
		public string Color { get; }


		public MyTask() { }

		public MyTask(string name, string description, DateTime dateCreate, string color)
		{
			this.Name = name;
			this.Description = description;
			this.DateCreate = dateCreate;
			this.Color = color;
		}
	}

		public class TaskList
		{
			private List<MyTask> taskList;

			public TaskList()
			{
				string[] colorArr = { "red", "green", "blue", "grey", "brown" };
				Random randDay = new Random();
				taskList = new List<MyTask>();
				for (int i = 0; i < colorArr.Length; i++) 
				{
					taskList.Add(new MyTask("Task name " + i.ToString(), "desctiption " + i.ToString(), DateTime.Now.AddDays(Convert.ToDouble(randDay.Next(0, 5))), colorArr[i]));
				}
			}

			public void CreateTask(string name, string description, DateTime dateCreate, string color)
			{
				taskList.Add( new MyTask(name, description, dateCreate, color) );
			}
			public List<MyTask> getTaskList()
			{
				return this.taskList;
			}

		}

}