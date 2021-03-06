//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2018 July 17 05:02:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        public partial interface I : EmptyInterface
        {
        }

        [GeneratedCode("go2cs", "0.1.1.0")]
        public struct I<T> : I
        {
            private T m_target;

            private delegate void MByVal(T value);
            private delegate void MByRef(ref T value);

            private static readonly MByVal s_MByVal;
            private static readonly MByRef s_MByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void M() => s_MByRef?.Invoke(ref m_target) ?? s_MByVal(m_target);

            [DebuggerStepperBoundary]
            static I()
            {
                Type targetType = typeof(T);
                MethodInfo extensionMethod;

                extensionMethod = targetType.GetExtensionMethod("M");

                if ((object)extensionMethod != null)
                {
                    s_MByRef = extensionMethod.CreateStaticDelegate(typeof(MByRef)) as MByRef;

                    if ((object)s_MByRef == null)
                        s_MByVal = extensionMethod.CreateStaticDelegate(typeof(MByVal)) as MByVal;
                }

                if ((object)s_MByRef == null && (object)s_MByVal == null)
                    throw new NotImplementedException($"{targetType.Name} does not implement I.M method", new Exception("M"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator I<T>(T target) => new I<T> { m_target = target };

            // Enable comparisons between nil and I<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(I<T> value, NilType nil) => (object)value == null || Activator.CreateInstance<I<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(I<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, I<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, I<T> value) => value != nil;
        }

        [GeneratedCode("go2cs", "0.1.1.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static I I_cast<T>(T target)
        {
            if (typeof(I).IsAssignableFrom(typeof(T)))
                return target as I;

            return (I<T>)target;
        }
    }
}

namespace go
{
    public partial class NilType
    {
        // Enable comparisons between nil and I interface
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(go.main_package.I value, NilType nil) => (object)value == null || Activator.CreateInstance(value.GetType()).Equals(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(go.main_package.I value, NilType nil) => !(value == nil);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(NilType nil, go.main_package.I value) => value == nil;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(NilType nil, go.main_package.I value) => value != nil;
    }

    public static class main_IExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.1.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T TypeAssert<T>(this go.main_package.I target)
        {
            try
            {
                go.main_package.I<T> test = (go.main_package.I<T>)target;
                return (T)target;
            }
            catch (InvalidCastException)
            {
                throw new PanicException($"panic: interface conversion: {target.GetType().FullName} is not {typeof(T).FullName}");
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"panic: interface conversion: {target.GetType().FullName} is not {typeof(T).FullName}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.1.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool TryTypeAssert<T>(this go.main_package.I target, out T result)
        {
            try
            {
                result = target.TypeAssert<T>();
                return true;
            }
            catch (PanicException)
            {
                result = default(T);
                return false;
            }
        }

        [GeneratedCode("go2cs", "0.1.1.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static object TypeAssert(this go.main_package.I target, Type type)
        {
            try
            {
                MethodInfo conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.main_package.I<>).GetExplicitGenericConversionOperator(type));

                if ((object)conversionOperator == null)
                    throw new PanicException($"panic: interface conversion: {target.GetType().FullName} is not {type.FullName}");

                return conversionOperator.Invoke(null, new object[] { target });
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"panic: interface conversion: {target.GetType().FullName} is not {type.FullName}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.1.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool TryTypeAssert(this go.main_package.I target, Type type, out object result)
        {
            try
            {
                result = target.TypeAssert(type);
                return true;
            }
            catch (PanicException)
            {
                result = type.IsValueType ? Activator.CreateInstance(type) : null;
                return false;
            }
        }
    }
}