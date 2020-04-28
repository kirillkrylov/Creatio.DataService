using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductInLeadType")]
	public class ProductInLeadType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="LeadTypeId")]
		public Guid LeadTypeId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductFolderId")]
		public Guid ProductFolderId { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="LeadType:LeadTypeId")]
		public LeadType LeadType { get; set; }
		[CProperty(Navigation ="Product:ProductId")]
		public Product Product { get; set; }
		[CProperty(Navigation ="ProductFolder:ProductFolderId")]
		public ProductFolder ProductFolder { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
