using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TableIntegrationFilter")]
	public class TableIntegrationFilter : BaseEntity
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
		private Guid _BPMCompareColumn;
		[CProperty(ColumnPath ="BPMCompareColumn")]
		public Guid BPMCompareColumn
		{
			get{return _BPMCompareColumn;}
			set
			{
				_BPMCompareColumn = value;
				OnPropertyChanged();
			}
		}
		private string _BPMCompareColumnName;
		[CProperty(ColumnPath ="BPMCompareColumnName")]
		public string BPMCompareColumnName
		{
			get{return _BPMCompareColumnName;}
			set
			{
				_BPMCompareColumnName = value;
				OnPropertyChanged();
			}
		}
		private int _CompareDataValueType;
		[CProperty(ColumnPath ="CompareDataValueType")]
		public int CompareDataValueType
		{
			get{return _CompareDataValueType;}
			set
			{
				_CompareDataValueType = value;
				OnPropertyChanged();
			}
		}
		private string _CompareReferenceSchemaName;
		[CProperty(ColumnPath ="CompareReferenceSchemaName")]
		public string CompareReferenceSchemaName
		{
			get{return _CompareReferenceSchemaName;}
			set
			{
				_CompareReferenceSchemaName = value;
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
		private int _DataValueType;
		[CProperty(ColumnPath ="DataValueType")]
		public int DataValueType
		{
			get{return _DataValueType;}
			set
			{
				_DataValueType = value;
				OnPropertyChanged();
			}
		}
		private string _DesignBPMColumnName;
		[CProperty(ColumnPath ="DesignBPMColumnName")]
		public string DesignBPMColumnName
		{
			get{return _DesignBPMColumnName;}
			set
			{
				_DesignBPMColumnName = value;
				OnPropertyChanged();
			}
		}
		private string _DesignBPMCompareColumnName;
		[CProperty(ColumnPath ="DesignBPMCompareColumnName")]
		public string DesignBPMCompareColumnName
		{
			get{return _DesignBPMCompareColumnName;}
			set
			{
				_DesignBPMCompareColumnName = value;
				OnPropertyChanged();
			}
		}
		private Guid _FilterDirectionId;
		[CProperty(ColumnPath ="FilterDirectionId")]
		public Guid FilterDirectionId
		{
			get{return _FilterDirectionId;}
			set
			{
				_FilterDirectionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _FilterTypeId;
		[CProperty(ColumnPath ="FilterTypeId")]
		public Guid FilterTypeId
		{
			get{return _FilterTypeId;}
			set
			{
				_FilterTypeId = value;
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
		private Guid _OneCObjectCompareColumnId;
		[CProperty(ColumnPath ="OneCObjectCompareColumnId")]
		public Guid OneCObjectCompareColumnId
		{
			get{return _OneCObjectCompareColumnId;}
			set
			{
				_OneCObjectCompareColumnId = value;
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
		private string _ReferenceSchemaName;
		[CProperty(ColumnPath ="ReferenceSchemaName")]
		public string ReferenceSchemaName
		{
			get{return _ReferenceSchemaName;}
			set
			{
				_ReferenceSchemaName = value;
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
		[CProperty(Navigation ="FilterDirection:FilterDirectionId")]
		public FilterDirection FilterDirection { get; set; }
		[CProperty(Navigation ="IntegrationComparisonType:ComparisonTypeId")]
		public IntegrationComparisonType ComparisonType { get; set; }
		[CProperty(Navigation ="IntegrationFilterType:FilterTypeId")]
		public IntegrationFilterType FilterType { get; set; }
		[CProperty(Navigation ="OneCObjectDetailColumn:OneCObjectColumnId")]
		public OneCObjectDetailColumn OneCObjectColumn { get; set; }
		[CProperty(Navigation ="OneCObjectDetailColumn:OneCObjectCompareColumnId")]
		public OneCObjectDetailColumn OneCObjectCompareColumn { get; set; }
		[CProperty(Navigation ="SyncColumn:IntegrationObjectId")]
		public SyncColumn IntegrationObject { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
