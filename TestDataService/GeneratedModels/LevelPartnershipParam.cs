using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LevelPartnershipParam")]
	public class LevelPartnershipParam : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BooleanValue")]
		public bool BooleanValue { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="FloatValue")]
		public decimal FloatValue { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IntValue")]
		public int IntValue { get; set; }
		[CProperty(ColumnPath ="ListItemValueId")]
		public Guid ListItemValueId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ParameterTypeId")]
		public Guid ParameterTypeId { get; set; }
		[CProperty(ColumnPath ="ParameterValueTypeId")]
		public Guid ParameterValueTypeId { get; set; }
		[CProperty(ColumnPath ="PartnerLevelId")]
		public Guid PartnerLevelId { get; set; }
		[CProperty(ColumnPath ="PartnerParamCategoryId")]
		public Guid PartnerParamCategoryId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="Score")]
		public int Score { get; set; }
		[CProperty(ColumnPath ="SpecificationId")]
		public Guid SpecificationId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StringValue")]
		public string StringValue { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ParameterType:ParameterTypeId")]
		public ParameterType ParameterType { get; set; }
		[CProperty(Navigation ="PartnerLevel:PartnerLevelId")]
		public PartnerLevel PartnerLevel { get; set; }
		[CProperty(Navigation ="PartnerParamCategory:PartnerParamCategoryId")]
		public PartnerParamCategory PartnerParamCategory { get; set; }
		[CProperty(Navigation ="Specification:SpecificationId")]
		public Specification Specification { get; set; }
		[CProperty(Navigation ="SpecificationListItem:ListItemValueId")]
		public SpecificationListItem ListItemValue { get; set; }
		[CProperty(Navigation ="SpecificationType:ParameterValueTypeId")]
		public SpecificationType ParameterValueType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
