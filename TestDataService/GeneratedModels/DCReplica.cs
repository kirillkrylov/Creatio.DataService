using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DCReplica")]
	public class DCReplica : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="Content")]
		public string Content { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DCTemplateId")]
		public Guid DCTemplateId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Mask")]
		public int Mask { get; set; }
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
		[CProperty(Navigation ="DCTemplate:DCTemplateId")]
		public DCTemplate DCTemplate { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BulkEmailRecipientReplica:DCReplicaId")]
		public virtual ICollection<BulkEmailRecipientReplica> BulkEmailRecipientReplicaByDCReplica { get; set; }
		[CProperty(Association ="BulkEmailReplicaHeaders:DCReplicaId")]
		public virtual ICollection<BulkEmailReplicaHeaders> BulkEmailReplicaHeadersByDCReplica { get; set; }
		[CProperty(Association ="DCBlockInReplica:DCReplicaId")]
		public virtual ICollection<DCBlockInReplica> DCBlockInReplicaByDCReplica { get; set; }
		[CProperty(Association ="DCRecipient:DCReplicaId")]
		public virtual ICollection<DCRecipient> DCRecipientByDCReplica { get; set; }
		#endregion
	}
}
