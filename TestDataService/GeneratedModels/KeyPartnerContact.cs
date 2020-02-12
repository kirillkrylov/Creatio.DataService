using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "KeyPartnerContact")]
	public class KeyPartnerContact : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
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
		[CProperty(ColumnPath ="PartnerContactRoleId")]
		public Guid PartnerContactRoleId { get; set; }
		[CProperty(ColumnPath ="PartnershipId")]
		public Guid PartnershipId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="PartnerContactRole:PartnerContactRoleId")]
		public PartnerContactRole PartnerContactRole { get; set; }
		[CProperty(Navigation ="Partnership:PartnershipId")]
		public Partnership Partnership { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
