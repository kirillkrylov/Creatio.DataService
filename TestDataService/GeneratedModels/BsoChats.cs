using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BsoChats")]
	public class BsoChats : BaseEntity
	{
		#region Values
		private string _BsoChatId;
		[CProperty(ColumnPath ="BsoChatId")]
		public string BsoChatId
		{
			get{return _BsoChatId;}
			set
			{
				_BsoChatId = value;
				OnPropertyChanged();
			}
		}
		private string _BsoCity;
		[CProperty(ColumnPath ="BsoCity")]
		public string BsoCity
		{
			get{return _BsoCity;}
			set
			{
				_BsoCity = value;
				OnPropertyChanged();
			}
		}
		private Guid _BsoContactId;
		[CProperty(ColumnPath ="BsoContactId")]
		public Guid BsoContactId
		{
			get{return _BsoContactId;}
			set
			{
				_BsoContactId = value;
				OnPropertyChanged();
			}
		}
		private string _BsoCountry;
		[CProperty(ColumnPath ="BsoCountry")]
		public string BsoCountry
		{
			get{return _BsoCountry;}
			set
			{
				_BsoCountry = value;
				OnPropertyChanged();
			}
		}
		private string _BsoCountryCode;
		[CProperty(ColumnPath ="BsoCountryCode")]
		public string BsoCountryCode
		{
			get{return _BsoCountryCode;}
			set
			{
				_BsoCountryCode = value;
				OnPropertyChanged();
			}
		}
		private DateTime _BsoDate;
		[CProperty(ColumnPath ="BsoDate")]
		public DateTime BsoDate
		{
			get{return _BsoDate;}
			set
			{
				_BsoDate = value;
				OnPropertyChanged();
			}
		}
		private string _BsoDescription;
		[CProperty(ColumnPath ="BsoDescription")]
		public string BsoDescription
		{
			get{return _BsoDescription;}
			set
			{
				_BsoDescription = value;
				OnPropertyChanged();
			}
		}
		private string _BsoEmail;
		[CProperty(ColumnPath ="BsoEmail")]
		public string BsoEmail
		{
			get{return _BsoEmail;}
			set
			{
				_BsoEmail = value;
				OnPropertyChanged();
			}
		}
		private bool _BsoIsMissed;
		[CProperty(ColumnPath ="BsoIsMissed")]
		public bool BsoIsMissed
		{
			get{return _BsoIsMissed;}
			set
			{
				_BsoIsMissed = value;
				OnPropertyChanged();
			}
		}
		private string _BsoLatitude;
		[CProperty(ColumnPath ="BsoLatitude")]
		public string BsoLatitude
		{
			get{return _BsoLatitude;}
			set
			{
				_BsoLatitude = value;
				OnPropertyChanged();
			}
		}
		private Guid _BsoLeadId;
		[CProperty(ColumnPath ="BsoLeadId")]
		public Guid BsoLeadId
		{
			get{return _BsoLeadId;}
			set
			{
				_BsoLeadId = value;
				OnPropertyChanged();
			}
		}
		private string _BsoLongitude;
		[CProperty(ColumnPath ="BsoLongitude")]
		public string BsoLongitude
		{
			get{return _BsoLongitude;}
			set
			{
				_BsoLongitude = value;
				OnPropertyChanged();
			}
		}
		private string _BsoName;
		[CProperty(ColumnPath ="BsoName")]
		public string BsoName
		{
			get{return _BsoName;}
			set
			{
				_BsoName = value;
				OnPropertyChanged();
			}
		}
		private bool _BsoOfflineMessage;
		[CProperty(ColumnPath ="BsoOfflineMessage")]
		public bool BsoOfflineMessage
		{
			get{return _BsoOfflineMessage;}
			set
			{
				_BsoOfflineMessage = value;
				OnPropertyChanged();
			}
		}
		private string _BsoOrganization;
		[CProperty(ColumnPath ="BsoOrganization")]
		public string BsoOrganization
		{
			get{return _BsoOrganization;}
			set
			{
				_BsoOrganization = value;
				OnPropertyChanged();
			}
		}
		private string _BsoOwnerEmail;
		[CProperty(ColumnPath ="BsoOwnerEmail")]
		public string BsoOwnerEmail
		{
			get{return _BsoOwnerEmail;}
			set
			{
				_BsoOwnerEmail = value;
				OnPropertyChanged();
			}
		}
		private Guid _BsoOwnerId;
		[CProperty(ColumnPath ="BsoOwnerId")]
		public Guid BsoOwnerId
		{
			get{return _BsoOwnerId;}
			set
			{
				_BsoOwnerId = value;
				OnPropertyChanged();
			}
		}
		private string _BsoPagetitle;
		[CProperty(ColumnPath ="BsoPagetitle")]
		public string BsoPagetitle
		{
			get{return _BsoPagetitle;}
			set
			{
				_BsoPagetitle = value;
				OnPropertyChanged();
			}
		}
		private string _BsoPageUrl;
		[CProperty(ColumnPath ="BsoPageUrl")]
		public string BsoPageUrl
		{
			get{return _BsoPageUrl;}
			set
			{
				_BsoPageUrl = value;
				OnPropertyChanged();
			}
		}
		private string _BsoPhone;
		[CProperty(ColumnPath ="BsoPhone")]
		public string BsoPhone
		{
			get{return _BsoPhone;}
			set
			{
				_BsoPhone = value;
				OnPropertyChanged();
			}
		}
		private string _BsoRegion;
		[CProperty(ColumnPath ="BsoRegion")]
		public string BsoRegion
		{
			get{return _BsoRegion;}
			set
			{
				_BsoRegion = value;
				OnPropertyChanged();
			}
		}
		private string _BsoRegionCode;
		[CProperty(ColumnPath ="BsoRegionCode")]
		public string BsoRegionCode
		{
			get{return _BsoRegionCode;}
			set
			{
				_BsoRegionCode = value;
				OnPropertyChanged();
			}
		}
		private string _BsoSocial;
		[CProperty(ColumnPath ="BsoSocial")]
		public string BsoSocial
		{
			get{return _BsoSocial;}
			set
			{
				_BsoSocial = value;
				OnPropertyChanged();
			}
		}
		private string _BsoSocialUrl;
		[CProperty(ColumnPath ="BsoSocialUrl")]
		public string BsoSocialUrl
		{
			get{return _BsoSocialUrl;}
			set
			{
				_BsoSocialUrl = value;
				OnPropertyChanged();
			}
		}
		private string _BsoUtmCampaign;
		[CProperty(ColumnPath ="BsoUtmCampaign")]
		public string BsoUtmCampaign
		{
			get{return _BsoUtmCampaign;}
			set
			{
				_BsoUtmCampaign = value;
				OnPropertyChanged();
			}
		}
		private string _BsoUtmMedium;
		[CProperty(ColumnPath ="BsoUtmMedium")]
		public string BsoUtmMedium
		{
			get{return _BsoUtmMedium;}
			set
			{
				_BsoUtmMedium = value;
				OnPropertyChanged();
			}
		}
		private string _BsoUtmSource;
		[CProperty(ColumnPath ="BsoUtmSource")]
		public string BsoUtmSource
		{
			get{return _BsoUtmSource;}
			set
			{
				_BsoUtmSource = value;
				OnPropertyChanged();
			}
		}
		private string _BsoVisitor;
		[CProperty(ColumnPath ="BsoVisitor")]
		public string BsoVisitor
		{
			get{return _BsoVisitor;}
			set
			{
				_BsoVisitor = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
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
