using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DependencyCategory")]
	public class DependencyCategory : BaseEntity
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ConfItemRelationship:DependencyCategoryId")]
		public virtual ICollection<ConfItemRelationship> ConfItemRelationshipByDependencyCategory { get; set; }
		[CProperty(Association ="DependencyType:DependencyCategoryId")]
		public virtual ICollection<DependencyType> DependencyTypeByDependencyCategory { get; set; }
		[CProperty(Association ="ServiceInConfItem:DependencyCategoryId")]
		public virtual ICollection<ServiceInConfItem> ServiceInConfItemByDependencyCategory { get; set; }
		[CProperty(Association ="ServiceRelationship:DependencyCategoryId")]
		public virtual ICollection<ServiceRelationship> ServiceRelationshipByDependencyCategory { get; set; }
		[CProperty(Association ="VwConfItemRelationship:DependencyCategoryId")]
		public virtual ICollection<VwConfItemRelationship> VwConfItemRelationshipByDependencyCategory { get; set; }
		[CProperty(Association ="VwConfItemRelationship:DependencyTypeCategoryId")]
		public virtual ICollection<VwConfItemRelationship> VwConfItemRelationshipByDependencyTypeCategory { get; set; }
		[CProperty(Association ="VwServiceInConfItem:DependencyCategoryId")]
		public virtual ICollection<VwServiceInConfItem> VwServiceInConfItemByDependencyCategory { get; set; }
		[CProperty(Association ="VwServiceInConfItem:DependencyCategoryReverseId")]
		public virtual ICollection<VwServiceInConfItem> VwServiceInConfItemByDependencyCategoryReverse { get; set; }
		[CProperty(Association ="VwServiceInConfItem:DependencyTypeCategoryId")]
		public virtual ICollection<VwServiceInConfItem> VwServiceInConfItemByDependencyTypeCategory { get; set; }
		[CProperty(Association ="VwServiceRelationship:DependencyCategoryId")]
		public virtual ICollection<VwServiceRelationship> VwServiceRelationshipByDependencyCategory { get; set; }
		[CProperty(Association ="VwServiceRelationship:DependencyTypeCategoryId")]
		public virtual ICollection<VwServiceRelationship> VwServiceRelationshipByDependencyTypeCategory { get; set; }
		#endregion
	}
}
