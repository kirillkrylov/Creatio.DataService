using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwProcessDashboard")]
	public class VwProcessDashboard : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ElementCaption")]
		public string ElementCaption { get; set; }
		[CProperty(ColumnPath ="ElementOwnerId")]
		public Guid ElementOwnerId { get; set; }
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId { get; set; }
		[CProperty(ColumnPath ="EntitySchemaUId")]
		public Guid EntitySchemaUId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessDataId")]
		public Guid ProcessDataId { get; set; }
		[CProperty(ColumnPath ="ProcessElementEntityId")]
		public Guid ProcessElementEntityId { get; set; }
		[CProperty(ColumnPath ="ProcessElementEntitySchemaUId")]
		public Guid ProcessElementEntitySchemaUId { get; set; }
		[CProperty(ColumnPath ="ProcessElementId")]
		public Guid ProcessElementId { get; set; }
		[CProperty(ColumnPath ="ProcessElementSchemaUId")]
		public Guid ProcessElementSchemaUId { get; set; }
		[CProperty(ColumnPath ="ProcessName")]
		public string ProcessName { get; set; }
		[CProperty(ColumnPath ="ProcessOwnerId")]
		public Guid ProcessOwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessSchemaElementUId")]
		public Guid ProcessSchemaElementUId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Contact:ElementOwnerId")]
		public Contact ElementOwner { get; set; }
		[CProperty(Navigation ="Contact:ProcessOwnerId")]
		public Contact ProcessOwner { get; set; }
		[CProperty(Navigation ="SysProcessData:ProcessDataId")]
		public SysProcessData ProcessData { get; set; }
		[CProperty(Navigation ="SysProcessElementData:ProcessElementId")]
		public SysProcessElementData ProcessElement { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
