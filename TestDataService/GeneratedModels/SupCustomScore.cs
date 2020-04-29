using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupCustomScore")]
	public class SupCustomScore : BaseEntity
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
		private Guid _SupAccountId;
		[CProperty(ColumnPath ="SupAccountId")]
		public Guid SupAccountId
		{
			get{return _SupAccountId;}
			set
			{
				_SupAccountId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SupEndDate;
		[CProperty(ColumnPath ="SupEndDate")]
		public DateTime SupEndDate
		{
			get{return _SupEndDate;}
			set
			{
				_SupEndDate = value;
				OnPropertyChanged();
			}
		}
		private string _SupNote;
		[CProperty(ColumnPath ="SupNote")]
		public string SupNote
		{
			get{return _SupNote;}
			set
			{
				_SupNote = value;
				OnPropertyChanged();
			}
		}
		private int _SupScore;
		[CProperty(ColumnPath ="SupScore")]
		public int SupScore
		{
			get{return _SupScore;}
			set
			{
				_SupScore = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SupStartDate;
		[CProperty(ColumnPath ="SupStartDate")]
		public DateTime SupStartDate
		{
			get{return _SupStartDate;}
			set
			{
				_SupStartDate = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:SupAccountId")]
		public Account SupAccount { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
