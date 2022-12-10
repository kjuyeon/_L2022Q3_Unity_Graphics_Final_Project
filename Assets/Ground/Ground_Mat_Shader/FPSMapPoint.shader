Shader "My/Lambert/Custom"
{
    /* MiniMap 카메라가 측면을 비춤에 따라 2D Sprite로 표현 할 시 게임 오브젝트가 회전 이동할 때 보이지 않는 경우 존재 
        -> 3D sqare에 쉐이더 적용해서 2D로 보이게 함
    */

    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM

        #pragma surface surf MyCustom noambient

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

        float4 LightingMyCustom(SurfaceOutput s, float3 lightDir, float atten){
            return float4(1, 0, 0, 1);
        }

        ENDCG
    }
    FallBack "Diffuse"
}