using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SyncRegisterColumn")]
	public class SyncRegisterColumn : BaseEntity
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
		private Guid _OneCFunctionColumnId;
		[CProperty(ColumnPath ="OneCFunctionColumnId")]
		public Guid OneCFunctionColumnId
		{
			get{return _OneCFunctionColumnId;}
			set
			{
				_OneCFunctionColumnId = value;
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FillColumnType:FillColumnTypeId")]
		public FillColumnType FillColumnType { get; set; }
		[CProperty(Navigation ="OneCFunctionColumn:OneCFunctionColumnId")]
		public OneCFunctionColumn OneCFunctionColumn { get; set; }
		[CProperty(Navigation ="SyncObject:IntegrationObjectId")]
		public SyncObject IntegrationObject { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
