using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CorrespondenceLink")]
	public class CorrespondenceLink : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActId")]
		public Guid ActId { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId { get; set; }
		[CProperty(ColumnPath ="CorrespondenceId")]
		public Guid CorrespondenceId { get; set; }
		[CProperty(ColumnPath ="CorrespondenceSourceId")]
		public Guid CorrespondenceSourceId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Quantity")]
		public int Quantity { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="RequestId")]
		public Guid RequestId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contract:ContractId")]
		public Contract Contract { get; set; }
		[CProperty(Navigation ="CorrespondenceLinkType:TypeId")]
		public CorrespondenceLinkType Type { get; set; }
		[CProperty(Navigation ="Document:CorrespondenceId")]
		public Document Correspondence { get; set; }
		[CProperty(Navigation ="Document:ActId")]
		public Document Act { get; set; }
		[CProperty(Navigation ="Document:CorrespondenceSourceId")]
		public Document CorrespondenceSource { get; set; }
		[CProperty(Navigation ="InternalRequest:RequestId")]
		public InternalRequest Request { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
