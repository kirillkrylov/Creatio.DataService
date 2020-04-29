using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "IQSetRights")]
	public class IQSetRights : BaseEntity
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
		private DateTime _IQGrantedTo;
		[CProperty(ColumnPath ="IQGrantedTo")]
		public DateTime IQGrantedTo
		{
			get{return _IQGrantedTo;}
			set
			{
				_IQGrantedTo = value;
				OnPropertyChanged();
			}
		}
		private DateTime _IQGrantFrom;
		[CProperty(ColumnPath ="IQGrantFrom")]
		public DateTime IQGrantFrom
		{
			get{return _IQGrantFrom;}
			set
			{
				_IQGrantFrom = value;
				OnPropertyChanged();
			}
		}
		private string _IQName;
		[CProperty(ColumnPath ="IQName")]
		public string IQName
		{
			get{return _IQName;}
			set
			{
				_IQName = value;
				OnPropertyChanged();
			}
		}
		private string _IQObject;
		[CProperty(ColumnPath ="IQObject")]
		public string IQObject
		{
			get{return _IQObject;}
			set
			{
				_IQObject = value;
				OnPropertyChanged();
			}
		}
		private Guid _IQProcessLogId;
		[CProperty(ColumnPath ="IQProcessLogId")]
		public Guid IQProcessLogId
		{
			get{return _IQProcessLogId;}
			set
			{
				_IQProcessLogId = value;
				OnPropertyChanged();
			}
		}
		private Guid _IQRightPeriodId;
		[CProperty(ColumnPath ="IQRightPeriodId")]
		public Guid IQRightPeriodId
		{
			get{return _IQRightPeriodId;}
			set
			{
				_IQRightPeriodId = value;
				OnPropertyChanged();
			}
		}
		private Guid _IQStatusId;
		[CProperty(ColumnPath ="IQStatusId")]
		public Guid IQStatusId
		{
			get{return _IQStatusId;}
			set
			{
				_IQStatusId = value;
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="IQActualStatus:IQStatusId")]
		public IQActualStatus IQStatus { get; set; }
		[CProperty(Navigation ="IQRightPeriod:IQRightPeriodId")]
		public IQRightPeriod IQRightPeriod { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:IQIQSetRightsId")]
		public virtual ICollection<Activity> ActivityByIQIQSetRights { get; set; }
		[CProperty(Association ="IQAddRight:IQSetRightsId")]
		public virtual ICollection<IQAddRight> IQAddRightByIQSetRights { get; set; }
		[CProperty(Association ="IQLimitRight:IQSetRightsId")]
		public virtual ICollection<IQLimitRight> IQLimitRightByIQSetRights { get; set; }
		[CProperty(Association ="IQSetRightsFile:IQSetRightsId")]
		public virtual ICollection<IQSetRightsFile> IQSetRightsFileByIQSetRights { get; set; }
		[CProperty(Association ="IQSetRightsInFolder:IQSetRightsId")]
		public virtual ICollection<IQSetRightsInFolder> IQSetRightsInFolderByIQSetRights { get; set; }
		[CProperty(Association ="IQSetRightsInTag:EntityId")]
		public virtual ICollection<IQSetRightsInTag> IQSetRightsInTagByEntity { get; set; }
		#endregion
	}
}
