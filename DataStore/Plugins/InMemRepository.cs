namespace DataStore.Plugins;

using Domain;
using System;
using System.Collections;
using System.Collections.Generic;

public class InMemRepository : IRepository
{
    private ArrayList _buf;
    public InMemRepository()
    {
        _buf = new ArrayList();
    }

    public void Add(IEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(IEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Edit(IEntity entity)
    {
        throw new NotImplementedException();
    }

    public IEntity Get(IEntity entity)
    {
        throw new NotImplementedException();
    }

    public IEntity GetByEntityId(Guid Id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IEntity> List()
    {
        throw new NotImplementedException();
    }
}