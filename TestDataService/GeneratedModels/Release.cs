using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Release")]
	public class Release : BaseEntity
	{
		#region Values
		private int _ActualDeploymentLabor;
		[CProperty(ColumnPath ="ActualDeploymentLabor")]
		public int ActualDeploymentLabor
		{
			get{return _ActualDeploymentLabor;}
			set
			{
				_ActualDeploymentLabor = value;
				OnPropertyChanged();
			}
		}
		private int _ActualDevelopmentLabor;
		[CProperty(ColumnPath ="ActualDevelopmentLabor")]
		public int ActualDevelopmentLabor
		{
			get{return _ActualDevelopmentLabor;}
			set
			{
				_ActualDevelopmentLabor = value;
				OnPropertyChanged();
			}
		}
		private int _ActualLabor;
		[CProperty(ColumnPath ="ActualLabor")]
		public int ActualLabor
		{
			get{return _ActualLabor;}
			set
			{
				_ActualLabor = value;
				OnPropertyChanged();
			}
		}
		private int _ActualTestingLabor;
		[CProperty(ColumnPath ="ActualTestingLabor")]
		public int ActualTestingLabor
		{
			get{return _ActualTestingLabor;}
			set
			{
				_ActualTestingLabor = value;
				OnPropertyChanged();
			}
		}
		private Guid _BPMInstallationPackageId;
		[CProperty(ColumnPath ="BPMInstallationPackageId")]
		public Guid BPMInstallationPackageId
		{
			get{return _BPMInstallationPackageId;}
			set
			{
				_BPMInstallationPackageId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineBuildId;
		[CProperty(ColumnPath ="BpmonlineBuildId")]
		public Guid BpmonlineBuildId
		{
			get{return _BpmonlineBuildId;}
			set
			{
				_BpmonlineBuildId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineLczId;
		[CProperty(ColumnPath ="BpmonlineLczId")]
		public Guid BpmonlineLczId
		{
			get{return _BpmonlineLczId;}
			set
			{
				_BpmonlineLczId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineProductId;
		[CProperty(ColumnPath ="BpmonlineProductId")]
		public Guid BpmonlineProductId
		{
			get{return _BpmonlineProductId;}
			set
			{
				_BpmonlineProductId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineVersionId;
		[CProperty(ColumnPath ="BpmonlineVersionId")]
		public Guid BpmonlineVersionId
		{
			get{return _BpmonlineVersionId;}
			set
			{
				_BpmonlineVersionId = value;
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
		private DateTime _DeploymentFinishedOn;
		[CProperty(ColumnPath ="DeploymentFinishedOn")]
		public DateTime DeploymentFinishedOn
		{
			get{return _DeploymentFinishedOn;}
			set
			{
				_DeploymentFinishedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DevelopmentFinishedOn;
		[CProperty(ColumnPath ="DevelopmentFinishedOn")]
		public DateTime DevelopmentFinishedOn
		{
			get{return _DevelopmentFinishedOn;}
			set
			{
				_DevelopmentFinishedOn = value;
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
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
				OnPropertyChanged();
			}
		}
		private string _Number;
		[CProperty(ColumnPath ="Number")]
		public string Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
				OnPropertyChanged();
			}
		}
		private int _PlannedLabor;
		[CProperty(ColumnPath ="PlannedLabor")]
		public int PlannedLabor
		{
			get{return _PlannedLabor;}
			set
			{
				_PlannedLabor = value;
				OnPropertyChanged();
			}
		}
		private Guid _PriorityId;
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId
		{
			get{return _PriorityId;}
			set
			{
				_PriorityId = value;
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
		private DateTime _ReleasedOn;
		[CProperty(ColumnPath ="ReleasedOn")]
		public DateTime ReleasedOn
		{
			get{return _ReleasedOn;}
			set
			{
				_ReleasedOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ScheduledReleaseDate;
		[CProperty(ColumnPath ="ScheduledReleaseDate")]
		public DateTime ScheduledReleaseDate
		{
			get{return _ScheduledReleaseDate;}
			set
			{
				_ScheduledReleaseDate = value;
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
		private DateTime _TestingFinishedOn;
		[CProperty(ColumnPath ="TestingFinishedOn")]
		public DateTime TestingFinishedOn
		{
			get{return _TestingFinishedOn;}
			set
			{
				_TestingFinishedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="BpmonlineBuild:BpmonlineBuildId")]
		public BpmonlineBuild BpmonlineBuild { get; set; }
		[CProperty(Navigation ="BpmonlineLcz:BpmonlineLczId")]
		public BpmonlineLcz BpmonlineLcz { get; set; }
		[CProperty(Navigation ="BpmonlineProduct:BpmonlineProductId")]
		public BpmonlineProduct BpmonlineProduct { get; set; }
		[CProperty(Navigation ="BpmonlineVersion:BpmonlineVersionId")]
		public BpmonlineVersion BpmonlineVersion { get; set; }
		[CProperty(Navigation ="ConfItem:BPMInstallationPackageId")]
		public ConfItem BPMInstallationPackage { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ReleasePriority:PriorityId")]
		public ReleasePriority Priority { get; set; }
		[CProperty(Navigation ="ReleaseStatus:StatusId")]
		public ReleaseStatus Status { get; set; }
		[CProperty(Navigation ="ReleaseType:TypeId")]
		public ReleaseType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:ReleaseId")]
		public virtual ICollection<Activity> ActivityByRelease { get; set; }
		[CProperty(Association ="Case:ReleaseId")]
		public virtual ICollection<Case> CaseByRelease { get; set; }
		[CProperty(Association ="Change:ReleaseId")]
		public virtual ICollection<Change> ChangeByRelease { get; set; }
		[CProperty(Association ="ReleaseConfItem:ReleaseId")]
		public virtual ICollection<ReleaseConfItem> ReleaseConfItemByRelease { get; set; }
		[CProperty(Association ="ReleaseFile:ReleaseId")]
		public virtual ICollection<ReleaseFile> ReleaseFileByRelease { get; set; }
		[CProperty(Association ="ReleaseInFolder:ReleaseId")]
		public virtual ICollection<ReleaseInFolder> ReleaseInFolderByRelease { get; set; }
		[CProperty(Association ="ReleaseInTag:EntityId")]
		public virtual ICollection<ReleaseInTag> ReleaseInTagByEntity { get; set; }
		[CProperty(Association ="ReleaseServiceItem:ReleaseId")]
		public virtual ICollection<ReleaseServiceItem> ReleaseServiceItemByRelease { get; set; }
		[CProperty(Association ="ReleaseTeam:ReleaseId")]
		public virtual ICollection<ReleaseTeam> ReleaseTeamByRelease { get; set; }
		[CProperty(Association ="ScheduledDate:ReleaseId")]
		public virtual ICollection<ScheduledDate> ScheduledDateByRelease { get; set; }
		[CProperty(Association ="VwChange:ReleaseId")]
		public virtual ICollection<VwChange> VwChangeByRelease { get; set; }
		#endregion
	}
}
