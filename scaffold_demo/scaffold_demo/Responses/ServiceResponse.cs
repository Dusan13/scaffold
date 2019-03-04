using scaffold_demo.Responses.StatusCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scaffold_demo.Responses
{
    public class ServiceResponse<T>
    {
        #region Private members

        private readonly T _payload;

        private readonly object _additionalInformation;

        private readonly StatusCode _statusCode;

        #endregion

        public ServiceResponse(StatusCode statusCode, T payload = default(T), object additionalInformation = null)
        {
            _payload = payload;
            _statusCode = statusCode;
            _additionalInformation = additionalInformation;
        }

        #region Public methods

        public bool HasErrors()
        {
            return _statusCode.IsError();
        }

        public StatusCode GetStatusCode()
        {
            return _statusCode;
        }

        public object GetErrorDescription()
        {
            if (HasErrors())
            {
                return new
                {
                    status = _statusCode.GetStatusDescription(),
                    additionalInformation = _additionalInformation
                };
            }

            return String.Empty;
        }

        public T GetPayload()
        {
            return _payload;
        }

        public object GetAdditionalInformation()
        {
            return _additionalInformation;
        }

        public ServerPayloadResponse GetPayloadResponse()
        {
            return new ServerPayloadResponse
            {
                Status = _statusCode.GetStatusDescription(),
                Payload = _payload,
                AdditionalInformation = _additionalInformation
            };
        }

        #endregion
    }

    public class ServerPayloadResponse
    {
        public object Status { get; set; }

        public object Payload { get; set; }

        public object AdditionalInformation { get; set; }
    }
}

