using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmail")]
	public class BulkEmail : BaseEntity
	{
		#region Values
		private int _BlankEmailCount;
		[CProperty(ColumnPath ="BlankEmailCount")]
		public int BlankEmailCount
		{
			get{return _BlankEmailCount;}
			set
			{
				_BlankEmailCount = value;
				OnPropertyChanged();
			}
		}
		private Guid _CampaignId;
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId
		{
			get{return _CampaignId;}
			set
			{
				_CampaignId = value;
				OnPropertyChanged();
			}
		}
		private int _CanceledCount;
		[CProperty(ColumnPath ="CanceledCount")]
		public int CanceledCount
		{
			get{return _CanceledCount;}
			set
			{
				_CanceledCount = value;
				OnPropertyChanged();
			}
		}
		private Guid _CategoryId;
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId
		{
			get{return _CategoryId;}
			set
			{
				_CategoryId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Clicks;
		[CProperty(ColumnPath ="Clicks")]
		public decimal Clicks
		{
			get{return _Clicks;}
			set
			{
				_Clicks = value;
				OnPropertyChanged();
			}
		}
		private int _ClicksCount;
		[CProperty(ColumnPath ="ClicksCount")]
		public int ClicksCount
		{
			get{return _ClicksCount;}
			set
			{
				_ClicksCount = value;
				OnPropertyChanged();
			}
		}
		private int _CommonErrorCount;
		[CProperty(ColumnPath ="CommonErrorCount")]
		public int CommonErrorCount
		{
			get{return _CommonErrorCount;}
			set
			{
				_CommonErrorCount = value;
				OnPropertyChanged();
			}
		}
		private int _CommunicationLimitCount;
		[CProperty(ColumnPath ="CommunicationLimitCount")]
		public int CommunicationLimitCount
		{
			get{return _CommunicationLimitCount;}
			set
			{
				_CommunicationLimitCount = value;
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
		private int _DeliveredCount;
		[CProperty(ColumnPath ="DeliveredCount")]
		public int DeliveredCount
		{
			get{return _DeliveredCount;}
			set
			{
				_DeliveredCount = value;
				OnPropertyChanged();
			}
		}
		private int _DeliveryError;
		[CProperty(ColumnPath ="DeliveryError")]
		public int DeliveryError
		{
			get{return _DeliveryError;}
			set
			{
				_DeliveryError = value;
				OnPropertyChanged();
			}
		}
		private string _Domains;
		[CProperty(ColumnPath ="Domains")]
		public string Domains
		{
			get{return _Domains;}
			set
			{
				_Domains = value;
				OnPropertyChanged();
			}
		}
		private int _DoNotUseEmailCount;
		[CProperty(ColumnPath ="DoNotUseEmailCount")]
		public int DoNotUseEmailCount
		{
			get{return _DoNotUseEmailCount;}
			set
			{
				_DoNotUseEmailCount = value;
				OnPropertyChanged();
			}
		}
		private int _DuplicateEmailCount;
		[CProperty(ColumnPath ="DuplicateEmailCount")]
		public int DuplicateEmailCount
		{
			get{return _DuplicateEmailCount;}
			set
			{
				_DuplicateEmailCount = value;
				OnPropertyChanged();
			}
		}
		private decimal _HardBounce;
		[CProperty(ColumnPath ="HardBounce")]
		public decimal HardBounce
		{
			get{return _HardBounce;}
			set
			{
				_HardBounce = value;
				OnPropertyChanged();
			}
		}
		private int _HardBounceCount;
		[CProperty(ColumnPath ="HardBounceCount")]
		public int HardBounceCount
		{
			get{return _HardBounceCount;}
			set
			{
				_HardBounceCount = value;
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
		private bool _IgnoreSendingRestriction;
		[CProperty(ColumnPath ="IgnoreSendingRestriction")]
		public bool IgnoreSendingRestriction
		{
			get{return _IgnoreSendingRestriction;}
			set
			{
				_IgnoreSendingRestriction = value;
				OnPropertyChanged();
			}
		}
		private int _IncorrectEmailCount;
		[CProperty(ColumnPath ="IncorrectEmailCount")]
		public int IncorrectEmailCount
		{
			get{return _IncorrectEmailCount;}
			set
			{
				_IncorrectEmailCount = value;
				OnPropertyChanged();
			}
		}
		private int _InQueueCount;
		[CProperty(ColumnPath ="InQueueCount")]
		public int InQueueCount
		{
			get{return _InQueueCount;}
			set
			{
				_InQueueCount = value;
				OnPropertyChanged();
			}
		}
		private int _InvalidAddresseeCount;
		[CProperty(ColumnPath ="InvalidAddresseeCount")]
		public int InvalidAddresseeCount
		{
			get{return _InvalidAddresseeCount;}
			set
			{
				_InvalidAddresseeCount = value;
				OnPropertyChanged();
			}
		}
		private bool _IsSystemEmail;
		[CProperty(ColumnPath ="IsSystemEmail")]
		public bool IsSystemEmail
		{
			get{return _IsSystemEmail;}
			set
			{
				_IsSystemEmail = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LastActualizeDate;
		[CProperty(ColumnPath ="LastActualizeDate")]
		public DateTime LastActualizeDate
		{
			get{return _LastActualizeDate;}
			set
			{
				_LastActualizeDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _LaunchOptionId;
		[CProperty(ColumnPath ="LaunchOptionId")]
		public Guid LaunchOptionId
		{
			get{return _LaunchOptionId;}
			set
			{
				_LaunchOptionId = value;
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
		private int _NotDeliveredCount;
		[CProperty(ColumnPath ="NotDeliveredCount")]
		public int NotDeliveredCount
		{
			get{return _NotDeliveredCount;}
			set
			{
				_NotDeliveredCount = value;
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
		private decimal _Opens;
		[CProperty(ColumnPath ="Opens")]
		public decimal Opens
		{
			get{return _Opens;}
			set
			{
				_Opens = value;
				OnPropertyChanged();
			}
		}
		private int _OpensCount;
		[CProperty(ColumnPath ="OpensCount")]
		public int OpensCount
		{
			get{return _OpensCount;}
			set
			{
				_OpensCount = value;
				OnPropertyChanged();
			}
		}
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PercentActiveWeight;
		[CProperty(ColumnPath ="PercentActiveWeight")]
		public decimal PercentActiveWeight
		{
			get{return _PercentActiveWeight;}
			set
			{
				_PercentActiveWeight = value;
				OnPropertyChanged();
			}
		}
		private decimal _PercentInactiveWeight;
		[CProperty(ColumnPath ="PercentInactiveWeight")]
		public decimal PercentInactiveWeight
		{
			get{return _PercentInactiveWeight;}
			set
			{
				_PercentInactiveWeight = value;
				OnPropertyChanged();
			}
		}
		private decimal _PercentWeight;
		[CProperty(ColumnPath ="PercentWeight")]
		public decimal PercentWeight
		{
			get{return _PercentWeight;}
			set
			{
				_PercentWeight = value;
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
		private int _RecipientCount;
		[CProperty(ColumnPath ="RecipientCount")]
		public int RecipientCount
		{
			get{return _RecipientCount;}
			set
			{
				_RecipientCount = value;
				OnPropertyChanged();
			}
		}
		private int _RejectedCount;
		[CProperty(ColumnPath ="RejectedCount")]
		public int RejectedCount
		{
			get{return _RejectedCount;}
			set
			{
				_RejectedCount = value;
				OnPropertyChanged();
			}
		}
		private bool _ResponseProcessingCompleted;
		[CProperty(ColumnPath ="ResponseProcessingCompleted")]
		public bool ResponseProcessingCompleted
		{
			get{return _ResponseProcessingCompleted;}
			set
			{
				_ResponseProcessingCompleted = value;
				OnPropertyChanged();
			}
		}
		private Guid _SegmentsStatusId;
		[CProperty(ColumnPath ="SegmentsStatusId")]
		public Guid SegmentsStatusId
		{
			get{return _SegmentsStatusId;}
			set
			{
				_SegmentsStatusId = value;
				OnPropertyChanged();
			}
		}
		private int _SendCount;
		[CProperty(ColumnPath ="SendCount")]
		public int SendCount
		{
			get{return _SendCount;}
			set
			{
				_SendCount = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SendDueDate;
		[CProperty(ColumnPath ="SendDueDate")]
		public DateTime SendDueDate
		{
			get{return _SendDueDate;}
			set
			{
				_SendDueDate = value;
				OnPropertyChanged();
			}
		}
		private string _SenderEmail;
		[CProperty(ColumnPath ="SenderEmail")]
		public string SenderEmail
		{
			get{return _SenderEmail;}
			set
			{
				_SenderEmail = value;
				OnPropertyChanged();
			}
		}
		private string _SenderName;
		[CProperty(ColumnPath ="SenderName")]
		public string SenderName
		{
			get{return _SenderName;}
			set
			{
				_SenderName = value;
				OnPropertyChanged();
			}
		}
		private int _SendersDomainNotVerifiedCount;
		[CProperty(ColumnPath ="SendersDomainNotVerifiedCount")]
		public int SendersDomainNotVerifiedCount
		{
			get{return _SendersDomainNotVerifiedCount;}
			set
			{
				_SendersDomainNotVerifiedCount = value;
				OnPropertyChanged();
			}
		}
		private int _SendersNameNotValidCount;
		[CProperty(ColumnPath ="SendersNameNotValidCount")]
		public int SendersNameNotValidCount
		{
			get{return _SendersNameNotValidCount;}
			set
			{
				_SendersNameNotValidCount = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SendStartDate;
		[CProperty(ColumnPath ="SendStartDate")]
		public DateTime SendStartDate
		{
			get{return _SendStartDate;}
			set
			{
				_SendStartDate = value;
				OnPropertyChanged();
			}
		}
		private decimal _SoftBounce;
		[CProperty(ColumnPath ="SoftBounce")]
		public decimal SoftBounce
		{
			get{return _SoftBounce;}
			set
			{
				_SoftBounce = value;
				OnPropertyChanged();
			}
		}
		private int _SoftBounceCount;
		[CProperty(ColumnPath ="SoftBounceCount")]
		public int SoftBounceCount
		{
			get{return _SoftBounceCount;}
			set
			{
				_SoftBounceCount = value;
				OnPropertyChanged();
			}
		}
		private decimal _Spam;
		[CProperty(ColumnPath ="Spam")]
		public decimal Spam
		{
			get{return _Spam;}
			set
			{
				_Spam = value;
				OnPropertyChanged();
			}
		}
		private int _SpamCount;
		[CProperty(ColumnPath ="SpamCount")]
		public int SpamCount
		{
			get{return _SpamCount;}
			set
			{
				_SpamCount = value;
				OnPropertyChanged();
			}
		}
		private Guid _SplitTestId;
		[CProperty(ColumnPath ="SplitTestId")]
		public Guid SplitTestId
		{
			get{return _SplitTestId;}
			set
			{
				_SplitTestId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StatisticDate;
		[CProperty(ColumnPath ="StatisticDate")]
		public DateTime StatisticDate
		{
			get{return _StatisticDate;}
			set
			{
				_StatisticDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
				OnPropertyChanged();
			}
		}
		private string _TemplateBody;
		[CProperty(ColumnPath ="TemplateBody")]
		public string TemplateBody
		{
			get{return _TemplateBody;}
			set
			{
				_TemplateBody = value;
				OnPropertyChanged();
			}
		}
		private string _TemplateConfig;
		[CProperty(ColumnPath ="TemplateConfig")]
		public string TemplateConfig
		{
			get{return _TemplateConfig;}
			set
			{
				_TemplateConfig = value;
				OnPropertyChanged();
			}
		}
		private int _TemplateNotFoundCount;
		[CProperty(ColumnPath ="TemplateNotFoundCount")]
		public int TemplateNotFoundCount
		{
			get{return _TemplateNotFoundCount;}
			set
			{
				_TemplateNotFoundCount = value;
				OnPropertyChanged();
			}
		}
		private string _TemplateSubject;
		[CProperty(ColumnPath ="TemplateSubject")]
		public string TemplateSubject
		{
			get{return _TemplateSubject;}
			set
			{
				_TemplateSubject = value;
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
		private int _UnreachableEmailCount;
		[CProperty(ColumnPath ="UnreachableEmailCount")]
		public int UnreachableEmailCount
		{
			get{return _UnreachableEmailCount;}
			set
			{
				_UnreachableEmailCount = value;
				OnPropertyChanged();
			}
		}
		private decimal _Unsubscribe;
		[CProperty(ColumnPath ="Unsubscribe")]
		public decimal Unsubscribe
		{
			get{return _Unsubscribe;}
			set
			{
				_Unsubscribe = value;
				OnPropertyChanged();
			}
		}
		private int _UnsubscribeCount;
		[CProperty(ColumnPath ="UnsubscribeCount")]
		public int UnsubscribeCount
		{
			get{return _UnsubscribeCount;}
			set
			{
				_UnsubscribeCount = value;
				OnPropertyChanged();
			}
		}
		private bool _UseUtm;
		[CProperty(ColumnPath ="UseUtm")]
		public bool UseUtm
		{
			get{return _UseUtm;}
			set
			{
				_UseUtm = value;
				OnPropertyChanged();
			}
		}
		private string _UtmCampaign;
		[CProperty(ColumnPath ="UtmCampaign")]
		public string UtmCampaign
		{
			get{return _UtmCampaign;}
			set
			{
				_UtmCampaign = value;
				OnPropertyChanged();
			}
		}
		private string _UtmContent;
		[CProperty(ColumnPath ="UtmContent")]
		public string UtmContent
		{
			get{return _UtmContent;}
			set
			{
				_UtmContent = value;
				OnPropertyChanged();
			}
		}
		private string _UtmMedium;
		[CProperty(ColumnPath ="UtmMedium")]
		public string UtmMedium
		{
			get{return _UtmMedium;}
			set
			{
				_UtmMedium = value;
				OnPropertyChanged();
			}
		}
		private string _UtmSource;
		[CProperty(ColumnPath ="UtmSource")]
		public string UtmSource
		{
			get{return _UtmSource;}
			set
			{
				_UtmSource = value;
				OnPropertyChanged();
			}
		}
		private string _UtmTerm;
		[CProperty(ColumnPath ="UtmTerm")]
		public string UtmTerm
		{
			get{return _UtmTerm;}
			set
			{
				_UtmTerm = value;
				OnPropertyChanged();
			}
		}
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
		[CProperty(Association ="VwLead:BulkEmailId")]
		public virtual ICollection<VwLead> VwLeadByBulkEmail { get; set; }
		[CProperty(Association ="VwMandrillRecipient:BulkEmailId")]
		public virtual ICollection<VwMandrillRecipient> VwMandrillRecipientByBulkEmail { get; set; }
		[CProperty(Association ="VwMandrillRecipientFilter:BulkEmailId")]
		public virtual ICollection<VwMandrillRecipientFilter> VwMandrillRecipientFilterByBulkEmail { get; set; }
		[CProperty(Association ="VwMandrillRecipientV2:BulkEmailId")]
		public virtual ICollection<VwMandrillRecipientV2> VwMandrillRecipientV2ByBulkEmail { get; set; }
		[CProperty(Association ="VwWorkMandrillRecip:BulkEmailId")]
		public virtual ICollection<VwWorkMandrillRecip> VwWorkMandrillRecipByBulkEmail { get; set; }
		#endregion
	}
}
