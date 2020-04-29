using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Sites")]
	public class Sites : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private string _BPMPkgCode;
		[CProperty(ColumnPath ="BPMPkgCode")]
		public string BPMPkgCode
		{
			get{return _BPMPkgCode;}
			set
			{
				_BPMPkgCode = value;
				OnPropertyChanged();
			}
		}
		private string _BPMPkgProductCode;
		[CProperty(ColumnPath ="BPMPkgProductCode")]
		public string BPMPkgProductCode
		{
			get{return _BPMPkgProductCode;}
			set
			{
				_BPMPkgProductCode = value;
				OnPropertyChanged();
			}
		}
		private string _BPMPkgProductName;
		[CProperty(ColumnPath ="BPMPkgProductName")]
		public string BPMPkgProductName
		{
			get{return _BPMPkgProductName;}
			set
			{
				_BPMPkgProductName = value;
				OnPropertyChanged();
			}
		}
		private string _BPMPkgState;
		[CProperty(ColumnPath ="BPMPkgState")]
		public string BPMPkgState
		{
			get{return _BPMPkgState;}
			set
			{
				_BPMPkgState = value;
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
		private string _DatabaseServer;
		[CProperty(ColumnPath ="DatabaseServer")]
		public string DatabaseServer
		{
			get{return _DatabaseServer;}
			set
			{
				_DatabaseServer = value;
				OnPropertyChanged();
			}
		}
		private string _DataCenter;
		[CProperty(ColumnPath ="DataCenter")]
		public string DataCenter
		{
			get{return _DataCenter;}
			set
			{
				_DataCenter = value;
				OnPropertyChanged();
			}
		}
		private string _DataCenterDescription;
		[CProperty(ColumnPath ="DataCenterDescription")]
		public string DataCenterDescription
		{
			get{return _DataCenterDescription;}
			set
			{
				_DataCenterDescription = value;
				OnPropertyChanged();
			}
		}
		private string _DataCenterDomain;
		[CProperty(ColumnPath ="DataCenterDomain")]
		public string DataCenterDomain
		{
			get{return _DataCenterDomain;}
			set
			{
				_DataCenterDomain = value;
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
		private string _RedisServer;
		[CProperty(ColumnPath ="RedisServer")]
		public string RedisServer
		{
			get{return _RedisServer;}
			set
			{
				_RedisServer = value;
				OnPropertyChanged();
			}
		}
		private string _ServerBlock;
		[CProperty(ColumnPath ="ServerBlock")]
		public string ServerBlock
		{
			get{return _ServerBlock;}
			set
			{
				_ServerBlock = value;
				OnPropertyChanged();
			}
		}
		private string _ServerBlockDescription;
		[CProperty(ColumnPath ="ServerBlockDescription")]
		public string ServerBlockDescription
		{
			get{return _ServerBlockDescription;}
			set
			{
				_ServerBlockDescription = value;
				OnPropertyChanged();
			}
		}
		private string _Site;
		[CProperty(ColumnPath ="Site")]
		public string Site
		{
			get{return _Site;}
			set
			{
				_Site = value;
				OnPropertyChanged();
			}
		}
		private string _SiteDescription;
		[CProperty(ColumnPath ="SiteDescription")]
		public string SiteDescription
		{
			get{return _SiteDescription;}
			set
			{
				_SiteDescription = value;
				OnPropertyChanged();
			}
		}
		private int _SitesId;
		[CProperty(ColumnPath ="SitesId")]
		public int SitesId
		{
			get{return _SitesId;}
			set
			{
				_SitesId = value;
				OnPropertyChanged();
			}
		}
		private string _SiteState;
		[CProperty(ColumnPath ="SiteState")]
		public string SiteState
		{
			get{return _SiteState;}
			set
			{
				_SiteState = value;
				OnPropertyChanged();
			}
		}
		private string _SiteURL;
		[CProperty(ColumnPath ="SiteURL")]
		public string SiteURL
		{
			get{return _SiteURL;}
			set
			{
				_SiteURL = value;
				OnPropertyChanged();
			}
		}
		private Guid _SubscribeId;
		[CProperty(ColumnPath ="SubscribeId")]
		public Guid SubscribeId
		{
			get{return _SubscribeId;}
			set
			{
				_SubscribeId = value;
				OnPropertyChanged();
			}
		}
		private string _VirtualizationParams;
		[CProperty(ColumnPath ="VirtualizationParams")]
		public string VirtualizationParams
		{
			get{return _VirtualizationParams;}
			set
			{
				_VirtualizationParams = value;
				OnPropertyChanged();
			}
		}
		private string _VirtualizationTypeCode;
		[CProperty(ColumnPath ="VirtualizationTypeCode")]
		public string VirtualizationTypeCode
		{
			get{return _VirtualizationTypeCode;}
			set
			{
				_VirtualizationTypeCode = value;
				OnPropertyChanged();
			}
		}
		private string _VirtualizationTypeName;
		[CProperty(ColumnPath ="VirtualizationTypeName")]
		public string VirtualizationTypeName
		{
			get{return _VirtualizationTypeName;}
			set
			{
				_VirtualizationTypeName = value;
				OnPropertyChanged();
			}
		}
		private string _WebServer;
		[CProperty(ColumnPath ="WebServer")]
		public string WebServer
		{
			get{return _WebServer;}
			set
			{
				_WebServer = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SocialSubscription:SubscribeId")]
		public SocialSubscription Subscribe { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
