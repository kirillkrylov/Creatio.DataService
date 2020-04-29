using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductDeliveryType")]
	public class ProductDeliveryType : BaseEntity
	{
		#region Values
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
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
		private bool _IsUpdatedAutomatically;
		[CProperty(ColumnPath ="IsUpdatedAutomatically")]
		public bool IsUpdatedAutomatically
		{
			get{return _IsUpdatedAutomatically;}
			set
			{
				_IsUpdatedAutomatically = value;
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
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupplyPaymentTypeId;
		[CProperty(ColumnPath ="SupplyPaymentTypeId")]
		public Guid SupplyPaymentTypeId
		{
			get{return _SupplyPaymentTypeId;}
			set
			{
				_SupplyPaymentTypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SupplyPaymentType:SupplyPaymentTypeId")]
		public SupplyPaymentType SupplyPaymentType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Product:DeliveryTypeId")]
		public virtual ICollection<Product> ProductByDeliveryType { get; set; }
		[CProperty(Association ="SupplyPaymentElement:DeliveryTypeId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByDeliveryType { get; set; }
		[CProperty(Association ="Transaction:IncomeTypeId")]
		public virtual ICollection<Transaction> TransactionByIncomeType { get; set; }
		[CProperty(Association ="TransactionForecast:IncomeTypeId")]
		public virtual ICollection<TransactionForecast> TransactionForecastByIncomeType { get; set; }
		[CProperty(Association ="VwTransaction:IncomeTypeId")]
		public virtual ICollection<VwTransaction> VwTransactionByIncomeType { get; set; }
		#endregion
	}
}
