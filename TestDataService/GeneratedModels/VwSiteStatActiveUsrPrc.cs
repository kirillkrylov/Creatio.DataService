using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSiteStatActiveUsrPrc")]
	public class VwSiteStatActiveUsrPrc : BaseEntity
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
		private decimal _PrecentForWeek;
		[CProperty(ColumnPath ="PrecentForWeek")]
		public decimal PrecentForWeek
		{
			get{return _PrecentForWeek;}
			set
			{
				_PrecentForWeek = value;
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
		private int _WeekNumber;
		[CProperty(ColumnPath ="WeekNumber")]
		public int WeekNumber
		{
			get{return _WeekNumber;}
			set
			{
				_WeekNumber = value;
				OnPropertyChanged();
			}
		}
		private string _YearWeek;
		[CProperty(ColumnPath ="YearWeek")]
		public string YearWeek
		{
			get{return _YearWeek;}
			set
			{
				_YearWeek = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="ConfItem:SiteStatId")]
		public ConfItem SiteStat { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
