using MemoApp.Domain;
using MemoApp.Domain.Entities;
using MemoApp.Domain.Exceptions;
using MemoApp.Domain.Repositories;
using System.Text.Json;

namespace MemoApp.Infrastructure.Json
{
    public class SettingJson : ISettingRepository
    {
        private readonly IFileSystem _fileSystem;

        public SettingJson(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public SettingEntity GetEntity()
        {
            try
            {
                using var stream = _fileSystem.OpenAppPackageFileAsync(Shared.SettingFilePath).Result;
                using var reader = new StreamReader(stream);
                var settingEntity = JsonSerializer.Deserialize<SettingEntity>(reader.ReadToEnd())!;

                return settingEntity;
            }
            catch (Exception e)
            {
                throw new SettingFileException(e);
            }
        }
    }
}
