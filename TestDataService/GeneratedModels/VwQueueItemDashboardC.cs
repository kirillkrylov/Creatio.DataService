using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwQueueItemDashboardC")]
	public class VwQueueItemDashboardC : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AttemptsToCall")]
		public int AttemptsToCall { get; set; }
		[CProperty(ColumnPath ="ContactName")]
		public string ContactName { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FirstActivityDate")]
		public DateTime FirstActivityDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="LastActivityContact")]
		public string LastActivityContact { get; set; }
		[CProperty(ColumnPath ="LastActivityCreatedOn")]
		public DateTime LastActivityCreatedOn { get; set; }
		[CProperty(ColumnPath ="LastActivityDetailedResult")]
		public string LastActivityDetailedResult { get; set; }
		[CProperty(ColumnPath ="LastActivityResult")]
		public string LastActivityResult { get; set; }
		[CProperty(ColumnPath ="NextProcessingDate")]
		public DateTime NextProcessingDate { get; set; }
		[CProperty(ColumnPath ="OperatorName")]
		public string OperatorName { get; set; }
		[CProperty(ColumnPath ="QueueId")]
		public Guid QueueId { get; set; }
		[CProperty(ColumnPath ="QueueItemStatusId")]
		public Guid QueueItemStatusId { get; set; }
		[CProperty(ColumnPath ="ReactionWorkTime")]
		public int ReactionWorkTime { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="Queue:QueueId")]
		public Queue Queue { get; set; }
		[CProperty(Navigation ="QueueItemStatus:QueueItemStatusId")]
		public QueueItemStatus QueueItemStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
