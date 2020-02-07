using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwProjectHierarchy")]
	public class VwProjectHierarchy : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="BaseProjectId")]
		public Guid BaseProjectId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsFirst")]
		public bool IsFirst { get; set; }
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Project:ProjectId")]
		public Project Project { get; set; }
		[CProperty(Navigation ="Project:BaseProjectId")]
		public Project BaseProject { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
