using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleFolder")]
	public class SysModuleFolder : BaseEntity
	{
		#region Values
		private string _Caption;
		[CProperty(ColumnPath ="Caption")]
		public string Caption
		{
			get{return _Caption;}
			set
			{
				_Caption = value;
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
		private string _Location;
		[CProperty(ColumnPath ="Location")]
		public string Location
		{
			get{return _Location;}
			set
			{
				_Location = value;
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
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
				OnPropertyChanged();
			}
		}
		private int _Position;
		[CProperty(ColumnPath ="Position")]
		public int Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="City:ParentId")]
		public City Parent { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BpmPreferences:BpmObjectId")]
		public virtual ICollection<BpmPreferences> BpmPreferencesByBpmObject { get; set; }
		[CProperty(Association ="SysModuleFolderLczOld:RecordId")]
		public virtual ICollection<SysModuleFolderLczOld> SysModuleFolderLczOldByRecord { get; set; }
		[CProperty(Association ="SysModuleInSysModuleFolder:SubSysModuleFolderId")]
		public virtual ICollection<SysModuleInSysModuleFolder> SysModuleInSysModuleFolderBySubSysModuleFolder { get; set; }
		[CProperty(Association ="SysModuleInSysModuleFolder:SysModuleFolderId")]
		public virtual ICollection<SysModuleInSysModuleFolder> SysModuleInSysModuleFolderBySysModuleFolder { get; set; }
		#endregion
	}
}
