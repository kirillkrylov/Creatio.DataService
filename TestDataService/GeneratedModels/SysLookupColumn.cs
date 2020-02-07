using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysLookupColumn")]
	public class SysLookupColumn : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="MetaCaption")]
		public string MetaCaption { get; set; }
		[CProperty(ColumnPath ="MetaPath")]
		public string MetaPath { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysLookupId")]
		public Guid SysLookupId { get; set; }
		[CProperty(ColumnPath ="SysOrderDirectionId")]
		public Guid SysOrderDirectionId { get; set; }
		[CProperty(ColumnPath ="Width")]
		public int Width { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysLookup:SysLookupId")]
		public SysLookup SysLookup { get; set; }
		[CProperty(Navigation ="SysOrderDirection:SysOrderDirectionId")]
		public SysOrderDirection SysOrderDirection { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
