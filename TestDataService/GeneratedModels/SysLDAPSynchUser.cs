using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysLDAPSynchUser")]
	public class SysLDAPSynchUser : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Company")]
		public string Company { get; set; }
		[CProperty(ColumnPath ="Dn")]
		public string Dn { get; set; }
		[CProperty(ColumnPath ="Email")]
		public string Email { get; set; }
		[CProperty(ColumnPath ="FullName")]
		public string FullName { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override string Id { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="JobTitle")]
		public string JobTitle { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Phone")]
		public string Phone { get; set; }
		[CProperty(ColumnPath ="RecordId")]
		public Guid RecordId { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
