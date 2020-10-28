using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web;
 

namespace MvcApplication1
{
    public class CustomMediaTypeformatter:JsonMediaTypeFormatter
    {
        public CustomMediaTypeformatter()
        {
                this.SupportedMediaTypes.Add(new MediaTypeWithQualityHeaderValue("text/html"));
        }

        public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
        {
            base.SetDefaultContentHeaders(type, headers, mediaType);
            headers.ContentType=new MediaTypeHeaderValue("application/json");
        }
    }
}