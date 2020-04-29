using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSiteStatModuleUsage")]
	public class VwSiteStatModuleUsage : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ConfItemId;
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId
		{
			get{return _ConfItemId;}
			set
			{
				_ConfItemId = value;
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
		private bool _IsAvaliable;
		[CProperty(ColumnPath ="IsAvaliable")]
		public bool IsAvaliable
		{
			get{return _IsAvaliable;}
			set
			{
				_IsAvaliable = value;
				OnPropertyChanged();
			}
		}
		private decimal _MetricValue;
		[CProperty(ColumnPath ="MetricValue")]
		public decimal MetricValue
		{
			get{return _MetricValue;}
			set
			{
				_MetricValue = value;
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
		private Guid _SitePurposeId;
		[CProperty(ColumnPath ="SitePurposeId")]
		public Guid SitePurposeId
		{
			get{return _SitePurposeId;}
			set
			{
				_SitePurposeId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _UpdateDate;
		[CProperty(ColumnPath ="UpdateDate")]
		public DateTime UpdateDate
		{
			get{return _UpdateDate;}
			set
			{
				_UpdateDate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _UsageEndDate;
		[CProperty(ColumnPath ="UsageEndDate")]
		public DateTime UsageEndDate
		{
			get{return _UsageEndDate;}
			set
			{
				_UsageEndDate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _UsageStartDate;
		[CProperty(ColumnPath ="UsageStartDate")]
		public DateTime UsageStartDate
		{
			get{return _UsageStartDate;}
			set
			{
				_UsageStartDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _UsageStatusId;
		[CProperty(ColumnPath ="UsageStatusId")]
		public Guid UsageStatusId
		{
			get{return _UsageStatusId;}
			set
			{
				_UsageStatusId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="CaseSubtype:FunctionId")]
		public CaseSubtype Function { get; set; }
		[CProperty(Navigation ="CaseType:ModuleId")]
		public CaseType Module { get; set; }
		[CProperty(Navigation ="ConfItem:ConfItemId")]
		public ConfItem ConfItem { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SitePurpose:SitePurposeId")]
		public SitePurpose SitePurpose { get; set; }
		[CProperty(Navigation ="UsageCondition:UsageStatusId")]
		public UsageCondition UsageStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
