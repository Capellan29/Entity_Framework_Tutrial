namespace ContosoUniversity.Models
{
    public interface IEnrollment
    {
        Course Course { get; set; }
        int CourseID { get; set; }
        int EnrollmentID { get; set; }
        Grade? Grade { get; set; }
        Student Student { get; set; }
        int PersonID { get; set; }
    }
}