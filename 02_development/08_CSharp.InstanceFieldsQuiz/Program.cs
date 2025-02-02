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

