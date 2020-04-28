using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "WorkDeployLog")]
	public class WorkDeployLog : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BuildId")]
		public string BuildId { get; set; }
		[CProperty(ColumnPath ="BuildStatusIconUrl")]
		public string BuildStatusIconUrl { get; set; }
		[CProperty(ColumnPath ="BuildUrl")]
		public string BuildUrl { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsFlushRedis")]
		public bool IsFlushRedis { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="WorkDeployLogFile:WorkDeployLogId")]
		public virtual ICollection<WorkDeployLogFile> WorkDeployLogFileByWorkDeployLog { get; set; }
		[CProperty(Association ="WorkDeployLogInFolder:WorkDeployLogId")]
		public virtual ICollection<WorkDeployLogInFolder> WorkDeployLogInFolderByWorkDeployLog { get; set; }
		[CProperty(Association ="WorkDeployLogInTag:EntityId")]
		public virtual ICollection<WorkDeployLogInTag> WorkDeployLogInTagByEntity { get; set; }
		#endregion
	}
}
