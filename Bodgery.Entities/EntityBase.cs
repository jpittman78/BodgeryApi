using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Bodgery.Entities
{
    /// <summary>

    /// Class represents the base class for all WPS Entities

    /// </summary>

    /// <remarks>

    /// 07/17/2018    User    Added XML Comments

    /// </remarks>

    [DebuggerDisplay("{DebugDisplay()}")]

    public abstract class EntityBase<T> : IEntity<T>

    {



        public abstract T Id { get; }

        object IEntity.Id { get { return this.Id; } }



        /// <summary>

        /// Overridden method returns a string representation of this object

        /// </summary>

        /// <returns>String</returns>

        /// <remarks>

        /// 07/17/2018    User    Added XML Comments

        /// </remarks>

        public override string ToString()

        {

            StringBuilder sb = new StringBuilder(0x1000);

            using (StringWriter writer = new StringWriter(sb))

            {

                JsonSerializer js = JsonSerializer.Create();

                js.Serialize(writer, this, this.GetType());

            }

            return sb.ToString();



        }



        /// <summary>

        /// Virtual Method returns display data for Debugging Watch Window

        /// </summary>

        /// <returns>String</returns>

        /// <remarks>

        /// 07/17/2018    User    Added XML Comments

        /// </remarks>

        protected virtual string DebugDisplay()

        {

            return $"{{ Id: {this.Id} }}";

        }

    }
}
