using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SiteEventType")]
	public class SiteEventType : BaseEntity
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
		private string _Identifier;
		[CProperty(ColumnPath ="Identifier")]
		public string Identifier
		{
			get{return _Identifier;}
			set
			{
				_Identifier = value;
				OnPropertyChanged();
			}
		}
		private bool _IsActive;
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive
		{
			get{return _IsActive;}
			set
			{
				_IsActive = value;
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
		private Guid _ScoringEventTypeId;
		[CProperty(ColumnPath ="ScoringEventTypeId")]
		public Guid ScoringEventTypeId
		{
			get{return _ScoringEventTypeId;}
			set
			{
				_ScoringEventTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SelectorTypeId;
		[CProperty(ColumnPath ="SelectorTypeId")]
		public Guid SelectorTypeId
		{
			get{return _SelectorTypeId;}
			set
			{
				_SelectorTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _WebsiteEventTypeId;
		[CProperty(ColumnPath ="WebsiteEventTypeId")]
		public Guid WebsiteEventTypeId
		{
			get{return _WebsiteEventTypeId;}
			set
			{
				_WebsiteEventTypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ScoringEventType:ScoringEventTypeId")]
		public ScoringEventType ScoringEventType { get; set; }
		[CProperty(Navigation ="SelectorType:SelectorTypeId")]
		public SelectorType SelectorType { get; set; }
		[CProperty(Navigation ="WebsiteEventType:WebsiteEventTypeId")]
		public WebsiteEventType WebsiteEventType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SiteEvent:SiteEventTypeId")]
		public virtual ICollection<SiteEvent> SiteEventBySiteEventType { get; set; }
		[CProperty(Association ="SiteEventTypeFile:SiteEventTypeId")]
		public virtual ICollection<SiteEventTypeFile> SiteEventTypeFileBySiteEventType { get; set; }
		[CProperty(Association ="SiteEventTypeInFolder:SiteEventTypeId")]
		public virtual ICollection<SiteEventTypeInFolder> SiteEventTypeInFolderBySiteEventType { get; set; }
		[CProperty(Association ="SiteEventTypeInTag:EntityId")]
		public virtual ICollection<SiteEventTypeInTag> SiteEventTypeInTagByEntity { get; set; }
		[CProperty(Association ="VwSiteEvent:SiteEventTypeId")]
		public virtual ICollection<VwSiteEvent> VwSiteEventBySiteEventType { get; set; }
		#endregion
	}
}
