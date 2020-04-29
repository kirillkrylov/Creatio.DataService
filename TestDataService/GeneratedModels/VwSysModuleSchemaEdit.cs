using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysModuleSchemaEdit")]
	public class VwSysModuleSchemaEdit : BaseEntity
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
		private string _EditPageCaption;
		[CProperty(ColumnPath ="EditPageCaption")]
		public string EditPageCaption
		{
			get{return _EditPageCaption;}
			set
			{
				_EditPageCaption = value;
				OnPropertyChanged();
			}
		}
		private string _EditPageName;
		[CProperty(ColumnPath ="EditPageName")]
		public string EditPageName
		{
			get{return _EditPageName;}
			set
			{
				_EditPageName = value;
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
		private Guid _MiniPageSchemaUId;
		[CProperty(ColumnPath ="MiniPageSchemaUId")]
		public Guid MiniPageSchemaUId
		{
			get{return _MiniPageSchemaUId;}
			set
			{
				_MiniPageSchemaUId = value;
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
		private string _PageCaption;
		[CProperty(ColumnPath ="PageCaption")]
		public string PageCaption
		{
			get{return _PageCaption;}
			set
			{
				_PageCaption = value;
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
		private string _TypeColumnValue;
		[CProperty(ColumnPath ="TypeColumnValue")]
		public string TypeColumnValue
		{
			get{return _TypeColumnValue;}
			set
			{
				_TypeColumnValue = value;
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
		#endregion
	}
}
