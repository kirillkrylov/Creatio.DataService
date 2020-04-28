using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DependencyCategory")]
	public class DependencyCategory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
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
