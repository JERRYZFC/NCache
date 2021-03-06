// Copyright (c) 2018 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Alachisoft.NCache.Runtime.Exceptions
{
    /// <summary>
    /// StreamNotFoundException is thrown if a CacheStream is not found in the cache.
    /// </summary>
    /// <remarks>Possible reason for this exception can be either it was not
    /// created or it is removed from the cache.</remarks>
    [Serializable]
    public class StreamNotFoundException :StreamException,ISerializable
    {
         /// <summary>
        /// Default constructor.
        /// </summary>
        public StreamNotFoundException() : base("Stream not found in the cache.") { }
        
        #region ISerializable Members

        /// <summary> 
        /// overloaded constructor, manual serialization. 
        /// </summary>
        protected StreamNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        #endregion
    }
}
