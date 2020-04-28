using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleEditDetailParentAssc")]
	public class SysModuleEditDetailParentAssc : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ColumnCaption")]
		public string ColumnCaption { get; set; }
		[CProperty(ColumnPath ="ColumnMetaPath")]
		public string ColumnMetaPath { get; set; }
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
		[CProperty(ColumnPath ="ParentColumnCaption")]
		public string ParentColumnCaption { get; set; }
		[CProperty(ColumnPath ="ParentColumnMetaPath")]
		public string ParentColumnMetaPath { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysModuleEditDetailId")]
		public Guid SysModuleEditDetailId { get; set; }
		[CProperty(ColumnPath ="SysParentAssociationTypeId")]
		public Guid SysParentAssociationTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysModuleEditDetail:SysModuleEditDetailId")]
		public SysModuleEditDetail SysModuleEditDetail { get; set; }
		[CProperty(Navigation ="SysParentAssociationType:SysParentAssociationTypeId")]
		public SysParentAssociationType SysParentAssociationType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
