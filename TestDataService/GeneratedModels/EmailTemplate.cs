using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmailTemplate")]
	public class EmailTemplate : BaseEntity
	{
		#region Values
		private byte[] _BlindCopyRecipient;
		[CProperty(ColumnPath ="BlindCopyRecipient")]
		public byte[] BlindCopyRecipient
		{
			get{return _BlindCopyRecipient;}
			set
			{
				_BlindCopyRecipient = value;
				OnPropertyChanged();
			}
		}
		private string _Body;
		[CProperty(ColumnPath ="Body")]
		public string Body
		{
			get{return _Body;}
			set
			{
				_Body = value;
				OnPropertyChanged();
			}
		}
		private int _ConfigType;
		[CProperty(ColumnPath ="ConfigType")]
		public int ConfigType
		{
			get{return _ConfigType;}
			set
			{
				_ConfigType = value;
				OnPropertyChanged();
			}
		}
		private byte[] _CopyRecipient;
		[CProperty(ColumnPath ="CopyRecipient")]
		public byte[] CopyRecipient
		{
			get{return _CopyRecipient;}
			set
			{
				_CopyRecipient = value;
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
		private bool _IsHtmlBody;
		[CProperty(ColumnPath ="IsHtmlBody")]
		public bool IsHtmlBody
		{
			get{return _IsHtmlBody;}
			set
			{
				_IsHtmlBody = value;
				OnPropertyChanged();
			}
		}
		private byte[] _Macros;
		[CProperty(ColumnPath ="Macros")]
		public byte[] Macros
		{
			get{return _Macros;}
			set
			{
				_Macros = value;
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
		private Guid _ObjectFieldInActivity;
		[CProperty(ColumnPath ="ObjectFieldInActivity")]
		public Guid ObjectFieldInActivity
		{
			get{return _ObjectFieldInActivity;}
			set
			{
				_ObjectFieldInActivity = value;
				OnPropertyChanged();
			}
		}
		private Guid _ObjectId;
		[CProperty(ColumnPath ="ObjectId")]
		public Guid ObjectId
		{
			get{return _ObjectId;}
			set
			{
				_ObjectId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PreviewImageId;
		[CProperty(ColumnPath ="PreviewImageId")]
		public Guid PreviewImageId
		{
			get{return _PreviewImageId;}
			set
			{
				_PreviewImageId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PriorityId;
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId
		{
			get{return _PriorityId;}
			set
			{
				_PriorityId = value;
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
		private byte[] _Recipient;
		[CProperty(ColumnPath ="Recipient")]
		public byte[] Recipient
		{
			get{return _Recipient;}
			set
			{
				_Recipient = value;
				OnPropertyChanged();
			}
		}
		private bool _SaveAsActivity;
		[CProperty(ColumnPath ="SaveAsActivity")]
		public bool SaveAsActivity
		{
			get{return _SaveAsActivity;}
			set
			{
				_SaveAsActivity = value;
				OnPropertyChanged();
			}
		}
		private Guid _SendIndividualEmailId;
		[CProperty(ColumnPath ="SendIndividualEmailId")]
		public Guid SendIndividualEmailId
		{
			get{return _SendIndividualEmailId;}
			set
			{
				_SendIndividualEmailId = value;
				OnPropertyChanged();
			}
		}
		private bool _ShowBeforeSending;
		[CProperty(ColumnPath ="ShowBeforeSending")]
		public bool ShowBeforeSending
		{
			get{return _ShowBeforeSending;}
			set
			{
				_ShowBeforeSending = value;
				OnPropertyChanged();
			}
		}
		private string _Subject;
		[CProperty(ColumnPath ="Subject")]
		public string Subject
		{
			get{return _Subject;}
			set
			{
				_Subject = value;
				OnPropertyChanged();
			}
		}
		private string _TemplateConfig;
		[CProperty(ColumnPath ="TemplateConfig")]
		public string TemplateConfig
		{
			get{return _TemplateConfig;}
			set
			{
				_TemplateConfig = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="ActivityPriority:PriorityId")]
		public ActivityPriority Priority { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EmailTemplateSendFlag:SendIndividualEmailId")]
		public EmailTemplateSendFlag SendIndividualEmail { get; set; }
		[CProperty(Navigation ="SysImage:PreviewImageId")]
		public SysImage PreviewImage { get; set; }
		[CProperty(Navigation ="VwSysSchemaInfo:ObjectId")]
		public VwSysSchemaInfo Object { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CaseNotificationRule:EmailTemplateId")]
		public virtual ICollection<CaseNotificationRule> CaseNotificationRuleByEmailTemplate { get; set; }
		[CProperty(Association ="EmailTemplateActivity:EmailTemplateId")]
		public virtual ICollection<EmailTemplateActivity> EmailTemplateActivityByEmailTemplate { get; set; }
		[CProperty(Association ="EmailTemplateFile:EmailTemplateId")]
		public virtual ICollection<EmailTemplateFile> EmailTemplateFileByEmailTemplate { get; set; }
		[CProperty(Association ="EmailTemplateLang:EmailTemplateId")]
		public virtual ICollection<EmailTemplateLang> EmailTemplateLangByEmailTemplate { get; set; }
		[CProperty(Association ="FavoriteEmailTemplate:EmailTemplateId")]
		public virtual ICollection<FavoriteEmailTemplate> FavoriteEmailTemplateByEmailTemplate { get; set; }
		[CProperty(Association ="labActualizeRule:labEmailTemplateId")]
		public virtual ICollection<labActualizeRule> labActualizeRuleBylabEmailTemplate { get; set; }
		[CProperty(Association ="SocialFeedFavoriteTpl:EmailTemplateId")]
		public virtual ICollection<SocialFeedFavoriteTpl> SocialFeedFavoriteTplByEmailTemplate { get; set; }
		[CProperty(Association ="TsMailNotificationValue:EmailTemplateId")]
		public virtual ICollection<TsMailNotificationValue> TsMailNotificationValueByEmailTemplate { get; set; }
		#endregion
	}
}
