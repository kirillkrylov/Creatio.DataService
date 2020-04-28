using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CampaignStep")]
	public class CampaignStep : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="JSON")]
		public string JSON { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordId")]
		public Guid RecordId { get; set; }
		[CProperty(ColumnPath ="Title")]
		public string Title { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation ="CampaignStepType:TypeId")]
		public CampaignStepType Type { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CampaignStepRoute:SourceStepId")]
		public virtual ICollection<CampaignStepRoute> CampaignStepRouteBySourceStep { get; set; }
		[CProperty(Association ="CampaignStepRoute:TargetStepId")]
		public virtual ICollection<CampaignStepRoute> CampaignStepRouteByTargetStep { get; set; }
		[CProperty(Association ="CampaignTarget:CurrentStepId")]
		public virtual ICollection<CampaignTarget> CampaignTargetByCurrentStep { get; set; }
		[CProperty(Association ="CampaignTarget:NextStepId")]
		public virtual ICollection<CampaignTarget> CampaignTargetByNextStep { get; set; }
		[CProperty(Association ="CampaignTarget:PassedStepId")]
		public virtual ICollection<CampaignTarget> CampaignTargetByPassedStep { get; set; }
		#endregion
	}
}
