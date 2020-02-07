using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysImage")]
	public class SysImage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Data")]
		public byte[] Data { get; set; }
		[CProperty(ColumnPath ="HasRef")]
		public bool HasRef { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="MimeType")]
		public string MimeType { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="PreviewData")]
		public byte[] PreviewData { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="UploadedOn")]
		public DateTime UploadedOn { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:AccountLogoId")]
		public virtual ICollection<Account> AccountByAccountLogo { get; set; }
		[CProperty(Association ="CallDirection:ImageId")]
		public virtual ICollection<CallDirection> CallDirectionByImage { get; set; }
		[CProperty(Association ="CaseOrigin:ImageId")]
		public virtual ICollection<CaseOrigin> CaseOriginByImage { get; set; }
		[CProperty(Association ="CasePriority:ImageId")]
		public virtual ICollection<CasePriority> CasePriorityByImage { get; set; }
		[CProperty(Association ="CaseStatus:ImageId")]
		public virtual ICollection<CaseStatus> CaseStatusByImage { get; set; }
		[CProperty(Association ="Contact:PhotoId")]
		public virtual ICollection<Contact> ContactByPhoto { get; set; }
		[CProperty(Association ="ContentBlock:ImageId")]
		public virtual ICollection<ContentBlock> ContentBlockByImage { get; set; }
		[CProperty(Association ="ContentUserBlock:ImageId")]
		public virtual ICollection<ContentUserBlock> ContentUserBlockByImage { get; set; }
		[CProperty(Association ="EmailTemplate:PreviewImageId")]
		public virtual ICollection<EmailTemplate> EmailTemplateByPreviewImage { get; set; }
		[CProperty(Association ="ESNNotificationType:IconId")]
		public virtual ICollection<ESNNotificationType> ESNNotificationTypeByIcon { get; set; }
		[CProperty(Association ="FolderType:ImageId")]
		public virtual ICollection<FolderType> FolderTypeByImage { get; set; }
		[CProperty(Association ="LeadType:ImageId")]
		public virtual ICollection<LeadType> LeadTypeByImage { get; set; }
		[CProperty(Association ="MailServer:LogoId")]
		public virtual ICollection<MailServer> MailServerByLogo { get; set; }
		[CProperty(Association ="MessagePublisher:ImageId")]
		public virtual ICollection<MessagePublisher> MessagePublisherByImage { get; set; }
		[CProperty(Association ="MultiLookupImage:LookupImageId")]
		public virtual ICollection<MultiLookupImage> MultiLookupImageByLookupImage { get; set; }
		[CProperty(Association ="NotificationsSettings:SysImageId")]
		public virtual ICollection<NotificationsSettings> NotificationsSettingsBySysImage { get; set; }
		[CProperty(Association ="OAuthApplications:ImageId")]
		public virtual ICollection<OAuthApplications> OAuthApplicationsByImage { get; set; }
		[CProperty(Association ="OpportunityMood:ImageId")]
		public virtual ICollection<OpportunityMood> OpportunityMoodByImage { get; set; }
		[CProperty(Association ="PageTemplate:PreviewImageId")]
		public virtual ICollection<PageTemplate> PageTemplateByPreviewImage { get; set; }
		[CProperty(Association ="ERROR")]
		public virtual ICollection<Portal_SysModule> PortalBySysModuleByImage32 { get; set; }
		[CProperty(Association ="ERROR")]
		public virtual ICollection<Portal_SysModule> PortalBySysModuleByLogo { get; set; }
		[CProperty(Association ="Product:PictureId")]
		public virtual ICollection<Product> ProductByPicture { get; set; }
		[CProperty(Association ="SatisfactionLevel:ImageId")]
		public virtual ICollection<SatisfactionLevel> SatisfactionLevelByImage { get; set; }
		[CProperty(Association ="SocialChannel:ImageId")]
		public virtual ICollection<SocialChannel> SocialChannelByImage { get; set; }
		[CProperty(Association ="SysChartSeriesKind:ImageId")]
		public virtual ICollection<SysChartSeriesKind> SysChartSeriesKindByImage { get; set; }
		[CProperty(Association ="SysCulture:ImageId")]
		public virtual ICollection<SysCulture> SysCultureByImage { get; set; }
		[CProperty(Association ="SysModule:Image32Id")]
		public virtual ICollection<SysModule> SysModuleByImage32 { get; set; }
		[CProperty(Association ="SysModule:LogoId")]
		public virtual ICollection<SysModule> SysModuleByLogo { get; set; }
		[CProperty(Association ="SysModuleAnalyticsReport:LogoId")]
		public virtual ICollection<SysModuleAnalyticsReport> SysModuleAnalyticsReportByLogo { get; set; }
		[CProperty(Association ="SysMsgUserState:ImageId")]
		public virtual ICollection<SysMsgUserState> SysMsgUserStateByImage { get; set; }
		[CProperty(Association ="SysMsgUserStateReason:ImageId")]
		public virtual ICollection<SysMsgUserStateReason> SysMsgUserStateReasonByImage { get; set; }
		[CProperty(Association ="SysOperationResult:ImageId")]
		public virtual ICollection<SysOperationResult> SysOperationResultByImage { get; set; }
		[CProperty(Association ="SysProcessUserTask:SysImageId")]
		public virtual ICollection<SysProcessUserTask> SysProcessUserTaskBySysImage { get; set; }
		[CProperty(Association ="VwMobileCaseMessageHistory:OwnerPhotoId")]
		public virtual ICollection<VwMobileCaseMessageHistory> VwMobileCaseMessageHistoryByOwnerPhoto { get; set; }
		[CProperty(Association ="VwPageTemplate:PreviewImageId")]
		public virtual ICollection<VwPageTemplate> VwPageTemplateByPreviewImage { get; set; }
		[CProperty(Association ="VwProcessLib:StartOptionsImageId")]
		public virtual ICollection<VwProcessLib> VwProcessLibByStartOptionsImage { get; set; }
		#endregion
	}
}
