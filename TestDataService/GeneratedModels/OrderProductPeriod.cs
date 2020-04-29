using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OrderProductPeriod")]
	public class OrderProductPeriod : BaseEntity
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
		private int _Days;
		[CProperty(ColumnPath ="Days")]
		public int Days
		{
			get{return _Days;}
			set
			{
				_Days = value;
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
		private bool _IsNew;
		[CProperty(ColumnPath ="IsNew")]
		public bool IsNew
		{
			get{return _IsNew;}
			set
			{
				_IsNew = value;
				OnPropertyChanged();
			}
		}
		private bool _IsUseInForecast;
		[CProperty(ColumnPath ="IsUseInForecast")]
		public bool IsUseInForecast
		{
			get{return _IsUseInForecast;}
			set
			{
				_IsUseInForecast = value;
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
		private int _SerialYearNumber;
		[CProperty(ColumnPath ="SerialYearNumber")]
		public int SerialYearNumber
		{
			get{return _SerialYearNumber;}
			set
			{
				_SerialYearNumber = value;
				OnPropertyChanged();
			}
		}
		private int _Years;
		[CProperty(ColumnPath ="Years")]
		public int Years
		{
			get{return _Years;}
			set
			{
				_Years = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="InvoiceProduct:PeriodId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductByPeriod { get; set; }
		[CProperty(Association ="OppForecastWizDeliveryPlan:PeriodId")]
		public virtual ICollection<OppForecastWizDeliveryPlan> OppForecastWizDeliveryPlanByPeriod { get; set; }
		[CProperty(Association ="OppForecastWizSupport:PeriodId")]
		public virtual ICollection<OppForecastWizSupport> OppForecastWizSupportByPeriod { get; set; }
		[CProperty(Association ="OpportunityForecast:PeriodId")]
		public virtual ICollection<OpportunityForecast> OpportunityForecastByPeriod { get; set; }
		[CProperty(Association ="OpportunityForecastHistory:PeriodId")]
		public virtual ICollection<OpportunityForecastHistory> OpportunityForecastHistoryByPeriod { get; set; }
		[CProperty(Association ="OrderProduct:PeriodId")]
		public virtual ICollection<OrderProduct> OrderProductByPeriod { get; set; }
		[CProperty(Association ="VwInvoiceProduct:PeriodId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductByPeriod { get; set; }
		#endregion
	}
}
