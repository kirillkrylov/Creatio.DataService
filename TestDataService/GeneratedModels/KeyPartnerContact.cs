using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "KeyPartnerContact")]
	public class KeyPartnerContact : BaseEntity
	{
		#region Values
		private string _Comment;
		[CProperty(ColumnPath ="Comment")]
		public string Comment
		{
			get{return _Comment;}
			set
			{
				_Comment = value;
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
		private Guid _PartnerContactRoleId;
		[CProperty(ColumnPath ="PartnerContactRoleId")]
		public Guid PartnerContactRoleId
		{
			get{return _PartnerContactRoleId;}
			set
			{
				_PartnerContactRoleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnershipId;
		[CProperty(ColumnPath ="PartnershipId")]
		public Guid PartnershipId
		{
			get{return _PartnershipId;}
			set
			{
				_PartnershipId = value;
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
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="PartnerContactRole:PartnerContactRoleId")]
		public PartnerContactRole PartnerContactRole { get; set; }
		[CProperty(Navigation ="Partnership:PartnershipId")]
		public Partnership Partnership { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
