using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DCRecipientOp")]
	public class DCRecipientOp : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BlockIndex")]
		public int BlockIndex { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId { get; set; }
		[CProperty(ColumnPath ="GroupIndex")]
		public int GroupIndex { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="SessionId")]
		public Guid SessionId { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
