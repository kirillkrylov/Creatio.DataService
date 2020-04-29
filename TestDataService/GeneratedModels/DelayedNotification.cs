using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DelayedNotification")]
	public class DelayedNotification : BaseEntity
	{
		#region Values
		private DateTime _ActualSendDate;
		[CProperty(ColumnPath ="ActualSendDate")]
		public DateTime ActualSendDate
		{
			get{return _ActualSendDate;}
			set
			{
				_ActualSendDate = value;
				OnPropertyChanged();
			}
		}
		private string _AssemblyQualifiedManagerName;
		[CProperty(ColumnPath ="AssemblyQualifiedManagerName")]
		public string AssemblyQualifiedManagerName
		{
			get{return _AssemblyQualifiedManagerName;}
			set
			{
				_AssemblyQualifiedManagerName = value;
				OnPropertyChanged();
			}
		}
		private Guid _CaseId;
		[CProperty(ColumnPath ="CaseId")]
		public Guid CaseId
		{
			get{return _CaseId;}
			set
			{
				_CaseId = value;
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
		private string _Error;
		[CProperty(ColumnPath ="Error")]
		public string Error
		{
			get{return _Error;}
			set
			{
				_Error = value;
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
		private DateTime _SendDate;
		[CProperty(ColumnPath ="SendDate")]
		public DateTime SendDate
		{
			get{return _SendDate;}
			set
			{
				_SendDate = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Case:CaseId")]
		public Case Case { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
