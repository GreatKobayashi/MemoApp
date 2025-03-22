global using Bunit;
global using TestContext = Bunit.TestContext;
using IElement = AngleSharp.Dom.IElement;

namespace TestMemoApp.UI
{
    public static class UITestUtility
    {
        public static Dictionary<string, string> GetStyles(this IElement element)
        {
            var stylesStr = element.GetAttribute("style");

            var styles = new Dictionary<string, string>();
            if (stylesStr == null)
            {
                return styles;
            }

            foreach (var style in stylesStr.Split(';'))
            {
                if (string.IsNullOrEmpty(style))
                {
                    continue;
                }
                var keyValue = style.Split(':').ToList().ConvertAll(x => x.Replace(" ", ""));
                styles.Add(keyValue[0], keyValue[1]);
            }

            return styles;
        }

        public static string GetStyle(this IElement element, string key)
        {
            var styles = element.GetStyles();
            return styles.ContainsKey(key) ? styles[key] : string.Empty;
        }
    }
}
