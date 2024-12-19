using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Business.Abstract;
using SignalR.DTO.Dtos.FeatureDto;
using SignalR.Entity.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService FeatureService, IMapper mapper)
        {
            _featureService = FeatureService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            _featureService.TAdd(new Feature()
            {
                Title1 = createFeatureDto.Title1,
                Title3 = createFeatureDto.Title3,
                Description1 = createFeatureDto.Description1,
                TitleD2 = createFeatureDto.TitleD2,
                Description2 = createFeatureDto.Description2,
                Description3 = createFeatureDto.Description3
            });
            return Ok("İletişim Bilgileri eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetById(id);
            _featureService.TDelete(value);
            return Ok("İletişim Bilgileri silindi");
        }

        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            _featureService.TUpdate(new Feature()
            {
                FeatureID = updateFeatureDto.FeatureID,
                Title1 = updateFeatureDto.Title1,
                Title3 = updateFeatureDto.Title3,
                Description1 = updateFeatureDto.Description1,
                TitleD2 = updateFeatureDto.TitleD2,
                Description2 = updateFeatureDto.Description2,
                Description3 = updateFeatureDto.Description3
            });

            return Ok("Feature güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetById(id);
            return Ok(value);
        }
    }
}
