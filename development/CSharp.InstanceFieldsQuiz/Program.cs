namespace CSharp.InstanceFieldsQuiz;

class Program
{ 
    static void Main(string[] args)
    {
        Quiz quiz = new Quiz("what is the capital of Burkina Faso?", "What is the capital of Bhutan?");
        quiz.getQuestionOne();
        quiz.getQuestionTwo();
    }
}
class Quiz
{
    string questionOne;
    string questionTwo;
    internal Quiz(string questionOne, string questionTwo)
    {
        this.questionOne = questionOne;
        this.questionTwo = questionTwo;
    }

    internal void getQuestionOne()
    {
        Console.WriteLine($"{questionOne}");
    }

    internal void getQuestionTwo()
    {
        Console.WriteLine($"{questionTwo}");
    }
}
