using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CompletenessParameter")]
	public class CompletenessParameter : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AttributeId")]
		public Guid AttributeId { get; set; }
		[CProperty(ColumnPath ="ColumnName")]
		public string ColumnName { get; set; }
		[CProperty(ColumnPath ="CompletenessId")]
		public Guid CompletenessId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DetailColumn")]
		public string DetailColumn { get; set; }
		[CProperty(ColumnPath ="DetailEntityName")]
		public string DetailEntityName { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsColumn")]
		public bool IsColumn { get; set; }
		[CProperty(ColumnPath ="IsDetail")]
		public bool IsDetail { get; set; }
		[CProperty(ColumnPath ="MasterColumn")]
		public string MasterColumn { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="Percentage")]
		public int Percentage { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TypeColumn")]
		public string TypeColumn { get; set; }
		[CProperty(ColumnPath ="TypeValue")]
		public Guid TypeValue { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Completeness:CompletenessId")]
		public Completeness Completeness { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
