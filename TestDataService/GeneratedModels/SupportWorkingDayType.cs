using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupportWorkingDayType")]
	public class SupportWorkingDayType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="From")]
		public DateTime From { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsAvailable")]
		public bool IsAvailable { get; set; }
		[CProperty(ColumnPath ="IsDuty")]
		public bool IsDuty { get; set; }
		[CProperty(ColumnPath ="IsNight")]
		public bool IsNight { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="To")]
		public DateTime To { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SupportSchedule:SupportWorkingDayTypeId")]
		public virtual ICollection<SupportSchedule> SupportScheduleBySupportWorkingDayType { get; set; }
		[CProperty(Association ="SupportScheduleLog:SupportWorkingDayTypeId")]
		public virtual ICollection<SupportScheduleLog> SupportScheduleLogBySupportWorkingDayType { get; set; }
		[CProperty(Association ="SupportUnit:SupportWorkingDayTypeId")]
		public virtual ICollection<SupportUnit> SupportUnitBySupportWorkingDayType { get; set; }
		[CProperty(Association ="SupportUnitLog:SupportWorkingDayTypeId")]
		public virtual ICollection<SupportUnitLog> SupportUnitLogBySupportWorkingDayType { get; set; }
		#endregion
	}
}
