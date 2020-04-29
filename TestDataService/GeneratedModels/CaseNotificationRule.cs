using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseNotificationRule")]
	public class CaseNotificationRule : BaseEntity
	{
		#region Values
		private Guid _CaseCategoryId;
		[CProperty(ColumnPath ="CaseCategoryId")]
		public Guid CaseCategoryId
		{
			get{return _CaseCategoryId;}
			set
			{
				_CaseCategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CaseStatusId;
		[CProperty(ColumnPath ="CaseStatusId")]
		public Guid CaseStatusId
		{
			get{return _CaseStatusId;}
			set
			{
				_CaseStatusId = value;
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
		private int _Delay;
		[CProperty(ColumnPath ="Delay")]
		public int Delay
		{
			get{return _Delay;}
			set
			{
				_Delay = value;
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
		private bool _IsQuoteOriginalEmail;
		[CProperty(ColumnPath ="IsQuoteOriginalEmail")]
		public bool IsQuoteOriginalEmail
		{
			get{return _IsQuoteOriginalEmail;}
			set
			{
				_IsQuoteOriginalEmail = value;
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
		private Guid _RuleUsageId;
		[CProperty(ColumnPath ="RuleUsageId")]
		public Guid RuleUsageId
		{
			get{return _RuleUsageId;}
			set
			{
				_RuleUsageId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseCategory:CaseCategoryId")]
		public CaseCategory CaseCategory { get; set; }
		[CProperty(Navigation ="CaseStatus:CaseStatusId")]
		public CaseStatus CaseStatus { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EmailTemplate:EmailTemplateId")]
		public EmailTemplate EmailTemplate { get; set; }
		[CProperty(Navigation ="NotificationRuleUsage:RuleUsageId")]
		public NotificationRuleUsage RuleUsage { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
