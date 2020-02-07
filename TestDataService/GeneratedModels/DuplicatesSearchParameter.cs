using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DuplicatesSearchParameter")]
	public class DuplicatesSearchParameter : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Days")]
		public int Days { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PerformSearchOnSave")]
		public bool PerformSearchOnSave { get; set; }
		[CProperty(ColumnPath ="PerformSheduledSearch")]
		public bool PerformSheduledSearch { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SchemaToSearch")]
		public Guid SchemaToSearch { get; set; }
		[CProperty(ColumnPath ="SchemaToSearchName")]
		public string SchemaToSearchName { get; set; }
		[CProperty(ColumnPath ="SearchByAll")]
		public bool SearchByAll { get; set; }
		[CProperty(ColumnPath ="SearchByModifiedOnly")]
		public bool SearchByModifiedOnly { get; set; }
		[CProperty(ColumnPath ="SearchTime")]
		public DateTime SearchTime { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
