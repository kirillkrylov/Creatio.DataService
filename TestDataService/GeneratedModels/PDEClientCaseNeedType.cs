using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PDEClientCaseNeedType")]
	public class PDEClientCaseNeedType : BaseEntity
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
		#endregion

		#region Associations
		[CProperty(Association ="PDEClientCaseNeed:PDENeedTypeId")]
		public virtual ICollection<PDEClientCaseNeed> PDEClientCaseNeedByPDENeedType { get; set; }
		[CProperty(Association ="PDEClientNeedInKnowledgeBase:PDENeedTypeId")]
		public virtual ICollection<PDEClientNeedInKnowledgeBase> PDEClientNeedInKnowledgeBaseByPDENeedType { get; set; }
		[CProperty(Association ="PDECustomerNeedInCustomer:PDENeedTypeId")]
		public virtual ICollection<PDECustomerNeedInCustomer> PDECustomerNeedInCustomerByPDENeedType { get; set; }
		[CProperty(Association ="PDECustomerNeedInOpportunity:PDENeedTypeId")]
		public virtual ICollection<PDECustomerNeedInOpportunity> PDECustomerNeedInOpportunityByPDENeedType { get; set; }
		[CProperty(Association ="PDECustomerNeedInReference:PDENeedTypeId")]
		public virtual ICollection<PDECustomerNeedInReference> PDECustomerNeedInReferenceByPDENeedType { get; set; }
		#endregion
	}
}
