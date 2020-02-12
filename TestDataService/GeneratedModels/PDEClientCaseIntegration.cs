using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PDEClientCaseIntegration")]
	public class PDEClientCaseIntegration : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="PDECommentary")]
		public string PDECommentary { get; set; }
		[CProperty(ColumnPath ="PDEIntegrationWithId")]
		public Guid PDEIntegrationWithId { get; set; }
		[CProperty(ColumnPath ="PDEIsImplemented")]
		public bool PDEIsImplemented { get; set; }
		[CProperty(ColumnPath ="PDEKnowledgeBaseId")]
		public Guid PDEKnowledgeBaseId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="KnowledgeBase:PDEKnowledgeBaseId")]
		public KnowledgeBase PDEKnowledgeBase { get; set; }
		[CProperty(Navigation ="PDESystemForIntegration:PDEIntegrationWithId")]
		public PDESystemForIntegration PDEIntegrationWith { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
