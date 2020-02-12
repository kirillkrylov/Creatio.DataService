using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SocialAccount")]
	public class SocialAccount : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccessSecretToken")]
		public string AccessSecretToken { get; set; }
		[CProperty(ColumnPath ="AccessToken")]
		public string AccessToken { get; set; }
		[CProperty(ColumnPath ="ConsumerKey")]
		public string ConsumerKey { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsExpired")]
		public bool IsExpired { get; set; }
		[CProperty(ColumnPath ="Login")]
		public string Login { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Public")]
		public bool Public { get; set; }
		[CProperty(ColumnPath ="SocialId")]
		public string SocialId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="UserId")]
		public Guid UserId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CommunicationType:TypeId")]
		public CommunicationType Type { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysAdminUnit:UserId")]
		public SysAdminUnit User { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ActivityCorrespondence:SourceAccountId")]
		public virtual ICollection<ActivityCorrespondence> ActivityCorrespondenceBySourceAccount { get; set; }
		[CProperty(Association ="Contact:TwitterAFDAId")]
		public virtual ICollection<Contact> ContactByTwitterAFDA { get; set; }
		[CProperty(Association ="Contact:FacebookAFDAId")]
		public virtual ICollection<Contact> ContactByFacebookAFDA { get; set; }
		[CProperty(Association ="Contact:LinkedInAFDAId")]
		public virtual ICollection<Contact> ContactByLinkedInAFDA { get; set; }
		[CProperty(Association ="ContactCorrespondence:SourceAccountId")]
		public virtual ICollection<ContactCorrespondence> ContactCorrespondenceBySourceAccount { get; set; }
		[CProperty(Association ="VwEventInContact:TwitterAFDAId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByTwitterAFDA { get; set; }
		[CProperty(Association ="VwEventInContact:FacebookAFDAId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByFacebookAFDA { get; set; }
		[CProperty(Association ="VwEventInContact:LinkedInAFDAId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByLinkedInAFDA { get; set; }
		#endregion
	}
}
