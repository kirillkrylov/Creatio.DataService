using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysModuleEdit")]
	public class VwSysModuleEdit : BaseEntity
	{
		#region Values
		private string _ActionKindCaption;
		[CProperty(ColumnPath ="ActionKindCaption")]
		public string ActionKindCaption
		{
			get{return _ActionKindCaption;}
			set
			{
				_ActionKindCaption = value;
				OnPropertyChanged();
			}
		}
		private string _ActionKindName;
		[CProperty(ColumnPath ="ActionKindName")]
		public string ActionKindName
		{
			get{return _ActionKindName;}
			set
			{
				_ActionKindName = value;
				OnPropertyChanged();
			}
		}
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
		private Guid _CardSchemaUId;
		[CProperty(ColumnPath ="CardSchemaUId")]
		public Guid CardSchemaUId
		{
			get{return _CardSchemaUId;}
			set
			{
				_CardSchemaUId = value;
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
		private string _HelpContextId;
		[CProperty(ColumnPath ="HelpContextId")]
		public string HelpContextId
		{
			get{return _HelpContextId;}
			set
			{
				_HelpContextId = value;
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
		private string _MiniPageModes;
		[CProperty(ColumnPath ="MiniPageModes")]
		public string MiniPageModes
		{
			get{return _MiniPageModes;}
			set
			{
				_MiniPageModes = value;
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
		private Guid _SearchRowSchemaUId;
		[CProperty(ColumnPath ="SearchRowSchemaUId")]
		public Guid SearchRowSchemaUId
		{
			get{return _SearchRowSchemaUId;}
			set
			{
				_SearchRowSchemaUId = value;
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
		private Guid _SysPageSchemaUId;
		[CProperty(ColumnPath ="SysPageSchemaUId")]
		public Guid SysPageSchemaUId
		{
			get{return _SysPageSchemaUId;}
			set
			{
				_SysPageSchemaUId = value;
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
		private Guid _TypeColumnValue;
		[CProperty(ColumnPath ="TypeColumnValue")]
		public Guid TypeColumnValue
		{
			get{return _TypeColumnValue;}
			set
			{
				_TypeColumnValue = value;
				OnPropertyChanged();
			}
		}
		private bool _UseModuleDetails;
		[CProperty(ColumnPath ="UseModuleDetails")]
		public bool UseModuleDetails
		{
			get{return _UseModuleDetails;}
			set
			{
				_UseModuleDetails = value;
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
		[CProperty(Navigation ="SysWorkspace:SysWorkspaceId")]
		public SysWorkspace SysWorkspace { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
