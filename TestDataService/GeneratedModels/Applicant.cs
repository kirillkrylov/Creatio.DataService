using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Applicant")]
	public class Applicant : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrentAccountId")]
		public Guid CurrentAccountId { get; set; }
		[CProperty(ColumnPath ="CurrentJobId")]
		public Guid CurrentJobId { get; set; }
		[CProperty(ColumnPath ="CurrentWageLevel")]
		public string CurrentWageLevel { get; set; }
		[CProperty(ColumnPath ="Email")]
		public string Email { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath ="ExpectedWageLevel")]
		public string ExpectedWageLevel { get; set; }
		[CProperty(ColumnPath ="ExpertiseLevelId")]
		public Guid ExpertiseLevelId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InternalRequestId")]
		public Guid InternalRequestId { get; set; }
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId { get; set; }
		[CProperty(ColumnPath ="Linkedin")]
		public string Linkedin { get; set; }
		[CProperty(ColumnPath ="MarketId")]
		public Guid MarketId { get; set; }
		[CProperty(ColumnPath ="MobilePhone")]
		public string MobilePhone { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OfficeId")]
		public Guid OfficeId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RejectReasonId")]
		public Guid RejectReasonId { get; set; }
		[CProperty(ColumnPath ="SegmentId")]
		public Guid SegmentId { get; set; }
		[CProperty(ColumnPath ="Skype")]
		public string Skype { get; set; }
		[CProperty(ColumnPath ="SourceId")]
		public Guid SourceId { get; set; }
		[CProperty(ColumnPath ="StageId")]
		public Guid StageId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:CurrentAccountId")]
		public Account CurrentAccount { get; set; }
		[CProperty(Navigation ="ApplicantSource:SourceId")]
		public ApplicantSource Source { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="CountryCodes:OfficeId")]
		public CountryCodes Office { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="EmployeeJob:JobId")]
		public EmployeeJob Job { get; set; }
		[CProperty(Navigation ="ExpertiseLevel:ExpertiseLevelId")]
		public ExpertiseLevel ExpertiseLevel { get; set; }
		[CProperty(Navigation ="InternalRequest:InternalRequestId")]
		public InternalRequest InternalRequest { get; set; }
		[CProperty(Navigation ="Job:CurrentJobId")]
		public Job CurrentJob { get; set; }
		[CProperty(Navigation ="OfferRejectReason:RejectReasonId")]
		public OfferRejectReason RejectReason { get; set; }
		[CProperty(Navigation ="RecruitmentStage:StageId")]
		public RecruitmentStage Stage { get; set; }
		[CProperty(Navigation ="TsSalesCareerMarket:MarketId")]
		public TsSalesCareerMarket Market { get; set; }
		[CProperty(Navigation ="TsSalesCareerSegment:SegmentId")]
		public TsSalesCareerSegment Segment { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:ApplicantId")]
		public virtual ICollection<Activity> ActivityByApplicant { get; set; }
		[CProperty(Association ="ApplicantFile:ApplicantId")]
		public virtual ICollection<ApplicantFile> ApplicantFileByApplicant { get; set; }
		[CProperty(Association ="ApplicantInFolder:ApplicantId")]
		public virtual ICollection<ApplicantInFolder> ApplicantInFolderByApplicant { get; set; }
		[CProperty(Association ="ApplicantInTag:EntityId")]
		public virtual ICollection<ApplicantInTag> ApplicantInTagByEntity { get; set; }
		[CProperty(Association ="ApplicantVisa:ApplicantId")]
		public virtual ICollection<ApplicantVisa> ApplicantVisaByApplicant { get; set; }
		[CProperty(Association ="RecruitmentInStage:RootEntityId")]
		public virtual ICollection<RecruitmentInStage> RecruitmentInStageByRootEntity { get; set; }
		#endregion
	}
}
