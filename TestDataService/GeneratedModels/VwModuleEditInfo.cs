using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwModuleEditInfo")]
	public class VwModuleEditInfo : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActionKindCaptionLczId")]
		public Guid ActionKindCaptionLczId { get; set; }
		[CProperty(ColumnPath ="CultureId")]
		public Guid CultureId { get; set; }
		[CProperty(ColumnPath ="DefaultPageCaption")]
		public string DefaultPageCaption { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ModuleCode")]
		public string ModuleCode { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="PageCaptionLcz")]
		public string PageCaptionLcz { get; set; }
		[CProperty(ColumnPath ="PageCaptionLczId")]
		public Guid PageCaptionLczId { get; set; }
		[CProperty(ColumnPath ="PageCaptionLczOld")]
		public string PageCaptionLczOld { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="RecordId")]
		public Guid RecordId { get; set; }
		[CProperty(ColumnPath ="TypeColumnValue")]
		public Guid TypeColumnValue { get; set; }
		[CProperty(ColumnPath ="WorkspaceId")]
		public Guid WorkspaceId { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
