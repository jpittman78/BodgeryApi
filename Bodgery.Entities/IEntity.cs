using System;
using System.Collections.Generic;
using System.Text;

namespace Bodgery.Entities
{
    /// <summary>

    /// Base interface for entity objects

    /// </summary>

    /// <remarks>

    /// 07/17/2018    User    Added XML Comments

    /// </remarks>

    public interface IEntity

    {

        object Id { get; }



    }



    /// <summary>

    /// Generic Base interface for entity objects

    /// </summary>

    /// <remarks>

    /// 07/17/2018    User    Added XML Comments

    /// </remarks>

    public interface IEntity<T> : IEntity

    {

        new T Id { get; }

    }


}
