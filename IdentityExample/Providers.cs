using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityExample
{
	public class Logger : ILogger
	{
		#region Implementation of ILogger

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
		{
			if (true/*state is DbCommandLogData*/)
			{
				Console.WriteLine(formatter(state, exception));
			}
		}

		public bool IsEnabled(LogLevel logLevel) => true;
		public IDisposable BeginScope<TState>(TState state) => null;

		#endregion
	}

	public class LoggerProvider : ILoggerProvider
	{
		#region Implementation of IDisposable

		public void Dispose()
		{
		}

		public ILogger CreateLogger(string categoryName) => new Logger();

		#endregion
	}
}
