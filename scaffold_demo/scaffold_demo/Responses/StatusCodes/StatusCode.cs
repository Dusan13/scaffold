using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scaffold_demo.Responses.StatusCodes
{
    public abstract class StatusCode
    {
        public StatusCode(int code, string message)
        {
            Code = code;
            Message = message;
        }

        public virtual bool IsError()
        {
            return Code > 0;
        }

        public virtual object GetStatusDescription()
        {
            return new
            {
                Message,
                Code
            };
        }

        public int Code { get; private set; }

        public string Message { get; private set; }
    }
}

