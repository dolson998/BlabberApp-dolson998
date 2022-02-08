namespace Domain;

public interface IRepository
{
    // CRUD ~ AGED
    public void Add(IEntity entity);
    public void Edit(IEntity entity);
    public void Delete(IEntity entity);
    public IEntity GetByEntityId(Guid Id);
    public IEntity Get(IEntity entity);
    public IEntity[] List();
}
