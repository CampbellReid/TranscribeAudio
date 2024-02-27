namespace TranscribeAudio.Logic
{
    public class TextCombineService
    {
        public string CombineTexts(IEnumerable<string> texts)
        {
            return string.Join(" ", texts);
        }
    }
}
