using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BsoChatMessage")]
	public class BsoChatMessage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BsoAuthor")]
		public string BsoAuthor { get; set; }
		[CProperty(ColumnPath ="BsoBlacklisted")]
		public bool BsoBlacklisted { get; set; }
		[CProperty(ColumnPath ="BsoChatId")]
		public Guid BsoChatId { get; set; }
		[CProperty(ColumnPath ="BsoDate")]
		public DateTime BsoDate { get; set; }
		[CProperty(ColumnPath ="BsoMessage")]
		public string BsoMessage { get; set; }
		[CProperty(ColumnPath ="BsoOwnerId")]
		public Guid BsoOwnerId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
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
		[CProperty(Navigation ="BsoChats:BsoChatId")]
		public BsoChats BsoChat { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:BsoOwnerId")]
		public Contact BsoOwner { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
