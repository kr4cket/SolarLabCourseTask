using System.Net;
using Microsoft.AspNetCore.Mvc;
using SolarLabCourseTask.AppServices.Users.Services.Interfaces;
using SolarLabCourseTask.Contracts.Users;

namespace SolarLabCourseTask.API.Controllers
{
    [ApiController]
    [Route("/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        /// <summary>
        /// Инициализирует экземпляр <see cref="UserController"/>
        /// </summary>
        /// <param name="userService">Сервис работы с пользователями.</param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Возвращает список пользователей.
        /// </summary>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Список пользователей.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<UserDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAllUsers(CancellationToken cancellationToken)
        {
            var result = await _userService.GetUsersAsync(cancellationToken);

            return Ok(result);
        }
        
        /// <summary>
        /// Возвращает пользователя.
        /// </summary>
        /// <param name="id">Идентификатор пользователя.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Пользователь.</returns>
        [HttpGet]
        [Route("/users/{id}")]
        [ProducesResponseType(typeof(UserDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetUser(string id, CancellationToken cancellationToken)
        {
            return Ok();
        }

        /// <summary>
        /// Удаляет пользователя.
        /// </summary>
        /// <param name="id">Идентификатор пользователя.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Пользователь.</returns>
        [HttpDelete]
        [Route("/users/{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> DeleteUser(string id, CancellationToken cancellationToken)
        {
            return NoContent();
        }
        
        /// <summary>
        /// Создает пользователя.
        /// </summary>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateUser(CancellationToken cancellationToken)
        {
            return Created();
        }

        /// <summary>
        /// Обновляет данные пользоватея.
        /// </summary>
        /// <param name="id">Идентификатор пользователя.</param>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        [HttpPut]
        [Route("/users/{id}")]
        [ProducesResponseType(typeof(UserDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> UpdateUser(string id, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
