using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.Rohan.TestCustomPackage
{
    public class Printer : MonoBehaviour
    {
        public string Name;

        public void Print(string name)
        {
            if (!string.IsNullOrEmpty(name))
                Debug.Log(name);
        }
    }

}
