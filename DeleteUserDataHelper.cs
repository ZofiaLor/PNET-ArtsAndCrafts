using ArtsAndCrafts.Data;
using Microsoft.EntityFrameworkCore;

namespace ArtsAndCrafts;

public static class DeleteUserDataHelper
{
    public static async Task DeleteUserData(ApplicationUser user, ApplicationDbContext context)
    {
        var patterns = await context.Patterns.Include(p => p.Tools).ThenInclude(t => t.Patterns).Include(p => p.Yarns).ThenInclude(y => y.Patterns).Where(p => p.AuthorId == user.Id).ToListAsync();
        foreach (var pattern in patterns)
        {
            var patternComments = await context.Comments.Where(c => c.CraftObjectId == pattern.Id).ToListAsync();
            foreach (var comment in patternComments)
            {
                context.Comments.Remove(comment);
            }
            var pictures = await context.Pictures.Where(c => c.CraftObjectId == pattern.Id).ToListAsync();
            foreach (var picture in pictures)
            {
                string path = Path.Combine("StaticFiles", picture.Path);
                context.Pictures.Remove(picture);
                File.Delete(path);
            }
            foreach (var tool in pattern.Tools)
            {
                tool.Patterns.Remove(pattern);
            }
            foreach (var yarn in pattern.Yarns)
            {
                yarn.Patterns.Remove(pattern);
            }

            context.Patterns.Remove(pattern!);
            await context.SaveChangesAsync();
        }
        var userComments = await context.Comments.Where(c => c.AuthorId == user.Id).ToListAsync();
        foreach (var comment in userComments)
        {
            context.Comments.Remove(comment);
        }
        var patternUsers = await context.PatternUsers.Where(u => u.UserId == user.Id).ToListAsync();
        foreach (var patternUser in patternUsers)
        {
            context.PatternUsers.Remove(patternUser);
        }
        var toolUsers = await context.ToolUsers.Where(u => u.UserId == user.Id).ToListAsync();
        foreach (var toolUser in toolUsers)
        {
            context.ToolUsers.Remove(toolUser);
        }
        var yarnUsers = await context.YarnUsers.Where(u => u.UserId == user.Id).ToListAsync();
        foreach (var yarnUser in yarnUsers)
        {
            context.YarnUsers.Remove(yarnUser);
        }
        await context.SaveChangesAsync();
    }
}
