using Abp.Application.Services.Dto;
using AutoMapper;
using Castle.Windsor;
using ElevenDEMO.BizBaseData;
using ElevenDEMO.BizBaseData.Dtos;
using ElevenDEMO.Vendor;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ElevenDEMO.Web.Controllers
{
    public class HomeController : ElevenDEMOControllerBase
    {
        IBizBaseDataAppService _bizBaseDataAppService;
        public HomeController(IBizBaseDataAppService bizBaseDataAppService)
        {
            _bizBaseDataAppService = bizBaseDataAppService;
        }
        public class TblVendor1 : Abp.Domain.Entities.Entity//<string>
        {
            
            public virtual string VendorCode { get; set; }

            public virtual string Vendor { get; set; }

            public virtual string Address { get; set; }
        }

        #region _del
        //[Abp.AutoMapper.AutoMapFrom(typeof(TblVendor1))]
        //public class VendorDto1 : EntityDto
        //{

        //    public string VendorCode { get; set; }

        //    public string Vendor { get; set; }

        //    public string Address { get; set; }
        //}
        #endregion
        public ActionResult Index()
        {

            //List<TblVendor1> t1 = new List<TblVendor1>();
            //t1.Add(new TblVendor1() { 
            //    Address = "address"
            //});
            //List<VendorDto1> t2 = Mapper.Map<List<VendorDto1>>(t1);


            //List<TblVendor> query = new List<TblVendor>();
            //query.Add(new TblVendor() { 
            //    Address = "address",
            //    Vendor = "Vendor"
            //});
            //VendorDto d = new VendorDto() { 
                
            //};

            //var a = new GetVendorsOutput
            //{
            //    Vendors = Mapper.Map<List<VendorDto>>(query)
            //};

            //return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
            return View(); //Layout of the angular application.
        }
       

        [HttpGet]
        public ActionResult Login(int? id,string name)
        {
            var container = new WindsorContainer();
            var vendors = _bizBaseDataAppService.GetVendors();

            ViewData["Name"] = "name=" + name  + " id=" + id;
            objA o = new objA()
            {
                A = "atext",
                B = "btext"
            };
            ViewData["vendors"] = vendors;
            ViewData["Obj"] = o;
            return View(o);
        }

        [HttpPost]
        public ActionResult Login(int? id)
        {
            return View();
        }
        public class objA
        {
            public string A { get; set; }
            public string B { get; set; }
        }
	}
}