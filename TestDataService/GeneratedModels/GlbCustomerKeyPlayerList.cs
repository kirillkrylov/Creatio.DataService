using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GlbCustomerKeyPlayerList")]
	public class GlbCustomerKeyPlayerList : BaseEntity
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
		private Guid _GlbAccountInCustomerId;
		[CProperty(ColumnPath ="GlbAccountInCustomerId")]
		public Guid GlbAccountInCustomerId
		{
			get{return _GlbAccountInCustomerId;}
			set
			{
				_GlbAccountInCustomerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbContactId;
		[CProperty(ColumnPath ="GlbContactId")]
		public Guid GlbContactId
		{
			get{return _GlbContactId;}
			set
			{
				_GlbContactId = value;
				OnPropertyChanged();
			}
		}
		private string _GlbDescription;
		[CProperty(ColumnPath ="GlbDescription")]
		public string GlbDescription
		{
			get{return _GlbDescription;}
			set
			{
				_GlbDescription = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbInfluenceId;
		[CProperty(ColumnPath ="GlbInfluenceId")]
		public Guid GlbInfluenceId
		{
			get{return _GlbInfluenceId;}
			set
			{
				_GlbInfluenceId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbJobId;
		[CProperty(ColumnPath ="GlbJobId")]
		public Guid GlbJobId
		{
			get{return _GlbJobId;}
			set
			{
				_GlbJobId = value;
				OnPropertyChanged();
			}
		}
		private string _GlbJobTitle;
		[CProperty(ColumnPath ="GlbJobTitle")]
		public string GlbJobTitle
		{
			get{return _GlbJobTitle;}
			set
			{
				_GlbJobTitle = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbLoyaltyId;
		[CProperty(ColumnPath ="GlbLoyaltyId")]
		public Guid GlbLoyaltyId
		{
			get{return _GlbLoyaltyId;}
			set
			{
				_GlbLoyaltyId = value;
				OnPropertyChanged();
			}
		}
		private string _GlbName;
		[CProperty(ColumnPath ="GlbName")]
		public string GlbName
		{
			get{return _GlbName;}
			set
			{
				_GlbName = value;
				OnPropertyChanged();
			}
		}
		private string _GlbNotes;
		[CProperty(ColumnPath ="GlbNotes")]
		public string GlbNotes
		{
			get{return _GlbNotes;}
			set
			{
				_GlbNotes = value;
				OnPropertyChanged();
			}
		}
		private string _GlbPain;
		[CProperty(ColumnPath ="GlbPain")]
		public string GlbPain
		{
			get{return _GlbPain;}
			set
			{
				_GlbPain = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbRoleId;
		[CProperty(ColumnPath ="GlbRoleId")]
		public Guid GlbRoleId
		{
			get{return _GlbRoleId;}
			set
			{
				_GlbRoleId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:GlbAccountInCustomerId")]
		public Account GlbAccountInCustomer { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:GlbContactId")]
		public Contact GlbContact { get; set; }
		[CProperty(Navigation ="Job:GlbJobId")]
		public Job GlbJob { get; set; }
		[CProperty(Navigation ="OppContactInfluence:GlbInfluenceId")]
		public OppContactInfluence GlbInfluence { get; set; }
		[CProperty(Navigation ="OppContactLoyality:GlbLoyaltyId")]
		public OppContactLoyality GlbLoyalty { get; set; }
		[CProperty(Navigation ="OppContactRole:GlbRoleId")]
		public OppContactRole GlbRole { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="GlbCustomerKeyPlayerListFile:GlbCustomerKeyPlayerListId")]
		public virtual ICollection<GlbCustomerKeyPlayerListFile> GlbCustomerKeyPlayerListFileByGlbCustomerKeyPlayerList { get; set; }
		[CProperty(Association ="GlbCustomerKeyPlayerListInFolder:GlbCustomerKeyPlayerListId")]
		public virtual ICollection<GlbCustomerKeyPlayerListInFolder> GlbCustomerKeyPlayerListInFolderByGlbCustomerKeyPlayerList { get; set; }
		[CProperty(Association ="GlbCustomerKeyPlayerListInTag:EntityId")]
		public virtual ICollection<GlbCustomerKeyPlayerListInTag> GlbCustomerKeyPlayerListInTagByEntity { get; set; }
		#endregion
	}
}
