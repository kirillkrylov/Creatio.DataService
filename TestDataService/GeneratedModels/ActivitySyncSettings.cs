using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ActivitySyncSettings")]
	public class ActivitySyncSettings : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActivitySyncPeriodId")]
		public Guid ActivitySyncPeriodId { get; set; }
		[CProperty(ColumnPath ="AppointmentLastSyncDate")]
		public DateTime AppointmentLastSyncDate { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ExportActivities")]
		public bool ExportActivities { get; set; }
		[CProperty(ColumnPath ="ExportActivitiesAll")]
		public bool ExportActivitiesAll { get; set; }
		[CProperty(ColumnPath ="ExportActivitiesFromGroups")]
		public bool ExportActivitiesFromGroups { get; set; }
		[CProperty(ColumnPath ="ExportActivitiesFromScheduler")]
		public bool ExportActivitiesFromScheduler { get; set; }
		[CProperty(ColumnPath ="ExportActivitiesGroups")]
		public string ExportActivitiesGroups { get; set; }
		[CProperty(ColumnPath ="ExportActivitiesSelected")]
		public bool ExportActivitiesSelected { get; set; }
		[CProperty(ColumnPath ="ExportAppointments")]
		public bool ExportAppointments { get; set; }
		[CProperty(ColumnPath ="ExportTasks")]
		public bool ExportTasks { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ImpAppointmentsFromCalendars")]
		public bool ImpAppointmentsFromCalendars { get; set; }
		[CProperty(ColumnPath ="ImportActivitiesFrom")]
		public DateTime ImportActivitiesFrom { get; set; }
		[CProperty(ColumnPath ="ImportAppointments")]
		public bool ImportAppointments { get; set; }
		[CProperty(ColumnPath ="ImportAppointmentsAll")]
		public bool ImportAppointmentsAll { get; set; }
		[CProperty(ColumnPath ="ImportAppointmentsCalendars")]
		public string ImportAppointmentsCalendars { get; set; }
		[CProperty(ColumnPath ="ImportTasks")]
		public bool ImportTasks { get; set; }
		[CProperty(ColumnPath ="ImportTasksAll")]
		public bool ImportTasksAll { get; set; }
		[CProperty(ColumnPath ="ImportTasksFolders")]
		public string ImportTasksFolders { get; set; }
		[CProperty(ColumnPath ="ImportTasksFromFolders")]
		public bool ImportTasksFromFolders { get; set; }
		[CProperty(ColumnPath ="MailboxSyncSettingsId")]
		public Guid MailboxSyncSettingsId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TaskLastSyncDate")]
		public DateTime TaskLastSyncDate { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MailboxSyncSettings:MailboxSyncSettingsId")]
		public MailboxSyncSettings MailboxSyncSettings { get; set; }
		[CProperty(Navigation ="MailSyncPeriod:ActivitySyncPeriodId")]
		public MailSyncPeriod ActivitySyncPeriod { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
