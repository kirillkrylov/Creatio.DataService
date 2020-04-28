using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Partnership")]
	public class Partnership : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="CertifiedEmployees")]
		public int CertifiedEmployees { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InvestmentScoreId")]
		public Guid InvestmentScoreId { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PartneBoardMember")]
		public bool PartneBoardMember { get; set; }
		[CProperty(ColumnPath ="PartnerLeads")]
		public int PartnerLeads { get; set; }
		[CProperty(ColumnPath ="PartnerLevelId")]
		public Guid PartnerLevelId { get; set; }
		[CProperty(ColumnPath ="PartnershipKindId")]
		public Guid PartnershipKindId { get; set; }
		[CProperty(ColumnPath ="PartnershipStatusId")]
		public Guid PartnershipStatusId { get; set; }
		[CProperty(ColumnPath ="PartnerTypeId")]
		public Guid PartnerTypeId { get; set; }
		[CProperty(ColumnPath ="PMMId")]
		public Guid PMMId { get; set; }
		[CProperty(ColumnPath ="POManagerId")]
		public Guid POManagerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RenewalRate")]
		public decimal RenewalRate { get; set; }
		[CProperty(ColumnPath ="SalesQualifiedPartner")]
		public bool SalesQualifiedPartner { get; set; }
		[CProperty(ColumnPath ="ScoreLeft")]
		public int ScoreLeft { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="TotalSales")]
		public decimal TotalSales { get; set; }
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
