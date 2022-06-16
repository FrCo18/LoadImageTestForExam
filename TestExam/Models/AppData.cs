namespace TestExam.Models
{
    class AppData
    {
        public Patients patient = null;

        public Laborants laorant = null;

        public const string userFiles = @"..\..\Recourses\Users\";

        public string getUserFilesPath() { 
        
            return userFiles;
        }
    }
}
