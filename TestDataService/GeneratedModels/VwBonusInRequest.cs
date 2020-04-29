using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwBonusInRequest")]
	public class VwBonusInRequest : BaseEntity
	{
		#region Values
		private decimal _Amount;
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount
		{
			get{return _Amount;}
			set
			{
				_Amount = value;
				OnPropertyChanged();
			}
		}
		private Guid _CalculationRuleId;
		[CProperty(ColumnPath ="CalculationRuleId")]
		public Guid CalculationRuleId
		{
			get{return _CalculationRuleId;}
			set
			{
				_CalculationRuleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _InternalRequestId;
		[CProperty(ColumnPath ="InternalRequestId")]
		public Guid InternalRequestId
		{
			get{return _InternalRequestId;}
			set
			{
				_InternalRequestId = value;
				OnPropertyChanged();
			}
		}
		private Guid _InvoiceId;
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId
		{
			get{return _InvoiceId;}
			set
			{
				_InvoiceId = value;
				OnPropertyChanged();
			}
		}
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
