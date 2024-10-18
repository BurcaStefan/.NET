using MediatR;

namespace Application.Use_Cases.Commands
{
    public class DeleteBookByIdCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
