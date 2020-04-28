using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SyncColumn")]
	public class SyncColumn : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BPMColumn")]
		public Guid BPMColumn { get; set; }
		[CProperty(ColumnPath ="BPMColumnName")]
		public string BPMColumnName { get; set; }
		[CProperty(ColumnPath ="BPMDesignDetailName")]
		public string BPMDesignDetailName { get; set; }
		[CProperty(ColumnPath ="BPMDetailName")]
		public string BPMDetailName { get; set; }
		[CProperty(ColumnPath ="BPMObject")]
		public Guid BPMObject { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="ComparisonSignId")]
		public Guid ComparisonSignId { get; set; }
		[CProperty(ColumnPath ="ComparisonTypeId")]
		public Guid ComparisonTypeId { get; set; }
		[CProperty(ColumnPath ="ConstValue")]
		public string ConstValue { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DefaultValue")]
		public string DefaultValue { get; set; }
		[CProperty(ColumnPath ="DesignLyncColumnName")]
		public string DesignLyncColumnName { get; set; }
		[CProperty(ColumnPath ="FillColumnTypeId")]
		public Guid FillColumnTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IdentityColumnId")]
		public Guid IdentityColumnId { get; set; }
		[CProperty(ColumnPath ="IntegrationObjectId")]
		public Guid IntegrationObjectId { get; set; }
		[CProperty(ColumnPath ="IsCleanTable")]
		public bool IsCleanTable { get; set; }
		[CProperty(ColumnPath ="IsDefault")]
		public bool IsDefault { get; set; }
		[CProperty(ColumnPath ="LastRecords")]
		public bool LastRecords { get; set; }
		[CProperty(ColumnPath ="LastRecordsBeforeToday")]
		public bool LastRecordsBeforeToday { get; set; }
		[CProperty(ColumnPath ="LyncColumnName")]
		public string LyncColumnName { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NeedGenerateSignal")]
		public bool NeedGenerateSignal { get; set; }
		[CProperty(ColumnPath ="OneCDetailId")]
		public Guid OneCDetailId { get; set; }
		[CProperty(ColumnPath ="OneCObjectColumnId")]
		public Guid OneCObjectColumnId { get; set; }
		[CProperty(ColumnPath ="OneCRegisterColumnId")]
		public Guid OneCRegisterColumnId { get; set; }
		[CProperty(ColumnPath ="OneCRegisterId")]
		public Guid OneCRegisterId { get; set; }
		[CProperty(ColumnPath ="OnlyNew")]
		public bool OnlyNew { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegesterLinkColumnFilterId")]
		public Guid RegesterLinkColumnFilterId { get; set; }
		[CProperty(ColumnPath ="RegesterLinkColumnId")]
		public Guid RegesterLinkColumnId { get; set; }
		[CProperty(ColumnPath ="RegisterClassId")]
		public Guid RegisterClassId { get; set; }
		[CProperty(ColumnPath ="StringView")]
		public bool StringView { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="Value")]
		public string Value { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BpmColumnValueType:ComparisonTypeId")]
		public BpmColumnValueType ComparisonType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FillColumnType:FillColumnTypeId")]
		public FillColumnType FillColumnType { get; set; }
		[CProperty(Navigation ="IntegrationComparisonType:ComparisonSignId")]
		public IntegrationComparisonType ComparisonSign { get; set; }
		[CProperty(Navigation ="OneCObjectColumn:OneCObjectColumnId")]
		public OneCObjectColumn OneCObjectColumn { get; set; }
		[CProperty(Navigation ="OneCObjectDetail:OneCDetailId")]
		public OneCObjectDetail OneCDetail { get; set; }
		[CProperty(Navigation ="OneCObjectDetailColumn:IdentityColumnId")]
		public OneCObjectDetailColumn IdentityColumn { get; set; }
		[CProperty(Navigation ="OneCRegister:OneCRegisterId")]
		public OneCRegister OneCRegister { get; set; }
		[CProperty(Navigation ="OneCRegisterClass:RegisterClassId")]
		public OneCRegisterClass RegisterClass { get; set; }
		[CProperty(Navigation ="OneCRegisterColumn:RegesterLinkColumnId")]
		public OneCRegisterColumn RegesterLinkColumn { get; set; }
		[CProperty(Navigation ="OneCRegisterColumn:RegesterLinkColumnFilterId")]
		public OneCRegisterColumn RegesterLinkColumnFilter { get; set; }
		[CProperty(Navigation ="OneCRegisterObjColumn:OneCRegisterColumnId")]
		public OneCRegisterObjColumn OneCRegisterColumn { get; set; }
		[CProperty(Navigation ="SyncColumnType:TypeId")]
		public SyncColumnType Type { get; set; }
		[CProperty(Navigation ="SyncObject:IntegrationObjectId")]
		public SyncObject IntegrationObject { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AgregateObject:SyncColumnId")]
		public virtual ICollection<AgregateObject> AgregateObjectBySyncColumn { get; set; }
		[CProperty(Association ="MatchingRuleColumn:SyncColumnId")]
		public virtual ICollection<MatchingRuleColumn> MatchingRuleColumnBySyncColumn { get; set; }
		[CProperty(Association ="RegisterColumn:IntegrationObjectId")]
		public virtual ICollection<RegisterColumn> RegisterColumnByIntegrationObject { get; set; }
		[CProperty(Association ="TableIntegrationFilter:IntegrationObjectId")]
		public virtual ICollection<TableIntegrationFilter> TableIntegrationFilterByIntegrationObject { get; set; }
		[CProperty(Association ="TableSyncColumn:IntegrationObjectId")]
		public virtual ICollection<TableSyncColumn> TableSyncColumnByIntegrationObject { get; set; }
		[CProperty(Association ="VwSyncColumn:SyncColumnId")]
		public virtual ICollection<VwSyncColumn> VwSyncColumnBySyncColumn { get; set; }
		#endregion
	}
}
