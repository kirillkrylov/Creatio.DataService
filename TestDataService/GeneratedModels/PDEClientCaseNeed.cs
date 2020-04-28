using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PDEClientCaseNeed")]
	public class PDEClientCaseNeed : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="PDENeedTypeId")]
		public Guid PDENeedTypeId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="PDEClientCaseNeedType:PDENeedTypeId")]
		public PDEClientCaseNeedType PDENeedType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="PDEClientCaseCompetitor:PDEClientNeedId")]
		public virtual ICollection<PDEClientCaseCompetitor> PDEClientCaseCompetitorByPDEClientNeed { get; set; }
		[CProperty(Association ="PDEClientCaseMigration:PDEClientNeedId")]
		public virtual ICollection<PDEClientCaseMigration> PDEClientCaseMigrationByPDEClientNeed { get; set; }
		[CProperty(Association ="PDEClientNeedInKnowledgeBase:PDEClientNeedId")]
		public virtual ICollection<PDEClientNeedInKnowledgeBase> PDEClientNeedInKnowledgeBaseByPDEClientNeed { get; set; }
		[CProperty(Association ="PDECustomerNeedInCustomer:PDECustomerNeedId")]
		public virtual ICollection<PDECustomerNeedInCustomer> PDECustomerNeedInCustomerByPDECustomerNeed { get; set; }
		[CProperty(Association ="PDECustomerNeedInOpportunity:PDECustomerNeedId")]
		public virtual ICollection<PDECustomerNeedInOpportunity> PDECustomerNeedInOpportunityByPDECustomerNeed { get; set; }
		[CProperty(Association ="PDECustomerNeedInReference:PDECustomerNeedId")]
		public virtual ICollection<PDECustomerNeedInReference> PDECustomerNeedInReferenceByPDECustomerNeed { get; set; }
		#endregion
	}
}
