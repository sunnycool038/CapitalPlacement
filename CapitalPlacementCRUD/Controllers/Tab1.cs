using AutoMapper;
using CapitalPlacementConsole.Models;
using CapitalPlacementCRUD.Domain.Interface;
using CapitalPlacementCRUD.Domain.Models;
using CapitalPlacementCRUD.Domain.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacementCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tab1 : ControllerBase
    {
        private readonly ITab1Service _tab1Service;
        IMapper _mapper;
        public Tab1(ITab1Service tab1Service, IMapper mapper)
        {
            _mapper = mapper;
            _tab1Service = tab1Service;
        }

        [HttpPost]
        [Route("Create-Program-Details")]
        public async Task<IActionResult> CreateProgramDetails([FromBody] ProgramDetails program)
        {
            var map = _mapper.Map<ProgramDetailsDB>(program);
            map.id = "3242432424";
            var res = await _tab1Service.InsertDetails(map);
            if(res == true)
            {
                return Ok(new InsertDetailsResponse { message = "Details Created Successfully", StatusCode = 200 });
            }
            return BadRequest(new InsertDetailsResponse { message = "Details Creation Failed", StatusCode = 400 });
        }

    }
}
