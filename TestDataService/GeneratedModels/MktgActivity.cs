using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MktgActivity")]
	public class MktgActivity : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CampaignPlannerId")]
		public Guid CampaignPlannerId { get; set; }
		[CProperty(ColumnPath ="ChannelId")]
		public Guid ChannelId { get; set; }
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
		public Guid Id { get; set; }
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="CampaignPlanner:CampaignPlannerId")]
		public CampaignPlanner CampaignPlanner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="LeadMedium:ChannelId")]
		public LeadMedium Channel { get; set; }
		[CProperty(Navigation ="MktgActivityStatus:StatusId")]
		public MktgActivityStatus Status { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="MktgActivityFile:MktgActivityId")]
		public virtual ICollection<MktgActivityFile> MktgActivityFileByMktgActivity { get; set; }
		[CProperty(Association ="MktgActivityInFolder:MktgActivityId")]
		public virtual ICollection<MktgActivityInFolder> MktgActivityInFolderByMktgActivity { get; set; }
		[CProperty(Association ="MktgActivityInTag:EntityId")]
		public virtual ICollection<MktgActivityInTag> MktgActivityInTagByEntity { get; set; }
		#endregion
	}
}
