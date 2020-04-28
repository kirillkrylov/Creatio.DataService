using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BpmGDPR")]
	public class BpmGDPR : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BpmName")]
		public string BpmName { get; set; }
		[CProperty(ColumnPath ="BpmNotes")]
		public string BpmNotes { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
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
		[CProperty(Association ="BpmGDPRFile:BpmGDPRId")]
		public virtual ICollection<BpmGDPRFile> BpmGDPRFileByBpmGDPR { get; set; }
		[CProperty(Association ="BpmGDPRInFolder:BpmGDPRId")]
		public virtual ICollection<BpmGDPRInFolder> BpmGDPRInFolderByBpmGDPR { get; set; }
		[CProperty(Association ="BpmGDPRInTag:EntityId")]
		public virtual ICollection<BpmGDPRInTag> BpmGDPRInTagByEntity { get; set; }
		[CProperty(Association ="BpmPreferences:BpmGDPRId")]
		public virtual ICollection<BpmPreferences> BpmPreferencesByBpmGDPR { get; set; }
		[CProperty(Association ="Contact:BpmManageDataPrivacyId")]
		public virtual ICollection<Contact> ContactByBpmManageDataPrivacy { get; set; }
		[CProperty(Association ="Employee:BpmManageDataPrivacyId")]
		public virtual ICollection<Employee> EmployeeByBpmManageDataPrivacy { get; set; }
		[CProperty(Association ="Lead:BpmGDPRId")]
		public virtual ICollection<Lead> LeadByBpmGDPR { get; set; }
		[CProperty(Association ="VwEventInContact:BpmManageDataPrivacyId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByBpmManageDataPrivacy { get; set; }
		[CProperty(Association ="VwLead:BpmGDPRId")]
		public virtual ICollection<VwLead> VwLeadByBpmGDPR { get; set; }
		#endregion
	}
}
