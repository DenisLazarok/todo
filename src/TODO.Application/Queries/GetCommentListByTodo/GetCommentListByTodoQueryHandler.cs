using AutoMapper;
using MediatR;
using TODO.Application.Common.Exceptions;
using TODO.Application.Models;
using TODO.Application.Queries.GetTodoList;
using TODO.Domain.Entities.CommentAggregate;
using TODO.Domain.Entities.TodoAggregate;
using TODO.Domain.Interfaces;
using TODO.Domain.Specifications;

namespace TODO.Application.Queries.GetCommentListByTodo;

public class GetCommentListByTodoQueryHandler : IRequestHandler<GetCommentListByTodoQuery, List<CommentVm>>
{
    private readonly IReadRepository<Comment> _commentRepository;
    private readonly IMapper _mapper;

    public GetCommentListByTodoQueryHandler(IReadRepository<Comment> commentRepository, IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;
    }

    public async Task<List<CommentVm>> Handle(GetCommentListByTodoQuery request, CancellationToken cancellationToken)
    {
        var specification = new CommentGetByTodoSpecification(request.Id);
        var comments = await _commentRepository.ListAsync(specification, cancellationToken);
        
        
        return _mapper.Map<List<CommentVm>>(comments);
    }
}
