using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContactCommunication")]
	public class ContactCommunication : BaseEntity
	{
		#region Values
		private Guid _CommunicationTypeId;
		[CProperty(ColumnPath ="CommunicationTypeId")]
		public Guid CommunicationTypeId
		{
			get{return _CommunicationTypeId;}
			set
			{
				_CommunicationTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
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
		private DateTime _DateSetNonActual;
		[CProperty(ColumnPath ="DateSetNonActual")]
		public DateTime DateSetNonActual
		{
			get{return _DateSetNonActual;}
			set
			{
				_DateSetNonActual = value;
				OnPropertyChanged();
			}
		}
		private string _ExternalCommunicationType;
		[CProperty(ColumnPath ="ExternalCommunicationType")]
		public string ExternalCommunicationType
		{
			get{return _ExternalCommunicationType;}
			set
			{
				_ExternalCommunicationType = value;
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
		private bool _IsCreatedBySynchronization;
		[CProperty(ColumnPath ="IsCreatedBySynchronization")]
		public bool IsCreatedBySynchronization
		{
			get{return _IsCreatedBySynchronization;}
			set
			{
				_IsCreatedBySynchronization = value;
				OnPropertyChanged();
			}
		}
		private bool _IsPrimary;
		[CProperty(ColumnPath ="IsPrimary")]
		public bool IsPrimary
		{
			get{return _IsPrimary;}
			set
			{
				_IsPrimary = value;
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
		private bool _NonActual;
		[CProperty(ColumnPath ="NonActual")]
		public bool NonActual
		{
			get{return _NonActual;}
			set
			{
				_NonActual = value;
				OnPropertyChanged();
			}
		}
		private Guid _NonActualReasonId;
		[CProperty(ColumnPath ="NonActualReasonId")]
		public Guid NonActualReasonId
		{
			get{return _NonActualReasonId;}
			set
			{
				_NonActualReasonId = value;
				OnPropertyChanged();
			}
		}
		private string _Number;
		[CProperty(ColumnPath ="Number")]
		public string Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
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
		private string _SearchNumber;
		[CProperty(ColumnPath ="SearchNumber")]
		public string SearchNumber
		{
			get{return _SearchNumber;}
			set
			{
				_SearchNumber = value;
				OnPropertyChanged();
			}
		}
		private string _SocialMediaId;
		[CProperty(ColumnPath ="SocialMediaId")]
		public string SocialMediaId
		{
			get{return _SocialMediaId;}
			set
			{
				_SocialMediaId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="CommunicationType:CommunicationTypeId")]
		public CommunicationType CommunicationType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="NonActualReason:NonActualReasonId")]
		public NonActualReason NonActualReason { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
