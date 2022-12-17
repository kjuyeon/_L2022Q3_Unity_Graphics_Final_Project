using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PostEffects : MonoBehaviour
{
    Material myMaterial;

    public bool InvertColor;

    public bool Depth;
    public float depth = 1.0f;

    public bool GlayScale;
    public float grayScaleAmount = 1.0f;

    public bool Blend;
    public bool Overlay;
    public Texture2D BlendTexture;
    public float blendOpacity = 1.0f;

    public bool InvertEffect;
    public bool DepthEffect;

    public bool Colors;

    public float brightness = 1.0f;
    public float saturation = 1.0f;
    public float contrast = 1.0f; 

    void Start()
    {

    }

    private void Update()
    {
        brightness = Mathf.Clamp(brightness, 0.0f, 3.0f);
        saturation = Mathf.Clamp(saturation, 0.0f, 3.0f);
        contrast = Mathf.Clamp(contrast, 0.0f, 3.0f);
        grayScaleAmount = Mathf.Clamp(grayScaleAmount, 0.0f, 1.0f);
        blendOpacity = Mathf.Clamp(blendOpacity, 0.0f, 1.0f);
        depth = Mathf.Clamp(depth, 0.0f, 1.0f);
    }


    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (!InvertColor && !Depth && !GlayScale && !Blend && !Overlay && !InvertEffect && !DepthEffect && !Colors)
        {
            Graphics.Blit(source, destination);
        }
        else
        {
            if (InvertColor)
            {
                myMaterial = new Material(Shader.Find("My/PostEffects/DefaultShader"));
                Graphics.Blit(source, destination, myMaterial, 0);
            }

            if (Depth)
            {
                myMaterial = new Material(Shader.Find("My/PostEffects/Depth"));
                myMaterial.SetFloat("_Depth", depth);
                Graphics.Blit(source, destination, myMaterial);
            }

            if (GlayScale)
            {
                myMaterial = new Material(Shader.Find("My/PostEffects/GrayScale"));
                myMaterial.SetFloat("_GrayScaleAmount", grayScaleAmount);
                Graphics.Blit(source, destination, myMaterial);
            }


            if (Blend)
            {
                myMaterial = new Material(Shader.Find("My/PostEffects/Blend"));
                myMaterial.SetTexture("_BlendTex", BlendTexture);
                myMaterial.SetFloat("_Opacity", blendOpacity);
                Graphics.Blit(source, destination, myMaterial);
            }


            if (Overlay)
            {
                myMaterial = new Material(Shader.Find("My/PostEffects/Overlay"));
                myMaterial.SetTexture("_BlendTex", BlendTexture);
                myMaterial.SetFloat("_Opacity", blendOpacity);
                Graphics.Blit(source, destination, myMaterial);
            }

            if (InvertEffect)
            {
                myMaterial = new Material(Shader.Find("My/PostEffects/MultiPass"));
                Graphics.Blit(source, destination, myMaterial, 0);
            }


            if (DepthEffect)
            {
                myMaterial = new Material(Shader.Find("My/PostEffects/MultiPass"));
                Graphics.Blit(source, destination, myMaterial, 1);
            }


            if (Colors)
            {
                myMaterial = new Material(Shader.Find("My/PostEffects/Color"));
                myMaterial.SetFloat("_Brightness", brightness);
                myMaterial.SetFloat("_Saturation", saturation);
                myMaterial.SetFloat("_Contrast", contrast);
                Graphics.Blit(source, destination, myMaterial);
            }
        }
        /*
        if (Default)
        {
            myMaterial = new Material(Shader.Find("My/PostEffects/DefaultShader"));
            Graphics.Blit(source, destination, myMaterial, 0);
        } 

        if (Depth)
        {
            myMaterial = new Material(Shader.Find("My/PostEffects/Depth"));
            myMaterial.SetFloat("_Depth", depth);
            Graphics.Blit(source, destination, myMaterial);
        } 

        if (GlayScale)
        {
            myMaterial = new Material(Shader.Find("My/PostEffects/GrayScale"));
            myMaterial.SetFloat("_GrayScaleAmount", grayScaleAmount);
            Graphics.Blit(source, destination, myMaterial);
        }


        if (Blend)
        {
            myMaterial = new Material(Shader.Find("My/PostEffects/Blend"));
            myMaterial.SetTexture("_BlendTex", BlendTexture);
            myMaterial.SetFloat("_Opacity", blendOpacity);
            Graphics.Blit(source, destination, myMaterial);
        }


        if (Overlay)
        {
            myMaterial = new Material(Shader.Find("My/PostEffects/Overlay"));
            myMaterial.SetTexture("_BlendTex", BlendTexture);
            myMaterial.SetFloat("_Opacity", blendOpacity);
            Graphics.Blit(source, destination, myMaterial);
        }

        if (InvertEffect)
        {
            myMaterial = new Material(Shader.Find("My/PostEffects/MultiPass"));
            Graphics.Blit(source, destination, myMaterial, 0);
        }


        if (DepthEffect)
        {
            myMaterial = new Material(Shader.Find("My/PostEffects/MultiPass"));
            Graphics.Blit(source, destination, myMaterial, 1);
        }


        if (Colors)
        {
            myMaterial = new Material(Shader.Find("My/PostEffects/Color"));
            myMaterial.SetFloat("_Brightness", brightness);
            myMaterial.SetFloat("_Saturation", saturation);
            myMaterial.SetFloat("_Contrast", contrast);
            Graphics.Blit(source, destination, myMaterial);
        }
        */
    }
}
