using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BonusRates")]
	public class BonusRates : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BonusPercent")]
		public decimal BonusPercent { get; set; }
		[CProperty(ColumnPath ="BonusRatio")]
		public decimal BonusRatio { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="LowerBoundaryOfQuartile")]
		public decimal LowerBoundaryOfQuartile { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SalesCareerRoleId")]
		public Guid SalesCareerRoleId { get; set; }
		[CProperty(ColumnPath ="SalesCareerSegmentId")]
		public Guid SalesCareerSegmentId { get; set; }
		[CProperty(ColumnPath ="TeamLeaderPercent")]
		public decimal TeamLeaderPercent { get; set; }
		[CProperty(ColumnPath ="UpperBoundaryOfQuartile")]
		public decimal UpperBoundaryOfQuartile { get; set; }
		[CProperty(ColumnPath ="VersionSMJId")]
		public Guid VersionSMJId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="TsSalesCareerRole:SalesCareerRoleId")]
		public TsSalesCareerRole SalesCareerRole { get; set; }
		[CProperty(Navigation ="TsSalesCareerSegment:SalesCareerSegmentId")]
		public TsSalesCareerSegment SalesCareerSegment { get; set; }
		[CProperty(Navigation ="TsVersionSMJ:VersionSMJId")]
		public TsVersionSMJ VersionSMJ { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
