using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ActivityCorrespondence")]
	public class ActivityCorrespondence : BaseEntity
	{
		#region Values
		private Guid _ActivityId;
		[CProperty(ColumnPath ="ActivityId")]
		public Guid ActivityId
		{
			get{return _ActivityId;}
			set
			{
				_ActivityId = value;
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
		private bool _CreatedInBPMonline;
		[CProperty(ColumnPath ="CreatedInBPMonline")]
		public bool CreatedInBPMonline
		{
			get{return _CreatedInBPMonline;}
			set
			{
				_CreatedInBPMonline = value;
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
		private string _SourceActivityId;
		[CProperty(ColumnPath ="SourceActivityId")]
		public string SourceActivityId
		{
			get{return _SourceActivityId;}
			set
			{
				_SourceActivityId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Activity:ActivityId")]
		public Activity Activity { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SocialAccount:SourceAccountId")]
		public SocialAccount SourceAccount { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
