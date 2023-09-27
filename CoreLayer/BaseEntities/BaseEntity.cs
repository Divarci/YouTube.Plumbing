﻿namespace CoreLayer.BaseEntities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public virtual int Id { get; set; }
        public virtual string CreatedDate { get; set; } = DateTime.Now.ToString("d");
        public virtual string? UpdatedDate { get; set; }
        public virtual byte[] RowVersion { get; set; } = null!;
    }
}
