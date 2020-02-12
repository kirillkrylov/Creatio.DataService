using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Payments")]
	public class Payments : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AmountWithOutTax")]
		public decimal AmountWithOutTax { get; set; }
		[CProperty(ColumnPath ="AmountWithTax")]
		public decimal AmountWithTax { get; set; }
		[CProperty(ColumnPath ="CheckingAccount")]
		public string CheckingAccount { get; set; }
		[CProperty(ColumnPath ="ContractNumber")]
		public string ContractNumber { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OperationDate")]
		public DateTime OperationDate { get; set; }
		[CProperty(ColumnPath ="Payer")]
		public string Payer { get; set; }
		[CProperty(ColumnPath ="PayerAccount")]
		public string PayerAccount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="PurposeOfPayment")]
		public string PurposeOfPayment { get; set; }
		[CProperty(ColumnPath ="Recipient")]
		public string Recipient { get; set; }
		[CProperty(ColumnPath ="TaxPercent")]
		public decimal TaxPercent { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="InvoicePayments:PaymentId")]
		public virtual ICollection<InvoicePayments> InvoicePaymentsByPayment { get; set; }
		[CProperty(Association ="PaymentsFile:PaymentsId")]
		public virtual ICollection<PaymentsFile> PaymentsFileByPayments { get; set; }
		[CProperty(Association ="PaymentsInFolder:PaymentsId")]
		public virtual ICollection<PaymentsInFolder> PaymentsInFolderByPayments { get; set; }
		[CProperty(Association ="PaymentsInTag:EntityId")]
		public virtual ICollection<PaymentsInTag> PaymentsInTagByEntity { get; set; }
		#endregion
	}
}
