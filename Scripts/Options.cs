using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    Resolution small;
    Resolution large;

    private void Start()
    {
        small.width = 800;
        small.height = 600;

        large.width = 1600;
        large.height = 900;
    }

    public void SmallerResolution()
    {
        Screen.SetResolution(small.width, small.height, false);
    }

    public void LargerResolution()
    {
        Screen.SetResolution(large.width, large.height, false);
    }
}