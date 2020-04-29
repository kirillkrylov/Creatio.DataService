using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysInstalledApp")]
	public class SysInstalledApp : BaseEntity
	{
		#region Values
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private string _FileLink;
		[CProperty(ColumnPath ="FileLink")]
		public string FileLink
		{
			get{return _FileLink;}
			set
			{
				_FileLink = value;
				OnPropertyChanged();
			}
		}
		private string _HelpLink;
		[CProperty(ColumnPath ="HelpLink")]
		public string HelpLink
		{
			get{return _HelpLink;}
			set
			{
				_HelpLink = value;
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
		private DateTime _InstallDate;
		[CProperty(ColumnPath ="InstallDate")]
		public DateTime InstallDate
		{
			get{return _InstallDate;}
			set
			{
				_InstallDate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LastUpdate;
		[CProperty(ColumnPath ="LastUpdate")]
		public DateTime LastUpdate
		{
			get{return _LastUpdate;}
			set
			{
				_LastUpdate = value;
				OnPropertyChanged();
			}
		}
		private string _Maintainer;
		[CProperty(ColumnPath ="Maintainer")]
		public string Maintainer
		{
			get{return _Maintainer;}
			set
			{
				_Maintainer = value;
				OnPropertyChanged();
			}
		}
		private string _MarketplaceLink;
		[CProperty(ColumnPath ="MarketplaceLink")]
		public string MarketplaceLink
		{
			get{return _MarketplaceLink;}
			set
			{
				_MarketplaceLink = value;
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
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private string _OrderLink;
		[CProperty(ColumnPath ="OrderLink")]
		public string OrderLink
		{
			get{return _OrderLink;}
			set
			{
				_OrderLink = value;
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
		private string _SupportEmail;
		[CProperty(ColumnPath ="SupportEmail")]
		public string SupportEmail
		{
			get{return _SupportEmail;}
			set
			{
				_SupportEmail = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysInstalledAppStatusId;
		[CProperty(ColumnPath ="SysInstalledAppStatusId")]
		public Guid SysInstalledAppStatusId
		{
			get{return _SysInstalledAppStatusId;}
			set
			{
				_SysInstalledAppStatusId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysInstalledAppStatus:SysInstalledAppStatusId")]
		public SysInstalledAppStatus SysInstalledAppStatus { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysPackageInInstalledApp:SysInstalledAppId")]
		public virtual ICollection<SysPackageInInstalledApp> SysPackageInInstalledAppBySysInstalledApp { get; set; }
		#endregion
	}
}
