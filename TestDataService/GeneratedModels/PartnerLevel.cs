using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PartnerLevel")]
	public class PartnerLevel : BaseEntity
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
		[CProperty(ColumnPath ="Number")]
		public int Number { get; set; }
		[CProperty(ColumnPath ="PartnerTypeId")]
		public Guid PartnerTypeId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="TargetScore")]
		public decimal TargetScore { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="PartnerType:PartnerTypeId")]
		public PartnerType PartnerType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="LevelPartnershipParam:PartnerLevelId")]
		public virtual ICollection<LevelPartnershipParam> LevelPartnershipParamByPartnerLevel { get; set; }
		[CProperty(Association ="PartnerParamHistory:PartnerLevelId")]
		public virtual ICollection<PartnerParamHistory> PartnerParamHistoryByPartnerLevel { get; set; }
		[CProperty(Association ="Partnership:PartnerLevelId")]
		public virtual ICollection<Partnership> PartnershipByPartnerLevel { get; set; }
		[CProperty(Association ="PartnershipParameter:PartnerLevelId")]
		public virtual ICollection<PartnershipParameter> PartnershipParameterByPartnerLevel { get; set; }
		#endregion
	}
}
