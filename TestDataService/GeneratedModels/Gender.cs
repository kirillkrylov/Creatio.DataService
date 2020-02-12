using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Gender")]
	public class Gender : BaseEntity
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
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
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
		[CProperty(Association ="Contact:GenderId")]
		public virtual ICollection<Contact> ContactByGender { get; set; }
		[CProperty(Association ="ContactSalutationType:GenderId")]
		public virtual ICollection<ContactSalutationType> ContactSalutationTypeByGender { get; set; }
		[CProperty(Association ="Lead:GenderId")]
		public virtual ICollection<Lead> LeadByGender { get; set; }
		[CProperty(Association ="LeadQualification:GenderId")]
		public virtual ICollection<LeadQualification> LeadQualificationByGender { get; set; }
		[CProperty(Association ="VwEventInContact:GenderId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByGender { get; set; }
		[CProperty(Association ="VwLead:GenderId")]
		public virtual ICollection<VwLead> VwLeadByGender { get; set; }
		#endregion
	}
}
