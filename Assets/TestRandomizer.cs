using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRandomizer : MonoBehaviour
{
    public List<Material> colours;
    public List<Material> faces;
    public ColourRandomizer randomizer;

    void Start()
    {
        randomizer.Randomize(colours, faces);
    }
}
