using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductPlatform")]
	public class ProductPlatform : BaseEntity
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:ProductPlatformId")]
		public virtual ICollection<Account> AccountByProductPlatform { get; set; }
		[CProperty(Association ="AccountStageHistory:ProductPlatformId")]
		public virtual ICollection<AccountStageHistory> AccountStageHistoryByProductPlatform { get; set; }
		[CProperty(Association ="GlbCustomer:GlbProductPlatformId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbProductPlatform { get; set; }
		[CProperty(Association ="Product:PlatformId")]
		public virtual ICollection<Product> ProductByPlatform { get; set; }
		#endregion
	}
}
