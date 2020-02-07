using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysAdminUnit")]
	public class SysAdminUnit : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="Active")]
		public bool Active { get; set; }
		[CProperty(ColumnPath ="ConnectionType")]
		public int ConnectionType { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DateTimeFormatId")]
		public Guid DateTimeFormatId { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="ForceChangePassword")]
		public bool ForceChangePassword { get; set; }
		[CProperty(ColumnPath ="HomePageId")]
		public Guid HomePageId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsDirectoryEntry")]
		public bool IsDirectoryEntry { get; set; }
		[CProperty(ColumnPath ="LDAPElementId")]
		public Guid LDAPElementId { get; set; }
		[CProperty(ColumnPath ="LDAPEntry")]
		public string LDAPEntry { get; set; }
		[CProperty(ColumnPath ="LDAPEntryDN")]
		public string LDAPEntryDN { get; set; }
		[CProperty(ColumnPath ="LDAPEntryId")]
		public string LDAPEntryId { get; set; }
		[CProperty(ColumnPath ="LoggedIn")]
		public bool LoggedIn { get; set; }
		[CProperty(ColumnPath ="LoginAttemptCount")]
		public int LoginAttemptCount { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ParentRoleId")]
		public Guid ParentRoleId { get; set; }
		[CProperty(ColumnPath ="PasswordExpireDate")]
		public DateTime PasswordExpireDate { get; set; }
		[CProperty(ColumnPath ="PortalAccountId")]
		public Guid PortalAccountId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SessionTimeout")]
		public int SessionTimeout { get; set; }
		[CProperty(ColumnPath ="SourceControlLogin")]
		public string SourceControlLogin { get; set; }
		[CProperty(ColumnPath ="SynchronizeWithLDAP")]
		public bool SynchronizeWithLDAP { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitTypeValue")]
		public int SysAdminUnitTypeValue { get; set; }
		[CProperty(ColumnPath ="SysCultureId")]
		public Guid SysCultureId { get; set; }
		[CProperty(ColumnPath ="TimeZoneId")]
		public string TimeZoneId { get; set; }
		[CProperty(ColumnPath ="UnblockTime")]
		public DateTime UnblockTime { get; set; }
		[CProperty(ColumnPath ="UserPassword")]
		public string UserPassword { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Account:PortalAccountId")]
		public Account PortalAccount { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="LDAPElement:LDAPElementId")]
		public LDAPElement LDAPElement { get; set; }
		[CProperty(Navigation ="SysAdminUnit:ParentRoleId")]
		public SysAdminUnit ParentRole { get; set; }
		[CProperty(Navigation ="SysCulture:SysCultureId")]
		public SysCulture SysCulture { get; set; }
		[CProperty(Navigation ="SysLanguage:DateTimeFormatId")]
		public SysLanguage DateTimeFormat { get; set; }
		[CProperty(Navigation ="SysModule:HomePageId")]
		public SysModule HomePage { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AdminUnitFeatureState:SysAdminUnitId")]
		public virtual ICollection<AdminUnitFeatureState> AdminUnitFeatureStateBySysAdminUnit { get; set; }
		[CProperty(Association ="Calendar:UserId")]
		public virtual ICollection<Calendar> CalendarByUser { get; set; }
		[CProperty(Association ="Case:GroupId")]
		public virtual ICollection<Case> CaseByGroup { get; set; }
		[CProperty(Association ="CaseLifecycle:GroupId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByGroup { get; set; }
		[CProperty(Association ="Change:GroupId")]
		public virtual ICollection<Change> ChangeByGroup { get; set; }
		[CProperty(Association ="ContractVisa:VisaOwnerId")]
		public virtual ICollection<ContractVisa> ContractVisaByVisaOwner { get; set; }
		[CProperty(Association ="ContractVisa:DelegatedFromId")]
		public virtual ICollection<ContractVisa> ContractVisaByDelegatedFrom { get; set; }
		[CProperty(Association ="DocumentVisa:VisaOwnerId")]
		public virtual ICollection<DocumentVisa> DocumentVisaByVisaOwner { get; set; }
		[CProperty(Association ="DocumentVisa:DelegatedFromId")]
		public virtual ICollection<DocumentVisa> DocumentVisaByDelegatedFrom { get; set; }
		[CProperty(Association ="EmailDefRights:SysAdminUnitId")]
		public virtual ICollection<EmailDefRights> EmailDefRightsBySysAdminUnit { get; set; }
		[CProperty(Association ="FolderFavorite:SysAdminUnitId")]
		public virtual ICollection<FolderFavorite> FolderFavoriteBySysAdminUnit { get; set; }
		[CProperty(Association ="InvoiceVisa:VisaOwnerId")]
		public virtual ICollection<InvoiceVisa> InvoiceVisaByVisaOwner { get; set; }
		[CProperty(Association ="InvoiceVisa:DelegatedFromId")]
		public virtual ICollection<InvoiceVisa> InvoiceVisaByDelegatedFrom { get; set; }
		[CProperty(Association ="MailboxSyncSettings:SysAdminUnitId")]
		public virtual ICollection<MailboxSyncSettings> MailboxSyncSettingsBySysAdminUnit { get; set; }
		[CProperty(Association ="MultiDeleteQueue:SysAdminUnitId")]
		public virtual ICollection<MultiDeleteQueue> MultiDeleteQueueBySysAdminUnit { get; set; }
		[CProperty(Association ="OAuthApplications:SharedUserId")]
		public virtual ICollection<OAuthApplications> OAuthApplicationsBySharedUser { get; set; }
		[CProperty(Association ="OAuthTokenStorage:SysUserId")]
		public virtual ICollection<OAuthTokenStorage> OAuthTokenStorageBySysUser { get; set; }
		[CProperty(Association ="OpportunityDepartment:SysAdminUnitId")]
		public virtual ICollection<OpportunityDepartment> OpportunityDepartmentBySysAdminUnit { get; set; }
		[CProperty(Association ="OpportunityVisa:VisaOwnerId")]
		public virtual ICollection<OpportunityVisa> OpportunityVisaByVisaOwner { get; set; }
		[CProperty(Association ="OpportunityVisa:DelegatedFromId")]
		public virtual ICollection<OpportunityVisa> OpportunityVisaByDelegatedFrom { get; set; }
		[CProperty(Association ="OptionalFuncSspRole:OrgRoleId")]
		public virtual ICollection<OptionalFuncSspRole> OptionalFuncSspRoleByOrgRole { get; set; }
		[CProperty(Association ="OptionalFuncSspRole:FuncRoleId")]
		public virtual ICollection<OptionalFuncSspRole> OptionalFuncSspRoleByFuncRole { get; set; }
		[CProperty(Association ="OrderVisa:VisaOwnerId")]
		public virtual ICollection<OrderVisa> OrderVisaByVisaOwner { get; set; }
		[CProperty(Association ="OrderVisa:DelegatedFromId")]
		public virtual ICollection<OrderVisa> OrderVisaByDelegatedFrom { get; set; }
		[CProperty(Association ="OrganizationProperty:SysAdminUnitId")]
		public virtual ICollection<OrganizationProperty> OrganizationPropertyBySysAdminUnit { get; set; }
		[CProperty(Association ="Problem:GroupId")]
		public virtual ICollection<Problem> ProblemByGroup { get; set; }
		[CProperty(Association ="PushNotificationToken:SysAdminUnitId")]
		public virtual ICollection<PushNotificationToken> PushNotificationTokenBySysAdminUnit { get; set; }
		[CProperty(Association ="QuickAddMenuSettings:SysAdminUnitId")]
		public virtual ICollection<QuickAddMenuSettings> QuickAddMenuSettingsBySysAdminUnit { get; set; }
		[CProperty(Association ="ReleaseTeam:ResponsibleId")]
		public virtual ICollection<ReleaseTeam> ReleaseTeamByResponsible { get; set; }
		[CProperty(Association ="ServiceEngineer:EngineerId")]
		public virtual ICollection<ServiceEngineer> ServiceEngineerByEngineer { get; set; }
		[CProperty(Association ="SocialAccount:UserId")]
		public virtual ICollection<SocialAccount> SocialAccountByUser { get; set; }
		[CProperty(Association ="SocialChannelPublisher:SysAdminUnitId")]
		public virtual ICollection<SocialChannelPublisher> SocialChannelPublisherBySysAdminUnit { get; set; }
		[CProperty(Association ="SocialFeedFavoriteTpl:SysAdminUnitId")]
		public virtual ICollection<SocialFeedFavoriteTpl> SocialFeedFavoriteTplBySysAdminUnit { get; set; }
		[CProperty(Association ="SocialLike:UserId")]
		public virtual ICollection<SocialLike> SocialLikeByUser { get; set; }
		[CProperty(Association ="SocialSubscription:SysAdminUnitId")]
		public virtual ICollection<SocialSubscription> SocialSubscriptionBySysAdminUnit { get; set; }
		[CProperty(Association ="SocialUnsubscription:SysAdminUnitId")]
		public virtual ICollection<SocialUnsubscription> SocialUnsubscriptionBySysAdminUnit { get; set; }
		[CProperty(Association ="SysAdminOperationGrantee:SysAdminUnitId")]
		public virtual ICollection<SysAdminOperationGrantee> SysAdminOperationGranteeBySysAdminUnit { get; set; }
		[CProperty(Association ="SysAdminUnit:ParentRoleId")]
		public virtual ICollection<SysAdminUnit> SysAdminUnitByParentRole { get; set; }
		[CProperty(Association ="SysAdminUnitInFolder:SysAdminUnitId")]
		public virtual ICollection<SysAdminUnitInFolder> SysAdminUnitInFolderBySysAdminUnit { get; set; }
		[CProperty(Association ="SysAdminUnitInWorkplace:SysAdminUnitId")]
		public virtual ICollection<SysAdminUnitInWorkplace> SysAdminUnitInWorkplaceBySysAdminUnit { get; set; }
		[CProperty(Association ="SysAdminUnitIPRange:SysAdminUnitId")]
		public virtual ICollection<SysAdminUnitIPRange> SysAdminUnitIPRangeBySysAdminUnit { get; set; }
		[CProperty(Association ="SysFuncRoleInOrgRole:OrgRoleId")]
		public virtual ICollection<SysFuncRoleInOrgRole> SysFuncRoleInOrgRoleByOrgRole { get; set; }
		[CProperty(Association ="SysFuncRoleInOrgRole:FuncRoleId")]
		public virtual ICollection<SysFuncRoleInOrgRole> SysFuncRoleInOrgRoleByFuncRole { get; set; }
		[CProperty(Association ="SysMsgUserSettings:UserId")]
		public virtual ICollection<SysMsgUserSettings> SysMsgUserSettingsByUser { get; set; }
		[CProperty(Association ="SysProfileData:SysUserId")]
		public virtual ICollection<SysProfileData> SysProfileDataBySysUser { get; set; }
		[CProperty(Association ="SysRecentEntity:SysUserId")]
		public virtual ICollection<SysRecentEntity> SysRecentEntityBySysUser { get; set; }
		[CProperty(Association ="SysRegistrationData:SysAdminUnitId")]
		public virtual ICollection<SysRegistrationData> SysRegistrationDataBySysAdminUnit { get; set; }
		[CProperty(Association ="SysRoleInMobWorkplace:SysRoleId")]
		public virtual ICollection<SysRoleInMobWorkplace> SysRoleInMobWorkplaceBySysRole { get; set; }
		[CProperty(Association ="SysSchema:LockedById")]
		public virtual ICollection<SysSchema> SysSchemaByLockedBy { get; set; }
		[CProperty(Association ="SysUserInRole:SysUserId")]
		public virtual ICollection<SysUserInRole> SysUserInRoleBySysUser { get; set; }
		[CProperty(Association ="SysUserInRole:SysRoleId")]
		public virtual ICollection<SysUserInRole> SysUserInRoleBySysRole { get; set; }
		[CProperty(Association ="SysUserSession:SysUserId")]
		public virtual ICollection<SysUserSession> SysUserSessionBySysUser { get; set; }
		[CProperty(Association ="tsaTerm:tsaTermOwnerTeamAcaId")]
		public virtual ICollection<tsaTerm> tsaTermBytsaTermOwnerTeamAca { get; set; }
		[CProperty(Association ="tsaTerm:tsaTermOwnerTeamRnDId")]
		public virtual ICollection<tsaTerm> tsaTermBytsaTermOwnerTeamRnD { get; set; }
		[CProperty(Association ="tsaTermVisa:VisaOwnerId")]
		public virtual ICollection<tsaTermVisa> tsaTermVisaByVisaOwner { get; set; }
		[CProperty(Association ="tsaTermVisa:DelegatedFromId")]
		public virtual ICollection<tsaTermVisa> tsaTermVisaByDelegatedFrom { get; set; }
		[CProperty(Association ="VwEmployeesHierarchy:ManagerUserId")]
		public virtual ICollection<VwEmployeesHierarchy> VwEmployeesHierarchyByManagerUser { get; set; }
		[CProperty(Association ="VwOAuthAppUser:SysUserId")]
		public virtual ICollection<VwOAuthAppUser> VwOAuthAppUserBySysUser { get; set; }
		[CProperty(Association ="VwRemindingsCount:SysAdminUnitId")]
		public virtual ICollection<VwRemindingsCount> VwRemindingsCountBySysAdminUnit { get; set; }
		[CProperty(Association ="VwSocialSubscription:SysAdminUnitId")]
		public virtual ICollection<VwSocialSubscription> VwSocialSubscriptionBySysAdminUnit { get; set; }
		[CProperty(Association ="VwSocialUnsubscription:SysAdminUnitId")]
		public virtual ICollection<VwSocialUnsubscription> VwSocialUnsubscriptionBySysAdminUnit { get; set; }
		[CProperty(Association ="VwSysAdminUnit:SysAdminUnitId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitBySysAdminUnit { get; set; }
		[CProperty(Association ="VwUserEmailsCount:SysAdminUnitId")]
		public virtual ICollection<VwUserEmailsCount> VwUserEmailsCountBySysAdminUnit { get; set; }
		[CProperty(Association ="VwUserRemindingsCount:SysAdminUnitId")]
		public virtual ICollection<VwUserRemindingsCount> VwUserRemindingsCountBySysAdminUnit { get; set; }
		[CProperty(Association ="VwVisa:VisaOwnerId")]
		public virtual ICollection<VwVisa> VwVisaByVisaOwner { get; set; }
		[CProperty(Association ="VwVisa:DelegatedFromId")]
		public virtual ICollection<VwVisa> VwVisaByDelegatedFrom { get; set; }
		#endregion
	}
}
