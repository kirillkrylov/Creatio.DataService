using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SpecificationType")]
	public class SpecificationType : BaseEntity
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
		[CProperty(Association ="LevelPartnershipParam:ParameterValueTypeId")]
		public virtual ICollection<LevelPartnershipParam> LevelPartnershipParamByParameterValueType { get; set; }
		[CProperty(Association ="PartnerParamHistory:ParameterValueTypeId")]
		public virtual ICollection<PartnerParamHistory> PartnerParamHistoryByParameterValueType { get; set; }
		[CProperty(Association ="PartnershipParameter:ParameterValueTypeId")]
		public virtual ICollection<PartnershipParameter> PartnershipParameterByParameterValueType { get; set; }
		[CProperty(Association ="Specification:TypeId")]
		public virtual ICollection<Specification> SpecificationByType { get; set; }
		#endregion
	}
}
