using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GlbReferenceableDetails")]
	public class GlbReferenceableDetails : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="GlbTypeId")]
		public Guid GlbTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GlbReferenceableTypeValue:GlbTypeId")]
		public GlbReferenceableTypeValue GlbType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:GlbReferenceableDetailsId")]
		public virtual ICollection<Account> AccountByGlbReferenceableDetails { get; set; }
		[CProperty(Association ="GlbReferenceable:GlbReferenceableDetailsId")]
		public virtual ICollection<GlbReferenceable> GlbReferenceableByGlbReferenceableDetails { get; set; }
		#endregion
	}
}
