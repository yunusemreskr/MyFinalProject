using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult<T> : DataResult<T>
    {
        public ErrorResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorResult(T data) : base(data, false)
        {

        }

        public ErrorResult(string message) : base(default, false, message)
        {

        }

        public ErrorResult() : base(default, false)
        {

        }
    }
}
