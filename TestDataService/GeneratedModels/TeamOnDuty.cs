using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TeamOnDuty")]
	public class TeamOnDuty : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DutySchedule:TeamOnDutyId")]
		public virtual ICollection<DutySchedule> DutyScheduleByTeamOnDuty { get; set; }
		[CProperty(Association ="TeamOnDutyFile:TeamOnDutyId")]
		public virtual ICollection<TeamOnDutyFile> TeamOnDutyFileByTeamOnDuty { get; set; }
		[CProperty(Association ="TeamOnDutyInFolder:TeamOnDutyId")]
		public virtual ICollection<TeamOnDutyInFolder> TeamOnDutyInFolderByTeamOnDuty { get; set; }
		[CProperty(Association ="TeamOnDutyInTag:EntityId")]
		public virtual ICollection<TeamOnDutyInTag> TeamOnDutyInTagByEntity { get; set; }
		#endregion
	}
}