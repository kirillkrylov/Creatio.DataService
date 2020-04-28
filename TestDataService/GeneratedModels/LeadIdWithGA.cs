using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadIdWithGA")]
	public class LeadIdWithGA : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CustomerIP")]
		public string CustomerIP { get; set; }
		[CProperty(ColumnPath ="GoogleAnalytics")]
		public string GoogleAnalytics { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="LeadId")]
		public string LeadId { get; set; }
		[CProperty(ColumnPath ="MarketingActivity")]
		public string MarketingActivity { get; set; }
		[CProperty(ColumnPath ="Partner")]
		public string Partner { get; set; }
		[CProperty(ColumnPath ="UTMCampaign")]
		public string UTMCampaign { get; set; }
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
