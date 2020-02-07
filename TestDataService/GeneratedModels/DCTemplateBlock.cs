using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DCTemplateBlock")]
	public class DCTemplateBlock : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DCTemplateGroupId")]
		public Guid DCTemplateGroupId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="Index")]
		public int Index { get; set; }
		[CProperty(ColumnPath ="IsDefault")]
		public bool IsDefault { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Priority")]
		public int Priority { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DCTemplateGroup:DCTemplateGroupId")]
		public DCTemplateGroup DCTemplateGroup { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DCAttributeInBlock:DCTemplateBlockId")]
		public virtual ICollection<DCAttributeInBlock> DCAttributeInBlockByDCTemplateBlock { get; set; }
		[CProperty(Association ="DCBlockInReplica:DCTemplateBlockId")]
		public virtual ICollection<DCBlockInReplica> DCBlockInReplicaByDCTemplateBlock { get; set; }
		#endregion
	}
}
