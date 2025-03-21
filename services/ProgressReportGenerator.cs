using CIS_106_ASSIGNMENT_2.models;

namespace CIS_106_ASSIGNMENT_2.services
{

    static class ProgressReportGenerator
    {

        public static void GenerateProgressReport(List<Character> characters, List<Level> levels)
        {
            // TODO: Write your code here to generate the progress report.
           foreach(var character in characters){
                Console.WriteLine($"Progress Report for {character.Name}:");
                foreach(var level in levels){
                    Console.WriteLine($"--{level.Name} Power Ups Collected:");
                    foreach(var levelPowerUp in level.PowerUps){
                        bool isCollected = character.PowerUps.Any(characterPowerUp => characterPowerUp.Name == levelPowerUp.Name);
                        Console.WriteLine($"----{levelPowerUp.Name}:[{(isCollected ? "X" : " ")}]");
                    
                    
                    }

                }
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
           }
        }
    }

}