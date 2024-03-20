using System.Net;
using Microsoft.AspNetCore.Mvc;
using SolarLabCourseTask.AppServices.Users.Services.Interfaces;
using SolarLabCourseTask.Contracts.Ads;

namespace SolarLabCourseTask.API.Controllers
{
    [ApiController]
    [Route("/ads")]
    public class AdsController : ControllerBase
    {
        private readonly int _adService;

        // /// <summary>
        // /// Инициализирует экземпляр <see cref="AdsController"/>
        // /// </summary>
        // /// <param name="adService">Сервис работы с объявлением.</param>
        // public UserController(IAdService adService)
        // {
        //     _adService = adService;
        // }

        /// <summary>
        /// Возвращает список объявлений.
        /// </summary>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Список объявлений.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<AdDTO>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAds(CancellationToken cancellationToken)
        {
            return Ok();
        }
        
        /// <summary>
        /// Возвращает объявление.
        /// </summary>
        /// <param name="id">Идентификатор объявления.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Объявление.</returns>
        [HttpGet]
        [Route("/ads/{id}")]
        [ProducesResponseType(typeof(AdDTO), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAd(string id, CancellationToken cancellationToken)
        {
            return Ok();
        }

        /// <summary>
        /// Удаляет объявление.
        /// </summary>
        /// <param name="id">Идентификатор объявления.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>объявление.</returns>
        [HttpDelete]
        [Route("/ads/{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> DeleteAd(string id, CancellationToken cancellationToken)
        {
            return NoContent();
        }
        
        /// <summary>
        /// Создает объявление.
        /// </summary>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateAd(CancellationToken cancellationToken)
        {
            return Created();
        }

        /// <summary>
        /// Обновляет данные объявления.
        /// </summary>
        /// <param name="id">Идентификатор объявления.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        [HttpPut]
        [Route("/ads/{id}")]
        [ProducesResponseType(typeof(AdDTO), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> UpdateAd(string id, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
