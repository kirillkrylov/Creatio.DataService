using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwInvoiceProduct")]
	public class VwInvoiceProduct : BaseEntity
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
		private decimal _BaseQuantity;
		[CProperty(ColumnPath ="BaseQuantity")]
		public decimal BaseQuantity
		{
			get{return _BaseQuantity;}
			set
			{
				_BaseQuantity = value;
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
		private string _CustomProduct;
		[CProperty(ColumnPath ="CustomProduct")]
		public string CustomProduct
		{
			get{return _CustomProduct;}
			set
			{
				_CustomProduct = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DeliveryDate;
		[CProperty(ColumnPath ="DeliveryDate")]
		public DateTime DeliveryDate
		{
			get{return _DeliveryDate;}
			set
			{
				_DeliveryDate = value;
				OnPropertyChanged();
			}
		}
		private decimal _DiscountAmount;
		[CProperty(ColumnPath ="DiscountAmount")]
		public decimal DiscountAmount
		{
			get{return _DiscountAmount;}
			set
			{
				_DiscountAmount = value;
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
		private decimal _DiscountTax;
		[CProperty(ColumnPath ="DiscountTax")]
		public decimal DiscountTax
		{
			get{return _DiscountTax;}
			set
			{
				_DiscountTax = value;
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
		private bool _IsRecordLocked;
		[CProperty(ColumnPath ="IsRecordLocked")]
		public bool IsRecordLocked
		{
			get{return _IsRecordLocked;}
			set
			{
				_IsRecordLocked = value;
				OnPropertyChanged();
			}
		}
		private decimal _Margin;
		[CProperty(ColumnPath ="Margin")]
		public decimal Margin
		{
			get{return _Margin;}
			set
			{
				_Margin = value;
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
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
				OnPropertyChanged();
			}
		}
		private Guid _OrderProductId;
		[CProperty(ColumnPath ="OrderProductId")]
		public Guid OrderProductId
		{
			get{return _OrderProductId;}
			set
			{
				_OrderProductId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PeriodId;
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId
		{
			get{return _PeriodId;}
			set
			{
				_PeriodId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Price;
		[CProperty(ColumnPath ="Price")]
		public decimal Price
		{
			get{return _Price;}
			set
			{
				_Price = value;
				OnPropertyChanged();
			}
		}
		private Guid _PriceListId;
		[CProperty(ColumnPath ="PriceListId")]
		public Guid PriceListId
		{
			get{return _PriceListId;}
			set
			{
				_PriceListId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PriceWithDiscount;
		[CProperty(ColumnPath ="PriceWithDiscount")]
		public decimal PriceWithDiscount
		{
			get{return _PriceWithDiscount;}
			set
			{
				_PriceWithDiscount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryAmount;
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount
		{
			get{return _PrimaryAmount;}
			set
			{
				_PrimaryAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryDiscountAmount;
		[CProperty(ColumnPath ="PrimaryDiscountAmount")]
		public decimal PrimaryDiscountAmount
		{
			get{return _PrimaryDiscountAmount;}
			set
			{
				_PrimaryDiscountAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryPaymentAmount;
		[CProperty(ColumnPath ="PrimaryPaymentAmount")]
		public decimal PrimaryPaymentAmount
		{
			get{return _PrimaryPaymentAmount;}
			set
			{
				_PrimaryPaymentAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryPrice;
		[CProperty(ColumnPath ="PrimaryPrice")]
		public decimal PrimaryPrice
		{
			get{return _PrimaryPrice;}
			set
			{
				_PrimaryPrice = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryTaxAmount;
		[CProperty(ColumnPath ="PrimaryTaxAmount")]
		public decimal PrimaryTaxAmount
		{
			get{return _PrimaryTaxAmount;}
			set
			{
				_PrimaryTaxAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryTotalAmount;
		[CProperty(ColumnPath ="PrimaryTotalAmount")]
		public decimal PrimaryTotalAmount
		{
			get{return _PrimaryTotalAmount;}
			set
			{
				_PrimaryTotalAmount = value;
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
		private decimal _Quantity;
		[CProperty(ColumnPath ="Quantity")]
		public decimal Quantity
		{
			get{return _Quantity;}
			set
			{
				_Quantity = value;
				OnPropertyChanged();
			}
		}
		private DateTime _RenewalDate;
		[CProperty(ColumnPath ="RenewalDate")]
		public DateTime RenewalDate
		{
			get{return _RenewalDate;}
			set
			{
				_RenewalDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _SaleTypeId;
		[CProperty(ColumnPath ="SaleTypeId")]
		public Guid SaleTypeId
		{
			get{return _SaleTypeId;}
			set
			{
				_SaleTypeId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupplyPaymentProductId;
		[CProperty(ColumnPath ="SupplyPaymentProductId")]
		public Guid SupplyPaymentProductId
		{
			get{return _SupplyPaymentProductId;}
			set
			{
				_SupplyPaymentProductId = value;
				OnPropertyChanged();
			}
		}
		private decimal _TaxAmount;
		[CProperty(ColumnPath ="TaxAmount")]
		public decimal TaxAmount
		{
			get{return _TaxAmount;}
			set
			{
				_TaxAmount = value;
				OnPropertyChanged();
			}
		}
		private Guid _TaxId;
		[CProperty(ColumnPath ="TaxId")]
		public Guid TaxId
		{
			get{return _TaxId;}
			set
			{
				_TaxId = value;
				OnPropertyChanged();
			}
		}
		private decimal _TotalAmount;
		[CProperty(ColumnPath ="TotalAmount")]
		public decimal TotalAmount
		{
			get{return _TotalAmount;}
			set
			{
				_TotalAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _TotalAmountWithoutTax;
		[CProperty(ColumnPath ="TotalAmountWithoutTax")]
		public decimal TotalAmountWithoutTax
		{
			get{return _TotalAmountWithoutTax;}
			set
			{
				_TotalAmountWithoutTax = value;
				OnPropertyChanged();
			}
		}
		private Guid _UnitId;
		[CProperty(ColumnPath ="UnitId")]
		public Guid UnitId
		{
			get{return _UnitId;}
			set
			{
				_UnitId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="OrderProduct:OrderProductId")]
		public OrderProduct OrderProduct { get; set; }
		[CProperty(Navigation ="OrderProductPeriod:PeriodId")]
		public OrderProductPeriod Period { get; set; }
		[CProperty(Navigation ="Pricelist:PriceListId")]
		public Pricelist PriceList { get; set; }
		[CProperty(Navigation ="Product:ProductId")]
		public Product Product { get; set; }
		[CProperty(Navigation ="SaleType:SaleTypeId")]
		public SaleType SaleType { get; set; }
		[CProperty(Navigation ="SupplyPaymentProduct:SupplyPaymentProductId")]
		public SupplyPaymentProduct SupplyPaymentProduct { get; set; }
		[CProperty(Navigation ="Tax:TaxId")]
		public Tax Tax { get; set; }
		[CProperty(Navigation ="Unit:UnitId")]
		public Unit Unit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
