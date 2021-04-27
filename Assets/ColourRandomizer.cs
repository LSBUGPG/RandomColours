using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourRandomizer : MonoBehaviour
{
    Material RandomFromList(List<Material> select)
    {
        int random = Random.Range(0, select.Count);
        Material material = select[random];
        select.RemoveAt(random);
        return material;
    }

    public void Randomize(List<Material> colours, List<Material> faces)
    {
        List<Material> select = new List<Material>();
        while (select.Count < faces.Count)
        {
            foreach (Material colour in colours)
            {
                select.Add(colour);
                if (select.Count == faces.Count)
                {
                    break;
                }
            }
        }

        for (int i = 0; i < faces.Count; i++)
        {
            faces[i] = RandomFromList(select);
        }
    }
}
