using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmployeeKpiIndicator")]
	public class EmployeeKpiIndicator : BaseEntity
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
		private Guid _EmployeeKpiId;
		[CProperty(ColumnPath ="EmployeeKpiId")]
		public Guid EmployeeKpiId
		{
			get{return _EmployeeKpiId;}
			set
			{
				_EmployeeKpiId = value;
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
		private Guid _KpiIndicatorId;
		[CProperty(ColumnPath ="KpiIndicatorId")]
		public Guid KpiIndicatorId
		{
			get{return _KpiIndicatorId;}
			set
			{
				_KpiIndicatorId = value;
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
		private int _PointValue;
		[CProperty(ColumnPath ="PointValue")]
		public int PointValue
		{
			get{return _PointValue;}
			set
			{
				_PointValue = value;
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
		private decimal _Value;
		[CProperty(ColumnPath ="Value")]
		public decimal Value
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
		[CProperty(Navigation ="EmployeeKpi:EmployeeKpiId")]
		public EmployeeKpi EmployeeKpi { get; set; }
		[CProperty(Navigation ="KpiIndicator:KpiIndicatorId")]
		public KpiIndicator KpiIndicator { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
