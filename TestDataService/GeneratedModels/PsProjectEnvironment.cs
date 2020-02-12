using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PsProjectEnvironment")]
	public class PsProjectEnvironment : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BranchKey")]
		public string BranchKey { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DbProjectServerId")]
		public Guid DbProjectServerId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="JiraComponent")]
		public string JiraComponent { get; set; }
		[CProperty(ColumnPath ="KindId")]
		public Guid KindId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="PackagePrefix")]
		public string PackagePrefix { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProjectSolutionId")]
		public Guid ProjectSolutionId { get; set; }
		[CProperty(ColumnPath ="RedisDBNumber")]
		public int RedisDBNumber { get; set; }
		[CProperty(ColumnPath ="RedisProjectServerId")]
		public Guid RedisProjectServerId { get; set; }
		[CProperty(ColumnPath ="SvnBranch")]
		public string SvnBranch { get; set; }
		[CProperty(ColumnPath ="TeamCityMakeBuildConfigurationID")]
		public string TeamCityMakeBuildConfigurationID { get; set; }
		[CProperty(ColumnPath ="TsTeamCityServerId")]
		public Guid TsTeamCityServerId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="WebProjectServerId")]
		public Guid WebProjectServerId { get; set; }
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
