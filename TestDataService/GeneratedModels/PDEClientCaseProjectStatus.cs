using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PDEClientCaseProjectStatus")]
	public class PDEClientCaseProjectStatus : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
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
		[CProperty(Association ="KnowledgeBase:PDEProjectStatusId")]
		public virtual ICollection<KnowledgeBase> KnowledgeBaseByPDEProjectStatus { get; set; }
		[CProperty(Association ="PDEClientNeedInKnowledgeBase:PDEProjectStatusId")]
		public virtual ICollection<PDEClientNeedInKnowledgeBase> PDEClientNeedInKnowledgeBaseByPDEProjectStatus { get; set; }
		[CProperty(Association ="PDECustomerNeedInCustomer:PDEProjectStatusId")]
		public virtual ICollection<PDECustomerNeedInCustomer> PDECustomerNeedInCustomerByPDEProjectStatus { get; set; }
		#endregion
	}
}
