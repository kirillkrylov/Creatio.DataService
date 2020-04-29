using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BeesenderClient")]
	public class BeesenderClient : BaseEntity
	{
		#region Values
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
		private string _Country;
		[CProperty(ColumnPath ="Country")]
		public string Country
		{
			get{return _Country;}
			set
			{
				_Country = value;
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
		private string _FirstName;
		[CProperty(ColumnPath ="FirstName")]
		public string FirstName
		{
			get{return _FirstName;}
			set
			{
				_FirstName = value;
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
		private string _InternalId;
		[CProperty(ColumnPath ="InternalId")]
		public string InternalId
		{
			get{return _InternalId;}
			set
			{
				_InternalId = value;
				OnPropertyChanged();
			}
		}
		private string _Language;
		[CProperty(ColumnPath ="Language")]
		public string Language
		{
			get{return _Language;}
			set
			{
				_Language = value;
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
		private string _NickName;
		[CProperty(ColumnPath ="NickName")]
		public string NickName
		{
			get{return _NickName;}
			set
			{
				_NickName = value;
				OnPropertyChanged();
			}
		}
		private string _PhotoSrc;
		[CProperty(ColumnPath ="PhotoSrc")]
		public string PhotoSrc
		{
			get{return _PhotoSrc;}
			set
			{
				_PhotoSrc = value;
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
		private string _SecondName;
		[CProperty(ColumnPath ="SecondName")]
		public string SecondName
		{
			get{return _SecondName;}
			set
			{
				_SecondName = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BeesenderChat:ClientId")]
		public virtual ICollection<BeesenderChat> BeesenderChatByClient { get; set; }
		[CProperty(Association ="BeesenderChatMessage:ClientId")]
		public virtual ICollection<BeesenderChatMessage> BeesenderChatMessageByClient { get; set; }
		#endregion
	}
}
