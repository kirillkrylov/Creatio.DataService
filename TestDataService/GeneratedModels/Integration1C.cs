using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Integration1C")]
	public class Integration1C : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsLogInDB")]
		public bool IsLogInDB { get; set; }
		[CProperty(ColumnPath ="IsPostProcessing")]
		public bool IsPostProcessing { get; set; }
		[CProperty(ColumnPath ="LogLevelId")]
		public Guid LogLevelId { get; set; }
		[CProperty(ColumnPath ="LogPath")]
		public string LogPath { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OneCPassword")]
		public string OneCPassword { get; set; }
		[CProperty(ColumnPath ="OneCServer")]
		public string OneCServer { get; set; }
		[CProperty(ColumnPath ="OneCUser")]
		public string OneCUser { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TimeLogSaving")]
		public int TimeLogSaving { get; set; }
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
