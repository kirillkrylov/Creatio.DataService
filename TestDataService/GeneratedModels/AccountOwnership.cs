using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountOwnership")]
	public class AccountOwnership : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:OwnershipId")]
		public virtual ICollection<Account> AccountByOwnership { get; set; }
		[CProperty(Association ="Lead:AccountOwnershipId")]
		public virtual ICollection<Lead> LeadByAccountOwnership { get; set; }
		[CProperty(Association ="LeadQualification:OwnershipId")]
		public virtual ICollection<LeadQualification> LeadQualificationByOwnership { get; set; }
		[CProperty(Association ="VwLead:AccountOwnershipId")]
		public virtual ICollection<VwLead> VwLeadByAccountOwnership { get; set; }
		#endregion
	}
}
