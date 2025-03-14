using MemoApp.Domain.Entities;

namespace MemoApp.Domain
{
    public static class Shared
    {
        public static void Setup(SettingEntity settingEntity)
        {
            IsFake = settingEntity.IsFake;
        }

        public static string SettingFilePath { get; } = "Setting.json";
        public static bool IsFake { get; private set; } = true;
    }
}
