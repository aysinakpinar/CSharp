namespace CSharp.InstanceFieldsQuiz;
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