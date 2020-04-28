using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ExesInRequestHistory")]
	public class ExesInRequestHistory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AmountEuro")]
		public decimal AmountEuro { get; set; }
		[CProperty(ColumnPath ="BaseCurrencyId")]
		public Guid BaseCurrencyId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ExesInRequestId")]
		public Guid ExesInRequestId { get; set; }
		[CProperty(ColumnPath ="HistoryDate")]
		public DateTime HistoryDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:BaseCurrencyId")]
		public Currency BaseCurrency { get; set; }
		[CProperty(Navigation ="ExesInRequest:ExesInRequestId")]
		public ExesInRequest ExesInRequest { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
