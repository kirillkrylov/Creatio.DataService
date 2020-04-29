using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductType")]
	public class ProductType : BaseEntity
	{
		#region Values
		private Guid _CategoryId;
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId
		{
			get{return _CategoryId;}
			set
			{
				_CategoryId = value;
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
		private DateTime _IntegratedOn;
		[CProperty(ColumnPath ="IntegratedOn")]
		public DateTime IntegratedOn
		{
			get{return _IntegratedOn;}
			set
			{
				_IntegratedOn = value;
				OnPropertyChanged();
			}
		}
		private bool _IsService;
		[CProperty(ColumnPath ="IsService")]
		public bool IsService
		{
			get{return _IsService;}
			set
			{
				_IsService = value;
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
		private Guid _Uid1C;
		[CProperty(ColumnPath ="Uid1C")]
		public Guid Uid1C
		{
			get{return _Uid1C;}
			set
			{
				_Uid1C = value;
				OnPropertyChanged();
			}
		}
		private bool _UseMinimumMargin;
		[CProperty(ColumnPath ="UseMinimumMargin")]
		public bool UseMinimumMargin
		{
			get{return _UseMinimumMargin;}
			set
			{
				_UseMinimumMargin = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ProductCategory:CategoryId")]
		public ProductCategory Category { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AttributeInSiteEvent:ProductTypeValueId")]
		public virtual ICollection<AttributeInSiteEvent> AttributeInSiteEventByProductTypeValue { get; set; }
		[CProperty(Association ="ContractByProductType:ProductTypeId")]
		public virtual ICollection<ContractByProductType> ContractByProductTypeByProductType { get; set; }
		[CProperty(Association ="Product:TypeId")]
		public virtual ICollection<Product> ProductByType { get; set; }
		[CProperty(Association ="ProductFilter:ProductTypeId")]
		public virtual ICollection<ProductFilter> ProductFilterByProductType { get; set; }
		#endregion
	}
}
