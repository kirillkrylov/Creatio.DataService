using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RestrictedParties")]
	public class RestrictedParties : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AddressTypeId")]
		public Guid AddressTypeId { get; set; }
		[CProperty(ColumnPath ="City")]
		public string City { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Email")]
		public string Email { get; set; }
		[CProperty(ColumnPath ="Fax")]
		public string Fax { get; set; }
		[CProperty(ColumnPath ="hasMoreDetails")]
		public bool hasMoreDetails { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="Info")]
		public string Info { get; set; }
		[CProperty(ColumnPath ="MatchConfirmed")]
		public bool MatchConfirmed { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="name1")]
		public string name1 { get; set; }
		[CProperty(ColumnPath ="name2")]
		public string name2 { get; set; }
		[CProperty(ColumnPath ="name3")]
		public string name3 { get; set; }
		[CProperty(ColumnPath ="name4")]
		public string name4 { get; set; }
		[CProperty(ColumnPath ="Phone")]
		public string Phone { get; set; }
		[CProperty(ColumnPath ="PostalCode")]
		public string PostalCode { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Region")]
		public string Region { get; set; }
		[CProperty(ColumnPath ="restrictionDate")]
		public DateTime restrictionDate { get; set; }
		[CProperty(ColumnPath ="restrictionSource")]
		public string restrictionSource { get; set; }
		[CProperty(ColumnPath ="restrictionType")]
		public string restrictionType { get; set; }
		[CProperty(ColumnPath ="SanctionListFullName")]
		public string SanctionListFullName { get; set; }
		[CProperty(ColumnPath ="SanctionListId")]
		public Guid SanctionListId { get; set; }
		[CProperty(ColumnPath ="ScreeningResultId")]
		public Guid ScreeningResultId { get; set; }
		[CProperty(ColumnPath ="similarity")]
		public decimal similarity { get; set; }
		[CProperty(ColumnPath ="sourceWebLink")]
		public string sourceWebLink { get; set; }
		[CProperty(ColumnPath ="Street")]
		public string Street { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="AddressType:AddressTypeId")]
		public AddressType AddressType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="SanctionList:SanctionListId")]
		public SanctionList SanctionList { get; set; }
		[CProperty(Navigation ="ScreenResult:ScreeningResultId")]
		public ScreenResult ScreeningResult { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
