using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PsDeliveryStatus")]
	public class PsDeliveryStatus : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Color")]
		public string Color { get; set; }
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
		[CProperty(ColumnPath ="OrderPosition")]
		public int OrderPosition { get; set; }
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
		[CProperty(Association ="PsDelivery:StatusId")]
		public virtual ICollection<PsDelivery> PsDeliveryByStatus { get; set; }
		[CProperty(Association ="PsDeliveryStatusDecoupling:CurrentStatusId")]
		public virtual ICollection<PsDeliveryStatusDecoupling> PsDeliveryStatusDecouplingByCurrentStatus { get; set; }
		[CProperty(Association ="PsDeliveryStatusDecoupling:NextStatusId")]
		public virtual ICollection<PsDeliveryStatusDecoupling> PsDeliveryStatusDecouplingByNextStatus { get; set; }
		#endregion
	}
}
