namespace DataStore.Exceptions;

using System;

public class BlabException : SystemException
{
	public BlabException(string message) : base(message) { }
	public BlabException(string message, Exception inner) : base(message, inner) { }
}

public class BlabAdapterNotFoundException : Exception
{
	public BlabAdapterNotFoundException(string message) : base(message) { }
	public BlabAdapterNotFoundException(string message, Exception inner) : base(message, inner) { }
}