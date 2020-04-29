using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupPortalPreCaseAction")]
	public class SupPortalPreCaseAction : BaseEntity
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
		private string _SupDescription;
		[CProperty(ColumnPath ="SupDescription")]
		public string SupDescription
		{
			get{return _SupDescription;}
			set
			{
				_SupDescription = value;
				OnPropertyChanged();
			}
		}
		private string _SupSessionId;
		[CProperty(ColumnPath ="SupSessionId")]
		public string SupSessionId
		{
			get{return _SupSessionId;}
			set
			{
				_SupSessionId = value;
				OnPropertyChanged();
			}
		}
		private string _SupSubject;
		[CProperty(ColumnPath ="SupSubject")]
		public string SupSubject
		{
			get{return _SupSubject;}
			set
			{
				_SupSubject = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupTypeId;
		[CProperty(ColumnPath ="SupTypeId")]
		public Guid SupTypeId
		{
			get{return _SupTypeId;}
			set
			{
				_SupTypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SupPortalPreCaseActionType:SupTypeId")]
		public SupPortalPreCaseActionType SupType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
