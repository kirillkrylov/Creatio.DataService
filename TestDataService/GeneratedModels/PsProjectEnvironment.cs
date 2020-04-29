using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PsProjectEnvironment")]
	public class PsProjectEnvironment : BaseEntity
	{
		#region Values
		private string _BranchKey;
		[CProperty(ColumnPath ="BranchKey")]
		public string BranchKey
		{
			get{return _BranchKey;}
			set
			{
				_BranchKey = value;
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
		private Guid _DbProjectServerId;
		[CProperty(ColumnPath ="DbProjectServerId")]
		public Guid DbProjectServerId
		{
			get{return _DbProjectServerId;}
			set
			{
				_DbProjectServerId = value;
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
		private string _JiraComponent;
		[CProperty(ColumnPath ="JiraComponent")]
		public string JiraComponent
		{
			get{return _JiraComponent;}
			set
			{
				_JiraComponent = value;
				OnPropertyChanged();
			}
		}
		private Guid _KindId;
		[CProperty(ColumnPath ="KindId")]
		public Guid KindId
		{
			get{return _KindId;}
			set
			{
				_KindId = value;
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
		private string _PackagePrefix;
		[CProperty(ColumnPath ="PackagePrefix")]
		public string PackagePrefix
		{
			get{return _PackagePrefix;}
			set
			{
				_PackagePrefix = value;
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
		private Guid _ProjectSolutionId;
		[CProperty(ColumnPath ="ProjectSolutionId")]
		public Guid ProjectSolutionId
		{
			get{return _ProjectSolutionId;}
			set
			{
				_ProjectSolutionId = value;
				OnPropertyChanged();
			}
		}
		private int _RedisDBNumber;
		[CProperty(ColumnPath ="RedisDBNumber")]
		public int RedisDBNumber
		{
			get{return _RedisDBNumber;}
			set
			{
				_RedisDBNumber = value;
				OnPropertyChanged();
			}
		}
		private Guid _RedisProjectServerId;
		[CProperty(ColumnPath ="RedisProjectServerId")]
		public Guid RedisProjectServerId
		{
			get{return _RedisProjectServerId;}
			set
			{
				_RedisProjectServerId = value;
				OnPropertyChanged();
			}
		}
		private string _SvnBranch;
		[CProperty(ColumnPath ="SvnBranch")]
		public string SvnBranch
		{
			get{return _SvnBranch;}
			set
			{
				_SvnBranch = value;
				OnPropertyChanged();
			}
		}
		private string _TeamCityMakeBuildConfigurationID;
		[CProperty(ColumnPath ="TeamCityMakeBuildConfigurationID")]
		public string TeamCityMakeBuildConfigurationID
		{
			get{return _TeamCityMakeBuildConfigurationID;}
			set
			{
				_TeamCityMakeBuildConfigurationID = value;
				OnPropertyChanged();
			}
		}
		private Guid _TsTeamCityServerId;
		[CProperty(ColumnPath ="TsTeamCityServerId")]
		public Guid TsTeamCityServerId
		{
			get{return _TsTeamCityServerId;}
			set
			{
				_TsTeamCityServerId = value;
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
		private Guid _WebProjectServerId;
		[CProperty(ColumnPath ="WebProjectServerId")]
		public Guid WebProjectServerId
		{
			get{return _WebProjectServerId;}
			set
			{
				_WebProjectServerId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ProjectSolution:ProjectSolutionId")]
		public ProjectSolution ProjectSolution { get; set; }
		[CProperty(Navigation ="PsProjectEnvironmentKind:KindId")]
		public PsProjectEnvironmentKind Kind { get; set; }
		[CProperty(Navigation ="PsProjectEnvironmentType:TypeId")]
		public PsProjectEnvironmentType Type { get; set; }
		[CProperty(Navigation ="PsProjectServers:DbProjectServerId")]
		public PsProjectServers DbProjectServer { get; set; }
		[CProperty(Navigation ="PsProjectServers:RedisProjectServerId")]
		public PsProjectServers RedisProjectServer { get; set; }
		[CProperty(Navigation ="PsProjectServers:WebProjectServerId")]
		public PsProjectServers WebProjectServer { get; set; }
		[CProperty(Navigation ="TsTeamCityServer:TsTeamCityServerId")]
		public TsTeamCityServer TsTeamCityServer { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="PsDelivery:ProjectEnvironmentId")]
		public virtual ICollection<PsDelivery> PsDeliveryByProjectEnvironment { get; set; }
		#endregion
	}
}
