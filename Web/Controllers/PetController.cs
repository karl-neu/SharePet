using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("api/pet")]
    [ApiController]
    public class PetController : ControllerBase
    {
		private ILoggerManager _logger;
		private IRepositoryWrapper _repository;
		private IMapper _mapper;

		public PetController(ILoggerManager logger,
			IRepositoryWrapper repository, IMapper mapper)
		{
			_logger = logger;
			_repository = repository;
			_mapper = mapper;
		}

        //[HttpGet]
        //public IActionResult GetPetsForOwner(Guid ownerId, [FromQuery] PetParameters parameters)
        //{
        //    var pets = _repository.Pet.GetPetsByOwner(ownerId, parameters);

        //    var metadata = new
        //    {
        //        pets.TotalCount,
        //        pets.PageSize,
        //        pets.CurrentPage,
        //        pets.TotalPages,
        //        pets.HasNext,
        //        pets.HasPrevious
        //    };

        //    Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

        //    _logger.LogInfo($"Returned {pets.TotalCount} owners from database.");

        //    return Ok(pets);
        //}

        [HttpGet]
		public IActionResult GetAllPets()
		{
			try
			{
				var pets = _repository.Pet.GetPets();
				_logger.LogInfo($"Returned all pets from database.");

				var petsResult = _mapper.Map<IEnumerable<PetDto>>(pets);
				return Ok(petsResult);
			}
			catch (Exception ex)
			{
				_logger.LogError($"Something went wrong inside GetAllPets action: {ex.Message}");
				return StatusCode(500, "Internal server error");
			}
		}
	}
}
