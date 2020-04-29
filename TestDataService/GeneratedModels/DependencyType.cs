using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DependencyType")]
	public class DependencyType : BaseEntity
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
		private bool _ForConfItemConfItem;
		[CProperty(ColumnPath ="ForConfItemConfItem")]
		public bool ForConfItemConfItem
		{
			get{return _ForConfItemConfItem;}
			set
			{
				_ForConfItemConfItem = value;
				OnPropertyChanged();
			}
		}
		private bool _ForServiceConfItem;
		[CProperty(ColumnPath ="ForServiceConfItem")]
		public bool ForServiceConfItem
		{
			get{return _ForServiceConfItem;}
			set
			{
				_ForServiceConfItem = value;
				OnPropertyChanged();
			}
		}
		private bool _ForServiceService;
		[CProperty(ColumnPath ="ForServiceService")]
		public bool ForServiceService
		{
			get{return _ForServiceService;}
			set
			{
				_ForServiceService = value;
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
		private string _ReverseTypeName;
		[CProperty(ColumnPath ="ReverseTypeName")]
		public string ReverseTypeName
		{
			get{return _ReverseTypeName;}
			set
			{
				_ReverseTypeName = value;
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
		#endregion

		#region Associations
		[CProperty(Association ="ConfItemRelationship:DependencyTypeId")]
		public virtual ICollection<ConfItemRelationship> ConfItemRelationshipByDependencyType { get; set; }
		[CProperty(Association ="ServiceInConfItem:DependencyTypeId")]
		public virtual ICollection<ServiceInConfItem> ServiceInConfItemByDependencyType { get; set; }
		[CProperty(Association ="ServiceRelationship:DependencyTypeId")]
		public virtual ICollection<ServiceRelationship> ServiceRelationshipByDependencyType { get; set; }
		[CProperty(Association ="VwConfItemRelationship:DependencyTypeId")]
		public virtual ICollection<VwConfItemRelationship> VwConfItemRelationshipByDependencyType { get; set; }
		[CProperty(Association ="VwServiceInConfItem:DependencyTypeId")]
		public virtual ICollection<VwServiceInConfItem> VwServiceInConfItemByDependencyType { get; set; }
		[CProperty(Association ="VwServiceRelationship:DependencyTypeId")]
		public virtual ICollection<VwServiceRelationship> VwServiceRelationshipByDependencyType { get; set; }
		#endregion
	}
}
