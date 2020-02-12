using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "INFLUTargetsStats")]
	public class INFLUTargetsStats : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="INFLUCampaignId")]
		public string INFLUCampaignId { get; set; }
		[CProperty(ColumnPath ="INFLUCampaignName")]
		public string INFLUCampaignName { get; set; }
		[CProperty(ColumnPath ="INFLUCampaignStatus")]
		public string INFLUCampaignStatus { get; set; }
		[CProperty(ColumnPath ="INFLUClicks")]
		public int INFLUClicks { get; set; }
		[CProperty(ColumnPath ="INFLUContactId")]
		public Guid INFLUContactId { get; set; }
		[CProperty(ColumnPath ="INFLUViews")]
		public int INFLUViews { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:INFLUContactId")]
		public Contact INFLUContact { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
