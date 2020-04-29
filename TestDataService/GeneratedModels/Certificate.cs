using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Certificate")]
	public class Certificate : BaseEntity
	{
		#region Values
		private string _CertificateNumber;
		[CProperty(ColumnPath ="CertificateNumber")]
		public string CertificateNumber
		{
			get{return _CertificateNumber;}
			set
			{
				_CertificateNumber = value;
				OnPropertyChanged();
			}
		}
		private string _Comments;
		[CProperty(ColumnPath ="Comments")]
		public string Comments
		{
			get{return _Comments;}
			set
			{
				_Comments = value;
				OnPropertyChanged();
			}
		}
		private Guid _CompetenceLevelId;
		[CProperty(ColumnPath ="CompetenceLevelId")]
		public Guid CompetenceLevelId
		{
			get{return _CompetenceLevelId;}
			set
			{
				_CompetenceLevelId = value;
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
		private DateTime _DateOfNotification;
		[CProperty(ColumnPath ="DateOfNotification")]
		public DateTime DateOfNotification
		{
			get{return _DateOfNotification;}
			set
			{
				_DateOfNotification = value;
				OnPropertyChanged();
			}
		}
		private Guid _EducationActivityId;
		[CProperty(ColumnPath ="EducationActivityId")]
		public Guid EducationActivityId
		{
			get{return _EducationActivityId;}
			set
			{
				_EducationActivityId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ExpireDate;
		[CProperty(ColumnPath ="ExpireDate")]
		public DateTime ExpireDate
		{
			get{return _ExpireDate;}
			set
			{
				_ExpireDate = value;
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
		private DateTime _IssueDate;
		[CProperty(ColumnPath ="IssueDate")]
		public DateTime IssueDate
		{
			get{return _IssueDate;}
			set
			{
				_IssueDate = value;
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
		private bool _NotificationSent;
		[CProperty(ColumnPath ="NotificationSent")]
		public bool NotificationSent
		{
			get{return _NotificationSent;}
			set
			{
				_NotificationSent = value;
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
		private decimal _ResultScore;
		[CProperty(ColumnPath ="ResultScore")]
		public decimal ResultScore
		{
			get{return _ResultScore;}
			set
			{
				_ResultScore = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="CompetenceLevel:CompetenceLevelId")]
		public CompetenceLevel CompetenceLevel { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="EducationActivity:EducationActivityId")]
		public EducationActivity EducationActivity { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
