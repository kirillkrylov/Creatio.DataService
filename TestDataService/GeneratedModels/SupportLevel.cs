using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupportLevel")]
	public class SupportLevel : BaseEntity
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
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
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
		[CProperty(Association ="ManualSupportLevel:SupportLevelId")]
		public virtual ICollection<ManualSupportLevel> ManualSupportLevelBySupportLevel { get; set; }
		[CProperty(Association ="OppForecastWizSupport:SupportLevelId")]
		public virtual ICollection<OppForecastWizSupport> OppForecastWizSupportBySupportLevel { get; set; }
		[CProperty(Association ="OpportunityForecast:SupportLevelId")]
		public virtual ICollection<OpportunityForecast> OpportunityForecastBySupportLevel { get; set; }
		[CProperty(Association ="OpportunityForecastHistory:SupportLevelId")]
		public virtual ICollection<OpportunityForecastHistory> OpportunityForecastHistoryBySupportLevel { get; set; }
		[CProperty(Association ="PriorityInSupportLevel:SupportLevelId")]
		public virtual ICollection<PriorityInSupportLevel> PriorityInSupportLevelBySupportLevel { get; set; }
		[CProperty(Association ="Product:SupportLevelId")]
		public virtual ICollection<Product> ProductBySupportLevel { get; set; }
		[CProperty(Association ="ProductInServicePact:SupportLevelId")]
		public virtual ICollection<ProductInServicePact> ProductInServicePactBySupportLevel { get; set; }
		[CProperty(Association ="ServicePact:SupportLevelId")]
		public virtual ICollection<ServicePact> ServicePactBySupportLevel { get; set; }
		[CProperty(Association ="SupportRate:SupportLevelId")]
		public virtual ICollection<SupportRate> SupportRateBySupportLevel { get; set; }
		[CProperty(Association ="VwProductSLA:SupportLevelId")]
		public virtual ICollection<VwProductSLA> VwProductSLABySupportLevel { get; set; }
		#endregion
	}
}
