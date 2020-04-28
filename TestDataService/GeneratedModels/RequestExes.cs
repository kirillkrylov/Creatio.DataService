using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RequestExes")]
	public class RequestExes : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Amount")]
		public int Amount { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NeedPrimaryDocuments")]
		public bool NeedPrimaryDocuments { get; set; }
		[CProperty(ColumnPath ="PaymentTypeId")]
		public Guid PaymentTypeId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="RequestTypeId")]
		public Guid RequestTypeId { get; set; }
		[CProperty(ColumnPath ="Sync1cId")]
		public string Sync1cId { get; set; }
		[CProperty(ColumnPath ="UsedInBusinessTrip")]
		public bool UsedInBusinessTrip { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="PaymentType:PaymentTypeId")]
		public PaymentType PaymentType { get; set; }
		[CProperty(Navigation ="RequestType:RequestTypeId")]
		public RequestType RequestType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ExesInRequest:RequestExesId")]
		public virtual ICollection<ExesInRequest> ExesInRequestByRequestExes { get; set; }
		[CProperty(Association ="RequestExesByType:RequestExesId")]
		public virtual ICollection<RequestExesByType> RequestExesByTypeByRequestExes { get; set; }
		#endregion
	}
}
