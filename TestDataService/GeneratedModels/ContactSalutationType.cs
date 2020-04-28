using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContactSalutationType")]
	public class ContactSalutationType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="GenderId")]
		public Guid GenderId { get; set; }
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
		[CProperty(Navigation ="Gender:GenderId")]
		public Gender Gender { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Contact:SalutationTypeId")]
		public virtual ICollection<Contact> ContactBySalutationType { get; set; }
		[CProperty(Association ="Lead:TitleId")]
		public virtual ICollection<Lead> LeadByTitle { get; set; }
		[CProperty(Association ="LeadQualification:SalutationId")]
		public virtual ICollection<LeadQualification> LeadQualificationBySalutation { get; set; }
		[CProperty(Association ="VwEventInContact:SalutationTypeId")]
		public virtual ICollection<VwEventInContact> VwEventInContactBySalutationType { get; set; }
		[CProperty(Association ="VwLead:TitleId")]
		public virtual ICollection<VwLead> VwLeadByTitle { get; set; }
		#endregion
	}
}
