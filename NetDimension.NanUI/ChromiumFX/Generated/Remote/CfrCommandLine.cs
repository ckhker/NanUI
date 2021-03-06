// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {

    /// <summary>
    /// Structure used to create and/or parse command line arguments. Arguments with
    /// '--', '-' and, on Windows, '/' prefixes are considered switches. Switches
    /// will always precede any arguments without switch prefixes. Switches can
    /// optionally have a value specified using the '=' delimiter (e.g.
    /// "-switch=value"). An argument of "--" will terminate switch parsing with all
    /// subsequent tokens, regardless of prefix, being interpreted as non-switch
    /// arguments. Switch names are considered case-insensitive. This structure can
    /// be used before cef_initialize() is called.
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
    /// </remarks>
    public class CfrCommandLine : CfrBaseLibrary {

        internal static CfrCommandLine Wrap(RemotePtr remotePtr) {
            if(remotePtr == RemotePtr.Zero) return null;
            var weakCache = CfxRemoteCallContext.CurrentContext.connection.weakCache;
            lock(weakCache) {
                var cfrObj = (CfrCommandLine)weakCache.Get(remotePtr.ptr);
                if(cfrObj == null) {
                    cfrObj = new CfrCommandLine(remotePtr);
                    weakCache.Add(remotePtr.ptr, cfrObj);
                }
                return cfrObj;
            }
        }


        /// <summary>
        /// Create a new CfrCommandLine instance.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public static CfrCommandLine Create() {
            var call = new CfxCommandLineCreateRemoteCall();
            call.RequestExecution();
            return CfrCommandLine.Wrap(new RemotePtr(call.__retval));
        }

        /// <summary>
        /// Returns the singleton global CfrCommandLine object. The returned object
        /// will be read-only.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public static CfrCommandLine GetGlobal() {
            var call = new CfxCommandLineGetGlobalRemoteCall();
            call.RequestExecution();
            return CfrCommandLine.Wrap(new RemotePtr(call.__retval));
        }


        private CfrCommandLine(RemotePtr remotePtr) : base(remotePtr) {}

        /// <summary>
        /// Returns true (1) if this object is valid. Do not call any other functions
        /// if this function returns false (0).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public bool IsValid {
            get {
                var call = new CfxCommandLineIsValidRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns true (1) if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public bool IsReadOnly {
            get {
                var call = new CfxCommandLineIsReadOnlyRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Constructs and returns the represented command line string. Use this
        /// function cautiously because quoting behavior is unclear.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public string CommandLineString {
            get {
                var call = new CfxCommandLineGetCommandLineStringRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Get the program part of the command line string (the first item).
        /// 
        /// Set the program part of the command line string (the first item).
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public string Program {
            get {
                var call = new CfxCommandLineGetProgramRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
            set {
                var call = new CfxCommandLineSetProgramRemoteCall();
                call.@this = RemotePtr.ptr;
                call.value = value;
                call.RequestExecution(RemotePtr.connection);
            }
        }

        /// <summary>
        /// Returns true (1) if the command line has switches.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public bool HasSwitches {
            get {
                var call = new CfxCommandLineHasSwitchesRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// True if there are remaining command line arguments.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public bool HasArguments {
            get {
                var call = new CfxCommandLineHasArgumentsRemoteCall();
                call.@this = RemotePtr.ptr;
                call.RequestExecution(RemotePtr.connection);
                return call.__retval;
            }
        }

        /// <summary>
        /// Returns a writable copy of this object.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public CfrCommandLine Copy() {
            var call = new CfxCommandLineCopyRemoteCall();
            call.@this = RemotePtr.ptr;
            call.RequestExecution(RemotePtr.connection);
            return CfrCommandLine.Wrap(new RemotePtr(call.__retval));
        }

        /// <summary>
        /// Initialize the command line with the specified |argc| and |argv| values.
        /// The first argument must be the name of the program. This function is only
        /// supported on non-Windows platforms.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void InitFromArgv(int argc, RemotePtr argv) {
            var call = new CfxCommandLineInitFromArgvRemoteCall();
            call.@this = RemotePtr.ptr;
            call.argc = argc;
            call.argv = argv.ptr;
            call.RequestExecution(RemotePtr.connection);
        }

        /// <summary>
        /// Initialize the command line with the string returned by calling
        /// GetCommandLineW(). This function is only supported on Windows.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void InitFromString(string commandLine) {
            var call = new CfxCommandLineInitFromStringRemoteCall();
            call.@this = RemotePtr.ptr;
            call.commandLine = commandLine;
            call.RequestExecution(RemotePtr.connection);
        }

        /// <summary>
        /// Reset the command-line switches and arguments but leave the program
        /// component unchanged.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void Reset() {
            var call = new CfxCommandLineResetRemoteCall();
            call.@this = RemotePtr.ptr;
            call.RequestExecution(RemotePtr.connection);
        }

        /// <summary>
        /// Retrieve the original command line string as a vector of strings. The argv
        /// array: { program, [(--|-|/)switch[=value]]*, [--], [argument]* }
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public System.Collections.Generic.List<string> GetArgv() {
            var call = new CfxCommandLineGetArgvRemoteCall();
            call.@this = RemotePtr.ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns true (1) if the command line contains the given switch.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public bool HasSwitch(string name) {
            var call = new CfxCommandLineHasSwitchRemoteCall();
            call.@this = RemotePtr.ptr;
            call.name = name;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the value associated with the given switch. If the switch has no
        /// value or isn't present this function returns the NULL string.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public string GetSwitchValue(string name) {
            var call = new CfxCommandLineGetSwitchValueRemoteCall();
            call.@this = RemotePtr.ptr;
            call.name = name;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Returns the map of switch names and values. If a switch has no value an
        /// NULL string is returned.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public System.Collections.Generic.List<string[]> GetSwitches() {
            var call = new CfxCommandLineGetSwitchesRemoteCall();
            call.@this = RemotePtr.ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Add a switch to the end of the command line. If the switch has no value
        /// pass an NULL value string.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void AppendSwitch(string name) {
            var call = new CfxCommandLineAppendSwitchRemoteCall();
            call.@this = RemotePtr.ptr;
            call.name = name;
            call.RequestExecution(RemotePtr.connection);
        }

        /// <summary>
        /// Add a switch with the specified value to the end of the command line.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void AppendSwitchWithValue(string name, string value) {
            var call = new CfxCommandLineAppendSwitchWithValueRemoteCall();
            call.@this = RemotePtr.ptr;
            call.name = name;
            call.value = value;
            call.RequestExecution(RemotePtr.connection);
        }

        /// <summary>
        /// Get the remaining command line arguments.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public System.Collections.Generic.List<string> GetArguments() {
            var call = new CfxCommandLineGetArgumentsRemoteCall();
            call.@this = RemotePtr.ptr;
            call.RequestExecution(RemotePtr.connection);
            return call.__retval;
        }

        /// <summary>
        /// Add an argument to the end of the command line.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void AppendArgument(string argument) {
            var call = new CfxCommandLineAppendArgumentRemoteCall();
            call.@this = RemotePtr.ptr;
            call.argument = argument;
            call.RequestExecution(RemotePtr.connection);
        }

        /// <summary>
        /// Insert a command before the current command. Common for debuggers, like
        /// "valgrind" or "gdb --args".
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_command_line_capi.h">cef/include/capi/cef_command_line_capi.h</see>.
        /// </remarks>
        public void PrependWrapper(string wrapper) {
            var call = new CfxCommandLinePrependWrapperRemoteCall();
            call.@this = RemotePtr.ptr;
            call.wrapper = wrapper;
            call.RequestExecution(RemotePtr.connection);
        }
    }
}
