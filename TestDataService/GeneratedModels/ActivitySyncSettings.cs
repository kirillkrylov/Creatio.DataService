using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ActivitySyncSettings")]
	public class ActivitySyncSettings : BaseEntity
	{
		#region Values
		private Guid _ActivitySyncPeriodId;
		[CProperty(ColumnPath ="ActivitySyncPeriodId")]
		public Guid ActivitySyncPeriodId
		{
			get{return _ActivitySyncPeriodId;}
			set
			{
				_ActivitySyncPeriodId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _AppointmentLastSyncDate;
		[CProperty(ColumnPath ="AppointmentLastSyncDate")]
		public DateTime AppointmentLastSyncDate
		{
			get{return _AppointmentLastSyncDate;}
			set
			{
				_AppointmentLastSyncDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportActivities;
		[CProperty(ColumnPath ="ExportActivities")]
		public bool ExportActivities
		{
			get{return _ExportActivities;}
			set
			{
				_ExportActivities = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportActivitiesAll;
		[CProperty(ColumnPath ="ExportActivitiesAll")]
		public bool ExportActivitiesAll
		{
			get{return _ExportActivitiesAll;}
			set
			{
				_ExportActivitiesAll = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportActivitiesFromGroups;
		[CProperty(ColumnPath ="ExportActivitiesFromGroups")]
		public bool ExportActivitiesFromGroups
		{
			get{return _ExportActivitiesFromGroups;}
			set
			{
				_ExportActivitiesFromGroups = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportActivitiesFromScheduler;
		[CProperty(ColumnPath ="ExportActivitiesFromScheduler")]
		public bool ExportActivitiesFromScheduler
		{
			get{return _ExportActivitiesFromScheduler;}
			set
			{
				_ExportActivitiesFromScheduler = value;
				OnPropertyChanged();
			}
		}
		private string _ExportActivitiesGroups;
		[CProperty(ColumnPath ="ExportActivitiesGroups")]
		public string ExportActivitiesGroups
		{
			get{return _ExportActivitiesGroups;}
			set
			{
				_ExportActivitiesGroups = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportActivitiesSelected;
		[CProperty(ColumnPath ="ExportActivitiesSelected")]
		public bool ExportActivitiesSelected
		{
			get{return _ExportActivitiesSelected;}
			set
			{
				_ExportActivitiesSelected = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportAppointments;
		[CProperty(ColumnPath ="ExportAppointments")]
		public bool ExportAppointments
		{
			get{return _ExportAppointments;}
			set
			{
				_ExportAppointments = value;
				OnPropertyChanged();
			}
		}
		private bool _ExportTasks;
		[CProperty(ColumnPath ="ExportTasks")]
		public bool ExportTasks
		{
			get{return _ExportTasks;}
			set
			{
				_ExportTasks = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private bool _ImpAppointmentsFromCalendars;
		[CProperty(ColumnPath ="ImpAppointmentsFromCalendars")]
		public bool ImpAppointmentsFromCalendars
		{
			get{return _ImpAppointmentsFromCalendars;}
			set
			{
				_ImpAppointmentsFromCalendars = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ImportActivitiesFrom;
		[CProperty(ColumnPath ="ImportActivitiesFrom")]
		public DateTime ImportActivitiesFrom
		{
			get{return _ImportActivitiesFrom;}
			set
			{
				_ImportActivitiesFrom = value;
				OnPropertyChanged();
			}
		}
		private bool _ImportAppointments;
		[CProperty(ColumnPath ="ImportAppointments")]
		public bool ImportAppointments
		{
			get{return _ImportAppointments;}
			set
			{
				_ImportAppointments = value;
				OnPropertyChanged();
			}
		}
		private bool _ImportAppointmentsAll;
		[CProperty(ColumnPath ="ImportAppointmentsAll")]
		public bool ImportAppointmentsAll
		{
			get{return _ImportAppointmentsAll;}
			set
			{
				_ImportAppointmentsAll = value;
				OnPropertyChanged();
			}
		}
		private string _ImportAppointmentsCalendars;
		[CProperty(ColumnPath ="ImportAppointmentsCalendars")]
		public string ImportAppointmentsCalendars
		{
			get{return _ImportAppointmentsCalendars;}
			set
			{
				_ImportAppointmentsCalendars = value;
				OnPropertyChanged();
			}
		}
		private bool _ImportTasks;
		[CProperty(ColumnPath ="ImportTasks")]
		public bool ImportTasks
		{
			get{return _ImportTasks;}
			set
			{
				_ImportTasks = value;
				OnPropertyChanged();
			}
		}
		private bool _ImportTasksAll;
		[CProperty(ColumnPath ="ImportTasksAll")]
		public bool ImportTasksAll
		{
			get{return _ImportTasksAll;}
			set
			{
				_ImportTasksAll = value;
				OnPropertyChanged();
			}
		}
		private string _ImportTasksFolders;
		[CProperty(ColumnPath ="ImportTasksFolders")]
		public string ImportTasksFolders
		{
			get{return _ImportTasksFolders;}
			set
			{
				_ImportTasksFolders = value;
				OnPropertyChanged();
			}
		}
		private bool _ImportTasksFromFolders;
		[CProperty(ColumnPath ="ImportTasksFromFolders")]
		public bool ImportTasksFromFolders
		{
			get{return _ImportTasksFromFolders;}
			set
			{
				_ImportTasksFromFolders = value;
				OnPropertyChanged();
			}
		}
		private Guid _MailboxSyncSettingsId;
		[CProperty(ColumnPath ="MailboxSyncSettingsId")]
		public Guid MailboxSyncSettingsId
		{
			get{return _MailboxSyncSettingsId;}
			set
			{
				_MailboxSyncSettingsId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private DateTime _TaskLastSyncDate;
		[CProperty(ColumnPath ="TaskLastSyncDate")]
		public DateTime TaskLastSyncDate
		{
			get{return _TaskLastSyncDate;}
			set
			{
				_TaskLastSyncDate = value;
				OnPropertyChanged();
			}
		}
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
