using Demo.Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Core.Services
{
    public class EnquiryService : IEnquiryService
    {
        private readonly ICarDbContext _carDbContext;

        public EnquiryService(ICarDbContext carDbContext)
        {
            _carDbContext = carDbContext;
        }
        public void Save(Enquiry enquiry)
        {
            _carDbContext.Enquiries.Add(enquiry);
        }
    }
}
