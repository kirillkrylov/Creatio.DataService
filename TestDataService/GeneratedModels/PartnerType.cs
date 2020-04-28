using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PartnerType")]
	public class PartnerType : BaseEntity
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
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Lead:PartnerTypeId")]
		public virtual ICollection<Lead> LeadByPartnerType { get; set; }
		[CProperty(Association ="Opportunity:PartnerTypeId")]
		public virtual ICollection<Opportunity> OpportunityByPartnerType { get; set; }
		[CProperty(Association ="PartnerLevel:PartnerTypeId")]
		public virtual ICollection<PartnerLevel> PartnerLevelByPartnerType { get; set; }
		[CProperty(Association ="Partnership:PartnerTypeId")]
		public virtual ICollection<Partnership> PartnershipByPartnerType { get; set; }
		[CProperty(Association ="VwLead:PartnerTypeId")]
		public virtual ICollection<VwLead> VwLeadByPartnerType { get; set; }
		#endregion
	}
}
