using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailSplit")]
	public class BulkEmailSplit : BaseEntity
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
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
				OnPropertyChanged();
			}
		}
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
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
		private int _RecipientCount;
		[CProperty(ColumnPath ="RecipientCount")]
		public int RecipientCount
		{
			get{return _RecipientCount;}
			set
			{
				_RecipientCount = value;
				OnPropertyChanged();
			}
		}
		private decimal _RecipientPercent;
		[CProperty(ColumnPath ="RecipientPercent")]
		public decimal RecipientPercent
		{
			get{return _RecipientPercent;}
			set
			{
				_RecipientPercent = value;
				OnPropertyChanged();
			}
		}
		private Guid _SegmentsStatusId;
		[CProperty(ColumnPath ="SegmentsStatusId")]
		public Guid SegmentsStatusId
		{
			get{return _SegmentsStatusId;}
			set
			{
				_SegmentsStatusId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
		private bool _StartManual;
		[CProperty(ColumnPath ="StartManual")]
		public bool StartManual
		{
			get{return _StartManual;}
			set
			{
				_StartManual = value;
				OnPropertyChanged();
			}
		}
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
				OnPropertyChanged();
			}
		}
		private int _TestRecipientCount;
		[CProperty(ColumnPath ="TestRecipientCount")]
		public int TestRecipientCount
		{
			get{return _TestRecipientCount;}
			set
			{
				_TestRecipientCount = value;
				OnPropertyChanged();
			}
		}
		private string _TransferTableName;
		[CProperty(ColumnPath ="TransferTableName")]
		public string TransferTableName
		{
			get{return _TransferTableName;}
			set
			{
				_TransferTableName = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="BulkEmailSplitStatus:StatusId")]
		public BulkEmailSplitStatus Status { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="SegmentStatus:SegmentsStatusId")]
		public SegmentStatus SegmentsStatus { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BulkEmail:SplitTestId")]
		public virtual ICollection<BulkEmail> BulkEmailBySplitTest { get; set; }
		[CProperty(Association ="BulkEmailInBulkEmailSplit:BulkEmailSplitId")]
		public virtual ICollection<BulkEmailInBulkEmailSplit> BulkEmailInBulkEmailSplitByBulkEmailSplit { get; set; }
		[CProperty(Association ="BulkEmailSplitFile:BulkEmailSplitId")]
		public virtual ICollection<BulkEmailSplitFile> BulkEmailSplitFileByBulkEmailSplit { get; set; }
		[CProperty(Association ="BulkEmailSplitInFolder:BulkEmailSplitId")]
		public virtual ICollection<BulkEmailSplitInFolder> BulkEmailSplitInFolderByBulkEmailSplit { get; set; }
		[CProperty(Association ="BulkEmailSplitSegment:BulkEmailSplitId")]
		public virtual ICollection<BulkEmailSplitSegment> BulkEmailSplitSegmentByBulkEmailSplit { get; set; }
		[CProperty(Association ="BulkEmailSplitTarget:BulkEmailSplitId")]
		public virtual ICollection<BulkEmailSplitTarget> BulkEmailSplitTargetByBulkEmailSplit { get; set; }
		#endregion
	}
}
