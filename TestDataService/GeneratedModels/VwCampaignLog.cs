using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwCampaignLog")]
	public class VwCampaignLog : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActionId")]
		public Guid ActionId { get; set; }
		[CProperty(ColumnPath ="Amount")]
		public int Amount { get; set; }
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId { get; set; }
		[CProperty(ColumnPath ="CampaignItemId")]
		public Guid CampaignItemId { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DurationMi")]
		public int DurationMi { get; set; }
		[CProperty(ColumnPath ="DurationSs")]
		public int DurationSs { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
		[CProperty(ColumnPath ="ErrorText")]
		public string ErrorText { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ScheduledDate")]
		public DateTime ScheduledDate { get; set; }
		[CProperty(ColumnPath ="SessionId")]
		public Guid SessionId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation ="CampaignItem:CampaignItemId")]
		public CampaignItem CampaignItem { get; set; }
		[CProperty(Navigation ="CampaignLogItemType:ActionId")]
		public CampaignLogItemType Action { get; set; }
		[CProperty(Navigation ="CampaignLogStatus:StatusId")]
		public CampaignLogStatus Status { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
