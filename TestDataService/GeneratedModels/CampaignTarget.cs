using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CampaignTarget")]
	public class CampaignTarget : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId { get; set; }
		[CProperty(ColumnPath ="CampaignTargetStatusId")]
		public Guid CampaignTargetStatusId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrentStepId")]
		public Guid CurrentStepId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsFromGroup")]
		public bool IsFromGroup { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NextStepId")]
		public Guid NextStepId { get; set; }
		[CProperty(ColumnPath ="PassedStepId")]
		public Guid PassedStepId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation ="CampaignStep:CurrentStepId")]
		public CampaignStep CurrentStep { get; set; }
		[CProperty(Navigation ="CampaignStep:NextStepId")]
		public CampaignStep NextStep { get; set; }
		[CProperty(Navigation ="CampaignStep:PassedStepId")]
		public CampaignStep PassedStep { get; set; }
		[CProperty(Navigation ="CampaignTargetStatus:CampaignTargetStatusId")]
		public CampaignTargetStatus CampaignTargetStatus { get; set; }
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
