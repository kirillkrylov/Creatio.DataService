using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EnrchTextEntity")]
	public class EnrchTextEntity : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DuplicationStatus")]
		public string DuplicationStatus { get; set; }
		[CProperty(ColumnPath ="EnrchEmailDataId")]
		public Guid EnrchEmailDataId { get; set; }
		[CProperty(ColumnPath ="Hash")]
		public string Hash { get; set; }
		[CProperty(ColumnPath ="HashVersion")]
		public int HashVersion { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="JsonData")]
		public string JsonData { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Source")]
		public string Source { get; set; }
		[CProperty(ColumnPath ="Type")]
		public string Type { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EnrchEmailData:EnrchEmailDataId")]
		public EnrchEmailData EnrchEmailData { get; set; }
		[CProperty(Navigation ="EnrchTextEntity:ParentId")]
		public EnrchTextEntity Parent { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="EnrchFoundAccount:EnrchTextEntityId")]
		public virtual ICollection<EnrchFoundAccount> EnrchFoundAccountByEnrchTextEntity { get; set; }
		[CProperty(Association ="EnrchFoundContact:EnrchTextEntityId")]
		public virtual ICollection<EnrchFoundContact> EnrchFoundContactByEnrchTextEntity { get; set; }
		[CProperty(Association ="EnrchTextEntity:ParentId")]
		public virtual ICollection<EnrchTextEntity> EnrchTextEntityByParent { get; set; }
		#endregion
	}
}
