#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2010
//
//     COPYRIGHT (C) 2010, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;

namespace System.Reflection
{
    /// <summary>
    /// Extension methods for inspecting, invoking and working with constructors.
    /// </summary>
    public static class ConstructorInfoExtensions
    {
        /// <summary>
        /// Invokes the constructor <paramref name="ctorInfo"/> with <paramref name="parameters"/> as arguments.
        /// Leave <paramref name="parameters"/> empty if the constructor has no argument.
        /// </summary>
        public static object CreateInstance(this ConstructorInfo ctorInfo, params object[] parameters)
        {
            return ctorInfo.DelegateForCreateInstance()(parameters);
        }

        /// <summary>
        /// Creates a delegate which can create instance based on the constructor <paramref name="ctorInfo"/>.
        /// </summary>
        public static ConstructorInvoker DelegateForCreateInstance(this ConstructorInfo ctorInfo)
        {
            return (ConstructorInvoker)new CtorInvocationEmitter(ctorInfo, Flags.InstanceAnyVisibility).GetDelegate();
        }
    }
}
