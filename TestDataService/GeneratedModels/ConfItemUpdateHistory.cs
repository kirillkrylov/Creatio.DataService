using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ConfItemUpdateHistory")]
	public class ConfItemUpdateHistory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DateTimeStamp")]
		public DateTime DateTimeStamp { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Link")]
		public string Link { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="UpdateResultId")]
		public Guid UpdateResultId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="ConfItem:ConfItemId")]
		public ConfItem ConfItem { get; set; }
		[CProperty(Navigation ="ConfItemUpdateResult:UpdateResultId")]
		public ConfItemUpdateResult UpdateResult { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
