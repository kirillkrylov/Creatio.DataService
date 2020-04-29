using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "WorkDeployLog")]
	public class WorkDeployLog : BaseEntity
	{
		#region Values
		private string _BuildId;
		[CProperty(ColumnPath ="BuildId")]
		public string BuildId
		{
			get{return _BuildId;}
			set
			{
				_BuildId = value;
				OnPropertyChanged();
			}
		}
		private string _BuildStatusIconUrl;
		[CProperty(ColumnPath ="BuildStatusIconUrl")]
		public string BuildStatusIconUrl
		{
			get{return _BuildStatusIconUrl;}
			set
			{
				_BuildStatusIconUrl = value;
				OnPropertyChanged();
			}
		}
		private string _BuildUrl;
		[CProperty(ColumnPath ="BuildUrl")]
		public string BuildUrl
		{
			get{return _BuildUrl;}
			set
			{
				_BuildUrl = value;
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
		private bool _IsFlushRedis;
		[CProperty(ColumnPath ="IsFlushRedis")]
		public bool IsFlushRedis
		{
			get{return _IsFlushRedis;}
			set
			{
				_IsFlushRedis = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="WorkDeployLogFile:WorkDeployLogId")]
		public virtual ICollection<WorkDeployLogFile> WorkDeployLogFileByWorkDeployLog { get; set; }
		[CProperty(Association ="WorkDeployLogInFolder:WorkDeployLogId")]
		public virtual ICollection<WorkDeployLogInFolder> WorkDeployLogInFolderByWorkDeployLog { get; set; }
		[CProperty(Association ="WorkDeployLogInTag:EntityId")]
		public virtual ICollection<WorkDeployLogInTag> WorkDeployLogInTagByEntity { get; set; }
		#endregion
	}
}
