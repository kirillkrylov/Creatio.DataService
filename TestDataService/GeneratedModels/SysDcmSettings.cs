using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysDcmSettings")]
	public class SysDcmSettings : BaseEntity
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
		private Guid _DefaultSchemaUId;
		[CProperty(ColumnPath ="DefaultSchemaUId")]
		public Guid DefaultSchemaUId
		{
			get{return _DefaultSchemaUId;}
			set
			{
				_DefaultSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private string _Filters;
		[CProperty(ColumnPath ="Filters")]
		public string Filters
		{
			get{return _Filters;}
			set
			{
				_Filters = value;
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
		private Guid _StageColumnUId;
		[CProperty(ColumnPath ="StageColumnUId")]
		public Guid StageColumnUId
		{
			get{return _StageColumnUId;}
			set
			{
				_StageColumnUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysModuleEntityId;
		[CProperty(ColumnPath ="SysModuleEntityId")]
		public Guid SysModuleEntityId
		{
			get{return _SysModuleEntityId;}
			set
			{
				_SysModuleEntityId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysModuleEntity:SysModuleEntityId")]
		public SysModuleEntity SysModuleEntity { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysDcmSchemaInSettings:SysDcmSettingsId")]
		public virtual ICollection<SysDcmSchemaInSettings> SysDcmSchemaInSettingsBySysDcmSettings { get; set; }
		#endregion
	}
}
