using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MailboxSyncSettings")]
	public class MailboxSyncSettings : BaseEntity
	{
		#region Values
		private bool _ActualizeMessageRelations;
		[CProperty(ColumnPath ="ActualizeMessageRelations")]
		public bool ActualizeMessageRelations
		{
			get{return _ActualizeMessageRelations;}
			set
			{
				_ActualizeMessageRelations = value;
				OnPropertyChanged();
			}
		}
		private bool _AutomaticallyAddNewEmails;
		[CProperty(ColumnPath ="AutomaticallyAddNewEmails")]
		public bool AutomaticallyAddNewEmails
		{
			get{return _AutomaticallyAddNewEmails;}
			set
			{
				_AutomaticallyAddNewEmails = value;
				OnPropertyChanged();
			}
		}
		private int _ContactSyncInterval;
		[CProperty(ColumnPath ="ContactSyncInterval")]
		public int ContactSyncInterval
		{
			get{return _ContactSyncInterval;}
			set
			{
				_ContactSyncInterval = value;
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
		private bool _CyclicallyAddNewEmails;
		[CProperty(ColumnPath ="CyclicallyAddNewEmails")]
		public bool CyclicallyAddNewEmails
		{
			get{return _CyclicallyAddNewEmails;}
			set
			{
				_CyclicallyAddNewEmails = value;
				OnPropertyChanged();
			}
		}
		private int _EmailsCyclicallyAddingInterval;
		[CProperty(ColumnPath ="EmailsCyclicallyAddingInterval")]
		public int EmailsCyclicallyAddingInterval
		{
			get{return _EmailsCyclicallyAddingInterval;}
			set
			{
				_EmailsCyclicallyAddingInterval = value;
				OnPropertyChanged();
			}
		}
		private bool _EnableMailSynhronization;
		[CProperty(ColumnPath ="EnableMailSynhronization")]
		public bool EnableMailSynhronization
		{
			get{return _EnableMailSynhronization;}
			set
			{
				_EnableMailSynhronization = value;
				OnPropertyChanged();
			}
		}
		private Guid _ErrorCodeId;
		[CProperty(ColumnPath ="ErrorCodeId")]
		public Guid ErrorCodeId
		{
			get{return _ErrorCodeId;}
			set
			{
				_ErrorCodeId = value;
				OnPropertyChanged();
			}
		}
		private bool _ExchangeAutoSyncActivity;
		[CProperty(ColumnPath ="ExchangeAutoSyncActivity")]
		public bool ExchangeAutoSyncActivity
		{
			get{return _ExchangeAutoSyncActivity;}
			set
			{
				_ExchangeAutoSyncActivity = value;
				OnPropertyChanged();
			}
		}
		private bool _ExchangeAutoSynchronization;
		[CProperty(ColumnPath ="ExchangeAutoSynchronization")]
		public bool ExchangeAutoSynchronization
		{
			get{return _ExchangeAutoSynchronization;}
			set
			{
				_ExchangeAutoSynchronization = value;
				OnPropertyChanged();
			}
		}
		private int _ExchangeSyncInterval;
		[CProperty(ColumnPath ="ExchangeSyncInterval")]
		public int ExchangeSyncInterval
		{
			get{return _ExchangeSyncInterval;}
			set
			{
				_ExchangeSyncInterval = value;
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
		private bool _IsAnonymousAuthentication;
		[CProperty(ColumnPath ="IsAnonymousAuthentication")]
		public bool IsAnonymousAuthentication
		{
			get{return _IsAnonymousAuthentication;}
			set
			{
				_IsAnonymousAuthentication = value;
				OnPropertyChanged();
			}
		}
		private bool _IsCustomFlagsNotSuported;
		[CProperty(ColumnPath ="IsCustomFlagsNotSuported")]
		public bool IsCustomFlagsNotSuported
		{
			get{return _IsCustomFlagsNotSuported;}
			set
			{
				_IsCustomFlagsNotSuported = value;
				OnPropertyChanged();
			}
		}
		private bool _IsDefault;
		[CProperty(ColumnPath ="IsDefault")]
		public bool IsDefault
		{
			get{return _IsDefault;}
			set
			{
				_IsDefault = value;
				OnPropertyChanged();
			}
		}
		private bool _IsShared;
		[CProperty(ColumnPath ="IsShared")]
		public bool IsShared
		{
			get{return _IsShared;}
			set
			{
				_IsShared = value;
				OnPropertyChanged();
			}
		}
		private string _LastError;
		[CProperty(ColumnPath ="LastError")]
		public string LastError
		{
			get{return _LastError;}
			set
			{
				_LastError = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LastSyncDate;
		[CProperty(ColumnPath ="LastSyncDate")]
		public DateTime LastSyncDate
		{
			get{return _LastSyncDate;}
			set
			{
				_LastSyncDate = value;
				OnPropertyChanged();
			}
		}
		private bool _LoadAllEmailsFromMailBox;
		[CProperty(ColumnPath ="LoadAllEmailsFromMailBox")]
		public bool LoadAllEmailsFromMailBox
		{
			get{return _LoadAllEmailsFromMailBox;}
			set
			{
				_LoadAllEmailsFromMailBox = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LoadEmailsFromDate;
		[CProperty(ColumnPath ="LoadEmailsFromDate")]
		public DateTime LoadEmailsFromDate
		{
			get{return _LoadEmailsFromDate;}
			set
			{
				_LoadEmailsFromDate = value;
				OnPropertyChanged();
			}
		}
		private string _MailboxName;
		[CProperty(ColumnPath ="MailboxName")]
		public string MailboxName
		{
			get{return _MailboxName;}
			set
			{
				_MailboxName = value;
				OnPropertyChanged();
			}
		}
		private Guid _MailServerId;
		[CProperty(ColumnPath ="MailServerId")]
		public Guid MailServerId
		{
			get{return _MailServerId;}
			set
			{
				_MailServerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _MailSyncPeriodId;
		[CProperty(ColumnPath ="MailSyncPeriodId")]
		public Guid MailSyncPeriodId
		{
			get{return _MailSyncPeriodId;}
			set
			{
				_MailSyncPeriodId = value;
				OnPropertyChanged();
			}
		}
		private Guid _MessageLanguageId;
		[CProperty(ColumnPath ="MessageLanguageId")]
		public Guid MessageLanguageId
		{
			get{return _MessageLanguageId;}
			set
			{
				_MessageLanguageId = value;
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
		private Guid _OAuthTokenStorageId;
		[CProperty(ColumnPath ="OAuthTokenStorageId")]
		public Guid OAuthTokenStorageId
		{
			get{return _OAuthTokenStorageId;}
			set
			{
				_OAuthTokenStorageId = value;
				OnPropertyChanged();
			}
		}
		private bool _PersonalMetrics;
		[CProperty(ColumnPath ="PersonalMetrics")]
		public bool PersonalMetrics
		{
			get{return _PersonalMetrics;}
			set
			{
				_PersonalMetrics = value;
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
		private int _RetryCounter;
		[CProperty(ColumnPath ="RetryCounter")]
		public int RetryCounter
		{
			get{return _RetryCounter;}
			set
			{
				_RetryCounter = value;
				OnPropertyChanged();
			}
		}
		private bool _SendEmailsViaThisAccount;
		[CProperty(ColumnPath ="SendEmailsViaThisAccount")]
		public bool SendEmailsViaThisAccount
		{
			get{return _SendEmailsViaThisAccount;}
			set
			{
				_SendEmailsViaThisAccount = value;
				OnPropertyChanged();
			}
		}
		private string _SenderDisplayValue;
		[CProperty(ColumnPath ="SenderDisplayValue")]
		public string SenderDisplayValue
		{
			get{return _SenderDisplayValue;}
			set
			{
				_SenderDisplayValue = value;
				OnPropertyChanged();
			}
		}
		private string _SenderEmailAddress;
		[CProperty(ColumnPath ="SenderEmailAddress")]
		public string SenderEmailAddress
		{
			get{return _SenderEmailAddress;}
			set
			{
				_SenderEmailAddress = value;
				OnPropertyChanged();
			}
		}
		private bool _SendWebsocketNotifications;
		[CProperty(ColumnPath ="SendWebsocketNotifications")]
		public bool SendWebsocketNotifications
		{
			get{return _SendWebsocketNotifications;}
			set
			{
				_SendWebsocketNotifications = value;
				OnPropertyChanged();
			}
		}
		private string _Signature;
		[CProperty(ColumnPath ="Signature")]
		public string Signature
		{
			get{return _Signature;}
			set
			{
				_Signature = value;
				OnPropertyChanged();
			}
		}
		private int _SyncDateMinutesOffset;
		[CProperty(ColumnPath ="SyncDateMinutesOffset")]
		public int SyncDateMinutesOffset
		{
			get{return _SyncDateMinutesOffset;}
			set
			{
				_SyncDateMinutesOffset = value;
				OnPropertyChanged();
			}
		}
		private bool _SynchronizationStopped;
		[CProperty(ColumnPath ="SynchronizationStopped")]
		public bool SynchronizationStopped
		{
			get{return _SynchronizationStopped;}
			set
			{
				_SynchronizationStopped = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysAdminUnitId;
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId
		{
			get{return _SysAdminUnitId;}
			set
			{
				_SysAdminUnitId = value;
				OnPropertyChanged();
			}
		}
		private string _UserName;
		[CProperty(ColumnPath ="UserName")]
		public string UserName
		{
			get{return _UserName;}
			set
			{
				_UserName = value;
				OnPropertyChanged();
			}
		}
		private bool _UseSignature;
		[CProperty(ColumnPath ="UseSignature")]
		public bool UseSignature
		{
			get{return _UseSignature;}
			set
			{
				_UseSignature = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MailServer:MailServerId")]
		public MailServer MailServer { get; set; }
		[CProperty(Navigation ="MailSyncPeriod:MailSyncPeriodId")]
		public MailSyncPeriod MailSyncPeriod { get; set; }
		[CProperty(Navigation ="OAuthTokenStorage:OAuthTokenStorageId")]
		public OAuthTokenStorage OAuthTokenStorage { get; set; }
		[CProperty(Navigation ="SyncErrorMessage:ErrorCodeId")]
		public SyncErrorMessage ErrorCode { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		[CProperty(Navigation ="SysLanguage:MessageLanguageId")]
		public SysLanguage MessageLanguage { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ActivitySyncSettings:MailboxSyncSettingsId")]
		public virtual ICollection<ActivitySyncSettings> ActivitySyncSettingsByMailboxSyncSettings { get; set; }
		[CProperty(Association ="ContactSyncSettings:MailboxSyncSettingsId")]
		public virtual ICollection<ContactSyncSettings> ContactSyncSettingsByMailboxSyncSettings { get; set; }
		[CProperty(Association ="EmailDefRights:RecordId")]
		public virtual ICollection<EmailDefRights> EmailDefRightsByRecord { get; set; }
		[CProperty(Association ="MailboxContactFolder:MailboxSyncSettingsId")]
		public virtual ICollection<MailboxContactFolder> MailboxContactFolderByMailboxSyncSettings { get; set; }
		[CProperty(Association ="MailboxFoldersCorrespondence:MailboxId")]
		public virtual ICollection<MailboxFoldersCorrespondence> MailboxFoldersCorrespondenceByMailbox { get; set; }
		[CProperty(Association ="MailboxForIncidentRegistration:MailboxSyncSettingsId")]
		public virtual ICollection<MailboxForIncidentRegistration> MailboxForIncidentRegistrationByMailboxSyncSettings { get; set; }
		[CProperty(Association ="MailboxSettingsFile:MailboxSyncSettingsId")]
		public virtual ICollection<MailboxSettingsFile> MailboxSettingsFileByMailboxSyncSettings { get; set; }
		[CProperty(Association ="PartnershipServiceEmail:EmailId")]
		public virtual ICollection<PartnershipServiceEmail> PartnershipServiceEmailByEmail { get; set; }
		#endregion
	}
}
