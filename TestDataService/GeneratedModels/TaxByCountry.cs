using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TaxByCountry")]
	public class TaxByCountry : BaseEntity
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
		private Guid _CustomerCountryId;
		[CProperty(ColumnPath ="CustomerCountryId")]
		public Guid CustomerCountryId
		{
			get{return _CustomerCountryId;}
			set
			{
				_CustomerCountryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CustomerRegionId;
		[CProperty(ColumnPath ="CustomerRegionId")]
		public Guid CustomerRegionId
		{
			get{return _CustomerRegionId;}
			set
			{
				_CustomerRegionId = value;
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
		private bool _IsCustomerVatPayer;
		[CProperty(ColumnPath ="IsCustomerVatPayer")]
		public bool IsCustomerVatPayer
		{
			get{return _IsCustomerVatPayer;}
			set
			{
				_IsCustomerVatPayer = value;
				OnPropertyChanged();
			}
		}
		private bool _IsEu;
		[CProperty(ColumnPath ="IsEu")]
		public bool IsEu
		{
			get{return _IsEu;}
			set
			{
				_IsEu = value;
				OnPropertyChanged();
			}
		}
		private bool _IsSupplierSingleTaxPayer;
		[CProperty(ColumnPath ="IsSupplierSingleTaxPayer")]
		public bool IsSupplierSingleTaxPayer
		{
			get{return _IsSupplierSingleTaxPayer;}
			set
			{
				_IsSupplierSingleTaxPayer = value;
				OnPropertyChanged();
			}
		}
		private bool _IsSupplierVatPayer;
		[CProperty(ColumnPath ="IsSupplierVatPayer")]
		public bool IsSupplierVatPayer
		{
			get{return _IsSupplierVatPayer;}
			set
			{
				_IsSupplierVatPayer = value;
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
		private Guid _ProductCategoryId;
		[CProperty(ColumnPath ="ProductCategoryId")]
		public Guid ProductCategoryId
		{
			get{return _ProductCategoryId;}
			set
			{
				_ProductCategoryId = value;
				OnPropertyChanged();
			}
		}
		private bool _ShowMessage;
		[CProperty(ColumnPath ="ShowMessage")]
		public bool ShowMessage
		{
			get{return _ShowMessage;}
			set
			{
				_ShowMessage = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupplierCountryId;
		[CProperty(ColumnPath ="SupplierCountryId")]
		public Guid SupplierCountryId
		{
			get{return _SupplierCountryId;}
			set
			{
				_SupplierCountryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupplierRegionId;
		[CProperty(ColumnPath ="SupplierRegionId")]
		public Guid SupplierRegionId
		{
			get{return _SupplierRegionId;}
			set
			{
				_SupplierRegionId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Country:SupplierCountryId")]
		public Country SupplierCountry { get; set; }
		[CProperty(Navigation ="Country:CustomerCountryId")]
		public Country CustomerCountry { get; set; }
		[CProperty(Navigation ="ProductCategory:ProductCategoryId")]
		public ProductCategory ProductCategory { get; set; }
		[CProperty(Navigation ="Region:SupplierRegionId")]
		public Region SupplierRegion { get; set; }
		[CProperty(Navigation ="Region:CustomerRegionId")]
		public Region CustomerRegion { get; set; }
		[CProperty(Navigation ="Tax:TaxId")]
		public Tax Tax { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
