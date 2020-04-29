using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "WebService")]
	public class WebService : BaseEntity
	{
		#region Values
		private string _Caption;
		[CProperty(ColumnPath ="Caption")]
		public string Caption
		{
			get{return _Caption;}
			set
			{
				_Caption = value;
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
		private bool _GenerateProxy;
		[CProperty(ColumnPath ="GenerateProxy")]
		public bool GenerateProxy
		{
			get{return _GenerateProxy;}
			set
			{
				_GenerateProxy = value;
				OnPropertyChanged();
			}
		}
		private Guid _HTTPAuthTypeId;
		[CProperty(ColumnPath ="HTTPAuthTypeId")]
		public Guid HTTPAuthTypeId
		{
			get{return _HTTPAuthTypeId;}
			set
			{
				_HTTPAuthTypeId = value;
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
		private string _Login;
		[CProperty(ColumnPath ="Login")]
		public string Login
		{
			get{return _Login;}
			set
			{
				_Login = value;
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
		private string _Namespace;
		[CProperty(ColumnPath ="Namespace")]
		public string Namespace
		{
			get{return _Namespace;}
			set
			{
				_Namespace = value;
				OnPropertyChanged();
			}
		}
		private string _Password;
		[CProperty(ColumnPath ="Password")]
		public string Password
		{
			get{return _Password;}
			set
			{
				_Password = value;
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
		private int _Timeout;
		[CProperty(ColumnPath ="Timeout")]
		public int Timeout
		{
			get{return _Timeout;}
			set
			{
				_Timeout = value;
				OnPropertyChanged();
			}
		}
		private Guid _WebServiceURLId;
		[CProperty(ColumnPath ="WebServiceURLId")]
		public Guid WebServiceURLId
		{
			get{return _WebServiceURLId;}
			set
			{
				_WebServiceURLId = value;
				OnPropertyChanged();
			}
		}
		private string _WSDL;
		[CProperty(ColumnPath ="WSDL")]
		public string WSDL
		{
			get{return _WSDL;}
			set
			{
				_WSDL = value;
				OnPropertyChanged();
			}
		}
		private string _WSDLURL;
		[CProperty(ColumnPath ="WSDLURL")]
		public string WSDLURL
		{
			get{return _WSDLURL;}
			set
			{
				_WSDLURL = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="HTTPAuthType:HTTPAuthTypeId")]
		public HTTPAuthType HTTPAuthType { get; set; }
		[CProperty(Navigation ="WebServiceURL:WebServiceURLId")]
		public WebServiceURL WebServiceURL { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="WebServiceURL:WebServiceId")]
		public virtual ICollection<WebServiceURL> WebServiceURLByWebService { get; set; }
		#endregion
	}
}
