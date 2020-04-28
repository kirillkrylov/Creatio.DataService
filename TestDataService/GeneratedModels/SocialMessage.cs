using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SocialMessage")]
	public class SocialMessage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CommentCount")]
		public int CommentCount { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId { get; set; }
		[CProperty(ColumnPath ="EntitySchemaUId")]
		public Guid EntitySchemaUId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="LastActionOn")]
		public DateTime LastActionOn { get; set; }
		[CProperty(ColumnPath ="LikeCount")]
		public int LikeCount { get; set; }
		[CProperty(ColumnPath ="Message")]
		public string Message { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
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
