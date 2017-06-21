namespace BashSoft
{
    class Launcher
    {
        static void Main(string[] args)
        {
            IOManager.TraverseDirectory(0);
            //IOManager.ChangeCurrentDirectoryRelative("mitko");
            //IOManager.TraverseDirectory(1);
            //StudentsRepository.InitializeData();
            //StudentsRepository.GetAllStudentsFromCourse("Unity");
            //StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");

            //IOManager.CreateDirectoryInCurrentFolder("mitko");
        }
    }
}
