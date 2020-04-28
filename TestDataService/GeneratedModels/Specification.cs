using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Specification")]
	public class Specification : BaseEntity
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
		[CProperty(ColumnPath ="IsForContract")]
		public bool IsForContract { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SpecificationType:TypeId")]
		public SpecificationType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="LevelPartnershipParam:SpecificationId")]
		public virtual ICollection<LevelPartnershipParam> LevelPartnershipParamBySpecification { get; set; }
		[CProperty(Association ="PartnerParamHistory:SpecificationId")]
		public virtual ICollection<PartnerParamHistory> PartnerParamHistoryBySpecification { get; set; }
		[CProperty(Association ="PartnershipParameter:SpecificationId")]
		public virtual ICollection<PartnershipParameter> PartnershipParameterBySpecification { get; set; }
		[CProperty(Association ="ProductFilter:SpecificationId")]
		public virtual ICollection<ProductFilter> ProductFilterBySpecification { get; set; }
		[CProperty(Association ="SpecificationInLead:SpecificationId")]
		public virtual ICollection<SpecificationInLead> SpecificationInLeadBySpecification { get; set; }
		[CProperty(Association ="SpecificationInObject:SpecificationId")]
		public virtual ICollection<SpecificationInObject> SpecificationInObjectBySpecification { get; set; }
		[CProperty(Association ="SpecificationInProduct:SpecificationId")]
		public virtual ICollection<SpecificationInProduct> SpecificationInProductBySpecification { get; set; }
		[CProperty(Association ="SpecificationListItem:SpecificationId")]
		public virtual ICollection<SpecificationListItem> SpecificationListItemBySpecification { get; set; }
		[CProperty(Association ="SpecInContract:SpecificationId")]
		public virtual ICollection<SpecInContract> SpecInContractBySpecification { get; set; }
		#endregion
	}
}
