using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DeduplicateExecLog")]
	public class DeduplicateExecLog : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CompletedOn")]
		public DateTime CompletedOn { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ExecutedOn")]
		public DateTime ExecutedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ProcedureName")]
		public string ProcedureName { get; set; }
		[CProperty(ColumnPath ="SqlErrorCode")]
		public int SqlErrorCode { get; set; }
		[CProperty(ColumnPath ="SqlErrorMessage")]
		public string SqlErrorMessage { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		[CProperty(Association ="DeduplicateExecLocker:ConversationId")]
		public virtual ICollection<DeduplicateExecLocker> DeduplicateExecLockerByConversation { get; set; }
		#endregion
	}
}
