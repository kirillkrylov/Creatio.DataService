using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PortalUserRoleInRegion")]
	public class PortalUserRoleInRegion : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountRoleId")]
		public Guid AccountRoleId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="End")]
		public bool End { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Number")]
		public int Number { get; set; }
		[CProperty(ColumnPath ="PartnerRoleId")]
		public Guid PartnerRoleId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:RegionId")]
		public OpportunityTerritory Region { get; set; }
		[CProperty(Navigation ="SysAdminUnit:PartnerRoleId")]
		public SysAdminUnit PartnerRole { get; set; }
		[CProperty(Navigation ="SysAdminUnit:AccountRoleId")]
		public SysAdminUnit AccountRole { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
