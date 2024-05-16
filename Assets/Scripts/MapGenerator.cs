using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour
{

    public int mapWidth;
    public int mapHeight;
    public float noiseScale;

    public bool autoUpdate;

    public void GenerateMap()
    {
        float[,] noiseMap = Noise.GenNoiseMap(mapWidth, mapHeight, noiseScale);


        DisplayMap display = FindObjectOfType<DisplayMap>();
        display.DrawNoiseMap(noiseMap);
    }

}
