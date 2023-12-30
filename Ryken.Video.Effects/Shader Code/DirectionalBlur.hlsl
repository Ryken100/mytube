#define D2D_INPUT_COUNT 1
#define D2D_INPUT0_SIMPLE

#include "d2d1effecthelpers.hlsli"

float Radius = 2;
float2 Direction = float2(1, 0);
D2D_PS_ENTRY(main)
{
	float4 color = (float4)0;
	float count = 0;
	float mul;
	for (float i = -1; i <= 1; i += 0.25)
	{
		mul = 1 - abs(i);
		color += D2DSampleInputAtOffset(0, normalize(Direction) * Radius * i * 0.5) * mul;
		count += mul;
	}
	return color / count;
}