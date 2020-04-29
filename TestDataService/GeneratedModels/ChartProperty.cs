using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ChartProperty")]
	public class ChartProperty : BaseEntity
	{
		#region Values
		private Guid _ChartAggregationTypeId;
		[CProperty(ColumnPath ="ChartAggregationTypeId")]
		public Guid ChartAggregationTypeId
		{
			get{return _ChartAggregationTypeId;}
			set
			{
				_ChartAggregationTypeId = value;
				OnPropertyChanged();
			}
		}
		private byte[] _ChartEntityColumn;
		[CProperty(ColumnPath ="ChartEntityColumn")]
		public byte[] ChartEntityColumn
		{
			get{return _ChartEntityColumn;}
			set
			{
				_ChartEntityColumn = value;
				OnPropertyChanged();
			}
		}
		private string _ChartSeriesKind;
		[CProperty(ColumnPath ="ChartSeriesKind")]
		public string ChartSeriesKind
		{
			get{return _ChartSeriesKind;}
			set
			{
				_ChartSeriesKind = value;
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntityId;
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId
		{
			get{return _EntityId;}
			set
			{
				_EntityId = value;
				OnPropertyChanged();
			}
		}
		private byte[] _Filter;
		[CProperty(ColumnPath ="Filter")]
		public byte[] Filter
		{
			get{return _Filter;}
			set
			{
				_Filter = value;
				OnPropertyChanged();
			}
		}
		private byte[] _GroupByField;
		[CProperty(ColumnPath ="GroupByField")]
		public byte[] GroupByField
		{
			get{return _GroupByField;}
			set
			{
				_GroupByField = value;
				OnPropertyChanged();
			}
		}
		private Guid _GroupByTypeDateTimeId;
		[CProperty(ColumnPath ="GroupByTypeDateTimeId")]
		public Guid GroupByTypeDateTimeId
		{
			get{return _GroupByTypeDateTimeId;}
			set
			{
				_GroupByTypeDateTimeId = value;
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
		private Guid _ModuleEntityId;
		[CProperty(ColumnPath ="ModuleEntityId")]
		public Guid ModuleEntityId
		{
			get{return _ModuleEntityId;}
			set
			{
				_ModuleEntityId = value;
				OnPropertyChanged();
			}
		}
		private byte[] _ModuleObjAccessField;
		[CProperty(ColumnPath ="ModuleObjAccessField")]
		public byte[] ModuleObjAccessField
		{
			get{return _ModuleObjAccessField;}
			set
			{
				_ModuleObjAccessField = value;
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
		private string _OrderByChartPropertyColumn;
		[CProperty(ColumnPath ="OrderByChartPropertyColumn")]
		public string OrderByChartPropertyColumn
		{
			get{return _OrderByChartPropertyColumn;}
			set
			{
				_OrderByChartPropertyColumn = value;
				OnPropertyChanged();
			}
		}
		private string _OrderDirection;
		[CProperty(ColumnPath ="OrderDirection")]
		public string OrderDirection
		{
			get{return _OrderDirection;}
			set
			{
				_OrderDirection = value;
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
		private string _XAxisCaption;
		[CProperty(ColumnPath ="XAxisCaption")]
		public string XAxisCaption
		{
			get{return _XAxisCaption;}
			set
			{
				_XAxisCaption = value;
				OnPropertyChanged();
			}
		}
		private string _YAxisCaption;
		[CProperty(ColumnPath ="YAxisCaption")]
		public string YAxisCaption
		{
			get{return _YAxisCaption;}
			set
			{
				_YAxisCaption = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="ChartAggregationType:ChartAggregationTypeId")]
		public ChartAggregationType ChartAggregationType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GroupByTypeDateTime:GroupByTypeDateTimeId")]
		public GroupByTypeDateTime GroupByTypeDateTime { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
