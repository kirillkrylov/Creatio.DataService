using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSubordinatesWithManager")]
	public class VwSubordinatesWithManager : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="ContactManagerId")]
		public Guid ContactManagerId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ManagerId")]
		public Guid ManagerId { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
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
