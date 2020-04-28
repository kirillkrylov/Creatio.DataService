using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RegisterColumn")]
	public class RegisterColumn : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BPMColumn")]
		public Guid BPMColumn { get; set; }
		[CProperty(ColumnPath ="ConstValue")]
		public string ConstValue { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DefaultValue")]
		public string DefaultValue { get; set; }
		[CProperty(ColumnPath ="DefaultValueTypeId")]
		public Guid DefaultValueTypeId { get; set; }
		[CProperty(ColumnPath ="FillColumnTypeId")]
		public Guid FillColumnTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegrationObjectId")]
		public Guid IntegrationObjectId { get; set; }
		[CProperty(ColumnPath ="IsDefault")]
		public bool IsDefault { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OneCRegesterColumnId")]
		public Guid OneCRegesterColumnId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BpmColumnValueType:DefaultValueTypeId")]
		public BpmColumnValueType DefaultValueType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FillColumnType:FillColumnTypeId")]
		public FillColumnType FillColumnType { get; set; }
		[CProperty(Navigation ="OneCRegisterColumn:OneCRegesterColumnId")]
		public OneCRegisterColumn OneCRegesterColumn { get; set; }
		[CProperty(Navigation ="SyncColumn:IntegrationObjectId")]
		public SyncColumn IntegrationObject { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
