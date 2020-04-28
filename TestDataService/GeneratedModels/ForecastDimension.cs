using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ForecastDimension")]
	public class ForecastDimension : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DimensionId")]
		public Guid DimensionId { get; set; }
		[CProperty(ColumnPath ="ForecastId")]
		public Guid ForecastId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Level")]
		public int Level { get; set; }
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
		[CProperty(Navigation ="Dimension:DimensionId")]
		public Dimension Dimension { get; set; }
		[CProperty(Navigation ="Forecast:ForecastId")]
		public Forecast Forecast { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ForecastItem:ForecastDimensionId")]
		public virtual ICollection<ForecastItem> ForecastItemByForecastDimension { get; set; }
		#endregion
	}
}
