using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SiteStatUserSession")]
	public class SiteStatUserSession : BaseEntity
	{
		#region Values
		private string _ContactName;
		[CProperty(ColumnPath ="ContactName")]
		public string ContactName
		{
			get{return _ContactName;}
			set
			{
				_ContactName = value;
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
		private int _SessionCount;
		[CProperty(ColumnPath ="SessionCount")]
		public int SessionCount
		{
			get{return _SessionCount;}
			set
			{
				_SessionCount = value;
				OnPropertyChanged();
			}
		}
		private Guid _SiteStatId;
		[CProperty(ColumnPath ="SiteStatId")]
		public Guid SiteStatId
		{
			get{return _SiteStatId;}
			set
			{
				_SiteStatId = value;
				OnPropertyChanged();
			}
		}
		private string _UserName;
		[CProperty(ColumnPath ="UserName")]
		public string UserName
		{
			get{return _UserName;}
			set
			{
				_UserName = value;
				OnPropertyChanged();
			}
		}
		private string _UserType;
		[CProperty(ColumnPath ="UserType")]
		public string UserType
		{
			get{return _UserType;}
			set
			{
				_UserType = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SiteStat:SiteStatId")]
		public SiteStat SiteStat { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
