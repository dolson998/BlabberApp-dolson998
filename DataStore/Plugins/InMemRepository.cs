namespace DataStore.Plugins;

using DataStore.Exceptions;
using Domain;
using System;
using System.Collections;
using System.Collections.Generic;

public class InMemRepository : IRepository
{
    public Int32? currentIndex { get; private set; }
    private ArrayList _buffer;
    public InMemRepository()
    {
        _buffer = new ArrayList();
    }

    public void Add(IEntity entity)
    {
        currentIndex = _buffer.Add(entity);
    }

    //TODO public void EditById(Guid ID, IEntity entity)
    public void Edit(IEntity entity)
    {
        // TODO find existing entity in the buffer.
        int index = _buffer.IndexOf(entity);

        // TODO handle not existant entity in buffer.
        if (index == -1) throw new NotFoundException("Entity not found.");

        // TODO handle existant entity in buffer.
        
    }

    public void Delete(IEntity entity)
    {
        // TODO find existing entity in the buffer.
        int index = _buffer.IndexOf(entity);

        // TODO handle not existant entity in buffer.
        if (index == -1) throw new NotFoundException("Entity not found.");

        // TODO remove existant entity in buffer.
        _buffer.Remove(entity);
        throw new NotImplementedException();
    }

    public IEntity Get(IEntity entity)
    {
        // TODO find existing entity in the buffer.
        int index = _buffer.IndexOf(entity);

        // TODO handle not existant entity in buffer.
        if (index == -1) throw new NotFoundException("Entity not found.");

        // TODO return found entity.
        throw new NotImplementedException();
    }

    public IEntity GetByEntityId(Guid Id)
    {
        // TODO find existing entity in the buffer.
        int index = _buffer.IndexOf(Id);

        // TODO handle not existant entity in buffer.
        if (index == -1) throw new NotFoundException("Entity not found.");

        // TODO return found entity.
        throw new NotImplementedException();
    }

    public IEntity[] List()
    {
        return (IEntity[])_buffer.ToArray();
    }

    private Int32 SearchById(Guid Id)
    {
        return _buffer.IndexOf(Id);
    }
}