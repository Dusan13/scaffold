using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scaffold_demo.Responses.StatusCodes
{
    public sealed class EmployeeStatusCode : StatusCode
    {
        public static readonly StatusCode SUCCESS = new EmployeeStatusCode(0, "success");
        public static readonly StatusCode USER_ALREADY_EXISTS = new EmployeeStatusCode(3000, "user already exists");

        private EmployeeStatusCode(int code, string message) : base(code, message) { }
    }
}
