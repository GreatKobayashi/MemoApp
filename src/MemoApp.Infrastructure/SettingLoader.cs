using MemoApp.Domain;
using MemoApp.Domain.Entities;
using System.Text.Json;

namespace MemoApp.Infrastructure
{
    public class SettingLoader
    {
        private readonly IFileSystem _fileSystem;

        public SettingLoader(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public void Load()
        {
            using var stream = _fileSystem.OpenAppPackageFileAsync(Shared.SettingFilePath).Result;
            using var reader = new StreamReader(stream);
            var settingEntity = JsonSerializer.Deserialize<SettingEntity>(reader.ReadToEnd());

            if (settingEntity is null)
            {
                throw new InvalidOperationException("設定ファイルの読み込みに失敗しました。");
            }

            Shared.Setup(settingEntity);
        }
    }
}
