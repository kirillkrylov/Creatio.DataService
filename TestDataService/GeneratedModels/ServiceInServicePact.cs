using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ServiceInServicePact")]
	public class ServiceInServicePact : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId { get; set; }
		[CProperty(ColumnPath ="ConcatName")]
		public string ConcatName { get; set; }
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
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReactionTime")]
		public string ReactionTime { get; set; }
		[CProperty(ColumnPath ="ReactionTimeUnitId")]
		public Guid ReactionTimeUnitId { get; set; }
		[CProperty(ColumnPath ="ReactionTimeValue")]
		public int ReactionTimeValue { get; set; }
		[CProperty(ColumnPath ="ServiceItemId")]
		public Guid ServiceItemId { get; set; }
		[CProperty(ColumnPath ="ServicePactId")]
		public Guid ServicePactId { get; set; }
		[CProperty(ColumnPath ="SolutionTime")]
		public string SolutionTime { get; set; }
		[CProperty(ColumnPath ="SolutionTimeUnitId")]
		public Guid SolutionTimeUnitId { get; set; }
		[CProperty(ColumnPath ="SolutionTimeValue")]
		public int SolutionTimeValue { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Calendar:CalendarId")]
		public Calendar Calendar { get; set; }
		[CProperty(Navigation ="CasePriority:PriorityId")]
		public CasePriority Priority { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemId")]
		public ServiceItem ServiceItem { get; set; }
		[CProperty(Navigation ="ServicePact:ServicePactId")]
		public ServicePact ServicePact { get; set; }
		[CProperty(Navigation ="ServiceStatus:StatusId")]
		public ServiceStatus Status { get; set; }
		[CProperty(Navigation ="TimeUnit:ReactionTimeUnitId")]
		public TimeUnit ReactionTimeUnit { get; set; }
		[CProperty(Navigation ="TimeUnit:SolutionTimeUnitId")]
		public TimeUnit SolutionTimeUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="TimeToPrioritize:ServiceInServicePactId")]
		public virtual ICollection<TimeToPrioritize> TimeToPrioritizeByServiceInServicePact { get; set; }
		#endregion
	}
}
