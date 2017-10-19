﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Minotaur
{
    public abstract class EntitySystem<T>
    {
        public BitSet Signature;
        protected T Game;
        private EntityComponentManager Entities;

        public void Attach(T game, EntityComponentManager ecm)
        {
            Game = game;
            Entities = ecm;
        }

        public virtual void Initialize() { }
        public virtual void OnActivate() { }
        public virtual void OnDeactivate() { }
        protected Entity CreateEntity()
        {
            return Entities.CreateEntity();
        }
        protected EntitySet GetEntities()
        {
            return Entities.GetEntities(Signature);
        }
        public virtual void Update(TimeSpan time, Entity entity) { }
        public virtual void Update(TimeSpan time, EntitySet entities) { }
        public virtual void Draw(TimeSpan time, Entity entity) { }
        public virtual void Draw(TimeSpan time, EntitySet entities) { }
    }

    public abstract class GameSystem<T>
    {
        public BitSet Signature;
        protected T Game;
        private EntityComponentManager Entities;

        public void Attach(T game, EntityComponentManager ecm)
        {
            Game = game;
            Entities = ecm;
        }

        public virtual void Initialize() { }
        public virtual void OnActivate() { }
        public virtual void OnDeactivate() { }
        protected Entity CreateEntity()
        {
            return Entities.CreateEntity();
        }
        public EntitySet GetEntities()
        {
            return Entities.GetEntities(Signature);
        }
        public virtual void Update(TimeSpan time) { }
        public virtual void Draw(TimeSpan time) { }
    }
}