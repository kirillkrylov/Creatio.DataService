using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwCaseStatusHistory")]
	public class VwCaseStatusHistory : BaseEntity
	{
		#region Values
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
		private Guid _NewStatusId;
		[CProperty(ColumnPath ="NewStatusId")]
		public Guid NewStatusId
		{
			get{return _NewStatusId;}
			set
			{
				_NewStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OldStatusId;
		[CProperty(ColumnPath ="OldStatusId")]
		public Guid OldStatusId
		{
			get{return _OldStatusId;}
			set
			{
				_OldStatusId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Case:CaseId")]
		public Case Case { get; set; }
		[CProperty(Navigation ="CaseStatus:OldStatusId")]
		public CaseStatus OldStatus { get; set; }
		[CProperty(Navigation ="CaseStatus:NewStatusId")]
		public CaseStatus NewStatus { get; set; }
		[CProperty(Navigation ="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
