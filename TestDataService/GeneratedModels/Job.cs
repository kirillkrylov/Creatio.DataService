using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Job")]
	public class Job : BaseEntity
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
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
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
		[CProperty(Association ="Applicant:CurrentJobId")]
		public virtual ICollection<Applicant> ApplicantByCurrentJob { get; set; }
		[CProperty(Association ="Contact:JobId")]
		public virtual ICollection<Contact> ContactByJob { get; set; }
		[CProperty(Association ="ContactCareer:JobId")]
		public virtual ICollection<ContactCareer> ContactCareerByJob { get; set; }
		[CProperty(Association ="GlbCustomerKeyPlayerList:GlbJobId")]
		public virtual ICollection<GlbCustomerKeyPlayerList> GlbCustomerKeyPlayerListByGlbJob { get; set; }
		[CProperty(Association ="Lead:JobId")]
		public virtual ICollection<Lead> LeadByJob { get; set; }
		[CProperty(Association ="LeadQualification:JobId")]
		public virtual ICollection<LeadQualification> LeadQualificationByJob { get; set; }
		[CProperty(Association ="OpportunityContact:JobId")]
		public virtual ICollection<OpportunityContact> OpportunityContactByJob { get; set; }
		[CProperty(Association ="PainChain:JobId")]
		public virtual ICollection<PainChain> PainChainByJob { get; set; }
		[CProperty(Association ="PainChainItem:JobId")]
		public virtual ICollection<PainChainItem> PainChainItemByJob { get; set; }
		[CProperty(Association ="PainReason:JobId")]
		public virtual ICollection<PainReason> PainReasonByJob { get; set; }
		[CProperty(Association ="ProjectRole:JobTitleId")]
		public virtual ICollection<ProjectRole> ProjectRoleByJobTitle { get; set; }
		[CProperty(Association ="VwEventInContact:JobId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByJob { get; set; }
		[CProperty(Association ="VwLead:JobId")]
		public virtual ICollection<VwLead> VwLeadByJob { get; set; }
		#endregion
	}
}
