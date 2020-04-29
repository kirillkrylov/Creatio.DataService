using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Applicant")]
	public class Applicant : BaseEntity
	{
		#region Values
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _CurrentAccountId;
		[CProperty(ColumnPath ="CurrentAccountId")]
		public Guid CurrentAccountId
		{
			get{return _CurrentAccountId;}
			set
			{
				_CurrentAccountId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CurrentJobId;
		[CProperty(ColumnPath ="CurrentJobId")]
		public Guid CurrentJobId
		{
			get{return _CurrentJobId;}
			set
			{
				_CurrentJobId = value;
				OnPropertyChanged();
			}
		}
		private string _CurrentWageLevel;
		[CProperty(ColumnPath ="CurrentWageLevel")]
		public string CurrentWageLevel
		{
			get{return _CurrentWageLevel;}
			set
			{
				_CurrentWageLevel = value;
				OnPropertyChanged();
			}
		}
		private string _Email;
		[CProperty(ColumnPath ="Email")]
		public string Email
		{
			get{return _Email;}
			set
			{
				_Email = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmployeeId;
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId
		{
			get{return _EmployeeId;}
			set
			{
				_EmployeeId = value;
				OnPropertyChanged();
			}
		}
		private string _ExpectedWageLevel;
		[CProperty(ColumnPath ="ExpectedWageLevel")]
		public string ExpectedWageLevel
		{
			get{return _ExpectedWageLevel;}
			set
			{
				_ExpectedWageLevel = value;
				OnPropertyChanged();
			}
		}
		private Guid _ExpertiseLevelId;
		[CProperty(ColumnPath ="ExpertiseLevelId")]
		public Guid ExpertiseLevelId
		{
			get{return _ExpertiseLevelId;}
			set
			{
				_ExpertiseLevelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _InternalRequestId;
		[CProperty(ColumnPath ="InternalRequestId")]
		public Guid InternalRequestId
		{
			get{return _InternalRequestId;}
			set
			{
				_InternalRequestId = value;
				OnPropertyChanged();
			}
		}
		private Guid _JobId;
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId
		{
			get{return _JobId;}
			set
			{
				_JobId = value;
				OnPropertyChanged();
			}
		}
		private string _Linkedin;
		[CProperty(ColumnPath ="Linkedin")]
		public string Linkedin
		{
			get{return _Linkedin;}
			set
			{
				_Linkedin = value;
				OnPropertyChanged();
			}
		}
		private Guid _MarketId;
		[CProperty(ColumnPath ="MarketId")]
		public Guid MarketId
		{
			get{return _MarketId;}
			set
			{
				_MarketId = value;
				OnPropertyChanged();
			}
		}
		private string _MobilePhone;
		[CProperty(ColumnPath ="MobilePhone")]
		public string MobilePhone
		{
			get{return _MobilePhone;}
			set
			{
				_MobilePhone = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private Guid _OfficeId;
		[CProperty(ColumnPath ="OfficeId")]
		public Guid OfficeId
		{
			get{return _OfficeId;}
			set
			{
				_OfficeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private Guid _RejectReasonId;
		[CProperty(ColumnPath ="RejectReasonId")]
		public Guid RejectReasonId
		{
			get{return _RejectReasonId;}
			set
			{
				_RejectReasonId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SegmentId;
		[CProperty(ColumnPath ="SegmentId")]
		public Guid SegmentId
		{
			get{return _SegmentId;}
			set
			{
				_SegmentId = value;
				OnPropertyChanged();
			}
		}
		private string _Skype;
		[CProperty(ColumnPath ="Skype")]
		public string Skype
		{
			get{return _Skype;}
			set
			{
				_Skype = value;
				OnPropertyChanged();
			}
		}
		private Guid _SourceId;
		[CProperty(ColumnPath ="SourceId")]
		public Guid SourceId
		{
			get{return _SourceId;}
			set
			{
				_SourceId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageId;
		[CProperty(ColumnPath ="StageId")]
		public Guid StageId
		{
			get{return _StageId;}
			set
			{
				_StageId = value;
				OnPropertyChanged();
			}
		}
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
