using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SiteStatModuleUsageHistory")]
	public class SiteStatModuleUsageHistory : BaseEntity
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
		private string _MetricCode;
		[CProperty(ColumnPath ="MetricCode")]
		public string MetricCode
		{
			get{return _MetricCode;}
			set
			{
				_MetricCode = value;
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
		private Guid _SiteStatId;
		[CProperty(ColumnPath ="SiteStatId")]
		public Guid SiteStatId
		{
			get{return _SiteStatId;}
			set
			{
				_SiteStatId = value;
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SiteStat:SiteStatId")]
		public SiteStat SiteStat { get; set; }
		[CProperty(Navigation ="UsageCondition:UsageStatusId")]
		public UsageCondition UsageStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
