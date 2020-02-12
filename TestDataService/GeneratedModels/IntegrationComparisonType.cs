using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "IntegrationComparisonType")]
	public class IntegrationComparisonType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
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
		[CProperty(Association ="IntegrationFilter:ComparisonTypeId")]
		public virtual ICollection<IntegrationFilter> IntegrationFilterByComparisonType { get; set; }
		[CProperty(Association ="SyncColumn:ComparisonSignId")]
		public virtual ICollection<SyncColumn> SyncColumnByComparisonSign { get; set; }
		[CProperty(Association ="TableIntegrationFilter:ComparisonTypeId")]
		public virtual ICollection<TableIntegrationFilter> TableIntegrationFilterByComparisonType { get; set; }
		#endregion
	}
}
