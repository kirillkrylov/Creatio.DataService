using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysModuleEntity")]
	public class VwSysModuleEntity : BaseEntity
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
		private byte[] _Image;
		[CProperty(ColumnPath ="Image")]
		public byte[] Image
		{
			get{return _Image;}
			set
			{
				_Image = value;
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
		private Guid _SysWorkspaceId;
		[CProperty(ColumnPath ="SysWorkspaceId")]
		public Guid SysWorkspaceId
		{
			get{return _SysWorkspaceId;}
			set
			{
				_SysWorkspaceId = value;
				OnPropertyChanged();
			}
		}
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
