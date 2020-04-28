using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CampaignPlanner")]
	public class CampaignPlanner : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BrandId")]
		public Guid BrandId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PlannedBudget")]
		public decimal PlannedBudget { get; set; }
		[CProperty(ColumnPath ="PrimaryPlannedBudget")]
		public decimal PrimaryPlannedBudget { get; set; }
		[CProperty(ColumnPath ="PrimarySpentBudget")]
		public decimal PrimarySpentBudget { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SpentBudget")]
		public decimal SpentBudget { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Brand:BrandId")]
		public Brand Brand { get; set; }
		[CProperty(Navigation ="CampaignPlannerStatus:StatusId")]
		public CampaignPlannerStatus Status { get; set; }
		[CProperty(Navigation ="CampaignPlannerType:TypeId")]
		public CampaignPlannerType Type { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CampaignPlannerFile:CampaignPlannerId")]
		public virtual ICollection<CampaignPlannerFile> CampaignPlannerFileByCampaignPlanner { get; set; }
		[CProperty(Association ="CampaignPlannerInFolder:CampaignPlannerId")]
		public virtual ICollection<CampaignPlannerInFolder> CampaignPlannerInFolderByCampaignPlanner { get; set; }
		[CProperty(Association ="CampaignPlannerInTag:EntityId")]
		public virtual ICollection<CampaignPlannerInTag> CampaignPlannerInTagByEntity { get; set; }
		[CProperty(Association ="MktgActivity:CampaignPlannerId")]
		public virtual ICollection<MktgActivity> MktgActivityByCampaignPlanner { get; set; }
		#endregion
	}
}
