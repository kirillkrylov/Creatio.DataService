using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BpmPreferences")]
	public class BpmPreferences : BaseEntity
	{
		#region Values
		private string _BpmEntityID;
		[CProperty(ColumnPath ="BpmEntityID")]
		public string BpmEntityID
		{
			get{return _BpmEntityID;}
			set
			{
				_BpmEntityID = value;
				OnPropertyChanged();
			}
		}
		private string _BpmEntitySchemaUId;
		[CProperty(ColumnPath ="BpmEntitySchemaUId")]
		public string BpmEntitySchemaUId
		{
			get{return _BpmEntitySchemaUId;}
			set
			{
				_BpmEntitySchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmGDPRId;
		[CProperty(ColumnPath ="BpmGDPRId")]
		public Guid BpmGDPRId
		{
			get{return _BpmGDPRId;}
			set
			{
				_BpmGDPRId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmLandingId;
		[CProperty(ColumnPath ="BpmLandingId")]
		public Guid BpmLandingId
		{
			get{return _BpmLandingId;}
			set
			{
				_BpmLandingId = value;
				OnPropertyChanged();
			}
		}
		private string _BpmLink;
		[CProperty(ColumnPath ="BpmLink")]
		public string BpmLink
		{
			get{return _BpmLink;}
			set
			{
				_BpmLink = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmObjectId;
		[CProperty(ColumnPath ="BpmObjectId")]
		public Guid BpmObjectId
		{
			get{return _BpmObjectId;}
			set
			{
				_BpmObjectId = value;
				OnPropertyChanged();
			}
		}
		private bool _BpmOK;
		[CProperty(ColumnPath ="BpmOK")]
		public bool BpmOK
		{
			get{return _BpmOK;}
			set
			{
				_BpmOK = value;
				OnPropertyChanged();
			}
		}
		private DateTime _BpmPermissionDueDate;
		[CProperty(ColumnPath ="BpmPermissionDueDate")]
		public DateTime BpmPermissionDueDate
		{
			get{return _BpmPermissionDueDate;}
			set
			{
				_BpmPermissionDueDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmPreferenceTypeId;
		[CProperty(ColumnPath ="BpmPreferenceTypeId")]
		public Guid BpmPreferenceTypeId
		{
			get{return _BpmPreferenceTypeId;}
			set
			{
				_BpmPreferenceTypeId = value;
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
		[CProperty(Navigation ="BpmGDPR:BpmGDPRId")]
		public BpmGDPR BpmGDPR { get; set; }
		[CProperty(Navigation ="BpmPreferenceType:BpmPreferenceTypeId")]
		public BpmPreferenceType BpmPreferenceType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GeneratedWebForm:BpmLandingId")]
		public GeneratedWebForm BpmLanding { get; set; }
		[CProperty(Navigation ="SysModuleFolder:BpmObjectId")]
		public SysModuleFolder BpmObject { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
