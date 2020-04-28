using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwContactDuplicate")]
	public class VwContactDuplicate : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Entity1Id")]
		public Guid Entity1Id { get; set; }
		[CProperty(ColumnPath ="Entity2Id")]
		public Guid Entity2Id { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StatusOfDuplicateId")]
		public Guid StatusOfDuplicateId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:Entity1Id")]
		public Contact Entity1 { get; set; }
		[CProperty(Navigation ="Contact:Entity2Id")]
		public Contact Entity2 { get; set; }
		[CProperty(Navigation ="DuplicateStatus:StatusOfDuplicateId")]
		public DuplicateStatus StatusOfDuplicate { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
