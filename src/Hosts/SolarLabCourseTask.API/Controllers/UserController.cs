using System.Net;
using Microsoft.AspNetCore.Mvc;
using SolarLabCourseTask.AppServices.Users.Services.Interfaces;
using SolarLabCourseTask.Contracts.Users;

namespace SolarLabCourseTask.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        [Route("all")]
        [ProducesResponseType(typeof(IEnumerable<UserDTO>), (int)HttpStatusCode.OK)]
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
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Пользователь.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(UserDTO), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetUser(CancellationToken cancellationToken)
        {
            return Ok();
        }
        
        /// <summary>
        /// Удаляет пользователя.
        /// </summary>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        /// <returns>Пользователь.</returns>
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> DeleteUser(CancellationToken cancellationToken)
        {
            return Ok();
        }
        
        /// <summary>
        /// Создает пользователя.
        /// </summary>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateUser(CancellationToken cancellationToken)
        {
            return Ok();
        }
        
        /// <summary>
        /// Обновляет данные пользоватея.
        /// </summary>
        /// <param name="cancellationToken">Токен отмены операции.</param>
        [HttpPut]
        [ProducesResponseType(typeof(UserDTO), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> UpdateUser(CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
