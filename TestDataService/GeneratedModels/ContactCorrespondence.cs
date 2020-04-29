using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContactCorrespondence")]
	public class ContactCorrespondence : BaseEntity
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
		private bool _IsDeleted;
		[CProperty(ColumnPath ="IsDeleted")]
		public bool IsDeleted
		{
			get{return _IsDeleted;}
			set
			{
				_IsDeleted = value;
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
		private string _SocialAccountName;
		[CProperty(ColumnPath ="SocialAccountName")]
		public string SocialAccountName
		{
			get{return _SocialAccountName;}
			set
			{
				_SocialAccountName = value;
				OnPropertyChanged();
			}
		}
		private Guid _SourceAccountId;
		[CProperty(ColumnPath ="SourceAccountId")]
		public Guid SourceAccountId
		{
			get{return _SourceAccountId;}
			set
			{
				_SourceAccountId = value;
				OnPropertyChanged();
			}
		}
		private string _SourceContactId;
		[CProperty(ColumnPath ="SourceContactId")]
		public string SourceContactId
		{
			get{return _SourceContactId;}
			set
			{
				_SourceContactId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="CommunicationType:SourceId")]
		public CommunicationType Source { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="SocialAccount:SourceAccountId")]
		public SocialAccount SourceAccount { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
