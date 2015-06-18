using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenDEMO.BizBaseData.Dtos
{
    public class GetVendorsOutput : IOutputDto
    {
        public List<VendorDto> Vendors { get; set; }
    }
}
