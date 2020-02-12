using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SyncObject")]
	public class SyncObject : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BPMObject")]
		public Guid BPMObject { get; set; }
		[CProperty(ColumnPath ="BPMObjectName")]
		public string BPMObjectName { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ExchangePlan")]
		public string ExchangePlan { get; set; }
		[CProperty(ColumnPath ="ExchangePlanNode")]
		public string ExchangePlanNode { get; set; }
		[CProperty(ColumnPath ="FiltersUnionTypeId")]
		public Guid FiltersUnionTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegrationId")]
		public Guid IntegrationId { get; set; }
		[CProperty(ColumnPath ="IntegrationTypeId")]
		public Guid IntegrationTypeId { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="LastRecords")]
		public bool LastRecords { get; set; }
		[CProperty(ColumnPath ="LastRecordsBeforeToday")]
		public bool LastRecordsBeforeToday { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NeedGenerateSignal")]
		public bool NeedGenerateSignal { get; set; }
		[CProperty(ColumnPath ="ObjectTypeId")]
		public Guid ObjectTypeId { get; set; }
		[CProperty(ColumnPath ="OneCObjectId")]
		public Guid OneCObjectId { get; set; }
		[CProperty(ColumnPath ="OneCRegisterClassId")]
		public Guid OneCRegisterClassId { get; set; }
		[CProperty(ColumnPath ="OneCRegisterFunctionId")]
		public Guid OneCRegisterFunctionId { get; set; }
		[CProperty(ColumnPath ="OneCRegisterId")]
		public Guid OneCRegisterId { get; set; }
		[CProperty(ColumnPath ="OnlyNew")]
		public bool OnlyNew { get; set; }
		[CProperty(ColumnPath ="Order")]
		public int Order { get; set; }
		[CProperty(ColumnPath ="Post")]
		public bool Post { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Rewrite")]
		public bool Rewrite { get; set; }
		[CProperty(ColumnPath ="UseMatchingRules")]
		public bool UseMatchingRules { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FilterUnionType:FiltersUnionTypeId")]
		public FilterUnionType FiltersUnionType { get; set; }
		[CProperty(Navigation ="Integration1C:IntegrationId")]
		public Integration1C Integration { get; set; }
		[CProperty(Navigation ="IntegrationType:IntegrationTypeId")]
		public IntegrationType IntegrationType { get; set; }
		[CProperty(Navigation ="OneCObject:OneCObjectId")]
		public OneCObject OneCObject { get; set; }
		[CProperty(Navigation ="OneCObjectType:ObjectTypeId")]
		public OneCObjectType ObjectType { get; set; }
		[CProperty(Navigation ="OneCRegisterClass:OneCRegisterClassId")]
		public OneCRegisterClass OneCRegisterClass { get; set; }
		[CProperty(Navigation ="OneCRegisterFunction:OneCRegisterFunctionId")]
		public OneCRegisterFunction OneCRegisterFunction { get; set; }
		[CProperty(Navigation ="OneCRegisterObject:OneCRegisterId")]
		public OneCRegisterObject OneCRegister { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Integration1CDuplLog:SyncObjectId")]
		public virtual ICollection<Integration1CDuplLog> Integration1CDuplLogBySyncObject { get; set; }
		[CProperty(Association ="IntegrationFilter:IntegrationObjectId")]
		public virtual ICollection<IntegrationFilter> IntegrationFilterByIntegrationObject { get; set; }
		[CProperty(Association ="MatchingRule:SyncObjectId")]
		public virtual ICollection<MatchingRule> MatchingRuleBySyncObject { get; set; }
		[CProperty(Association ="SyncColumn:IntegrationObjectId")]
		public virtual ICollection<SyncColumn> SyncColumnByIntegrationObject { get; set; }
		[CProperty(Association ="SyncRegisterColumn:IntegrationObjectId")]
		public virtual ICollection<SyncRegisterColumn> SyncRegisterColumnByIntegrationObject { get; set; }
		#endregion
	}
}
