int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\tFinal Score\tExtra Credit Points\n");

foreach (string name in studentNames)
{
    int[] studentScores;

    if (name == "Sophia") studentScores = sophiaScores;
    else if (name == "Andrew") studentScores = andrewScores;
    else if (name == "Emma") studentScores = emmaScores;
    else if (name == "Logan") studentScores = loganScores;
    else if (name == "Becky") studentScores = beckyScores;
    else if (name == "Chris") studentScores = chrisScores;
    else if (name == "Eric") studentScores = ericScores;
    else if (name == "Gregor") studentScores = gregorScores;
    else continue;

    int sumExamScores = 0;
    int sumExtraCredit = 0;
    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments++;

        if (gradedAssignments <= examAssignments)
            sumExamScores += score;
        else
            sumExtraCredit += score;
    }

    decimal examAverage = (decimal)sumExamScores / examAssignments;
    decimal extraCreditPoints = (decimal)(sumExtraCredit * 0.10) / examAssignments;
    decimal finalScore = ((decimal)sumExamScores + (sumExtraCredit * 0.10M)) / examAssignments;

    string letterGrade;
    if (finalScore >= 97) letterGrade = "A+";
    else if (finalScore >= 93) letterGrade = "A";
    else if (finalScore >= 90) letterGrade = "A-";
    else if (finalScore >= 87) letterGrade = "B+";
    else if (finalScore >= 83) letterGrade = "B";
    else if (finalScore >= 80) letterGrade = "B-";
    else if (finalScore >= 77) letterGrade = "C+";
    else if (finalScore >= 73) letterGrade = "C";
    else if (finalScore >= 70) letterGrade = "C-";
    else if (finalScore >= 67) letterGrade = "D+";
    else if (finalScore >= 63) letterGrade = "D";
    else if (finalScore >= 60) letterGrade = "D-";
    else letterGrade = "F";

    Console.WriteLine($"{name,-10}\t{sumExamScores,-14}{examAverage:F1}\t{letterGrade,-8}\t{sumExtraCredit} ({sumExtraCredit * 0.10M:F1} pts)\t{finalScore:F1}\t{extraCreditPoints:F1}");
}

Console.WriteLine("\nPress the Enter key to continue...");
Console.ReadLine();