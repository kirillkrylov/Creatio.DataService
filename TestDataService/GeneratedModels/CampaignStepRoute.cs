using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CampaignStepRoute")]
	public class CampaignStepRoute : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="JSON")]
		public string JSON { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SourceStepId")]
		public Guid SourceStepId { get; set; }
		[CProperty(ColumnPath ="TargetStepId")]
		public Guid TargetStepId { get; set; }
		[CProperty(ColumnPath ="Title")]
		public string Title { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CampaignStep:SourceStepId")]
		public CampaignStep SourceStep { get; set; }
		[CProperty(Navigation ="CampaignStep:TargetStepId")]
		public CampaignStep TargetStep { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
