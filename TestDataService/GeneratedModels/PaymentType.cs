using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PaymentType")]
	public class PaymentType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
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
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="UseInFinanceRequest")]
		public bool UseInFinanceRequest { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ExesInRequest:PaymentTypeId")]
		public virtual ICollection<ExesInRequest> ExesInRequestByPaymentType { get; set; }
		[CProperty(Association ="Invoice:PaymentTypeId")]
		public virtual ICollection<Invoice> InvoiceByPaymentType { get; set; }
		[CProperty(Association ="Order:PaymentTypeId")]
		public virtual ICollection<Order> OrderByPaymentType { get; set; }
		[CProperty(Association ="RequestExes:PaymentTypeId")]
		public virtual ICollection<RequestExes> RequestExesByPaymentType { get; set; }
		#endregion
	}
}
