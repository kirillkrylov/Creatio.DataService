using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LABAnonymizationObject")]
	public class LABAnonymizationObject : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="LABColumnUId")]
		public Guid LABColumnUId { get; set; }
		[CProperty(ColumnPath ="LABRefColumnName")]
		public string LABRefColumnName { get; set; }
		[CProperty(ColumnPath ="LABSysSchemaUId")]
		public Guid LABSysSchemaUId { get; set; }
		[CProperty(ColumnPath ="LABTableName")]
		public string LABTableName { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
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
		[CProperty(Association ="LABObjectFields:LABAnonymizationObjectId")]
		public virtual ICollection<LABObjectFields> LABObjectFieldsByLABAnonymizationObject { get; set; }
		#endregion
	}
}
