using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PortalMessage")]
	public class PortalMessage : BaseEntity
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
		private Guid _EntityId;
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId
		{
			get{return _EntityId;}
			set
			{
				_EntityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntitySchemaUId;
		[CProperty(ColumnPath ="EntitySchemaUId")]
		public Guid EntitySchemaUId
		{
			get{return _EntitySchemaUId;}
			set
			{
				_EntitySchemaUId = value;
				OnPropertyChanged();
			}
		}
		private bool _FromPortal;
		[CProperty(ColumnPath ="FromPortal")]
		public bool FromPortal
		{
			get{return _FromPortal;}
			set
			{
				_FromPortal = value;
				OnPropertyChanged();
			}
		}
		private bool _HideOnPortal;
		[CProperty(ColumnPath ="HideOnPortal")]
		public bool HideOnPortal
		{
			get{return _HideOnPortal;}
			set
			{
				_HideOnPortal = value;
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
		private bool _IsNotPublished;
		[CProperty(ColumnPath ="IsNotPublished")]
		public bool IsNotPublished
		{
			get{return _IsNotPublished;}
			set
			{
				_IsNotPublished = value;
				OnPropertyChanged();
			}
		}
		private string _Message;
		[CProperty(ColumnPath ="Message")]
		public string Message
		{
			get{return _Message;}
			set
			{
				_Message = value;
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
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="PortalMessageType:TypeId")]
		public PortalMessageType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="PortalMessageFile:PortalMessageId")]
		public virtual ICollection<PortalMessageFile> PortalMessageFileByPortalMessage { get; set; }
		#endregion
	}
}
