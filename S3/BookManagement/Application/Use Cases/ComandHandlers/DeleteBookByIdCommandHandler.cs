using Application.Use_Cases.Commands;
using Domain.Repositories;
using MediatR;

namespace Application.Use_Cases.ComandHandlers
{
    public class DeleteBookByIdCommandHandler : IRequestHandler<DeleteBookByIdCommand, Guid>
    {
        private readonly IBookRepository repository;
        public DeleteBookByIdCommandHandler(IBookRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Guid> Handle(DeleteBookByIdCommand request, CancellationToken cancellationToken)
        {
            var book = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(request.Id);
            return request.Id;
        }
    }
}
