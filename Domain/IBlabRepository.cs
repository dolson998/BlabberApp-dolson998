namespace Domain;

public interface IBlabRepository : IRepository
{
    IEnumerable<IEntity> GetBlabsByUser(User user);
    IEnumerable<IEntity> GetByDateTime(DateTime Dttm);
}