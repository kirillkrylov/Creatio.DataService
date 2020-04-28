using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "IntegrationLog")]
	public class IntegrationLog : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Date")]
		public DateTime Date { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="DirectionId")]
		public Guid DirectionId { get; set; }
		[CProperty(ColumnPath ="ErrorDescription")]
		public string ErrorDescription { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegrationSystemId")]
		public Guid IntegrationSystemId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OperationId")]
		public Guid OperationId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ResultId")]
		public Guid ResultId { get; set; }
		[CProperty(ColumnPath ="SessionNumber")]
		public int SessionNumber { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="IntegrationDirection:DirectionId")]
		public IntegrationDirection Direction { get; set; }
		[CProperty(Navigation ="IntegrationOperation:OperationId")]
		public IntegrationOperation Operation { get; set; }
		[CProperty(Navigation ="IntegrationResult:ResultId")]
		public IntegrationResult Result { get; set; }
		[CProperty(Navigation ="IntegrationSystem:IntegrationSystemId")]
		public IntegrationSystem IntegrationSystem { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
