using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Integration1C")]
	public class Integration1C : BaseEntity
	{
		#region Values
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
		private bool _IsLogInDB;
		[CProperty(ColumnPath ="IsLogInDB")]
		public bool IsLogInDB
		{
			get{return _IsLogInDB;}
			set
			{
				_IsLogInDB = value;
				OnPropertyChanged();
			}
		}
		private bool _IsPostProcessing;
		[CProperty(ColumnPath ="IsPostProcessing")]
		public bool IsPostProcessing
		{
			get{return _IsPostProcessing;}
			set
			{
				_IsPostProcessing = value;
				OnPropertyChanged();
			}
		}
		private Guid _LogLevelId;
		[CProperty(ColumnPath ="LogLevelId")]
		public Guid LogLevelId
		{
			get{return _LogLevelId;}
			set
			{
				_LogLevelId = value;
				OnPropertyChanged();
			}
		}
		private string _LogPath;
		[CProperty(ColumnPath ="LogPath")]
		public string LogPath
		{
			get{return _LogPath;}
			set
			{
				_LogPath = value;
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
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private string _OneCPassword;
		[CProperty(ColumnPath ="OneCPassword")]
		public string OneCPassword
		{
			get{return _OneCPassword;}
			set
			{
				_OneCPassword = value;
				OnPropertyChanged();
			}
		}
		private string _OneCServer;
		[CProperty(ColumnPath ="OneCServer")]
		public string OneCServer
		{
			get{return _OneCServer;}
			set
			{
				_OneCServer = value;
				OnPropertyChanged();
			}
		}
		private string _OneCUser;
		[CProperty(ColumnPath ="OneCUser")]
		public string OneCUser
		{
			get{return _OneCUser;}
			set
			{
				_OneCUser = value;
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
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
				OnPropertyChanged();
			}
		}
		private int _TimeLogSaving;
		[CProperty(ColumnPath ="TimeLogSaving")]
		public int TimeLogSaving
		{
			get{return _TimeLogSaving;}
			set
			{
				_TimeLogSaving = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="IntegrationStatus:StatusId")]
		public IntegrationStatus Status { get; set; }
		[CProperty(Navigation ="LogLevel:LogLevelId")]
		public LogLevel LogLevel { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Integration1CLog:IntegrationId")]
		public virtual ICollection<Integration1CLog> Integration1CLogByIntegration { get; set; }
		[CProperty(Association ="Integration1CSession:IntegrationId")]
		public virtual ICollection<Integration1CSession> Integration1CSessionByIntegration { get; set; }
		[CProperty(Association ="IntegrationJob:IntegrationId")]
		public virtual ICollection<IntegrationJob> IntegrationJobByIntegration { get; set; }
		[CProperty(Association ="OneCExchangePlan:IntegrationId")]
		public virtual ICollection<OneCExchangePlan> OneCExchangePlanByIntegration { get; set; }
		[CProperty(Association ="OneCObject:IntegrationId")]
		public virtual ICollection<OneCObject> OneCObjectByIntegration { get; set; }
		[CProperty(Association ="OneCRegister:IntegrationId")]
		public virtual ICollection<OneCRegister> OneCRegisterByIntegration { get; set; }
		[CProperty(Association ="OneCRegisterObject:IntegrationId")]
		public virtual ICollection<OneCRegisterObject> OneCRegisterObjectByIntegration { get; set; }
		[CProperty(Association ="ProcessInIntegration:IntegrationId")]
		public virtual ICollection<ProcessInIntegration> ProcessInIntegrationByIntegration { get; set; }
		[CProperty(Association ="SyncObject:IntegrationId")]
		public virtual ICollection<SyncObject> SyncObjectByIntegration { get; set; }
		#endregion
	}
}
