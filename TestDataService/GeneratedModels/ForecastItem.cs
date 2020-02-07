using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ForecastItem")]
	public class ForecastItem : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DimensionValueId")]
		public Guid DimensionValueId { get; set; }
		[CProperty(ColumnPath ="ForecastDimensionId")]
		public Guid ForecastDimensionId { get; set; }
		[CProperty(ColumnPath ="ForecastId")]
		public Guid ForecastId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsDeleted")]
		public bool IsDeleted { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Forecast:ForecastId")]
		public Forecast Forecast { get; set; }
		[CProperty(Navigation ="ForecastDimension:ForecastDimensionId")]
		public ForecastDimension ForecastDimension { get; set; }
		[CProperty(Navigation ="ForecastItem:ParentId")]
		public ForecastItem Parent { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ForecastItem:ParentId")]
		public virtual ICollection<ForecastItem> ForecastItemByParent { get; set; }
		#endregion
	}
}
