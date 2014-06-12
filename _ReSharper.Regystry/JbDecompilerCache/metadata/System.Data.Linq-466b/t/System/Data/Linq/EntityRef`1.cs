// Type: System.Data.Linq.EntityRef`1
// Assembly: System.Data.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Data.Linq.dll

using System.Collections.Generic;

namespace System.Data.Linq
{
    public struct EntityRef<TEntity> where TEntity : class
    {
        public EntityRef(TEntity entity);
        public EntityRef(IEnumerable<TEntity> source);
        public EntityRef(EntityRef<TEntity> entityRef);
        public TEntity Entity { get; set; }
        public bool HasLoadedOrAssignedValue { get; }
    }
}
