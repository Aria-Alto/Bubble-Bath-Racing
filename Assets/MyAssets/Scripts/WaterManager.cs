using System;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class WaterManager : MonoBehaviour
{
    MeshFilter meshFilter;
    public Material waterMaterial;
    private Vector2 matOffset;
    public float matSpeed = -0.0003f;

    private void Awake() {
        meshFilter = GetComponent<MeshFilter>();
    }

    private void Start() {
        matOffset = new Vector2(0, 0);
    }

    private void Update() {
        Vector3[] verticies = meshFilter.mesh.vertices;
        for (int i = 0; i < verticies.Length; i++) {
            // Debug.Log(WaveManager.instance.GetWaveHeight(transform.position.x + verticies[i].x));
            verticies[i].y = WaveManager.instance.GetWaveHeight(transform.position.x + verticies[i].x);
        }
        meshFilter.mesh.vertices = verticies;
        meshFilter.mesh.RecalculateNormals();

        OffsetMaterial();
    }

    private void OffsetMaterial()
    {
        matOffset.y += matSpeed;// * Time.deltaTime;
        // if (matOffset.x > 1f) {
        //     matOffset.x -= 1f;
        // }
        // if (matOffset.x < -1f) {
        //     matOffset.x += 1f;
        // }

        waterMaterial.mainTextureOffset = matOffset;
    }
}
