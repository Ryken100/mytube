#define D2D_REQUIRES_SCENE_POSITION
#define D2D_INPUT_COUNT 1
#define D2D_INPUT0_COMPLEX

#include "d2d1effecthelpers.hlsli"

#define iterations 1.0 / 20.0

float2 Size = (float2)0;
float2 Offset = (float2)0;
float4 Color = float4(1, 1, 1, 1);
float Distance = 0.2;

D2D_PS_ENTRY(main)
{
	float distance;
	float distanceFromPrevious;
	float readableCount = 0;
	float unreadableCount = 0;
	float totalUnreadableDistance = 0;
	float minUnreadableDistance = Distance;
	float totalReadableDistance = 0;
	float count = 0;
	float4 currentColor = D2DSampleInputAtPosition(0, (Offset + (float2(0, 0) * Size)));;
	float4 previousColor = currentColor;
	float4 totalBusiness = 0;
	for (float yi = 0; yi <= 1; yi += iterations)
	{
		for (float xi = 0; xi <= 1; xi += iterations)
		{
			previousColor = currentColor;
			currentColor = D2DSampleInputAtPosition(0, (Offset + (float2(xi, yi) * Size)));
			distance = (abs(currentColor.r - Color.r) + abs(currentColor.g - Color.g) + abs(currentColor.b - Color.b)) / 3;
			distanceFromPrevious += (abs(currentColor.r - previousColor.r) + abs(currentColor.g - previousColor.g) + abs(currentColor.b - previousColor.b)) / 3;
			if (distance > Distance)
			{
				readableCount++;
				totalReadableDistance += distance;
			}
			else 
			{
				unreadableCount++;
				totalUnreadableDistance += distance;
				if (distance < minUnreadableDistance)
					minUnreadableDistance = distance;
			}
			count++;
		}
	}
	return float4(readableCount / count, minUnreadableDistance, distanceFromPrevious / count, 1);
}