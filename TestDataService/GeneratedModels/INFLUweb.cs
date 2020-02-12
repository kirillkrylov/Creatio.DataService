using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "INFLUweb")]
	public class INFLUweb : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="INFLUNotes")]
		public string INFLUNotes { get; set; }
		[CProperty(ColumnPath ="INFLUSection")]
		public string INFLUSection { get; set; }
		[CProperty(ColumnPath ="INFLUURL")]
		public string INFLUURL { get; set; }
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
		#endregion

		#region Associations
		[CProperty(Association ="INFLUwebFile:INFLUwebId")]
		public virtual ICollection<INFLUwebFile> INFLUwebFileByINFLUweb { get; set; }
		[CProperty(Association ="INFLUwebInFolder:INFLUwebId")]
		public virtual ICollection<INFLUwebInFolder> INFLUwebInFolderByINFLUweb { get; set; }
		[CProperty(Association ="INFLUwebInTag:EntityId")]
		public virtual ICollection<INFLUwebInTag> INFLUwebInTagByEntity { get; set; }
		#endregion
	}
}
