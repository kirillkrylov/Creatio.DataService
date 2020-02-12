using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ScreenResult")]
	public class ScreenResult : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountBillingInfoId")]
		public Guid AccountBillingInfoId { get; set; }
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="BOE")]
		public bool BOE { get; set; }
		[CProperty(ColumnPath ="CFSP")]
		public bool CFSP { get; set; }
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DJSOR")]
		public bool DJSOR { get; set; }
		[CProperty(ColumnPath ="DPL")]
		public bool DPL { get; set; }
		[CProperty(ColumnPath ="EL")]
		public bool EL { get; set; }
		[CProperty(ColumnPath ="Email")]
		public string Email { get; set; }
		[CProperty(ColumnPath ="EUL")]
		public bool EUL { get; set; }
		[CProperty(ColumnPath ="EURUDU")]
		public bool EURUDU { get; set; }
		[CProperty(ColumnPath ="EURUKM")]
		public bool EURUKM { get; set; }
		[CProperty(ColumnPath ="Fax")]
		public string Fax { get; set; }
		[CProperty(ColumnPath ="FINCEN")]
		public bool FINCEN { get; set; }
		[CProperty(ColumnPath ="GoodGuy")]
		public bool GoodGuy { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsActual")]
		public bool IsActual { get; set; }
		[CProperty(ColumnPath ="LADP")]
		public bool LADP { get; set; }
		[CProperty(ColumnPath ="LSDP")]
		public bool LSDP { get; set; }
		[CProperty(ColumnPath ="MatchFound")]
		public bool MatchFound { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="NPS")]
		public bool NPS { get; set; }
		[CProperty(ColumnPath ="OFACCSL")]
		public bool OFACCSL { get; set; }
		[CProperty(ColumnPath ="Organization")]
		public string Organization { get; set; }
		[CProperty(ColumnPath ="PhoneNumber")]
		public string PhoneNumber { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId { get; set; }
		[CProperty(ColumnPath ="ScreeningDate")]
		public DateTime ScreeningDate { get; set; }
		[CProperty(ColumnPath ="ScreeningEvent")]
		public string ScreeningEvent { get; set; }
		[CProperty(ColumnPath ="ScreeningInitiatorId")]
		public Guid ScreeningInitiatorId { get; set; }
		[CProperty(ColumnPath ="ScreeningResultStatusId")]
		public Guid ScreeningResultStatusId { get; set; }
		[CProperty(ColumnPath ="SDN")]
		public bool SDN { get; set; }
		[CProperty(ColumnPath ="Street")]
		public string Street { get; set; }
		[CProperty(ColumnPath ="UKUASL")]
		public bool UKUASL { get; set; }
		[CProperty(ColumnPath ="UL")]
		public bool UL { get; set; }
		[CProperty(ColumnPath ="WBL")]
		public bool WBL { get; set; }
		[CProperty(ColumnPath ="WithoutIntegration")]
		public bool WithoutIntegration { get; set; }
		[CProperty(ColumnPath ="ZipCode")]
		public string ZipCode { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:AccountBillingInfoId")]
		public AccountBillingInfo AccountBillingInfo { get; set; }
		[CProperty(Navigation ="City:CityId")]
		public City City { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ScreeningInitiatorId")]
		public Contact ScreeningInitiator { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="Region:RegionId")]
		public Region Region { get; set; }
		[CProperty(Navigation ="ScreeningResultStatus:ScreeningResultStatusId")]
		public ScreeningResultStatus ScreeningResultStatus { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="RestrictedParties:ScreeningResultId")]
		public virtual ICollection<RestrictedParties> RestrictedPartiesByScreeningResult { get; set; }
		[CProperty(Association ="ScreenResultFile:ScreenResultId")]
		public virtual ICollection<ScreenResultFile> ScreenResultFileByScreenResult { get; set; }
		[CProperty(Association ="ScreenResultInFolder:ScreenResultId")]
		public virtual ICollection<ScreenResultInFolder> ScreenResultInFolderByScreenResult { get; set; }
		[CProperty(Association ="ScreenResultInTag:EntityId")]
		public virtual ICollection<ScreenResultInTag> ScreenResultInTagByEntity { get; set; }
		[CProperty(Association ="ScreenResultVisa:ScreenResultId")]
		public virtual ICollection<ScreenResultVisa> ScreenResultVisaByScreenResult { get; set; }
		#endregion
	}
}
