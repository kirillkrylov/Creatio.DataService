using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SiteStatModuleUsageMetrics")]
	public class SiteStatModuleUsageMetrics : BaseEntity
	{
		#region Values
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
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
		private Guid _FunctionId;
		[CProperty(ColumnPath ="FunctionId")]
		public Guid FunctionId
		{
			get{return _FunctionId;}
			set
			{
				_FunctionId = value;
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
		private decimal _InTestValue;
		[CProperty(ColumnPath ="InTestValue")]
		public decimal InTestValue
		{
			get{return _InTestValue;}
			set
			{
				_InTestValue = value;
				OnPropertyChanged();
			}
		}
		private decimal _InUseValue;
		[CProperty(ColumnPath ="InUseValue")]
		public decimal InUseValue
		{
			get{return _InUseValue;}
			set
			{
				_InUseValue = value;
				OnPropertyChanged();
			}
		}
		private Guid _MetricCalcToolId;
		[CProperty(ColumnPath ="MetricCalcToolId")]
		public Guid MetricCalcToolId
		{
			get{return _MetricCalcToolId;}
			set
			{
				_MetricCalcToolId = value;
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
		private Guid _ModuleId;
		[CProperty(ColumnPath ="ModuleId")]
		public Guid ModuleId
		{
			get{return _ModuleId;}
			set
			{
				_ModuleId = value;
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
		[CProperty(Navigation ="CaseSubtype:FunctionId")]
		public CaseSubtype Function { get; set; }
		[CProperty(Navigation ="CaseType:ModuleId")]
		public CaseType Module { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MetricCalcTool:MetricCalcToolId")]
		public MetricCalcTool MetricCalcTool { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
