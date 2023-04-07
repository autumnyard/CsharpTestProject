﻿namespace Serialization
{
    public interface ISerializer
    {
        void Serialize(string path, object value);
        bool Deserialize(string path, out object value);
    }
}