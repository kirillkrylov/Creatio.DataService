using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysGridPage")]
	public class SysGridPage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysEntitySchemaId")]
		public Guid SysEntitySchemaId { get; set; }
		[CProperty(ColumnPath ="SysPageSchemaId")]
		public Guid SysPageSchemaId { get; set; }
		[CProperty(ColumnPath ="TypeColumnUId")]
		public Guid TypeColumnUId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysSchema:SysPageSchemaId")]
		public SysSchema SysPageSchema { get; set; }
		[CProperty(Navigation ="SysSchema:SysEntitySchemaId")]
		public SysSchema SysEntitySchema { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysEditPage:SysGridPageId")]
		public virtual ICollection<SysEditPage> SysEditPageBySysGridPage { get; set; }
		[CProperty(Association ="SysGridPageView:SysGridPageId")]
		public virtual ICollection<SysGridPageView> SysGridPageViewBySysGridPage { get; set; }
		#endregion
	}
}
