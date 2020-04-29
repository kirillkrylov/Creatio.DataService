using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SyncColumn")]
	public class SyncColumn : BaseEntity
	{
		#region Values
		private Guid _BPMColumn;
		[CProperty(ColumnPath ="BPMColumn")]
		public Guid BPMColumn
		{
			get{return _BPMColumn;}
			set
			{
				_BPMColumn = value;
				OnPropertyChanged();
			}
		}
		private string _BPMColumnName;
		[CProperty(ColumnPath ="BPMColumnName")]
		public string BPMColumnName
		{
			get{return _BPMColumnName;}
			set
			{
				_BPMColumnName = value;
				OnPropertyChanged();
			}
		}
		private string _BPMDesignDetailName;
		[CProperty(ColumnPath ="BPMDesignDetailName")]
		public string BPMDesignDetailName
		{
			get{return _BPMDesignDetailName;}
			set
			{
				_BPMDesignDetailName = value;
				OnPropertyChanged();
			}
		}
		private string _BPMDetailName;
		[CProperty(ColumnPath ="BPMDetailName")]
		public string BPMDetailName
		{
			get{return _BPMDetailName;}
			set
			{
				_BPMDetailName = value;
				OnPropertyChanged();
			}
		}
		private Guid _BPMObject;
		[CProperty(ColumnPath ="BPMObject")]
		public Guid BPMObject
		{
			get{return _BPMObject;}
			set
			{
				_BPMObject = value;
				OnPropertyChanged();
			}
		}
		private string _Comment;
		[CProperty(ColumnPath ="Comment")]
		public string Comment
		{
			get{return _Comment;}
			set
			{
				_Comment = value;
				OnPropertyChanged();
			}
		}
		private Guid _ComparisonSignId;
		[CProperty(ColumnPath ="ComparisonSignId")]
		public Guid ComparisonSignId
		{
			get{return _ComparisonSignId;}
			set
			{
				_ComparisonSignId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ComparisonTypeId;
		[CProperty(ColumnPath ="ComparisonTypeId")]
		public Guid ComparisonTypeId
		{
			get{return _ComparisonTypeId;}
			set
			{
				_ComparisonTypeId = value;
				OnPropertyChanged();
			}
		}
		private string _ConstValue;
		[CProperty(ColumnPath ="ConstValue")]
		public string ConstValue
		{
			get{return _ConstValue;}
			set
			{
				_ConstValue = value;
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
		private string _DefaultValue;
		[CProperty(ColumnPath ="DefaultValue")]
		public string DefaultValue
		{
			get{return _DefaultValue;}
			set
			{
				_DefaultValue = value;
				OnPropertyChanged();
			}
		}
		private string _DesignLyncColumnName;
		[CProperty(ColumnPath ="DesignLyncColumnName")]
		public string DesignLyncColumnName
		{
			get{return _DesignLyncColumnName;}
			set
			{
				_DesignLyncColumnName = value;
				OnPropertyChanged();
			}
		}
		private Guid _FillColumnTypeId;
		[CProperty(ColumnPath ="FillColumnTypeId")]
		public Guid FillColumnTypeId
		{
			get{return _FillColumnTypeId;}
			set
			{
				_FillColumnTypeId = value;
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
		private Guid _IdentityColumnId;
		[CProperty(ColumnPath ="IdentityColumnId")]
		public Guid IdentityColumnId
		{
			get{return _IdentityColumnId;}
			set
			{
				_IdentityColumnId = value;
				OnPropertyChanged();
			}
		}
		private Guid _IntegrationObjectId;
		[CProperty(ColumnPath ="IntegrationObjectId")]
		public Guid IntegrationObjectId
		{
			get{return _IntegrationObjectId;}
			set
			{
				_IntegrationObjectId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsCleanTable;
		[CProperty(ColumnPath ="IsCleanTable")]
		public bool IsCleanTable
		{
			get{return _IsCleanTable;}
			set
			{
				_IsCleanTable = value;
				OnPropertyChanged();
			}
		}
		private bool _IsDefault;
		[CProperty(ColumnPath ="IsDefault")]
		public bool IsDefault
		{
			get{return _IsDefault;}
			set
			{
				_IsDefault = value;
				OnPropertyChanged();
			}
		}
		private bool _LastRecords;
		[CProperty(ColumnPath ="LastRecords")]
		public bool LastRecords
		{
			get{return _LastRecords;}
			set
			{
				_LastRecords = value;
				OnPropertyChanged();
			}
		}
		private bool _LastRecordsBeforeToday;
		[CProperty(ColumnPath ="LastRecordsBeforeToday")]
		public bool LastRecordsBeforeToday
		{
			get{return _LastRecordsBeforeToday;}
			set
			{
				_LastRecordsBeforeToday = value;
				OnPropertyChanged();
			}
		}
		private string _LyncColumnName;
		[CProperty(ColumnPath ="LyncColumnName")]
		public string LyncColumnName
		{
			get{return _LyncColumnName;}
			set
			{
				_LyncColumnName = value;
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
		private bool _NeedGenerateSignal;
		[CProperty(ColumnPath ="NeedGenerateSignal")]
		public bool NeedGenerateSignal
		{
			get{return _NeedGenerateSignal;}
			set
			{
				_NeedGenerateSignal = value;
				OnPropertyChanged();
			}
		}
		private Guid _OneCDetailId;
		[CProperty(ColumnPath ="OneCDetailId")]
		public Guid OneCDetailId
		{
			get{return _OneCDetailId;}
			set
			{
				_OneCDetailId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OneCObjectColumnId;
		[CProperty(ColumnPath ="OneCObjectColumnId")]
		public Guid OneCObjectColumnId
		{
			get{return _OneCObjectColumnId;}
			set
			{
				_OneCObjectColumnId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OneCRegisterColumnId;
		[CProperty(ColumnPath ="OneCRegisterColumnId")]
		public Guid OneCRegisterColumnId
		{
			get{return _OneCRegisterColumnId;}
			set
			{
				_OneCRegisterColumnId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OneCRegisterId;
		[CProperty(ColumnPath ="OneCRegisterId")]
		public Guid OneCRegisterId
		{
			get{return _OneCRegisterId;}
			set
			{
				_OneCRegisterId = value;
				OnPropertyChanged();
			}
		}
		private bool _OnlyNew;
		[CProperty(ColumnPath ="OnlyNew")]
		public bool OnlyNew
		{
			get{return _OnlyNew;}
			set
			{
				_OnlyNew = value;
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
		private Guid _RegesterLinkColumnFilterId;
		[CProperty(ColumnPath ="RegesterLinkColumnFilterId")]
		public Guid RegesterLinkColumnFilterId
		{
			get{return _RegesterLinkColumnFilterId;}
			set
			{
				_RegesterLinkColumnFilterId = value;
				OnPropertyChanged();
			}
		}
		private Guid _RegesterLinkColumnId;
		[CProperty(ColumnPath ="RegesterLinkColumnId")]
		public Guid RegesterLinkColumnId
		{
			get{return _RegesterLinkColumnId;}
			set
			{
				_RegesterLinkColumnId = value;
				OnPropertyChanged();
			}
		}
		private Guid _RegisterClassId;
		[CProperty(ColumnPath ="RegisterClassId")]
		public Guid RegisterClassId
		{
			get{return _RegisterClassId;}
			set
			{
				_RegisterClassId = value;
				OnPropertyChanged();
			}
		}
		private bool _StringView;
		[CProperty(ColumnPath ="StringView")]
		public bool StringView
		{
			get{return _StringView;}
			set
			{
				_StringView = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		private string _Value;
		[CProperty(ColumnPath ="Value")]
		public string Value
		{
			get{return _Value;}
			set
			{
				_Value = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="BpmColumnValueType:ComparisonTypeId")]
		public BpmColumnValueType ComparisonType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FillColumnType:FillColumnTypeId")]
		public FillColumnType FillColumnType { get; set; }
		[CProperty(Navigation ="IntegrationComparisonType:ComparisonSignId")]
		public IntegrationComparisonType ComparisonSign { get; set; }
		[CProperty(Navigation ="OneCObjectColumn:OneCObjectColumnId")]
		public OneCObjectColumn OneCObjectColumn { get; set; }
		[CProperty(Navigation ="OneCObjectDetail:OneCDetailId")]
		public OneCObjectDetail OneCDetail { get; set; }
		[CProperty(Navigation ="OneCObjectDetailColumn:IdentityColumnId")]
		public OneCObjectDetailColumn IdentityColumn { get; set; }
		[CProperty(Navigation ="OneCRegister:OneCRegisterId")]
		public OneCRegister OneCRegister { get; set; }
		[CProperty(Navigation ="OneCRegisterClass:RegisterClassId")]
		public OneCRegisterClass RegisterClass { get; set; }
		[CProperty(Navigation ="OneCRegisterColumn:RegesterLinkColumnId")]
		public OneCRegisterColumn RegesterLinkColumn { get; set; }
		[CProperty(Navigation ="OneCRegisterColumn:RegesterLinkColumnFilterId")]
		public OneCRegisterColumn RegesterLinkColumnFilter { get; set; }
		[CProperty(Navigation ="OneCRegisterObjColumn:OneCRegisterColumnId")]
		public OneCRegisterObjColumn OneCRegisterColumn { get; set; }
		[CProperty(Navigation ="SyncColumnType:TypeId")]
		public SyncColumnType Type { get; set; }
		[CProperty(Navigation ="SyncObject:IntegrationObjectId")]
		public SyncObject IntegrationObject { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AgregateObject:SyncColumnId")]
		public virtual ICollection<AgregateObject> AgregateObjectBySyncColumn { get; set; }
		[CProperty(Association ="MatchingRuleColumn:SyncColumnId")]
		public virtual ICollection<MatchingRuleColumn> MatchingRuleColumnBySyncColumn { get; set; }
		[CProperty(Association ="RegisterColumn:IntegrationObjectId")]
		public virtual ICollection<RegisterColumn> RegisterColumnByIntegrationObject { get; set; }
		[CProperty(Association ="TableIntegrationFilter:IntegrationObjectId")]
		public virtual ICollection<TableIntegrationFilter> TableIntegrationFilterByIntegrationObject { get; set; }
		[CProperty(Association ="TableSyncColumn:IntegrationObjectId")]
		public virtual ICollection<TableSyncColumn> TableSyncColumnByIntegrationObject { get; set; }
		[CProperty(Association ="VwSyncColumn:SyncColumnId")]
		public virtual ICollection<VwSyncColumn> VwSyncColumnBySyncColumn { get; set; }
		#endregion
	}
}
