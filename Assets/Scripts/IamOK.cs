using UnityEngine;
using System;
using System.Collections;

public class IamOK : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("I'm OK");

        StartCoroutine(Routine());
        IEnumerator Routine()
        {
            while (true)
            {
                yield return new WaitForSeconds(1f);
                Debug.Log("I'm still OK");
            }
        }
    }
}
