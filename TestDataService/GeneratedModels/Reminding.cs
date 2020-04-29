using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Reminding")]
	public class Reminding : BaseEntity
	{
		#region Values
		private DateTime _AnniversaryDate;
		[CProperty(ColumnPath ="AnniversaryDate")]
		public DateTime AnniversaryDate
		{
			get{return _AnniversaryDate;}
			set
			{
				_AnniversaryDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _AuthorId;
		[CProperty(ColumnPath ="AuthorId")]
		public Guid AuthorId
		{
			get{return _AuthorId;}
			set
			{
				_AuthorId = value;
				OnPropertyChanged();
			}
		}
		private string _Config;
		[CProperty(ColumnPath ="Config")]
		public string Config
		{
			get{return _Config;}
			set
			{
				_Config = value;
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
		private string _Hash;
		[CProperty(ColumnPath ="Hash")]
		public string Hash
		{
			get{return _Hash;}
			set
			{
				_Hash = value;
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
		private bool _IsNeedToSend;
		[CProperty(ColumnPath ="IsNeedToSend")]
		public bool IsNeedToSend
		{
			get{return _IsNeedToSend;}
			set
			{
				_IsNeedToSend = value;
				OnPropertyChanged();
			}
		}
		private bool _IsRead;
		[CProperty(ColumnPath ="IsRead")]
		public bool IsRead
		{
			get{return _IsRead;}
			set
			{
				_IsRead = value;
				OnPropertyChanged();
			}
		}
		private Guid _LoaderId;
		[CProperty(ColumnPath ="LoaderId")]
		public Guid LoaderId
		{
			get{return _LoaderId;}
			set
			{
				_LoaderId = value;
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
		private Guid _NotificationTypeId;
		[CProperty(ColumnPath ="NotificationTypeId")]
		public Guid NotificationTypeId
		{
			get{return _NotificationTypeId;}
			set
			{
				_NotificationTypeId = value;
				OnPropertyChanged();
			}
		}
		private string _PopupTitle;
		[CProperty(ColumnPath ="PopupTitle")]
		public string PopupTitle
		{
			get{return _PopupTitle;}
			set
			{
				_PopupTitle = value;
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
		private DateTime _RemindTime;
		[CProperty(ColumnPath ="RemindTime")]
		public DateTime RemindTime
		{
			get{return _RemindTime;}
			set
			{
				_RemindTime = value;
				OnPropertyChanged();
			}
		}
		private Guid _SenderId;
		[CProperty(ColumnPath ="SenderId")]
		public Guid SenderId
		{
			get{return _SenderId;}
			set
			{
				_SenderId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SourceId;
		[CProperty(ColumnPath ="SourceId")]
		public Guid SourceId
		{
			get{return _SourceId;}
			set
			{
				_SourceId = value;
				OnPropertyChanged();
			}
		}
		private string _SubjectCaption;
		[CProperty(ColumnPath ="SubjectCaption")]
		public string SubjectCaption
		{
			get{return _SubjectCaption;}
			set
			{
				_SubjectCaption = value;
				OnPropertyChanged();
			}
		}
		private Guid _SubjectId;
		[CProperty(ColumnPath ="SubjectId")]
		public Guid SubjectId
		{
			get{return _SubjectId;}
			set
			{
				_SubjectId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysEntitySchemaId;
		[CProperty(ColumnPath ="SysEntitySchemaId")]
		public Guid SysEntitySchemaId
		{
			get{return _SysEntitySchemaId;}
			set
			{
				_SysEntitySchemaId = value;
				OnPropertyChanged();
			}
		}
		private string _TypeCaption;
		[CProperty(ColumnPath ="TypeCaption")]
		public string TypeCaption
		{
			get{return _TypeCaption;}
			set
			{
				_TypeCaption = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:AuthorId")]
		public Contact Author { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="NotificationType:NotificationTypeId")]
		public NotificationType NotificationType { get; set; }
		[CProperty(Navigation ="RemindingSource:SourceId")]
		public RemindingSource Source { get; set; }
		[CProperty(Navigation ="VwSysModuleEntity:SysEntitySchemaId")]
		public VwSysModuleEntity SysEntitySchema { get; set; }
		[CProperty(Navigation ="VwSysModuleEntity:LoaderId")]
		public VwSysModuleEntity Loader { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
