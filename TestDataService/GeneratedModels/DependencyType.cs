using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DependencyType")]
	public class DependencyType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DependencyCategoryId")]
		public Guid DependencyCategoryId { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="ForConfItemConfItem")]
		public bool ForConfItemConfItem { get; set; }
		[CProperty(ColumnPath ="ForServiceConfItem")]
		public bool ForServiceConfItem { get; set; }
		[CProperty(ColumnPath ="ForServiceService")]
		public bool ForServiceService { get; set; }
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
		[CProperty(ColumnPath ="ReverseTypeName")]
		public string ReverseTypeName { get; set; }
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
