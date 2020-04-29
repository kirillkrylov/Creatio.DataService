using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleEntity")]
	public class SysModuleEntity : BaseEntity
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
		private Guid _SysEntitySchemaUId;
		[CProperty(ColumnPath ="SysEntitySchemaUId")]
		public Guid SysEntitySchemaUId
		{
			get{return _SysEntitySchemaUId;}
			set
			{
				_SysEntitySchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeColumnUId;
		[CProperty(ColumnPath ="TypeColumnUId")]
		public Guid TypeColumnUId
		{
			get{return _TypeColumnUId;}
			set
			{
				_TypeColumnUId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ERROR")]
		public virtual ICollection<Portal_SysModule> PortalBySysModuleBySysModuleEntity { get; set; }
		[CProperty(Association ="SysDcmSettings:SysModuleEntityId")]
		public virtual ICollection<SysDcmSettings> SysDcmSettingsBySysModuleEntity { get; set; }
		[CProperty(Association ="SysModule:SysModuleEntityId")]
		public virtual ICollection<SysModule> SysModuleBySysModuleEntity { get; set; }
		[CProperty(Association ="SysModuleDcmSettings:SysModuleEntityId")]
		public virtual ICollection<SysModuleDcmSettings> SysModuleDcmSettingsBySysModuleEntity { get; set; }
		[CProperty(Association ="SysModuleEdit:SysModuleEntityId")]
		public virtual ICollection<SysModuleEdit> SysModuleEditBySysModuleEntity { get; set; }
		[CProperty(Association ="SysModuleEntityInPortal:SysModuleEntityId")]
		public virtual ICollection<SysModuleEntityInPortal> SysModuleEntityInPortalBySysModuleEntity { get; set; }
		[CProperty(Association ="SysModuleGrid:SysModuleEntityId")]
		public virtual ICollection<SysModuleGrid> SysModuleGridBySysModuleEntity { get; set; }
		[CProperty(Association ="VwSysModuleEdit:SysModuleEntityId")]
		public virtual ICollection<VwSysModuleEdit> VwSysModuleEditBySysModuleEntity { get; set; }
		[CProperty(Association ="VwSysModuleSchemaEdit:SysModuleEntityId")]
		public virtual ICollection<VwSysModuleSchemaEdit> VwSysModuleSchemaEditBySysModuleEntity { get; set; }
		#endregion
	}
}
