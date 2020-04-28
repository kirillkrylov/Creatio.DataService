using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MailboxSyncSettings")]
	public class MailboxSyncSettings : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActualizeMessageRelations")]
		public bool ActualizeMessageRelations { get; set; }
		[CProperty(ColumnPath ="AutomaticallyAddNewEmails")]
		public bool AutomaticallyAddNewEmails { get; set; }
		[CProperty(ColumnPath ="ContactSyncInterval")]
		public int ContactSyncInterval { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CyclicallyAddNewEmails")]
		public bool CyclicallyAddNewEmails { get; set; }
		[CProperty(ColumnPath ="EmailsCyclicallyAddingInterval")]
		public int EmailsCyclicallyAddingInterval { get; set; }
		[CProperty(ColumnPath ="EnableMailSynhronization")]
		public bool EnableMailSynhronization { get; set; }
		[CProperty(ColumnPath ="ErrorCodeId")]
		public Guid ErrorCodeId { get; set; }
		[CProperty(ColumnPath ="ExchangeAutoSyncActivity")]
		public bool ExchangeAutoSyncActivity { get; set; }
		[CProperty(ColumnPath ="ExchangeAutoSynchronization")]
		public bool ExchangeAutoSynchronization { get; set; }
		[CProperty(ColumnPath ="ExchangeSyncInterval")]
		public int ExchangeSyncInterval { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsAnonymousAuthentication")]
		public bool IsAnonymousAuthentication { get; set; }
		[CProperty(ColumnPath ="IsCustomFlagsNotSuported")]
		public bool IsCustomFlagsNotSuported { get; set; }
		[CProperty(ColumnPath ="IsDefault")]
		public bool IsDefault { get; set; }
		[CProperty(ColumnPath ="IsShared")]
		public bool IsShared { get; set; }
		[CProperty(ColumnPath ="LastError")]
		public string LastError { get; set; }
		[CProperty(ColumnPath ="LastSyncDate")]
		public DateTime LastSyncDate { get; set; }
		[CProperty(ColumnPath ="LoadAllEmailsFromMailBox")]
		public bool LoadAllEmailsFromMailBox { get; set; }
		[CProperty(ColumnPath ="LoadEmailsFromDate")]
		public DateTime LoadEmailsFromDate { get; set; }
		[CProperty(ColumnPath ="MailboxName")]
		public string MailboxName { get; set; }
		[CProperty(ColumnPath ="MailServerId")]
		public Guid MailServerId { get; set; }
		[CProperty(ColumnPath ="MailSyncPeriodId")]
		public Guid MailSyncPeriodId { get; set; }
		[CProperty(ColumnPath ="MessageLanguageId")]
		public Guid MessageLanguageId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OAuthTokenStorageId")]
		public Guid OAuthTokenStorageId { get; set; }
		[CProperty(ColumnPath ="PersonalMetrics")]
		public bool PersonalMetrics { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RetryCounter")]
		public int RetryCounter { get; set; }
		[CProperty(ColumnPath ="SendEmailsViaThisAccount")]
		public bool SendEmailsViaThisAccount { get; set; }
		[CProperty(ColumnPath ="SenderDisplayValue")]
		public string SenderDisplayValue { get; set; }
		[CProperty(ColumnPath ="SenderEmailAddress")]
		public string SenderEmailAddress { get; set; }
		[CProperty(ColumnPath ="SendWebsocketNotifications")]
		public bool SendWebsocketNotifications { get; set; }
		[CProperty(ColumnPath ="Signature")]
		public string Signature { get; set; }
		[CProperty(ColumnPath ="SyncDateMinutesOffset")]
		public int SyncDateMinutesOffset { get; set; }
		[CProperty(ColumnPath ="SynchronizationStopped")]
		public bool SynchronizationStopped { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId { get; set; }
		[CProperty(ColumnPath ="UserName")]
		public string UserName { get; set; }
		[CProperty(ColumnPath ="UseSignature")]
		public bool UseSignature { get; set; }
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
