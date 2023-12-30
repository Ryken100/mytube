#define D2D_INPUT_COUNT 2
#define D2D_INPUT0_SIMPLE
#define D2D_INPUT1_SIMPLE

#include "d2d1effecthelpers.hlsli"

float2 PixelScale = float2(1, 1);
// Disclaimer: Not an actual HQ2X shader
D2D_PS_ENTRY(main)
{
	//return (D2DGetInput(0) + D2DGetInput(1)) / 2;
	//return (D2DSampleInputAtOffset(0, float2(0, 0)) + D2DSampleInputAtOffset(1, float2(0, 0))) / 2;
	float4 color = D2DSampleInputAtOffset(0, float2(0, 0));
	float4 origCol = D2DSampleInputAtOffset(1, float2(0, 0));
	float4 currentCol;
	float4 finalCol = color;
	float distance = 1000;
	for (float i = -1; i <= 1; i+=0.1)
	{
		currentCol = D2DSampleInputAtOffset(1, float2(i, 0) * PixelScale);
		float dist = abs(color.r - currentCol.r) + abs(color.g - currentCol.g) + abs(color.b - currentCol.b);
		if (dist < distance)
		{
			distance = dist;
			finalCol = currentCol;
		}
	}
	for (float o = -1; o <= 1; o += 0.1)
	{
		currentCol = D2DSampleInputAtOffset(1, float2(0, o) * PixelScale);
		float dist = abs(color.r - currentCol.r) + abs(color.g - currentCol.g) + abs(color.b - currentCol.b);
		if (dist < distance)
		{
			distance = dist;
			finalCol = currentCol;
		}
	}
	float colAvg = (origCol.r + origCol.g + origCol.b) / 3;
	float finalAvg = (finalCol.r + finalCol.g + finalCol.b) / 3;
	//return finalCol;
	return finalCol * (colAvg / finalAvg);
}