using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Investor")]
	public class Investor : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="AUM")]
		public decimal AUM { get; set; }
		[CProperty(ColumnPath ="CheckSize")]
		public string CheckSize { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CulturalFit")]
		public string CulturalFit { get; set; }
		[CProperty(ColumnPath ="EnterpriseExperience")]
		public string EnterpriseExperience { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OverallPriorityId")]
		public Guid OverallPriorityId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="StrengthOfNetwork")]
		public string StrengthOfNetwork { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="InvestorPriority:OverallPriorityId")]
		public InvestorPriority OverallPriority { get; set; }
		[CProperty(Navigation ="InvestorStatus:StatusId")]
		public InvestorStatus Status { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:InvestorId")]
		public virtual ICollection<Activity> ActivityByInvestor { get; set; }
		[CProperty(Association ="InvestorComment:InvestorId")]
		public virtual ICollection<InvestorComment> InvestorCommentByInvestor { get; set; }
		[CProperty(Association ="InvestorFile:InvestorId")]
		public virtual ICollection<InvestorFile> InvestorFileByInvestor { get; set; }
		[CProperty(Association ="InvestorInFolder:InvestorId")]
		public virtual ICollection<InvestorInFolder> InvestorInFolderByInvestor { get; set; }
		[CProperty(Association ="InvestorInTag:EntityId")]
		public virtual ICollection<InvestorInTag> InvestorInTagByEntity { get; set; }
		#endregion
	}
}
