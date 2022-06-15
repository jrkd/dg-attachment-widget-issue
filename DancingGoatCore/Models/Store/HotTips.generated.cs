//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.DancingGoatCore;

[assembly: RegisterDocumentType(HotTips.CLASS_NAME, typeof(HotTips))]

namespace CMS.DocumentEngine.Types.DancingGoatCore
{
	/// <summary>
	/// Represents a content item of type HotTips.
	/// </summary>
	public partial class HotTips : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DancingGoatCore.HotTips";


		/// <summary>
		/// The instance of the class that provides extended API for working with HotTips fields.
		/// </summary>
		private readonly HotTipsFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HotTipsID.
		/// </summary>
		[DatabaseIDField]
		public int HotTipsID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HotTipsID"), 0);
			}
			set
			{
				SetValue("HotTipsID", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with HotTips fields.
		/// </summary>
		[RegisterProperty]
		public HotTipsFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with HotTips fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HotTipsFields : AbstractHierarchicalObject<HotTipsFields>
		{
			/// <summary>
			/// The content item of type HotTips that is a target of the extended API.
			/// </summary>
			private readonly HotTips mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HotTipsFields" /> class with the specified content item of type HotTips.
			/// </summary>
			/// <param name="instance">The content item of type HotTips that is a target of the extended API.</param>
			public HotTipsFields(HotTips instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HotTipsID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HotTipsID;
				}
				set
				{
					mInstance.HotTipsID = value;
				}
			}


			/// <summary>
			/// Hot tips.
			/// </summary>
			public IEnumerable<TreeNode> HotTips
			{
				get
				{
					return mInstance.GetRelatedDocuments("HotTips");
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="HotTips" /> class.
		/// </summary>
		public HotTips() : base(CLASS_NAME)
		{
			mFields = new HotTipsFields(this);
		}

		#endregion
	}
}