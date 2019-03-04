using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scaffold_demo.Responses.StatusCodes
{
    public sealed class GetEmployeeStatusCode : StatusCode
    {
        public static readonly StatusCode SUCCESS = new GetEmployeeStatusCode(0, "success");
        public static readonly StatusCode ID_DOESNT_EXISTS = new GetEmployeeStatusCode(3000, "id doesnt exists");

        private GetEmployeeStatusCode(int code, string message) : base(code, message) { }
    }
}
