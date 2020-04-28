using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PsProjectServers")]
	public class PsProjectServers : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OpportunityDepartmentId")]
		public Guid OpportunityDepartmentId { get; set; }
		[CProperty(ColumnPath ="PracticeId")]
		public Guid PracticeId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OpportunityDepartment:OpportunityDepartmentId")]
		public OpportunityDepartment OpportunityDepartment { get; set; }
		[CProperty(Navigation ="Practice:PracticeId")]
		public Practice Practice { get; set; }
		[CProperty(Navigation ="PsProjectServerType:TypeId")]
		public PsProjectServerType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="PsProjectEnvironment:DbProjectServerId")]
		public virtual ICollection<PsProjectEnvironment> PsProjectEnvironmentByDbProjectServer { get; set; }
		[CProperty(Association ="PsProjectEnvironment:RedisProjectServerId")]
		public virtual ICollection<PsProjectEnvironment> PsProjectEnvironmentByRedisProjectServer { get; set; }
		[CProperty(Association ="PsProjectEnvironment:WebProjectServerId")]
		public virtual ICollection<PsProjectEnvironment> PsProjectEnvironmentByWebProjectServer { get; set; }
		#endregion
	}
}
