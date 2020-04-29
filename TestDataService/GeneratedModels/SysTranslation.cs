using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysTranslation")]
	public class SysTranslation : BaseEntity
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
		private string _ErrorMessage;
		[CProperty(ColumnPath ="ErrorMessage")]
		public string ErrorMessage
		{
			get{return _ErrorMessage;}
			set
			{
				_ErrorMessage = value;
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
		private bool _IsChanged0;
		[CProperty(ColumnPath ="IsChanged0")]
		public bool IsChanged0
		{
			get{return _IsChanged0;}
			set
			{
				_IsChanged0 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged1;
		[CProperty(ColumnPath ="IsChanged1")]
		public bool IsChanged1
		{
			get{return _IsChanged1;}
			set
			{
				_IsChanged1 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged10;
		[CProperty(ColumnPath ="IsChanged10")]
		public bool IsChanged10
		{
			get{return _IsChanged10;}
			set
			{
				_IsChanged10 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged11;
		[CProperty(ColumnPath ="IsChanged11")]
		public bool IsChanged11
		{
			get{return _IsChanged11;}
			set
			{
				_IsChanged11 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged12;
		[CProperty(ColumnPath ="IsChanged12")]
		public bool IsChanged12
		{
			get{return _IsChanged12;}
			set
			{
				_IsChanged12 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged13;
		[CProperty(ColumnPath ="IsChanged13")]
		public bool IsChanged13
		{
			get{return _IsChanged13;}
			set
			{
				_IsChanged13 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged14;
		[CProperty(ColumnPath ="IsChanged14")]
		public bool IsChanged14
		{
			get{return _IsChanged14;}
			set
			{
				_IsChanged14 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged15;
		[CProperty(ColumnPath ="IsChanged15")]
		public bool IsChanged15
		{
			get{return _IsChanged15;}
			set
			{
				_IsChanged15 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged16;
		[CProperty(ColumnPath ="IsChanged16")]
		public bool IsChanged16
		{
			get{return _IsChanged16;}
			set
			{
				_IsChanged16 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged17;
		[CProperty(ColumnPath ="IsChanged17")]
		public bool IsChanged17
		{
			get{return _IsChanged17;}
			set
			{
				_IsChanged17 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged18;
		[CProperty(ColumnPath ="IsChanged18")]
		public bool IsChanged18
		{
			get{return _IsChanged18;}
			set
			{
				_IsChanged18 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged19;
		[CProperty(ColumnPath ="IsChanged19")]
		public bool IsChanged19
		{
			get{return _IsChanged19;}
			set
			{
				_IsChanged19 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged2;
		[CProperty(ColumnPath ="IsChanged2")]
		public bool IsChanged2
		{
			get{return _IsChanged2;}
			set
			{
				_IsChanged2 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged20;
		[CProperty(ColumnPath ="IsChanged20")]
		public bool IsChanged20
		{
			get{return _IsChanged20;}
			set
			{
				_IsChanged20 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged21;
		[CProperty(ColumnPath ="IsChanged21")]
		public bool IsChanged21
		{
			get{return _IsChanged21;}
			set
			{
				_IsChanged21 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged22;
		[CProperty(ColumnPath ="IsChanged22")]
		public bool IsChanged22
		{
			get{return _IsChanged22;}
			set
			{
				_IsChanged22 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged23;
		[CProperty(ColumnPath ="IsChanged23")]
		public bool IsChanged23
		{
			get{return _IsChanged23;}
			set
			{
				_IsChanged23 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged24;
		[CProperty(ColumnPath ="IsChanged24")]
		public bool IsChanged24
		{
			get{return _IsChanged24;}
			set
			{
				_IsChanged24 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged25;
		[CProperty(ColumnPath ="IsChanged25")]
		public bool IsChanged25
		{
			get{return _IsChanged25;}
			set
			{
				_IsChanged25 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged26;
		[CProperty(ColumnPath ="IsChanged26")]
		public bool IsChanged26
		{
			get{return _IsChanged26;}
			set
			{
				_IsChanged26 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged27;
		[CProperty(ColumnPath ="IsChanged27")]
		public bool IsChanged27
		{
			get{return _IsChanged27;}
			set
			{
				_IsChanged27 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged28;
		[CProperty(ColumnPath ="IsChanged28")]
		public bool IsChanged28
		{
			get{return _IsChanged28;}
			set
			{
				_IsChanged28 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged29;
		[CProperty(ColumnPath ="IsChanged29")]
		public bool IsChanged29
		{
			get{return _IsChanged29;}
			set
			{
				_IsChanged29 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged3;
		[CProperty(ColumnPath ="IsChanged3")]
		public bool IsChanged3
		{
			get{return _IsChanged3;}
			set
			{
				_IsChanged3 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged30;
		[CProperty(ColumnPath ="IsChanged30")]
		public bool IsChanged30
		{
			get{return _IsChanged30;}
			set
			{
				_IsChanged30 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged4;
		[CProperty(ColumnPath ="IsChanged4")]
		public bool IsChanged4
		{
			get{return _IsChanged4;}
			set
			{
				_IsChanged4 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged5;
		[CProperty(ColumnPath ="IsChanged5")]
		public bool IsChanged5
		{
			get{return _IsChanged5;}
			set
			{
				_IsChanged5 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged6;
		[CProperty(ColumnPath ="IsChanged6")]
		public bool IsChanged6
		{
			get{return _IsChanged6;}
			set
			{
				_IsChanged6 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged7;
		[CProperty(ColumnPath ="IsChanged7")]
		public bool IsChanged7
		{
			get{return _IsChanged7;}
			set
			{
				_IsChanged7 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged8;
		[CProperty(ColumnPath ="IsChanged8")]
		public bool IsChanged8
		{
			get{return _IsChanged8;}
			set
			{
				_IsChanged8 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged9;
		[CProperty(ColumnPath ="IsChanged9")]
		public bool IsChanged9
		{
			get{return _IsChanged9;}
			set
			{
				_IsChanged9 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified0;
		[CProperty(ColumnPath ="IsVerified0")]
		public bool IsVerified0
		{
			get{return _IsVerified0;}
			set
			{
				_IsVerified0 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified1;
		[CProperty(ColumnPath ="IsVerified1")]
		public bool IsVerified1
		{
			get{return _IsVerified1;}
			set
			{
				_IsVerified1 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified10;
		[CProperty(ColumnPath ="IsVerified10")]
		public bool IsVerified10
		{
			get{return _IsVerified10;}
			set
			{
				_IsVerified10 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified11;
		[CProperty(ColumnPath ="IsVerified11")]
		public bool IsVerified11
		{
			get{return _IsVerified11;}
			set
			{
				_IsVerified11 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified12;
		[CProperty(ColumnPath ="IsVerified12")]
		public bool IsVerified12
		{
			get{return _IsVerified12;}
			set
			{
				_IsVerified12 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified13;
		[CProperty(ColumnPath ="IsVerified13")]
		public bool IsVerified13
		{
			get{return _IsVerified13;}
			set
			{
				_IsVerified13 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified14;
		[CProperty(ColumnPath ="IsVerified14")]
		public bool IsVerified14
		{
			get{return _IsVerified14;}
			set
			{
				_IsVerified14 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified15;
		[CProperty(ColumnPath ="IsVerified15")]
		public bool IsVerified15
		{
			get{return _IsVerified15;}
			set
			{
				_IsVerified15 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified16;
		[CProperty(ColumnPath ="IsVerified16")]
		public bool IsVerified16
		{
			get{return _IsVerified16;}
			set
			{
				_IsVerified16 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified17;
		[CProperty(ColumnPath ="IsVerified17")]
		public bool IsVerified17
		{
			get{return _IsVerified17;}
			set
			{
				_IsVerified17 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified18;
		[CProperty(ColumnPath ="IsVerified18")]
		public bool IsVerified18
		{
			get{return _IsVerified18;}
			set
			{
				_IsVerified18 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified19;
		[CProperty(ColumnPath ="IsVerified19")]
		public bool IsVerified19
		{
			get{return _IsVerified19;}
			set
			{
				_IsVerified19 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified2;
		[CProperty(ColumnPath ="IsVerified2")]
		public bool IsVerified2
		{
			get{return _IsVerified2;}
			set
			{
				_IsVerified2 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified20;
		[CProperty(ColumnPath ="IsVerified20")]
		public bool IsVerified20
		{
			get{return _IsVerified20;}
			set
			{
				_IsVerified20 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified21;
		[CProperty(ColumnPath ="IsVerified21")]
		public bool IsVerified21
		{
			get{return _IsVerified21;}
			set
			{
				_IsVerified21 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified22;
		[CProperty(ColumnPath ="IsVerified22")]
		public bool IsVerified22
		{
			get{return _IsVerified22;}
			set
			{
				_IsVerified22 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified23;
		[CProperty(ColumnPath ="IsVerified23")]
		public bool IsVerified23
		{
			get{return _IsVerified23;}
			set
			{
				_IsVerified23 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified24;
		[CProperty(ColumnPath ="IsVerified24")]
		public bool IsVerified24
		{
			get{return _IsVerified24;}
			set
			{
				_IsVerified24 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified25;
		[CProperty(ColumnPath ="IsVerified25")]
		public bool IsVerified25
		{
			get{return _IsVerified25;}
			set
			{
				_IsVerified25 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified26;
		[CProperty(ColumnPath ="IsVerified26")]
		public bool IsVerified26
		{
			get{return _IsVerified26;}
			set
			{
				_IsVerified26 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified27;
		[CProperty(ColumnPath ="IsVerified27")]
		public bool IsVerified27
		{
			get{return _IsVerified27;}
			set
			{
				_IsVerified27 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified28;
		[CProperty(ColumnPath ="IsVerified28")]
		public bool IsVerified28
		{
			get{return _IsVerified28;}
			set
			{
				_IsVerified28 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified29;
		[CProperty(ColumnPath ="IsVerified29")]
		public bool IsVerified29
		{
			get{return _IsVerified29;}
			set
			{
				_IsVerified29 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified3;
		[CProperty(ColumnPath ="IsVerified3")]
		public bool IsVerified3
		{
			get{return _IsVerified3;}
			set
			{
				_IsVerified3 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified30;
		[CProperty(ColumnPath ="IsVerified30")]
		public bool IsVerified30
		{
			get{return _IsVerified30;}
			set
			{
				_IsVerified30 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified4;
		[CProperty(ColumnPath ="IsVerified4")]
		public bool IsVerified4
		{
			get{return _IsVerified4;}
			set
			{
				_IsVerified4 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified5;
		[CProperty(ColumnPath ="IsVerified5")]
		public bool IsVerified5
		{
			get{return _IsVerified5;}
			set
			{
				_IsVerified5 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified6;
		[CProperty(ColumnPath ="IsVerified6")]
		public bool IsVerified6
		{
			get{return _IsVerified6;}
			set
			{
				_IsVerified6 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified7;
		[CProperty(ColumnPath ="IsVerified7")]
		public bool IsVerified7
		{
			get{return _IsVerified7;}
			set
			{
				_IsVerified7 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified8;
		[CProperty(ColumnPath ="IsVerified8")]
		public bool IsVerified8
		{
			get{return _IsVerified8;}
			set
			{
				_IsVerified8 = value;
				OnPropertyChanged();
			}
		}
		private bool _IsVerified9;
		[CProperty(ColumnPath ="IsVerified9")]
		public bool IsVerified9
		{
			get{return _IsVerified9;}
			set
			{
				_IsVerified9 = value;
				OnPropertyChanged();
			}
		}
		private string _Key;
		[CProperty(ColumnPath ="Key")]
		public string Key
		{
			get{return _Key;}
			set
			{
				_Key = value;
				OnPropertyChanged();
			}
		}
		private string _Language0;
		[CProperty(ColumnPath ="Language0")]
		public string Language0
		{
			get{return _Language0;}
			set
			{
				_Language0 = value;
				OnPropertyChanged();
			}
		}
		private string _Language0Short;
		[CProperty(ColumnPath ="Language0Short")]
		public string Language0Short
		{
			get{return _Language0Short;}
			set
			{
				_Language0Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language1;
		[CProperty(ColumnPath ="Language1")]
		public string Language1
		{
			get{return _Language1;}
			set
			{
				_Language1 = value;
				OnPropertyChanged();
			}
		}
		private string _Language10;
		[CProperty(ColumnPath ="Language10")]
		public string Language10
		{
			get{return _Language10;}
			set
			{
				_Language10 = value;
				OnPropertyChanged();
			}
		}
		private string _Language10Short;
		[CProperty(ColumnPath ="Language10Short")]
		public string Language10Short
		{
			get{return _Language10Short;}
			set
			{
				_Language10Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language11;
		[CProperty(ColumnPath ="Language11")]
		public string Language11
		{
			get{return _Language11;}
			set
			{
				_Language11 = value;
				OnPropertyChanged();
			}
		}
		private string _Language11Short;
		[CProperty(ColumnPath ="Language11Short")]
		public string Language11Short
		{
			get{return _Language11Short;}
			set
			{
				_Language11Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language12;
		[CProperty(ColumnPath ="Language12")]
		public string Language12
		{
			get{return _Language12;}
			set
			{
				_Language12 = value;
				OnPropertyChanged();
			}
		}
		private string _Language12Short;
		[CProperty(ColumnPath ="Language12Short")]
		public string Language12Short
		{
			get{return _Language12Short;}
			set
			{
				_Language12Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language13;
		[CProperty(ColumnPath ="Language13")]
		public string Language13
		{
			get{return _Language13;}
			set
			{
				_Language13 = value;
				OnPropertyChanged();
			}
		}
		private string _Language13Short;
		[CProperty(ColumnPath ="Language13Short")]
		public string Language13Short
		{
			get{return _Language13Short;}
			set
			{
				_Language13Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language14;
		[CProperty(ColumnPath ="Language14")]
		public string Language14
		{
			get{return _Language14;}
			set
			{
				_Language14 = value;
				OnPropertyChanged();
			}
		}
		private string _Language14Short;
		[CProperty(ColumnPath ="Language14Short")]
		public string Language14Short
		{
			get{return _Language14Short;}
			set
			{
				_Language14Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language15;
		[CProperty(ColumnPath ="Language15")]
		public string Language15
		{
			get{return _Language15;}
			set
			{
				_Language15 = value;
				OnPropertyChanged();
			}
		}
		private string _Language15Short;
		[CProperty(ColumnPath ="Language15Short")]
		public string Language15Short
		{
			get{return _Language15Short;}
			set
			{
				_Language15Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language16;
		[CProperty(ColumnPath ="Language16")]
		public string Language16
		{
			get{return _Language16;}
			set
			{
				_Language16 = value;
				OnPropertyChanged();
			}
		}
		private string _Language16Short;
		[CProperty(ColumnPath ="Language16Short")]
		public string Language16Short
		{
			get{return _Language16Short;}
			set
			{
				_Language16Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language17;
		[CProperty(ColumnPath ="Language17")]
		public string Language17
		{
			get{return _Language17;}
			set
			{
				_Language17 = value;
				OnPropertyChanged();
			}
		}
		private string _Language17Short;
		[CProperty(ColumnPath ="Language17Short")]
		public string Language17Short
		{
			get{return _Language17Short;}
			set
			{
				_Language17Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language18;
		[CProperty(ColumnPath ="Language18")]
		public string Language18
		{
			get{return _Language18;}
			set
			{
				_Language18 = value;
				OnPropertyChanged();
			}
		}
		private string _Language18Short;
		[CProperty(ColumnPath ="Language18Short")]
		public string Language18Short
		{
			get{return _Language18Short;}
			set
			{
				_Language18Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language19;
		[CProperty(ColumnPath ="Language19")]
		public string Language19
		{
			get{return _Language19;}
			set
			{
				_Language19 = value;
				OnPropertyChanged();
			}
		}
		private string _Language19Short;
		[CProperty(ColumnPath ="Language19Short")]
		public string Language19Short
		{
			get{return _Language19Short;}
			set
			{
				_Language19Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language1Short;
		[CProperty(ColumnPath ="Language1Short")]
		public string Language1Short
		{
			get{return _Language1Short;}
			set
			{
				_Language1Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language2;
		[CProperty(ColumnPath ="Language2")]
		public string Language2
		{
			get{return _Language2;}
			set
			{
				_Language2 = value;
				OnPropertyChanged();
			}
		}
		private string _Language20;
		[CProperty(ColumnPath ="Language20")]
		public string Language20
		{
			get{return _Language20;}
			set
			{
				_Language20 = value;
				OnPropertyChanged();
			}
		}
		private string _Language20Short;
		[CProperty(ColumnPath ="Language20Short")]
		public string Language20Short
		{
			get{return _Language20Short;}
			set
			{
				_Language20Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language21;
		[CProperty(ColumnPath ="Language21")]
		public string Language21
		{
			get{return _Language21;}
			set
			{
				_Language21 = value;
				OnPropertyChanged();
			}
		}
		private string _Language21Short;
		[CProperty(ColumnPath ="Language21Short")]
		public string Language21Short
		{
			get{return _Language21Short;}
			set
			{
				_Language21Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language22;
		[CProperty(ColumnPath ="Language22")]
		public string Language22
		{
			get{return _Language22;}
			set
			{
				_Language22 = value;
				OnPropertyChanged();
			}
		}
		private string _Language22Short;
		[CProperty(ColumnPath ="Language22Short")]
		public string Language22Short
		{
			get{return _Language22Short;}
			set
			{
				_Language22Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language23;
		[CProperty(ColumnPath ="Language23")]
		public string Language23
		{
			get{return _Language23;}
			set
			{
				_Language23 = value;
				OnPropertyChanged();
			}
		}
		private string _Language23Short;
		[CProperty(ColumnPath ="Language23Short")]
		public string Language23Short
		{
			get{return _Language23Short;}
			set
			{
				_Language23Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language24;
		[CProperty(ColumnPath ="Language24")]
		public string Language24
		{
			get{return _Language24;}
			set
			{
				_Language24 = value;
				OnPropertyChanged();
			}
		}
		private string _Language24Short;
		[CProperty(ColumnPath ="Language24Short")]
		public string Language24Short
		{
			get{return _Language24Short;}
			set
			{
				_Language24Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language25;
		[CProperty(ColumnPath ="Language25")]
		public string Language25
		{
			get{return _Language25;}
			set
			{
				_Language25 = value;
				OnPropertyChanged();
			}
		}
		private string _Language25Short;
		[CProperty(ColumnPath ="Language25Short")]
		public string Language25Short
		{
			get{return _Language25Short;}
			set
			{
				_Language25Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language26;
		[CProperty(ColumnPath ="Language26")]
		public string Language26
		{
			get{return _Language26;}
			set
			{
				_Language26 = value;
				OnPropertyChanged();
			}
		}
		private string _Language26Short;
		[CProperty(ColumnPath ="Language26Short")]
		public string Language26Short
		{
			get{return _Language26Short;}
			set
			{
				_Language26Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language27;
		[CProperty(ColumnPath ="Language27")]
		public string Language27
		{
			get{return _Language27;}
			set
			{
				_Language27 = value;
				OnPropertyChanged();
			}
		}
		private string _Language27Short;
		[CProperty(ColumnPath ="Language27Short")]
		public string Language27Short
		{
			get{return _Language27Short;}
			set
			{
				_Language27Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language28;
		[CProperty(ColumnPath ="Language28")]
		public string Language28
		{
			get{return _Language28;}
			set
			{
				_Language28 = value;
				OnPropertyChanged();
			}
		}
		private string _Language28Short;
		[CProperty(ColumnPath ="Language28Short")]
		public string Language28Short
		{
			get{return _Language28Short;}
			set
			{
				_Language28Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language29;
		[CProperty(ColumnPath ="Language29")]
		public string Language29
		{
			get{return _Language29;}
			set
			{
				_Language29 = value;
				OnPropertyChanged();
			}
		}
		private string _Language29Short;
		[CProperty(ColumnPath ="Language29Short")]
		public string Language29Short
		{
			get{return _Language29Short;}
			set
			{
				_Language29Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language2Short;
		[CProperty(ColumnPath ="Language2Short")]
		public string Language2Short
		{
			get{return _Language2Short;}
			set
			{
				_Language2Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language3;
		[CProperty(ColumnPath ="Language3")]
		public string Language3
		{
			get{return _Language3;}
			set
			{
				_Language3 = value;
				OnPropertyChanged();
			}
		}
		private string _Language30;
		[CProperty(ColumnPath ="Language30")]
		public string Language30
		{
			get{return _Language30;}
			set
			{
				_Language30 = value;
				OnPropertyChanged();
			}
		}
		private string _Language30Short;
		[CProperty(ColumnPath ="Language30Short")]
		public string Language30Short
		{
			get{return _Language30Short;}
			set
			{
				_Language30Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language3Short;
		[CProperty(ColumnPath ="Language3Short")]
		public string Language3Short
		{
			get{return _Language3Short;}
			set
			{
				_Language3Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language4;
		[CProperty(ColumnPath ="Language4")]
		public string Language4
		{
			get{return _Language4;}
			set
			{
				_Language4 = value;
				OnPropertyChanged();
			}
		}
		private string _Language4Short;
		[CProperty(ColumnPath ="Language4Short")]
		public string Language4Short
		{
			get{return _Language4Short;}
			set
			{
				_Language4Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language5;
		[CProperty(ColumnPath ="Language5")]
		public string Language5
		{
			get{return _Language5;}
			set
			{
				_Language5 = value;
				OnPropertyChanged();
			}
		}
		private string _Language5Short;
		[CProperty(ColumnPath ="Language5Short")]
		public string Language5Short
		{
			get{return _Language5Short;}
			set
			{
				_Language5Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language6;
		[CProperty(ColumnPath ="Language6")]
		public string Language6
		{
			get{return _Language6;}
			set
			{
				_Language6 = value;
				OnPropertyChanged();
			}
		}
		private string _Language6Short;
		[CProperty(ColumnPath ="Language6Short")]
		public string Language6Short
		{
			get{return _Language6Short;}
			set
			{
				_Language6Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language7;
		[CProperty(ColumnPath ="Language7")]
		public string Language7
		{
			get{return _Language7;}
			set
			{
				_Language7 = value;
				OnPropertyChanged();
			}
		}
		private string _Language7Short;
		[CProperty(ColumnPath ="Language7Short")]
		public string Language7Short
		{
			get{return _Language7Short;}
			set
			{
				_Language7Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language8;
		[CProperty(ColumnPath ="Language8")]
		public string Language8
		{
			get{return _Language8;}
			set
			{
				_Language8 = value;
				OnPropertyChanged();
			}
		}
		private string _Language8Short;
		[CProperty(ColumnPath ="Language8Short")]
		public string Language8Short
		{
			get{return _Language8Short;}
			set
			{
				_Language8Short = value;
				OnPropertyChanged();
			}
		}
		private string _Language9;
		[CProperty(ColumnPath ="Language9")]
		public string Language9
		{
			get{return _Language9;}
			set
			{
				_Language9 = value;
				OnPropertyChanged();
			}
		}
		private string _Language9Short;
		[CProperty(ColumnPath ="Language9Short")]
		public string Language9Short
		{
			get{return _Language9Short;}
			set
			{
				_Language9Short = value;
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysTranslationInFolder:SysTranslationId")]
		public virtual ICollection<SysTranslationInFolder> SysTranslationInFolderBySysTranslation { get; set; }
		[CProperty(Association ="SysTranslationInTag:EntityId")]
		public virtual ICollection<SysTranslationInTag> SysTranslationInTagByEntity { get; set; }
		#endregion
	}
}
