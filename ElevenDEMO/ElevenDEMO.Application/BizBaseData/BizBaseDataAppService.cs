using Abp.Application.Services;
using AutoMapper;
using ElevenDEMO.BizBaseData.Dtos;
using ElevenDEMO.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenDEMO.BizBaseData
{
    public class BizBaseDataAppService : ApplicationService,IBizBaseDataAppService
    {
        private readonly ITblVendorRepository _vendorRepository;
        public BizBaseDataAppService(ITblVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        Dtos.GetVendorsOutput IBizBaseDataAppService.GetVendors()
        {
            var query = _vendorRepository.GetAll().ToList();
            //_vendorRepository.GetAllList();
            return new GetVendorsOutput
            {
                Vendors = Mapper.Map<List<VendorDto>>(query)
            };
            //return new GetVendorsOutput() {
            //    Vendors = Mapper.Map<List<VendorDto>>(query)
            //};
        }

        Dtos.VendorDto IBizBaseDataAppService.GetVendor(Dtos.GetVendorInput input)
        {
            throw new NotImplementedException();
        }
    }
}
