using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ServicePactType")]
	public class ServicePactType : BaseEntity
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
		[CProperty(Association ="ProductInServicePact:ServicePactTypeId")]
		public virtual ICollection<ProductInServicePact> ProductInServicePactByServicePactType { get; set; }
		[CProperty(Association ="ServiceCalendar:SLATypeId")]
		public virtual ICollection<ServiceCalendar> ServiceCalendarBySLAType { get; set; }
		[CProperty(Association ="ServicePact:TypeId")]
		public virtual ICollection<ServicePact> ServicePactByType { get; set; }
		[CProperty(Association ="VwProductSLA:ServicePactTypeId")]
		public virtual ICollection<VwProductSLA> VwProductSLAByServicePactType { get; set; }
		#endregion
	}
}
