using System;

namespace Shared.Entities
{
    public abstract class Entity
    {
        public Entity(){
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        private DateTime? createdAt;
        public DateTime CreatedAt
        {
            get { return createdAt ?? DateTime.UtcNow; }
            set { createdAt = value; }
        }
    }
}