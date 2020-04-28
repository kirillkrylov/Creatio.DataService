using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ReleaseTeam")]
	public class ReleaseTeam : BaseEntity
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
		[CProperty(ColumnPath ="ReleaseId")]
		public Guid ReleaseId { get; set; }
		[CProperty(ColumnPath ="ResponsibleId")]
		public Guid ResponsibleId { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Release:ReleaseId")]
		public Release Release { get; set; }
		[CProperty(Navigation ="ReleaseStatus:StatusId")]
		public ReleaseStatus Status { get; set; }
		[CProperty(Navigation ="SysAdminUnit:ResponsibleId")]
		public SysAdminUnit Responsible { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
