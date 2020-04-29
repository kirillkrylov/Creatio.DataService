using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailCountLimit")]
	public class BulkEmailCountLimit : BaseEntity
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
		private Guid _EmailCategoryId;
		[CProperty(ColumnPath ="EmailCategoryId")]
		public Guid EmailCategoryId
		{
			get{return _EmailCategoryId;}
			set
			{
				_EmailCategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmailTypeId;
		[CProperty(ColumnPath ="EmailTypeId")]
		public Guid EmailTypeId
		{
			get{return _EmailTypeId;}
			set
			{
				_EmailTypeId = value;
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
		private int _MailingLimitCount;
		[CProperty(ColumnPath ="MailingLimitCount")]
		public int MailingLimitCount
		{
			get{return _MailingLimitCount;}
			set
			{
				_MailingLimitCount = value;
				OnPropertyChanged();
			}
		}
		private int _MailingLimitPeriod;
		[CProperty(ColumnPath ="MailingLimitPeriod")]
		public int MailingLimitPeriod
		{
			get{return _MailingLimitPeriod;}
			set
			{
				_MailingLimitPeriod = value;
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
		private Guid _OverlimitResponseId;
		[CProperty(ColumnPath ="OverlimitResponseId")]
		public Guid OverlimitResponseId
		{
			get{return _OverlimitResponseId;}
			set
			{
				_OverlimitResponseId = value;
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
		private Guid _TerritoryId;
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId
		{
			get{return _TerritoryId;}
			set
			{
				_TerritoryId = value;
				OnPropertyChanged();
			}
		}
		private string _Title;
		[CProperty(ColumnPath ="Title")]
		public string Title
		{
			get{return _Title;}
			set
			{
				_Title = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="BulkEmailCategory:EmailCategoryId")]
		public BulkEmailCategory EmailCategory { get; set; }
		[CProperty(Navigation ="BulkEmailResponse:OverlimitResponseId")]
		public BulkEmailResponse OverlimitResponse { get; set; }
		[CProperty(Navigation ="BulkEmailType:EmailTypeId")]
		public BulkEmailType EmailType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
