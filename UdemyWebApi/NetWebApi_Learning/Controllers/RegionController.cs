using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetWebApi_Learning.Model.DTO;
using NetWebApi_Learning.Repository.IRepository;

namespace NetWebApi_Learning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public RegionController(IRegionRepository regionRepository,IMapper mapper)
        {
            this._regionRepository = regionRepository;
            this._mapper = mapper; 
        }
        [HttpGet("GetAll")]
        
        public   async Task< IActionResult> GetAllregion()
        {
            var result =  await this._regionRepository.GetAll();
            var RegionDto = _mapper.Map<List<RegionDto>>(result);
            return Ok(RegionDto);
        }
    }
}
