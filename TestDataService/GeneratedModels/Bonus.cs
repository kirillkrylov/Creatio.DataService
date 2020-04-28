using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Bonus")]
	public class Bonus : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccrualDate")]
		public DateTime AccrualDate { get; set; }
		[CProperty(ColumnPath ="AccrualPeriodId")]
		public Guid AccrualPeriodId { get; set; }
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="BonusCategoryId")]
		public Guid BonusCategoryId { get; set; }
		[CProperty(ColumnPath ="CalculationRuleId")]
		public Guid CalculationRuleId { get; set; }
		[CProperty(ColumnPath ="ChargedManually")]
		public bool ChargedManually { get; set; }
		[CProperty(ColumnPath ="Coefficient")]
		public decimal Coefficient { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InternalRequestId")]
		public Guid InternalRequestId { get; set; }
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId { get; set; }
		[CProperty(ColumnPath ="InvoiceProductId")]
		public Guid InvoiceProductId { get; set; }
		[CProperty(ColumnPath ="IsTarget")]
		public bool IsTarget { get; set; }
		[CProperty(ColumnPath ="ManagerPercentage")]
		public decimal ManagerPercentage { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="PaymentDate")]
		public DateTime PaymentDate { get; set; }
		[CProperty(ColumnPath ="PaymentSchemaRecordId")]
		public Guid PaymentSchemaRecordId { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Quartile")]
		public string Quartile { get; set; }
		[CProperty(ColumnPath ="SaleTypeId")]
		public Guid SaleTypeId { get; set; }
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BonusCategory:BonusCategoryId")]
		public BonusCategory BonusCategory { get; set; }
		[CProperty(Navigation ="BonusState:StateId")]
		public BonusState State { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="InternalRequest:InternalRequestId")]
		public InternalRequest InternalRequest { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="InvoiceProduct:InvoiceProductId")]
		public InvoiceProduct InvoiceProduct { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="PaymentRule:CalculationRuleId")]
		public PaymentRule CalculationRule { get; set; }
		[CProperty(Navigation ="Period:AccrualPeriodId")]
		public Period AccrualPeriod { get; set; }
		[CProperty(Navigation ="SaleType:SaleTypeId")]
		public SaleType SaleType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BonusFile:BonusId")]
		public virtual ICollection<BonusFile> BonusFileByBonus { get; set; }
		[CProperty(Association ="BonusHistory:BonusId")]
		public virtual ICollection<BonusHistory> BonusHistoryByBonus { get; set; }
		[CProperty(Association ="BonusInFolder:BonusId")]
		public virtual ICollection<BonusInFolder> BonusInFolderByBonus { get; set; }
		[CProperty(Association ="BonusInTag:EntityId")]
		public virtual ICollection<BonusInTag> BonusInTagByEntity { get; set; }
		[CProperty(Association ="BonusVisa:BonusId")]
		public virtual ICollection<BonusVisa> BonusVisaByBonus { get; set; }
		#endregion
	}
}
