using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OppForecastWizPartners")]
	public class OppForecastWizPartners : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="OpportunityPartnerId")]
		public Guid OpportunityPartnerId { get; set; }
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId { get; set; }
		[CProperty(ColumnPath ="PartnerMargin")]
		public decimal PartnerMargin { get; set; }
		[CProperty(ColumnPath ="PartnerMarginPercent")]
		public decimal PartnerMarginPercent { get; set; }
		[CProperty(ColumnPath ="PartnerRoleId")]
		public Guid PartnerRoleId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityPartner:OpportunityPartnerId")]
		public OpportunityPartner OpportunityPartner { get; set; }
		[CProperty(Navigation ="PartnerProjectRole:PartnerRoleId")]
		public PartnerProjectRole PartnerRole { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
