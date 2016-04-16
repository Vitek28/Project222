using System;
using System.Collections;
using UnityEngine;

namespace Extensions
{
    public static class MonoBehaviourExtensions
    {
        /// <summary>
        /// Use this functions for check
        /// editor variales
        /// </summary>
        public static bool Check(this MonoBehaviour mono, string variableName, bool condition, LogType logType)
        {
            if (!condition)
            {
                string message = string.Format("'{0}' has invalid '{1}' value", mono, variableName);
                Log(message, mono, logType);
            }
            return condition;
        }

        private static void Log(string message, MonoBehaviour mono, LogType logType = LogType.Log)
        {
            if (logType == LogType.Log)
                Debug.Log(message, mono);
            else if (logType == LogType.Warning)
                Debug.LogWarning(message, mono);
            else
                Debug.LogError(message, mono);
        }
    }
}
