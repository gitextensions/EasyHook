// EasyHook (File: EasyHook\DllImport.cs)
//
// Copyright (c) 2009 Christoph Husse & Copyright (c) 2015 Justin Stenning
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
// Please visit https://easyhook.github.io for more information
// about the project and latest updates.

using System;
using System.Runtime.InteropServices;

namespace EasyHook
{
#pragma warning disable 1591

    static class NativeAPI_x86
    {
        private const String DllName = "EasyHook32.dll";

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern String RtlGetLastErrorStringCopy();

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 RtlGetLastError();

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhInstallHook(
            IntPtr InEntryPoint,
            IntPtr InHookProc,
            IntPtr InCallback,
            IntPtr OutHandle);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhUninstallHook(IntPtr RefHandle);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhWaitForPendingRemovals();


        /*
            Setup the ACLs after hook installation. Please note that every
            hook starts suspended. You will have to set a proper ACL to
            make it active!
        */
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhSetInclusiveACL(
                    [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)]
                    Int32[] InThreadIdList,
                    Int32 InThreadCount,
                    IntPtr InHandle);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhSetExclusiveACL(
                    [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)]
                    Int32[] InThreadIdList,
                    Int32 InThreadCount,
                    IntPtr InHandle);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhSetGlobalInclusiveACL(
                    [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
                    Int32[] InThreadIdList,
                    Int32 InThreadCount);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhSetGlobalExclusiveACL(
                    [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)]
                    Int32[] InThreadIdList,
                    Int32 InThreadCount);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhIsThreadIntercepted(
                    IntPtr InHandle,
                    Int32 InThreadID,
                    out Boolean OutResult);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern int LhGetHookBypassAddress(IntPtr handle, out IntPtr address);
    }

    static class NativeAPI_x64
    {
        private const String DllName = "EasyHook64.dll";

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern String RtlGetLastErrorStringCopy();

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 RtlGetLastError();

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhInstallHook(
            IntPtr InEntryPoint,
            IntPtr InHookProc,
            IntPtr InCallback,
            IntPtr OutHandle);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhUninstallHook(IntPtr RefHandle);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhWaitForPendingRemovals();


        /*
            Setup the ACLs after hook installation. Please note that every
            hook starts suspended. You will have to set a proper ACL to
            make it active!
        */
        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhSetInclusiveACL(
                    [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
                    Int32[] InThreadIdList,
                    Int32 InThreadCount,
                    IntPtr InHandle);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhSetExclusiveACL(
                    [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
                    Int32[] InThreadIdList,
                    Int32 InThreadCount,
                    IntPtr InHandle);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhSetGlobalInclusiveACL(
                    [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
                    Int32[] InThreadIdList,
                    Int32 InThreadCount);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhSetGlobalExclusiveACL(
                    [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
                    Int32[] InThreadIdList,
                    Int32 InThreadCount);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 LhIsThreadIntercepted(
                    IntPtr InHandle,
                    Int32 InThreadID,
                    out Boolean OutResult);

        [DllImport(DllName, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern int LhGetHookBypassAddress(IntPtr handle, out IntPtr address);
    }

    public static class NativeAPI
    {
        public readonly static Boolean Is64Bit = IntPtr.Size == 8;

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        public static extern IntPtr GetProcAddress(IntPtr InModule, String InProcName);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadLibrary(String InPath);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr GetModuleHandle(String InPath);

        public const Int32 STATUS_SUCCESS = unchecked((Int32)0);
        public const Int32 STATUS_INVALID_PARAMETER = unchecked((Int32)0xC000000DL);
        public const Int32 STATUS_INVALID_PARAMETER_1 = unchecked((Int32)0xC00000EFL);
        public const Int32 STATUS_INVALID_PARAMETER_2 = unchecked((Int32)0xC00000F0L);
        public const Int32 STATUS_INVALID_PARAMETER_3 = unchecked((Int32)0xC00000F1L);
        public const Int32 STATUS_INVALID_PARAMETER_4 = unchecked((Int32)0xC00000F2L);
        public const Int32 STATUS_INVALID_PARAMETER_5 = unchecked((Int32)0xC00000F3L);
        public const Int32 STATUS_NOT_SUPPORTED = unchecked((Int32)0xC00000BBL);

        public const Int32 STATUS_INTERNAL_ERROR = unchecked((Int32)0xC00000E5L);
        public const Int32 STATUS_INSUFFICIENT_RESOURCES = unchecked((Int32)0xC000009AL);
        public const Int32 STATUS_BUFFER_TOO_SMALL = unchecked((Int32)0xC0000023L);
        public const Int32 STATUS_NO_MEMORY = unchecked((Int32)0xC0000017L);
        public const Int32 STATUS_WOW_ASSERTION = unchecked((Int32)0xC0009898L);
        public const Int32 STATUS_ACCESS_DENIED = unchecked((Int32)0xC0000022L);

        private static String ComposeString()
        {
            return String.Format("{0} (Code: {1})", RtlGetLastErrorString(), RtlGetLastError());
        }

        internal static void Force(Int32 InErrorCode)
        {
            switch (InErrorCode)
            {
                case STATUS_SUCCESS: return;
                case STATUS_INVALID_PARAMETER: throw new ArgumentException("STATUS_INVALID_PARAMETER: " + ComposeString());
                case STATUS_INVALID_PARAMETER_1: throw new ArgumentException("STATUS_INVALID_PARAMETER_1: " + ComposeString());
                case STATUS_INVALID_PARAMETER_2: throw new ArgumentException("STATUS_INVALID_PARAMETER_2: " + ComposeString());
                case STATUS_INVALID_PARAMETER_3: throw new ArgumentException("STATUS_INVALID_PARAMETER_3: " + ComposeString());
                case STATUS_INVALID_PARAMETER_4: throw new ArgumentException("STATUS_INVALID_PARAMETER_4: " + ComposeString());
                case STATUS_INVALID_PARAMETER_5: throw new ArgumentException("STATUS_INVALID_PARAMETER_5: " + ComposeString());
                case STATUS_NOT_SUPPORTED: throw new NotSupportedException("STATUS_NOT_SUPPORTED: " + ComposeString());
                case STATUS_INTERNAL_ERROR: throw new ApplicationException("STATUS_INTERNAL_ERROR: " + ComposeString());
                case STATUS_INSUFFICIENT_RESOURCES: throw new InsufficientMemoryException("STATUS_INSUFFICIENT_RESOURCES: " + ComposeString());
                case STATUS_BUFFER_TOO_SMALL: throw new ArgumentException("STATUS_BUFFER_TOO_SMALL: " + ComposeString());
                case STATUS_NO_MEMORY: throw new OutOfMemoryException("STATUS_NO_MEMORY: " + ComposeString());
                case STATUS_WOW_ASSERTION: throw new OutOfMemoryException("STATUS_WOW_ASSERTION: " + ComposeString());
                case STATUS_ACCESS_DENIED: throw new AccessViolationException("STATUS_ACCESS_DENIED: " + ComposeString());

                default: throw new ApplicationException("Unknown error code (" + InErrorCode + "): " + ComposeString());
            }
        }

        public static Int32 RtlGetLastError()
        {
            if (Is64Bit) return NativeAPI_x64.RtlGetLastError();
            else return NativeAPI_x86.RtlGetLastError();
        }

        public static String RtlGetLastErrorString()
        {
            if (Is64Bit) return NativeAPI_x64.RtlGetLastErrorStringCopy();
            else return NativeAPI_x86.RtlGetLastErrorStringCopy();
        }

        public static void LhInstallHook(
            IntPtr InEntryPoint,
            IntPtr InHookProc,
            IntPtr InCallback,
            IntPtr OutHandle)
        {
            if (Is64Bit) Force(NativeAPI_x64.LhInstallHook(InEntryPoint, InHookProc, InCallback, OutHandle));
            else Force(NativeAPI_x86.LhInstallHook(InEntryPoint, InHookProc, InCallback, OutHandle));
        }

        public static void LhUninstallHook(IntPtr RefHandle)
        {
            if (Is64Bit) Force(NativeAPI_x64.LhUninstallHook(RefHandle));
            else Force(NativeAPI_x86.LhUninstallHook(RefHandle));
        }

        public static void LhWaitForPendingRemovals()
        {
            if (Is64Bit) Force(NativeAPI_x64.LhWaitForPendingRemovals());
            else Force(NativeAPI_x86.LhWaitForPendingRemovals());
        }

        public static void LhIsThreadIntercepted(
                    IntPtr InHandle,
                    Int32 InThreadID,
                    out Boolean OutResult)
        {
            if (Is64Bit) Force(NativeAPI_x64.LhIsThreadIntercepted(InHandle, InThreadID, out OutResult));
            else Force(NativeAPI_x86.LhIsThreadIntercepted(InHandle, InThreadID, out OutResult));
        }

        public static void LhSetInclusiveACL(
                    Int32[] InThreadIdList,
                    Int32 InThreadCount,
                    IntPtr InHandle)
        {
            if (Is64Bit) Force(NativeAPI_x64.LhSetInclusiveACL(InThreadIdList, InThreadCount, InHandle));
            else Force(NativeAPI_x86.LhSetInclusiveACL(InThreadIdList, InThreadCount, InHandle));
        }

        public static void LhSetExclusiveACL(
                    Int32[] InThreadIdList,
                    Int32 InThreadCount,
                    IntPtr InHandle)
        {
            if (Is64Bit) Force(NativeAPI_x64.LhSetExclusiveACL(InThreadIdList, InThreadCount, InHandle));
            else Force(NativeAPI_x86.LhSetExclusiveACL(InThreadIdList, InThreadCount, InHandle));
        }

        public static void LhSetGlobalInclusiveACL(
                    Int32[] InThreadIdList,
                    Int32 InThreadCount)
        {
            if (Is64Bit) Force(NativeAPI_x64.LhSetGlobalInclusiveACL(InThreadIdList, InThreadCount));
            else Force(NativeAPI_x86.LhSetGlobalInclusiveACL(InThreadIdList, InThreadCount));
        }

        public static void LhSetGlobalExclusiveACL(
                    Int32[] InThreadIdList,
                    Int32 InThreadCount)
        {
            if (Is64Bit) Force(NativeAPI_x64.LhSetGlobalExclusiveACL(InThreadIdList, InThreadCount));
            else Force(NativeAPI_x86.LhSetGlobalExclusiveACL(InThreadIdList, InThreadCount));
        }

        public static void LhGetHookBypassAddress(IntPtr handle, out IntPtr address)
        {
            if (Is64Bit) Force(NativeAPI_x64.LhGetHookBypassAddress(handle, out address));
            else Force(NativeAPI_x86.LhGetHookBypassAddress(handle, out address));
        }
    }
}
