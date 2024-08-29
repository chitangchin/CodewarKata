namespace Kata.Kyu7.MyLanguageSkills
{
    public class SolutionClass
    {
        public static IEnumerable<string> MyLanguages(Dictionary<string, int> results)
        {
            var result = new List<string>();
            foreach (var item in results.OrderByDescending(x => x.Value))
            {
                if (item.Value >= 60)
                    result.Add(item.Key);
            }
            return result;
        }
    }
}
