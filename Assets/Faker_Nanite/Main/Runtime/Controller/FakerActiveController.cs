using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TK.Nanite.Alpha
{
    public class FakerActiveController : MonoBehaviour
    {
        [SerializeField] public bool m_isUseNanite;

        public static bool isNanite;

        static GameObject NaniteRuntime = null;

        private void Awake()
        {
            Connect();
        }
        [ContextMenu("Connect")]
        void Connect()
        {
            isNanite = m_isUseNanite;
            if (!NaniteRuntime)
            {
                NaniteRuntime = new GameObject("Nanite");
                NaniteRuntime.AddComponent<FakerNaniteRuntime>();
            }
        }

        void Start()
        {
            
        }
        [ContextMenu("DisConnect")]
        private void DisConnect()
        {
            if (NaniteRuntime)
            {
                Destroy(NaniteRuntime);
                NaniteRuntime = null;
                NaniteRuntime.GetComponent<FakerNaniteRuntime>().UnaniteThread.Abort();
            }
        }
    }
}
