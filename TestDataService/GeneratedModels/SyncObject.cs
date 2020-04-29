using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SyncObject")]
	public class SyncObject : BaseEntity
	{
		#region Values
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
		private string _BPMObjectName;
		[CProperty(ColumnPath ="BPMObjectName")]
		public string BPMObjectName
		{
			get{return _BPMObjectName;}
			set
			{
				_BPMObjectName = value;
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
		private string _ExchangePlan;
		[CProperty(ColumnPath ="ExchangePlan")]
		public string ExchangePlan
		{
			get{return _ExchangePlan;}
			set
			{
				_ExchangePlan = value;
				OnPropertyChanged();
			}
		}
		private string _ExchangePlanNode;
		[CProperty(ColumnPath ="ExchangePlanNode")]
		public string ExchangePlanNode
		{
			get{return _ExchangePlanNode;}
			set
			{
				_ExchangePlanNode = value;
				OnPropertyChanged();
			}
		}
		private Guid _FiltersUnionTypeId;
		[CProperty(ColumnPath ="FiltersUnionTypeId")]
		public Guid FiltersUnionTypeId
		{
			get{return _FiltersUnionTypeId;}
			set
			{
				_FiltersUnionTypeId = value;
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
		private Guid _IntegrationId;
		[CProperty(ColumnPath ="IntegrationId")]
		public Guid IntegrationId
		{
			get{return _IntegrationId;}
			set
			{
				_IntegrationId = value;
				OnPropertyChanged();
			}
		}
		private Guid _IntegrationTypeId;
		[CProperty(ColumnPath ="IntegrationTypeId")]
		public Guid IntegrationTypeId
		{
			get{return _IntegrationTypeId;}
			set
			{
				_IntegrationTypeId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsActive;
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive
		{
			get{return _IsActive;}
			set
			{
				_IsActive = value;
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
		private Guid _ObjectTypeId;
		[CProperty(ColumnPath ="ObjectTypeId")]
		public Guid ObjectTypeId
		{
			get{return _ObjectTypeId;}
			set
			{
				_ObjectTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OneCObjectId;
		[CProperty(ColumnPath ="OneCObjectId")]
		public Guid OneCObjectId
		{
			get{return _OneCObjectId;}
			set
			{
				_OneCObjectId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OneCRegisterClassId;
		[CProperty(ColumnPath ="OneCRegisterClassId")]
		public Guid OneCRegisterClassId
		{
			get{return _OneCRegisterClassId;}
			set
			{
				_OneCRegisterClassId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OneCRegisterFunctionId;
		[CProperty(ColumnPath ="OneCRegisterFunctionId")]
		public Guid OneCRegisterFunctionId
		{
			get{return _OneCRegisterFunctionId;}
			set
			{
				_OneCRegisterFunctionId = value;
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
		private int _Order;
		[CProperty(ColumnPath ="Order")]
		public int Order
		{
			get{return _Order;}
			set
			{
				_Order = value;
				OnPropertyChanged();
			}
		}
		private bool _Post;
		[CProperty(ColumnPath ="Post")]
		public bool Post
		{
			get{return _Post;}
			set
			{
				_Post = value;
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
		private bool _Rewrite;
		[CProperty(ColumnPath ="Rewrite")]
		public bool Rewrite
		{
			get{return _Rewrite;}
			set
			{
				_Rewrite = value;
				OnPropertyChanged();
			}
		}
		private bool _UseMatchingRules;
		[CProperty(ColumnPath ="UseMatchingRules")]
		public bool UseMatchingRules
		{
			get{return _UseMatchingRules;}
			set
			{
				_UseMatchingRules = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FilterUnionType:FiltersUnionTypeId")]
		public FilterUnionType FiltersUnionType { get; set; }
		[CProperty(Navigation ="Integration1C:IntegrationId")]
		public Integration1C Integration { get; set; }
		[CProperty(Navigation ="IntegrationType:IntegrationTypeId")]
		public IntegrationType IntegrationType { get; set; }
		[CProperty(Navigation ="OneCObject:OneCObjectId")]
		public OneCObject OneCObject { get; set; }
		[CProperty(Navigation ="OneCObjectType:ObjectTypeId")]
		public OneCObjectType ObjectType { get; set; }
		[CProperty(Navigation ="OneCRegisterClass:OneCRegisterClassId")]
		public OneCRegisterClass OneCRegisterClass { get; set; }
		[CProperty(Navigation ="OneCRegisterFunction:OneCRegisterFunctionId")]
		public OneCRegisterFunction OneCRegisterFunction { get; set; }
		[CProperty(Navigation ="OneCRegisterObject:OneCRegisterId")]
		public OneCRegisterObject OneCRegister { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Integration1CDuplLog:SyncObjectId")]
		public virtual ICollection<Integration1CDuplLog> Integration1CDuplLogBySyncObject { get; set; }
		[CProperty(Association ="IntegrationFilter:IntegrationObjectId")]
		public virtual ICollection<IntegrationFilter> IntegrationFilterByIntegrationObject { get; set; }
		[CProperty(Association ="MatchingRule:SyncObjectId")]
		public virtual ICollection<MatchingRule> MatchingRuleBySyncObject { get; set; }
		[CProperty(Association ="SyncColumn:IntegrationObjectId")]
		public virtual ICollection<SyncColumn> SyncColumnByIntegrationObject { get; set; }
		[CProperty(Association ="SyncRegisterColumn:IntegrationObjectId")]
		public virtual ICollection<SyncRegisterColumn> SyncRegisterColumnByIntegrationObject { get; set; }
		#endregion
	}
}
