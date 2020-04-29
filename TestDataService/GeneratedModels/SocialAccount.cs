using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SocialAccount")]
	public class SocialAccount : BaseEntity
	{
		#region Values
		private string _AccessSecretToken;
		[CProperty(ColumnPath ="AccessSecretToken")]
		public string AccessSecretToken
		{
			get{return _AccessSecretToken;}
			set
			{
				_AccessSecretToken = value;
				OnPropertyChanged();
			}
		}
		private string _AccessToken;
		[CProperty(ColumnPath ="AccessToken")]
		public string AccessToken
		{
			get{return _AccessToken;}
			set
			{
				_AccessToken = value;
				OnPropertyChanged();
			}
		}
		private string _ConsumerKey;
		[CProperty(ColumnPath ="ConsumerKey")]
		public string ConsumerKey
		{
			get{return _ConsumerKey;}
			set
			{
				_ConsumerKey = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private bool _IsExpired;
		[CProperty(ColumnPath ="IsExpired")]
		public bool IsExpired
		{
			get{return _IsExpired;}
			set
			{
				_IsExpired = value;
				OnPropertyChanged();
			}
		}
		private string _Login;
		[CProperty(ColumnPath ="Login")]
		public string Login
		{
			get{return _Login;}
			set
			{
				_Login = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private bool _Public;
		[CProperty(ColumnPath ="Public")]
		public bool Public
		{
			get{return _Public;}
			set
			{
				_Public = value;
				OnPropertyChanged();
			}
		}
		private string _SocialId;
		[CProperty(ColumnPath ="SocialId")]
		public string SocialId
		{
			get{return _SocialId;}
			set
			{
				_SocialId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _UserId;
		[CProperty(ColumnPath ="UserId")]
		public Guid UserId
		{
			get{return _UserId;}
			set
			{
				_UserId = value;
				OnPropertyChanged();
			}
		}
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
