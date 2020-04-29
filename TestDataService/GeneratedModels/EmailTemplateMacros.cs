using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmailTemplateMacros")]
	public class EmailTemplateMacros : BaseEntity
	{
		#region Values
		private Guid _AccountCommunicationTypeId;
		[CProperty(ColumnPath ="AccountCommunicationTypeId")]
		public Guid AccountCommunicationTypeId
		{
			get{return _AccountCommunicationTypeId;}
			set
			{
				_AccountCommunicationTypeId = value;
				OnPropertyChanged();
			}
		}
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
				OnPropertyChanged();
			}
		}
		private string _ColumnPath;
		[CProperty(ColumnPath ="ColumnPath")]
		public string ColumnPath
		{
			get{return _ColumnPath;}
			set
			{
				_ColumnPath = value;
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
		private bool _IsInactive;
		[CProperty(ColumnPath ="IsInactive")]
		public bool IsInactive
		{
			get{return _IsInactive;}
			set
			{
				_IsInactive = value;
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
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
				OnPropertyChanged();
			}
		}
		private int _Position;
		[CProperty(ColumnPath ="Position")]
		public int Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
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
		private string _Template;
		[CProperty(ColumnPath ="Template")]
		public string Template
		{
			get{return _Template;}
			set
			{
				_Template = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="CommunicationType:AccountCommunicationTypeId")]
		public CommunicationType AccountCommunicationType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EmailTemplateMacros:ParentId")]
		public EmailTemplateMacros Parent { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="EmailTemplateMacros:ParentId")]
		public virtual ICollection<EmailTemplateMacros> EmailTemplateMacrosByParent { get; set; }
		#endregion
	}
}
