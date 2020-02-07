using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmail")]
	public class BulkEmail : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BlankEmailCount")]
		public int BlankEmailCount { get; set; }
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId { get; set; }
		[CProperty(ColumnPath ="CanceledCount")]
		public int CanceledCount { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="Clicks")]
		public decimal Clicks { get; set; }
		[CProperty(ColumnPath ="ClicksCount")]
		public int ClicksCount { get; set; }
		[CProperty(ColumnPath ="CommonErrorCount")]
		public int CommonErrorCount { get; set; }
		[CProperty(ColumnPath ="CommunicationLimitCount")]
		public int CommunicationLimitCount { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DeliveredCount")]
		public int DeliveredCount { get; set; }
		[CProperty(ColumnPath ="DeliveryError")]
		public int DeliveryError { get; set; }
		[CProperty(ColumnPath ="Domains")]
		public string Domains { get; set; }
		[CProperty(ColumnPath ="DoNotUseEmailCount")]
		public int DoNotUseEmailCount { get; set; }
		[CProperty(ColumnPath ="DuplicateEmailCount")]
		public int DuplicateEmailCount { get; set; }
		[CProperty(ColumnPath ="HardBounce")]
		public decimal HardBounce { get; set; }
		[CProperty(ColumnPath ="HardBounceCount")]
		public int HardBounceCount { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IncorrectEmailCount")]
		public int IncorrectEmailCount { get; set; }
		[CProperty(ColumnPath ="InQueueCount")]
		public int InQueueCount { get; set; }
		[CProperty(ColumnPath ="InvalidAddresseeCount")]
		public int InvalidAddresseeCount { get; set; }
		[CProperty(ColumnPath ="IsSystemEmail")]
		public bool IsSystemEmail { get; set; }
		[CProperty(ColumnPath ="LastActualizeDate")]
		public DateTime LastActualizeDate { get; set; }
		[CProperty(ColumnPath ="LaunchOptionId")]
		public Guid LaunchOptionId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NotDeliveredCount")]
		public int NotDeliveredCount { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="Opens")]
		public decimal Opens { get; set; }
		[CProperty(ColumnPath ="OpensCount")]
		public int OpensCount { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PercentActiveWeight")]
		public decimal PercentActiveWeight { get; set; }
		[CProperty(ColumnPath ="PercentInactiveWeight")]
		public decimal PercentInactiveWeight { get; set; }
		[CProperty(ColumnPath ="PercentWeight")]
		public decimal PercentWeight { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecipientCount")]
		public int RecipientCount { get; set; }
		[CProperty(ColumnPath ="RejectedCount")]
		public int RejectedCount { get; set; }
		[CProperty(ColumnPath ="ResponseProcessingCompleted")]
		public bool ResponseProcessingCompleted { get; set; }
		[CProperty(ColumnPath ="SegmentsStatusId")]
		public Guid SegmentsStatusId { get; set; }
		[CProperty(ColumnPath ="SendCount")]
		public int SendCount { get; set; }
		[CProperty(ColumnPath ="SendDueDate")]
		public DateTime SendDueDate { get; set; }
		[CProperty(ColumnPath ="SenderEmail")]
		public string SenderEmail { get; set; }
		[CProperty(ColumnPath ="SenderName")]
		public string SenderName { get; set; }
		[CProperty(ColumnPath ="SendersDomainNotVerifiedCount")]
		public int SendersDomainNotVerifiedCount { get; set; }
		[CProperty(ColumnPath ="SendersNameNotValidCount")]
		public int SendersNameNotValidCount { get; set; }
		[CProperty(ColumnPath ="SendStartDate")]
		public DateTime SendStartDate { get; set; }
		[CProperty(ColumnPath ="SoftBounce")]
		public decimal SoftBounce { get; set; }
		[CProperty(ColumnPath ="SoftBounceCount")]
		public int SoftBounceCount { get; set; }
		[CProperty(ColumnPath ="Spam")]
		public decimal Spam { get; set; }
		[CProperty(ColumnPath ="SpamCount")]
		public int SpamCount { get; set; }
		[CProperty(ColumnPath ="SplitTestId")]
		public Guid SplitTestId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StatisticDate")]
		public DateTime StatisticDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TemplateBody")]
		public string TemplateBody { get; set; }
		[CProperty(ColumnPath ="TemplateConfig")]
		public string TemplateConfig { get; set; }
		[CProperty(ColumnPath ="TemplateNotFoundCount")]
		public int TemplateNotFoundCount { get; set; }
		[CProperty(ColumnPath ="TemplateSubject")]
		public string TemplateSubject { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="UnreachableEmailCount")]
		public int UnreachableEmailCount { get; set; }
		[CProperty(ColumnPath ="Unsubscribe")]
		public decimal Unsubscribe { get; set; }
		[CProperty(ColumnPath ="UnsubscribeCount")]
		public int UnsubscribeCount { get; set; }
		[CProperty(ColumnPath ="UseUtm")]
		public bool UseUtm { get; set; }
		[CProperty(ColumnPath ="UtmCampaign")]
		public string UtmCampaign { get; set; }
		[CProperty(ColumnPath ="UtmContent")]
		public string UtmContent { get; set; }
		[CProperty(ColumnPath ="UtmMedium")]
		public string UtmMedium { get; set; }
		[CProperty(ColumnPath ="UtmSource")]
		public string UtmSource { get; set; }
		[CProperty(ColumnPath ="UtmTerm")]
		public string UtmTerm { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BulkEmailCategory:CategoryId")]
		public BulkEmailCategory Category { get; set; }
		[CProperty(Navigation ="BulkEmailLaunchOption:LaunchOptionId")]
		public BulkEmailLaunchOption LaunchOption { get; set; }
		[CProperty(Navigation ="BulkEmailSplit:SplitTestId")]
		public BulkEmailSplit SplitTest { get; set; }
		[CProperty(Navigation ="BulkEmailStatus:StatusId")]
		public BulkEmailStatus Status { get; set; }
		[CProperty(Navigation ="BulkEmailType:TypeId")]
		public BulkEmailType Type { get; set; }
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="SegmentStatus:SegmentsStatusId")]
		public SegmentStatus SegmentsStatus { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BulkEmailEventLog:BulkEmailId")]
		public virtual ICollection<BulkEmailEventLog> BulkEmailEventLogByBulkEmail { get; set; }
		[CProperty(Association ="BulkEmailFile:BulkEmailId")]
		public virtual ICollection<BulkEmailFile> BulkEmailFileByBulkEmail { get; set; }
		[CProperty(Association ="BulkEmailHyperlink:BulkEmailId")]
		public virtual ICollection<BulkEmailHyperlink> BulkEmailHyperlinkByBulkEmail { get; set; }
		[CProperty(Association ="BulkEmailInBulkEmailSplit:BulkEmailId")]
		public virtual ICollection<BulkEmailInBulkEmailSplit> BulkEmailInBulkEmailSplitByBulkEmail { get; set; }
		[CProperty(Association ="BulkEmailInFolder:BulkEmailId")]
		public virtual ICollection<BulkEmailInFolder> BulkEmailInFolderByBulkEmail { get; set; }
		[CProperty(Association ="BulkEmailInTag:EntityId")]
		public virtual ICollection<BulkEmailInTag> BulkEmailInTagByEntity { get; set; }
		[CProperty(Association ="BulkEmailRecipientMacro:BulkEmailId")]
		public virtual ICollection<BulkEmailRecipientMacro> BulkEmailRecipientMacroByBulkEmail { get; set; }
		[CProperty(Association ="BulkEmailRecipientReplica:BulkEmailId")]
		public virtual ICollection<BulkEmailRecipientReplica> BulkEmailRecipientReplicaByBulkEmail { get; set; }
		[CProperty(Association ="BulkEmailReplicaHeaders:BulkEmailId")]
		public virtual ICollection<BulkEmailReplicaHeaders> BulkEmailReplicaHeadersByBulkEmail { get; set; }
		[CProperty(Association ="BulkEmailSegment:BulkEmailId")]
		public virtual ICollection<BulkEmailSegment> BulkEmailSegmentByBulkEmail { get; set; }
		[CProperty(Association ="BulkEmailTarget:BulkEmailId")]
		public virtual ICollection<BulkEmailTarget> BulkEmailTargetByBulkEmail { get; set; }
		[CProperty(Association ="Lead:BulkEmailId")]
		public virtual ICollection<Lead> LeadByBulkEmail { get; set; }
		[CProperty(Association ="VwBulkEmailInCampaign:BulkEmailId")]
		public virtual ICollection<VwBulkEmailInCampaign> VwBulkEmailInCampaignByBulkEmail { get; set; }
		[CProperty(Association ="VwMandrillRecipient:BulkEmailId")]
		public virtual ICollection<VwMandrillRecipient> VwMandrillRecipientByBulkEmail { get; set; }
		[CProperty(Association ="VwMandrillRecipientV2:BulkEmailId")]
		public virtual ICollection<VwMandrillRecipientV2> VwMandrillRecipientV2ByBulkEmail { get; set; }
		#endregion
	}
}
