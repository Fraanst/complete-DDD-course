using System;

namespace Domain.Entities
{
    public abstract class Entity
    {
        public string Id { get; set; }
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