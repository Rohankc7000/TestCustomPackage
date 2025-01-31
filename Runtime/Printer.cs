using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Rohan.TestCustomPackage
{
    public class Printer : MonoBehaviour
    {
        public string SanamGeda;

        [ContextMenu("Print")]
        public void Print()
        {
            if (!string.IsNullOrEmpty(SanamGeda))
                Debug.Log(name);
        }
    }

}
