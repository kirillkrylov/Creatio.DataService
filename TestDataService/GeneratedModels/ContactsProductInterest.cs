using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContactsProductInterest")]
	public class ContactsProductInterest : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="Comments")]
		public string Comments { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DateOfProposal")]
		public DateTime DateOfProposal { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		[CProperty(ColumnPath ="ResultOfProposalId")]
		public Guid ResultOfProposalId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Product:ProductId")]
		public Product Product { get; set; }
		[CProperty(Navigation ="PropositionResult:ResultOfProposalId")]
		public PropositionResult ResultOfProposal { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
