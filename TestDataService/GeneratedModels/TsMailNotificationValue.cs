using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsMailNotificationValue")]
	public class TsMailNotificationValue : BaseEntity
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
		private Guid _CultureId;
		[CProperty(ColumnPath ="CultureId")]
		public Guid CultureId
		{
			get{return _CultureId;}
			set
			{
				_CultureId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmailNotificationId;
		[CProperty(ColumnPath ="EmailNotificationId")]
		public Guid EmailNotificationId
		{
			get{return _EmailNotificationId;}
			set
			{
				_EmailNotificationId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmailTemplateId;
		[CProperty(ColumnPath ="EmailTemplateId")]
		public Guid EmailTemplateId
		{
			get{return _EmailTemplateId;}
			set
			{
				_EmailTemplateId = value;
				OnPropertyChanged();
			}
		}
		private string _From;
		[CProperty(ColumnPath ="From")]
		public string From
		{
			get{return _From;}
			set
			{
				_From = value;
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EmailTemplate:EmailTemplateId")]
		public EmailTemplate EmailTemplate { get; set; }
		[CProperty(Navigation ="SysCulture:CultureId")]
		public SysCulture Culture { get; set; }
		[CProperty(Navigation ="TsEmailNotification:EmailNotificationId")]
		public TsEmailNotification EmailNotification { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
