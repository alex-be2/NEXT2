using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace NEXT2.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options) { }

		public DbSet<Question> QuestionsNew { get; set; }
		public DbSet<Answer> AnswersNew { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Node> NodesNew { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
    }


}
//public class Question
//{
//    public int QuestionID { get; set; }
//    public string QuestionText { get; set; }
//    public int? ParentQuestionID { get; set; }

//    public string? Category { get; set; }
//}

public class Question
{
    public int QuestionID { get; set; }
    public string QuestionText { get; set; }
}

public class Answer
{
    public int AnswerID { get; set; }
    public int QuestionID { get; set; }
    public string AnswerText { get; set; }
    public int Path { get; set; }

}

public class User
{
    public int userID { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Role { get; set; }
    public string? Password { get; set; }
}

public class Node 
{ 
    public int NodeID { get; set; }
    public int Question1ID { get; set; }
    public int Question2ID { get; set; }
    public int Question3ID { get; set; }
    public int Path1 { get; set; }
    public int Path2 { get; set; }
    public int ParentNodeId { get; set; }
}

public class UserAnswer
{
    [Key]
    public int AnswerID { get; set; }
    public int QuestionID { get; set; }
    public int UserID { get; set; }
    public int NodeID { get; set; }
}
