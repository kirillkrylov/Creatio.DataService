using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysPackageHierarchy")]
	public class SysPackageHierarchy : BaseEntity
	{
		#region Values
		private Guid _BaseSysPackageId;
		[CProperty(ColumnPath ="BaseSysPackageId")]
		public Guid BaseSysPackageId
		{
			get{return _BaseSysPackageId;}
			set
			{
				_BaseSysPackageId = value;
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
		private Guid _DependOnPackageId;
		[CProperty(ColumnPath ="DependOnPackageId")]
		public Guid DependOnPackageId
		{
			get{return _DependOnPackageId;}
			set
			{
				_DependOnPackageId = value;
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
		private int _Level;
		[CProperty(ColumnPath ="Level")]
		public int Level
		{
			get{return _Level;}
			set
			{
				_Level = value;
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
		private Guid _SysPackageId;
		[CProperty(ColumnPath ="SysPackageId")]
		public Guid SysPackageId
		{
			get{return _SysPackageId;}
			set
			{
				_SysPackageId = value;
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
		[CProperty(Navigation ="SysPackage:BaseSysPackageId")]
		public SysPackage BaseSysPackage { get; set; }
		[CProperty(Navigation ="SysPackage:SysPackageId")]
		public SysPackage SysPackage { get; set; }
		[CProperty(Navigation ="SysPackage:DependOnPackageId")]
		public SysPackage DependOnPackage { get; set; }
		[CProperty(Navigation ="SysWorkspace:SysWorkspaceId")]
		public SysWorkspace SysWorkspace { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
