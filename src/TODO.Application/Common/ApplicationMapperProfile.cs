using AutoMapper;
using TODO.Application.Commands.AddComment;
using TODO.Application.Commands.AddTodo;
using TODO.Application.Models;
using TODO.Application.Queries.GetTodoList;
using TODO.Domain.Entities.CommentAggregate;
using TODO.Domain.Entities.TodoAggregate;
using TODO.Domain.Extensions;

namespace TODO.Application.Common;

public class ApplicationMapperProfile : Profile
{
    public ApplicationMapperProfile()
    {
        CreateMap<Todo, TodoVm>()
            .ForMember(dest => dest.Hash, c => c.MapFrom(src => src.Header.ToMd5()));
        CreateMap<Comment, CommentVm>();
        CreateMap<AddTodoCommand, Todo>();
        CreateMap<AddCommentCommand, Comment>();
    }
}
