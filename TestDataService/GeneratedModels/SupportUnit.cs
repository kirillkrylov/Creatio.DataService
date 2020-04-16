using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupportUnit")]
	public class SupportUnit : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Active")]
		public bool Active { get; set; }
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
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
		[CProperty(ColumnPath ="ParentSupportUnitId")]
		public Guid ParentSupportUnitId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SupportUnitTypeId")]
		public Guid SupportUnitTypeId { get; set; }
		[CProperty(ColumnPath ="SupportWorkingDayTypeId")]
		public Guid SupportWorkingDayTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Calendar:CalendarId")]
		public Calendar Calendar { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="SupportUnit:ParentSupportUnitId")]
		public SupportUnit ParentSupportUnit { get; set; }
		[CProperty(Navigation ="SupportUnitType:SupportUnitTypeId")]
		public SupportUnitType SupportUnitType { get; set; }
		[CProperty(Navigation ="SupportWorkingDayType:SupportWorkingDayTypeId")]
		public SupportWorkingDayType SupportWorkingDayType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SupportSchedule:SupportUnitId")]
		public virtual ICollection<SupportSchedule> SupportScheduleBySupportUnit { get; set; }
		[CProperty(Association ="SupportScheduleLog:SupportUnitId")]
		public virtual ICollection<SupportScheduleLog> SupportScheduleLogBySupportUnit { get; set; }
		[CProperty(Association ="SupportUnit:ParentSupportUnitId")]
		public virtual ICollection<SupportUnit> SupportUnitByParentSupportUnit { get; set; }
		[CProperty(Association ="SupportUnitInFolder:SupportUnitId")]
		public virtual ICollection<SupportUnitInFolder> SupportUnitInFolderBySupportUnit { get; set; }
		[CProperty(Association ="SupportUnitLog:SupportUnitId")]
		public virtual ICollection<SupportUnitLog> SupportUnitLogBySupportUnit { get; set; }
		[CProperty(Association ="SupportUnitLog:ParentSupportUnitId")]
		public virtual ICollection<SupportUnitLog> SupportUnitLogByParentSupportUnit { get; set; }
		#endregion
	}
}
