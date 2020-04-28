using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "WorkResourceElement")]
	public class WorkResourceElement : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActualWork")]
		public decimal ActualWork { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ExternalRate")]
		public decimal ExternalRate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InternalRate")]
		public decimal InternalRate { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PlanningWork")]
		public decimal PlanningWork { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId { get; set; }
		[CProperty(ColumnPath ="ProjectResourceElementId")]
		public Guid ProjectResourceElementId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Project:ProjectId")]
		public Project Project { get; set; }
		[CProperty(Navigation ="ProjectResourceElement:ProjectResourceElementId")]
		public ProjectResourceElement ProjectResourceElement { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
