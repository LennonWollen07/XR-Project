using UnityEngine;

public class TextureSwitcher : MonoBehaviour
{
    public Texture[] NewTextures; 
    private int TextureIndex = 0; 
    // Renderer renderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Texture Switcher Started");
        // renderer = GetComponent<Renderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void UpdateMaterialTexture() 
    { 
        print("update texture called"); 
        if (GetComponent<Renderer>() != null && NewTextures != null) 
        { 
            TextureIndex++; 
            if(TextureIndex >= NewTextures.Length) 
            { 
                TextureIndex = 0; 
            } 
            GetComponent<Renderer>().material.mainTexture = NewTextures[TextureIndex]; 
        } 
    } 
}
