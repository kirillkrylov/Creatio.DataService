using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductDeliveryType")]
	public class ProductDeliveryType : BaseEntity
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
		[CProperty(ColumnPath ="IsUpdatedAutomatically")]
		public bool IsUpdatedAutomatically { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="SupplyPaymentTypeId")]
		public Guid SupplyPaymentTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SupplyPaymentType:SupplyPaymentTypeId")]
		public SupplyPaymentType SupplyPaymentType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Product:DeliveryTypeId")]
		public virtual ICollection<Product> ProductByDeliveryType { get; set; }
		[CProperty(Association ="SupplyPaymentElement:DeliveryTypeId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByDeliveryType { get; set; }
		[CProperty(Association ="Transaction:IncomeTypeId")]
		public virtual ICollection<Transaction> TransactionByIncomeType { get; set; }
		[CProperty(Association ="TransactionForecast:IncomeTypeId")]
		public virtual ICollection<TransactionForecast> TransactionForecastByIncomeType { get; set; }
		[CProperty(Association ="VwTransaction:IncomeTypeId")]
		public virtual ICollection<VwTransaction> VwTransactionByIncomeType { get; set; }
		#endregion
	}
}
