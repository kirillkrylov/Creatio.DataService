using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysAdminUnit")]
	public class VwSysAdminUnit : BaseEntity
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SessionTimeout")]
		public int SessionTimeout { get; set; }
		[CProperty(ColumnPath ="SynchronizeWithLDAP")]
		public bool SynchronizeWithLDAP { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitTypeId")]
		public Guid SysAdminUnitTypeId { get; set; }
		[CProperty(ColumnPath ="SysCultureId")]
		public Guid SysCultureId { get; set; }
		[CProperty(ColumnPath ="TimeZoneId")]
		public Guid TimeZoneId { get; set; }
		[CProperty(ColumnPath ="UserConnectionTypeId")]
		public Guid UserConnectionTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="ConnectionType:UserConnectionTypeId")]
		public ConnectionType UserConnectionType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="LDAPElement:LDAPElementId")]
		public LDAPElement LDAPElement { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		[CProperty(Navigation ="SysAdminUnitType:SysAdminUnitTypeId")]
		public SysAdminUnitType SysAdminUnitType { get; set; }
		[CProperty(Navigation ="SysCulture:SysCultureId")]
		public SysCulture SysCulture { get; set; }
		[CProperty(Navigation ="SysLanguage:DateTimeFormatId")]
		public SysLanguage DateTimeFormat { get; set; }
		[CProperty(Navigation ="SysModule:HomePageId")]
		public SysModule HomePage { get; set; }
		[CProperty(Navigation ="TimeZone:TimeZoneId")]
		public TimeZone TimeZone { get; set; }
		[CProperty(Navigation ="VwSysAdminUnit:ParentRoleId")]
		public VwSysAdminUnit ParentRole { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="IQAddRight:IQUserRoleId")]
		public virtual ICollection<IQAddRight> IQAddRightByIQUserRole { get; set; }
		[CProperty(Association ="IQGrantedRight:IQGrantorSysAdminUnitId")]
		public virtual ICollection<IQGrantedRight> IQGrantedRightByIQGrantorSysAdminUnit { get; set; }
		[CProperty(Association ="IQGrantedRight:IQGranteeSysAdminUnitId")]
		public virtual ICollection<IQGrantedRight> IQGrantedRightByIQGranteeSysAdminUnit { get; set; }
		[CProperty(Association ="IQLimitRight:IQUserRoleId")]
		public virtual ICollection<IQLimitRight> IQLimitRightByIQUserRole { get; set; }
		[CProperty(Association ="SysAdminUnitGrantedRight:GrantorSysAdminUnitId")]
		public virtual ICollection<SysAdminUnitGrantedRight> SysAdminUnitGrantedRightByGrantorSysAdminUnit { get; set; }
		[CProperty(Association ="SysAdminUnitGrantedRight:GranteeSysAdminUnitId")]
		public virtual ICollection<SysAdminUnitGrantedRight> SysAdminUnitGrantedRightByGranteeSysAdminUnit { get; set; }
		[CProperty(Association ="SysEntitySchemaOperationRight:SysAdminUnitId")]
		public virtual ICollection<SysEntitySchemaOperationRight> SysEntitySchemaOperationRightBySysAdminUnit { get; set; }
		[CProperty(Association ="SysExtServiceOperationRight:SysAdminUnitId")]
		public virtual ICollection<SysExtServiceOperationRight> SysExtServiceOperationRightBySysAdminUnit { get; set; }
		[CProperty(Association ="VwSysAdminUnit:ParentRoleId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitByParentRole { get; set; }
		[CProperty(Association ="VwSysEntitySchemaColumnRight:SysAdminUnitId")]
		public virtual ICollection<VwSysEntitySchemaColumnRight> VwSysEntitySchemaColumnRightBySysAdminUnit { get; set; }
		#endregion
	}
}
