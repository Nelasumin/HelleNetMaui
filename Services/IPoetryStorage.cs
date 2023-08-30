

using HelleNetMaui.Models;

namespace HelleNetMaui.Services;

public interface IPoetryStorage
{
    //初始化数据库 异步业务
    Task InitializeAsync();

    Task SavePeotryAsync(Poetry postry);
    Task<Poetry> GetPoetryAsync(int id);

    Task<IEnumerable<Poetry>> SearchByNameAsync(string name);





}