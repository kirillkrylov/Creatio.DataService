using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PaymentRule")]
	public class PaymentRule : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccrualMethodId")]
		public Guid AccrualMethodId { get; set; }
		[CProperty(ColumnPath ="AccrualTypeId")]
		public Guid AccrualTypeId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="IsAutomatic")]
		public bool IsAutomatic { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NeedApproval")]
		public bool NeedApproval { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="PayForSchemaId")]
		public Guid PayForSchemaId { get; set; }
		[CProperty(ColumnPath ="PaymentTargetColumnCaption")]
		public string PaymentTargetColumnCaption { get; set; }
		[CProperty(ColumnPath ="PaymentTargetColumnFilter")]
		public string PaymentTargetColumnFilter { get; set; }
		[CProperty(ColumnPath ="PaymentTargetColumnPath")]
		public string PaymentTargetColumnPath { get; set; }
		[CProperty(ColumnPath ="PeriodColumnUId")]
		public Guid PeriodColumnUId { get; set; }
		[CProperty(ColumnPath ="PeriodTypeId")]
		public Guid PeriodTypeId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="QueryCondition")]
		public string QueryCondition { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="ValueColumnUId")]
		public Guid ValueColumnUId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="AccrualMethod:AccrualMethodId")]
		public AccrualMethod AccrualMethod { get; set; }
		[CProperty(Navigation ="AccrualType:AccrualTypeId")]
		public AccrualType AccrualType { get; set; }
		[CProperty(Navigation ="BonusRuleType:TypeId")]
		public BonusRuleType Type { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="PeriodType:PeriodTypeId")]
		public PeriodType PeriodType { get; set; }
		[CProperty(Navigation ="VwSysSchemaInfo:PayForSchemaId")]
		public VwSysSchemaInfo PayForSchema { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Bonus:CalculationRuleId")]
		public virtual ICollection<Bonus> BonusByCalculationRule { get; set; }
		[CProperty(Association ="BonusQueue:PaymentRuleId")]
		public virtual ICollection<BonusQueue> BonusQueueByPaymentRule { get; set; }
		[CProperty(Association ="InvoiceAccrueRole:PaymentRuleId")]
		public virtual ICollection<InvoiceAccrueRole> InvoiceAccrueRoleByPaymentRule { get; set; }
		[CProperty(Association ="PaymentRuleAccrualValue:PaymentRuleId")]
		public virtual ICollection<PaymentRuleAccrualValue> PaymentRuleAccrualValueByPaymentRule { get; set; }
		[CProperty(Association ="PaymentRuleFile:PaymentRuleId")]
		public virtual ICollection<PaymentRuleFile> PaymentRuleFileByPaymentRule { get; set; }
		[CProperty(Association ="PaymentRuleInFolder:PaymentRuleId")]
		public virtual ICollection<PaymentRuleInFolder> PaymentRuleInFolderByPaymentRule { get; set; }
		[CProperty(Association ="PaymentRuleInTag:EntityId")]
		public virtual ICollection<PaymentRuleInTag> PaymentRuleInTagByEntity { get; set; }
		[CProperty(Association ="VwBonusInRequest:CalculationRuleId")]
		public virtual ICollection<VwBonusInRequest> VwBonusInRequestByCalculationRule { get; set; }
		#endregion
	}
}
