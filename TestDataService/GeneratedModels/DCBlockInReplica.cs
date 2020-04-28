using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DCBlockInReplica")]
	public class DCBlockInReplica : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DCReplicaId")]
		public Guid DCReplicaId { get; set; }
		[CProperty(ColumnPath ="DCTemplateBlockId")]
		public Guid DCTemplateBlockId { get; set; }
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DCReplica:DCReplicaId")]
		public DCReplica DCReplica { get; set; }
		[CProperty(Navigation ="DCTemplateBlock:DCTemplateBlockId")]
		public DCTemplateBlock DCTemplateBlock { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
