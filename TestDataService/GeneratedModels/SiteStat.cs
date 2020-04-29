using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SiteStat")]
	public class SiteStat : BaseEntity
	{
		#region Values
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
		private Guid _SiteId;
		[CProperty(ColumnPath ="SiteId")]
		public Guid SiteId
		{
			get{return _SiteId;}
			set
			{
				_SiteId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StatDate;
		[CProperty(ColumnPath ="StatDate")]
		public DateTime StatDate
		{
			get{return _StatDate;}
			set
			{
				_StatDate = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="ConfItem:SiteId")]
		public ConfItem Site { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SiteStatAddValue:SiteStatId")]
		public virtual ICollection<SiteStatAddValue> SiteStatAddValueBySiteStat { get; set; }
		[CProperty(Association ="SiteStatModuleUsageHistory:SiteStatId")]
		public virtual ICollection<SiteStatModuleUsageHistory> SiteStatModuleUsageHistoryBySiteStat { get; set; }
		[CProperty(Association ="SiteStatUserSession:SiteStatId")]
		public virtual ICollection<SiteStatUserSession> SiteStatUserSessionBySiteStat { get; set; }
		#endregion
	}
}
