using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SegmentStatus")]
	public class SegmentStatus : BaseEntity
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
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
		#endregion

		#region Associations
		[CProperty(Association ="BulkEmail:SegmentsStatusId")]
		public virtual ICollection<BulkEmail> BulkEmailBySegmentsStatus { get; set; }
		[CProperty(Association ="BulkEmailSegment:StateId")]
		public virtual ICollection<BulkEmailSegment> BulkEmailSegmentByState { get; set; }
		[CProperty(Association ="BulkEmailSplit:SegmentsStatusId")]
		public virtual ICollection<BulkEmailSplit> BulkEmailSplitBySegmentsStatus { get; set; }
		[CProperty(Association ="BulkEmailSplitSegment:StateId")]
		public virtual ICollection<BulkEmailSplitSegment> BulkEmailSplitSegmentByState { get; set; }
		[CProperty(Association ="Campaign:SegmentsStatusId")]
		public virtual ICollection<Campaign> CampaignBySegmentsStatus { get; set; }
		[CProperty(Association ="CampaignSegment:StateId")]
		public virtual ICollection<CampaignSegment> CampaignSegmentByState { get; set; }
		[CProperty(Association ="Event:ActualizeStatusId")]
		public virtual ICollection<Event> EventByActualizeStatus { get; set; }
		[CProperty(Association ="Event:SegmentsStatusId")]
		public virtual ICollection<Event> EventBySegmentsStatus { get; set; }
		[CProperty(Association ="EventSegment:StateId")]
		public virtual ICollection<EventSegment> EventSegmentByState { get; set; }
		#endregion
	}
}
