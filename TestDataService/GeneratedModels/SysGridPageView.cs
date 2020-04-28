using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysGridPageView")]
	public class SysGridPageView : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DataSourceFilterCode")]
		public string DataSourceFilterCode { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysGridPageId")]
		public Guid SysGridPageId { get; set; }
		[CProperty(ColumnPath ="SysStoringStateId")]
		public Guid SysStoringStateId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysGridPage:SysGridPageId")]
		public SysGridPage SysGridPage { get; set; }
		[CProperty(Navigation ="SysGridPageView:ParentId")]
		public SysGridPageView Parent { get; set; }
		[CProperty(Navigation ="SysStoringObjectState:SysStoringStateId")]
		public SysStoringObjectState SysStoringState { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysGridPageView:ParentId")]
		public virtual ICollection<SysGridPageView> SysGridPageViewByParent { get; set; }
		#endregion
	}
}
