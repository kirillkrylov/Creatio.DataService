using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PortalEmailMessage")]
	public class PortalEmailMessage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CaseMessageHistoryId")]
		public Guid CaseMessageHistoryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsHtmlBody")]
		public bool IsHtmlBody { get; set; }
		[CProperty(ColumnPath ="MessageTypeId")]
		public Guid MessageTypeId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Recipient")]
		public string Recipient { get; set; }
		[CProperty(ColumnPath ="SendDate")]
		public DateTime SendDate { get; set; }
		[CProperty(ColumnPath ="Sender")]
		public string Sender { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseMessageHistory:CaseMessageHistoryId")]
		public CaseMessageHistory CaseMessageHistory { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
