using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EventProduct")]
	public class EventProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BrandId")]
		public Guid BrandId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EventId")]
		public Guid EventId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Note")]
		public string Note { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Brand:BrandId")]
		public Brand Brand { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Event:EventId")]
		public Event Event { get; set; }
		[CProperty(Navigation ="Product:ProductId")]
		public Product Product { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
