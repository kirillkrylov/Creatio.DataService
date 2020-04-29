using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductFilter")]
	public class ProductFilter : BaseEntity
	{
		#region Values
		private string _ColumnCaption;
		[CProperty(ColumnPath ="ColumnCaption")]
		public string ColumnCaption
		{
			get{return _ColumnCaption;}
			set
			{
				_ColumnCaption = value;
				OnPropertyChanged();
			}
		}
		private int _ColumnDataValueType;
		[CProperty(ColumnPath ="ColumnDataValueType")]
		public int ColumnDataValueType
		{
			get{return _ColumnDataValueType;}
			set
			{
				_ColumnDataValueType = value;
				OnPropertyChanged();
			}
		}
		private string _ColumnPath;
		[CProperty(ColumnPath ="ColumnPath")]
		public string ColumnPath
		{
			get{return _ColumnPath;}
			set
			{
				_ColumnPath = value;
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
		private int _Position;
		[CProperty(ColumnPath ="Position")]
		public int Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
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
		private Guid _ProductTypeId;
		[CProperty(ColumnPath ="ProductTypeId")]
		public Guid ProductTypeId
		{
			get{return _ProductTypeId;}
			set
			{
				_ProductTypeId = value;
				OnPropertyChanged();
			}
		}
		private string _ReferenceSchemaName;
		[CProperty(ColumnPath ="ReferenceSchemaName")]
		public string ReferenceSchemaName
		{
			get{return _ReferenceSchemaName;}
			set
			{
				_ReferenceSchemaName = value;
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
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ProductFilterType:TypeId")]
		public ProductFilterType Type { get; set; }
		[CProperty(Navigation ="ProductType:ProductTypeId")]
		public ProductType ProductType { get; set; }
		[CProperty(Navigation ="Specification:SpecificationId")]
		public Specification Specification { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
