using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysLDAPSynchGroup")]
	public class SysLDAPSynchGroup : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Dn")]
		public string Dn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override string Id { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="RecordId")]
		public Guid RecordId { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
