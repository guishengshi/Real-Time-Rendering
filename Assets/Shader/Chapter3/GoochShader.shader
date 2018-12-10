// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

Shader "Chapter3/GoochShader" {
	Properties {
		_MainTex ("MainTex", 2D) = "white" {}
		_WarmColor ("WarmColor", Color) = (1,1,1,1)
		_CoolColor ("CoolColor", Color) = (1,1,1,1)
	}
	SubShader {
		Tags { "RenderType"="Opaque" }

		Pass {
			CGPROGRAM
			#include "UnityCG.cginc"
			#pragma vertex vert
            #pragma fragment frag

			sampler2D _MainTex;
			fixed4 _WarmColor;
			fixed4 _CoolColor;
			float3 _Light_Pos;

			struct a2v {
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
				float3 normal : NORMAL;
			};

			struct v2f {
				float4 pos : SV_POSITION;
				float2 uv : TEXCOORD0;
				float3 light_vec : TEXCOORD1;
				float3 world_normal : TEXCOORD2;
			};

			v2f vert (a2v v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				float4 vertexInWorld = mul(unity_ObjectToWorld, v.vertex);
				o.light_vec = (_Light_Pos.xyz - vertexInWorld);
				o.world_normal = UnityObjectToWorldNormal(v.normal);
				return o;
			}

			fixed4 frag (v2f i) : Color {
				fixed4 color = tex2D(_MainTex, i.uv);
				float3 light_vec = normalize(i.light_vec);
				float3 world_normal = normalize(i.world_normal);
				float ldn = dot(light_vec, world_normal);
				float mixer = 0.5 * (ldn + 1.0);
				fixed4 res = lerp(_CoolColor, _WarmColor, mixer);
				return res * color;
			}

			ENDCG
		}
	}
	FallBack "Diffuse"
}
