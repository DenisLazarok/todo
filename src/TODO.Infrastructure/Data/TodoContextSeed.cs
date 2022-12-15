using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TODO.Domain.Entities.CommentAggregate;
using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Infrastructure.Data;

public class TodoContextSeed
{
    public static async Task SeedAsync(TodoContext todoContext,
        ILogger logger,
        int retry = 0)
    {
        var retryForAvailability = retry;
        try
        {
            if (todoContext.Database.IsNpgsql())
            {
                await todoContext.Database.MigrateAsync();
            }

            if (!await todoContext.Todos.AnyAsync())
            {
                var comment1 = new Comment( "Today");
                var comment2 = new Comment("At 10 o`clock");
                var todo1 = new Todo("Calculate employees salary", CategoryType.Bookkeeping, "red", new List<Comment>(){comment1, comment2});
                var todo2 = new Todo("Analyse project", CategoryType.Analytics, "blue");
                await todoContext.Comments.AddRangeAsync(comment1, comment2);
                await todoContext.Todos.AddRangeAsync(todo1, todo2);

                await todoContext.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            if (retryForAvailability >= 3) throw;

            retryForAvailability++;

            logger.LogError(ex.Message);
            await SeedAsync(todoContext, logger, retryForAvailability);
            throw;
        }
    }
}
