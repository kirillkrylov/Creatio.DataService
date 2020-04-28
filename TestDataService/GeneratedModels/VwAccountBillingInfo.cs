using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwAccountBillingInfo")]
	public class VwAccountBillingInfo : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountBillingInfoId")]
		public Guid AccountBillingInfoId { get; set; }
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="City")]
		public string City { get; set; }
		[CProperty(ColumnPath ="CountryISO")]
		public string CountryISO { get; set; }
		[CProperty(ColumnPath ="DateOfBirth")]
		public DateTime DateOfBirth { get; set; }
		[CProperty(ColumnPath ="District")]
		public string District { get; set; }
		[CProperty(ColumnPath ="Email")]
		public string Email { get; set; }
		[CProperty(ColumnPath ="Fax")]
		public string Fax { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Name1")]
		public string Name1 { get; set; }
		[CProperty(ColumnPath ="Name2")]
		public string Name2 { get; set; }
		[CProperty(ColumnPath ="NameWithoutOwnership")]
		public string NameWithoutOwnership { get; set; }
		[CProperty(ColumnPath ="Pc")]
		public string Pc { get; set; }
		[CProperty(ColumnPath ="Position")]
		public string Position { get; set; }
		[CProperty(ColumnPath ="ReferenceComment")]
		public Guid ReferenceComment { get; set; }
		[CProperty(ColumnPath ="ReferenceId")]
		public Guid ReferenceId { get; set; }
		[CProperty(ColumnPath ="Street")]
		public string Street { get; set; }
		[CProperty(ColumnPath ="Surname")]
		public string Surname { get; set; }
		[CProperty(ColumnPath ="TelNo")]
		public string TelNo { get; set; }
		[CProperty(ColumnPath ="Title")]
		public string Title { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="AccountBillingInfo:AccountBillingInfoId")]
		public AccountBillingInfo AccountBillingInfo { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
