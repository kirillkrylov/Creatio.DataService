using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwBulkEmailClickedLink")]
	public class VwBulkEmailClickedLink : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BulkEmailHyperlinkId")]
		public Guid BulkEmailHyperlinkId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BulkEmailHyperlink:BulkEmailHyperlinkId")]
		public BulkEmailHyperlink BulkEmailHyperlink { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
