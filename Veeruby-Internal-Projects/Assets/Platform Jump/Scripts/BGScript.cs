using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScript : MonoBehaviour
{
    public float scrollSpeed = 0.3f;
    private MeshRenderer mesh_Renderer;
    private static string texture_name = "_MainTex";

    public void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }

    public void Update()
    {
        Scroll();
    }

    private void Scroll()
    {
        Vector2 offset = mesh_Renderer.sharedMaterial.GetTextureOffset(texture_name);
        offset.y += Time.deltaTime * scrollSpeed;
        mesh_Renderer.sharedMaterial.SetTextureOffset(texture_name, offset);
    }
}
