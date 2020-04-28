using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MatchingRule")]
	public class MatchingRule : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Order")]
		public int Order { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SyncObjectId")]
		public Guid SyncObjectId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SyncObject:SyncObjectId")]
		public SyncObject SyncObject { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="MatchingRuleColumn:MatchingRuleId")]
		public virtual ICollection<MatchingRuleColumn> MatchingRuleColumnByMatchingRule { get; set; }
		[CProperty(Association ="VwSyncColumn:MatchingRuleId")]
		public virtual ICollection<VwSyncColumn> VwSyncColumnByMatchingRule { get; set; }
		#endregion
	}
}
