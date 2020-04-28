using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ManagersQuotesBySegment")]
	public class ManagersQuotesBySegment : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CashNB")]
		public decimal CashNB { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FullQuotaPercent")]
		public decimal FullQuotaPercent { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ManagerRoleId")]
		public Guid ManagerRoleId { get; set; }
		[CProperty(ColumnPath ="ManagerSegmentId")]
		public Guid ManagerSegmentId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="MonthNumber")]
		public int MonthNumber { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SMJVersionId")]
		public Guid SMJVersionId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="TsSalesCareerRole:ManagerRoleId")]
		public TsSalesCareerRole ManagerRole { get; set; }
		[CProperty(Navigation ="TsSalesCareerSegment:ManagerSegmentId")]
		public TsSalesCareerSegment ManagerSegment { get; set; }
		[CProperty(Navigation ="TsVersionSMJ:SMJVersionId")]
		public TsVersionSMJ SMJVersion { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
