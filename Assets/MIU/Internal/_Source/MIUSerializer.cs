using MessagePack.Resolvers;
using MessagePack.Unity;
using MIU;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using UnityEngine;

public partial class SerializerHelper
{
    public ByteStream Stream;

    public static byte[] Compress(byte[] data)
    {
        MemoryStream output = new MemoryStream();
        using (DeflateStream dstream = new DeflateStream(output, CompressionMode.Compress))
        {
            dstream.Write(data, 0, data.Length);
        }
        var tmp = output.ToArray();
        return tmp;
    }

    public static void CopyStream(Stream input, Stream output)
    {
        byte[] buffer = new byte[32768];
        int read;
        while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
        {
            output.Write(buffer, 0, read);
        }
    }

    public static byte[] Decompress(byte[] data)
    {
        MemoryStream input = new MemoryStream(data);
        MemoryStream output = new MemoryStream();
        using (DeflateStream dstream = new DeflateStream(input, CompressionMode.Decompress))
        {
            CopyStream(dstream, output);
        }
        var tmp = output.ToArray();
        return tmp;    
    }

    public void Write(Color value)
    {
        Stream.BeginWrite();
        Stream.Position += UnityResolver.Instance.GetFormatter<Vector4>().Serialize(ref Stream.Buffer, Stream.Position, value, UnityResolver.Instance);
        Stream.EndWrite();
    }

    public void Read(ref Color value)
    {
        int size;
        value = UnityResolver.Instance.GetFormatter<Color>().Deserialize(Stream.Buffer, Stream.Position, UnityResolver.Instance, out size);
        Stream.Position += size;
    }

    public void Write(Gradient value)
    {
        Stream.BeginWrite();
        Stream.Position += UnityResolver.Instance.GetFormatter<Gradient>().Serialize(ref Stream.Buffer, Stream.Position, value, UnityResolver.Instance);
        Stream.EndWrite();
    }

    public void Read(ref Gradient value)
    {
        int size;
        value = UnityResolver.Instance.GetFormatter<Gradient>().Deserialize(Stream.Buffer, Stream.Position, UnityResolver.Instance, out size);
        Stream.Position += size;
    }

    public void Write(AnimationCurve value)
    {
        Stream.BeginWrite();
        Stream.Position += UnityResolver.Instance.GetFormatter<AnimationCurve>().Serialize(ref Stream.Buffer, Stream.Position, value, UnityResolver.Instance);
        Stream.EndWrite();
    }

    public void Read(ref AnimationCurve value)
    {
        int size;
        value = UnityResolver.Instance.GetFormatter<AnimationCurve>().Deserialize(Stream.Buffer, Stream.Position, UnityResolver.Instance, out size);
        Stream.Position += size;
    }

    public void Write(Vector3Int value)
    {
        Stream.BeginWrite();
        Stream.Position += new Vector3IntFormatter().Serialize(ref Stream.Buffer, Stream.Position, value, UnityResolver.Instance);
        Stream.EndWrite();
    }

    public void Read(ref Vector3Int value)
    {
        int size;
        value = UnityResolver.Instance.GetFormatter<Vector3Int>().Deserialize(Stream.Buffer, Stream.Position, UnityResolver.Instance, out size);
        Stream.Position += size;
    }


    public void Write(List<string> value)
    {
        Stream.WriteInt32(value.Count);
        foreach (var v in value)
            Stream.WriteString(v);
    }

    public void Read(ref List<string> value)
    {
        value = new List<string>();
        int count;
        Stream.ReadInt32(out count);

        if (value != null)
            value.Clear();
        else
            value = new List<string>();
        
        value.Capacity = count;

        for (var i = 0; i < count; i++)
        {
            string t;
            Stream.ReadString(out t);
            value.Add(t);
        }
    }

    public void Write(List<float> value)
    {
        Stream.BeginWrite();
        Stream.Position += BuiltinResolver.Instance.GetFormatter<List<float>>().Serialize(ref Stream.Buffer, Stream.Position, value, UnityResolver.Instance);
        Stream.EndWrite();
    }

    public void Read(ref List<float> value)
    {
        int size;
        value = BuiltinResolver.Instance.GetFormatter<List<float>>().Deserialize(Stream.Buffer, Stream.Position, UnityResolver.Instance, out size);
        Stream.Position += size;
    }

    public void Write(List<LevelSubMesh> value)
    {
        Stream.WriteInt32(value.Count);
        foreach(var v in value)
            Write(v);
    }

    public void Read(ref List<LevelSubMesh> value)
    {
        int count;
        Stream.ReadInt32(out count);

        if (value != null)
            value.Clear();
        else
            value = new List<LevelSubMesh>();

        value.Capacity = count;

        for(var i=0; i<count; i++)
        {
            LevelSubMesh t = new LevelSubMesh();
            Read(ref t);
            value.Add(t);
        }
    }

    public void Write(List<LevelObject> value)
    {
        Stream.WriteInt32(value.Count);
        foreach (var v in value)
            Write(v);
    }

    public void Read(ref List<LevelObject> value)
    {
        int count;
        Stream.ReadInt32(out count);

        if (value != null)
            value.Clear();
        else
            value = new List<LevelObject>();

        value.Capacity = count;

        for (var i = 0; i < count; i++)
        {
            var t = new LevelObject();
            Read(ref t);
            value.Add(t);
        }

    }

    public void Write(SimpleBuffer value)
    {
        Stream.WriteBytes(value.Stream.GetBuffer(), 0, (int)value.Stream.Length);
    }

    public void Read(ref SimpleBuffer value)
    {
        ArraySegment<byte> seg;
        Stream.ReadBytesSegment(out seg);

        var buff = new byte[seg.Count];
        Array.Copy(seg.Array, seg.Offset, buff, 0, seg.Count);

        value.Stream = new System.IO.MemoryStream(buff, 0, buff.Length, true, true);
    }

    public void Write(Dictionary<string, object> value)
    {
        Stream.WriteInt32(value.Keys.Count);
        foreach(var entry in value)
        {
            Stream.WriteString(entry.Key);

            if (entry.Value is string)
            {
                Stream.WriteByte(1);
                Stream.WriteString((string)entry.Value);
            }
            else if(entry.Value is int)
            {
                Stream.WriteByte(2);
                Stream.WriteInt32((int)entry.Value);
            }
            else if (entry.Value is float)
            {
                Stream.WriteByte(3);
                Stream.WriteSingle((float)entry.Value);
            }
            else if (entry.Value is SimpleBuffer)
            {
                Stream.WriteByte(4);
                Write((SimpleBuffer)entry.Value);
            }
            else if (entry.Value is bool)
            {
                Stream.WriteByte(5);
                Stream.WriteBoolean((bool)entry.Value);
            }
            else
            {
                throw new Exception("Encountered (write) unknown dictionary entry type " + entry.Value.GetType().Name);
            }
        }
    }

    public void Read(ref Dictionary<string, object> value)
    {
        int count;
        Stream.ReadInt32(out count);

        if (value == null)
            value = new Dictionary<string, object>();

        for (var i=0; i<count; i++)
        {
            string key;
            Stream.ReadString(out key);

            byte type;
            Stream.ReadByte(out type);

            switch(type)
            {
                case 1:
                    string strVal;
                    Stream.ReadString(out strVal);
                    value[key] = strVal;
                    break;

                case 2:
                    int intVal;
                    Stream.ReadInt32(out intVal);
                    value[key] = intVal;
                    break;

                case 3:
                    float fVal;
                    Stream.ReadSingle(out fVal);
                    value[key] = fVal;
                    break;

                case 4:
                    SimpleBuffer sb = new SimpleBuffer();
                    Read(ref sb);
                    value[key] = sb;
                    break;

                case 5:
                    bool bVal;
                    Stream.ReadBoolean(out bVal);
                    value[key] = bVal;
                    break;

                default:
                    throw new Exception("Encountered (read) unknown dictionary entry type " + type);
            }
        }
    }

    public sealed class Vector3IntFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::UnityEngine.Vector3Int>
    {

        public int Serialize(ref byte[] bytes, int offset, global::UnityEngine.Vector3Int value, global::MessagePack.IFormatterResolver formatterResolver)
        {

            var startOffset = offset;
            offset += global::MessagePack.MessagePackBinary.WriteFixedArrayHeaderUnsafe(ref bytes, offset, 3);
            offset += MessagePack.MessagePackBinary.WriteInt32(ref bytes, offset, value.x);
            offset += MessagePack.MessagePackBinary.WriteInt32(ref bytes, offset, value.y);
            offset += MessagePack.MessagePackBinary.WriteInt32(ref bytes, offset, value.z);
            return offset - startOffset;
        }

        public global::UnityEngine.Vector3Int Deserialize(byte[] bytes, int offset, global::MessagePack.IFormatterResolver formatterResolver, out int readSize)
        {
            if (global::MessagePack.MessagePackBinary.IsNil(bytes, offset))
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }

            var startOffset = offset;
            var length = global::MessagePack.MessagePackBinary.ReadArrayHeader(bytes, offset, out readSize);
            offset += readSize;

            var __x__ = default(int);
            var __y__ = default(int);
            var __z__ = default(int);

            for (int i = 0; i < length; i++)
            {
                var key = i;

                switch (key)
                {
                    case 0:
                        __x__ = MessagePack.MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 1:
                        __y__ = MessagePack.MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    case 2:
                        __z__ = MessagePack.MessagePackBinary.ReadInt32(bytes, offset, out readSize);
                        break;
                    default:
                        readSize = global::MessagePack.MessagePackBinary.ReadNextBlock(bytes, offset);
                        break;
                }
                offset += readSize;
            }

            readSize = offset - startOffset;

            var ____result = new global::UnityEngine.Vector3Int(__x__, __y__, __z__);
            ____result.x = __x__;
            ____result.y = __y__;
            ____result.z = __z__;
            return ____result;
        }
    }

}
