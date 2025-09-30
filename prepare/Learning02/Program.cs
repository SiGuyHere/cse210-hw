using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job computerScientist = new Job();
        computerScientist._jobTitle = "Computer Scientist";
        computerScientist._company = "Computer Scientist";
        computerScientist._startYear = "Computer Scientist";
        computerScientist._endYear = "Computer Scientist";
        Job biologist = new Job();
        biologist._jobTitle = "Biologist";
        biologist._company = "Biologist";
        biologist._startYear = "Biologist";
        biologist._endYear = "Biologist";
        Resume silasResume = new Resume();
        silasResume._name = "Silas";
        silasResume._jobs.Add(biologist);
        silasResume._jobs.Add(computerScientist);
        silasResume.Display();
    }
}