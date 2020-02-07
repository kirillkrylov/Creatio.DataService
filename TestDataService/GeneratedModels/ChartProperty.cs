using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ChartProperty")]
	public class ChartProperty : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ChartAggregationTypeId")]
		public Guid ChartAggregationTypeId { get; set; }
		[CProperty(ColumnPath ="ChartEntityColumn")]
		public byte[] ChartEntityColumn { get; set; }
		[CProperty(ColumnPath ="ChartSeriesKind")]
		public string ChartSeriesKind { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId { get; set; }
		[CProperty(ColumnPath ="Filter")]
		public byte[] Filter { get; set; }
		[CProperty(ColumnPath ="GroupByField")]
		public byte[] GroupByField { get; set; }
		[CProperty(ColumnPath ="GroupByTypeDateTimeId")]
		public Guid GroupByTypeDateTimeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ModuleEntityId")]
		public Guid ModuleEntityId { get; set; }
		[CProperty(ColumnPath ="ModuleObjAccessField")]
		public byte[] ModuleObjAccessField { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OrderByChartPropertyColumn")]
		public string OrderByChartPropertyColumn { get; set; }
		[CProperty(ColumnPath ="OrderDirection")]
		public string OrderDirection { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="XAxisCaption")]
		public string XAxisCaption { get; set; }
		[CProperty(ColumnPath ="YAxisCaption")]
		public string YAxisCaption { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="ChartAggregationType:ChartAggregationTypeId")]
		public ChartAggregationType ChartAggregationType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GroupByTypeDateTime:GroupByTypeDateTimeId")]
		public GroupByTypeDateTime GroupByTypeDateTime { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
