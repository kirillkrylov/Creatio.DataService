using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BsoChats")]
	public class BsoChats : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BsoChatId")]
		public string BsoChatId { get; set; }
		[CProperty(ColumnPath ="BsoCity")]
		public string BsoCity { get; set; }
		[CProperty(ColumnPath ="BsoContactId")]
		public Guid BsoContactId { get; set; }
		[CProperty(ColumnPath ="BsoCountry")]
		public string BsoCountry { get; set; }
		[CProperty(ColumnPath ="BsoCountryCode")]
		public string BsoCountryCode { get; set; }
		[CProperty(ColumnPath ="BsoDate")]
		public DateTime BsoDate { get; set; }
		[CProperty(ColumnPath ="BsoDescription")]
		public string BsoDescription { get; set; }
		[CProperty(ColumnPath ="BsoEmail")]
		public string BsoEmail { get; set; }
		[CProperty(ColumnPath ="BsoIsMissed")]
		public bool BsoIsMissed { get; set; }
		[CProperty(ColumnPath ="BsoLatitude")]
		public string BsoLatitude { get; set; }
		[CProperty(ColumnPath ="BsoLeadId")]
		public Guid BsoLeadId { get; set; }
		[CProperty(ColumnPath ="BsoLongitude")]
		public string BsoLongitude { get; set; }
		[CProperty(ColumnPath ="BsoName")]
		public string BsoName { get; set; }
		[CProperty(ColumnPath ="BsoOfflineMessage")]
		public bool BsoOfflineMessage { get; set; }
		[CProperty(ColumnPath ="BsoOrganization")]
		public string BsoOrganization { get; set; }
		[CProperty(ColumnPath ="BsoOwnerEmail")]
		public string BsoOwnerEmail { get; set; }
		[CProperty(ColumnPath ="BsoOwnerId")]
		public Guid BsoOwnerId { get; set; }
		[CProperty(ColumnPath ="BsoPagetitle")]
		public string BsoPagetitle { get; set; }
		[CProperty(ColumnPath ="BsoPageUrl")]
		public string BsoPageUrl { get; set; }
		[CProperty(ColumnPath ="BsoPhone")]
		public string BsoPhone { get; set; }
		[CProperty(ColumnPath ="BsoRegion")]
		public string BsoRegion { get; set; }
		[CProperty(ColumnPath ="BsoRegionCode")]
		public string BsoRegionCode { get; set; }
		[CProperty(ColumnPath ="BsoSocial")]
		public string BsoSocial { get; set; }
		[CProperty(ColumnPath ="BsoSocialUrl")]
		public string BsoSocialUrl { get; set; }
		[CProperty(ColumnPath ="BsoUtmCampaign")]
		public string BsoUtmCampaign { get; set; }
		[CProperty(ColumnPath ="BsoUtmMedium")]
		public string BsoUtmMedium { get; set; }
		[CProperty(ColumnPath ="BsoUtmSource")]
		public string BsoUtmSource { get; set; }
		[CProperty(ColumnPath ="BsoVisitor")]
		public string BsoVisitor { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:BsoContactId")]
		public Contact BsoContact { get; set; }
		[CProperty(Navigation ="Contact:BsoOwnerId")]
		public Contact BsoOwner { get; set; }
		[CProperty(Navigation ="Lead:BsoLeadId")]
		public Lead BsoLead { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BsoChatMessage:BsoChatId")]
		public virtual ICollection<BsoChatMessage> BsoChatMessageByBsoChat { get; set; }
		[CProperty(Association ="BsoChatsFile:BsoChatsId")]
		public virtual ICollection<BsoChatsFile> BsoChatsFileByBsoChats { get; set; }
		[CProperty(Association ="BsoChatsInFolder:BsoChatsId")]
		public virtual ICollection<BsoChatsInFolder> BsoChatsInFolderByBsoChats { get; set; }
		[CProperty(Association ="BsoChatsInTag:EntityId")]
		public virtual ICollection<BsoChatsInTag> BsoChatsInTagByEntity { get; set; }
		#endregion
	}
}
