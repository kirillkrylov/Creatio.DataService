using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSiteEvent")]
	public class VwSiteEvent : BaseEntity
	{
		#region Values
		private Guid _BpmSessionId;
		[CProperty(ColumnPath ="BpmSessionId")]
		public Guid BpmSessionId
		{
			get{return _BpmSessionId;}
			set
			{
				_BpmSessionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
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
		private DateTime _EventDate;
		[CProperty(ColumnPath ="EventDate")]
		public DateTime EventDate
		{
			get{return _EventDate;}
			set
			{
				_EventDate = value;
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
		private Guid _LeadId;
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId
		{
			get{return _LeadId;}
			set
			{
				_LeadId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadTypeId;
		[CProperty(ColumnPath ="LeadTypeId")]
		public Guid LeadTypeId
		{
			get{return _LeadTypeId;}
			set
			{
				_LeadTypeId = value;
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
		private Guid _SiteEventTypeId;
		[CProperty(ColumnPath ="SiteEventTypeId")]
		public Guid SiteEventTypeId
		{
			get{return _SiteEventTypeId;}
			set
			{
				_SiteEventTypeId = value;
				OnPropertyChanged();
			}
		}
		private string _Source;
		[CProperty(ColumnPath ="Source")]
		public string Source
		{
			get{return _Source;}
			set
			{
				_Source = value;
				OnPropertyChanged();
			}
		}
		private string _Tag;
		[CProperty(ColumnPath ="Tag")]
		public string Tag
		{
			get{return _Tag;}
			set
			{
				_Tag = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="LeadType:LeadTypeId")]
		public LeadType LeadType { get; set; }
		[CProperty(Navigation ="SiteEventType:SiteEventTypeId")]
		public SiteEventType SiteEventType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
