namespace MemoApp.UI.Components.Atoms
{
    partial class Text
    {
        private string GetStyle()
        {
            var fontSize = FontSize.HasValue ? $"font-size: {FontSize}px;" : string.Empty;

            return $"{fontSize} {(IsBold ? "font-weight:bold;" : string.Empty)}";
        }
    }
}
