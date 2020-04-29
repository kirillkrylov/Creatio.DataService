using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSupplyPaymentProduct")]
	public class VwSupplyPaymentProduct : BaseEntity
	{
		#region Values
		private decimal _AvailableAmount;
		[CProperty(ColumnPath ="AvailableAmount")]
		public decimal AvailableAmount
		{
			get{return _AvailableAmount;}
			set
			{
				_AvailableAmount = value;
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
		private int _IsDistributed;
		[CProperty(ColumnPath ="IsDistributed")]
		public int IsDistributed
		{
			get{return _IsDistributed;}
			set
			{
				_IsDistributed = value;
				OnPropertyChanged();
			}
		}
		private decimal _MaxQuantity;
		[CProperty(ColumnPath ="MaxQuantity")]
		public decimal MaxQuantity
		{
			get{return _MaxQuantity;}
			set
			{
				_MaxQuantity = value;
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
		private decimal _TotalPrice;
		[CProperty(ColumnPath ="TotalPrice")]
		public decimal TotalPrice
		{
			get{return _TotalPrice;}
			set
			{
				_TotalPrice = value;
				OnPropertyChanged();
			}
		}
		private decimal _UsedAmount;
		[CProperty(ColumnPath ="UsedAmount")]
		public decimal UsedAmount
		{
			get{return _UsedAmount;}
			set
			{
				_UsedAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _UsedQuantity;
		[CProperty(ColumnPath ="UsedQuantity")]
		public decimal UsedQuantity
		{
			get{return _UsedQuantity;}
			set
			{
				_UsedQuantity = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OrderProduct:OrderProductId")]
		public OrderProduct OrderProduct { get; set; }
		[CProperty(Navigation ="SupplyPaymentElement:SupplyPaymentElementId")]
		public SupplyPaymentElement SupplyPaymentElement { get; set; }
		[CProperty(Navigation ="SupplyPaymentProduct:SupplyPaymentProductId")]
		public SupplyPaymentProduct SupplyPaymentProduct { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
