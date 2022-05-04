//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Rule
{
    [Serializable]
    public class HakoEnvMsg : Message
    {
        public const string k_RosMessageName = "rule_msgs/HakoEnv";
        public override string RosMessageName => k_RosMessageName;

        public ulong simtime;

        public HakoEnvMsg()
        {
            this.simtime = 0;
        }

        public HakoEnvMsg(ulong simtime)
        {
            this.simtime = simtime;
        }

        public static HakoEnvMsg Deserialize(MessageDeserializer deserializer) => new HakoEnvMsg(deserializer);

        private HakoEnvMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.simtime);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.simtime);
        }

        public override string ToString()
        {
            return "HakoEnvMsg: " +
            "\nsimtime: " + simtime.ToString();
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