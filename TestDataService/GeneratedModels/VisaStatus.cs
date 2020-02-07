using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VisaStatus")]
	public class VisaStatus : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsFinal")]
		public bool IsFinal { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ContractVisa:StatusId")]
		public virtual ICollection<ContractVisa> ContractVisaByStatus { get; set; }
		[CProperty(Association ="DocumentVisa:StatusId")]
		public virtual ICollection<DocumentVisa> DocumentVisaByStatus { get; set; }
		[CProperty(Association ="InvoiceVisa:StatusId")]
		public virtual ICollection<InvoiceVisa> InvoiceVisaByStatus { get; set; }
		[CProperty(Association ="OpportunityVisa:StatusId")]
		public virtual ICollection<OpportunityVisa> OpportunityVisaByStatus { get; set; }
		[CProperty(Association ="OrderVisa:StatusId")]
		public virtual ICollection<OrderVisa> OrderVisaByStatus { get; set; }
		[CProperty(Association ="tsaTermVisa:StatusId")]
		public virtual ICollection<tsaTermVisa> tsaTermVisaByStatus { get; set; }
		[CProperty(Association ="VwVisa:StatusId")]
		public virtual ICollection<VwVisa> VwVisaByStatus { get; set; }
		#endregion
	}
}
