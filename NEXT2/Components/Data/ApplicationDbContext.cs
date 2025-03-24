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
        public DbSet<UserAnswer> UserAnswersNew { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<RoleAnswer> RoleAnswers {  get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Result> Results { get; set; }
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
    public int NodeId { get; set; }
}

public class Answer
{
    public int AnswerID { get; set; }
    public int QuestionID { get; set; }
    public string AnswerText { get; set; }
    public int? Path { get; set; }
    public int RoleID { get; set; }
    public int RoleScore { get; set; }

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
    public int? Path1 { get; set; }
    public int? Path2 { get; set; }
    public int? ParentNodeId { get; set; }
}

public class UserAnswer
{
    //[Key]
    public int UserAnswerID { get; set; }
    public int SessionID { get; set; }
    public int AnswerID { get; set; }
    public int QuestionID { get; set; }
    public int NodeID { get; set; }
}

public class Departments
{
    [Key]
    public int DepartmentID { get; set; }
    public string DepartmentName { get; set; }
    public string? DepartmentDesc { get; set; }
    public string? Img { get; set; }
    public int NodeID { get; set; }
}

public class Role
{
    public int RoleID { get; set; }
    public string RoleName { get; set; }
    public string? RoleDesc { get; set; }
    public string? RoleLink {  get; set; }
    public int? FinalNodeID { get; set; }
}

public class RoleAnswer
{
    public int RoleAnswerID { get; set; }
    public int AnswerID { get; set; }
    public int RoleID { get; set; }
    public int RoleScore { get; set; }
}

public class Result
{
    public int ResultID { get; set; }
    public int SessionId { get; set; }
    public int? UserID { get; set; }
    public int Role1ID { get; set; }
    public int Role1Score { get; set; }
    public int Role2ID { get; set; }
    public int Role2Score { get; set; }
    public int Role3ID { get; set; }
    public int Role3Score { get; set; }
}