using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OppForecastWizPayments")]
	public class OppForecastWizPayments : BaseEntity
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
		private Guid _ForecastProductTypeId;
		[CProperty(ColumnPath ="ForecastProductTypeId")]
		public Guid ForecastProductTypeId
		{
			get{return _ForecastProductTypeId;}
			set
			{
				_ForecastProductTypeId = value;
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
		private Guid _OpportunityForecastStatusId;
		[CProperty(ColumnPath ="OpportunityForecastStatusId")]
		public Guid OpportunityForecastStatusId
		{
			get{return _OpportunityForecastStatusId;}
			set
			{
				_OpportunityForecastStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OpportunityId;
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId
		{
			get{return _OpportunityId;}
			set
			{
				_OpportunityId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PaymentAmount;
		[CProperty(ColumnPath ="PaymentAmount")]
		public decimal PaymentAmount
		{
			get{return _PaymentAmount;}
			set
			{
				_PaymentAmount = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PaymentDate;
		[CProperty(ColumnPath ="PaymentDate")]
		public DateTime PaymentDate
		{
			get{return _PaymentDate;}
			set
			{
				_PaymentDate = value;
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
		private decimal _TCVPercent;
		[CProperty(ColumnPath ="TCVPercent")]
		public decimal TCVPercent
		{
			get{return _TCVPercent;}
			set
			{
				_TCVPercent = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ForecastProductType:ForecastProductTypeId")]
		public ForecastProductType ForecastProductType { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityForecastStatus:OpportunityForecastStatusId")]
		public OpportunityForecastStatus OpportunityForecastStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
