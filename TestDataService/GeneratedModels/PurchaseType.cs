using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PurchaseType")]
	public class PurchaseType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ProductForLicGenerator:PurchaseTypeId")]
		public virtual ICollection<ProductForLicGenerator> ProductForLicGeneratorByPurchaseType { get; set; }
		[CProperty(Association ="ProductInSubscription:PurchaseTypeId")]
		public virtual ICollection<ProductInSubscription> ProductInSubscriptionByPurchaseType { get; set; }
		[CProperty(Association ="VwTSSLA:PurchaseTypeId")]
		public virtual ICollection<VwTSSLA> VwTSSLAByPurchaseType { get; set; }
		[CProperty(Association ="VwTSSLAArchive:PurchaseTypeId")]
		public virtual ICollection<VwTSSLAArchive> VwTSSLAArchiveByPurchaseType { get; set; }
		#endregion
	}
}
