using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupplyPaymentProduct")]
	public class SupplyPaymentProduct : BaseEntity
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
		private Guid _CurrencyId;
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId
		{
			get{return _CurrencyId;}
			set
			{
				_CurrencyId = value;
				OnPropertyChanged();
			}
		}
		private decimal _CurrencyRate;
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate
		{
			get{return _CurrencyRate;}
			set
			{
				_CurrencyRate = value;
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
		private Guid _SupplyPaymentElementId;
		[CProperty(ColumnPath ="SupplyPaymentElementId")]
		public Guid SupplyPaymentElementId
		{
			get{return _SupplyPaymentElementId;}
			set
			{
				_SupplyPaymentElementId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="OrderProduct:ProductId")]
		public OrderProduct Product { get; set; }
		[CProperty(Navigation ="SupplyPaymentElement:SupplyPaymentElementId")]
		public SupplyPaymentElement SupplyPaymentElement { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="InvoiceProduct:SupplyPaymentProductId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductBySupplyPaymentProduct { get; set; }
		[CProperty(Association ="VwInvoiceProduct:SupplyPaymentProductId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductBySupplyPaymentProduct { get; set; }
		[CProperty(Association ="VwSupplyPaymentProduct:SupplyPaymentProductId")]
		public virtual ICollection<VwSupplyPaymentProduct> VwSupplyPaymentProductBySupplyPaymentProduct { get; set; }
		#endregion
	}
}
