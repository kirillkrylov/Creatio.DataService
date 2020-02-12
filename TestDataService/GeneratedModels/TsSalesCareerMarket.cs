using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsSalesCareerMarket")]
	public class TsSalesCareerMarket : BaseEntity
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
		[CProperty(ColumnPath ="isActive")]
		public bool isActive { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
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
		[CProperty(Association ="Applicant:MarketId")]
		public virtual ICollection<Applicant> ApplicantByMarket { get; set; }
		[CProperty(Association ="InternalRequest:MarketId")]
		public virtual ICollection<InternalRequest> InternalRequestByMarket { get; set; }
		[CProperty(Association ="OrgStructureUnit:MarketId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByMarket { get; set; }
		[CProperty(Association ="SMHealthCheck:MarketId")]
		public virtual ICollection<SMHealthCheck> SMHealthCheckByMarket { get; set; }
		[CProperty(Association ="TsSalesCareer:MarketId")]
		public virtual ICollection<TsSalesCareer> TsSalesCareerByMarket { get; set; }
		[CProperty(Association ="VwTsSalesCareer:MarketId")]
		public virtual ICollection<VwTsSalesCareer> VwTsSalesCareerByMarket { get; set; }
		#endregion
	}
}
