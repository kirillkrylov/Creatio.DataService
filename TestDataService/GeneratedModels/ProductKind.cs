using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductKind")]
	public class ProductKind : BaseEntity
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
		private DateTime _IntegratedOn;
		[CProperty(ColumnPath ="IntegratedOn")]
		public DateTime IntegratedOn
		{
			get{return _IntegratedOn;}
			set
			{
				_IntegratedOn = value;
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
		private string _NameEN;
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN
		{
			get{return _NameEN;}
			set
			{
				_NameEN = value;
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
		private Guid _Uid1C;
		[CProperty(ColumnPath ="Uid1C")]
		public Guid Uid1C
		{
			get{return _Uid1C;}
			set
			{
				_Uid1C = value;
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
		[CProperty(Association ="ClientARRInPeriod:ProductKindId")]
		public virtual ICollection<ClientARRInPeriod> ClientARRInPeriodByProductKind { get; set; }
		[CProperty(Association ="ClientSaaSMetrics:ProductFamilyId")]
		public virtual ICollection<ClientSaaSMetrics> ClientSaaSMetricsByProductFamily { get; set; }
		[CProperty(Association ="OppForecastWizDeliveryPlan:ProductKindId")]
		public virtual ICollection<OppForecastWizDeliveryPlan> OppForecastWizDeliveryPlanByProductKind { get; set; }
		[CProperty(Association ="OpportunityForecast:ProductKindId")]
		public virtual ICollection<OpportunityForecast> OpportunityForecastByProductKind { get; set; }
		[CProperty(Association ="OpportunityForecastHistory:ProductKindId")]
		public virtual ICollection<OpportunityForecastHistory> OpportunityForecastHistoryByProductKind { get; set; }
		[CProperty(Association ="Product:KindId")]
		public virtual ICollection<Product> ProductByKind { get; set; }
		[CProperty(Association ="SaaSMetrics:ProductFamilyId")]
		public virtual ICollection<SaaSMetrics> SaaSMetricsByProductFamily { get; set; }
		[CProperty(Association ="SaaSMetricsTransactions:ProductFamilyId")]
		public virtual ICollection<SaaSMetricsTransactions> SaaSMetricsTransactionsByProductFamily { get; set; }
		[CProperty(Association ="VwNewClientsBySubscription:KindId")]
		public virtual ICollection<VwNewClientsBySubscription> VwNewClientsBySubscriptionByKind { get; set; }
		[CProperty(Association ="VwTSLicProduct:KindId")]
		public virtual ICollection<VwTSLicProduct> VwTSLicProductByKind { get; set; }
		[CProperty(Association ="VwTSLicProductArchive:KindId")]
		public virtual ICollection<VwTSLicProductArchive> VwTSLicProductArchiveByKind { get; set; }
		#endregion
	}
}
