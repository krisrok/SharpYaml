// Copyright (c) 2015 SharpYaml - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
// -------------------------------------------------------------------------------
// SharpYaml is a fork of YamlDotNet https://github.com/aaubry/YamlDotNet
// published with the following license:
// -------------------------------------------------------------------------------
// 
// Copyright (c) 2008, 2009, 2010, 2011, 2012 Antoine Aubry
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
// of the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

namespace SharpYaml.Serialization
{
    /// <summary>
    /// Defines how arrays will be treated during deserialization into an existing object.
    /// </summary>
    public enum ExistingArrayStrategy
    {
        /// <summary>
        /// Always create a new instance.
        /// </summary>
        CreateNew,
        /// <summary>
        /// Fill the existing array, overwriting items. Pre-existing values that do not get overwritten will be kept.
        /// If the existing array does not have sufficient length, a <see cref="YamlException"/> will be thrown.
        /// If the array does not exist yet, an instance will be created and populated.
        /// </summary>
        FillExisting
    }

    /// <summary>
    /// Defines how types inherting from <see cref="ICollection"/> and <see cref="ICollection{T}"/> will be treated during deserialization into an existing object.
    /// </summary>
    public enum ExistingCollectionStrategy
    {
        /// <summary>
        /// Always create a new instance.
        /// </summary>
        CreateNew,
        /// <summary>
        /// Add items to the existing collection.
        /// If the collection does not exist yet, an instance will be created and populated.
        /// </summary>
        AddItems
    }

    /// <summary>
    /// Defines how types inherting from <see cref="IDictionary"/> and <see cref="IDictionary{TKey, TValue}"/> will be treated during deserialization into an existing object.
    /// </summary>
    public enum ExistingDictionaryStrategy
    {
        /// <summary>
        /// Always create a new instance.
        /// </summary>
        CreateNew,
        /// <summary>
        /// Add items to the existing dictionary.
        /// If the key is already present in the existing collection, a <see cref="ArgumentException"/> will be thrown.
        /// If the dictionary does not exist yet, an instance will be created and populated.
        /// </summary>
        AddItems,
        /// <summary>
        /// Add items to the existing dictionary, replacing values with pre-existing keys.
        /// If the dictionary does not exist yet, an instance will be created and populated.
        /// </summary>
        AddOrReplaceItems
    }

    /// <summary>
    /// Settings used to configure population of pre-existing objects, e.g. by using <see cref="Serialization.Serializer.DeserializeInto{T}(string, T)"/> and overloads.
    /// </summary>
    public sealed class DeserializeIntoSettings
	{
        public ExistingArrayStrategy ArrayStrategy { get; set; } = ExistingArrayStrategy.FillExisting;
        public ExistingCollectionStrategy CollectionStrategy { get; set; } = ExistingCollectionStrategy.AddItems;
        public ExistingDictionaryStrategy DictionaryStrategy { get; set; } = ExistingDictionaryStrategy.AddItems;
    }
}
