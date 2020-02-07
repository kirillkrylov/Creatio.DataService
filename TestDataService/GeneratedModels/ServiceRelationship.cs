using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ServiceRelationship")]
	public class ServiceRelationship : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DependencyCategoryId")]
		public Guid DependencyCategoryId { get; set; }
		[CProperty(ColumnPath ="DependencyTypeId")]
		public Guid DependencyTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ServiceItemAId")]
		public Guid ServiceItemAId { get; set; }
		[CProperty(ColumnPath ="ServiceItemBId")]
		public Guid ServiceItemBId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DependencyCategory:DependencyCategoryId")]
		public DependencyCategory DependencyCategory { get; set; }
		[CProperty(Navigation ="DependencyType:DependencyTypeId")]
		public DependencyType DependencyType { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemAId")]
		public ServiceItem ServiceItemA { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemBId")]
		public ServiceItem ServiceItemB { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
