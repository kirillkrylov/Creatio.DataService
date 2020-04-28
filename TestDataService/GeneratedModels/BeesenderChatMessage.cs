using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BeesenderChatMessage")]
	public class BeesenderChatMessage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Buttons")]
		public string Buttons { get; set; }
		[CProperty(ColumnPath ="ChatId")]
		public Guid ChatId { get; set; }
		[CProperty(ColumnPath ="ClientContactId")]
		public Guid ClientContactId { get; set; }
		[CProperty(ColumnPath ="ClientId")]
		public Guid ClientId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InternalId")]
		public string InternalId { get; set; }
		[CProperty(ColumnPath ="MessageType")]
		public int MessageType { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OperatorContactId")]
		public Guid OperatorContactId { get; set; }
		[CProperty(ColumnPath ="OperatorId")]
		public Guid OperatorId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SendByOperator")]
		public bool SendByOperator { get; set; }
		[CProperty(ColumnPath ="Text")]
		public string Text { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BeesenderChat:ChatId")]
		public BeesenderChat Chat { get; set; }
		[CProperty(Navigation ="BeesenderClient:ClientId")]
		public BeesenderClient Client { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OperatorContactId")]
		public Contact OperatorContact { get; set; }
		[CProperty(Navigation ="Contact:ClientContactId")]
		public Contact ClientContact { get; set; }
		[CProperty(Navigation ="SysAdminUnit:OperatorId")]
		public SysAdminUnit Operator { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
