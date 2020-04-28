using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysTranslation")]
	public class SysTranslation : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ErrorMessage")]
		public string ErrorMessage { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsChanged0")]
		public bool IsChanged0 { get; set; }
		[CProperty(ColumnPath ="IsChanged1")]
		public bool IsChanged1 { get; set; }
		[CProperty(ColumnPath ="IsChanged10")]
		public bool IsChanged10 { get; set; }
		[CProperty(ColumnPath ="IsChanged11")]
		public bool IsChanged11 { get; set; }
		[CProperty(ColumnPath ="IsChanged12")]
		public bool IsChanged12 { get; set; }
		[CProperty(ColumnPath ="IsChanged13")]
		public bool IsChanged13 { get; set; }
		[CProperty(ColumnPath ="IsChanged14")]
		public bool IsChanged14 { get; set; }
		[CProperty(ColumnPath ="IsChanged15")]
		public bool IsChanged15 { get; set; }
		[CProperty(ColumnPath ="IsChanged16")]
		public bool IsChanged16 { get; set; }
		[CProperty(ColumnPath ="IsChanged17")]
		public bool IsChanged17 { get; set; }
		[CProperty(ColumnPath ="IsChanged18")]
		public bool IsChanged18 { get; set; }
		[CProperty(ColumnPath ="IsChanged19")]
		public bool IsChanged19 { get; set; }
		[CProperty(ColumnPath ="IsChanged2")]
		public bool IsChanged2 { get; set; }
		[CProperty(ColumnPath ="IsChanged20")]
		public bool IsChanged20 { get; set; }
		[CProperty(ColumnPath ="IsChanged21")]
		public bool IsChanged21 { get; set; }
		[CProperty(ColumnPath ="IsChanged22")]
		public bool IsChanged22 { get; set; }
		[CProperty(ColumnPath ="IsChanged23")]
		public bool IsChanged23 { get; set; }
		[CProperty(ColumnPath ="IsChanged24")]
		public bool IsChanged24 { get; set; }
		[CProperty(ColumnPath ="IsChanged25")]
		public bool IsChanged25 { get; set; }
		[CProperty(ColumnPath ="IsChanged26")]
		public bool IsChanged26 { get; set; }
		[CProperty(ColumnPath ="IsChanged27")]
		public bool IsChanged27 { get; set; }
		[CProperty(ColumnPath ="IsChanged28")]
		public bool IsChanged28 { get; set; }
		[CProperty(ColumnPath ="IsChanged29")]
		public bool IsChanged29 { get; set; }
		[CProperty(ColumnPath ="IsChanged3")]
		public bool IsChanged3 { get; set; }
		[CProperty(ColumnPath ="IsChanged30")]
		public bool IsChanged30 { get; set; }
		[CProperty(ColumnPath ="IsChanged4")]
		public bool IsChanged4 { get; set; }
		[CProperty(ColumnPath ="IsChanged5")]
		public bool IsChanged5 { get; set; }
		[CProperty(ColumnPath ="IsChanged6")]
		public bool IsChanged6 { get; set; }
		[CProperty(ColumnPath ="IsChanged7")]
		public bool IsChanged7 { get; set; }
		[CProperty(ColumnPath ="IsChanged8")]
		public bool IsChanged8 { get; set; }
		[CProperty(ColumnPath ="IsChanged9")]
		public bool IsChanged9 { get; set; }
		[CProperty(ColumnPath ="IsVerified0")]
		public bool IsVerified0 { get; set; }
		[CProperty(ColumnPath ="IsVerified1")]
		public bool IsVerified1 { get; set; }
		[CProperty(ColumnPath ="IsVerified10")]
		public bool IsVerified10 { get; set; }
		[CProperty(ColumnPath ="IsVerified11")]
		public bool IsVerified11 { get; set; }
		[CProperty(ColumnPath ="IsVerified12")]
		public bool IsVerified12 { get; set; }
		[CProperty(ColumnPath ="IsVerified13")]
		public bool IsVerified13 { get; set; }
		[CProperty(ColumnPath ="IsVerified14")]
		public bool IsVerified14 { get; set; }
		[CProperty(ColumnPath ="IsVerified15")]
		public bool IsVerified15 { get; set; }
		[CProperty(ColumnPath ="IsVerified16")]
		public bool IsVerified16 { get; set; }
		[CProperty(ColumnPath ="IsVerified17")]
		public bool IsVerified17 { get; set; }
		[CProperty(ColumnPath ="IsVerified18")]
		public bool IsVerified18 { get; set; }
		[CProperty(ColumnPath ="IsVerified19")]
		public bool IsVerified19 { get; set; }
		[CProperty(ColumnPath ="IsVerified2")]
		public bool IsVerified2 { get; set; }
		[CProperty(ColumnPath ="IsVerified20")]
		public bool IsVerified20 { get; set; }
		[CProperty(ColumnPath ="IsVerified21")]
		public bool IsVerified21 { get; set; }
		[CProperty(ColumnPath ="IsVerified22")]
		public bool IsVerified22 { get; set; }
		[CProperty(ColumnPath ="IsVerified23")]
		public bool IsVerified23 { get; set; }
		[CProperty(ColumnPath ="IsVerified24")]
		public bool IsVerified24 { get; set; }
		[CProperty(ColumnPath ="IsVerified25")]
		public bool IsVerified25 { get; set; }
		[CProperty(ColumnPath ="IsVerified26")]
		public bool IsVerified26 { get; set; }
		[CProperty(ColumnPath ="IsVerified27")]
		public bool IsVerified27 { get; set; }
		[CProperty(ColumnPath ="IsVerified28")]
		public bool IsVerified28 { get; set; }
		[CProperty(ColumnPath ="IsVerified29")]
		public bool IsVerified29 { get; set; }
		[CProperty(ColumnPath ="IsVerified3")]
		public bool IsVerified3 { get; set; }
		[CProperty(ColumnPath ="IsVerified30")]
		public bool IsVerified30 { get; set; }
		[CProperty(ColumnPath ="IsVerified4")]
		public bool IsVerified4 { get; set; }
		[CProperty(ColumnPath ="IsVerified5")]
		public bool IsVerified5 { get; set; }
		[CProperty(ColumnPath ="IsVerified6")]
		public bool IsVerified6 { get; set; }
		[CProperty(ColumnPath ="IsVerified7")]
		public bool IsVerified7 { get; set; }
		[CProperty(ColumnPath ="IsVerified8")]
		public bool IsVerified8 { get; set; }
		[CProperty(ColumnPath ="IsVerified9")]
		public bool IsVerified9 { get; set; }
		[CProperty(ColumnPath ="Key")]
		public string Key { get; set; }
		[CProperty(ColumnPath ="Language0")]
		public string Language0 { get; set; }
		[CProperty(ColumnPath ="Language0Short")]
		public string Language0Short { get; set; }
		[CProperty(ColumnPath ="Language1")]
		public string Language1 { get; set; }
		[CProperty(ColumnPath ="Language10")]
		public string Language10 { get; set; }
		[CProperty(ColumnPath ="Language10Short")]
		public string Language10Short { get; set; }
		[CProperty(ColumnPath ="Language11")]
		public string Language11 { get; set; }
		[CProperty(ColumnPath ="Language11Short")]
		public string Language11Short { get; set; }
		[CProperty(ColumnPath ="Language12")]
		public string Language12 { get; set; }
		[CProperty(ColumnPath ="Language12Short")]
		public string Language12Short { get; set; }
		[CProperty(ColumnPath ="Language13")]
		public string Language13 { get; set; }
		[CProperty(ColumnPath ="Language13Short")]
		public string Language13Short { get; set; }
		[CProperty(ColumnPath ="Language14")]
		public string Language14 { get; set; }
		[CProperty(ColumnPath ="Language14Short")]
		public string Language14Short { get; set; }
		[CProperty(ColumnPath ="Language15")]
		public string Language15 { get; set; }
		[CProperty(ColumnPath ="Language15Short")]
		public string Language15Short { get; set; }
		[CProperty(ColumnPath ="Language16")]
		public string Language16 { get; set; }
		[CProperty(ColumnPath ="Language16Short")]
		public string Language16Short { get; set; }
		[CProperty(ColumnPath ="Language17")]
		public string Language17 { get; set; }
		[CProperty(ColumnPath ="Language17Short")]
		public string Language17Short { get; set; }
		[CProperty(ColumnPath ="Language18")]
		public string Language18 { get; set; }
		[CProperty(ColumnPath ="Language18Short")]
		public string Language18Short { get; set; }
		[CProperty(ColumnPath ="Language19")]
		public string Language19 { get; set; }
		[CProperty(ColumnPath ="Language19Short")]
		public string Language19Short { get; set; }
		[CProperty(ColumnPath ="Language1Short")]
		public string Language1Short { get; set; }
		[CProperty(ColumnPath ="Language2")]
		public string Language2 { get; set; }
		[CProperty(ColumnPath ="Language20")]
		public string Language20 { get; set; }
		[CProperty(ColumnPath ="Language20Short")]
		public string Language20Short { get; set; }
		[CProperty(ColumnPath ="Language21")]
		public string Language21 { get; set; }
		[CProperty(ColumnPath ="Language21Short")]
		public string Language21Short { get; set; }
		[CProperty(ColumnPath ="Language22")]
		public string Language22 { get; set; }
		[CProperty(ColumnPath ="Language22Short")]
		public string Language22Short { get; set; }
		[CProperty(ColumnPath ="Language23")]
		public string Language23 { get; set; }
		[CProperty(ColumnPath ="Language23Short")]
		public string Language23Short { get; set; }
		[CProperty(ColumnPath ="Language24")]
		public string Language24 { get; set; }
		[CProperty(ColumnPath ="Language24Short")]
		public string Language24Short { get; set; }
		[CProperty(ColumnPath ="Language25")]
		public string Language25 { get; set; }
		[CProperty(ColumnPath ="Language25Short")]
		public string Language25Short { get; set; }
		[CProperty(ColumnPath ="Language26")]
		public string Language26 { get; set; }
		[CProperty(ColumnPath ="Language26Short")]
		public string Language26Short { get; set; }
		[CProperty(ColumnPath ="Language27")]
		public string Language27 { get; set; }
		[CProperty(ColumnPath ="Language27Short")]
		public string Language27Short { get; set; }
		[CProperty(ColumnPath ="Language28")]
		public string Language28 { get; set; }
		[CProperty(ColumnPath ="Language28Short")]
		public string Language28Short { get; set; }
		[CProperty(ColumnPath ="Language29")]
		public string Language29 { get; set; }
		[CProperty(ColumnPath ="Language29Short")]
		public string Language29Short { get; set; }
		[CProperty(ColumnPath ="Language2Short")]
		public string Language2Short { get; set; }
		[CProperty(ColumnPath ="Language3")]
		public string Language3 { get; set; }
		[CProperty(ColumnPath ="Language30")]
		public string Language30 { get; set; }
		[CProperty(ColumnPath ="Language30Short")]
		public string Language30Short { get; set; }
		[CProperty(ColumnPath ="Language3Short")]
		public string Language3Short { get; set; }
		[CProperty(ColumnPath ="Language4")]
		public string Language4 { get; set; }
		[CProperty(ColumnPath ="Language4Short")]
		public string Language4Short { get; set; }
		[CProperty(ColumnPath ="Language5")]
		public string Language5 { get; set; }
		[CProperty(ColumnPath ="Language5Short")]
		public string Language5Short { get; set; }
		[CProperty(ColumnPath ="Language6")]
		public string Language6 { get; set; }
		[CProperty(ColumnPath ="Language6Short")]
		public string Language6Short { get; set; }
		[CProperty(ColumnPath ="Language7")]
		public string Language7 { get; set; }
		[CProperty(ColumnPath ="Language7Short")]
		public string Language7Short { get; set; }
		[CProperty(ColumnPath ="Language8")]
		public string Language8 { get; set; }
		[CProperty(ColumnPath ="Language8Short")]
		public string Language8Short { get; set; }
		[CProperty(ColumnPath ="Language9")]
		public string Language9 { get; set; }
		[CProperty(ColumnPath ="Language9Short")]
		public string Language9Short { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
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
