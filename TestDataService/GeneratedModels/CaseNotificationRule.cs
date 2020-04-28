using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseNotificationRule")]
	public class CaseNotificationRule : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CaseCategoryId")]
		public Guid CaseCategoryId { get; set; }
		[CProperty(ColumnPath ="CaseStatusId")]
		public Guid CaseStatusId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Delay")]
		public int Delay { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="EmailTemplateId")]
		public Guid EmailTemplateId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsQuoteOriginalEmail")]
		public bool IsQuoteOriginalEmail { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RuleUsageId")]
		public Guid RuleUsageId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseCategory:CaseCategoryId")]
		public CaseCategory CaseCategory { get; set; }
		[CProperty(Navigation ="CaseStatus:CaseStatusId")]
		public CaseStatus CaseStatus { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EmailTemplate:EmailTemplateId")]
		public EmailTemplate EmailTemplate { get; set; }
		[CProperty(Navigation ="NotificationRuleUsage:RuleUsageId")]
		public NotificationRuleUsage RuleUsage { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
