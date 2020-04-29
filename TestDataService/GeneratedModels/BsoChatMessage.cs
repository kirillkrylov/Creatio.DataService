using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BsoChatMessage")]
	public class BsoChatMessage : BaseEntity
	{
		#region Values
		private string _BsoAuthor;
		[CProperty(ColumnPath ="BsoAuthor")]
		public string BsoAuthor
		{
			get{return _BsoAuthor;}
			set
			{
				_BsoAuthor = value;
				OnPropertyChanged();
			}
		}
		private bool _BsoBlacklisted;
		[CProperty(ColumnPath ="BsoBlacklisted")]
		public bool BsoBlacklisted
		{
			get{return _BsoBlacklisted;}
			set
			{
				_BsoBlacklisted = value;
				OnPropertyChanged();
			}
		}
		private Guid _BsoChatId;
		[CProperty(ColumnPath ="BsoChatId")]
		public Guid BsoChatId
		{
			get{return _BsoChatId;}
			set
			{
				_BsoChatId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _BsoDate;
		[CProperty(ColumnPath ="BsoDate")]
		public DateTime BsoDate
		{
			get{return _BsoDate;}
			set
			{
				_BsoDate = value;
				OnPropertyChanged();
			}
		}
		private string _BsoMessage;
		[CProperty(ColumnPath ="BsoMessage")]
		public string BsoMessage
		{
			get{return _BsoMessage;}
			set
			{
				_BsoMessage = value;
				OnPropertyChanged();
			}
		}
		private Guid _BsoOwnerId;
		[CProperty(ColumnPath ="BsoOwnerId")]
		public Guid BsoOwnerId
		{
			get{return _BsoOwnerId;}
			set
			{
				_BsoOwnerId = value;
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
		[CProperty(Navigation ="BsoChats:BsoChatId")]
		public BsoChats BsoChat { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:BsoOwnerId")]
		public Contact BsoOwner { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
