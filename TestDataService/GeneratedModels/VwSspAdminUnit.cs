using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSspAdminUnit")]
	public class VwSspAdminUnit : BaseEntity
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
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="LicenseName")]
		public string LicenseName { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ParentRoleId")]
		public Guid ParentRoleId { get; set; }
		[CProperty(ColumnPath ="PortalAccountId")]
		public Guid PortalAccountId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitTypeId")]
		public Guid SysAdminUnitTypeId { get; set; }
		[CProperty(ColumnPath ="SysCultureId")]
		public Guid SysCultureId { get; set; }
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
		[CProperty(Navigation ="SysAdminUnitType:SysAdminUnitTypeId")]
		public SysAdminUnitType SysAdminUnitType { get; set; }
		[CProperty(Navigation ="SysCulture:SysCultureId")]
		public SysCulture SysCulture { get; set; }
		[CProperty(Navigation ="VwSspAdminUnit:ParentRoleId")]
		public VwSspAdminUnit ParentRole { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="VwSspAdminUnit:ParentRoleId")]
		public virtual ICollection<VwSspAdminUnit> VwSspAdminUnitByParentRole { get; set; }
		#endregion
	}
}
