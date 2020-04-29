using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsSalesCareerSegment")]
	public class TsSalesCareerSegment : BaseEntity
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
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
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
		[CProperty(Association ="Applicant:SegmentId")]
		public virtual ICollection<Applicant> ApplicantBySegment { get; set; }
		[CProperty(Association ="BonusRates:SalesCareerSegmentId")]
		public virtual ICollection<BonusRates> BonusRatesBySalesCareerSegment { get; set; }
		[CProperty(Association ="InternalRequest:SegmentId")]
		public virtual ICollection<InternalRequest> InternalRequestBySegment { get; set; }
		[CProperty(Association ="ManagersQuotesBySegment:ManagerSegmentId")]
		public virtual ICollection<ManagersQuotesBySegment> ManagersQuotesBySegmentByManagerSegment { get; set; }
		[CProperty(Association ="OrgStructureUnit:SegmentId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitBySegment { get; set; }
		[CProperty(Association ="SMHealthCheck:SegmentId")]
		public virtual ICollection<SMHealthCheck> SMHealthCheckBySegment { get; set; }
		[CProperty(Association ="TsSalesCareer:SegmentId")]
		public virtual ICollection<TsSalesCareer> TsSalesCareerBySegment { get; set; }
		[CProperty(Association ="VwTsSalesCareer:SegmentId")]
		public virtual ICollection<VwTsSalesCareer> VwTsSalesCareerBySegment { get; set; }
		#endregion
	}
}
