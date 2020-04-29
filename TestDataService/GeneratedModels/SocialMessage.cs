using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SocialMessage")]
	public class SocialMessage : BaseEntity
	{
		#region Values
		private int _CommentCount;
		[CProperty(ColumnPath ="CommentCount")]
		public int CommentCount
		{
			get{return _CommentCount;}
			set
			{
				_CommentCount = value;
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
		private Guid _EntityId;
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId
		{
			get{return _EntityId;}
			set
			{
				_EntityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntitySchemaUId;
		[CProperty(ColumnPath ="EntitySchemaUId")]
		public Guid EntitySchemaUId
		{
			get{return _EntitySchemaUId;}
			set
			{
				_EntitySchemaUId = value;
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
		private DateTime _LastActionOn;
		[CProperty(ColumnPath ="LastActionOn")]
		public DateTime LastActionOn
		{
			get{return _LastActionOn;}
			set
			{
				_LastActionOn = value;
				OnPropertyChanged();
			}
		}
		private int _LikeCount;
		[CProperty(ColumnPath ="LikeCount")]
		public int LikeCount
		{
			get{return _LikeCount;}
			set
			{
				_LikeCount = value;
				OnPropertyChanged();
			}
		}
		private string _Message;
		[CProperty(ColumnPath ="Message")]
		public string Message
		{
			get{return _Message;}
			set
			{
				_Message = value;
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
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SocialMessage:ParentId")]
		public SocialMessage Parent { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ESNNotification:SocialMessageId")]
		public virtual ICollection<ESNNotification> ESNNotificationBySocialMessage { get; set; }
		[CProperty(Association ="SocialLike:SocialMessageId")]
		public virtual ICollection<SocialLike> SocialLikeBySocialMessage { get; set; }
		[CProperty(Association ="SocialMention:SocialMessageId")]
		public virtual ICollection<SocialMention> SocialMentionBySocialMessage { get; set; }
		[CProperty(Association ="SocialMessage:ParentId")]
		public virtual ICollection<SocialMessage> SocialMessageByParent { get; set; }
		[CProperty(Association ="SocialMessageEntity:SocialMessageId")]
		public virtual ICollection<SocialMessageEntity> SocialMessageEntityBySocialMessage { get; set; }
		[CProperty(Association ="VwInternalRequestSM:SocialMessageId")]
		public virtual ICollection<VwInternalRequestSM> VwInternalRequestSMBySocialMessage { get; set; }
		[CProperty(Association ="VwInvoiceLastComment:SocialMessageId")]
		public virtual ICollection<VwInvoiceLastComment> VwInvoiceLastCommentBySocialMessage { get; set; }
		[CProperty(Association ="VwSocialSubscription:SocialMessageId")]
		public virtual ICollection<VwSocialSubscription> VwSocialSubscriptionBySocialMessage { get; set; }
		[CProperty(Association ="VwSocialUnsubscription:SocialMessageId")]
		public virtual ICollection<VwSocialUnsubscription> VwSocialUnsubscriptionBySocialMessage { get; set; }
		#endregion
	}
}
