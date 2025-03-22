using MemoApp.Domain.Entities;
using MemoApp.Domain.Repositories;

namespace MemoApp.Infrastructure.Fake
{
    public class SettingFake : ISettingRepository
    {
        public SettingEntity GetEntity()
        {
            return new SettingEntity { IsFake = true };
        }
    }
}
