namespace DataStore.Plugins;

using DataStore.Exceptions;
using Domain;
using System;
using System.Collections;
using System.Collections.Generic;

public class InMemRepository : IRepository //, IBlabRepository, IUserRepository
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

    /*public void EditById(Guid Id, IEntity newEntity)
    {
        if (Id == ) throw new NotFoundException("Entity not found.");
    }*/

    public void Edit(IEntity entity)
    {
        // TODO find existing entity in the buffer.
        int index = _buffer.IndexOf(entity);

        // TODO handle not existant entity in buffer.
        if (index == -1) throw new NotFoundException("Entity not found.");

        //TODO validation of obj.
        try
        {
            if (entity.GetType() == typeof(Blab))
            {
                Blab blab = (Blab)entity;
                blab.Validate();
            }

            if (entity.GetType() == typeof(User))
            {
                User user = (User)entity;
                user.Validate();
            }
        }
        catch (NotFoundException)
        {
            throw new NotFoundException("Entity data is invalid.");
        }

        
        this._buffer[index] = entity;
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
    }

    public IEntity Get(IEntity entity)
    {
        // TODO find existing entity in the buffer.
        int index = _buffer.IndexOf(entity);

        // TODO handle not existant entity in buffer.
        if (index == -1) throw new NotFoundException("Entity not found.");

        IEntity? returnEntity = (IEntity)_buffer[index];

        if (returnEntity == null) 
        {
            throw new NotFoundException("Entity not found.");
        }
        return returnEntity;
        // TODO return found entity.

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