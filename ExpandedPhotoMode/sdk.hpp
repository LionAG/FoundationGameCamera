#pragma once

namespace Nesae::ExpandedPhotoMode
{
	// Created with ReClass.NET by KN4CK3R

	struct PhotoModeCameraController
	{
		char pad_0000[592]; //0x0000
		char CameraType; //0x0250
		char pad_0251[95]; //0x0251
		float X; //0x02B0
		float Y; //0x02B4
		float Z; //0x02B8
		char pad_02BC[276]; //0x02BC
		float Roll; //0x03D0
		char pad_03D4[24]; //0x03D4
		float FoV; //0x03EC
	}; //Size: 0x03F0

	struct Player
	{
		char pad_0000[30];
		float XRotation;
		float YRotation;
		float ZRotation;
	};
}