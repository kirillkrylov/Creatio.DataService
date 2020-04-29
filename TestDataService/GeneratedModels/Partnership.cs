using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Partnership")]
	public class Partnership : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private int _CertifiedEmployees;
		[CProperty(ColumnPath ="CertifiedEmployees")]
		public int CertifiedEmployees
		{
			get{return _CertifiedEmployees;}
			set
			{
				_CertifiedEmployees = value;
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
		private DateTime _DueDate;
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate
		{
			get{return _DueDate;}
			set
			{
				_DueDate = value;
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
		private Guid _InvestmentScoreId;
		[CProperty(ColumnPath ="InvestmentScoreId")]
		public Guid InvestmentScoreId
		{
			get{return _InvestmentScoreId;}
			set
			{
				_InvestmentScoreId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsActive;
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive
		{
			get{return _IsActive;}
			set
			{
				_IsActive = value;
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
		private bool _PartneBoardMember;
		[CProperty(ColumnPath ="PartneBoardMember")]
		public bool PartneBoardMember
		{
			get{return _PartneBoardMember;}
			set
			{
				_PartneBoardMember = value;
				OnPropertyChanged();
			}
		}
		private int _PartnerLeads;
		[CProperty(ColumnPath ="PartnerLeads")]
		public int PartnerLeads
		{
			get{return _PartnerLeads;}
			set
			{
				_PartnerLeads = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerLevelId;
		[CProperty(ColumnPath ="PartnerLevelId")]
		public Guid PartnerLevelId
		{
			get{return _PartnerLevelId;}
			set
			{
				_PartnerLevelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnershipKindId;
		[CProperty(ColumnPath ="PartnershipKindId")]
		public Guid PartnershipKindId
		{
			get{return _PartnershipKindId;}
			set
			{
				_PartnershipKindId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnershipStatusId;
		[CProperty(ColumnPath ="PartnershipStatusId")]
		public Guid PartnershipStatusId
		{
			get{return _PartnershipStatusId;}
			set
			{
				_PartnershipStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerTypeId;
		[CProperty(ColumnPath ="PartnerTypeId")]
		public Guid PartnerTypeId
		{
			get{return _PartnerTypeId;}
			set
			{
				_PartnerTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PMMId;
		[CProperty(ColumnPath ="PMMId")]
		public Guid PMMId
		{
			get{return _PMMId;}
			set
			{
				_PMMId = value;
				OnPropertyChanged();
			}
		}
		private Guid _POManagerId;
		[CProperty(ColumnPath ="POManagerId")]
		public Guid POManagerId
		{
			get{return _POManagerId;}
			set
			{
				_POManagerId = value;
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
		private decimal _RenewalRate;
		[CProperty(ColumnPath ="RenewalRate")]
		public decimal RenewalRate
		{
			get{return _RenewalRate;}
			set
			{
				_RenewalRate = value;
				OnPropertyChanged();
			}
		}
		private bool _SalesQualifiedPartner;
		[CProperty(ColumnPath ="SalesQualifiedPartner")]
		public bool SalesQualifiedPartner
		{
			get{return _SalesQualifiedPartner;}
			set
			{
				_SalesQualifiedPartner = value;
				OnPropertyChanged();
			}
		}
		private int _ScoreLeft;
		[CProperty(ColumnPath ="ScoreLeft")]
		public int ScoreLeft
		{
			get{return _ScoreLeft;}
			set
			{
				_ScoreLeft = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
		private decimal _TotalSales;
		[CProperty(ColumnPath ="TotalSales")]
		public decimal TotalSales
		{
			get{return _TotalSales;}
			set
			{
				_TotalSales = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:POManagerId")]
		public Contact POManager { get; set; }
		[CProperty(Navigation ="Contact:PMMId")]
		public Contact PMM { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="InvestmentScore:InvestmentScoreId")]
		public InvestmentScore InvestmentScore { get; set; }
		[CProperty(Navigation ="PartnerLevel:PartnerLevelId")]
		public PartnerLevel PartnerLevel { get; set; }
		[CProperty(Navigation ="PartnershipKind:PartnershipKindId")]
		public PartnershipKind PartnershipKind { get; set; }
		[CProperty(Navigation ="PartnershipStatus:PartnershipStatusId")]
		public PartnershipStatus PartnershipStatus { get; set; }
		[CProperty(Navigation ="PartnerType:PartnerTypeId")]
		public PartnerType PartnerType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:PartnershipId")]
		public virtual ICollection<Activity> ActivityByPartnership { get; set; }
		[CProperty(Association ="Fund:PartnershipId")]
		public virtual ICollection<Fund> FundByPartnership { get; set; }
		[CProperty(Association ="KeyPartnerContact:PartnershipId")]
		public virtual ICollection<KeyPartnerContact> KeyPartnerContactByPartnership { get; set; }
		[CProperty(Association ="MktgActivity:PartnershipId")]
		public virtual ICollection<MktgActivity> MktgActivityByPartnership { get; set; }
		[CProperty(Association ="PartnerDomain:PartnershipId")]
		public virtual ICollection<PartnerDomain> PartnerDomainByPartnership { get; set; }
		[CProperty(Association ="PartnerParamHistory:PartnershipId")]
		public virtual ICollection<PartnerParamHistory> PartnerParamHistoryByPartnership { get; set; }
		[CProperty(Association ="PartnershipFile:PartnershipId")]
		public virtual ICollection<PartnershipFile> PartnershipFileByPartnership { get; set; }
		[CProperty(Association ="PartnershipInFolder:PartnershipId")]
		public virtual ICollection<PartnershipInFolder> PartnershipInFolderByPartnership { get; set; }
		[CProperty(Association ="PartnershipInTag:EntityId")]
		public virtual ICollection<PartnershipInTag> PartnershipInTagByEntity { get; set; }
		[CProperty(Association ="PartnershipParameter:PartnershipId")]
		public virtual ICollection<PartnershipParameter> PartnershipParameterByPartnership { get; set; }
		[CProperty(Association ="PartnershipVisa:PartnershipId")]
		public virtual ICollection<PartnershipVisa> PartnershipVisaByPartnership { get; set; }
		[CProperty(Association ="PRMTransaction:PartnershipId")]
		public virtual ICollection<PRMTransaction> PRMTransactionByPartnership { get; set; }
		[CProperty(Association ="PRMTransactionHistory:PartnershipId")]
		public virtual ICollection<PRMTransactionHistory> PRMTransactionHistoryByPartnership { get; set; }
		[CProperty(Association ="RegionalLanguagePartner:PartnershipId")]
		public virtual ICollection<RegionalLanguagePartner> RegionalLanguagePartnerByPartnership { get; set; }
		#endregion
	}
}
