namespace DataStore.Exceptions;

using System;

public class UserException : SystemException
{
	public UserException(string message) : base(message) { }
}
public class UserAdapterNotFoundException : Exception
{
	public UserAdapterNotFoundException(string message) : base(message) { }
}
public class UserAdapterDuplicateException : Exception
{
	public UserAdapterDuplicateException(string message) : base(message) { }
}