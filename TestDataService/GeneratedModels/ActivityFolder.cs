using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ActivityFolder")]
	public class ActivityFolder : BaseEntity
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
		private Guid _FolderEmbeddedProcessId;
		[CProperty(ColumnPath ="FolderEmbeddedProcessId")]
		public Guid FolderEmbeddedProcessId
		{
			get{return _FolderEmbeddedProcessId;}
			set
			{
				_FolderEmbeddedProcessId = value;
				OnPropertyChanged();
			}
		}
		private Guid _FolderTypeId;
		[CProperty(ColumnPath ="FolderTypeId")]
		public Guid FolderTypeId
		{
			get{return _FolderTypeId;}
			set
			{
				_FolderTypeId = value;
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
		private int _OptimizationType;
		[CProperty(ColumnPath ="OptimizationType")]
		public int OptimizationType
		{
			get{return _OptimizationType;}
			set
			{
				_OptimizationType = value;
				OnPropertyChanged();
			}
		}
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
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
		private byte[] _SearchData;
		[CProperty(ColumnPath ="SearchData")]
		public byte[] SearchData
		{
			get{return _SearchData;}
			set
			{
				_SearchData = value;
				OnPropertyChanged();
			}
		}
		private bool _Synchronize;
		[CProperty(ColumnPath ="Synchronize")]
		public bool Synchronize
		{
			get{return _Synchronize;}
			set
			{
				_Synchronize = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="ActivityFolder:ParentId")]
		public ActivityFolder Parent { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FolderType:FolderTypeId")]
		public FolderType FolderType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ActivityFolder:ParentId")]
		public virtual ICollection<ActivityFolder> ActivityFolderByParent { get; set; }
		[CProperty(Association ="ActivityInFolder:FolderId")]
		public virtual ICollection<ActivityInFolder> ActivityInFolderByFolder { get; set; }
		[CProperty(Association ="EmailFolderColumnValuesSetting:EmailFolderId")]
		public virtual ICollection<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingByEmailFolder { get; set; }
		[CProperty(Association ="MailboxFoldersCorrespondence:ActivityFolderId")]
		public virtual ICollection<MailboxFoldersCorrespondence> MailboxFoldersCorrespondenceByActivityFolder { get; set; }
		#endregion
	}
}
