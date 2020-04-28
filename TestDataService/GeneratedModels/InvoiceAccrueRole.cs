using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "InvoiceAccrueRole")]
	public class InvoiceAccrueRole : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccrualPercent")]
		public decimal AccrualPercent { get; set; }
		[CProperty(ColumnPath ="BonusAccrueContactRoleId")]
		public Guid BonusAccrueContactRoleId { get; set; }
		[CProperty(ColumnPath ="BonusMargin")]
		public decimal BonusMargin { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ExtraBonus")]
		public bool ExtraBonus { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PaymentRuleId")]
		public Guid PaymentRuleId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SetAmountManually")]
		public bool SetAmountManually { get; set; }
		[CProperty(ColumnPath ="TargetMargin")]
		public decimal TargetMargin { get; set; }
		[CProperty(ColumnPath ="TeamLeaderId")]
		public Guid TeamLeaderId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BonusAccrueContactRole:BonusAccrueContactRoleId")]
		public BonusAccrueContactRole BonusAccrueContactRole { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:TeamLeaderId")]
		public Contact TeamLeader { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="PaymentRule:PaymentRuleId")]
		public PaymentRule PaymentRule { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BonusProduct:InvoiceAccrueRoleId")]
		public virtual ICollection<BonusProduct> BonusProductByInvoiceAccrueRole { get; set; }
		#endregion
	}
}
