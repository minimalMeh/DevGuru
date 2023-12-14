using System;

namespace DevGuru.Core.Prototype
{
    public abstract class Shape
    {
        protected int x, y;
        protected DateTime dateCreated;
        protected Info info;

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
            dateCreated = DateTime.Now;
            info = new Info(dateCreated.Ticks);
        }

        public Shape(Shape prototype)
        {
            x = prototype.x;
            y = prototype.y;
            dateCreated = prototype.dateCreated;
            info = new Info(prototype.info.Id);
        }

        public abstract Shape Clone();

        protected class Info
        {
            public long Id;
            public Info(long id)
            {
                Id = id;
            }
        }
    }

}
