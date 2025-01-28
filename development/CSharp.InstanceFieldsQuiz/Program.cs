namespace CSharp.InstanceFieldsQuiz;

class Quiz
{
    static void Main(string[] args)
    {
        Quiz quiz = new Quiz("what is the capital of Burkina Faso?", "What is the capital of Bhutan?");
        quiz.getQuestionOne();
        quiz.getQuestionTwo();
    }
    string questionOne;
    string questionTwo;
    Quiz(string questionOne, string questionTwo)
    {
        this.questionOne = questionOne;
        this.questionTwo = questionTwo;
    }

    private void getQuestionOne()
    {
        Console.WriteLine($"{questionOne}");
    }

    private void getQuestionTwo()
    {
        Console.WriteLine($"{questionTwo}");
    }
}
