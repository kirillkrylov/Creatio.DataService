using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwCommandAction")]
	public class VwCommandAction : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AdditionalParamValue")]
		public string AdditionalParamValue { get; set; }
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="ColumnCaption")]
		public string ColumnCaption { get; set; }
		[CProperty(ColumnPath ="CommandActionId")]
		public Guid CommandActionId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsShared")]
		public bool IsShared { get; set; }
		[CProperty(ColumnPath ="MainParamCation")]
		public string MainParamCation { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OrderColumn")]
		public int OrderColumn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SubjectColumnUId")]
		public Guid SubjectColumnUId { get; set; }
		[CProperty(ColumnPath ="SubjectSchemaUId")]
		public Guid SubjectSchemaUId { get; set; }
		[CProperty(ColumnPath ="TypeColumnCode")]
		public string TypeColumnCode { get; set; }
		[CProperty(ColumnPath ="TypeColumnUId")]
		public Guid TypeColumnUId { get; set; }
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
