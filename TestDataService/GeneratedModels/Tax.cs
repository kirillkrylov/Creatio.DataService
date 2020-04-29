using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Tax")]
	public class Tax : BaseEntity
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
		private decimal _Percent;
		[CProperty(ColumnPath ="Percent")]
		public decimal Percent
		{
			get{return _Percent;}
			set
			{
				_Percent = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DocumentProduct:TaxId")]
		public virtual ICollection<DocumentProduct> DocumentProductByTax { get; set; }
		[CProperty(Association ="ExesInRequest:TaxId")]
		public virtual ICollection<ExesInRequest> ExesInRequestByTax { get; set; }
		[CProperty(Association ="InvoiceProduct:TaxId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductByTax { get; set; }
		[CProperty(Association ="OrderProduct:TaxId")]
		public virtual ICollection<OrderProduct> OrderProductByTax { get; set; }
		[CProperty(Association ="Product:TaxId")]
		public virtual ICollection<Product> ProductByTax { get; set; }
		[CProperty(Association ="ProductPrice:TaxId")]
		public virtual ICollection<ProductPrice> ProductPriceByTax { get; set; }
		[CProperty(Association ="ProjectProduct:TaxId")]
		public virtual ICollection<ProjectProduct> ProjectProductByTax { get; set; }
		[CProperty(Association ="SupplyPaymentElement:TaxId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByTax { get; set; }
		[CProperty(Association ="TaxByCountry:TaxId")]
		public virtual ICollection<TaxByCountry> TaxByCountryByTax { get; set; }
		[CProperty(Association ="VwDocumentProduct:TaxId")]
		public virtual ICollection<VwDocumentProduct> VwDocumentProductByTax { get; set; }
		[CProperty(Association ="VwInvoiceProduct:TaxId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductByTax { get; set; }
		[CProperty(Association ="VwProjectProduct:TaxId")]
		public virtual ICollection<VwProjectProduct> VwProjectProductByTax { get; set; }
		#endregion
	}
}
