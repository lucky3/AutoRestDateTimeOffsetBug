using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;

namespace ConsoleApplication1
{
    public partial interface IValues
    {
        Task<HttpOperationResponse<string>> MyPostRawDateWithOperationResponseAsync(DateTimeOffset dateTimeOffset, CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}
