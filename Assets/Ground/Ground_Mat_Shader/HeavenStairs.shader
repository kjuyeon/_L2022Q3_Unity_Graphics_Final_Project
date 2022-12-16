Shader "Custom/HeavenStairs"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        cull front

        CGPROGRAM

        #pragma surface surf Nolight vertex:vert noshadow  noambient

        struct Input
        {
            float4 color:COLOR;
        };

        void vert(inout appdata_full v){
            v.vertex.xyz += v.normal.xyz*0.03;
        }

        void surf (Input IN, inout SurfaceOutput o) 
        {
        }

        float4 LightingNolight (SurfaceOutput s, float3 lightDir, float atten){
            return float4(0,0,0,1);
        }
        ENDCG

        cull back        

        CGPROGRAM
        #pragma surface surf Toon noambient 

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }

        float4 LightingToon (SurfaceOutput s, float3 lightDir, float atten){
            float ndotl = dot(s.Normal, lightDir) * 0.5 + 0.5;
            if(ndotl > 0.7){
                ndotl = 0.9;
            }
            else if(ndotl > 0.4){
                ndotl = 0.4;
            }
            else
            {
                ndotl = 0.0;
            }
            return ndotl; 
        }
        ENDCG

        
    }
    FallBack "Diffuse"
}
