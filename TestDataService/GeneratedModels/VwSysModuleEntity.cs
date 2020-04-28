using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysModuleEntity")]
	public class VwSysModuleEntity : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Image")]
		public byte[] Image { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysWorkspaceId")]
		public Guid SysWorkspaceId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysWorkspace:SysWorkspaceId")]
		public SysWorkspace SysWorkspace { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Reminding:SysEntitySchemaId")]
		public virtual ICollection<Reminding> RemindingBySysEntitySchema { get; set; }
		[CProperty(Association ="Reminding:LoaderId")]
		public virtual ICollection<Reminding> RemindingByLoader { get; set; }
		[CProperty(Association ="ScoringModel:ScoringObjectId")]
		public virtual ICollection<ScoringModel> ScoringModelByScoringObject { get; set; }
		[CProperty(Association ="VwAccountModuleHistory:SysEntityId")]
		public virtual ICollection<VwAccountModuleHistory> VwAccountModuleHistoryBySysEntity { get; set; }
		[CProperty(Association ="VwContactModuleHistory:SysEntityId")]
		public virtual ICollection<VwContactModuleHistory> VwContactModuleHistoryBySysEntity { get; set; }
		[CProperty(Association ="VwModuleHistory:SysEntityId")]
		public virtual ICollection<VwModuleHistory> VwModuleHistoryBySysEntity { get; set; }
		#endregion
	}
}
