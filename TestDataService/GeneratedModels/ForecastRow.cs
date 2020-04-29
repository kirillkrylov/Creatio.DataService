using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ForecastRow")]
	public class ForecastRow : BaseEntity
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountForecast:RowId")]
		public virtual ICollection<AccountForecast> AccountForecastByRow { get; set; }
		[CProperty(Association ="ContactForecast:RowId")]
		public virtual ICollection<ContactForecast> ContactForecastByRow { get; set; }
		[CProperty(Association ="EmployeeForecast:RowId")]
		public virtual ICollection<EmployeeForecast> EmployeeForecastByRow { get; set; }
		[CProperty(Association ="LeadTypeForecast:RowId")]
		public virtual ICollection<LeadTypeForecast> LeadTypeForecastByRow { get; set; }
		[CProperty(Association ="OppDepartmentForecast:RowId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastByRow { get; set; }
		[CProperty(Association ="ProductForecast:RowId")]
		public virtual ICollection<ProductForecast> ProductForecastByRow { get; set; }
		#endregion
	}
}
