using AutoMapper;
using MediatR;
using TODO.Application.Commands.AddTodo;
using TODO.Application.Common.Exceptions;
using TODO.Domain.Entities.CommentAggregate;
using TODO.Domain.Entities.TodoAggregate;
using TODO.Domain.Interfaces;

namespace TODO.Application.Commands.AddComment;

public class AddCommentCommandHandler : IRequestHandler<AddCommentCommand, Guid>
{
    private readonly IRepository<Comment> _commentRepository;
    private readonly IRepository<Todo> _todoRepository;
    private readonly IMapper _mapper;

    public AddCommentCommandHandler(IRepository<Comment> commentRepository, IMapper mapper,
        IRepository<Todo> todoRepository)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;
        _todoRepository = todoRepository;
    }

    public async Task<Guid> Handle(AddCommentCommand request, CancellationToken cancellationToken)
    {
        var comment = _mapper.Map<Comment>(request);
        var todo = await _todoRepository.GetByIdAsync(request.TodoId, cancellationToken);

        if (todo is null)
            throw new NotFoundException(nameof(Todo), request.TodoId);

        await _commentRepository.AddAsync(comment, cancellationToken);

        return comment.Id;
    }
}
