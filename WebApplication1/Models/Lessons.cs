namespace WebApplication1.Models;

public class Lessons
{
    public int LessonID { get; set; }
    public int LessonNo { get; set; }
    public string LessonTitle { get; set; }
    public string LessonStatus { get; set; }
    public DateTime LastAccessedDate { get; set; }
    public string CourseID { get; set; }

}