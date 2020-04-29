using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupAccessToClient")]
	public class SupAccessToClient : BaseEntity
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
		private string _SupAccess;
		[CProperty(ColumnPath ="SupAccess")]
		public string SupAccess
		{
			get{return _SupAccess;}
			set
			{
				_SupAccess = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupAccessTypeId;
		[CProperty(ColumnPath ="SupAccessTypeId")]
		public Guid SupAccessTypeId
		{
			get{return _SupAccessTypeId;}
			set
			{
				_SupAccessTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupCaseId;
		[CProperty(ColumnPath ="SupCaseId")]
		public Guid SupCaseId
		{
			get{return _SupCaseId;}
			set
			{
				_SupCaseId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupConfItemId;
		[CProperty(ColumnPath ="SupConfItemId")]
		public Guid SupConfItemId
		{
			get{return _SupConfItemId;}
			set
			{
				_SupConfItemId = value;
				OnPropertyChanged();
			}
		}
		private bool _SupIsActual;
		[CProperty(ColumnPath ="SupIsActual")]
		public bool SupIsActual
		{
			get{return _SupIsActual;}
			set
			{
				_SupIsActual = value;
				OnPropertyChanged();
			}
		}
		private string _SupNote;
		[CProperty(ColumnPath ="SupNote")]
		public string SupNote
		{
			get{return _SupNote;}
			set
			{
				_SupNote = value;
				OnPropertyChanged();
			}
		}
		private string _SupSiteAddress;
		[CProperty(ColumnPath ="SupSiteAddress")]
		public string SupSiteAddress
		{
			get{return _SupSiteAddress;}
			set
			{
				_SupSiteAddress = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Case:SupCaseId")]
		public Case SupCase { get; set; }
		[CProperty(Navigation ="ConfItem:SupConfItemId")]
		public ConfItem SupConfItem { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SupAccessType:SupAccessTypeId")]
		public SupAccessType SupAccessType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SupAccessToClientFile:SupAccessToClientId")]
		public virtual ICollection<SupAccessToClientFile> SupAccessToClientFileBySupAccessToClient { get; set; }
		#endregion
	}
}
