using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SaaSMetricsTransactions")]
	public class SaaSMetricsTransactions : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ActivationDate;
		[CProperty(ColumnPath ="ActivationDate")]
		public DateTime ActivationDate
		{
			get{return _ActivationDate;}
			set
			{
				_ActivationDate = value;
				OnPropertyChanged();
			}
		}
		private decimal _AmountWithoutTax;
		[CProperty(ColumnPath ="AmountWithoutTax")]
		public decimal AmountWithoutTax
		{
			get{return _AmountWithoutTax;}
			set
			{
				_AmountWithoutTax = value;
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
		private DateTime _DeactivationDate;
		[CProperty(ColumnPath ="DeactivationDate")]
		public DateTime DeactivationDate
		{
			get{return _DeactivationDate;}
			set
			{
				_DeactivationDate = value;
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
		private bool _IsActive;
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive
		{
			get{return _IsActive;}
			set
			{
				_IsActive = value;
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
		private bool _NewProduct;
		[CProperty(ColumnPath ="NewProduct")]
		public bool NewProduct
		{
			get{return _NewProduct;}
			set
			{
				_NewProduct = value;
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
		private string _ProductCaption;
		[CProperty(ColumnPath ="ProductCaption")]
		public string ProductCaption
		{
			get{return _ProductCaption;}
			set
			{
				_ProductCaption = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProductFamilyId;
		[CProperty(ColumnPath ="ProductFamilyId")]
		public Guid ProductFamilyId
		{
			get{return _ProductFamilyId;}
			set
			{
				_ProductFamilyId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SigningDate;
		[CProperty(ColumnPath ="SigningDate")]
		public DateTime SigningDate
		{
			get{return _SigningDate;}
			set
			{
				_SigningDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _SpecificationId;
		[CProperty(ColumnPath ="SpecificationId")]
		public Guid SpecificationId
		{
			get{return _SpecificationId;}
			set
			{
				_SpecificationId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contract:SpecificationId")]
		public Contract Specification { get; set; }
		[CProperty(Navigation ="ProductKind:ProductFamilyId")]
		public ProductKind ProductFamily { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
