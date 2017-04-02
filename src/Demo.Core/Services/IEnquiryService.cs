using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Core.Services
{
    public interface IEnquiryService
    {
        void Save(Enquiry enquiry);
    }
}
