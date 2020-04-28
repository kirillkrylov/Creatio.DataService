using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseMessageHistory")]
	public class CaseMessageHistory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CaseId")]
		public Guid CaseId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="HasAttachment")]
		public bool HasAttachment { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Message")]
		public string Message { get; set; }
		[CProperty(ColumnPath ="MessageNotifierId")]
		public Guid MessageNotifierId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordId")]
		public Guid RecordId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Case:CaseId")]
		public Case Case { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MessageNotifier:MessageNotifierId")]
		public MessageNotifier MessageNotifier { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="PortalEmailMessage:CaseMessageHistoryId")]
		public virtual ICollection<PortalEmailMessage> PortalEmailMessageByCaseMessageHistory { get; set; }
		#endregion
	}
}
