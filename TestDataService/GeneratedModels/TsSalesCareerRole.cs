using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsSalesCareerRole")]
	public class TsSalesCareerRole : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BonusRates:SalesCareerRoleId")]
		public virtual ICollection<BonusRates> BonusRatesBySalesCareerRole { get; set; }
		[CProperty(Association ="ManagersQuotesBySegment:ManagerRoleId")]
		public virtual ICollection<ManagersQuotesBySegment> ManagersQuotesBySegmentByManagerRole { get; set; }
		[CProperty(Association ="OrgStructureUnit:RoleId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByRole { get; set; }
		[CProperty(Association ="TsSalesCareer:ManagerRoleId")]
		public virtual ICollection<TsSalesCareer> TsSalesCareerByManagerRole { get; set; }
		[CProperty(Association ="VwTsSalesCareer:ManagerRoleId")]
		public virtual ICollection<VwTsSalesCareer> VwTsSalesCareerByManagerRole { get; set; }
		#endregion
	}
}
