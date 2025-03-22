namespace MemoApp.UI
{
    // Platform間共通の設定値を保持するクラス
    public static class UISettings
    {
        // TODO: ファイル読み込みで設定を取得するか？
        private static readonly Color _gray = new(229, 229, 234);

        public static Color StatusBarColor { get; } = _gray;
        public static bool IsDarkMode { get; } = false;
    }
}
