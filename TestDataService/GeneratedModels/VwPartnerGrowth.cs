using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwPartnerGrowth")]
	public class VwPartnerGrowth : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ChurnFrom010418To300319")]
		public decimal ChurnFrom010418To300319 { get; set; }
		[CProperty(ColumnPath ="ChurnFrom010419TillNow")]
		public decimal ChurnFrom010419TillNow { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NewCustomersFrom010418TillNow")]
		public decimal NewCustomersFrom010418TillNow { get; set; }
		[CProperty(ColumnPath ="NewCustomersFrom010418To310319")]
		public decimal NewCustomersFrom010418To310319 { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TotalCustomersForCurrentDate")]
		public decimal TotalCustomersForCurrentDate { get; set; }
		[CProperty(ColumnPath ="TotalCustomersOn010418")]
		public decimal TotalCustomersOn010418 { get; set; }
		[CProperty(ColumnPath ="TotalCustomersOn010419")]
		public decimal TotalCustomersOn010419 { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
