using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "IntegrationJob")]
	public class IntegrationJob : BaseEntity
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
		private int _HoursInterval;
		[CProperty(ColumnPath ="HoursInterval")]
		public int HoursInterval
		{
			get{return _HoursInterval;}
			set
			{
				_HoursInterval = value;
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
		private Guid _IntegrationId;
		[CProperty(ColumnPath ="IntegrationId")]
		public Guid IntegrationId
		{
			get{return _IntegrationId;}
			set
			{
				_IntegrationId = value;
				OnPropertyChanged();
			}
		}
		private Guid _IntegrationJobTypeId;
		[CProperty(ColumnPath ="IntegrationJobTypeId")]
		public Guid IntegrationJobTypeId
		{
			get{return _IntegrationJobTypeId;}
			set
			{
				_IntegrationJobTypeId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _IntegrationTime;
		[CProperty(ColumnPath ="IntegrationTime")]
		public DateTime IntegrationTime
		{
			get{return _IntegrationTime;}
			set
			{
				_IntegrationTime = value;
				OnPropertyChanged();
			}
		}
		private bool _IsActive;
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive
		{
			get{return _IsActive;}
			set
			{
				_IsActive = value;
				OnPropertyChanged();
			}
		}
		private string _JobName;
		[CProperty(ColumnPath ="JobName")]
		public string JobName
		{
			get{return _JobName;}
			set
			{
				_JobName = value;
				OnPropertyChanged();
			}
		}
		private int _MinutesInterval;
		[CProperty(ColumnPath ="MinutesInterval")]
		public int MinutesInterval
		{
			get{return _MinutesInterval;}
			set
			{
				_MinutesInterval = value;
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
		private Guid _UserId;
		[CProperty(ColumnPath ="UserId")]
		public Guid UserId
		{
			get{return _UserId;}
			set
			{
				_UserId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Integration1C:IntegrationId")]
		public Integration1C Integration { get; set; }
		[CProperty(Navigation ="IntegrationJobType:IntegrationJobTypeId")]
		public IntegrationJobType IntegrationJobType { get; set; }
		[CProperty(Navigation ="SysAdminUnit:UserId")]
		public SysAdminUnit User { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
