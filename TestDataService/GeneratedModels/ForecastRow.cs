using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ForecastRow")]
	public class ForecastRow : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
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
		[CProperty(Association ="LeadTypeForecast:RowId")]
		public virtual ICollection<LeadTypeForecast> LeadTypeForecastByRow { get; set; }
		[CProperty(Association ="OppDepartmentForecast:RowId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastByRow { get; set; }
		#endregion
	}
}
