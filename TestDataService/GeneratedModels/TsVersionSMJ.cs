using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsVersionSMJ")]
	public class TsVersionSMJ : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
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
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BonusRates:VersionSMJId")]
		public virtual ICollection<BonusRates> BonusRatesByVersionSMJ { get; set; }
		[CProperty(Association ="ManagersQuotesBySegment:SMJVersionId")]
		public virtual ICollection<ManagersQuotesBySegment> ManagersQuotesBySegmentBySMJVersion { get; set; }
		[CProperty(Association ="ProductCoefficients:VersionSMJId")]
		public virtual ICollection<ProductCoefficients> ProductCoefficientsByVersionSMJ { get; set; }
		[CProperty(Association ="TsSalesCareer:VersionSMJId")]
		public virtual ICollection<TsSalesCareer> TsSalesCareerByVersionSMJ { get; set; }
		[CProperty(Association ="VwTsSalesCareer:VersionSMJId")]
		public virtual ICollection<VwTsSalesCareer> VwTsSalesCareerByVersionSMJ { get; set; }
		#endregion
	}
}
