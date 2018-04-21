Shader "Content/Mask" {
	Properties {
        _StencilMask ("Mask Layer", Range(0, 255)) = 2
	}
    SubShader {
        Tags { "RenderType"="Opaque" "Queue"="Geometry"}
        Pass {
            Stencil {
                Ref [_StencilMask]
                Comp always
                Pass replace
            }
            ZWrite Off
            ZTest Always
            Blend SrcAlpha OneMinusSrcAlpha
        
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            struct appdata {
                float4 vertex : POSITION;
            };
            struct v2f {
                float4 pos : SV_POSITION;
            };
            v2f vert(appdata v) {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                return o;
            }
            half4 frag(v2f i) : SV_Target {
                return half4(1,0,0,0);
            }
            ENDCG
        }
    } 
}