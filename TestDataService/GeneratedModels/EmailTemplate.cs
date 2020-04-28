using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmailTemplate")]
	public class EmailTemplate : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BlindCopyRecipient")]
		public byte[] BlindCopyRecipient { get; set; }
		[CProperty(ColumnPath ="Body")]
		public string Body { get; set; }
		[CProperty(ColumnPath ="ConfigType")]
		public int ConfigType { get; set; }
		[CProperty(ColumnPath ="CopyRecipient")]
		public byte[] CopyRecipient { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsHtmlBody")]
		public bool IsHtmlBody { get; set; }
		[CProperty(ColumnPath ="Macros")]
		public byte[] Macros { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ObjectFieldInActivity")]
		public Guid ObjectFieldInActivity { get; set; }
		[CProperty(ColumnPath ="ObjectId")]
		public Guid ObjectId { get; set; }
		[CProperty(ColumnPath ="PreviewImageId")]
		public Guid PreviewImageId { get; set; }
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Recipient")]
		public byte[] Recipient { get; set; }
		[CProperty(ColumnPath ="SaveAsActivity")]
		public bool SaveAsActivity { get; set; }
		[CProperty(ColumnPath ="SendIndividualEmailId")]
		public Guid SendIndividualEmailId { get; set; }
		[CProperty(ColumnPath ="ShowBeforeSending")]
		public bool ShowBeforeSending { get; set; }
		[CProperty(ColumnPath ="Subject")]
		public string Subject { get; set; }
		[CProperty(ColumnPath ="TemplateConfig")]
		public string TemplateConfig { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="ActivityPriority:PriorityId")]
		public ActivityPriority Priority { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EmailTemplateSendFlag:SendIndividualEmailId")]
		public EmailTemplateSendFlag SendIndividualEmail { get; set; }
		[CProperty(Navigation ="SysImage:PreviewImageId")]
		public SysImage PreviewImage { get; set; }
		[CProperty(Navigation ="VwSysSchemaInfo:ObjectId")]
		public VwSysSchemaInfo Object { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CaseNotificationRule:EmailTemplateId")]
		public virtual ICollection<CaseNotificationRule> CaseNotificationRuleByEmailTemplate { get; set; }
		[CProperty(Association ="EmailTemplateActivity:EmailTemplateId")]
		public virtual ICollection<EmailTemplateActivity> EmailTemplateActivityByEmailTemplate { get; set; }
		[CProperty(Association ="EmailTemplateFile:EmailTemplateId")]
		public virtual ICollection<EmailTemplateFile> EmailTemplateFileByEmailTemplate { get; set; }
		[CProperty(Association ="EmailTemplateLang:EmailTemplateId")]
		public virtual ICollection<EmailTemplateLang> EmailTemplateLangByEmailTemplate { get; set; }
		[CProperty(Association ="FavoriteEmailTemplate:EmailTemplateId")]
		public virtual ICollection<FavoriteEmailTemplate> FavoriteEmailTemplateByEmailTemplate { get; set; }
		[CProperty(Association ="labActualizeRule:labEmailTemplateId")]
		public virtual ICollection<labActualizeRule> labActualizeRuleBylabEmailTemplate { get; set; }
		[CProperty(Association ="SocialFeedFavoriteTpl:EmailTemplateId")]
		public virtual ICollection<SocialFeedFavoriteTpl> SocialFeedFavoriteTplByEmailTemplate { get; set; }
		[CProperty(Association ="TsMailNotificationValue:EmailTemplateId")]
		public virtual ICollection<TsMailNotificationValue> TsMailNotificationValueByEmailTemplate { get; set; }
		#endregion
	}
}
