using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;

namespace _01_colorConsoleWrite
{
	/// <summary>
	///     Represents the standard input, output, and error streams for console applications. This class cannot be
	///     inherited.To browse the .NET Framework source code for this type, see the Reference Source.
	/// </summary>
	/// <filterpriority>1</filterpriority>
	public static class Console
	{
		private static volatile bool _isOutTextWriterRedirected = false;
		private static volatile bool _isErrorTextWriterRedirected = false;
		private static volatile Encoding _inputEncoding = null;
		private static volatile Encoding _outputEncoding = null;
		private static volatile bool _stdInRedirectQueried = false;
		private static volatile bool _stdOutRedirectQueried = false;
		private static volatile bool _stdErrRedirectQueried = false;
		private static volatile TextReader _in;
		private static volatile TextWriter _out;
		private static volatile TextWriter _error;
		private static volatile ConsoleCancelEventHandler _cancelCallbacks;
		private static volatile bool _haveReadDefaultColors;
		private static volatile byte _defaultColors;
		private static bool _isStdInRedirected;
		private static bool _isStdOutRedirected;
		private static bool _isStdErrRedirected;
		private static volatile object s_InternalSyncObject;
		private static volatile object s_ReadKeySyncObject;
		private static volatile IntPtr _consoleInputHandle;
		private static volatile IntPtr _consoleOutputHandle;


		/// <summary>Reads the next character from the standard input stream.</summary>
		/// <returns>
		///     The next character from the input stream, or negative one (-1) if there are currently no more characters to be
		///     read.
		/// </returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static int Read()
		{
			return System.Console.In.Read();
		}

		/// <summary>Reads the next line of characters from the standard input stream.</summary>
		/// <returns>The next line of characters from the input stream, or null if no more lines are available.</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <exception cref="T:System.OutOfMemoryException">
		///     There is insufficient memory to allocate a buffer for the returned
		///     string.
		/// </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///     The number of characters in the next line of characters is
		///     greater than <see cref="F:System.Int32.MaxValue" />.
		/// </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static string ReadLine()
		{
			return System.Console.In.ReadLine();
		}

		/// <summary>Writes the current line terminator to the standard output stream.</summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine()
		{
			System.Console.Out.WriteLine();
		}

		/// <summary>
		///     Writes the text representation of the specified Boolean value, followed by the current line terminator, to the
		///     standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(bool value)
		{
			System.Console.Out.WriteLine(value);
		}

		/// <summary>
		///     Writes the specified Unicode character, followed by the current line terminator, value to the standard output
		///     stream.
		/// </summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(char value)
		{
			System.Console.Out.WriteLine(value);
		}

		/// <summary>
		///     Writes the specified array of Unicode characters, followed by the current line terminator, to the standard
		///     output stream.
		/// </summary>
		/// <param name="buffer">A Unicode character array. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(char[] buffer)
		{
			System.Console.Out.WriteLine(buffer);
		}

		/// <summary>
		///     Writes the specified subarray of Unicode characters, followed by the current line terminator, to the standard
		///     output stream.
		/// </summary>
		/// <param name="buffer">An array of Unicode characters. </param>
		/// <param name="index">The starting position in <paramref name="buffer" />. </param>
		/// <param name="count">The number of characters to write. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///     <paramref name="buffer" /> is null.
		/// </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///     <paramref name="index" /> or <paramref name="count" /> is less than zero.
		/// </exception>
		/// <exception cref="T:System.ArgumentException">
		///     <paramref name="index" /> plus <paramref name="count" /> specify a position that is not within
		///     <paramref name="buffer" />.
		/// </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(char[] buffer, int index, int count)
		{
			System.Console.Out.WriteLine(buffer, index, count);
		}

		/// <summary>
		///     Writes the text representation of the specified <see cref="T:System.Decimal" /> value, followed by the current
		///     line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(decimal value)
		{
			System.Console.Out.WriteLine(value);
		}

		/// <summary>
		///     Writes the text representation of the specified double-precision floating-point value, followed by the current
		///     line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(double value)
		{
			System.Console.Out.WriteLine(value);
		}

		/// <summary>
		///     Writes the text representation of the specified single-precision floating-point value, followed by the current
		///     line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(float value)
		{
			System.Console.Out.WriteLine(value);
		}

		/// <summary>
		///     Writes the text representation of the specified 32-bit signed integer value, followed by the current line
		///     terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(int value)
		{
			System.Console.Out.WriteLine(value);
		}

		/// <summary>
		///     Writes the text representation of the specified 32-bit unsigned integer value, followed by the current line
		///     terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(uint value)
		{
			System.Console.Out.WriteLine(value);
		}

		/// <summary>
		///     Writes the text representation of the specified 64-bit signed integer value, followed by the current line
		///     terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(long value)
		{
			System.Console.Out.WriteLine(value);
		}

		/// <summary>
		///     Writes the text representation of the specified 64-bit unsigned integer value, followed by the current line
		///     terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(ulong value)
		{
			System.Console.Out.WriteLine(value);
		}

		/// <summary>
		///     Writes the text representation of the specified object, followed by the current line terminator, to the
		///     standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(object value)
		{
			System.Console.Out.WriteLine(value);
		}

		/// <summary>Writes the specified string value, followed by the current line terminator, to the standard output stream.</summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(string value)
		{
			var color = System.Console.ForegroundColor;
			for (int i = 0; i < value.Length; i++)
			{
				System.Console.ForegroundColor = (ConsoleColor) (i%15+1);
				System.Console.Out.Write(value[i]);

			}
			System.Console.ForegroundColor = color;
		}

		/// <summary>
		///     Writes the text representation of the specified object, followed by the current line terminator, to the
		///     standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param>
		/// <param name="arg0">An object to write using <paramref name="format" />. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///     <paramref name="format" /> is null.
		/// </exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(string format, object arg0)
		{
			System.Console.Out.WriteLine(format, arg0);
		}

		/// <summary>
		///     Writes the text representation of the specified objects, followed by the current line terminator, to the
		///     standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param>
		/// <param name="arg0">The first object to write using <paramref name="format" />. </param>
		/// <param name="arg1">The second object to write using <paramref name="format" />. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///     <paramref name="format" /> is null.
		/// </exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(string format, object arg0, object arg1)
		{
			System.Console.Out.WriteLine(format, arg0, arg1);
		}

		/// <summary>
		///     Writes the text representation of the specified objects, followed by the current line terminator, to the
		///     standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param>
		/// <param name="arg0">The first object to write using <paramref name="format" />. </param>
		/// <param name="arg1">The second object to write using <paramref name="format" />. </param>
		/// <param name="arg2">The third object to write using <paramref name="format" />. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///     <paramref name="format" /> is null.
		/// </exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(string format, object arg0, object arg1, object arg2)
		{
			System.Console.Out.WriteLine(format, arg0, arg1, arg2);
		}

		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(string format, object arg0, object arg1, object arg2, object arg3, __arglist)
		{
			var argIterator = new ArgIterator(__arglist);
			var length = argIterator.GetRemainingCount() + 4;
			var objArray = new object[length];
			objArray[0] = arg0;
			objArray[1] = arg1;
			objArray[2] = arg2;
			objArray[3] = arg3;
			for (var index = 4; index < length; ++index)
				objArray[index] = TypedReference.ToObject(argIterator.GetNextArg());
			System.Console.Out.WriteLine(format, objArray);
		}

		/// <summary>
		///     Writes the text representation of the specified array of objects, followed by the current line terminator, to
		///     the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param>
		/// <param name="arg">An array of objects to write using <paramref name="format" />. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///     <paramref name="format" /> or <paramref name="arg" /> is null.
		/// </exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void WriteLine(string format, params object[] arg)
		{
			if (arg == null)
				System.Console.Out.WriteLine(format, null, null);
			else
				System.Console.Out.WriteLine(format, arg);
		}

		/// <summary>
		///     Writes the text representation of the specified object to the standard output stream using the specified
		///     format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks). </param>
		/// <param name="arg0">An object to write using <paramref name="format" />. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///     <paramref name="format" /> is null.
		/// </exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(string format, object arg0)
		{
			System.Console.Out.Write(format, arg0);
		}

		/// <summary>
		///     Writes the text representation of the specified objects to the standard output stream using the specified
		///     format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param>
		/// <param name="arg0">The first object to write using <paramref name="format" />. </param>
		/// <param name="arg1">The second object to write using <paramref name="format" />. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///     <paramref name="format" /> is null.
		/// </exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(string format, object arg0, object arg1)
		{
			System.Console.Out.Write(format, arg0, arg1);
		}

		/// <summary>
		///     Writes the text representation of the specified objects to the standard output stream using the specified
		///     format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param>
		/// <param name="arg0">The first object to write using <paramref name="format" />. </param>
		/// <param name="arg1">The second object to write using <paramref name="format" />. </param>
		/// <param name="arg2">The third object to write using <paramref name="format" />. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///     <paramref name="format" /> is null.
		/// </exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(string format, object arg0, object arg1, object arg2)
		{
			System.Console.Out.Write(format, arg0, arg1, arg2);
		}

		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(string format, object arg0, object arg1, object arg2, object arg3, __arglist)
		{
			var argIterator = new ArgIterator(__arglist);
			var length = argIterator.GetRemainingCount() + 4;
			var objArray = new object[length];
			objArray[0] = arg0;
			objArray[1] = arg1;
			objArray[2] = arg2;
			objArray[3] = arg3;
			for (var index = 4; index < length; ++index)
				objArray[index] = TypedReference.ToObject(argIterator.GetNextArg());
			System.Console.Out.Write(format, objArray);
		}

		/// <summary>
		///     Writes the text representation of the specified array of objects to the standard output stream using the
		///     specified format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param>
		/// <param name="arg">An array of objects to write using <paramref name="format" />. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///     <paramref name="format" /> or <paramref name="arg" /> is null.
		/// </exception>
		/// <exception cref="T:System.FormatException">The format specification in <paramref name="format" /> is invalid. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(string format, params object[] arg)
		{
			if (arg == null)
				System.Console.Out.Write(format, null, null);
			else
				System.Console.Out.Write(format, arg);
		}

		/// <summary>Writes the text representation of the specified Boolean value to the standard output stream.</summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(bool value)
		{
			System.Console.Out.Write(value);
		}

		/// <summary>Writes the specified Unicode character value to the standard output stream.</summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(char value)
		{
			System.Console.Out.Write(value);
		}

		/// <summary>Writes the specified array of Unicode characters to the standard output stream.</summary>
		/// <param name="buffer">A Unicode character array. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(char[] buffer)
		{
			System.Console.Out.Write(buffer);
		}

		/// <summary>Writes the specified subarray of Unicode characters to the standard output stream.</summary>
		/// <param name="buffer">An array of Unicode characters. </param>
		/// <param name="index">The starting position in <paramref name="buffer" />. </param>
		/// <param name="count">The number of characters to write. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///     <paramref name="buffer" /> is null.
		/// </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///     <paramref name="index" /> or <paramref name="count" /> is less than zero.
		/// </exception>
		/// <exception cref="T:System.ArgumentException">
		///     <paramref name="index" /> plus <paramref name="count" /> specify a position that is not within
		///     <paramref name="buffer" />.
		/// </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(char[] buffer, int index, int count)
		{
			System.Console.Out.Write(buffer, index, count);
		}

		/// <summary>
		///     Writes the text representation of the specified double-precision floating-point value to the standard output
		///     stream.
		/// </summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(double value)
		{
			System.Console.Out.Write(value);
		}

		/// <summary>
		///     Writes the text representation of the specified <see cref="T:System.Decimal" /> value to the standard output
		///     stream.
		/// </summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(decimal value)
		{
			System.Console.Out.Write(value);
		}

		/// <summary>
		///     Writes the text representation of the specified single-precision floating-point value to the standard output
		///     stream.
		/// </summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(float value)
		{
			System.Console.Out.Write(value);
		}

		/// <summary>Writes the text representation of the specified 32-bit signed integer value to the standard output stream.</summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(int value)
		{
			System.Console.Out.Write(value);
		}

		/// <summary>Writes the text representation of the specified 32-bit unsigned integer value to the standard output stream.</summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(uint value)
		{
			System.Console.Out.Write(value);
		}

		/// <summary>Writes the text representation of the specified 64-bit signed integer value to the standard output stream.</summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(long value)
		{
			System.Console.Out.Write(value);
		}

		/// <summary>Writes the text representation of the specified 64-bit unsigned integer value to the standard output stream.</summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(ulong value)
		{
			System.Console.Out.Write(value);
		}

		/// <summary>Writes the text representation of the specified object to the standard output stream.</summary>
		/// <param name="value">The value to write, or null. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(object value)
		{
			System.Console.Out.Write(value);
		}

		/// <summary>Writes the specified string value to the standard output stream.</summary>
		/// <param name="value">The value to write. </param>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(MethodImplOptions.NoInlining)]
		[HostProtection(SecurityAction.LinkDemand, UI = true)]
		public static void Write(string value)
		{
			System.Console.Out.Write(value);
		}

		[Flags]
		internal enum ControlKeyState
		{
			RightAltPressed = 1,
			LeftAltPressed = 2,
			RightCtrlPressed = 4,
			LeftCtrlPressed = 8,
			ShiftPressed = 16,
			NumLockOn = 32,
			ScrollLockOn = 64,
			CapsLockOn = 128,
			EnhancedKey = 256
		}
	}
}