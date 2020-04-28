using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GlbReferenceable")]
	public class GlbReferenceable : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="GlbAccountCustomerId")]
		public Guid GlbAccountCustomerId { get; set; }
		[CProperty(ColumnPath ="GlbName")]
		public string GlbName { get; set; }
		[CProperty(ColumnPath ="GlbNotes")]
		public string GlbNotes { get; set; }
		[CProperty(ColumnPath ="GlbReferenceableDetailsId")]
		public Guid GlbReferenceableDetailsId { get; set; }
		[CProperty(ColumnPath ="GlbReferenceableTypeId")]
		public Guid GlbReferenceableTypeId { get; set; }
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
		[CProperty(Navigation ="Account:GlbAccountCustomerId")]
		public Account GlbAccountCustomer { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GlbReferenceableDetails:GlbReferenceableDetailsId")]
		public GlbReferenceableDetails GlbReferenceableDetails { get; set; }
		[CProperty(Navigation ="GlbReferenceableTypeValue:GlbReferenceableTypeId")]
		public GlbReferenceableTypeValue GlbReferenceableType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="GlbReferenceableFile:GlbReferenceableId")]
		public virtual ICollection<GlbReferenceableFile> GlbReferenceableFileByGlbReferenceable { get; set; }
		[CProperty(Association ="GlbReferenceableInFolder:GlbReferenceableId")]
		public virtual ICollection<GlbReferenceableInFolder> GlbReferenceableInFolderByGlbReferenceable { get; set; }
		[CProperty(Association ="GlbReferenceableInTag:EntityId")]
		public virtual ICollection<GlbReferenceableInTag> GlbReferenceableInTagByEntity { get; set; }
		#endregion
	}
}
