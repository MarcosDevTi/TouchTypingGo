namespace TouchTypingGo.Application.Interfaces
{
    public interface IHelperService
    {
        string NewCode();
        string CreateLessonWithParagraph(string texto, int numLimite);
    }
}
