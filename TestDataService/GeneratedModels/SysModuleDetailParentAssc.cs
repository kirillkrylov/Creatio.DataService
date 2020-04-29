using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleDetailParentAssc")]
	public class SysModuleDetailParentAssc : BaseEntity
	{
		#region Values
		private string _ColumnCaption;
		[CProperty(ColumnPath ="ColumnCaption")]
		public string ColumnCaption
		{
			get{return _ColumnCaption;}
			set
			{
				_ColumnCaption = value;
				OnPropertyChanged();
			}
		}
		private string _ColumnMetaPath;
		[CProperty(ColumnPath ="ColumnMetaPath")]
		public string ColumnMetaPath
		{
			get{return _ColumnMetaPath;}
			set
			{
				_ColumnMetaPath = value;
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
		private string _ParentColumnCaption;
		[CProperty(ColumnPath ="ParentColumnCaption")]
		public string ParentColumnCaption
		{
			get{return _ParentColumnCaption;}
			set
			{
				_ParentColumnCaption = value;
				OnPropertyChanged();
			}
		}
		private string _ParentColumnMetaPath;
		[CProperty(ColumnPath ="ParentColumnMetaPath")]
		public string ParentColumnMetaPath
		{
			get{return _ParentColumnMetaPath;}
			set
			{
				_ParentColumnMetaPath = value;
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
		private Guid _SysModuleDetailId;
		[CProperty(ColumnPath ="SysModuleDetailId")]
		public Guid SysModuleDetailId
		{
			get{return _SysModuleDetailId;}
			set
			{
				_SysModuleDetailId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysParentAssociationTypeId;
		[CProperty(ColumnPath ="SysParentAssociationTypeId")]
		public Guid SysParentAssociationTypeId
		{
			get{return _SysParentAssociationTypeId;}
			set
			{
				_SysParentAssociationTypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysModuleDetail:SysModuleDetailId")]
		public SysModuleDetail SysModuleDetail { get; set; }
		[CProperty(Navigation ="SysParentAssociationType:SysParentAssociationTypeId")]
		public SysParentAssociationType SysParentAssociationType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
