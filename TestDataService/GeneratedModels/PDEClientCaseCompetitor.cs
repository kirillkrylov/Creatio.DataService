using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PDEClientCaseCompetitor")]
	public class PDEClientCaseCompetitor : BaseEntity
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
		[CProperty(ColumnPath ="PDEClientNeedId")]
		public Guid PDEClientNeedId { get; set; }
		[CProperty(ColumnPath ="PDECommentary")]
		public string PDECommentary { get; set; }
		[CProperty(ColumnPath ="PDECompetitorId")]
		public Guid PDECompetitorId { get; set; }
		[CProperty(ColumnPath ="PDEKnowledgeBaseId")]
		public Guid PDEKnowledgeBaseId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:PDECompetitorId")]
		public Account PDECompetitor { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="KnowledgeBase:PDEKnowledgeBaseId")]
		public KnowledgeBase PDEKnowledgeBase { get; set; }
		[CProperty(Navigation ="PDEClientCaseNeed:PDEClientNeedId")]
		public PDEClientCaseNeed PDEClientNeed { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
