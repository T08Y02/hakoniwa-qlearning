//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Ev3
{
    [Serializable]
    public class Ev3PduColorSensorMsg : Message
    {
        public const string k_RosMessageName = "ev3_msgs/Ev3PduColorSensor";
        public override string RosMessageName => k_RosMessageName;

        public uint color;
        public uint reflect;
        public uint rgb_r;
        public uint rgb_g;
        public uint rgb_b;

        public Ev3PduColorSensorMsg()
        {
            this.color = 0;
            this.reflect = 0;
            this.rgb_r = 0;
            this.rgb_g = 0;
            this.rgb_b = 0;
        }

        public Ev3PduColorSensorMsg(uint color, uint reflect, uint rgb_r, uint rgb_g, uint rgb_b)
        {
            this.color = color;
            this.reflect = reflect;
            this.rgb_r = rgb_r;
            this.rgb_g = rgb_g;
            this.rgb_b = rgb_b;
        }

        public static Ev3PduColorSensorMsg Deserialize(MessageDeserializer deserializer) => new Ev3PduColorSensorMsg(deserializer);

        private Ev3PduColorSensorMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.color);
            deserializer.Read(out this.reflect);
            deserializer.Read(out this.rgb_r);
            deserializer.Read(out this.rgb_g);
            deserializer.Read(out this.rgb_b);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.color);
            serializer.Write(this.reflect);
            serializer.Write(this.rgb_r);
            serializer.Write(this.rgb_g);
            serializer.Write(this.rgb_b);
        }

        public override string ToString()
        {
            return "Ev3PduColorSensorMsg: " +
            "\ncolor: " + color.ToString() +
            "\nreflect: " + reflect.ToString() +
            "\nrgb_r: " + rgb_r.ToString() +
            "\nrgb_g: " + rgb_g.ToString() +
            "\nrgb_b: " + rgb_b.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}