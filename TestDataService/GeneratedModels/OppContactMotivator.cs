using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OppContactMotivator")]
	public class OppContactMotivator : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContactMotivatorId")]
		public Guid ContactMotivatorId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OpportunityContactId")]
		public Guid OpportunityContactId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OppContactMotivators:ContactMotivatorId")]
		public OppContactMotivators ContactMotivator { get; set; }
		[CProperty(Navigation ="OpportunityContact:OpportunityContactId")]
		public OpportunityContact OpportunityContact { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
