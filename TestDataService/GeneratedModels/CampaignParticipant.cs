using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CampaignParticipant")]
	public class CampaignParticipant : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId { get; set; }
		[CProperty(ColumnPath ="CampaignItemId")]
		public Guid CampaignItemId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="StepCompleted")]
		public bool StepCompleted { get; set; }
		[CProperty(ColumnPath ="StepCompletedOn")]
		public DateTime StepCompletedOn { get; set; }
		[CProperty(ColumnPath ="StepModifiedOn")]
		public DateTime StepModifiedOn { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation ="CampaignItem:CampaignItemId")]
		public CampaignItem CampaignItem { get; set; }
		[CProperty(Navigation ="CmpgnParticipantStatus:StatusId")]
		public CmpgnParticipantStatus Status { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CampaignParticipantOp:CampaignParticipantId")]
		public virtual ICollection<CampaignParticipantOp> CampaignParticipantOpByCampaignParticipant { get; set; }
		[CProperty(Association ="CampaignQueue:CampaignParticipantId")]
		public virtual ICollection<CampaignQueue> CampaignQueueByCampaignParticipant { get; set; }
		#endregion
	}
}
