using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PortalColumnAccessList")]
	public class PortalColumnAccessList : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ColumnName")]
		public string ColumnName { get; set; }
		[CProperty(ColumnPath ="ColumnUId")]
		public Guid ColumnUId { get; set; }
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
		[CProperty(ColumnPath ="PortalSchemaListId")]
		public Guid PortalSchemaListId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="PortalSchemaAccessList:PortalSchemaListId")]
		public PortalSchemaAccessList PortalSchemaList { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
