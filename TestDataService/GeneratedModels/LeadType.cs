using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadType")]
	public class LeadType : BaseEntity
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
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId { get; set; }
		[CProperty(ColumnPath ="LeadTypeDetailizationId")]
		public Guid LeadTypeDetailizationId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NotForOpportunity")]
		public bool NotForOpportunity { get; set; }
		[CProperty(ColumnPath ="OpportunityDepartmentId")]
		public Guid OpportunityDepartmentId { get; set; }
		[CProperty(ColumnPath ="PrimaryQualification")]
		public bool PrimaryQualification { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="LeadDetailedType:LeadTypeDetailizationId")]
		public LeadDetailedType LeadTypeDetailization { get; set; }
		[CProperty(Navigation ="OpportunityDepartment:OpportunityDepartmentId")]
		public OpportunityDepartment OpportunityDepartment { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DepartmentTypeTerritory:LeadTypeId")]
		public virtual ICollection<DepartmentTypeTerritory> DepartmentTypeTerritoryByLeadType { get; set; }
		[CProperty(Association ="Lead:LeadTypeId")]
		public virtual ICollection<Lead> LeadByLeadType { get; set; }
		[CProperty(Association ="LeadInStage:LeadTypeId")]
		public virtual ICollection<LeadInStage> LeadInStageByLeadType { get; set; }
		[CProperty(Association ="LeadQualification:LeadTypeId")]
		public virtual ICollection<LeadQualification> LeadQualificationByLeadType { get; set; }
		[CProperty(Association ="LeadTypeForecast:LeadTypeId")]
		public virtual ICollection<LeadTypeForecast> LeadTypeForecastByLeadType { get; set; }
		[CProperty(Association ="Opportunity:LeadTypeId")]
		public virtual ICollection<Opportunity> OpportunityByLeadType { get; set; }
		[CProperty(Association ="ProductInLeadType:LeadTypeId")]
		public virtual ICollection<ProductInLeadType> ProductInLeadTypeByLeadType { get; set; }
		[CProperty(Association ="Queue:LeadTypeId")]
		public virtual ICollection<Queue> QueueByLeadType { get; set; }
		[CProperty(Association ="SiteEvent:LeadTypeId")]
		public virtual ICollection<SiteEvent> SiteEventByLeadType { get; set; }
		[CProperty(Association ="VwLead:LeadTypeId")]
		public virtual ICollection<VwLead> VwLeadByLeadType { get; set; }
		[CProperty(Association ="VwPortalOpportunity:LeadTypeId")]
		public virtual ICollection<VwPortalOpportunity> VwPortalOpportunityByLeadType { get; set; }
		[CProperty(Association ="VwProductInLeadType:LeadTypeId")]
		public virtual ICollection<VwProductInLeadType> VwProductInLeadTypeByLeadType { get; set; }
		[CProperty(Association ="VwSiteEvent:LeadTypeId")]
		public virtual ICollection<VwSiteEvent> VwSiteEventByLeadType { get; set; }
		#endregion
	}
}
