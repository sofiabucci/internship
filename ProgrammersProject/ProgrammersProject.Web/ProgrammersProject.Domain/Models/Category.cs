﻿namespace Project.Domain.Models
{
    public class Category
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; set; }

    }
}
