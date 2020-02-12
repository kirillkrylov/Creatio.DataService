using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContactDecisionRole")]
	public class ContactDecisionRole : BaseEntity
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
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
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
		[CProperty(Association ="Contact:DecisionRoleId")]
		public virtual ICollection<Contact> ContactByDecisionRole { get; set; }
		[CProperty(Association ="ContactCareer:DecisionRoleId")]
		public virtual ICollection<ContactCareer> ContactCareerByDecisionRole { get; set; }
		[CProperty(Association ="Lead:DecisionRoleId")]
		public virtual ICollection<Lead> LeadByDecisionRole { get; set; }
		[CProperty(Association ="LeadQualification:DecisionRoleId")]
		public virtual ICollection<LeadQualification> LeadQualificationByDecisionRole { get; set; }
		[CProperty(Association ="VwEventInContact:DecisionRoleId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByDecisionRole { get; set; }
		[CProperty(Association ="VwLead:DecisionRoleId")]
		public virtual ICollection<VwLead> VwLeadByDecisionRole { get; set; }
		#endregion
	}
}
