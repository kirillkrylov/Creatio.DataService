using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BpmonlineBuild")]
	public class BpmonlineBuild : BaseEntity
	{
		#region Values
		private Guid _BpmonlineBuildDBMSId;
		[CProperty(ColumnPath ="BpmonlineBuildDBMSId")]
		public Guid BpmonlineBuildDBMSId
		{
			get{return _BpmonlineBuildDBMSId;}
			set
			{
				_BpmonlineBuildDBMSId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineBuildVersionId;
		[CProperty(ColumnPath ="BpmonlineBuildVersionId")]
		public Guid BpmonlineBuildVersionId
		{
			get{return _BpmonlineBuildVersionId;}
			set
			{
				_BpmonlineBuildVersionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineLczId;
		[CProperty(ColumnPath ="BpmonlineLczId")]
		public Guid BpmonlineLczId
		{
			get{return _BpmonlineLczId;}
			set
			{
				_BpmonlineLczId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineProductId;
		[CProperty(ColumnPath ="BpmonlineProductId")]
		public Guid BpmonlineProductId
		{
			get{return _BpmonlineProductId;}
			set
			{
				_BpmonlineProductId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineVersionId;
		[CProperty(ColumnPath ="BpmonlineVersionId")]
		public Guid BpmonlineVersionId
		{
			get{return _BpmonlineVersionId;}
			set
			{
				_BpmonlineVersionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BuildTypeEntityId;
		[CProperty(ColumnPath ="BuildTypeEntityId")]
		public Guid BuildTypeEntityId
		{
			get{return _BuildTypeEntityId;}
			set
			{
				_BuildTypeEntityId = value;
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
		[CProperty(Navigation ="BpmonlineBuildDBMS:BpmonlineBuildDBMSId")]
		public BpmonlineBuildDBMS BpmonlineBuildDBMS { get; set; }
		[CProperty(Navigation ="BpmonlineBuildVersion:BpmonlineBuildVersionId")]
		public BpmonlineBuildVersion BpmonlineBuildVersion { get; set; }
		[CProperty(Navigation ="BpmonlineLcz:BpmonlineLczId")]
		public BpmonlineLcz BpmonlineLcz { get; set; }
		[CProperty(Navigation ="BpmonlineProduct:BpmonlineProductId")]
		public BpmonlineProduct BpmonlineProduct { get; set; }
		[CProperty(Navigation ="BpmonlineVersion:BpmonlineVersionId")]
		public BpmonlineVersion BpmonlineVersion { get; set; }
		[CProperty(Navigation ="BuildTypeEntity:BuildTypeEntityId")]
		public BuildTypeEntity BuildTypeEntity { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BpmonlineBuildFile:BpmonlineBuildId")]
		public virtual ICollection<BpmonlineBuildFile> BpmonlineBuildFileByBpmonlineBuild { get; set; }
		[CProperty(Association ="BpmonlineBuildInFolder:BpmonlineBuildId")]
		public virtual ICollection<BpmonlineBuildInFolder> BpmonlineBuildInFolderByBpmonlineBuild { get; set; }
		[CProperty(Association ="BpmonlineBuildInTag:EntityId")]
		public virtual ICollection<BpmonlineBuildInTag> BpmonlineBuildInTagByEntity { get; set; }
		[CProperty(Association ="ConfItem:BpmonlineBuildId")]
		public virtual ICollection<ConfItem> ConfItemByBpmonlineBuild { get; set; }
		[CProperty(Association ="Release:BpmonlineBuildId")]
		public virtual ICollection<Release> ReleaseByBpmonlineBuild { get; set; }
		#endregion
	}
}
