using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountIndustry")]
	public class AccountIndustry : BaseEntity
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
		[CProperty(Association ="Account:IndustryId")]
		public virtual ICollection<Account> AccountByIndustry { get; set; }
		[CProperty(Association ="Event:IndustryId")]
		public virtual ICollection<Event> EventByIndustry { get; set; }
		[CProperty(Association ="Lead:IndustryId")]
		public virtual ICollection<Lead> LeadByIndustry { get; set; }
		[CProperty(Association ="LeadQualification:IndustryId")]
		public virtual ICollection<LeadQualification> LeadQualificationByIndustry { get; set; }
		#endregion
	}
}
