//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{
	///<summary>
	/// DispatchInterface ITabs SupportByLibrary MSComctlLib, 6
	///</summary>
	[SupportByLibrary("MSComctlLib", 6)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ITabs : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ITabs(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ITabs(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ITabs(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ITabs()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public Int16 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Count", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="pvIndex">object pvIndex</param>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.ITab get_ControlDefault(object pvIndex)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvIndex);
			object returnItem = Invoker.PropertyGet(this, "ControlDefault", paramsArray);
			NetOffice.MSComctlLibApi.ITab newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.ITab;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="pvIndex">object pvIndex</param>
		[SupportByLibrary("MSComctlLib", 6)]
		public void set_ControlDefault(object pvIndex, NetOffice.MSComctlLibApi.ITab value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvIndex);
			Invoker.PropertySet(this, "ControlDefault", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="pvIndex">object pvIndex</param>
		[SupportByLibrary("MSComctlLib", 6)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.MSComctlLibApi.ITab this[object pvIndex]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(pvIndex);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.MSComctlLibApi.ITab newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.ITab;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="pvIndex">object pvIndex</param>
		[SupportByLibrary("MSComctlLib", 6)]
		public void Remove(object pvIndex)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvIndex);
			Invoker.Method(this, "Remove", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="pvIndex">optional object pvIndex</param>
		/// <param name="pvKey">optional object pvKey</param>
		/// <param name="pvCaption">optional object pvCaption</param>
		/// <param name="pvImage">optional object pvImage</param>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.ITab Add(object pvIndex=null, object pvKey=null, object pvCaption=null, object pvImage=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvIndex, pvKey, pvCaption, pvImage);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.ITab newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.ITab;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibrary("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.ITab Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.ITab newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.ITab;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("MSComctlLib", 6)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}