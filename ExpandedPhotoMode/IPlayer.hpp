#pragma once

#include "sdk.hpp"
#include "BaseTypes.h"

namespace Nesae::ExpandedPhotoMode
{
	enum class RotationAxis
	{
		X,
		Y,
		Z
	};

	class IPlayer
	{
		void RotateByXAxis(float amount);
		void RotateByYAxis(float amount);
		void RotateByZAxis(float amount);

		SDK::Player OriginalPlayer;

	public:
		IPlayer();
		~IPlayer();

		SDK::Player* GetInstance();
		void Rotate(RotationAxis axis, float amount);
		void Restore();
	};
}
