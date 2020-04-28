using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LDAPElement")]
	public class LDAPElement : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Company")]
		public string Company { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="Email")]
		public string Email { get; set; }
		[CProperty(ColumnPath ="FullName")]
		public string FullName { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="JobTitle")]
		public string JobTitle { get; set; }
		[CProperty(ColumnPath ="LDAPEntryDN")]
		public string LDAPEntryDN { get; set; }
		[CProperty(ColumnPath ="LDAPEntryId")]
		public string LDAPEntryId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Phone")]
		public string Phone { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Type")]
		public int Type { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="LDAPUserInLDAPGroup:LDAPUserId")]
		public virtual ICollection<LDAPUserInLDAPGroup> LDAPUserInLDAPGroupByLDAPUser { get; set; }
		[CProperty(Association ="LDAPUserInLDAPGroup:LDAPGroupId")]
		public virtual ICollection<LDAPUserInLDAPGroup> LDAPUserInLDAPGroupByLDAPGroup { get; set; }
		[CProperty(Association ="SysAdminUnit:LDAPElementId")]
		public virtual ICollection<SysAdminUnit> SysAdminUnitByLDAPElement { get; set; }
		[CProperty(Association ="VwGroupSysAdminUnit:LDAPElementId")]
		public virtual ICollection<VwGroupSysAdminUnit> VwGroupSysAdminUnitByLDAPElement { get; set; }
		[CProperty(Association ="VwSysAdminUnit:LDAPElementId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitByLDAPElement { get; set; }
		#endregion
	}
}
