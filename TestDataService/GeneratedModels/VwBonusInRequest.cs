using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwBonusInRequest")]
	public class VwBonusInRequest : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="CalculationRuleId")]
		public Guid CalculationRuleId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InternalRequestId")]
		public Guid InternalRequestId { get; set; }
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="InternalRequest:InternalRequestId")]
		public InternalRequest InternalRequest { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="PaymentRule:CalculationRuleId")]
		public PaymentRule CalculationRule { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
