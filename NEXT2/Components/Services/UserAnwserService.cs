using Microsoft.EntityFrameworkCore;
using NEXT2.Data;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NEXT2.Components.Services
{
    public class UserAnwserService(ApplicationDbContext context)
    {
        public async Task<List<UserAnswer>> GetUserAnswersAsync()
        {
            return await context.UserAnswersNew.ToListAsync();
        }

        public async Task<UserAnswer> GetUserAnswerById(int UserAnswerID)
        {
            return await context.UserAnswersNew.FindAsync(UserAnswerID);
        }

        public async Task AddUserAnswer(UserAnswer userAnswer)
        {
            context.UserAnswersNew.Add(userAnswer);
            await context.SaveChangesAsync();
        }

        public async Task UpdateUserAnswer(UserAnswer UserAnswer)
        {
            context.UserAnswersNew.Update(UserAnswer);
            await context.SaveChangesAsync();
        }
    }
}
