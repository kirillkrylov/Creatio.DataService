using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ServiceInConfItem")]
	public class ServiceInConfItem : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DependencyCategoryId")]
		public Guid DependencyCategoryId { get; set; }
		[CProperty(ColumnPath ="DependencyTypeId")]
		public Guid DependencyTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ServiceItemId")]
		public Guid ServiceItemId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="ConfItem:ConfItemId")]
		public ConfItem ConfItem { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DependencyCategory:DependencyCategoryId")]
		public DependencyCategory DependencyCategory { get; set; }
		[CProperty(Navigation ="DependencyType:DependencyTypeId")]
		public DependencyType DependencyType { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemId")]
		public ServiceItem ServiceItem { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
