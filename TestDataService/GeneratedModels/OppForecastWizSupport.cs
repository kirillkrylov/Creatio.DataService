using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OppForecastWizSupport")]
	public class OppForecastWizSupport : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Days")]
		public int Days { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="SupportLevelId")]
		public Guid SupportLevelId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OrderProductPeriod:PeriodId")]
		public OrderProductPeriod Period { get; set; }
		[CProperty(Navigation ="SupportLevel:SupportLevelId")]
		public SupportLevel SupportLevel { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
