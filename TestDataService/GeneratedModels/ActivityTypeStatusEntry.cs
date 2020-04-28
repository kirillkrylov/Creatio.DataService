using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ActivityTypeStatusEntry")]
	public class ActivityTypeStatusEntry : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActivityStatusId")]
		public Guid ActivityStatusId { get; set; }
		[CProperty(ColumnPath ="ActivityTypeId")]
		public Guid ActivityTypeId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
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
		[CProperty(Navigation ="ActivityStatus:ActivityStatusId")]
		public ActivityStatus ActivityStatus { get; set; }
		[CProperty(Navigation ="ActivityType:ActivityTypeId")]
		public ActivityType ActivityType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
