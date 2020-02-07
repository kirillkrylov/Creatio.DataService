using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SpecificationListItem")]
	public class SpecificationListItem : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SpecificationId")]
		public Guid SpecificationId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Specification:SpecificationId")]
		public Specification Specification { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="LevelPartnershipParam:ListItemValueId")]
		public virtual ICollection<LevelPartnershipParam> LevelPartnershipParamByListItemValue { get; set; }
		[CProperty(Association ="PartnerParamHistory:ListItemValueId")]
		public virtual ICollection<PartnerParamHistory> PartnerParamHistoryByListItemValue { get; set; }
		[CProperty(Association ="PartnershipParameter:ListItemValueId")]
		public virtual ICollection<PartnershipParameter> PartnershipParameterByListItemValue { get; set; }
		[CProperty(Association ="SpecificationInLead:ListItemValueId")]
		public virtual ICollection<SpecificationInLead> SpecificationInLeadByListItemValue { get; set; }
		[CProperty(Association ="SpecificationInObject:ListItemValueId")]
		public virtual ICollection<SpecificationInObject> SpecificationInObjectByListItemValue { get; set; }
		[CProperty(Association ="SpecificationInProduct:ListItemValueId")]
		public virtual ICollection<SpecificationInProduct> SpecificationInProductByListItemValue { get; set; }
		#endregion
	}
}
