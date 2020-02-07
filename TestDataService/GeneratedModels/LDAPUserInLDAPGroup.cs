using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LDAPUserInLDAPGroup")]
	public class LDAPUserInLDAPGroup : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="LDAPGroupId")]
		public Guid LDAPGroupId { get; set; }
		[CProperty(ColumnPath ="LDAPUserId")]
		public Guid LDAPUserId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="LDAPElement:LDAPUserId")]
		public LDAPElement LDAPUser { get; set; }
		[CProperty(Navigation ="LDAPElement:LDAPGroupId")]
		public LDAPElement LDAPGroup { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
