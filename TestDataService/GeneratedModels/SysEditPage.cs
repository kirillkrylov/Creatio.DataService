using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysEditPage")]
	public class SysEditPage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysEntitySchemaId")]
		public Guid SysEntitySchemaId { get; set; }
		[CProperty(ColumnPath ="SysGridPageId")]
		public Guid SysGridPageId { get; set; }
		[CProperty(ColumnPath ="SysPageSchemaId")]
		public Guid SysPageSchemaId { get; set; }
		[CProperty(ColumnPath ="TypeColumnValue")]
		public Guid TypeColumnValue { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysGridPage:SysGridPageId")]
		public SysGridPage SysGridPage { get; set; }
		[CProperty(Navigation ="SysSchema:SysPageSchemaId")]
		public SysSchema SysPageSchema { get; set; }
		[CProperty(Navigation ="SysSchema:SysEntitySchemaId")]
		public SysSchema SysEntitySchema { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
