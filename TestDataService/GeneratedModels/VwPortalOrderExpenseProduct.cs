using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwPortalOrderExpenseProduct")]
	public class VwPortalOrderExpenseProduct : BaseEntity
	{
		#region Values
		private decimal _AmountWithVAT;
		[CProperty(ColumnPath ="AmountWithVAT")]
		public decimal AmountWithVAT
		{
			get{return _AmountWithVAT;}
			set
			{
				_AmountWithVAT = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private decimal _DiscountAmountInPaymentCurrency;
		[CProperty(ColumnPath ="DiscountAmountInPaymentCurrency")]
		public decimal DiscountAmountInPaymentCurrency
		{
			get{return _DiscountAmountInPaymentCurrency;}
			set
			{
				_DiscountAmountInPaymentCurrency = value;
				OnPropertyChanged();
			}
		}
		private decimal _DiscountPercent;
		[CProperty(ColumnPath ="DiscountPercent")]
		public decimal DiscountPercent
		{
			get{return _DiscountPercent;}
			set
			{
				_DiscountPercent = value;
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
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private decimal _PartnerCompensationAmount;
		[CProperty(ColumnPath ="PartnerCompensationAmount")]
		public decimal PartnerCompensationAmount
		{
			get{return _PartnerCompensationAmount;}
			set
			{
				_PartnerCompensationAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PartnerCompensationPercent;
		[CProperty(ColumnPath ="PartnerCompensationPercent")]
		public decimal PartnerCompensationPercent
		{
			get{return _PartnerCompensationPercent;}
			set
			{
				_PartnerCompensationPercent = value;
				OnPropertyChanged();
			}
		}
		private decimal _PartnerMargin;
		[CProperty(ColumnPath ="PartnerMargin")]
		public decimal PartnerMargin
		{
			get{return _PartnerMargin;}
			set
			{
				_PartnerMargin = value;
				OnPropertyChanged();
			}
		}
		private decimal _PartnerMarginInPaymentCurrency;
		[CProperty(ColumnPath ="PartnerMarginInPaymentCurrency")]
		public decimal PartnerMarginInPaymentCurrency
		{
			get{return _PartnerMarginInPaymentCurrency;}
			set
			{
				_PartnerMarginInPaymentCurrency = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProductId;
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId
		{
			get{return _ProductId;}
			set
			{
				_ProductId = value;
				OnPropertyChanged();
			}
		}
		private decimal _ProductPriceInInvoiceCurrency;
		[CProperty(ColumnPath ="ProductPriceInInvoiceCurrency")]
		public decimal ProductPriceInInvoiceCurrency
		{
			get{return _ProductPriceInInvoiceCurrency;}
			set
			{
				_ProductPriceInInvoiceCurrency = value;
				OnPropertyChanged();
			}
		}
		private int _Quantity;
		[CProperty(ColumnPath ="Quantity")]
		public int Quantity
		{
			get{return _Quantity;}
			set
			{
				_Quantity = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupportSoldForId;
		[CProperty(ColumnPath ="SupportSoldForId")]
		public Guid SupportSoldForId
		{
			get{return _SupportSoldForId;}
			set
			{
				_SupportSoldForId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TsOrderExpenseId;
		[CProperty(ColumnPath ="TsOrderExpenseId")]
		public Guid TsOrderExpenseId
		{
			get{return _TsOrderExpenseId;}
			set
			{
				_TsOrderExpenseId = value;
				OnPropertyChanged();
			}
		}
		private decimal _VATAmount;
		[CProperty(ColumnPath ="VATAmount")]
		public decimal VATAmount
		{
			get{return _VATAmount;}
			set
			{
				_VATAmount = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Product:SupportSoldForId")]
		public Product SupportSoldFor { get; set; }
		[CProperty(Navigation ="Product:ProductId")]
		public Product Product { get; set; }
		[CProperty(Navigation ="TsOrderExpense:TsOrderExpenseId")]
		public TsOrderExpense TsOrderExpense { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
