using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RequestType")]
	public class RequestType : BaseEntity
	{
		#region Values
		private bool _AddAllExesToRequest;
		[CProperty(ColumnPath ="AddAllExesToRequest")]
		public bool AddAllExesToRequest
		{
			get{return _AddAllExesToRequest;}
			set
			{
				_AddAllExesToRequest = value;
				OnPropertyChanged();
			}
		}
		private Guid _CategoryId;
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId
		{
			get{return _CategoryId;}
			set
			{
				_CategoryId = value;
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
		private string _RequestDescriptionTemplate;
		[CProperty(ColumnPath ="RequestDescriptionTemplate")]
		public string RequestDescriptionTemplate
		{
			get{return _RequestDescriptionTemplate;}
			set
			{
				_RequestDescriptionTemplate = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="RequestCategory:CategoryId")]
		public RequestCategory Category { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="InternalRequest:TypeId")]
		public virtual ICollection<InternalRequest> InternalRequestByType { get; set; }
		[CProperty(Association ="RequestExes:RequestTypeId")]
		public virtual ICollection<RequestExes> RequestExesByRequestType { get; set; }
		[CProperty(Association ="RequestExesByType:RequestTypeId")]
		public virtual ICollection<RequestExesByType> RequestExesByTypeByRequestType { get; set; }
		[CProperty(Association ="RequestSubType:RequestTypeId")]
		public virtual ICollection<RequestSubType> RequestSubTypeByRequestType { get; set; }
		#endregion
	}
}
