using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PainChain")]
	public class PainChain : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsConfirmed")]
		public bool IsConfirmed { get; set; }
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId { get; set; }
		[CProperty(ColumnPath ="KeyPlayerId")]
		public Guid KeyPlayerId { get; set; }
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NewPain")]
		public string NewPain { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="PainId")]
		public Guid PainId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:KeyPlayerId")]
		public Contact KeyPlayer { get; set; }
		[CProperty(Navigation ="Job:JobId")]
		public Job Job { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="OppContactRole:RoleId")]
		public OppContactRole Role { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="PainChainItem:PainId")]
		public PainChainItem Pain { get; set; }
		[CProperty(Navigation ="PainChainType:TypeId")]
		public PainChainType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="PainReason:PainChainId")]
		public virtual ICollection<PainReason> PainReasonByPainChain { get; set; }
		#endregion
	}
}
