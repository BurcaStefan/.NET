using Application.DTOs;
using Application.Use_Cases.Queries;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Use_Cases.QueryHandlers
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookDto>
    {
        private readonly IBookRepository reporitory;
        private readonly IMapper mapper;

        public GetBookByIdQueryHandler(IBookRepository reporitory, IMapper mapper)
        {
            this.reporitory = reporitory;
            this.mapper = mapper;
        }
        public async Task<BookDto> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await reporitory.GetByIdAsync(request.Id);
            //add maper
            //return new BookDto
            //{
            //    Id = book.Id,
            //    Title = book.Title,
            //    Author = book.Author,
            //    ISBN = book.ISBN,
            //    PublicationDate = book.PublicationDate,
            //};
            return  mapper.Map<BookDto>(book);
        }

    }
}
