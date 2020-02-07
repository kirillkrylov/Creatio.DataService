using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailHyperlink")]
	public class BulkEmailHyperlink : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BpmReplicaMask")]
		public int BpmReplicaMask { get; set; }
		[CProperty(ColumnPath ="BpmTrackId")]
		public int BpmTrackId { get; set; }
		[CProperty(ColumnPath ="BulkEmailId")]
		public Guid BulkEmailId { get; set; }
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="ClicksCount")]
		public int ClicksCount { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Hash")]
		public Guid Hash { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Url")]
		public string Url { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BulkEmail:BulkEmailId")]
		public BulkEmail BulkEmail { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="VwBulkEmailClickedLink:BulkEmailHyperlinkId")]
		public virtual ICollection<VwBulkEmailClickedLink> VwBulkEmailClickedLinkByBulkEmailHyperlink { get; set; }
		#endregion
	}
}
