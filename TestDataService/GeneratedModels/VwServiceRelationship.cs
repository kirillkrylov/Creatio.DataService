using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwServiceRelationship")]
	public class VwServiceRelationship : BaseEntity
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
		private Guid _DependencyCategoryId;
		[CProperty(ColumnPath ="DependencyCategoryId")]
		public Guid DependencyCategoryId
		{
			get{return _DependencyCategoryId;}
			set
			{
				_DependencyCategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DependencyTypeCategoryId;
		[CProperty(ColumnPath ="DependencyTypeCategoryId")]
		public Guid DependencyTypeCategoryId
		{
			get{return _DependencyTypeCategoryId;}
			set
			{
				_DependencyTypeCategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DependencyTypeId;
		[CProperty(ColumnPath ="DependencyTypeId")]
		public Guid DependencyTypeId
		{
			get{return _DependencyTypeId;}
			set
			{
				_DependencyTypeId = value;
				OnPropertyChanged();
			}
		}
		private string _DependencyTypeReverseName;
		[CProperty(ColumnPath ="DependencyTypeReverseName")]
		public string DependencyTypeReverseName
		{
			get{return _DependencyTypeReverseName;}
			set
			{
				_DependencyTypeReverseName = value;
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
		private bool _IsCopy;
		[CProperty(ColumnPath ="IsCopy")]
		public bool IsCopy
		{
			get{return _IsCopy;}
			set
			{
				_IsCopy = value;
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
		private Guid _ServiceItemAId;
		[CProperty(ColumnPath ="ServiceItemAId")]
		public Guid ServiceItemAId
		{
			get{return _ServiceItemAId;}
			set
			{
				_ServiceItemAId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ServiceItemBId;
		[CProperty(ColumnPath ="ServiceItemBId")]
		public Guid ServiceItemBId
		{
			get{return _ServiceItemBId;}
			set
			{
				_ServiceItemBId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DependencyCategory:DependencyCategoryId")]
		public DependencyCategory DependencyCategory { get; set; }
		[CProperty(Navigation ="DependencyCategory:DependencyTypeCategoryId")]
		public DependencyCategory DependencyTypeCategory { get; set; }
		[CProperty(Navigation ="DependencyType:DependencyTypeId")]
		public DependencyType DependencyType { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemAId")]
		public ServiceItem ServiceItemA { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemBId")]
		public ServiceItem ServiceItemB { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
