using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Testing_WebForms.Models
{
	public class AttributeField
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public string Value { get; set; }

		public AttributeField(string name, string type, string value)
		{
			this.Name = name;
			this.Type = type;
			this.Value = value;
		}
	}

	public class MyEntry
	{
		public string Name { get; }
		public string Description { get; }
		public DateTime DateCreate { get; }
		public string Color { get; }

		private List<AttributeField> attributeList;

		public MyEntry() { }

		public MyEntry(string name, string description, DateTime dateCreate, string color)
		{
			attributeList = new List<AttributeField>()
			{
				new AttributeField("nameEntry", "text", name),
				new AttributeField("descriptionEntry", "text", description),
				new AttributeField("colorEntry", "text", color),
				new AttributeField("dateCreateEntry", "date", dateCreate.ToShortDateString())
			};
			this.Name = name;
			this.Description = description;
			this.DateCreate = dateCreate;
			this.Color = color;
		}
		public List<AttributeField> getListAttribute() 
		{
			return this.attributeList;
		}
	}

	public class EntryList
	{
		private List<MyEntry> entryList;

		public EntryList()
		{
			entryList = new List<MyEntry>()
			{
				new MyEntry("Name 0", "Description 0", new DateTime(2016, 6, 1), "red" ),
				new MyEntry("Name 1", "Description 1", new DateTime(2016, 6, 5), "green" ),
				new MyEntry("Name 2", "Description 2", new DateTime(2016, 5, 25), "blue" ),
				new MyEntry("Name 3", "Description 3", new DateTime(2016, 6, 7), "grey" ),
				new MyEntry("Name 4", "Description 4", new DateTime(2016, 4, 25), "brown" )
			};
		}
		public void CreateEntry(string name, string description, DateTime dateCreate, string color)
		{
			entryList.Add(new MyEntry(name, description, dateCreate, color));
		}
		public List<MyEntry> getEntryList()
		{
			return this.entryList;
		}

	}

}