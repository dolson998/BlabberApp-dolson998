namespace Domain;

public interface IRepository
{
    // CRUD ~ AGED
    void Add(IEntity entity);
    void Edit(IEntity entity);
    void Delete(IEntity entity);
    IEntity GetByEntityId(Guid Id);
    IEntity Get(IEntity entity);

    IEnumerable <IEntity> List();
}
