using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Unit")]
	public class Unit : BaseEntity
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
		private string _ShortName;
		[CProperty(ColumnPath ="ShortName")]
		public string ShortName
		{
			get{return _ShortName;}
			set
			{
				_ShortName = value;
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
		[CProperty(Association ="DocumentProduct:UnitId")]
		public virtual ICollection<DocumentProduct> DocumentProductByUnit { get; set; }
		[CProperty(Association ="InvoiceProduct:UnitId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductByUnit { get; set; }
		[CProperty(Association ="OrderProduct:UnitId")]
		public virtual ICollection<OrderProduct> OrderProductByUnit { get; set; }
		[CProperty(Association ="Product:UnitId")]
		public virtual ICollection<Product> ProductByUnit { get; set; }
		[CProperty(Association ="ProductUnit:UnitId")]
		public virtual ICollection<ProductUnit> ProductUnitByUnit { get; set; }
		[CProperty(Association ="ProjectProduct:UnitId")]
		public virtual ICollection<ProjectProduct> ProjectProductByUnit { get; set; }
		[CProperty(Association ="VwDocumentProduct:UnitId")]
		public virtual ICollection<VwDocumentProduct> VwDocumentProductByUnit { get; set; }
		[CProperty(Association ="VwInvoiceProduct:UnitId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductByUnit { get; set; }
		[CProperty(Association ="VwOrderProduct:UnitId")]
		public virtual ICollection<VwOrderProduct> VwOrderProductByUnit { get; set; }
		[CProperty(Association ="VwProjectProduct:UnitId")]
		public virtual ICollection<VwProjectProduct> VwProjectProductByUnit { get; set; }
		#endregion
	}
}
