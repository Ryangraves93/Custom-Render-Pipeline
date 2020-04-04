using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(menuName = "Render/Custom Render Pipeline")]
public class CustomRenderPipelineAsset : RenderPipelineAsset 

{
    
    protected override RenderPipeline CreatePipeline()
    {
        return new CustomRenderPipeline();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
