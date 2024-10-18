using Application.DTOs;
using Application.Use_Cases.Queries;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Use_Cases.QueryHandlers
{
    public class GetAllBookQueryHandler : IRequestHandler<GetAllBookQuery, IEnumerable<BookDto>>
    {
        private readonly IBookRepository repository;
        private readonly IMapper mapper;

        public GetAllBookQueryHandler(IBookRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<BookDto>> Handle(GetAllBookQuery request, CancellationToken cancellationToken)
        {
            var books = await repository.GetAllAsync();
            return mapper.Map<IEnumerable<BookDto>>(books);
        }
    }
}
