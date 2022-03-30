using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour 
{


    public Object[] skybox_materials; 
    public Material skybox_material; 

    public void Start  ()
    {
        skybox_materials = Resources.LoadAll("Skybox_Materials", typeof(Material)); 

        // foreach (var m in skybox_materials)
        // {
        //     Debug.Log (m.name); 
        // }
        Debug.Log(skybox_materials.Length + " materials loaded"); 

        skybox_material = (Material)skybox_materials[Random.Range(0,skybox_materials.Length)];
        RenderSettings.skybox = skybox_material; 
        
        Debug.Log("background starting at " + skybox_material.name);
    }

    public void Change ()
    {
        skybox_material = (Material)skybox_materials[Random.Range(0,skybox_materials.Length)];
        RenderSettings.skybox = skybox_material; 

        Debug.Log("background changed to " + skybox_material.name);

    }
}
