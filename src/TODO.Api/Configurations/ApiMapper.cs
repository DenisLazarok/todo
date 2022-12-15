using AutoMapper;
using TODO.Api.Contracts;
using TODO.Application.Commands.AddTodo;
using TODO.Application.Queries.GetTodoList;

namespace TODO.Api.Configurations;

public class ApiMapperProfile : Profile
{
    public ApiMapperProfile()
    {
        CreateMap<GetTodoFilterDto, GetTodoListQuery>();
        CreateMap<AddTodoDto, AddTodoCommand>();
    }
}
