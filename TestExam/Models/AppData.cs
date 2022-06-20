namespace TestExam.Models
{
    public class AppData
    {
        public Patients patient = null;

        public Laborants laorant = null;

        public const string userFiles = @"..\..\Recourses\Users\";

        public LaboratoryEntities db = new LaboratoryEntities();

        public string getUserFilesPath()
        {

            return userFiles;
        }
    }
}
