using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PDEClientNeedInKnowledgeBase")]
	public class PDEClientNeedInKnowledgeBase : BaseEntity
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
		[CProperty(ColumnPath ="PDEKnowledgeBaseId")]
		public Guid PDEKnowledgeBaseId { get; set; }
		[CProperty(ColumnPath ="PDENeedTypeId")]
		public Guid PDENeedTypeId { get; set; }
		[CProperty(ColumnPath ="PDEPartnerId")]
		public Guid PDEPartnerId { get; set; }
		[CProperty(ColumnPath ="PDEProjectEndDate")]
		public DateTime PDEProjectEndDate { get; set; }
		[CProperty(ColumnPath ="PDEProjectStatusId")]
		public Guid PDEProjectStatusId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:PDEPartnerId")]
		public Account PDEPartner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="KnowledgeBase:PDEKnowledgeBaseId")]
		public KnowledgeBase PDEKnowledgeBase { get; set; }
		[CProperty(Navigation ="PDEClientCaseNeed:PDEClientNeedId")]
		public PDEClientCaseNeed PDEClientNeed { get; set; }
		[CProperty(Navigation ="PDEClientCaseNeedType:PDENeedTypeId")]
		public PDEClientCaseNeedType PDENeedType { get; set; }
		[CProperty(Navigation ="PDEClientCaseProjectStatus:PDEProjectStatusId")]
		public PDEClientCaseProjectStatus PDEProjectStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
