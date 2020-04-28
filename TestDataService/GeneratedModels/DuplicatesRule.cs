using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DuplicatesRule")]
	public class DuplicatesRule : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ObjectId")]
		public Guid ObjectId { get; set; }
		[CProperty(ColumnPath ="ProcedureName")]
		public string ProcedureName { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RuleBody")]
		public string RuleBody { get; set; }
		[CProperty(ColumnPath ="SearchObjectId")]
		public Guid SearchObjectId { get; set; }
		[CProperty(ColumnPath ="UseAtSave")]
		public bool UseAtSave { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="VwDuplicatesRuleType:ObjectId")]
		public VwDuplicatesRuleType Object { get; set; }
		[CProperty(Navigation ="VwDuplicatesRuleType:SearchObjectId")]
		public VwDuplicatesRuleType SearchObject { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DuplicatesRuleInFolder:DuplicatesRuleId")]
		public virtual ICollection<DuplicatesRuleInFolder> DuplicatesRuleInFolderByDuplicatesRule { get; set; }
		[CProperty(Association ="DuplicatesRuleInTag:EntityId")]
		public virtual ICollection<DuplicatesRuleInTag> DuplicatesRuleInTagByEntity { get; set; }
		#endregion
	}
}
