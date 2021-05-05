using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Application.Exceptions
{
	class ValidationException : Exception
	{

		public ValidationException(string Message) : base(Message)
		{

		}

		public ValidationException() : this("Dogrulama Hatasi")
		{
		}
		public ValidationException(Exception ex) : this(ex.Message)
		{

		}
	}
}
