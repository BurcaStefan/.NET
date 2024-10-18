using Application.DTOs;
using Application.Use_Cases.Commands;
using Application.Use_Cases.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator mediator;

        public BooksController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateBook(CreateBookCommand command)
        {
            return await mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<BookDto>> GetBookById([FromQuery] GetBookByIdQuery query)
        {
            return await mediator.Send(query);
        }

        [HttpDelete]
        public async Task<ActionResult<Guid>> DeleteBook([FromQuery] DeleteBookByIdCommand command)
        {
            return await mediator.Send(command);
        }
    }
}
