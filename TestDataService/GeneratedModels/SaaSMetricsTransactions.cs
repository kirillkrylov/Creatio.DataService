using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SaaSMetricsTransactions")]
	public class SaaSMetricsTransactions : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="ActivationDate")]
		public DateTime ActivationDate { get; set; }
		[CProperty(ColumnPath ="AmountWithoutTax")]
		public decimal AmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DeactivationDate")]
		public DateTime DeactivationDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NewProduct")]
		public bool NewProduct { get; set; }
		[CProperty(ColumnPath ="OrderProductId")]
		public Guid OrderProductId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductCaption")]
		public string ProductCaption { get; set; }
		[CProperty(ColumnPath ="ProductFamilyId")]
		public Guid ProductFamilyId { get; set; }
		[CProperty(ColumnPath ="SigningDate")]
		public DateTime SigningDate { get; set; }
		[CProperty(ColumnPath ="SpecificationId")]
		public Guid SpecificationId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contract:SpecificationId")]
		public Contract Specification { get; set; }
		[CProperty(Navigation ="ProductKind:ProductFamilyId")]
		public ProductKind ProductFamily { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
