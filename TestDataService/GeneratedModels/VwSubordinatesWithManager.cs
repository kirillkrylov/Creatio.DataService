using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSubordinatesWithManager")]
	public class VwSubordinatesWithManager : BaseEntity
	{
		#region Values
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactManagerId;
		[CProperty(ColumnPath ="ContactManagerId")]
		public Guid ContactManagerId
		{
			get{return _ContactManagerId;}
			set
			{
				_ContactManagerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _ManagerId;
		[CProperty(ColumnPath ="ManagerId")]
		public Guid ManagerId
		{
			get{return _ManagerId;}
			set
			{
				_ManagerId = value;
				OnPropertyChanged();
			}
		}
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:ContactManagerId")]
		public Contact ContactManager { get; set; }
		[CProperty(Navigation ="Employee:ManagerId")]
		public Employee Manager { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
