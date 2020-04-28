using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysEntitySchemaReference")]
	public class SysEntitySchemaReference : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ColumnCaption")]
		public string ColumnCaption { get; set; }
		[CProperty(ColumnPath ="ColumnName")]
		public string ColumnName { get; set; }
		[CProperty(ColumnPath ="ColumnUId")]
		public Guid ColumnUId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReferenceSchemaId")]
		public Guid ReferenceSchemaId { get; set; }
		[CProperty(ColumnPath ="SysSchemaId")]
		public Guid SysSchemaId { get; set; }
		[CProperty(ColumnPath ="UsageType")]
		public int UsageType { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysSchema:ReferenceSchemaId")]
		public SysSchema ReferenceSchema { get; set; }
		[CProperty(Navigation ="SysSchema:SysSchemaId")]
		public SysSchema SysSchema { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
