using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContactDuplicate")]
	public class ContactDuplicate : BaseEntity
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
		private Guid _Entity1Id;
		[CProperty(ColumnPath ="Entity1Id")]
		public Guid Entity1Id
		{
			get{return _Entity1Id;}
			set
			{
				_Entity1Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _Entity2Id;
		[CProperty(ColumnPath ="Entity2Id")]
		public Guid Entity2Id
		{
			get{return _Entity2Id;}
			set
			{
				_Entity2Id = value;
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
		private Guid _StatusOfDuplicateId;
		[CProperty(ColumnPath ="StatusOfDuplicateId")]
		public Guid StatusOfDuplicateId
		{
			get{return _StatusOfDuplicateId;}
			set
			{
				_StatusOfDuplicateId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:Entity1Id")]
		public Contact Entity1 { get; set; }
		[CProperty(Navigation ="Contact:Entity2Id")]
		public Contact Entity2 { get; set; }
		[CProperty(Navigation ="DuplicateStatus:StatusOfDuplicateId")]
		public DuplicateStatus StatusOfDuplicate { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
