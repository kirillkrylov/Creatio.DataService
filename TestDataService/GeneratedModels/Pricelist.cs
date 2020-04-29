using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Pricelist")]
	public class Pricelist : BaseEntity
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
		private bool _IsBase;
		[CProperty(ColumnPath ="IsBase")]
		public bool IsBase
		{
			get{return _IsBase;}
			set
			{
				_IsBase = value;
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
		private Guid _TerritoryId;
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId
		{
			get{return _TerritoryId;}
			set
			{
				_TerritoryId = value;
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
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:PriceListId")]
		public virtual ICollection<Account> AccountByPriceList { get; set; }
		[CProperty(Association ="DocumentProduct:PriceListId")]
		public virtual ICollection<DocumentProduct> DocumentProductByPriceList { get; set; }
		[CProperty(Association ="InnerCurrencyRate:BasePriceListId")]
		public virtual ICollection<InnerCurrencyRate> InnerCurrencyRateByBasePriceList { get; set; }
		[CProperty(Association ="InnerCurrencyRate:NewPriceListId")]
		public virtual ICollection<InnerCurrencyRate> InnerCurrencyRateByNewPriceList { get; set; }
		[CProperty(Association ="InvoiceProduct:PriceListId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductByPriceList { get; set; }
		[CProperty(Association ="OrderProduct:PriceListId")]
		public virtual ICollection<OrderProduct> OrderProductByPriceList { get; set; }
		[CProperty(Association ="PricelistByCountry:PricelistId")]
		public virtual ICollection<PricelistByCountry> PricelistByCountryByPricelist { get; set; }
		[CProperty(Association ="ProductPrice:PriceListId")]
		public virtual ICollection<ProductPrice> ProductPriceByPriceList { get; set; }
		[CProperty(Association ="ProjectProduct:PriceListId")]
		public virtual ICollection<ProjectProduct> ProjectProductByPriceList { get; set; }
		[CProperty(Association ="SupportRate:PriceListId")]
		public virtual ICollection<SupportRate> SupportRateByPriceList { get; set; }
		[CProperty(Association ="VwDocumentProduct:PriceListId")]
		public virtual ICollection<VwDocumentProduct> VwDocumentProductByPriceList { get; set; }
		[CProperty(Association ="VwInvoiceProduct:PriceListId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductByPriceList { get; set; }
		[CProperty(Association ="VwProjectProduct:PriceListId")]
		public virtual ICollection<VwProjectProduct> VwProjectProductByPriceList { get; set; }
		#endregion
	}
}
