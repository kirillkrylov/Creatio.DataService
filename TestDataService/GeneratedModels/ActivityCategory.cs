using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ActivityCategory")]
	public class ActivityCategory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActivityTypeId")]
		public Guid ActivityTypeId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="ActivityType:ActivityTypeId")]
		public ActivityType ActivityType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:ActivityCategoryId")]
		public virtual ICollection<Activity> ActivityByActivityCategory { get; set; }
		[CProperty(Association ="ActivityCategoryResultEntry:ActivityCategoryId")]
		public virtual ICollection<ActivityCategoryResultEntry> ActivityCategoryResultEntryByActivityCategory { get; set; }
		[CProperty(Association ="ActivityKind:ActivityCategoryId")]
		public virtual ICollection<ActivityKind> ActivityKindByActivityCategory { get; set; }
		#endregion
	}
}
