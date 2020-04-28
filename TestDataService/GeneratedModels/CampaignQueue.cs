using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CampaignQueue")]
	public class CampaignQueue : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CampaignItemId")]
		public Guid CampaignItemId { get; set; }
		[CProperty(ColumnPath ="CampaignParticipantId")]
		public Guid CampaignParticipantId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ExpirationPeriod")]
		public int ExpirationPeriod { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CampaignItem:CampaignItemId")]
		public CampaignItem CampaignItem { get; set; }
		[CProperty(Navigation ="CampaignParticipant:CampaignParticipantId")]
		public CampaignParticipant CampaignParticipant { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
