using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Integration1CLog")]
	public class Integration1CLog : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Integration1CSessionId")]
		public Guid Integration1CSessionId { get; set; }
		[CProperty(ColumnPath ="IntegrationId")]
		public Guid IntegrationId { get; set; }
		[CProperty(ColumnPath ="LogRecordTypeId")]
		public Guid LogRecordTypeId { get; set; }
		[CProperty(ColumnPath ="Message")]
		public string Message { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Number")]
		public int Number { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Integration1C:IntegrationId")]
		public Integration1C Integration { get; set; }
		[CProperty(Navigation ="Integration1CSession:Integration1CSessionId")]
		public Integration1CSession Integration1CSession { get; set; }
		[CProperty(Navigation ="LogRecordType:LogRecordTypeId")]
		public LogRecordType LogRecordType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
