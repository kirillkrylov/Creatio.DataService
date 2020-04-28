using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsSalesCareerSegment")]
	public class TsSalesCareerSegment : BaseEntity
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
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Applicant:SegmentId")]
		public virtual ICollection<Applicant> ApplicantBySegment { get; set; }
		[CProperty(Association ="BonusRates:SalesCareerSegmentId")]
		public virtual ICollection<BonusRates> BonusRatesBySalesCareerSegment { get; set; }
		[CProperty(Association ="InternalRequest:SegmentId")]
		public virtual ICollection<InternalRequest> InternalRequestBySegment { get; set; }
		[CProperty(Association ="ManagersQuotesBySegment:ManagerSegmentId")]
		public virtual ICollection<ManagersQuotesBySegment> ManagersQuotesBySegmentByManagerSegment { get; set; }
		[CProperty(Association ="OrgStructureUnit:SegmentId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitBySegment { get; set; }
		[CProperty(Association ="SMHealthCheck:SegmentId")]
		public virtual ICollection<SMHealthCheck> SMHealthCheckBySegment { get; set; }
		[CProperty(Association ="TsSalesCareer:SegmentId")]
		public virtual ICollection<TsSalesCareer> TsSalesCareerBySegment { get; set; }
		[CProperty(Association ="VwTsSalesCareer:SegmentId")]
		public virtual ICollection<VwTsSalesCareer> VwTsSalesCareerBySegment { get; set; }
		#endregion
	}
}
